
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_login = new Siticone.UI.WinForms.SiticoneButton();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_Password = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.txt_UserName = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.siticoneButton4 = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneButton3 = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneButton1 = new Siticone.UI.WinForms.SiticoneButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneElipse1
            // 
            this.siticoneElipse1.BorderRadius = 20;
            this.siticoneElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Minimize);
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.siticoneButton4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 37);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            // 
            // btn_login
            // 
            this.btn_login.BorderRadius = 20;
            this.btn_login.CheckedState.Parent = this.btn_login;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.CustomImages.Parent = this.btn_login;
            this.btn_login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(159)))));
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(139)))), ((int)(((byte)(184)))));
            this.btn_login.HoveredState.Parent = this.btn_login;
            this.btn_login.Location = new System.Drawing.Point(170, 386);
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
            this.label2.Location = new System.Drawing.Point(126, 547);
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
            // txt_Password
            // 
            this.txt_Password.Animated = false;
            this.txt_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Password.DefaultText = "";
            this.txt_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Password.DisabledState.Parent = this.txt_Password;
            this.txt_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Password.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(74)))), ((int)(((byte)(17)))));
            this.txt_Password.FocusedState.Parent = this.txt_Password;
            this.txt_Password.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txt_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Password.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Password.HoveredState.Parent = this.txt_Password;
            this.txt_Password.IconLeft = global::GetWell.Properties.Resources.password2;
            this.txt_Password.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txt_Password.Location = new System.Drawing.Point(99, 316);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '\0';
            this.txt_Password.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.txt_UserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_UserName.DefaultText = "";
            this.txt_UserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_UserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_UserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_UserName.DisabledState.Parent = this.txt_UserName;
            this.txt_UserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_UserName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_UserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(74)))), ((int)(((byte)(17)))));
            this.txt_UserName.FocusedState.Parent = this.txt_UserName;
            this.txt_UserName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txt_UserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_UserName.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_UserName.HoveredState.Parent = this.txt_UserName;
            this.txt_UserName.IconLeft = global::GetWell.Properties.Resources.profileIcon2;
            this.txt_UserName.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txt_UserName.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txt_UserName.Location = new System.Drawing.Point(99, 249);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.PasswordChar = '\0';
            this.txt_UserName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_UserName.PlaceholderText = "entrer votre nom d\'utilisateur";
            this.txt_UserName.SelectedText = "";
            this.txt_UserName.ShadowDecoration.Parent = this.txt_UserName;
            this.txt_UserName.Size = new System.Drawing.Size(303, 36);
            this.txt_UserName.TabIndex = 1;
            this.txt_UserName.TextChanged += new System.EventHandler(this.siticoneRoundedTextBox1_TextChanged);
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
            this.btn_Minimize.Location = new System.Drawing.Point(422, 3);
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
            this.btn_Exit.Location = new System.Drawing.Point(458, 3);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(30, 30);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
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
            this.siticoneButton4.Location = new System.Drawing.Point(12, 6);
            this.siticoneButton4.Name = "siticoneButton4";
            this.siticoneButton4.ShadowDecoration.Parent = this.siticoneButton4;
            this.siticoneButton4.Size = new System.Drawing.Size(99, 24);
            this.siticoneButton4.TabIndex = 0;
            this.siticoneButton4.Click += new System.EventHandler(this.siticoneButton1_Click);
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
            this.siticoneButton3.Location = new System.Drawing.Point(195, 564);
            this.siticoneButton3.Name = "siticoneButton3";
            this.siticoneButton3.ShadowDecoration.Parent = this.siticoneButton3;
            this.siticoneButton3.Size = new System.Drawing.Size(111, 24);
            this.siticoneButton3.TabIndex = 0;
            this.siticoneButton3.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.BorderRadius = 80;
            this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
            this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
            this.siticoneButton1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.HoveredState.Parent = this.siticoneButton1;
            this.siticoneButton1.Image = global::GetWell.Properties.Resources.Logo;
            this.siticoneButton1.ImageSize = new System.Drawing.Size(120, 120);
            this.siticoneButton1.Location = new System.Drawing.Point(170, 63);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(160, 160);
            this.siticoneButton1.TabIndex = 0;
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.siticoneButton3);
            this.Controls.Add(this.siticoneButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneElipse siticoneElipse1;
        private Siticone.UI.WinForms.SiticoneButton btn_login;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox txt_Password;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox txt_UserName;
        private System.Windows.Forms.Panel panel1;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton1;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Minimize;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton3;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton4;
        private System.Windows.Forms.Timer timer1;
    }
}

