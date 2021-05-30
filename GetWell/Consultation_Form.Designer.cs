
namespace GetWell
{
    partial class Consultation_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultation_Form));
            this.siticoneElipse1 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.Patient_combobox = new Siticone.UI.WinForms.SiticoneRoundedComboBox();
            this.DateTimePicker1 = new Siticone.UI.WinForms.SiticoneRoundedDateTimePicker();
            this.siticonePanel1 = new Siticone.UI.WinForms.SiticonePanel();
            this.Description_text = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.siticoneSeparator1 = new Siticone.UI.WinForms.SiticoneSeparator();
            this.siticoneSeparator2 = new Siticone.UI.WinForms.SiticoneSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.siticoneSeparator3 = new Siticone.UI.WinForms.SiticoneSeparator();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.show_consultations_btn = new System.Windows.Forms.Button();
            this.siticoneButton3 = new Siticone.UI.WinForms.SiticoneButton();
            this.btn_save = new Siticone.UI.WinForms.SiticoneButton();
            this.siticonePictureBox3 = new Siticone.UI.WinForms.SiticonePictureBox();
            this.siticonePanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneElipse1
            // 
            this.siticoneElipse1.BorderRadius = 30;
            this.siticoneElipse1.TargetControl = this;
            // 
            // Patient_combobox
            // 
            this.Patient_combobox.BackColor = System.Drawing.Color.Transparent;
            this.Patient_combobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Patient_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Patient_combobox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Patient_combobox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patient_combobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Patient_combobox.HoveredState.Parent = this.Patient_combobox;
            this.Patient_combobox.ItemHeight = 30;
            this.Patient_combobox.ItemsAppearance.Parent = this.Patient_combobox;
            this.Patient_combobox.Location = new System.Drawing.Point(116, 165);
            this.Patient_combobox.Name = "Patient_combobox";
            this.Patient_combobox.ShadowDecoration.Parent = this.Patient_combobox;
            this.Patient_combobox.Size = new System.Drawing.Size(261, 36);
            this.Patient_combobox.TabIndex = 0;
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.CheckedState.Parent = this.DateTimePicker1;
            this.DateTimePicker1.FillColor = System.Drawing.Color.SteelBlue;
            this.DateTimePicker1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimePicker1.HoveredState.Parent = this.DateTimePicker1;
            this.DateTimePicker1.Location = new System.Drawing.Point(383, 165);
            this.DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.ShadowDecoration.Parent = this.DateTimePicker1;
            this.DateTimePicker1.Size = new System.Drawing.Size(302, 36);
            this.DateTimePicker1.TabIndex = 1;
            this.DateTimePicker1.Value = new System.DateTime(2021, 5, 2, 15, 39, 1, 552);
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.Transparent;
            this.siticonePanel1.BorderRadius = 20;
            this.siticonePanel1.Controls.Add(this.Description_text);
            this.siticonePanel1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.siticonePanel1.Location = new System.Drawing.Point(116, 264);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
            this.siticonePanel1.Size = new System.Drawing.Size(569, 190);
            this.siticonePanel1.TabIndex = 4;
            this.siticonePanel1.UseTransparentBackground = true;
            // 
            // Description_text
            // 
            this.Description_text.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Description_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Description_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description_text.Location = new System.Drawing.Point(13, 11);
            this.Description_text.Name = "Description_text";
            this.Description_text.Size = new System.Drawing.Size(542, 170);
            this.Description_text.TabIndex = 0;
            this.Description_text.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(248, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Descreption du sotuation de patient";
            // 
            // siticoneSeparator1
            // 
            this.siticoneSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneSeparator1.Location = new System.Drawing.Point(116, 237);
            this.siticoneSeparator1.Name = "siticoneSeparator1";
            this.siticoneSeparator1.Size = new System.Drawing.Size(569, 10);
            this.siticoneSeparator1.TabIndex = 18;
            this.siticoneSeparator1.UseTransparentBackground = true;
            // 
            // siticoneSeparator2
            // 
            this.siticoneSeparator2.Location = new System.Drawing.Point(116, 137);
            this.siticoneSeparator2.Name = "siticoneSeparator2";
            this.siticoneSeparator2.Size = new System.Drawing.Size(261, 10);
            this.siticoneSeparator2.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(200, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Id Patient";
            // 
            // siticoneSeparator3
            // 
            this.siticoneSeparator3.Location = new System.Drawing.Point(383, 137);
            this.siticoneSeparator3.Name = "siticoneSeparator3";
            this.siticoneSeparator3.Size = new System.Drawing.Size(302, 10);
            this.siticoneSeparator3.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bell MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(454, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Date Consultation";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Minimize);
            this.panel2.Controls.Add(this.btn_Exit);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 42);
            this.panel2.TabIndex = 25;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
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
            this.btn_Minimize.Location = new System.Drawing.Point(722, 7);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(30, 30);
            this.btn_Minimize.TabIndex = 23;
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
            this.btn_Exit.Location = new System.Drawing.Point(758, 7);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(30, 30);
            this.btn_Exit.TabIndex = 24;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bell MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(12, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ajout d\'une consultation";
            // 
            // show_consultations_btn
            // 
            this.show_consultations_btn.BackColor = System.Drawing.Color.Transparent;
            this.show_consultations_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show_consultations_btn.FlatAppearance.BorderSize = 0;
            this.show_consultations_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.show_consultations_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.show_consultations_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_consultations_btn.Font = new System.Drawing.Font("MCS ROUND", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_consultations_btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.show_consultations_btn.Location = new System.Drawing.Point(249, 541);
            this.show_consultations_btn.Name = "show_consultations_btn";
            this.show_consultations_btn.Size = new System.Drawing.Size(302, 23);
            this.show_consultations_btn.TabIndex = 26;
            this.show_consultations_btn.Text = "Afficher liste de consultations et patients";
            this.show_consultations_btn.UseVisualStyleBackColor = false;
            this.show_consultations_btn.Click += new System.EventHandler(this.show_consultations_btn_Click);
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
            this.siticoneButton3.ImageSize = new System.Drawing.Size(200, 200);
            this.siticoneButton3.Location = new System.Drawing.Point(308, 48);
            this.siticoneButton3.Name = "siticoneButton3";
            this.siticoneButton3.ShadowDecoration.Parent = this.siticoneButton3;
            this.siticoneButton3.Size = new System.Drawing.Size(184, 52);
            this.siticoneButton3.TabIndex = 22;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.BorderRadius = 22;
            this.btn_save.CheckedState.Parent = this.btn_save;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.CustomImages.Parent = this.btn_save;
            this.btn_save.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(159)))));
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(139)))), ((int)(((byte)(184)))));
            this.btn_save.HoveredState.Parent = this.btn_save;
            this.btn_save.Image = global::GetWell.Properties.Resources.appbar_clipboard_paper_check;
            this.btn_save.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_save.Location = new System.Drawing.Point(116, 477);
            this.btn_save.Name = "btn_save";
            this.btn_save.ShadowDecoration.Parent = this.btn_save;
            this.btn_save.Size = new System.Drawing.Size(569, 44);
            this.btn_save.TabIndex = 14;
            this.btn_save.Text = "Ajoutter";
            this.btn_save.UseTransparentBackground = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // siticonePictureBox3
            // 
            this.siticonePictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.siticonePictureBox3.Image = global::GetWell.Properties.Resources.Untitled_13;
            this.siticonePictureBox3.Location = new System.Drawing.Point(-201, 388);
            this.siticonePictureBox3.Name = "siticonePictureBox3";
            this.siticonePictureBox3.ShadowDecoration.Parent = this.siticonePictureBox3;
            this.siticonePictureBox3.Size = new System.Drawing.Size(543, 324);
            this.siticonePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticonePictureBox3.TabIndex = 27;
            this.siticonePictureBox3.TabStop = false;
            this.siticonePictureBox3.UseTransparentBackground = true;
            // 
            // Consultation_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(800, 619);
            this.Controls.Add(this.show_consultations_btn);
            this.Controls.Add(this.siticoneButton3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.siticoneSeparator3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.siticoneSeparator2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siticoneSeparator1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.siticonePanel1);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.Patient_combobox);
            this.Controls.Add(this.siticonePictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Consultation_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultation_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Consultation_Form_FormClosing);
            this.Load += new System.EventHandler(this.Consultation_Form_Load);
            this.siticonePanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneElipse siticoneElipse1;
        private Siticone.UI.WinForms.SiticoneRoundedDateTimePicker DateTimePicker1;
        private Siticone.UI.WinForms.SiticoneRoundedComboBox Patient_combobox;
        private Siticone.UI.WinForms.SiticonePanel siticonePanel1;
        private System.Windows.Forms.RichTextBox Description_text;
        private Siticone.UI.WinForms.SiticoneButton btn_save;
        private System.Windows.Forms.Label label3;
        private Siticone.UI.WinForms.SiticoneSeparator siticoneSeparator3;
        private System.Windows.Forms.Label label2;
        private Siticone.UI.WinForms.SiticoneSeparator siticoneSeparator2;
        private System.Windows.Forms.Label label1;
        private Siticone.UI.WinForms.SiticoneSeparator siticoneSeparator1;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button show_consultations_btn;
        private Siticone.UI.WinForms.SiticonePictureBox siticonePictureBox3;
    }
}