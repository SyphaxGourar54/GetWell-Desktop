
namespace GetWell
{
    partial class UpdatePass_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePass_Form));
            this.siticoneElipse1 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_NewPass = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.txt_confNewPass = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.label_error = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_pw2 = new Siticone.UI.WinForms.SiticoneButton();
            this.btn_pw1 = new Siticone.UI.WinForms.SiticoneButton();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.siticoneButton3 = new Siticone.UI.WinForms.SiticoneButton();
            this.btn_save = new Siticone.UI.WinForms.SiticoneButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneElipse1
            // 
            this.siticoneElipse1.BorderRadius = 30;
            this.siticoneElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(83, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(11, 56);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(83, 297);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(11, 56);
            this.panel2.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txt_NewPass
            // 
            this.txt_NewPass.Animated = false;
            this.txt_NewPass.BorderThickness = 2;
            this.txt_NewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_NewPass.DefaultText = "";
            this.txt_NewPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_NewPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_NewPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_NewPass.DisabledState.Parent = this.txt_NewPass;
            this.txt_NewPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_NewPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.txt_NewPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(172)))), ((int)(((byte)(17)))));
            this.txt_NewPass.FocusedState.Parent = this.txt_NewPass;
            this.txt_NewPass.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txt_NewPass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_NewPass.HoveredState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.txt_NewPass.HoveredState.Parent = this.txt_NewPass;
            this.txt_NewPass.Location = new System.Drawing.Point(103, 258);
            this.txt_NewPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_NewPass.Name = "txt_NewPass";
            this.txt_NewPass.PasswordChar = '\0';
            this.txt_NewPass.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_NewPass.PlaceholderText = "";
            this.txt_NewPass.SelectedText = "";
            this.txt_NewPass.ShadowDecoration.Parent = this.txt_NewPass;
            this.txt_NewPass.Size = new System.Drawing.Size(370, 39);
            this.txt_NewPass.TabIndex = 9;
            this.txt_NewPass.TextChanged += new System.EventHandler(this.txt_NewPass_TextChanged);
            // 
            // txt_confNewPass
            // 
            this.txt_confNewPass.Animated = false;
            this.txt_confNewPass.BorderThickness = 2;
            this.txt_confNewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_confNewPass.DefaultText = "";
            this.txt_confNewPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_confNewPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_confNewPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_confNewPass.DisabledState.Parent = this.txt_confNewPass;
            this.txt_confNewPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_confNewPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.txt_confNewPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(172)))), ((int)(((byte)(17)))));
            this.txt_confNewPass.FocusedState.Parent = this.txt_confNewPass;
            this.txt_confNewPass.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txt_confNewPass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_confNewPass.HoveredState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.txt_confNewPass.HoveredState.Parent = this.txt_confNewPass;
            this.txt_confNewPass.Location = new System.Drawing.Point(103, 324);
            this.txt_confNewPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_confNewPass.Name = "txt_confNewPass";
            this.txt_confNewPass.PasswordChar = '\0';
            this.txt_confNewPass.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_confNewPass.PlaceholderText = "";
            this.txt_confNewPass.SelectedText = "";
            this.txt_confNewPass.ShadowDecoration.Parent = this.txt_confNewPass;
            this.txt_confNewPass.Size = new System.Drawing.Size(370, 39);
            this.txt_confNewPass.TabIndex = 9;
            this.txt_confNewPass.TextChanged += new System.EventHandler(this.txt_confNewPass_TextChanged);
            // 
            // label_error
            // 
            this.label_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_error.ForeColor = System.Drawing.Color.Red;
            this.label_error.Image = global::GetWell.Properties.Resources.appbar_alert_small;
            this.label_error.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_error.Location = new System.Drawing.Point(100, 376);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(325, 33);
            this.label_error.TabIndex = 11;
            this.label_error.Text = "Les deux Mots de passe doivent être la même";
            this.label_error.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_error.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GetWell.Properties.Resources.LogoWhiteIcon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(262, 515);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 38);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btn_pw2
            // 
            this.btn_pw2.BackColor = System.Drawing.Color.Transparent;
            this.btn_pw2.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btn_pw2.CheckedState.Parent = this.btn_pw2;
            this.btn_pw2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pw2.CustomImages.Parent = this.btn_pw2;
            this.btn_pw2.FillColor = System.Drawing.Color.Transparent;
            this.btn_pw2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_pw2.ForeColor = System.Drawing.Color.White;
            this.btn_pw2.HoveredState.FillColor = System.Drawing.Color.Transparent;
            this.btn_pw2.HoveredState.Parent = this.btn_pw2;
            this.btn_pw2.Image = global::GetWell.Properties.Resources.appbar1;
            this.btn_pw2.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_pw2.Location = new System.Drawing.Point(441, 333);
            this.btn_pw2.Name = "btn_pw2";
            this.btn_pw2.PressedColor = System.Drawing.Color.Transparent;
            this.btn_pw2.ShadowDecoration.Parent = this.btn_pw2;
            this.btn_pw2.Size = new System.Drawing.Size(37, 20);
            this.btn_pw2.TabIndex = 8;
            this.btn_pw2.UseTransparentBackground = true;
            this.btn_pw2.Click += new System.EventHandler(this.btn_pw2_Click);
            // 
            // btn_pw1
            // 
            this.btn_pw1.BackColor = System.Drawing.Color.Transparent;
            this.btn_pw1.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btn_pw1.CheckedState.Parent = this.btn_pw1;
            this.btn_pw1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pw1.CustomImages.Parent = this.btn_pw1;
            this.btn_pw1.FillColor = System.Drawing.Color.Transparent;
            this.btn_pw1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_pw1.ForeColor = System.Drawing.Color.White;
            this.btn_pw1.HoveredState.FillColor = System.Drawing.Color.Transparent;
            this.btn_pw1.HoveredState.Parent = this.btn_pw1;
            this.btn_pw1.Image = global::GetWell.Properties.Resources.appbar1;
            this.btn_pw1.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_pw1.Location = new System.Drawing.Point(441, 267);
            this.btn_pw1.Name = "btn_pw1";
            this.btn_pw1.PressedColor = System.Drawing.Color.Transparent;
            this.btn_pw1.ShadowDecoration.Parent = this.btn_pw1;
            this.btn_pw1.Size = new System.Drawing.Size(37, 20);
            this.btn_pw1.TabIndex = 8;
            this.btn_pw1.UseTransparentBackground = true;
            this.btn_pw1.Click += new System.EventHandler(this.btn_pw1_Click);
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
            this.btn_Exit.Location = new System.Drawing.Point(530, 12);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(30, 30);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // siticoneButton3
            // 
            this.siticoneButton3.BorderRadius = 22;
            this.siticoneButton3.CheckedState.Parent = this.siticoneButton3;
            this.siticoneButton3.CustomImages.Parent = this.siticoneButton3;
            this.siticoneButton3.FillColor = System.Drawing.Color.Transparent;
            this.siticoneButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton3.ForeColor = System.Drawing.Color.White;
            this.siticoneButton3.HoveredState.Parent = this.siticoneButton3;
            this.siticoneButton3.Image = global::GetWell.Properties.Resources.Logo3;
            this.siticoneButton3.ImageSize = new System.Drawing.Size(120, 120);
            this.siticoneButton3.Location = new System.Drawing.Point(7, 7);
            this.siticoneButton3.Name = "siticoneButton3";
            this.siticoneButton3.ShadowDecoration.Parent = this.siticoneButton3;
            this.siticoneButton3.Size = new System.Drawing.Size(122, 40);
            this.siticoneButton3.TabIndex = 2;
            // 
            // btn_save
            // 
            this.btn_save.CheckedState.Parent = this.btn_save;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.CustomImages.Parent = this.btn_save;
            this.btn_save.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(159)))));
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(139)))), ((int)(((byte)(184)))));
            this.btn_save.HoveredState.Parent = this.btn_save;
            this.btn_save.Image = global::GetWell.Properties.Resources.appbar_check;
            this.btn_save.ImageOffset = new System.Drawing.Point(46, 0);
            this.btn_save.ImageSize = new System.Drawing.Size(34, 34);
            this.btn_save.Location = new System.Drawing.Point(103, 434);
            this.btn_save.Name = "btn_save";
            this.btn_save.ShadowDecoration.Parent = this.btn_save;
            this.btn_save.Size = new System.Drawing.Size(370, 45);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Enregistrer";
            this.btn_save.TextOffset = new System.Drawing.Point(-12, 0);
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::GetWell.Properties.Resources._3094350;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(189, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(198, 197);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(241, 494);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 12;
            this.label1.TabStop = true;
            this.label1.Text = "terms et conditions";
            // 
            // UpdatePass_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(572, 578);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_pw2);
            this.Controls.Add(this.btn_pw1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.siticoneButton3);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_confNewPass);
            this.Controls.Add(this.txt_NewPass);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdatePass_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdatePass_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdatePass_Form_FormClosing);
            this.Load += new System.EventHandler(this.UpdatePass_Form_Load);
            this.Click += new System.EventHandler(this.UpdatePass_Form_Click);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneElipse siticoneElipse1;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton3;
        private System.Windows.Forms.Button btn_Exit;
        private Siticone.UI.WinForms.SiticoneButton btn_save;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private Siticone.UI.WinForms.SiticoneButton btn_pw1;
        private Siticone.UI.WinForms.SiticoneButton btn_pw2;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox txt_confNewPass;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox txt_NewPass;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_error;
        private System.Windows.Forms.LinkLabel label1;
    }
}