
namespace GetWell
{
    partial class Home_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.siticoneButton3 = new Siticone.UI.WinForms.SiticoneButton();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.siticoneElipse1 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.label_welcome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.siticoneGradientPanel1 = new Siticone.UI.WinForms.SiticoneGradientPanel();
            this.siticoneButton6 = new Siticone.UI.WinForms.SiticoneButton();
            this.btn_profile = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneCirclePictureBox1 = new Siticone.UI.WinForms.SiticoneCirclePictureBox();
            this.label_NewRV = new Siticone.UI.WinForms.SiticoneCircleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.siticoneCircleButton2 = new Siticone.UI.WinForms.SiticoneCircleButton();
            this.btn_consultation = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.btn_calendrier = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.btn_newrv = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.btn_teleconsultation = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.CheckForNewRV = new System.Windows.Forms.Timer(this.components);
            this.notification = new Tulpep.NotificationWindow.PopupNotifier();
            this.siticoneButton1 = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneButton4 = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneButton5 = new Siticone.UI.WinForms.SiticoneButton();
            this.panel1.SuspendLayout();
            this.siticoneGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.siticoneButton3);
            this.panel1.Controls.Add(this.btn_Minimize);
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 37);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
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
            this.siticoneButton3.ImageSize = new System.Drawing.Size(100, 100);
            this.siticoneButton3.Location = new System.Drawing.Point(-1, 6);
            this.siticoneButton3.Name = "siticoneButton3";
            this.siticoneButton3.ShadowDecoration.Parent = this.siticoneButton3;
            this.siticoneButton3.Size = new System.Drawing.Size(111, 24);
            this.siticoneButton3.TabIndex = 3;
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimize.BackgroundImage = global::GetWell.Properties.Resources.appbar_minus;
            this.btn_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Minimize.FlatAppearance.BorderSize = 0;
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.Location = new System.Drawing.Point(899, 4);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(30, 30);
            this.btn_Minimize.TabIndex = 0;
            this.btn_Minimize.UseVisualStyleBackColor = true;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit.BackgroundImage = global::GetWell.Properties.Resources.appbar_close;
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Location = new System.Drawing.Point(936, 3);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(30, 30);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // siticoneElipse1
            // 
            this.siticoneElipse1.BorderRadius = 20;
            this.siticoneElipse1.TargetControl = this;
            // 
            // label_welcome
            // 
            this.label_welcome.BackColor = System.Drawing.Color.Transparent;
            this.label_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label_welcome.Location = new System.Drawing.Point(50, 137);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(207, 90);
            this.label_welcome.TabIndex = 5;
            this.label_welcome.Text = "Bienvenu!\nMr Mohamed";
            this.label_welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(141, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "page d\'accueil";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // siticoneGradientPanel1
            // 
            this.siticoneGradientPanel1.BorderRadius = 30;
            this.siticoneGradientPanel1.Controls.Add(this.siticoneButton6);
            this.siticoneGradientPanel1.Controls.Add(this.btn_profile);
            this.siticoneGradientPanel1.Controls.Add(this.siticoneCirclePictureBox1);
            this.siticoneGradientPanel1.Controls.Add(this.label_welcome);
            this.siticoneGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.siticoneGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(159)))));
            this.siticoneGradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.siticoneGradientPanel1.Location = new System.Drawing.Point(35, 11);
            this.siticoneGradientPanel1.Name = "siticoneGradientPanel1";
            this.siticoneGradientPanel1.ShadowDecoration.Parent = this.siticoneGradientPanel1;
            this.siticoneGradientPanel1.Size = new System.Drawing.Size(306, 368);
            this.siticoneGradientPanel1.TabIndex = 6;
            this.siticoneGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.siticoneGradientPanel1_Paint);
            // 
            // siticoneButton6
            // 
            this.siticoneButton6.BackColor = System.Drawing.Color.Transparent;
            this.siticoneButton6.CheckedState.Parent = this.siticoneButton6;
            this.siticoneButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneButton6.CustomImages.Parent = this.siticoneButton6;
            this.siticoneButton6.FillColor = System.Drawing.Color.Transparent;
            this.siticoneButton6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.siticoneButton6.ForeColor = System.Drawing.Color.White;
            this.siticoneButton6.HoveredState.Parent = this.siticoneButton6;
            this.siticoneButton6.Image = global::GetWell.Properties.Resources.appbar_door_lock_open;
            this.siticoneButton6.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.siticoneButton6.ImageSize = new System.Drawing.Size(30, 30);
            this.siticoneButton6.Location = new System.Drawing.Point(92, 315);
            this.siticoneButton6.Name = "siticoneButton6";
            this.siticoneButton6.ShadowDecoration.Parent = this.siticoneButton6;
            this.siticoneButton6.Size = new System.Drawing.Size(123, 42);
            this.siticoneButton6.TabIndex = 7;
            this.siticoneButton6.Text = "Deconnecter";
            this.siticoneButton6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.siticoneButton6.UseTransparentBackground = true;
            this.siticoneButton6.Click += new System.EventHandler(this.siticoneButton6_Click);
            // 
            // btn_profile
            // 
            this.btn_profile.BackColor = System.Drawing.Color.Transparent;
            this.btn_profile.BorderRadius = 25;
            this.btn_profile.CheckedState.Parent = this.btn_profile;
            this.btn_profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_profile.CustomImages.Parent = this.btn_profile;
            this.btn_profile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(74)))), ((int)(((byte)(17)))));
            this.btn_profile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Underline);
            this.btn_profile.ForeColor = System.Drawing.Color.White;
            this.btn_profile.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(134)))), ((int)(((byte)(17)))));
            this.btn_profile.HoveredState.Parent = this.btn_profile;
            this.btn_profile.Image = global::GetWell.Properties.Resources.appbar_settings;
            this.btn_profile.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_profile.Location = new System.Drawing.Point(63, 250);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.ShadowDecoration.Parent = this.btn_profile;
            this.btn_profile.Size = new System.Drawing.Size(180, 50);
            this.btn_profile.TabIndex = 6;
            this.btn_profile.Text = "Gerer Votre Profile";
            this.btn_profile.TextOffset = new System.Drawing.Point(-4, 0);
            this.btn_profile.Click += new System.EventHandler(this.btn_profile_Click);
            // 
            // siticoneCirclePictureBox1
            // 
            this.siticoneCirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneCirclePictureBox1.Image = global::GetWell.Properties.Resources.profile1;
            this.siticoneCirclePictureBox1.Location = new System.Drawing.Point(103, 47);
            this.siticoneCirclePictureBox1.Name = "siticoneCirclePictureBox1";
            this.siticoneCirclePictureBox1.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCirclePictureBox1.ShadowDecoration.Parent = this.siticoneCirclePictureBox1;
            this.siticoneCirclePictureBox1.Size = new System.Drawing.Size(100, 100);
            this.siticoneCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticoneCirclePictureBox1.TabIndex = 4;
            this.siticoneCirclePictureBox1.TabStop = false;
            // 
            // label_NewRV
            // 
            this.label_NewRV.BackColor = System.Drawing.Color.Transparent;
            this.label_NewRV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.label_NewRV.CheckedState.Parent = this.label_NewRV;
            this.label_NewRV.CustomBorderThickness = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.label_NewRV.CustomImages.Parent = this.label_NewRV;
            this.label_NewRV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.label_NewRV.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold);
            this.label_NewRV.ForeColor = System.Drawing.Color.White;
            this.label_NewRV.HoveredState.Parent = this.label_NewRV;
            this.label_NewRV.Location = new System.Drawing.Point(798, 50);
            this.label_NewRV.Name = "label_NewRV";
            this.label_NewRV.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
            this.label_NewRV.ShadowDecoration.Parent = this.label_NewRV;
            this.label_NewRV.Size = new System.Drawing.Size(45, 45);
            this.label_NewRV.TabIndex = 9;
            this.label_NewRV.Text = "5";
            this.label_NewRV.UseTransparentBackground = true;
            this.label_NewRV.TextChanged += new System.EventHandler(this.label_NewRV_TextChanged);
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(363, 574);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 14);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tous Droits Réservés © copyright GetWell 2020 ";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(91, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(792, 10);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(11, 595);
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.label_NewRV);
            this.panel4.Controls.Add(this.siticoneCircleButton2);
            this.panel4.Controls.Add(this.btn_consultation);
            this.panel4.Controls.Add(this.btn_calendrier);
            this.panel4.Controls.Add(this.btn_newrv);
            this.panel4.Controls.Add(this.btn_teleconsultation);
            this.panel4.Controls.Add(this.siticoneGradientPanel1);
            this.panel4.Location = new System.Drawing.Point(56, 139);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(862, 389);
            this.panel4.TabIndex = 14;
            // 
            // siticoneCircleButton2
            // 
            this.siticoneCircleButton2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneCircleButton2.CheckedState.Parent = this.siticoneCircleButton2;
            this.siticoneCircleButton2.CustomImages.Parent = this.siticoneCircleButton2;
            this.siticoneCircleButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.siticoneCircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneCircleButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneCircleButton2.HoveredState.Parent = this.siticoneCircleButton2;
            this.siticoneCircleButton2.Location = new System.Drawing.Point(789, 41);
            this.siticoneCircleButton2.Name = "siticoneCircleButton2";
            this.siticoneCircleButton2.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCircleButton2.ShadowDecoration.Parent = this.siticoneCircleButton2;
            this.siticoneCircleButton2.Size = new System.Drawing.Size(63, 63);
            this.siticoneCircleButton2.TabIndex = 15;
            this.siticoneCircleButton2.UseTransparentBackground = true;
            // 
            // btn_consultation
            // 
            this.btn_consultation.BackColor = System.Drawing.Color.Transparent;
            this.btn_consultation.BorderRadius = 30;
            this.btn_consultation.CheckedState.Parent = this.btn_consultation;
            this.btn_consultation.CustomImages.Parent = this.btn_consultation;
            this.btn_consultation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(154)))), ((int)(((byte)(142)))));
            this.btn_consultation.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(239)))), ((int)(((byte)(125)))));
            this.btn_consultation.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_consultation.ForeColor = System.Drawing.Color.White;
            this.btn_consultation.HoveredState.Parent = this.btn_consultation;
            this.btn_consultation.Image = global::GetWell.Properties.Resources.appbar_eye;
            this.btn_consultation.ImageOffset = new System.Drawing.Point(23, -20);
            this.btn_consultation.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_consultation.Location = new System.Drawing.Point(387, 203);
            this.btn_consultation.Name = "btn_consultation";
            this.btn_consultation.ShadowDecoration.Parent = this.btn_consultation;
            this.btn_consultation.Size = new System.Drawing.Size(211, 176);
            this.btn_consultation.TabIndex = 7;
            this.btn_consultation.Text = "Consultation";
            this.btn_consultation.TextOffset = new System.Drawing.Point(-11, 18);
            this.btn_consultation.UseTransparentBackground = true;
            this.btn_consultation.Click += new System.EventHandler(this.btn_consultation_Click);
            // 
            // btn_calendrier
            // 
            this.btn_calendrier.BackColor = System.Drawing.Color.Transparent;
            this.btn_calendrier.BorderRadius = 30;
            this.btn_calendrier.CheckedState.Parent = this.btn_calendrier;
            this.btn_calendrier.CustomImages.Parent = this.btn_calendrier;
            this.btn_calendrier.FillColor = System.Drawing.Color.DeepPink;
            this.btn_calendrier.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.btn_calendrier.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_calendrier.ForeColor = System.Drawing.Color.White;
            this.btn_calendrier.HoveredState.Parent = this.btn_calendrier;
            this.btn_calendrier.Image = global::GetWell.Properties.Resources.appbar_calendar_31;
            this.btn_calendrier.ImageOffset = new System.Drawing.Point(20, -20);
            this.btn_calendrier.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_calendrier.Location = new System.Drawing.Point(387, 11);
            this.btn_calendrier.Name = "btn_calendrier";
            this.btn_calendrier.ShadowDecoration.Parent = this.btn_calendrier;
            this.btn_calendrier.Size = new System.Drawing.Size(211, 176);
            this.btn_calendrier.TabIndex = 7;
            this.btn_calendrier.Text = "Calendrier";
            this.btn_calendrier.TextOffset = new System.Drawing.Point(-11, 18);
            this.btn_calendrier.UseTransparentBackground = true;
            this.btn_calendrier.Click += new System.EventHandler(this.btn_calendrier_Click);
            // 
            // btn_newrv
            // 
            this.btn_newrv.BackColor = System.Drawing.Color.Transparent;
            this.btn_newrv.BorderRadius = 30;
            this.btn_newrv.CheckedState.Parent = this.btn_newrv;
            this.btn_newrv.CustomImages.Parent = this.btn_newrv;
            this.btn_newrv.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_newrv.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(159)))));
            this.btn_newrv.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_newrv.ForeColor = System.Drawing.Color.White;
            this.btn_newrv.HoveredState.Parent = this.btn_newrv;
            this.btn_newrv.Image = global::GetWell.Properties.Resources.appbar_list_check;
            this.btn_newrv.ImageOffset = new System.Drawing.Point(38, -20);
            this.btn_newrv.ImageSize = new System.Drawing.Size(60, 60);
            this.btn_newrv.Location = new System.Drawing.Point(616, 11);
            this.btn_newrv.Name = "btn_newrv";
            this.btn_newrv.ShadowDecoration.Parent = this.btn_newrv;
            this.btn_newrv.Size = new System.Drawing.Size(211, 176);
            this.btn_newrv.TabIndex = 7;
            this.btn_newrv.Text = "nouveaux rendez-vous";
            this.btn_newrv.TextOffset = new System.Drawing.Point(-16, 18);
            this.btn_newrv.UseTransparentBackground = true;
            this.btn_newrv.Click += new System.EventHandler(this.btn_newrv_Click);
            // 
            // btn_teleconsultation
            // 
            this.btn_teleconsultation.BackColor = System.Drawing.Color.Transparent;
            this.btn_teleconsultation.BorderRadius = 30;
            this.btn_teleconsultation.CheckedState.Parent = this.btn_teleconsultation;
            this.btn_teleconsultation.CustomImages.Parent = this.btn_teleconsultation;
            this.btn_teleconsultation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(199)))), ((int)(((byte)(34)))));
            this.btn_teleconsultation.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_teleconsultation.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_teleconsultation.ForeColor = System.Drawing.Color.White;
            this.btn_teleconsultation.HoveredState.Parent = this.btn_teleconsultation;
            this.btn_teleconsultation.Image = global::GetWell.Properties.Resources.appbar_email_minimal;
            this.btn_teleconsultation.ImageOffset = new System.Drawing.Point(33, -20);
            this.btn_teleconsultation.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_teleconsultation.Location = new System.Drawing.Point(616, 203);
            this.btn_teleconsultation.Name = "btn_teleconsultation";
            this.btn_teleconsultation.ShadowDecoration.Parent = this.btn_teleconsultation;
            this.btn_teleconsultation.Size = new System.Drawing.Size(211, 176);
            this.btn_teleconsultation.TabIndex = 7;
            this.btn_teleconsultation.Text = "Tele-Consultations";
            this.btn_teleconsultation.TextOffset = new System.Drawing.Point(-13, 18);
            this.btn_teleconsultation.UseTransparentBackground = true;
            this.btn_teleconsultation.Click += new System.EventHandler(this.btn_teleconsultation_Click);
            // 
            // CheckForNewRV
            // 
            this.CheckForNewRV.Enabled = true;
            this.CheckForNewRV.Interval = 10000;
            this.CheckForNewRV.Tick += new System.EventHandler(this.CheckForNewRV_Tick);
            // 
            // notification
            // 
            this.notification.AnimationInterval = 20;
            this.notification.BorderColor = System.Drawing.Color.Transparent;
            this.notification.ButtonBorderColor = System.Drawing.Color.Transparent;
            this.notification.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            this.notification.ContentHoverColor = System.Drawing.Color.Black;
            this.notification.ContentText = null;
            this.notification.Delay = 5000;
            this.notification.HeaderColor = System.Drawing.Color.DeepSkyBlue;
            this.notification.HeaderHeight = 1;
            this.notification.Image = null;
            this.notification.IsRightToLeft = false;
            this.notification.OptionsMenu = null;
            this.notification.ShowGrip = false;
            this.notification.ShowOptionsButton = true;
            this.notification.Size = new System.Drawing.Size(400, 110);
            this.notification.TitleFont = new System.Drawing.Font("Segoe UI", 9F);
            this.notification.TitleText = null;
            this.notification.Click += new System.EventHandler(this.notification_Click);
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneButton1.BorderRadius = 80;
            this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
            this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
            this.siticoneButton1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.HoveredState.Parent = this.siticoneButton1;
            this.siticoneButton1.Image = global::GetWell.Properties.Resources.appbar_home;
            this.siticoneButton1.ImageSize = new System.Drawing.Size(60, 60);
            this.siticoneButton1.Location = new System.Drawing.Point(91, 65);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(51, 52);
            this.siticoneButton1.TabIndex = 3;
            // 
            // siticoneButton4
            // 
            this.siticoneButton4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneButton4.BorderRadius = 80;
            this.siticoneButton4.CheckedState.Parent = this.siticoneButton4;
            this.siticoneButton4.CustomImages.Parent = this.siticoneButton4;
            this.siticoneButton4.FillColor = System.Drawing.Color.Transparent;
            this.siticoneButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton4.ForeColor = System.Drawing.Color.White;
            this.siticoneButton4.HoveredState.Parent = this.siticoneButton4;
            this.siticoneButton4.Image = global::GetWell.Properties.Resources.Logo3;
            this.siticoneButton4.ImageSize = new System.Drawing.Size(80, 80);
            this.siticoneButton4.Location = new System.Drawing.Point(432, 591);
            this.siticoneButton4.Name = "siticoneButton4";
            this.siticoneButton4.ShadowDecoration.Parent = this.siticoneButton4;
            this.siticoneButton4.Size = new System.Drawing.Size(111, 24);
            this.siticoneButton4.TabIndex = 10;
            this.siticoneButton4.Click += new System.EventHandler(this.siticoneButton4_Click);
            // 
            // siticoneButton5
            // 
            this.siticoneButton5.BackColor = System.Drawing.Color.Transparent;
            this.siticoneButton5.BorderRadius = 80;
            this.siticoneButton5.CheckedState.Parent = this.siticoneButton5;
            this.siticoneButton5.CustomImages.Parent = this.siticoneButton5;
            this.siticoneButton5.FillColor = System.Drawing.Color.Transparent;
            this.siticoneButton5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton5.ForeColor = System.Drawing.Color.White;
            this.siticoneButton5.HoveredState.Parent = this.siticoneButton5;
            this.siticoneButton5.Image = global::GetWell.Properties.Resources.Logo4;
            this.siticoneButton5.ImageSize = new System.Drawing.Size(60, 60);
            this.siticoneButton5.Location = new System.Drawing.Point(636, 308);
            this.siticoneButton5.Name = "siticoneButton5";
            this.siticoneButton5.ShadowDecoration.Parent = this.siticoneButton5;
            this.siticoneButton5.Size = new System.Drawing.Size(51, 52);
            this.siticoneButton5.TabIndex = 3;
            this.siticoneButton5.UseTransparentBackground = true;
            // 
            // Home_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(975, 632);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.siticoneButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.siticoneButton4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.siticoneButton5);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home_Form";
            this.Load += new System.EventHandler(this.Home_Form_Load);
            this.panel1.ResumeLayout(false);
            this.siticoneGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.Button btn_Exit;
        private Siticone.UI.WinForms.SiticoneElipse siticoneElipse1;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton3;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.UI.WinForms.SiticoneCirclePictureBox siticoneCirclePictureBox1;
        private System.Windows.Forms.Label label2;
        private Siticone.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel1;
        private Siticone.UI.WinForms.SiticoneButton btn_profile;
        private Siticone.UI.WinForms.SiticoneGradientButton btn_calendrier;
        private Siticone.UI.WinForms.SiticoneGradientButton btn_consultation;
        private Siticone.UI.WinForms.SiticoneGradientButton btn_teleconsultation;
        private Siticone.UI.WinForms.SiticoneGradientButton btn_newrv;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private Siticone.UI.WinForms.SiticoneCircleButton siticoneCircleButton2;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton5;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton6;
        private System.Windows.Forms.Timer CheckForNewRV;
        private Tulpep.NotificationWindow.PopupNotifier notification;
        public Siticone.UI.WinForms.SiticoneCircleButton label_NewRV;
        public System.Windows.Forms.Label label_welcome;
    }
}