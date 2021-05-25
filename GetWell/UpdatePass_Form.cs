using GetWell.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetWell
{
    public partial class UpdatePass_Form : Form
    {
        public UpdatePass_Form()
        {
            InitializeComponent();
        }
        ////////////////////////code to move the form using the mouse/////////////////////////////
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Panel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            this.ActiveControl = label1;
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void UpdatePass_Form_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }

        private void UpdatePass_Form_Click(object sender, EventArgs e)
        {
            
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txt_NewPass.Focused)
            {
                if(txt_NewPass.Text == "Nouveau mot de passe")
                { txt_NewPass.Text = ""; }
                
            }
            else
            {
                if (txt_NewPass.Text == "")
                { txt_NewPass.Text = "Nouveau mot de passe"; }
            }


            if (txt_confNewPass.Focused)
            {
                if(txt_confNewPass.Text == "Confirmer votre mot de passe")
                {
                    txt_confNewPass.Text = "";
                }
                
            }
            else
            {
                if (txt_confNewPass.Text == "")
                {
                    txt_confNewPass.Text = "Confirmer votre mot de passe";
                }
            }
        }

        private void btn_pw1_Click(object sender, EventArgs e)
        {
            if (txt_NewPass.UseSystemPasswordChar == false)
            {
                txt_NewPass.UseSystemPasswordChar = true;
                btn_pw1.Image = Resources.appbar_eye_hide; 
            }
            else
            {
                txt_NewPass.UseSystemPasswordChar = false;
                btn_pw1.Image = Resources.appbar_eye;
            }
        }

        private void btn_pw2_Click(object sender, EventArgs e)
        {
            if (txt_confNewPass.UseSystemPasswordChar == false)
            {
                txt_confNewPass.UseSystemPasswordChar = true;
                btn_pw2.Image = Resources.appbar_eye_hide;
            }
            else
            {
                txt_confNewPass.UseSystemPasswordChar = false;
                btn_pw2.Image = Resources.appbar_eye;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(txt_NewPass.Text == txt_confNewPass.Text)
            {
                MedecinController.UpdatePasword(txt_NewPass.Text, Medecin.Id_doc);
                OperationDone_Form op = new OperationDone_Form();
                op.ShowDialog();
            }
            else
            {
                label_error.Visible = true; 
            }
        }

        private void txt_NewPass_TextChanged(object sender, EventArgs e)
        {

            if (txt_NewPass.Text == txt_confNewPass.Text)
            {
                label_error.Visible = false;
            }
        }

        private void txt_confNewPass_TextChanged(object sender, EventArgs e)
        {
            if (txt_NewPass.Text == txt_confNewPass.Text)
            {
                label_error.Visible = false;
            }
        }

        private void UpdatePass_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login_Form.hf.Show();
        }
    }
}
