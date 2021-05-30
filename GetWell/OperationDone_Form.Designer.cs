
namespace GetWell
{
    partial class OperationDone_Form
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
            this.done_img = new Siticone.UI.WinForms.SiticoneCirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.siticoneGradientButton1 = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.siticoneButton2 = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneGradientPanel1 = new Siticone.UI.WinForms.SiticoneGradientPanel();
            this.siticoneShadowForm1 = new Siticone.UI.WinForms.SiticoneShadowForm(this.components);
            this.siticoneShadowPanel1 = new Siticone.UI.WinForms.SiticoneShadowPanel();
            ((System.ComponentModel.ISupportInitialize)(this.done_img)).BeginInit();
            this.siticoneGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneElipse1
            // 
            this.siticoneElipse1.BorderRadius = 40;
            this.siticoneElipse1.TargetControl = this;
            // 
            // done_img
            // 
            this.done_img.BackColor = System.Drawing.Color.Transparent;
            this.done_img.Image = global::GetWell.Properties.Resources.donegif;
            this.done_img.Location = new System.Drawing.Point(142, 43);
            this.done_img.Name = "done_img";
            this.done_img.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
            this.done_img.ShadowDecoration.Parent = this.done_img;
            this.done_img.Size = new System.Drawing.Size(177, 152);
            this.done_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.done_img.TabIndex = 3;
            this.done_img.TabStop = false;
            this.done_img.UseTransparentBackground = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MCS ROUND", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(86, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Opération effectué avec succès!";
            // 
            // siticoneGradientButton1
            // 
            this.siticoneGradientButton1.BorderRadius = 15;
            this.siticoneGradientButton1.CheckedState.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneGradientButton1.CustomImages.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.FillColor = System.Drawing.Color.DodgerBlue;
            this.siticoneGradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.siticoneGradientButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.siticoneGradientButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneGradientButton1.HoveredState.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.Location = new System.Drawing.Point(371, 197);
            this.siticoneGradientButton1.Name = "siticoneGradientButton1";
            this.siticoneGradientButton1.ShadowDecoration.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.Size = new System.Drawing.Size(77, 31);
            this.siticoneGradientButton1.TabIndex = 5;
            this.siticoneGradientButton1.Text = "OK";
            this.siticoneGradientButton1.Click += new System.EventHandler(this.siticoneGradientButton1_Click);
            // 
            // siticoneButton2
            // 
            this.siticoneButton2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneButton2.BorderRadius = 80;
            this.siticoneButton2.CheckedState.Parent = this.siticoneButton2;
            this.siticoneButton2.CustomImages.Parent = this.siticoneButton2;
            this.siticoneButton2.FillColor = System.Drawing.Color.Transparent;
            this.siticoneButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneButton2.HoveredState.Parent = this.siticoneButton2;
            this.siticoneButton2.Image = global::GetWell.Properties.Resources.Logo3;
            this.siticoneButton2.ImageSize = new System.Drawing.Size(110, 110);
            this.siticoneButton2.Location = new System.Drawing.Point(12, 197);
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.ShadowDecoration.Parent = this.siticoneButton2;
            this.siticoneButton2.Size = new System.Drawing.Size(105, 31);
            this.siticoneButton2.TabIndex = 6;
            // 
            // siticoneGradientPanel1
            // 
            this.siticoneGradientPanel1.Controls.Add(this.label1);
            this.siticoneGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.siticoneGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.siticoneGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.siticoneGradientPanel1.Name = "siticoneGradientPanel1";
            this.siticoneGradientPanel1.ShadowDecoration.Parent = this.siticoneGradientPanel1;
            this.siticoneGradientPanel1.Size = new System.Drawing.Size(460, 39);
            this.siticoneGradientPanel1.TabIndex = 7;
            this.siticoneGradientPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            // 
            // siticoneShadowPanel1
            // 
            this.siticoneShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneShadowPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.siticoneShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.siticoneShadowPanel1.Name = "siticoneShadowPanel1";
            this.siticoneShadowPanel1.Radius = 10;
            this.siticoneShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.siticoneShadowPanel1.Size = new System.Drawing.Size(460, 240);
            this.siticoneShadowPanel1.TabIndex = 8;
            // 
            // OperationDone_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(460, 240);
            this.Controls.Add(this.siticoneGradientPanel1);
            this.Controls.Add(this.siticoneButton2);
            this.Controls.Add(this.siticoneGradientButton1);
            this.Controls.Add(this.done_img);
            this.Controls.Add(this.siticoneShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OperationDone_Form";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OprationDone_Form";
            this.Load += new System.EventHandler(this.OperationDone_Form_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.done_img)).EndInit();
            this.siticoneGradientPanel1.ResumeLayout(false);
            this.siticoneGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneElipse siticoneElipse1;
        private Siticone.UI.WinForms.SiticoneCirclePictureBox done_img;
        private Siticone.UI.WinForms.SiticoneGradientButton siticoneGradientButton1;
        private System.Windows.Forms.Label label1;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton2;
        private Siticone.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel1;
        private Siticone.UI.WinForms.SiticoneShadowPanel siticoneShadowPanel1;
        private Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm1;
    }
}