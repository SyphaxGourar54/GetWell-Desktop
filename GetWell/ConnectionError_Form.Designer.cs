
namespace GetWell
{
    partial class ConnectionError_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionError_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.siticoneElipse1 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_error = new Siticone.UI.WinForms.SiticonePanel();
            this.btn_Refresh = new Siticone.UI.WinForms.SiticoneButton();
            this.refresh_img = new Siticone.UI.WinForms.SiticoneCirclePictureBox();
            this.panel1.SuspendLayout();
            this.panel_error.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refresh_img)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 65);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
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
            this.btn_Exit.Location = new System.Drawing.Point(653, 4);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(49, 48);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // siticoneElipse1
            // 
            this.siticoneElipse1.BorderRadius = 30;
            this.siticoneElipse1.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel_error
            // 
            this.panel_error.BackColor = System.Drawing.Color.Transparent;
            this.panel_error.BackgroundImage = global::GetWell.Properties.Resources.notConnected2;
            this.panel_error.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_error.BorderRadius = 30;
            this.panel_error.Controls.Add(this.btn_Refresh);
            this.panel_error.Controls.Add(this.refresh_img);
            this.panel_error.Location = new System.Drawing.Point(2, 71);
            this.panel_error.Name = "panel_error";
            this.panel_error.ShadowDecoration.Parent = this.panel_error;
            this.panel_error.Size = new System.Drawing.Size(700, 538);
            this.panel_error.TabIndex = 9;
            this.panel_error.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_error_Paint);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Refresh.BorderRadius = 16;
            this.btn_Refresh.BorderThickness = 2;
            this.btn_Refresh.CheckedState.Parent = this.btn_Refresh;
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.CustomImages.Parent = this.btn_Refresh;
            this.btn_Refresh.FillColor = System.Drawing.Color.Transparent;
            this.btn_Refresh.Font = new System.Drawing.Font("Consolas", 13F);
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.HoveredState.Parent = this.btn_Refresh;
            this.btn_Refresh.Location = new System.Drawing.Point(271, 16);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.ShadowDecoration.Parent = this.btn_Refresh;
            this.btn_Refresh.Size = new System.Drawing.Size(159, 34);
            this.btn_Refresh.TabIndex = 0;
            this.btn_Refresh.Text = "Actualiser";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // refresh_img
            // 
            this.refresh_img.Image = global::GetWell.Properties.Resources.login_gif_11;
            this.refresh_img.Location = new System.Drawing.Point(297, 37);
            this.refresh_img.Name = "refresh_img";
            this.refresh_img.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
            this.refresh_img.ShadowDecoration.Parent = this.refresh_img;
            this.refresh_img.Size = new System.Drawing.Size(106, 74);
            this.refresh_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refresh_img.TabIndex = 2;
            this.refresh_img.TabStop = false;
            this.refresh_img.UseTransparentBackground = true;
            this.refresh_img.Visible = false;
            // 
            // ConnectionError_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(704, 609);
            this.Controls.Add(this.panel_error);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConnectionError_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConnectionError_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConnectionError_Form_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel_error.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.refresh_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Exit;
        private Siticone.UI.WinForms.SiticonePanel panel_error;
        private Siticone.UI.WinForms.SiticoneButton btn_Refresh;
        private Siticone.UI.WinForms.SiticoneElipse siticoneElipse1;
        private System.Windows.Forms.Timer timer1;
        private Siticone.UI.WinForms.SiticoneCirclePictureBox refresh_img;
    }
}