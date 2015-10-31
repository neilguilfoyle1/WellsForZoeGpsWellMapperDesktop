using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using System.Reflection;
using FYP_Project.GMapExtensions;
using FYP_Project.Database;
using Npgsql;

namespace FYP_Project.Forms
{
    public partial class MainForm : Form
    {

        private DatabaseLoader databaseLoader; 
        private List<Well> wellsLoaded;
        private Dictionary<Well, WellDetailPopup> loadedPopups;
        private string connString;
        private Well latestWellClicked;

        public bool LoginSuccessful()
        {
            var lf = new LoginForm();
            if (lf.ShowDialog() != DialogResult.OK)
            {
                return false;
            }
            return true;
        }

        private List<TextBox> extraInfoTextboxes;

        //the difference between markers in database and newly created wells before saving
        private GMarkerGoogleType newMarkerStyle;
        private GMarkerGoogleType loadedMarkerStyle;

        // layers
        readonly GMapOverlay top = new GMapOverlay();
        internal readonly GMapOverlay objects = new GMapOverlay("objects");
        internal readonly GMapOverlay routes = new GMapOverlay("routes");

        // marker
        GMapMarker currentMarker;

        // etc
        bool isMouseDown = false;

        public MainForm()
        {
            loadedPopups = new Dictionary<Well, WellDetailPopup>();
            string serverName = "46.22.134.194";
            string port = "5432";
            string userName = "u1300377_wells4z";
            string password = "_Harrington22";
            string databaseName = "WellsForZoe_fyp";
            connString = String.Format("Server={0};Port={1}; User Id={2};Password={3};Database={4};Ssl=True;SslMode=Prefer;Timeout=5;CommandTimeout=5;Pooling=False;",
                    serverName, port, userName, password, databaseName);

            InitializeComponent();

            //save all textboxes used for extra info to list
            extraInfoTextboxes = new List<TextBox> 
            { 
                this.textBoxDistrict,
                this.textBoxArea,
                this.textBoxVillage,
                this.textBoxNumPeople,
                this.textBoxWaterLevel,
                this.textBoxWellDepth,
                this.textBoxDescription,
                this.textBoxValveReplaced
            };

            //Marker Styles
            newMarkerStyle = GMarkerGoogleType.blue_dot;
            loadedMarkerStyle = GMarkerGoogleType.green;



            if (!GMapControl.IsDesignerHosted)
            {
                // set cache mode only if no internet avaible
                if (!NetworkChecker.LastStatus)
                {
                    MainMap.Manager.Mode = AccessMode.CacheOnly;
                    MessageBox.Show("No internet connection available, going to CacheOnly mode.", "GMap.NET - WellForZoe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //create database loader with network status set
                databaseLoader = new DatabaseLoader(connString, NetworkChecker.LastStatus);

                // config map         
                MainMap.MapProvider = GMapProviders.GoogleHybridMap;
                MainMap.MinZoom = 0;
                MainMap.MaxZoom = 24;
                MainMap.Zoom = 9;
                MainMap.MouseWheelZoomType = MouseWheelZoomType.MousePositionWithoutCenter;
                MainMap.CanDragMap = true;
                MainMap.ShowCenter = true;

                // map events
                MainMap.OnPositionChanged += new PositionChanged(MainMap_OnPositionChanged);

                MainMap.OnMapZoomChanged += new MapZoomChanged(MainMap_OnMapZoomChanged);
                MainMap.OnMapTypeChanged += new MapTypeChanged(MainMap_OnMapTypeChanged);

                MainMap.OnMarkerClick += new MarkerClick(MainMap_OnMarkerClick);

                MainMap.Manager.OnTileCacheComplete += new TileCacheComplete(OnTileCacheComplete);
                MainMap.Manager.OnTileCacheStart += new TileCacheStart(OnTileCacheStart);
                MainMap.Manager.OnTileCacheProgress += new TileCacheProgress(OnTileCacheProgress);

                //mouse events
                MainMap.MouseMove += new MouseEventHandler(MainMap_MouseMove);
                MainMap.MouseDown += new MouseEventHandler(MainMap_MouseDown);
                MainMap.MouseUp += new MouseEventHandler(MainMap_MouseUp);
                MainMap.MouseDoubleClick += new MouseEventHandler(MainMap_MouseDoubleClick);

                // get map types
                comboBoxMapType.ValueMember = "Name";
                comboBoxMapType.DataSource = FilterUnusedProviders(GMapProviders.List);
                comboBoxMapType.SelectedItem = MainMap.MapProvider;

                // get position
                textBoxLat.Text = MainMap.Position.Lat.ToString(CultureInfo.InvariantCulture);
                textBoxLng.Text = MainMap.Position.Lng.ToString(CultureInfo.InvariantCulture);

                // get cache modes
                checkBoxUseInfoCache.Checked = MainMap.Manager.UseRouteCache;

                // get zoom  
                trackBar1.Minimum = MainMap.MinZoom * 100;
                trackBar1.Maximum = MainMap.MaxZoom * 100;
                trackBar1.TickFrequency = 50;

#if DEBUG
                checkBoxDebug.Checked = true;
#endif

                //From GMap Demo example, for layout purposes
                ToolStripManager.Renderer = new BSE.Windows.Forms.Office2007Renderer();
                //From GMap Demo example END
                // add custom layers  
                {
                    MainMap.Overlays.Add(objects);
                    MainMap.Overlays.Add(routes);
                    MainMap.Overlays.Add(top);

                    objects.Markers.CollectionChanged += new GMap.NET.ObjectModel.NotifyCollectionChangedEventHandler(Markers_CollectionChanged);
                }

                // set current marker
                currentMarker = new GMarkerGoogle(MainMap.Position, GMarkerGoogleType.arrow);
                currentMarker.IsHitTestVisible = false;
                top.Markers.Add(currentMarker);


                // add my city location for demo
                GeoCoderStatusCode status = GeoCoderStatusCode.Unknow;
                {
                    PointLatLng? pos = GMapProviders.GoogleMap.GetPoint("Malawi, Lulogwa", out status);
                    if (pos != null && status == GeoCoderStatusCode.G_GEO_SUCCESS)
                    {
                        textBoxLat.Text = pos.Value.Lat.ToString();
                        textBoxLng.Text = pos.Value.Lng.ToString();
                        currentMarker.Position = pos.Value;
                        currentMarker.IsVisible = true; //show marker that is to be dragged
                    }
                }

                // add points from database
                wellsLoaded = databaseLoader.ReadWellData();
                foreach (var well in wellsLoaded)
                {
                    AddLocation(well);
                }

                //if there are any wells set the last as selected
                if (wellsLoaded.Count > 0)
                {
                    LatestWellClicked = wellsLoaded[wellsLoaded.Count - 1];
                }

                //zoom to fit all markers
                if (objects.Markers.Count > 0)
                {
                    MainMap.ZoomAndCenterMarkers(null);
                }


                //From GMap Demo example 
                //make sure it can cache
                try
                {
                    GMapOverlay overlay = DeepClone<GMapOverlay>(objects);
                    Debug.WriteLine("ISerializable status for markers: OK");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("ISerializable failure: " + ex.Message);

#if DEBUG
                    if (Debugger.IsAttached)
                    {
                        Debugger.Break();
                    }
#endif
                }
                //From GMap Demo example END
            }
        }





        public Well LatestWellClicked
        {
            get { return latestWellClicked; }
            set 
            { 
                latestWellClicked = value;
                if(latestWellClicked != null)
                {

                    this.textBoxDistrict.Text = latestWellClicked.District;
                    this.textBoxArea.Text = latestWellClicked.Area;
                    this.textBoxVillage.Text = latestWellClicked.Village;
                    this.textBoxNumPeople.Text = latestWellClicked.NumberOfPeople;
                    this.textBoxWaterLevel.Text = latestWellClicked.WaterLevel;
                    this.textBoxWellDepth.Text = latestWellClicked.Depth;
                    this.textBoxDescription.Text = latestWellClicked.Description;
                    this.textBoxValveReplaced.Text = latestWellClicked.ValveReplacedBy;
                    this.valveReplacementDatePicker.Text = latestWellClicked.ValveReplacementDate;
                }
            }
        }

       

        

       
        
      

		//From GMap Demo example
        public T DeepClone<T>(T obj)
        {
            using(var ms = new System.IO.MemoryStream())
            {
                var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                formatter.Serialize(ms, obj);

                ms.Position = 0;

                return (T) formatter.Deserialize(ms);
            }
        }
		//From GMap Demo example END

		//From GMap Demo example 
        void Markers_CollectionChanged(object sender, GMap.NET.ObjectModel.NotifyCollectionChangedEventArgs e)
        {
            textBoxMarkerCount.Text = objects.Markers.Count.ToString();
        }
		//From GMap Demo example END
       
        #region -- some functions --
        //Passing in a reference from well.cs and also passing in all wells info
        void AddLocation(Well well)
        { //mapOverLay.markers. add markers
           objects.Markers.AddDefaultGoogleMarker(well.CalculatedPoint, loadedMarkerStyle, well.WellId);
        }

        //Passing in a list of providers to be returned with just the list we need
        List<GMapProvider> FilterUnusedProviders(List<GMapProvider> inputList)
        {   // Here making a list (mutable) that we want to exclude from the map Provider
            var exclusionList = new List<string>
            {
                "OpenStreet4U",
                "Yahoo",
                "GoogleKorea",
                "Near",
                "Lithuania",
                "Latvia",
                "MapBender",
                "Turkey",
                "CloudMade",
                "Spain",
                "Czech",
                "ArcGIS"
            };
            //new filtered list that will be returned with the new content
            var filteredList = new List<GMapProvider>();
            
            //looping through all the list from map provider
            foreach(var provider in inputList)
            {   
                bool isExcluded = false;
                //Looping through all of list that we want to exclude
                foreach (var excluded in exclusionList)
                {   //(Condition) if list contains exclusionList to be removed
                    if (provider.Name.StartsWith(excluded))
                    {   //if list we are looping through happens to be true, it is excluded, break out of loop
                        isExcluded = true;
                        break;
                    }
                }
                //Anything thats not excluded, add the new provider list to the filterList array
                if (!isExcluded)
                {
                    filteredList.Add(provider);
                }
            }
            //send back the new map provider list required
            return filteredList;
        }

        #endregion

		//From GMap Demo example caching abilities, 3 methods below
        #region -- map events --

        void OnTileCacheComplete()
        {
            Debug.WriteLine("OnTileCacheComplete");
            long size = 0;
            int db = 0;
            try
            {
                DirectoryInfo di = new DirectoryInfo(MainMap.CacheLocation);
                var dbs = di.GetFiles("*.gmdb", SearchOption.AllDirectories);
                foreach(var d in dbs)
                {
                    size += d.Length;
                    db++;
                }
            }
            catch
            {
            }

            if(!IsDisposed)
            {
                MethodInvoker m = delegate
                {
                    textBoxCacheSize.Text = string.Format(CultureInfo.InvariantCulture, "{0} db in {1:00} MB", db, size / (1024.0 * 1024.0));
                    textBoxCacheStatus.Text = "all tiles saved!";
                };

                if (!IsDisposed)
                {
                    try
                    {
                        Invoke(m);
                    }
                    catch(Exception)
                    {
                    }
                }
            }
        }

        void OnTileCacheStart()
        {
            Debug.WriteLine("OnTileCacheStart");

            if(!IsDisposed)
            {
                MethodInvoker m = delegate
                {
                    textBoxCacheStatus.Text = "saving tiles...";
                };
                Invoke(m);
            }
        }

        void OnTileCacheProgress(int left)
        {
            if(!IsDisposed)
            {
                MethodInvoker m = delegate
                {
                    textBoxCacheStatus.Text = left + " tile to save...";
                };
                Invoke(m);
            }
        }
        //From GMap Demo example END
        void MainMap_OnMapTypeChanged(GMapProvider type)
        {
            comboBoxMapType.SelectedItem = type;

            trackBar1.Minimum = MainMap.MinZoom * 100;
            trackBar1.Maximum = MainMap.MaxZoom * 100;
            RefreshOpenPopups();
        }

        void MainMap_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        // add marker
        void MainMap_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (CurrentSelectedMarker != null && CurrentSelectedMarker.Type == newMarkerStyle)
            {
                // Do well detail filling in here 
                // if marker is blue_dot to add to database and change to green
                string longitude = StringToCoordinateConverter.ConvertBackFromLongitude(CurrentSelectedMarker.Position.Lng);
                string latitude = StringToCoordinateConverter.ConvertBackFromLatitude(CurrentSelectedMarker.Position.Lat);

                string majorName = GetMajorAddressNameFromMarker(CurrentSelectedMarker);

                try
                {
                    databaseLoader.AddLocationData(majorName, string.Empty, string.Empty, string.Empty);
                }
                catch (NpgsqlException)
                {
                    databaseLoader.UpdateLocationData(majorName, string.Empty, string.Empty, string.Empty);
                }

                var wellId = databaseLoader.InsertWellData(longitude, latitude, majorName);
                if (wellId == -1)
                {
                    MessageBox.Show("No well added, likely no internet connection\n"+
                        "If application was started with no internet connection\n"+
                        "it was run with read-only mode and must be restarted to login");
                    return;
                }
                var newWell = new Well(wellId.ToString(), longitude, latitude, null);
                CurrentSelectedMarker.Tag = newWell.WellId;
                objects.Markers.Remove(CurrentSelectedMarker);
                objects.Markers.AddDefaultGoogleMarker(CurrentSelectedMarker.Position, loadedMarkerStyle, newWell.WellId);
                CurrentSelectedMarker = objects.Markers[objects.Markers.Count - 1] as GMarkerGoogle;
                wellsLoaded.Add(newWell);
                reloadMap_Click(null, EventArgs.Empty);
            }
            else
            {
                var cc = new GMarkerGoogle(MainMap.FromLocalToLatLng(e.X, e.Y), newMarkerStyle);
                objects.Markers.Add(cc);
                CurrentSelectedMarker = cc;
            }
        }

        private string GetMajorAddressNameFromMarker(GMarkerGoogle marker)
        {
            var address = marker.ToolTipText;
            string majorName = string.Empty;
            if (address != null)
            {
                var indexAfterLastComma = address.LastIndexOf(',') + 1;
                if (indexAfterLastComma > 0)
                {
                    majorName = address.Substring(indexAfterLastComma, address.Length - indexAfterLastComma);
                }
            }
            return majorName;
        }
		
		//From GMap Demo example, but easy to understand how to implement, 
		//same as any other event, demonstrates FromLocalToLatLng method of GMapControl class
        void MainMap_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                isMouseDown = true;

                if(currentMarker.IsVisible)
                {
                    currentMarker.Position = MainMap.FromLocalToLatLng(e.X, e.Y);
#if DEBUG
                    var px = MainMap.MapProvider.Projection.FromLatLngToPixel(currentMarker.Position.Lat, currentMarker.Position.Lng, (int) MainMap.Zoom);
                    var tile = MainMap.MapProvider.Projection.FromPixelToTileXY(px);

                    Debug.WriteLine("MouseDown: geo: " + currentMarker.Position + " | px: " + px + " | tile: " + tile);
#endif
                }
            }
        }
		//From GMap Demo example END

        // move current marker with left holding
        void MainMap_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left && isMouseDown)
            {
                //don't allow moving selected markers (they are supposedly static wells)
                if(CurrentSelectedMarker == null)
                {
                    if(currentMarker.IsVisible)
                    {
                        currentMarker.Position = MainMap.FromLocalToLatLng(e.X, e.Y);
                    }
                }
                //allow moving markers which are blue
                else if (CurrentSelectedMarker.Type == newMarkerStyle)
                {
                    CurrentSelectedMarker.Position = MainMap.FromLocalToLatLng(e.X, e.Y);
                }
                RefreshOpenPopups();
                MainMap.Refresh(); // force instant invalidation (redraw)
            }
        }

        private void RefreshOpenPopups()
        {
            foreach (var wellPair in loadedPopups)
            {
                if (wellPair.Value.Visible == true)
                {
                    wellPair.Value.Location = MainMap.FromLatLngToLocal(wellPair.Key.CalculatedPoint);
                }
            }
        }

        // MapZoomChanged
        void MainMap_OnMapZoomChanged()
        {
            trackBar1.Value = (int) (MainMap.Zoom * 100.0);
            textBoxZoomCurrent.Text = MainMap.Zoom.ToString();
        }
        
        // click on some marker
        void MainMap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            if(e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if(item is GMarkerGoogle)
                {
                    CurrentSelectedMarker = item as GMarkerGoogle;
                    GeoCoderStatusCode status;
                    var pos = GMapProviders.GoogleMap.GetPlacemark(item.Position, out status);
                    if(status == GeoCoderStatusCode.G_GEO_SUCCESS && pos != null)
                    {
                        CurrentSelectedMarker.ToolTipText = pos.Value.Address;
                    }

                    //Display data on hover (image, coords)
                    Well well = null;
                    foreach (var w in wellsLoaded)
                    {
                        if (w.WellId == CurrentSelectedMarker.Tag as string)
                        {
                            well = w;
                            break;
                        }
                    }
                    if(well != null)
                    {
                        var localPoint = MainMap.FromLatLngToLocal(well.CalculatedPoint);
                        var nearestWell = objects.Markers.FindNearestMarker(well.CalculatedPoint, MainMap.MapProvider.Projection.GetDistance);
                        ResetAndAddRoute(well.CalculatedPoint, nearestWell.Position);
                        WellDetailPopup popup = null;
                        if(loadedPopups.TryGetValue(well, out popup))
                        {
                            popup.Location = localPoint;
                            popup.Owner = this;
                            popup.Show(this);
                        }
                        else
                        {
                            popup = new WellDetailPopup(this, this.panelExtra, well, localPoint, connString, (w) => UpdateMarkerPosition(w), (w) => RemoveWellMarker(w));
                            loadedPopups.Add(well, popup);
                            popup.Show(this);
                            popup.PerformAutoScale();
                        }
                        LatestWellClicked = well;
                    }

                    MainMap.Invalidate(false);
                }
            }
        }

        void ResetAndAddRoute(PointLatLng source, PointLatLng destination)
        {
            routes.Clear();
            var route = new GMapRoute(new List<PointLatLng> { source, destination }, "closestWell");
            GMapMarker middleMarker = new GMarkerGoogle(new PointLatLng((source.Lat + destination.Lat) / 2, (source.Lng + destination.Lng) / 2), GMarkerGoogleType.yellow);
            middleMarker.Size = new System.Drawing.Size(0, 0);
            middleMarker.ToolTipMode = MarkerTooltipMode.Always;
            middleMarker.ToolTipText = Math.Round(route.Distance, 2) + "km";
            
            route.IsVisible = true;
            route.Stroke = new Pen(Brushes.Blue);
            route.Stroke.Width = 4;
            route.Stroke.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;

            route.Stroke.StartCap = LineCap.NoAnchor;
            route.Stroke.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            route.Stroke.LineJoin = LineJoin.Round;

            routes.Routes.Add(route);
            routes.Markers.Add(middleMarker);
            MainMap.Refresh();
        }

        void UpdateMarkerPosition(Well well)
        {
            foreach (var marker in objects.Markers)
            {
                if (marker.Tag as string == well.WellId)
                {
                    marker.Position = well.CalculatedPoint;
                    MainMap.ZoomAndCenterMarkers(null);
                    WellDetailPopup popup;
                    if(loadedPopups.TryGetValue(well, out popup))
                    {
                        popup.Location = MainMap.FromLatLngToLocal(well.CalculatedPoint);
                        popup.Refresh();
                    }
                }
            }
            MainMap.Refresh();
        }

        void RemoveWellMarker(Well well)
        {
            GMapMarker markerFound = null;
            foreach (var marker in objects.Markers)
            {
                if (marker.Tag as string == well.WellId)
                {
                    markerFound = marker;
                    break;
                }
            }
            foreach (var marker in objects.Markers)
            {
                Console.WriteLine(marker.Tag);
            }
            if (markerFound != null)
            {
                routes.Clear();
                objects.Markers.Remove(markerFound);
                wellsLoaded.Remove(well);
                MainMap.ZoomAndCenterMarkers(null);
                loadedPopups.Remove(well);
            }
            MainMap.Refresh();
        }

        // current point changed
        void MainMap_OnPositionChanged(PointLatLng point)
        {
            textBoxLatCurrent.Text = point.Lat.ToString(CultureInfo.InvariantCulture);
            textBoxLngCurrent.Text = point.Lng.ToString(CultureInfo.InvariantCulture);

            lastPosition = point;
            lastZoom = (int) MainMap.Zoom;
        }

        PointLatLng lastPosition;
        int lastZoom;
        private GMarkerGoogle CurrentSelectedMarker;

		//From GMap Demo example on how to load map and use expander panels.
        // center markers on start
        private void MainForm_Load(object sender, EventArgs e)
        {
            trackBar1.Value = (int) MainMap.Zoom * 100;
            Activate();
            TopMost = true;
            TopMost = false;
        }
        #endregion

        #region -- menu panels expanders --
        private void xPanderPanel1_Click(object sender, EventArgs e)
        {
            xPanderPanelList1.Expand(xPanderPanelMain);
        }

        private void xPanderPanelCache_Click(object sender, EventArgs e)
        {
            xPanderPanelList1.Expand(xPanderPanelCache);
        }

        private void xPanderPanelInfo_Click(object sender, EventArgs e)
        {
            xPanderPanelList1.Expand(xPanderPanelInfo);
        }
   		//From GMap Demo example END
        #endregion
		
		#region -- ui events --

        // change map type
        private void comboBoxMapType_DropDownClosed(object sender, EventArgs e)
        {
            MainMap.MapProvider = comboBoxMapType.SelectedItem as GMapProvider;
            comboBoxMapType.SelectedItem = MainMap.MapProvider;
        }
        
        // zoom
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            MainMap.Zoom = trackBar1.Value / 100.0;
            RefreshOpenPopups();
        }

        // go to
        private void gotoLocationBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double lat = double.Parse(textBoxLat.Text, CultureInfo.InvariantCulture);
                double lng = double.Parse(textBoxLng.Text, CultureInfo.InvariantCulture);

                MainMap.Position = new PointLatLng(lat, lng);
            }
            catch(Exception ex)
            {
                GeoCoderStatusCode status = MainMap.SetPositionByKeywords(textBoxGeo.Text);
                if (status != GeoCoderStatusCode.G_GEO_SUCCESS)
                {
                    MessageBox.Show(string.Format("incorrect coordinate format: {0} To use location name enter it above and press enter instead", ex.Message));
                }
            }
        }

        private void textBoxLatLng_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                gotoLocationBtn_Click(sender, e);
                e.Handled = true;
            }
        }

        // goto by geocoder
        private void textBoxGeo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((Keys) e.KeyChar == Keys.Enter)
            {
                GeoCoderStatusCode status = MainMap.SetPositionByKeywords(textBoxGeo.Text);
                if(status != GeoCoderStatusCode.G_GEO_SUCCESS)
                {
                    MessageBox.Show("Geocoder can't find: '" + textBoxGeo.Text + "', reason: " + status.ToString());
                }
                e.Handled = true;
            }
        }

        // reload map
        private void reloadMap_Click(object sender, EventArgs e)
        {
            // add points from database
            wellsLoaded = databaseLoader.ReadWellData();
            clearMarkers_Click(null, EventArgs.Empty);
            foreach (var well in wellsLoaded)
            {
                AddLocation(well);
            }
            MainMap.ReloadMap();
        }

		//From GMap Demo example to allow for caching to work
        // cache config
        private void checkBoxUseCache_CheckedChanged(object sender, EventArgs e)
        {
            MainMap.Manager.UseRouteCache = checkBoxUseInfoCache.Checked;
            MainMap.Manager.UseGeocoderCache = checkBoxUseInfoCache.Checked;
            MainMap.Manager.UsePlacemarkCache = checkBoxUseInfoCache.Checked;
            MainMap.Manager.UseDirectionsCache = checkBoxUseInfoCache.Checked;
        }

        // clear cache
        private void clearTimesInCache_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You sure?", "Clear GMap.NET cache?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    MainMap.Manager.PrimaryCache.DeleteOlderThan(DateTime.Now, null);
                    MessageBox.Show("Done. Cache is clear.");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
   		//From GMap Demo example END
        // add marker on current position
        private void AddMarker_Click(object sender, EventArgs e)
        {
            GMarkerGoogle m = new GMarkerGoogle(currentMarker.Position, newMarkerStyle);
            m.ToolTipMode = MarkerTooltipMode.OnMouseOver;

            Placemark? p = null;
            if(checkBoxPlacemarkInfo.Checked)
            {
                GeoCoderStatusCode status;
                var ret = GMapProviders.GoogleMap.GetPlacemark(currentMarker.Position, out status);
                if(status == GeoCoderStatusCode.G_GEO_SUCCESS && ret != null)
                {
                    p = ret;
                }
            }

            if(p != null)
            {
                m.ToolTipText = p.Value.Address;
            }
            else
            {
                m.ToolTipText = currentMarker.Position.ToString();
            }

            objects.Markers.Add(m);
        }

        // clear markers
        private void clearMarkers_Click(object sender, EventArgs e)
        {
            routes.Clear();
            objects.Markers.Clear();
        }
        
        // zoom to max for markers
        private void zoomToMarkers_Click(object sender, EventArgs e)
        {
            MainMap.ZoomAndCenterMarkers("objects");
            RefreshOpenPopups();
        }

		//From GMap Demo example for caching again
        // export map data
        private void cacheExport_Click(object sender, EventArgs e)
        {
            MainMap.ShowExportDialog();
        }

        // import map data
        private void cacheImport_Click(object sender, EventArgs e)
        {
            MainMap.ShowImportDialog();
        }
   		//From GMap Demo example END

        // key-up events
        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            int offset = -22;

            if(e.KeyCode == Keys.Left)
            {
            MainMap.Offset(-offset, 0);
            }
            else if(e.KeyCode == Keys.Right)
            {
            MainMap.Offset(offset, 0);
            }
            else if(e.KeyCode == Keys.Up)
            {
            MainMap.Offset(0, -offset);
            }
            else if(e.KeyCode == Keys.Down)
            {
            MainMap.Offset(0, offset);
            }
            else if(e.KeyCode == Keys.Delete)
            {
                if (CurrentSelectedMarker != null)
                {
                    objects.Markers.Remove(CurrentSelectedMarker);
                    CurrentSelectedMarker = null;
                }
            }
            else if(e.KeyCode == Keys.Escape)
            {
                MainMap.Bearing = 0;
            }
        }

        // key-press events
        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(MainMap.Focused)
            {
                if(e.KeyChar == '+')
                {
                    MainMap.Zoom = ((int) MainMap.Zoom) + 1;
                    RefreshOpenPopups();
                }
                else if(e.KeyChar == '-')
                {
                    MainMap.Zoom = ((int) (MainMap.Zoom + 0.99)) - 1;
                    RefreshOpenPopups();
                }
            }
        }

        private void buttonZoomUp_Click(object sender, EventArgs e)
        {
            MainMap.Zoom = ((int) MainMap.Zoom) + 1;
            RefreshOpenPopups();
        }

        private void buttonZoomDown_Click(object sender, EventArgs e)
        {
            MainMap.Zoom = ((int) (MainMap.Zoom + 0.99)) - 1;
            RefreshOpenPopups();
        }

		//From GMap Demo example for caching features again
        // open disk cache location
        private void openCacheLocation_Click(object sender, EventArgs e)
        {
            try
            {
                string argument = "/select, \"" + MainMap.CacheLocation + "TileDBv5\"";
                System.Diagnostics.Process.Start("explorer.exe", argument);
            }
            catch(Exception ex)
            {
            MessageBox.Show("Failed to open: " + ex.Message, "GMap.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
   		//From GMap Demo example END

        #endregion

        #region -- extra detail about well methods --
        private void extraUpdateBtn_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if(button.Text == "Edit")
            {
                this.extraCancelBtn.Visible = true;
                ToggleExtraDetailFields(false);
                BackupExtraDetailFields(true);
                button.Text = "Save";
            }
            else if(button.Text == "Save")
            {
                if (string.IsNullOrEmpty(textBoxVillage.Text))
                {
                    extraErrorLbl.Text = "Please enter village name";
                    return;
                }

                this.extraCancelBtn.Visible = false;
                ToggleExtraDetailFields(true);

                Well wellEdited = LatestWellClicked;
                if (!TryUpdateWell(wellEdited)) return;

                try
                {
                    try
                    {
                        databaseLoader.AddLocationData(wellEdited.Village, wellEdited.Area, wellEdited.District, wellEdited.NumberOfPeople);
                    }
                    catch (NpgsqlException)
                    {
                        databaseLoader.UpdateLocationData(wellEdited.Village, wellEdited.Area, wellEdited.District, wellEdited.NumberOfPeople);
                    }
                    databaseLoader.UpdateWellData(wellEdited);
                }
                catch (NpgsqlException ex)
                {
                    extraErrorLbl.Text = ex.Message;
                    BackupExtraDetailFields(false);    //restore form backup
                }
                button.Text = "Edit";
                extraErrorLbl.Text = string.Empty;
                extraCancelBtn.Visible = false;
            }
        }

        private void extraCancelBtn_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            TryUpdateWell(LatestWellClicked);
            BackupExtraDetailFields(false);    //reset from backup
            ToggleExtraDetailFields(true);
            button.Visible = false;
            extraUpdateBtn.Text = "Edit";
            extraErrorLbl.Text = string.Empty;
        }

        private void ToggleExtraDetailFields(bool isReadonly)
        {
            foreach (var textBox in extraInfoTextboxes)
            {
                textBox.Enabled = !isReadonly;
            }
            valveReplacementDatePicker.Enabled = !isReadonly;
        }

        private void RefreshExtraDetailFields(bool isReadonly)
        {
            foreach (var textBox in extraInfoTextboxes)
            {
                textBox.Invalidate();
            }
            valveReplacementDatePicker.Invalidate();
        }

        private bool TryUpdateWell(Well well)
        {
            var error = well.UpdateDetail(textBoxDescription.Text == string.Empty ? null : textBoxDescription.Text,
                textBoxWellDepth.Text == string.Empty ? null : textBoxWellDepth.Text,
                textBoxWaterLevel.Text == string.Empty ? null : textBoxWaterLevel.Text,
                textBoxVillage.Text,
                textBoxArea.Text,
                textBoxDistrict.Text,
                textBoxNumPeople.Text == string.Empty ? null : textBoxNumPeople.Text,
                textBoxValveReplaced.Text == string.Empty ? null : textBoxValveReplaced.Text,
                valveReplacementDatePicker.Text == string.Empty ? null : valveReplacementDatePicker.Text
                );
            if (error != null)
            {
                extraErrorLbl.Text = error;
                return false;
            }
            return true;
        }

        private void BackupExtraDetailFields(bool backup)
        {
            foreach (var textBox in extraInfoTextboxes)
            {
                //backup
                if (backup)
                {
                    textBox.Tag = textBox.Text;
                }
                //recover
                else
                {
                    textBox.Text = textBox.Tag.ToString();
                }
            }

            if (backup)
            {
                this.valveReplacementDatePicker.Tag = valveReplacementDatePicker.Text;
            }
            else
            {
                this.valveReplacementDatePicker.Text = valveReplacementDatePicker.Tag as string;
            }

        }
        #endregion
    }
}
