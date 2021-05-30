
namespace GetWell
{
    partial class NewRV_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewRV_Form));
            this.siticoneElipse1 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.siticoneButton4 = new Siticone.UI.WinForms.SiticoneButton();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.NewRvchecker = new System.Windows.Forms.Timer(this.components);
            this.siticoneGradientPanel1 = new Siticone.UI.WinForms.SiticoneGradientPanel();
            this.siticonePictureBox1 = new Siticone.UI.WinForms.SiticonePictureBox();
            this.btn_refuser = new Siticone.UI.WinForms.SiticoneButton();
            this.btn_Accepter = new Siticone.UI.WinForms.SiticoneButton();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.siticoneGradientButton1 = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.dataGridView_NewRv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datePriseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rendezvousBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siticoneElipse2 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.panel1.SuspendLayout();
            this.siticoneGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NewRv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendezvousBindingSource)).BeginInit();
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
            this.panel1.Controls.Add(this.siticoneButton4);
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(275, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 37);
            this.panel1.TabIndex = 23;
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
            this.btn_Minimize.Location = new System.Drawing.Point(745, 3);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(30, 30);
            this.btn_Minimize.TabIndex = 0;
            this.btn_Minimize.UseVisualStyleBackColor = true;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
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
            // btn_Exit
            // 
            this.btn_Exit.BackgroundImage = global::GetWell.Properties.Resources.appbar_close;
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Location = new System.Drawing.Point(780, 3);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(30, 30);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // NewRvchecker
            // 
            this.NewRvchecker.Enabled = true;
            this.NewRvchecker.Interval = 3000;
            this.NewRvchecker.Tick += new System.EventHandler(this.NewRvchecker_Tick);
            // 
            // siticoneGradientPanel1
            // 
            this.siticoneGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneGradientPanel1.Controls.Add(this.siticonePictureBox1);
            this.siticoneGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.siticoneGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.siticoneGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(159)))));
            this.siticoneGradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.siticoneGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.siticoneGradientPanel1.Name = "siticoneGradientPanel1";
            this.siticoneGradientPanel1.ShadowDecoration.Parent = this.siticoneGradientPanel1;
            this.siticoneGradientPanel1.Size = new System.Drawing.Size(275, 610);
            this.siticoneGradientPanel1.TabIndex = 26;
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.Image = global::GetWell.Properties.Resources.v870_tang_36;
            this.siticonePictureBox1.Location = new System.Drawing.Point(0, -101);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.ShadowDecoration.Parent = this.siticonePictureBox1;
            this.siticonePictureBox1.Size = new System.Drawing.Size(955, 814);
            this.siticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticonePictureBox1.TabIndex = 9;
            this.siticonePictureBox1.TabStop = false;
            this.siticonePictureBox1.UseTransparentBackground = true;
            // 
            // btn_refuser
            // 
            this.btn_refuser.BorderRadius = 20;
            this.btn_refuser.CheckedState.Parent = this.btn_refuser;
            this.btn_refuser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refuser.CustomImages.Parent = this.btn_refuser;
            this.btn_refuser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(35)))), ((int)(((byte)(27)))));
            this.btn_refuser.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_refuser.ForeColor = System.Drawing.Color.White;
            this.btn_refuser.HoveredState.Parent = this.btn_refuser;
            this.btn_refuser.Image = global::GetWell.Properties.Resources.appbar2;
            this.btn_refuser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_refuser.ImageOffset = new System.Drawing.Point(10, 0);
            this.btn_refuser.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_refuser.Location = new System.Drawing.Point(961, 556);
            this.btn_refuser.Name = "btn_refuser";
            this.btn_refuser.ShadowDecoration.Parent = this.btn_refuser;
            this.btn_refuser.Size = new System.Drawing.Size(124, 40);
            this.btn_refuser.TabIndex = 5;
            this.btn_refuser.Text = "Refuser";
            this.btn_refuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_refuser.TextOffset = new System.Drawing.Point(10, 0);
            this.btn_refuser.Click += new System.EventHandler(this.btn_refuser_Click);
            // 
            // btn_Accepter
            // 
            this.btn_Accepter.BorderRadius = 20;
            this.btn_Accepter.CheckedState.Parent = this.btn_Accepter;
            this.btn_Accepter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Accepter.CustomImages.Parent = this.btn_Accepter;
            this.btn_Accepter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(162)))), ((int)(((byte)(70)))));
            this.btn_Accepter.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_Accepter.ForeColor = System.Drawing.Color.White;
            this.btn_Accepter.HoveredState.Parent = this.btn_Accepter;
            this.btn_Accepter.Image = global::GetWell.Properties.Resources.appbar_check;
            this.btn_Accepter.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_Accepter.ImageOffset = new System.Drawing.Point(5, 0);
            this.btn_Accepter.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Accepter.Location = new System.Drawing.Point(831, 556);
            this.btn_Accepter.Name = "btn_Accepter";
            this.btn_Accepter.ShadowDecoration.Parent = this.btn_Accepter;
            this.btn_Accepter.Size = new System.Drawing.Size(124, 40);
            this.btn_Accepter.TabIndex = 5;
            this.btn_Accepter.Text = "Accepter";
            this.btn_Accepter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Accepter.TextOffset = new System.Drawing.Point(10, 0);
            this.btn_Accepter.Click += new System.EventHandler(this.btn_Accepter_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.BorderRadius = 20;
            this.guna2GradientPanel1.Controls.Add(this.siticoneGradientButton1);
            this.guna2GradientPanel1.Controls.Add(this.dataGridView_NewRv);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(292, 52);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(793, 498);
            this.guna2GradientPanel1.TabIndex = 25;
            // 
            // siticoneGradientButton1
            // 
            this.siticoneGradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneGradientButton1.BorderRadius = 10;
            this.siticoneGradientButton1.CheckedState.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.CustomImages.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneGradientButton1.FillColor2 = System.Drawing.Color.Transparent;
            this.siticoneGradientButton1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this.siticoneGradientButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.siticoneGradientButton1.HoveredState.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.Location = new System.Drawing.Point(12, 12);
            this.siticoneGradientButton1.Name = "siticoneGradientButton1";
            this.siticoneGradientButton1.ShadowDecoration.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.Size = new System.Drawing.Size(772, 45);
            this.siticoneGradientButton1.TabIndex = 4;
            this.siticoneGradientButton1.Text = "nouveaux rendez-vous";
            // 
            // dataGridView_NewRv
            // 
            this.dataGridView_NewRv.AllowUserToAddRows = false;
            this.dataGridView_NewRv.AllowUserToDeleteRows = false;
            this.dataGridView_NewRv.AllowUserToResizeColumns = false;
            this.dataGridView_NewRv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(207)))), ((int)(((byte)(246)))));
            this.dataGridView_NewRv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_NewRv.AutoGenerateColumns = false;
            this.dataGridView_NewRv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_NewRv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.dataGridView_NewRv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_NewRv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_NewRv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_NewRv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_NewRv.ColumnHeadersHeight = 40;
            this.dataGridView_NewRv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_NewRv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.dateDataGridViewTextBoxColumn,
            this.datePriseDataGridViewTextBoxColumn,
            this.tempDataGridViewTextBoxColumn,
            this.patientDataGridViewTextBoxColumn});
            this.dataGridView_NewRv.DataSource = this.rendezvousBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(207)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_NewRv.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_NewRv.EnableHeadersVisualStyles = false;
            this.dataGridView_NewRv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.dataGridView_NewRv.Location = new System.Drawing.Point(12, 66);
            this.dataGridView_NewRv.MultiSelect = false;
            this.dataGridView_NewRv.Name = "dataGridView_NewRv";
            this.dataGridView_NewRv.ReadOnly = true;
            this.dataGridView_NewRv.RowHeadersVisible = false;
            this.dataGridView_NewRv.RowTemplate.Height = 40;
            this.dataGridView_NewRv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_NewRv.Size = new System.Drawing.Size(772, 419);
            this.dataGridView_NewRv.TabIndex = 2;
            this.dataGridView_NewRv.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightBlue;
            this.dataGridView_NewRv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.dataGridView_NewRv.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.dataGridView_NewRv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_NewRv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(207)))), ((int)(((byte)(246)))));
            this.dataGridView_NewRv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_NewRv.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.dataGridView_NewRv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.dataGridView_NewRv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.dataGridView_NewRv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_NewRv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial", 10F);
            this.dataGridView_NewRv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_NewRv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_NewRv.ThemeStyle.HeaderStyle.Height = 40;
            this.dataGridView_NewRv.ThemeStyle.ReadOnly = true;
            this.dataGridView_NewRv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.dataGridView_NewRv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_NewRv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.dataGridView_NewRv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView_NewRv.ThemeStyle.RowsStyle.Height = 40;
            this.dataGridView_NewRv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(207)))), ((int)(((byte)(246)))));
            this.dataGridView_NewRv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.Id.DefaultCellStyle = dataGridViewCellStyle3;
            this.Id.FillWeight = 30.97797F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.FillWeight = 87.67332F;
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datePriseDataGridViewTextBoxColumn
            // 
            this.datePriseDataGridViewTextBoxColumn.DataPropertyName = "DatePrise";
            this.datePriseDataGridViewTextBoxColumn.FillWeight = 87.67332F;
            this.datePriseDataGridViewTextBoxColumn.HeaderText = "DatePrise";
            this.datePriseDataGridViewTextBoxColumn.Name = "datePriseDataGridViewTextBoxColumn";
            this.datePriseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tempDataGridViewTextBoxColumn
            // 
            this.tempDataGridViewTextBoxColumn.DataPropertyName = "Temp";
            this.tempDataGridViewTextBoxColumn.FillWeight = 87.67332F;
            this.tempDataGridViewTextBoxColumn.HeaderText = "Temp";
            this.tempDataGridViewTextBoxColumn.Name = "tempDataGridViewTextBoxColumn";
            this.tempDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientDataGridViewTextBoxColumn
            // 
            this.patientDataGridViewTextBoxColumn.DataPropertyName = "patient";
            this.patientDataGridViewTextBoxColumn.FillWeight = 100.6733F;
            this.patientDataGridViewTextBoxColumn.HeaderText = "patient";
            this.patientDataGridViewTextBoxColumn.Name = "patientDataGridViewTextBoxColumn";
            this.patientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rendezvousBindingSource
            // 
            this.rendezvousBindingSource.DataSource = typeof(GetWell.Rendezvous);
            // 
            // siticoneElipse2
            // 
            this.siticoneElipse2.BorderRadius = 20;
            this.siticoneElipse2.TargetControl = this.dataGridView_NewRv;
            // 
            // NewRV_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1097, 610);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_refuser);
            this.Controls.Add(this.btn_Accepter);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.siticoneGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewRV_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewRV_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewRV_Form_FormClosing);
            this.Load += new System.EventHandler(this.NewRV_Form_Load);
            this.panel1.ResumeLayout(false);
            this.siticoneGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NewRv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendezvousBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneElipse siticoneElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.Button btn_Exit;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton4;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Siticone.UI.WinForms.SiticoneGradientButton siticoneGradientButton1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_NewRv;
        private System.Windows.Forms.BindingSource rendezvousBindingSource;
        private Siticone.UI.WinForms.SiticoneButton btn_refuser;
        private Siticone.UI.WinForms.SiticoneButton btn_Accepter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datePriseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientDataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer NewRvchecker;
        private Siticone.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel1;
        private Siticone.UI.WinForms.SiticonePictureBox siticonePictureBox1;
        private Siticone.UI.WinForms.SiticoneElipse siticoneElipse2;
    }
}