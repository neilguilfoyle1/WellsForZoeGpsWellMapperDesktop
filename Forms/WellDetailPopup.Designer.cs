namespace FYP_Project.Forms
{
    partial class WellDetailPopup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.latitudeLbl = new System.Windows.Forms.Label();
            this.wellImage = new System.Windows.Forms.PictureBox();
            this.longitudeLbl = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.updateWellBtn = new System.Windows.Forms.Button();
            this.editLngBox = new System.Windows.Forms.TextBox();
            this.editLatBox = new System.Windows.Forms.TextBox();
            this.editErrorLbl = new System.Windows.Forms.Label();
            this.editImageBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.wellImage)).BeginInit();
            this.SuspendLayout();
            // 
            // latitudeLbl
            // 
            this.latitudeLbl.AutoSize = true;
            this.latitudeLbl.BackColor = System.Drawing.SystemColors.Control;
            this.latitudeLbl.Location = new System.Drawing.Point(28, 62);
            this.latitudeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.latitudeLbl.Name = "latitudeLbl";
            this.latitudeLbl.Size = new System.Drawing.Size(71, 17);
            this.latitudeLbl.TabIndex = 0;
            this.latitudeLbl.Text = "Longitude";
            // 
            // wellImage
            // 
            this.wellImage.BackColor = System.Drawing.SystemColors.Control;
            this.wellImage.Location = new System.Drawing.Point(16, 161);
            this.wellImage.Margin = new System.Windows.Forms.Padding(4);
            this.wellImage.Name = "wellImage";
            this.wellImage.Size = new System.Drawing.Size(347, 165);
            this.wellImage.TabIndex = 1;
            this.wellImage.TabStop = false;
            // 
            // longitudeLbl
            // 
            this.longitudeLbl.AutoSize = true;
            this.longitudeLbl.BackColor = System.Drawing.SystemColors.Control;
            this.longitudeLbl.Location = new System.Drawing.Point(28, 97);
            this.longitudeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.longitudeLbl.Name = "longitudeLbl";
            this.longitudeLbl.Size = new System.Drawing.Size(59, 17);
            this.longitudeLbl.TabIndex = 2;
            this.longitudeLbl.Text = "Latitude";
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.SystemColors.Control;
            this.closeBtn.Location = new System.Drawing.Point(263, 15);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(100, 28);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.Close_clicked);
            // 
            // updateWellBtn
            // 
            this.updateWellBtn.BackColor = System.Drawing.SystemColors.Control;
            this.updateWellBtn.Location = new System.Drawing.Point(16, 15);
            this.updateWellBtn.Margin = new System.Windows.Forms.Padding(4);
            this.updateWellBtn.Name = "updateWellBtn";
            this.updateWellBtn.Size = new System.Drawing.Size(100, 28);
            this.updateWellBtn.TabIndex = 4;
            this.updateWellBtn.Text = "Edit";
            this.updateWellBtn.UseVisualStyleBackColor = false;
            this.updateWellBtn.Click += new System.EventHandler(this.Edit_Click);
            // 
            // editLngBox
            // 
            this.editLngBox.Enabled = false;
            this.editLngBox.Location = new System.Drawing.Point(116, 58);
            this.editLngBox.Margin = new System.Windows.Forms.Padding(4);
            this.editLngBox.Name = "editLngBox";
            this.editLngBox.Size = new System.Drawing.Size(245, 22);
            this.editLngBox.TabIndex = 5;
            // 
            // editLatBox
            // 
            this.editLatBox.Enabled = false;
            this.editLatBox.Location = new System.Drawing.Point(116, 94);
            this.editLatBox.Margin = new System.Windows.Forms.Padding(4);
            this.editLatBox.Name = "editLatBox";
            this.editLatBox.Size = new System.Drawing.Size(245, 22);
            this.editLatBox.TabIndex = 6;
            // 
            // editErrorLbl
            // 
            this.editErrorLbl.AutoSize = true;
            this.editErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.editErrorLbl.Location = new System.Drawing.Point(149, 132);
            this.editErrorLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.editErrorLbl.Name = "editErrorLbl";
            this.editErrorLbl.Size = new System.Drawing.Size(0, 17);
            this.editErrorLbl.TabIndex = 7;
            // 
            // editImageBtn
            // 
            this.editImageBtn.BackColor = System.Drawing.SystemColors.Control;
            this.editImageBtn.Location = new System.Drawing.Point(32, 126);
            this.editImageBtn.Margin = new System.Windows.Forms.Padding(4);
            this.editImageBtn.Name = "editImageBtn";
            this.editImageBtn.Size = new System.Drawing.Size(109, 28);
            this.editImageBtn.TabIndex = 8;
            this.editImageBtn.Text = "Upload Image";
            this.editImageBtn.UseVisualStyleBackColor = false;
            this.editImageBtn.Visible = false;
            this.editImageBtn.Click += new System.EventHandler(this.editImageBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.SystemColors.Control;
            this.deleteBtn.Location = new System.Drawing.Point(141, 15);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(100, 28);
            this.deleteBtn.TabIndex = 9;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(5, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 327);
            this.panel1.TabIndex = 10;
            // 
            // WellDetailPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(379, 332);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editImageBtn);
            this.Controls.Add(this.editErrorLbl);
            this.Controls.Add(this.editLatBox);
            this.Controls.Add(this.editLngBox);
            this.Controls.Add(this.updateWellBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.longitudeLbl);
            this.Controls.Add(this.wellImage);
            this.Controls.Add(this.latitudeLbl);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WellDetailPopup";
            this.Text = "WellDetailPopup";
            ((System.ComponentModel.ISupportInitialize)(this.wellImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label latitudeLbl;
        private System.Windows.Forms.PictureBox wellImage;
        private System.Windows.Forms.Label longitudeLbl;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button updateWellBtn;
        private System.Windows.Forms.TextBox editLngBox;
        private System.Windows.Forms.TextBox editLatBox;
        private System.Windows.Forms.Label editErrorLbl;
        private System.Windows.Forms.Button editImageBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Panel panel1;


    }
}