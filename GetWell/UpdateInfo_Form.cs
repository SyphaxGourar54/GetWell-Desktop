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
    public partial class UpdateInfo_Form : Form
    {
        public UpdateInfo_Form()
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
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////
        ///
        private void txt_confNewPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateInfo_Form_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
            txt_username.Text = Medecin.Username;
            text_nom.Text = Medecin.Nom;
            txt_prenom.Text = Medecin.Prenom;
            txt_tel.Text = Medecin.Tel;
            txt_email.Text = Medecin.Email;
            txt_ville.Text = Medecin.ville;
            txt_adresse.Text = Medecin.Adresse;
            txt_facebook.Text = Medecin.Facebook;
            txt_whatsapp.Text = Medecin.Whatsapp;
            txt_instagram.Text = Medecin.Instagram;
            txt_twitter.Text = Medecin.Twitter;
            txt_linkeden.Text = Medecin.Linkeden; 
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; 
        }

        private void UpdateInfo_Form_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpdateInfo_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login_Form.hf.Show();
            
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Localisation_Form lcf = new Localisation_Form();
            lcf.Show();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            { 
                MedecinController.UpdateData(Medecin.Id_doc, txt_username.Text, text_nom.Text, txt_prenom.Text, txt_tel.Text, txt_email.Text, txt_ville.Text, txt_adresse.Text, txt_facebook.Text, txt_whatsapp.Text, txt_instagram.Text, txt_twitter.Text, txt_linkeden.Text);
                MedecinController.GetDocData();
                Properties.Settings.Default.UserName = txt_username.Text; 
                Home_Form.dataUpdated = true;
                OperationDone_Form op = new OperationDone_Form();
                op.ShowDialog();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }

        }
    }
}
