
namespace GetWell
{
    partial class Calendar_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendar_Form));
            this.siticoneElipse1 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.date = new Siticone.UI.WinForms.SiticoneRoundedDateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.siticoneGradientPanel1 = new Siticone.UI.WinForms.SiticoneGradientPanel();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.siticoneGradientButton1 = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.dgv_rvs = new Guna.UI2.WinForms.Guna2DataGridView();
            this.siticoneButton2 = new Siticone.UI.WinForms.SiticoneButton();
            this.NoResult_lbl1 = new System.Windows.Forms.Label();
            this.search_txtbox = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.siticonePictureBox1 = new Siticone.UI.WinForms.SiticonePictureBox();
            this.siticoneButton1 = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneElipse2 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.panel1.SuspendLayout();
            this.siticoneGradientPanel1.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rvs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneElipse1
            // 
            this.siticoneElipse1.BorderRadius = 30;
            this.siticoneElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.btn_Minimize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(295, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 43);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            // 
            // date
            // 
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.date.BorderThickness = 2;
            this.date.CheckedState.Parent = this.date;
            this.date.FillColor = System.Drawing.Color.Transparent;
            this.date.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date.HoveredState.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.date.HoveredState.Parent = this.date;
            this.date.Location = new System.Drawing.Point(678, 74);
            this.date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date.Name = "date";
            this.date.ShadowDecoration.Parent = this.date;
            this.date.Size = new System.Drawing.Size(361, 40);
            this.date.TabIndex = 9;
            this.date.TextTransform = Siticone.UI.WinForms.Enums.TextTransform.UpperCase;
            this.date.UseTransparentBackground = true;
            this.date.Value = new System.DateTime(2021, 5, 6, 20, 42, 45, 805);
            this.date.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(318, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Choisir une date:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("DYLOVASTUFF 02", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(52, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "Votre rendez-vous";
            // 
            // siticoneGradientPanel1
            // 
            this.siticoneGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneGradientPanel1.Controls.Add(this.siticonePictureBox1);
            this.siticoneGradientPanel1.Controls.Add(this.siticoneButton1);
            this.siticoneGradientPanel1.Controls.Add(this.label6);
            this.siticoneGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.siticoneGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.siticoneGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(159)))));
            this.siticoneGradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.siticoneGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.siticoneGradientPanel1.Name = "siticoneGradientPanel1";
            this.siticoneGradientPanel1.ShadowDecoration.Parent = this.siticoneGradientPanel1;
            this.siticoneGradientPanel1.Size = new System.Drawing.Size(295, 718);
            this.siticoneGradientPanel1.TabIndex = 10;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.BorderRadius = 20;
            this.guna2GradientPanel1.Controls.Add(this.NoResult_lbl1);
            this.guna2GradientPanel1.Controls.Add(this.search_txtbox);
            this.guna2GradientPanel1.Controls.Add(this.siticoneGradientButton1);
            this.guna2GradientPanel1.Controls.Add(this.dgv_rvs);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(310, 128);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(784, 578);
            this.guna2GradientPanel1.TabIndex = 24;
            // 
            // siticoneGradientButton1
            // 
            this.siticoneGradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneGradientButton1.BorderRadius = 10;
            this.siticoneGradientButton1.CheckedState.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.CustomImages.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneGradientButton1.FillColor2 = System.Drawing.Color.Transparent;
            this.siticoneGradientButton1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.siticoneGradientButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.siticoneGradientButton1.HoveredState.FillColor = System.Drawing.Color.Transparent;
            this.siticoneGradientButton1.HoveredState.FillColor2 = System.Drawing.Color.Transparent;
            this.siticoneGradientButton1.HoveredState.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.Location = new System.Drawing.Point(12, 9);
            this.siticoneGradientButton1.Name = "siticoneGradientButton1";
            this.siticoneGradientButton1.ShadowDecoration.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.Size = new System.Drawing.Size(757, 45);
            this.siticoneGradientButton1.TabIndex = 4;
            this.siticoneGradientButton1.Text = "Liste des Rendez-Vous";
            this.siticoneGradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.siticoneGradientButton1.UseTransparentBackground = true;
            // 
            // dgv_rvs
            // 
            this.dgv_rvs.AllowUserToAddRows = false;
            this.dgv_rvs.AllowUserToDeleteRows = false;
            this.dgv_rvs.AllowUserToResizeColumns = false;
            this.dgv_rvs.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_rvs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_rvs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_rvs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.dgv_rvs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_rvs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_rvs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_rvs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_rvs.ColumnHeadersHeight = 40;
            this.dgv_rvs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_rvs.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_rvs.EnableHeadersVisualStyles = false;
            this.dgv_rvs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.dgv_rvs.Location = new System.Drawing.Point(12, 60);
            this.dgv_rvs.MultiSelect = false;
            this.dgv_rvs.Name = "dgv_rvs";
            this.dgv_rvs.ReadOnly = true;
            this.dgv_rvs.RowHeadersVisible = false;
            this.dgv_rvs.RowTemplate.Height = 40;
            this.dgv_rvs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_rvs.Size = new System.Drawing.Size(757, 495);
            this.dgv_rvs.TabIndex = 2;
            this.dgv_rvs.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightBlue;
            this.dgv_rvs.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.dgv_rvs.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_rvs.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_rvs.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_rvs.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_rvs.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.dgv_rvs.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.dgv_rvs.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.dgv_rvs.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_rvs.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_rvs.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_rvs.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_rvs.ThemeStyle.HeaderStyle.Height = 40;
            this.dgv_rvs.ThemeStyle.ReadOnly = true;
            this.dgv_rvs.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.dgv_rvs.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_rvs.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dgv_rvs.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_rvs.ThemeStyle.RowsStyle.Height = 40;
            this.dgv_rvs.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            this.dgv_rvs.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // siticoneButton2
            // 
            this.siticoneButton2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneButton2.BorderRadius = 20;
            this.siticoneButton2.CheckedState.Parent = this.siticoneButton2;
            this.siticoneButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneButton2.CustomImages.Parent = this.siticoneButton2;
            this.siticoneButton2.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.siticoneButton2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.siticoneButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneButton2.HoveredState.Parent = this.siticoneButton2;
            this.siticoneButton2.Image = global::GetWell.Properties.Resources.appbar5;
            this.siticoneButton2.ImageOffset = new System.Drawing.Point(1, 0);
            this.siticoneButton2.ImageSize = new System.Drawing.Size(35, 35);
            this.siticoneButton2.Location = new System.Drawing.Point(1051, 74);
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.ShadowDecoration.Parent = this.siticoneButton2;
            this.siticoneButton2.Size = new System.Drawing.Size(40, 40);
            this.siticoneButton2.TabIndex = 26;
            this.siticoneButton2.UseTransparentBackground = true;
            this.siticoneButton2.Click += new System.EventHandler(this.siticoneButton2_Click);
            // 
            // NoResult_lbl1
            // 
            this.NoResult_lbl1.Font = new System.Drawing.Font("Perpetua", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoResult_lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NoResult_lbl1.Image = global::GetWell.Properties.Resources.icons8_fingerprint_error_100;
            this.NoResult_lbl1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NoResult_lbl1.Location = new System.Drawing.Point(324, 188);
            this.NoResult_lbl1.Name = "NoResult_lbl1";
            this.NoResult_lbl1.Size = new System.Drawing.Size(192, 141);
            this.NoResult_lbl1.TabIndex = 6;
            this.NoResult_lbl1.Text = "aucune resultat !";
            this.NoResult_lbl1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NoResult_lbl1.Visible = false;
            // 
            // search_txtbox
            // 
            this.search_txtbox.Animated = false;
            this.search_txtbox.BorderThickness = 0;
            this.search_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search_txtbox.DefaultText = "";
            this.search_txtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.search_txtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.search_txtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_txtbox.DisabledState.Parent = this.search_txtbox;
            this.search_txtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_txtbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(239)))), ((int)(((byte)(252)))));
            this.search_txtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_txtbox.FocusedState.Parent = this.search_txtbox;
            this.search_txtbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.search_txtbox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_txtbox.HoveredState.Parent = this.search_txtbox;
            this.search_txtbox.IconRight = global::GetWell.Properties.Resources.appbar4;
            this.search_txtbox.IconRightSize = new System.Drawing.Size(35, 35);
            this.search_txtbox.Location = new System.Drawing.Point(565, 15);
            this.search_txtbox.Name = "search_txtbox";
            this.search_txtbox.PasswordChar = '\0';
            this.search_txtbox.PlaceholderText = "Entrer le nom de patient";
            this.search_txtbox.SelectedText = "";
            this.search_txtbox.ShadowDecoration.Parent = this.search_txtbox;
            this.search_txtbox.Size = new System.Drawing.Size(204, 33);
            this.search_txtbox.TabIndex = 5;
            this.search_txtbox.TextChanged += new System.EventHandler(this.search_txtbox_TextChanged);
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
            this.btn_Exit.Location = new System.Drawing.Point(769, 6);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(30, 30);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
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
            this.btn_Minimize.Location = new System.Drawing.Point(733, 6);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(30, 30);
            this.btn_Minimize.TabIndex = 0;
            this.btn_Minimize.UseVisualStyleBackColor = true;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.Image = global::GetWell.Properties.Resources.undraw_Working_oh83;
            this.siticonePictureBox1.Location = new System.Drawing.Point(-44, 271);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.ShadowDecoration.Parent = this.siticonePictureBox1;
            this.siticonePictureBox1.Size = new System.Drawing.Size(383, 260);
            this.siticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.siticonePictureBox1.TabIndex = 9;
            this.siticonePictureBox1.TabStop = false;
            this.siticonePictureBox1.UseTransparentBackground = true;
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.BorderRadius = 80;
            this.siticoneButton1.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
            this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
            this.siticoneButton1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.HoveredState.FillColor = System.Drawing.Color.Transparent;
            this.siticoneButton1.HoveredState.Parent = this.siticoneButton1;
            this.siticoneButton1.Image = global::GetWell.Properties.Resources.Logo4;
            this.siticoneButton1.ImageSize = new System.Drawing.Size(120, 120);
            this.siticoneButton1.Location = new System.Drawing.Point(62, 74);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.PressedColor = System.Drawing.Color.Transparent;
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(160, 160);
            this.siticoneButton1.TabIndex = 8;
            this.siticoneButton1.UseTransparentBackground = true;
            // 
            // siticoneElipse2
            // 
            this.siticoneElipse2.BorderRadius = 30;
            this.siticoneElipse2.TargetControl = this.dgv_rvs;
            // 
            // Calendar_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1108, 718);
            this.Controls.Add(this.siticoneButton2);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.date);
            this.Controls.Add(this.siticoneGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calendar_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendar_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Calendar_Form_FormClosing);
            this.Load += new System.EventHandler(this.Calendar_Form_Load);
            this.panel1.ResumeLayout(false);
            this.siticoneGradientPanel1.ResumeLayout(false);
            this.siticoneGradientPanel1.PerformLayout();
            this.guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rvs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneElipse siticoneElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.Button btn_Exit;
        private Siticone.UI.WinForms.SiticoneRoundedDateTimePicker date;
        private System.Windows.Forms.Label label5;
        private Siticone.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel1;
        private System.Windows.Forms.Label label6;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.UI.WinForms.SiticonePictureBox siticonePictureBox1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label NoResult_lbl1;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox search_txtbox;
        private Siticone.UI.WinForms.SiticoneGradientButton siticoneGradientButton1;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_rvs;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton2;
        private Siticone.UI.WinForms.SiticoneElipse siticoneElipse2;
    }
}