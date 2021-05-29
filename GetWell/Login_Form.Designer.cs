
namespace GetWell
{
    partial class Login_Form
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
            this.siticoneElipse1 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.btn_login = new Siticone.UI.WinForms.SiticoneButton();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.IsLoggedTimer = new System.Windows.Forms.Timer(this.components);
            this.siticoneButton1 = new Siticone.UI.WinForms.SiticoneButton();
            this.label_error = new System.Windows.Forms.Label();
            this.btn_close = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneButton4 = new Siticone.UI.WinForms.SiticoneButton();
            this.txt_Password = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.txt_UserName = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneButton3 = new Siticone.UI.WinForms.SiticoneButton();
            this.siticonePictureBox1 = new Siticone.UI.WinForms.SiticonePictureBox();
            this.siticonePictureBox3 = new Siticone.UI.WinForms.SiticonePictureBox();
            this.siticonePictureBox2 = new Siticone.UI.WinForms.SiticonePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneElipse1
            // 
            this.siticoneElipse1.BorderRadius = 20;
            this.siticoneElipse1.TargetControl = this;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.BorderRadius = 20;
            this.btn_login.CheckedState.Parent = this.btn_login;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.CustomImages.Parent = this.btn_login;
            this.btn_login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(159)))));
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(139)))), ((int)(((byte)(184)))));
            this.btn_login.HoveredState.Parent = this.btn_login;
            this.btn_login.Location = new System.Drawing.Point(170, 555);
            this.btn_login.Name = "btn_login";
            this.btn_login.ShadowDecoration.Parent = this.btn_login;
            this.btn_login.Size = new System.Drawing.Size(161, 40);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "L O G I N";
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(126, 655);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tous Droits Réservés © copyright GetWell 2020 ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // IsLoggedTimer
            // 
            this.IsLoggedTimer.Enabled = true;
            this.IsLoggedTimer.Interval = 5000;
            this.IsLoggedTimer.Tick += new System.EventHandler(this.IsLoggedTimer_Tick);
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
            this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
            this.siticoneButton1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.HoveredState.FillColor = System.Drawing.Color.Transparent;
            this.siticoneButton1.HoveredState.Parent = this.siticoneButton1;
            this.siticoneButton1.Location = new System.Drawing.Point(4, 3);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(131, 45);
            this.siticoneButton1.TabIndex = 7;
            this.siticoneButton1.Text = "GetWell - Desktop";
            this.siticoneButton1.UseTransparentBackground = true;
            // 
            // label_error
            // 
            this.label_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_error.Location = new System.Drawing.Point(110, 509);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(283, 31);
            this.label_error.TabIndex = 4;
            this.label_error.Text = "label1";
            this.label_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_error.Visible = false;
            this.label_error.Click += new System.EventHandler(this.label_error_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BorderRadius = 18;
            this.btn_close.CheckedState.Parent = this.btn_close;
            this.btn_close.CustomImages.Parent = this.btn_close;
            this.btn_close.FillColor = System.Drawing.Color.Transparent;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.HoveredState.Parent = this.btn_close;
            this.btn_close.Image = global::GetWell.Properties.Resources.appbar3;
            this.btn_close.ImageOffset = new System.Drawing.Point(1, 0);
            this.btn_close.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_close.Location = new System.Drawing.Point(457, 7);
            this.btn_close.Name = "btn_close";
            this.btn_close.ShadowDecoration.Parent = this.btn_close;
            this.btn_close.Size = new System.Drawing.Size(36, 36);
            this.btn_close.TabIndex = 6;
            this.btn_close.UseTransparentBackground = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // siticoneButton4
            // 
            this.siticoneButton4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneButton4.BorderRadius = 80;
            this.siticoneButton4.CheckedState.Parent = this.siticoneButton4;
            this.siticoneButton4.CustomImages.Parent = this.siticoneButton4;
            this.siticoneButton4.FillColor = System.Drawing.Color.Transparent;
            this.siticoneButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton4.ForeColor = System.Drawing.Color.White;
            this.siticoneButton4.HoveredState.Parent = this.siticoneButton4;
            this.siticoneButton4.Image = global::GetWell.Properties.Resources.LogoInline;
            this.siticoneButton4.ImageSize = new System.Drawing.Size(180, 180);
            this.siticoneButton4.Location = new System.Drawing.Point(157, 86);
            this.siticoneButton4.Name = "siticoneButton4";
            this.siticoneButton4.ShadowDecoration.Parent = this.siticoneButton4;
            this.siticoneButton4.Size = new System.Drawing.Size(186, 42);
            this.siticoneButton4.TabIndex = 0;
            this.siticoneButton4.UseTransparentBackground = true;
            this.siticoneButton4.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.Animated = false;
            this.txt_Password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Password.DefaultText = "";
            this.txt_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Password.DisabledState.Parent = this.txt_Password;
            this.txt_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Password.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.txt_Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(74)))), ((int)(((byte)(17)))));
            this.txt_Password.FocusedState.Parent = this.txt_Password;
            this.txt_Password.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txt_Password.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Password.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Password.HoveredState.Parent = this.txt_Password;
            this.txt_Password.IconLeft = global::GetWell.Properties.Resources.password2;
            this.txt_Password.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txt_Password.Location = new System.Drawing.Point(99, 459);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '\0';
            this.txt_Password.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_Password.PlaceholderText = "entrer votre mot de pass";
            this.txt_Password.SelectedText = "";
            this.txt_Password.ShadowDecoration.Parent = this.txt_Password;
            this.txt_Password.Size = new System.Drawing.Size(303, 36);
            this.txt_Password.TabIndex = 2;
            this.txt_Password.UseSystemPasswordChar = true;
            this.txt_Password.TextChanged += new System.EventHandler(this.siticoneRoundedTextBox2_TextChanged);
            // 
            // txt_UserName
            // 
            this.txt_UserName.Animated = false;
            this.txt_UserName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_UserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_UserName.DefaultText = "";
            this.txt_UserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_UserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_UserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_UserName.DisabledState.Parent = this.txt_UserName;
            this.txt_UserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_UserName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.txt_UserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(74)))), ((int)(((byte)(17)))));
            this.txt_UserName.FocusedState.Parent = this.txt_UserName;
            this.txt_UserName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txt_UserName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_UserName.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_UserName.HoveredState.Parent = this.txt_UserName;
            this.txt_UserName.IconLeft = global::GetWell.Properties.Resources.profileIcon2;
            this.txt_UserName.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txt_UserName.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txt_UserName.Location = new System.Drawing.Point(99, 392);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.PasswordChar = '\0';
            this.txt_UserName.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_UserName.PlaceholderText = "entrer votre nom d\'utilisateur";
            this.txt_UserName.SelectedText = "";
            this.txt_UserName.ShadowDecoration.Parent = this.txt_UserName;
            this.txt_UserName.Size = new System.Drawing.Size(303, 36);
            this.txt_UserName.TabIndex = 1;
            this.txt_UserName.TextChanged += new System.EventHandler(this.siticoneRoundedTextBox1_TextChanged);
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
            this.siticoneButton3.Location = new System.Drawing.Point(195, 672);
            this.siticoneButton3.Name = "siticoneButton3";
            this.siticoneButton3.ShadowDecoration.Parent = this.siticoneButton3;
            this.siticoneButton3.Size = new System.Drawing.Size(111, 24);
            this.siticoneButton3.TabIndex = 0;
            this.siticoneButton3.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticonePictureBox1.Image = global::GetWell.Properties.Resources.Untitled_12;
            this.siticonePictureBox1.Location = new System.Drawing.Point(0, 0);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.ShadowDecoration.Parent = this.siticonePictureBox1;
            this.siticonePictureBox1.Size = new System.Drawing.Size(500, 329);
            this.siticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.siticonePictureBox1.TabIndex = 5;
            this.siticonePictureBox1.TabStop = false;
            this.siticonePictureBox1.UseTransparentBackground = true;
            this.siticonePictureBox1.Click += new System.EventHandler(this.siticonePictureBox1_Click);
            this.siticonePictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            // 
            // siticonePictureBox3
            // 
            this.siticonePictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.siticonePictureBox3.Image = global::GetWell.Properties.Resources.Untitled_13;
            this.siticonePictureBox3.Location = new System.Drawing.Point(289, 459);
            this.siticonePictureBox3.Name = "siticonePictureBox3";
            this.siticonePictureBox3.ShadowDecoration.Parent = this.siticonePictureBox3;
            this.siticonePictureBox3.Size = new System.Drawing.Size(543, 324);
            this.siticonePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticonePictureBox3.TabIndex = 17;
            this.siticonePictureBox3.TabStop = false;
            this.siticonePictureBox3.UseTransparentBackground = true;
            // 
            // siticonePictureBox2
            // 
            this.siticonePictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.siticonePictureBox2.Image = global::GetWell.Properties.Resources.Untitled_122;
            this.siticonePictureBox2.Location = new System.Drawing.Point(-315, 436);
            this.siticonePictureBox2.Name = "siticonePictureBox2";
            this.siticonePictureBox2.ShadowDecoration.Parent = this.siticonePictureBox2;
            this.siticonePictureBox2.Size = new System.Drawing.Size(543, 324);
            this.siticonePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticonePictureBox2.TabIndex = 17;
            this.siticonePictureBox2.TabStop = false;
            this.siticonePictureBox2.UseTransparentBackground = true;
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(500, 719);
            this.Controls.Add(this.siticoneButton1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.siticoneButton4);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.siticoneButton3);
            this.Controls.Add(this.siticonePictureBox1);
            this.Controls.Add(this.siticonePictureBox3);
            this.Controls.Add(this.siticonePictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneElipse siticoneElipse1;
        private Siticone.UI.WinForms.SiticoneButton btn_login;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox txt_Password;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox txt_UserName;
        private System.Windows.Forms.Label label2;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton3;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer IsLoggedTimer;
        private Siticone.UI.WinForms.SiticonePictureBox siticonePictureBox1;
        private Siticone.UI.WinForms.SiticoneButton btn_close;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.UI.WinForms.SiticonePictureBox siticonePictureBox2;
        private System.Windows.Forms.Label label_error;
        private Siticone.UI.WinForms.SiticonePictureBox siticonePictureBox3;
    }
}

