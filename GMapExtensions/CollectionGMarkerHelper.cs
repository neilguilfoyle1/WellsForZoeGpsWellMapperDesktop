using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace FYP_Project.GMapExtensions
{
    public static class CollectionGMarkerHelper
    {
        public static void AddDefaultGoogleMarker(this Collection<GMapMarker> source, PointLatLng? point, GMarkerGoogleType style, object tag = null)
        {
            if (point != null)
            {
                GMarkerGoogle m = new GMarkerGoogle((PointLatLng)point, style);
                m.ToolTip = new GMapRoundedToolTip(m);
                m.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                m.Tag = tag;

                source.Add(m);
            }
        }

        public static GMapMarker FindNearestMarker(this Collection<GMapMarker> source, PointLatLng point, Func<PointLatLng, PointLatLng, double> getDistance)
        {
            GMapMarker nearestMarker = null;
            double smallestDistance = double.PositiveInfinity;
            foreach (var marker in source)
            {
                if (marker.Position != point)
                {
                    var distance = getDistance(marker.Position, point);
                    if (distance < smallestDistance)
                    {
                        smallestDistance = distance;
                        nearestMarker = marker;
                    }
                }
            }

            if(double.IsPositiveInfinity(smallestDistance))
            {
                return null;
            }
            else
            {
                return nearestMarker;
            }
        }
    }
}
