
namespace GetWell
{
    partial class ConfirmLocalusation_Form
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
            this.siticoneButton2 = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneButton1 = new Siticone.UI.WinForms.SiticoneButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_confirm = new Siticone.UI.WinForms.SiticoneButton();
            this.btn_Cancel = new Siticone.UI.WinForms.SiticoneButton();
            this.label_data = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // siticoneElipse1
            // 
            this.siticoneElipse1.BorderRadius = 20;
            this.siticoneElipse1.TargetControl = this;
            // 
            // siticoneButton2
            // 
            this.siticoneButton2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneButton2.BorderRadius = 10;
            this.siticoneButton2.CheckedState.Parent = this.siticoneButton2;
            this.siticoneButton2.CustomImages.Parent = this.siticoneButton2;
            this.siticoneButton2.FillColor = System.Drawing.Color.Transparent;
            this.siticoneButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneButton2.HoveredState.FillColor = System.Drawing.Color.Transparent;
            this.siticoneButton2.HoveredState.Parent = this.siticoneButton2;
            this.siticoneButton2.Image = global::GetWell.Properties.Resources.Logo3;
            this.siticoneButton2.ImageSize = new System.Drawing.Size(110, 110);
            this.siticoneButton2.Location = new System.Drawing.Point(196, 99);
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.PressedColor = System.Drawing.Color.Transparent;
            this.siticoneButton2.ShadowDecoration.Parent = this.siticoneButton2;
            this.siticoneButton2.Size = new System.Drawing.Size(99, 24);
            this.siticoneButton2.TabIndex = 1;
            this.siticoneButton2.UseTransparentBackground = true;
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
            this.siticoneButton1.HoveredState.FillColor = System.Drawing.Color.Transparent;
            this.siticoneButton1.HoveredState.Parent = this.siticoneButton1;
            this.siticoneButton1.Image = global::GetWell.Properties.Resources.LogoMarker5;
            this.siticoneButton1.ImageSize = new System.Drawing.Size(110, 110);
            this.siticoneButton1.Location = new System.Drawing.Point(196, 12);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.PressedColor = System.Drawing.Color.Transparent;
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(99, 102);
            this.siticoneButton1.TabIndex = 1;
            this.siticoneButton1.UseTransparentBackground = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Confirmez votre nouvelle localisation?";
            // 
            // btn_confirm
            // 
            this.btn_confirm.CheckedState.Parent = this.btn_confirm;
            this.btn_confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_confirm.CustomImages.Parent = this.btn_confirm;
            this.btn_confirm.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_confirm.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btn_confirm.ForeColor = System.Drawing.Color.White;
            this.btn_confirm.HoveredState.Parent = this.btn_confirm;
            this.btn_confirm.Image = global::GetWell.Properties.Resources.appbar_check;
            this.btn_confirm.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_confirm.Location = new System.Drawing.Point(-1, 213);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.ShadowDecoration.Parent = this.btn_confirm;
            this.btn_confirm.Size = new System.Drawing.Size(248, 62);
            this.btn_confirm.TabIndex = 3;
            this.btn_confirm.Text = "Confirmer";
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.CheckedState.Parent = this.btn_Cancel;
            this.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancel.CustomImages.Parent = this.btn_Cancel;
            this.btn_Cancel.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_Cancel.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.HoveredState.Parent = this.btn_Cancel;
            this.btn_Cancel.Image = global::GetWell.Properties.Resources.appbar_close;
            this.btn_Cancel.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Cancel.Location = new System.Drawing.Point(242, 213);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.ShadowDecoration.Parent = this.btn_Cancel;
            this.btn_Cancel.Size = new System.Drawing.Size(248, 62);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "Annuller";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label_data
            // 
            this.label_data.Location = new System.Drawing.Point(111, 152);
            this.label_data.Name = "label_data";
            this.label_data.Size = new System.Drawing.Size(269, 58);
            this.label_data.TabIndex = 4;
            this.label_data.Text = "label2";
            this.label_data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConfirmLocalusation_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 273);
            this.Controls.Add(this.label_data);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siticoneButton2);
            this.Controls.Add(this.siticoneButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmLocalusation_Form";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConfirmLocalusation_Form";
            this.Load += new System.EventHandler(this.ConfirmLocalusation_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneElipse siticoneElipse1;
        private Siticone.UI.WinForms.SiticoneButton btn_Cancel;
        private Siticone.UI.WinForms.SiticoneButton btn_confirm;
        private System.Windows.Forms.Label label1;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton2;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton1;
        private System.Windows.Forms.Label label_data;
    }
}