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
using Tulpep.NotificationWindow;

namespace GetWell
{
    public partial class Home_Form : Form
    {
        public Home_Form()
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

        /////////////////////////////////////////////////////

        public static bool Newrv = false; 
        FormCollection fc = Application.OpenForms;
        private void OpenForm(Form frm, string name)
        {

            bool bFormNameOpen = false;
            foreach (Form form in fc)
            {
                //iterate through
                if (form.Name == name)
                {
                    bFormNameOpen = true;
                    form.TopMost = true; 
                }
            }

            if (!bFormNameOpen)
            {
                
                frm.Name = name;
                frm.Show();
                this.Hide(); 
            }
        }


        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable; 
            this.WindowState = FormWindowState.Minimized;
            this.FormBorderStyle = FormBorderStyle.None; 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void siticoneGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Form_Load(object sender, EventArgs e)
        {
            //Properties.Settings.Default.UserName = String.Empty; 


            if (Properties.Settings.Default.UserName != String.Empty)
            {
                label_welcome.Text = "Bienvenu!\nMr " + Medecin.Nom;
                label_NewRV.Text = MedecinController.NewRV(Medecin.Id_doc).ToString(); 

            }
            else
            {
                this.Close();
            }


            notification.Image = Resources.notificationSmallWhite;
            notification.ImagePadding = new Padding(0, 20, 0, 0);
            notification.TitlePadding = new Padding(0, 20, 0, 0);
            notification.TitleText = "Nouveau Rendez-Vous";
            notification.ContentText = "vous avez un nouveau rendez-vous, vous peuvez le valider maintenent";
            notification.TitleColor = Color.White;
            notification.TitleFont = new Font("Arial", 16);
            notification.BodyColor = Color.FromArgb(0, 140, 176);
            notification.BorderColor = Color.Transparent;
            notification.OptionsMenu = new ContextMenuStrip();
            notification.OptionsMenu.Items.Add("Never Show again");

            notification.OptionsMenu.Items[0].Click += new EventHandler(this.HideNotification); 
        }


        public void HideNotification(object sender, EventArgs e)
        {
            Properties.Settings.Default.ShowNotification = false;
            notification.Hide(); 
        }

        //test notification
        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            //PopupNotifier notification = new PopupNotifier();
            //notification.Image = Resources.notificationSmall2;
            //notification.TitleText = "nouveau rendez-vous";
            //notification.ContentText = "vous avez un nouveau rendez-vous, vous peuvez le valider maintenent";
            //notification.Popup();
        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserName = String.Empty;
            Properties.Settings.Default.Save();
        }

        private void CheckForNewRV_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UserName != String.Empty)
            {
                label_NewRV.Text = MedecinController.NewRV(Medecin.Id_doc).ToString();
            }
        }

        private void label_NewRV_TextChanged(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.ShowNotification)
            {
                notification.Popup();
            }

            Newrv = true; 


        }

        private void notification_Click(object sender, EventArgs e)
        {

            if (Properties.Settings.Default.UserName == String.Empty)
            {

                NewRV_Form frm = new NewRV_Form();
                OpenForm(frm, "Cal_Frm");

            }
        }

        private void btn_calendrier_Click(object sender, EventArgs e)
        {
            Calendar_Form frm = new Calendar_Form(); 
            OpenForm(frm, "Cal_Frm");

        }

        private void btn_consultation_Click(object sender, EventArgs e)
        {
            Consultation_Form frm = new Consultation_Form();
            OpenForm(frm, "Cal_Frm");
        }

        private void btn_teleconsultation_Click(object sender, EventArgs e)
        {
            TeleConsultation_Form frm = new TeleConsultation_Form();
            OpenForm(frm, "Cal_Frm");
        }

        private void btn_newrv_Click(object sender, EventArgs e)
        {
            NewRV_Form frm = new NewRV_Form();
            OpenForm(frm, "Cal_Frm");
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            Settings_Form frm = new Settings_Form();
            OpenForm(frm, "Cal_Frm");
        }

        
    }
}
