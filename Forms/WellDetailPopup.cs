using GMap.NET;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FYP_Project.GMapExtensions;
using FYP_Project.Database;

namespace FYP_Project.Forms
{
    public partial class WellDetailPopup : Form
    {
        private string connectionString;
        private Well well;
        private string lngEditBackup;
        private string latEditBackup;
        private Image imageEditBackup;
        private Action<Well> updateMarkerPositionAction;
        private Action<Well> deleteMarkerAction;
        private Image latestImageSelected;
        private BSE.Windows.Forms.Panel leftPanel;

        private GPoint location;
        public new GPoint Location
        {
            get
            {
                return location;
            }
            set
            {
                //convert location from map api to location for Form popup to be above where it was clicked
                location = value;
                base.Location = new Point(
                    Owner.Location.X + (int)value.X + leftPanel.Size.Width + 5 - this.Size.Width / 2,
                    Owner.Location.Y + (int)value.Y - this.Size.Height - 5);
            }
        }

        public WellDetailPopup(Form parent, BSE.Windows.Forms.Panel leftPanel, Well well, GPoint markerLocationOnParent, string dataConnString, Action<Well> updateMarkerPosition, Action<Well> deleteMarker)
        {
            this.FormClosing += Close_clicked;
            this.leftPanel = leftPanel;
            deleteMarkerAction = deleteMarker;
            updateMarkerPositionAction = updateMarkerPosition;
            connectionString = dataConnString;
            Owner = parent;
            StartPosition = FormStartPosition.Manual;
            Location = markerLocationOnParent;

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            InitializeComponent();

            this.well = well;
            editLngBox.Text = well.Latitude;
            editLatBox.Text = well.Longitude;
            imageEditBackup = well.WellImage;
            wellImage.Image = well.WellImage;
            wellImage.SizeMode = PictureBoxSizeMode.Zoom;
        }

        public new void Show(IWin32Window owner)
        {
            if(!Visible) base.Show(owner);
        }

        private void Close_clicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button == null || button.Text == "Close")
            {
                editErrorLbl.Text = string.Empty;
                this.Hide();
            }
            else if (button.Text == "Cancel")
            {
                editLngBox.Enabled = false;
                editLatBox.Enabled = false;
                editImageBtn.Visible = false;
                updateWellBtn.Text = "Edit";
                button.Text = "Close";
                RestoreFromBackup();
            }
            else
            {
                throw new NotSupportedException("Button can only be Close or Cancel");
            }
            
            //this event is called if parent is losing too, therefore we want 
            //to only cancel when popup is closed
            //not when main form is closed such as FormOwnerClosing, we don't want to cancel
            // any of system shutdown events are raised either
            var cancelArgs = e as FormClosingEventArgs;
            if (cancelArgs != null && cancelArgs.CloseReason == CloseReason.UserClosing)
            {
                cancelArgs.Cancel = true;
            }
        }

        private void RestoreFromBackup()
        {
            well.UpdateCoordinates(lngEditBackup, latEditBackup);
            well.UpdateImage(imageEditBackup);
            editLatBox.Text = lngEditBackup;
            editLngBox.Text = latEditBackup;
            wellImage.Image = imageEditBackup;
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            editErrorLbl.Text = string.Empty;
            var button = sender as Button;
            if (button.Text == "Edit")
            {
                latEditBackup = editLngBox.Text;
                lngEditBackup = editLatBox.Text;
                //open edit window or better allow editing in same open space
                //let browse new image
                editLngBox.Enabled = true;
                editLatBox.Enabled = true;
                editImageBtn.Visible = true;
                button.Text = "Save";
                closeBtn.Text = "Cancel";
            }
            else if (button.Text == "Save")
            {
                if (string.IsNullOrWhiteSpace(editLngBox.Text)) editErrorLbl.Text = "Latitude cannot be empty";
                else if (string.IsNullOrWhiteSpace(editLatBox.Text)) editErrorLbl.Text = "Longitude cannot be empty";
                else
                {
                    editLngBox.Enabled = false;
                    editLatBox.Enabled = false;
                    editImageBtn.Visible = false;
                    try
                    {
                        var testPoint = StringToCoordinateConverter.ConvertToCoordinate(editLngBox.Text, editLatBox.Text);
                    }
                    catch (ArgumentException)
                    {
                        editErrorLbl.Text = "Lat/Long not in L DD MM.MMM";
                        editLngBox.Enabled = true;
                        editLatBox.Enabled = true;
                        editImageBtn.Visible = true;
                        return;
                    }

                    //send all to database
                    var db = new DatabaseLoader(connectionString, NetworkChecker.LastStatus);
                    well.UpdateCoordinates(editLatBox.Text, editLngBox.Text);
                    try
                    {
                        db.UpdateWellData(well);
                    }
                    catch (NpgsqlException ex)
                    {
                        editErrorLbl.Text = ex.Message;
                        RestoreFromBackup();
                    }
                    updateMarkerPositionAction(well);
                    button.Text = "Edit";
                    closeBtn.Text = "Close";
                }
            }
            else
            {
                throw new NotSupportedException("Button can only be Edit or Save");
            }
        }

        private void editImageBtn_Click(object sender, EventArgs e)
        {
            editErrorLbl.Text = string.Empty;
            var fileSelection = new OpenFileDialog();
            fileSelection.CheckFileExists = true;
            fileSelection.Multiselect = false;
            fileSelection.Title = "Select well image";

            if (fileSelection.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    imageEditBackup = well.WellImage;
                    latestImageSelected = Image.FromFile(fileSelection.FileName);
                    well.UpdateImage(latestImageSelected);
                    wellImage.Image = latestImageSelected;
                }
                catch (FileNotFoundException)
                {
                    editErrorLbl.Text = "No such file exists";
                }
                catch (ArgumentException ex)
                {
                    editErrorLbl.Text = ex.Message;
                }
                catch (OutOfMemoryException)
                {
                    editErrorLbl.Text = "Unsupported image";
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var warning = MessageBox.Show(
                this, 
                "Are you sure you want to delete well?\n This action cannot be undone.", 
                "Deleting Well", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Exclamation, 
                MessageBoxDefaultButton.Button2);

            if (warning == DialogResult.Yes)
            {
                var db = new DatabaseLoader(connectionString, NetworkChecker.LastStatus);
                try
                {
                    db.DeleteWell(well);
                    deleteMarkerAction(well);
                    this.Close();
                }
                catch (NpgsqlException ex)
                {
                    editErrorLbl.Text = ex.Message;
                }
            }
        }
    }
}
