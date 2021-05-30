
namespace GetWell
{
    partial class Localisation_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Localisation_Form));
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.siticoneElipse1 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.siticoneElipse2 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.siticoneButton2 = new Siticone.UI.WinForms.SiticoneButton();
            this.buttons_panel = new Siticone.UI.WinForms.SiticoneGradientPanel();
            this.btn_mapZoomIn = new Siticone.UI.WinForms.SiticoneButton();
            this.btn_MyLocation = new Siticone.UI.WinForms.SiticoneButton();
            this.btn_MapPoint = new Siticone.UI.WinForms.SiticoneButton();
            this.btn_mapZoomOut = new Siticone.UI.WinForms.SiticoneButton();
            this.btn_MapNav = new Siticone.UI.WinForms.SiticoneButton();
            this.label2 = new System.Windows.Forms.Label();
            this.siticoneElipse3 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.panel_error = new Siticone.UI.WinForms.SiticonePanel();
            this.btn_Refresh = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneButton3 = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneButton4 = new Siticone.UI.WinForms.SiticoneButton();
            this.panel1.SuspendLayout();
            this.buttons_panel.SuspendLayout();
            this.panel_error.SuspendLayout();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(52, 65);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(897, 538);
            this.map.TabIndex = 1;
            this.map.Zoom = 0D;
            this.map.Load += new System.EventHandler(this.map_Load);
            this.map.Click += new System.EventHandler(this.map_Click);
            this.map.MouseClick += new System.Windows.Forms.MouseEventHandler(this.map_MouseClick);
            // 
            // siticoneElipse1
            // 
            this.siticoneElipse1.BorderRadius = 30;
            this.siticoneElipse1.TargetControl = this.map;
            // 
            // siticoneElipse2
            // 
            this.siticoneElipse2.BorderRadius = 30;
            this.siticoneElipse2.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Minimize);
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.siticoneButton2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 43);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.BackgroundImage = global::GetWell.Properties.Resources.appbar_minus;
            this.btn_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Minimize.FlatAppearance.BorderSize = 0;
            this.btn_Minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.Location = new System.Drawing.Point(923, 7);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(30, 30);
            this.btn_Minimize.TabIndex = 0;
            this.btn_Minimize.UseVisualStyleBackColor = true;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackgroundImage = global::GetWell.Properties.Resources.appbar_close;
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Location = new System.Drawing.Point(959, 7);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(30, 30);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // siticoneButton2
            // 
            this.siticoneButton2.BorderRadius = 80;
            this.siticoneButton2.CheckedState.Parent = this.siticoneButton2;
            this.siticoneButton2.CustomImages.Parent = this.siticoneButton2;
            this.siticoneButton2.FillColor = System.Drawing.Color.Transparent;
            this.siticoneButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneButton2.HoveredState.Parent = this.siticoneButton2;
            this.siticoneButton2.Image = global::GetWell.Properties.Resources.Logo3;
            this.siticoneButton2.ImageSize = new System.Drawing.Size(110, 110);
            this.siticoneButton2.Location = new System.Drawing.Point(12, 10);
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.ShadowDecoration.Parent = this.siticoneButton2;
            this.siticoneButton2.Size = new System.Drawing.Size(99, 24);
            this.siticoneButton2.TabIndex = 0;
            this.siticoneButton2.Click += new System.EventHandler(this.siticoneButton2_Click);
            // 
            // buttons_panel
            // 
            this.buttons_panel.BackColor = System.Drawing.Color.Transparent;
            this.buttons_panel.BorderRadius = 22;
            this.buttons_panel.Controls.Add(this.btn_mapZoomIn);
            this.buttons_panel.Controls.Add(this.btn_MyLocation);
            this.buttons_panel.Controls.Add(this.btn_MapPoint);
            this.buttons_panel.Controls.Add(this.btn_mapZoomOut);
            this.buttons_panel.Controls.Add(this.btn_MapNav);
            this.buttons_panel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(82)))), ((int)(((byte)(241)))));
            this.buttons_panel.FillColor2 = System.Drawing.Color.MediumTurquoise;
            this.buttons_panel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.buttons_panel.Location = new System.Drawing.Point(923, 181);
            this.buttons_panel.Name = "buttons_panel";
            this.buttons_panel.ShadowDecoration.BorderRadius = 22;
            this.buttons_panel.ShadowDecoration.Enabled = true;
            this.buttons_panel.ShadowDecoration.Parent = this.buttons_panel;
            this.buttons_panel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.buttons_panel.Size = new System.Drawing.Size(50, 306);
            this.buttons_panel.TabIndex = 5;
            this.buttons_panel.UseTransparentBackground = true;
            // 
            // btn_mapZoomIn
            // 
            this.btn_mapZoomIn.BorderRadius = 15;
            this.btn_mapZoomIn.CheckedState.Parent = this.btn_mapZoomIn;
            this.btn_mapZoomIn.CustomImages.Parent = this.btn_mapZoomIn;
            this.btn_mapZoomIn.FillColor = System.Drawing.Color.Transparent;
            this.btn_mapZoomIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_mapZoomIn.ForeColor = System.Drawing.Color.White;
            this.btn_mapZoomIn.HoveredState.FillColor = System.Drawing.Color.SteelBlue;
            this.btn_mapZoomIn.HoveredState.Parent = this.btn_mapZoomIn;
            this.btn_mapZoomIn.Image = global::GetWell.Properties.Resources.appbar_magnify_add;
            this.btn_mapZoomIn.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_mapZoomIn.Location = new System.Drawing.Point(10, 29);
            this.btn_mapZoomIn.Name = "btn_mapZoomIn";
            this.btn_mapZoomIn.PressedColor = System.Drawing.Color.RoyalBlue;
            this.btn_mapZoomIn.ShadowDecoration.Parent = this.btn_mapZoomIn;
            this.btn_mapZoomIn.Size = new System.Drawing.Size(30, 30);
            this.btn_mapZoomIn.TabIndex = 0;
            this.btn_mapZoomIn.Click += new System.EventHandler(this.btn_mapZoomIn_Click);
            // 
            // btn_MyLocation
            // 
            this.btn_MyLocation.BorderRadius = 15;
            this.btn_MyLocation.CheckedState.Parent = this.btn_MyLocation;
            this.btn_MyLocation.CustomImages.Parent = this.btn_MyLocation;
            this.btn_MyLocation.FillColor = System.Drawing.Color.Transparent;
            this.btn_MyLocation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_MyLocation.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_MyLocation.HoveredState.Parent = this.btn_MyLocation;
            this.btn_MyLocation.Image = global::GetWell.Properties.Resources.appbar_location_circle;
            this.btn_MyLocation.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_MyLocation.Location = new System.Drawing.Point(10, 245);
            this.btn_MyLocation.Name = "btn_MyLocation";
            this.btn_MyLocation.ShadowDecoration.Parent = this.btn_MyLocation;
            this.btn_MyLocation.Size = new System.Drawing.Size(30, 30);
            this.btn_MyLocation.TabIndex = 2;
            this.btn_MyLocation.Click += new System.EventHandler(this.btn_MyLocation_Click);
            // 
            // btn_MapPoint
            // 
            this.btn_MapPoint.BorderRadius = 15;
            this.btn_MapPoint.CheckedState.Parent = this.btn_MapPoint;
            this.btn_MapPoint.CustomImages.Parent = this.btn_MapPoint;
            this.btn_MapPoint.FillColor = System.Drawing.Color.Transparent;
            this.btn_MapPoint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_MapPoint.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_MapPoint.HoveredState.Parent = this.btn_MapPoint;
            this.btn_MapPoint.Image = global::GetWell.Properties.Resources.appbar_location1;
            this.btn_MapPoint.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_MapPoint.Location = new System.Drawing.Point(10, 191);
            this.btn_MapPoint.Name = "btn_MapPoint";
            this.btn_MapPoint.ShadowDecoration.Parent = this.btn_MapPoint;
            this.btn_MapPoint.Size = new System.Drawing.Size(30, 30);
            this.btn_MapPoint.TabIndex = 2;
            this.btn_MapPoint.Click += new System.EventHandler(this.btn_MapPoint_Click);
            // 
            // btn_mapZoomOut
            // 
            this.btn_mapZoomOut.BorderRadius = 15;
            this.btn_mapZoomOut.CheckedState.Parent = this.btn_mapZoomOut;
            this.btn_mapZoomOut.CustomImages.Parent = this.btn_mapZoomOut;
            this.btn_mapZoomOut.FillColor = System.Drawing.Color.Transparent;
            this.btn_mapZoomOut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_mapZoomOut.ForeColor = System.Drawing.Color.White;
            this.btn_mapZoomOut.HoveredState.FillColor = System.Drawing.Color.SteelBlue;
            this.btn_mapZoomOut.HoveredState.Parent = this.btn_mapZoomOut;
            this.btn_mapZoomOut.Image = global::GetWell.Properties.Resources.appbar_magnify_minus;
            this.btn_mapZoomOut.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_mapZoomOut.Location = new System.Drawing.Point(10, 83);
            this.btn_mapZoomOut.Name = "btn_mapZoomOut";
            this.btn_mapZoomOut.PressedColor = System.Drawing.Color.RoyalBlue;
            this.btn_mapZoomOut.ShadowDecoration.Parent = this.btn_mapZoomOut;
            this.btn_mapZoomOut.Size = new System.Drawing.Size(30, 30);
            this.btn_mapZoomOut.TabIndex = 0;
            this.btn_mapZoomOut.Click += new System.EventHandler(this.btn_mapZoomOut_Click);
            // 
            // btn_MapNav
            // 
            this.btn_MapNav.BorderRadius = 15;
            this.btn_MapNav.CheckedState.Parent = this.btn_MapNav;
            this.btn_MapNav.CustomImages.Parent = this.btn_MapNav;
            this.btn_MapNav.FillColor = System.Drawing.Color.Transparent;
            this.btn_MapNav.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_MapNav.ForeColor = System.Drawing.Color.White;
            this.btn_MapNav.HoveredState.Parent = this.btn_MapNav;
            this.btn_MapNav.Image = global::GetWell.Properties.Resources.appbar_cursor_move;
            this.btn_MapNav.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_MapNav.Location = new System.Drawing.Point(10, 137);
            this.btn_MapNav.Name = "btn_MapNav";
            this.btn_MapNav.ShadowDecoration.Parent = this.btn_MapNav;
            this.btn_MapNav.Size = new System.Drawing.Size(30, 30);
            this.btn_MapNav.TabIndex = 0;
            this.btn_MapNav.Click += new System.EventHandler(this.btn_MapNav_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(376, 620);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tous Droits Réservés © copyright GetWell 2020 ";
            // 
            // siticoneElipse3
            // 
            this.siticoneElipse3.BorderRadius = 30;
            this.siticoneElipse3.TargetControl = this.panel_error;
            // 
            // panel_error
            // 
            this.panel_error.BackColor = System.Drawing.Color.Transparent;
            this.panel_error.BackgroundImage = global::GetWell.Properties.Resources.notConnected2;
            this.panel_error.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_error.BorderRadius = 30;
            this.panel_error.Controls.Add(this.btn_Refresh);
            this.panel_error.Location = new System.Drawing.Point(150, 59);
            this.panel_error.Name = "panel_error";
            this.panel_error.ShadowDecoration.Parent = this.panel_error;
            this.panel_error.Size = new System.Drawing.Size(700, 538);
            this.panel_error.TabIndex = 8;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Refresh.BorderRadius = 24;
            this.btn_Refresh.BorderThickness = 2;
            this.btn_Refresh.CheckedState.Parent = this.btn_Refresh;
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.CustomImages.Parent = this.btn_Refresh;
            this.btn_Refresh.FillColor = System.Drawing.Color.Transparent;
            this.btn_Refresh.Font = new System.Drawing.Font("Consolas", 13F);
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.HoveredState.Parent = this.btn_Refresh;
            this.btn_Refresh.Location = new System.Drawing.Point(260, 46);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.ShadowDecoration.Parent = this.btn_Refresh;
            this.btn_Refresh.Size = new System.Drawing.Size(180, 50);
            this.btn_Refresh.TabIndex = 0;
            this.btn_Refresh.Text = "Actualiser";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // siticoneButton3
            // 
            this.siticoneButton3.BorderRadius = 80;
            this.siticoneButton3.CheckedState.Parent = this.siticoneButton3;
            this.siticoneButton3.CustomImages.Parent = this.siticoneButton3;
            this.siticoneButton3.FillColor = System.Drawing.Color.Transparent;
            this.siticoneButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton3.ForeColor = System.Drawing.Color.White;
            this.siticoneButton3.HoveredState.Parent = this.siticoneButton3;
            this.siticoneButton3.Image = global::GetWell.Properties.Resources.Logo3;
            this.siticoneButton3.ImageSize = new System.Drawing.Size(80, 80);
            this.siticoneButton3.Location = new System.Drawing.Point(445, 637);
            this.siticoneButton3.Name = "siticoneButton3";
            this.siticoneButton3.ShadowDecoration.Parent = this.siticoneButton3;
            this.siticoneButton3.Size = new System.Drawing.Size(111, 24);
            this.siticoneButton3.TabIndex = 6;
            // 
            // siticoneButton4
            // 
            this.siticoneButton4.BorderRadius = 80;
            this.siticoneButton4.CheckedState.Parent = this.siticoneButton4;
            this.siticoneButton4.CustomImages.Parent = this.siticoneButton4;
            this.siticoneButton4.FillColor = System.Drawing.Color.Transparent;
            this.siticoneButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton4.ForeColor = System.Drawing.Color.White;
            this.siticoneButton4.HoveredState.Parent = this.siticoneButton4;
            this.siticoneButton4.Image = global::GetWell.Properties.Resources.Logo3;
            this.siticoneButton4.ImageSize = new System.Drawing.Size(110, 110);
            this.siticoneButton4.Location = new System.Drawing.Point(39, 7);
            this.siticoneButton4.Name = "siticoneButton4";
            this.siticoneButton4.ShadowDecoration.Parent = this.siticoneButton4;
            this.siticoneButton4.Size = new System.Drawing.Size(99, 24);
            this.siticoneButton4.TabIndex = 3;
            // 
            // Localisation_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1001, 673);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.siticoneButton3);
            this.Controls.Add(this.buttons_panel);
            this.Controls.Add(this.map);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.siticoneButton4);
            this.Controls.Add(this.panel_error);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Localisation_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localisation_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Localisation_Form_FormClosing);
            this.Load += new System.EventHandler(this.Localisation_Form_Load);
            this.panel1.ResumeLayout(false);
            this.buttons_panel.ResumeLayout(false);
            this.panel_error.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GMap.NET.WindowsForms.GMapControl map;
        private Siticone.UI.WinForms.SiticoneButton btn_MapPoint;
        private Siticone.UI.WinForms.SiticoneElipse siticoneElipse1;
        private Siticone.UI.WinForms.SiticoneElipse siticoneElipse2;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.Button btn_Exit;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton2;
        private Siticone.UI.WinForms.SiticoneButton btn_mapZoomIn;
        private Siticone.UI.WinForms.SiticoneButton btn_mapZoomOut;
        private Siticone.UI.WinForms.SiticoneButton btn_MapNav;
        private Siticone.UI.WinForms.SiticoneGradientPanel buttons_panel;
        private System.Windows.Forms.Label label2;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton3;
        private Siticone.UI.WinForms.SiticoneButton btn_MyLocation;
        private Siticone.UI.WinForms.SiticonePanel panel_error;
        private Siticone.UI.WinForms.SiticoneButton btn_Refresh;
        private Siticone.UI.WinForms.SiticoneElipse siticoneElipse3;
    }
}