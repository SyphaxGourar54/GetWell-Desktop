
namespace GetWell
{
    partial class TeleConsultation_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeleConsultation_Form));
            this.siticoneElipse1 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.siticoneGradientButton1 = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.dgv_teleconsultation = new Guna.UI2.WinForms.Guna2DataGridView();
            this.siticonePanel1 = new Siticone.UI.WinForms.SiticonePanel();
            this.label1 = new System.Windows.Forms.Label();
            this.Response_text = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.siticoneSeparator2 = new Siticone.UI.WinForms.SiticoneSeparator();
            this.label3 = new System.Windows.Forms.Label();
            this.Email_textbox = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.patient_TextBox = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneButton1 = new Siticone.UI.WinForms.SiticoneButton();
            this.NoResult_lbl1 = new System.Windows.Forms.Label();
            this.search_txtbox = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.siticoneButton4 = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneElipse2 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.panel1.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teleconsultation)).BeginInit();
            this.siticonePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneElipse1
            // 
            this.siticoneElipse1.BorderRadius = 30;
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
            this.panel1.Size = new System.Drawing.Size(880, 37);
            this.panel1.TabIndex = 22;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.BorderRadius = 20;
            this.guna2GradientPanel1.Controls.Add(this.NoResult_lbl1);
            this.guna2GradientPanel1.Controls.Add(this.search_txtbox);
            this.guna2GradientPanel1.Controls.Add(this.siticoneGradientButton1);
            this.guna2GradientPanel1.Controls.Add(this.dgv_teleconsultation);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(17, 52);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(844, 478);
            this.guna2GradientPanel1.TabIndex = 23;
            // 
            // siticoneGradientButton1
            // 
            this.siticoneGradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneGradientButton1.BorderRadius = 10;
            this.siticoneGradientButton1.CheckedState.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.CustomImages.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneGradientButton1.FillColor2 = System.Drawing.Color.Transparent;
            this.siticoneGradientButton1.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.siticoneGradientButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.siticoneGradientButton1.HoveredState.FillColor = System.Drawing.Color.Transparent;
            this.siticoneGradientButton1.HoveredState.FillColor2 = System.Drawing.Color.Transparent;
            this.siticoneGradientButton1.HoveredState.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.Location = new System.Drawing.Point(12, 9);
            this.siticoneGradientButton1.Name = "siticoneGradientButton1";
            this.siticoneGradientButton1.ShadowDecoration.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.Size = new System.Drawing.Size(816, 45);
            this.siticoneGradientButton1.TabIndex = 4;
            this.siticoneGradientButton1.Text = "Liste de Tele-Consultations";
            this.siticoneGradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.siticoneGradientButton1.UseTransparentBackground = true;
            // 
            // dgv_teleconsultation
            // 
            this.dgv_teleconsultation.AllowUserToAddRows = false;
            this.dgv_teleconsultation.AllowUserToDeleteRows = false;
            this.dgv_teleconsultation.AllowUserToResizeColumns = false;
            this.dgv_teleconsultation.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_teleconsultation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_teleconsultation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_teleconsultation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.dgv_teleconsultation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_teleconsultation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_teleconsultation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_teleconsultation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_teleconsultation.ColumnHeadersHeight = 40;
            this.dgv_teleconsultation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_teleconsultation.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_teleconsultation.EnableHeadersVisualStyles = false;
            this.dgv_teleconsultation.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.dgv_teleconsultation.Location = new System.Drawing.Point(17, 63);
            this.dgv_teleconsultation.MultiSelect = false;
            this.dgv_teleconsultation.Name = "dgv_teleconsultation";
            this.dgv_teleconsultation.ReadOnly = true;
            this.dgv_teleconsultation.RowHeadersVisible = false;
            this.dgv_teleconsultation.RowTemplate.Height = 40;
            this.dgv_teleconsultation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_teleconsultation.Size = new System.Drawing.Size(809, 393);
            this.dgv_teleconsultation.TabIndex = 2;
            this.dgv_teleconsultation.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightBlue;
            this.dgv_teleconsultation.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.dgv_teleconsultation.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_teleconsultation.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_teleconsultation.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_teleconsultation.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_teleconsultation.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.dgv_teleconsultation.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.dgv_teleconsultation.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.dgv_teleconsultation.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_teleconsultation.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_teleconsultation.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_teleconsultation.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_teleconsultation.ThemeStyle.HeaderStyle.Height = 40;
            this.dgv_teleconsultation.ThemeStyle.ReadOnly = true;
            this.dgv_teleconsultation.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.dgv_teleconsultation.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_teleconsultation.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dgv_teleconsultation.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_teleconsultation.ThemeStyle.RowsStyle.Height = 40;
            this.dgv_teleconsultation.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            this.dgv_teleconsultation.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_teleconsultation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_teleconsultation_CellContentClick);
            this.dgv_teleconsultation.SelectionChanged += new System.EventHandler(this.dgv_teleconsultation_SelectionChanged);
            this.dgv_teleconsultation.Click += new System.EventHandler(this.dgv_teleconsultation_Click);
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.Transparent;
            this.siticonePanel1.BorderRadius = 20;
            this.siticonePanel1.Controls.Add(this.label1);
            this.siticonePanel1.Controls.Add(this.siticoneButton1);
            this.siticonePanel1.Controls.Add(this.Response_text);
            this.siticonePanel1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.siticonePanel1.Location = new System.Drawing.Point(344, 590);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
            this.siticonePanel1.Size = new System.Drawing.Size(517, 130);
            this.siticonePanel1.TabIndex = 24;
            this.siticonePanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.siticonePanel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 26;
            this.label1.Text = "Reponse:";
            // 
            // Response_text
            // 
            this.Response_text.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Response_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Response_text.Font = new System.Drawing.Font("Segoe Script", 10F);
            this.Response_text.Location = new System.Drawing.Point(35, 26);
            this.Response_text.Name = "Response_text";
            this.Response_text.Size = new System.Drawing.Size(425, 95);
            this.Response_text.TabIndex = 0;
            this.Response_text.Text = "";
            this.Response_text.TextChanged += new System.EventHandler(this.Description_text_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Bell MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(343, 559);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "Repondre au Tele-Consultation";
            // 
            // siticoneSeparator2
            // 
            this.siticoneSeparator2.FillColor = System.Drawing.Color.Gray;
            this.siticoneSeparator2.FillStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.siticoneSeparator2.Location = new System.Drawing.Point(-6, 541);
            this.siticoneSeparator2.Name = "siticoneSeparator2";
            this.siticoneSeparator2.Size = new System.Drawing.Size(892, 10);
            this.siticoneSeparator2.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Bell MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(13, 559);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "Patient Selectioné";
            // 
            // Email_textbox
            // 
            this.Email_textbox.Animated = false;
            this.Email_textbox.BorderThickness = 0;
            this.Email_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Email_textbox.DefaultText = "";
            this.Email_textbox.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.Email_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Email_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Email_textbox.DisabledState.Parent = this.Email_textbox;
            this.Email_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Email_textbox.Enabled = false;
            this.Email_textbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Email_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Email_textbox.FocusedState.Parent = this.Email_textbox;
            this.Email_textbox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.Email_textbox.ForeColor = System.Drawing.Color.Silver;
            this.Email_textbox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Email_textbox.HoveredState.Parent = this.Email_textbox;
            this.Email_textbox.IconLeft = global::GetWell.Properties.Resources.appbar_email2;
            this.Email_textbox.IconLeftSize = new System.Drawing.Size(40, 40);
            this.Email_textbox.Location = new System.Drawing.Point(17, 668);
            this.Email_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Email_textbox.Name = "Email_textbox";
            this.Email_textbox.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Email_textbox.PasswordChar = '\0';
            this.Email_textbox.PlaceholderText = "Email";
            this.Email_textbox.SelectedText = "";
            this.Email_textbox.ShadowDecoration.Parent = this.Email_textbox;
            this.Email_textbox.Size = new System.Drawing.Size(299, 43);
            this.Email_textbox.TabIndex = 25;
            // 
            // patient_TextBox
            // 
            this.patient_TextBox.Animated = false;
            this.patient_TextBox.BorderThickness = 0;
            this.patient_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.patient_TextBox.DefaultText = "";
            this.patient_TextBox.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.patient_TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.patient_TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.patient_TextBox.DisabledState.Parent = this.patient_TextBox;
            this.patient_TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.patient_TextBox.Enabled = false;
            this.patient_TextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.patient_TextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.patient_TextBox.FocusedState.Parent = this.patient_TextBox;
            this.patient_TextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.patient_TextBox.ForeColor = System.Drawing.Color.Silver;
            this.patient_TextBox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.patient_TextBox.HoveredState.Parent = this.patient_TextBox;
            this.patient_TextBox.IconLeft = global::GetWell.Properties.Resources.user22;
            this.patient_TextBox.IconLeftOffset = new System.Drawing.Point(12, 0);
            this.patient_TextBox.Location = new System.Drawing.Point(17, 603);
            this.patient_TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.patient_TextBox.Name = "patient_TextBox";
            this.patient_TextBox.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.patient_TextBox.PasswordChar = '\0';
            this.patient_TextBox.PlaceholderText = "Patient";
            this.patient_TextBox.SelectedText = "";
            this.patient_TextBox.ShadowDecoration.Parent = this.patient_TextBox;
            this.patient_TextBox.Size = new System.Drawing.Size(299, 43);
            this.patient_TextBox.TabIndex = 25;
            this.patient_TextBox.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.BorderRadius = 20;
            this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
            this.siticoneButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
            this.siticoneButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(129)))), ((int)(((byte)(171)))));
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.HoveredState.Parent = this.siticoneButton1;
            this.siticoneButton1.Image = global::GetWell.Properties.Resources.send;
            this.siticoneButton1.ImageSize = new System.Drawing.Size(18, 18);
            this.siticoneButton1.Location = new System.Drawing.Point(466, 81);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(40, 40);
            this.siticoneButton1.TabIndex = 25;
            this.siticoneButton1.UseTransparentBackground = true;
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
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
            this.search_txtbox.Location = new System.Drawing.Point(621, 15);
            this.search_txtbox.Name = "search_txtbox";
            this.search_txtbox.PasswordChar = '\0';
            this.search_txtbox.PlaceholderText = "Entrer le nom de patient";
            this.search_txtbox.SelectedText = "";
            this.search_txtbox.ShadowDecoration.Parent = this.search_txtbox;
            this.search_txtbox.Size = new System.Drawing.Size(204, 33);
            this.search_txtbox.TabIndex = 5;
            this.search_txtbox.TextChanged += new System.EventHandler(this.search_txtbox_TextChanged);
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
            this.btn_Minimize.Location = new System.Drawing.Point(795, 3);
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
            this.btn_Exit.Location = new System.Drawing.Point(831, 4);
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
            // 
            // siticoneElipse2
            // 
            this.siticoneElipse2.BorderRadius = 30;
            this.siticoneElipse2.TargetControl = this.dgv_teleconsultation;
            // 
            // TeleConsultation_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(880, 749);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Email_textbox);
            this.Controls.Add(this.patient_TextBox);
            this.Controls.Add(this.siticonePanel1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.siticoneSeparator2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TeleConsultation_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeleConsultation_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TeleConsultation_Form_FormClosing);
            this.Load += new System.EventHandler(this.TeleConsultation_Form_Load);
            this.Click += new System.EventHandler(this.TeleConsultation_Form_Click);
            this.panel1.ResumeLayout(false);
            this.guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teleconsultation)).EndInit();
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneElipse siticoneElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.Button btn_Exit;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton4;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label NoResult_lbl1;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox search_txtbox;
        private Siticone.UI.WinForms.SiticoneGradientButton siticoneGradientButton1;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_teleconsultation;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.UI.WinForms.SiticonePanel siticonePanel1;
        private System.Windows.Forms.RichTextBox Response_text;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox Email_textbox;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox patient_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Siticone.UI.WinForms.SiticoneSeparator siticoneSeparator2;
        private System.Windows.Forms.Label label2;
        private Siticone.UI.WinForms.SiticoneElipse siticoneElipse2;
    }
}