using GetWell.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
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
        public static bool dataUpdated = false; 
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


        int[] numberOfNewRv = new int[2];

        private void Home_Form_Load(object sender, EventArgs e)
        {
            //Properties.Settings.Default.UserName = String.Empty; 

            
            if (Properties.Settings.Default.UserName != String.Empty)
            {
                label_welcome.Text = "Bienvenu!\nMr " + Medecin.Nom;
                if(MedecinController.NewRV(Medecin.Id_doc) != -1)
                {
                    label_NewRV.Text = MedecinController.NewRV(Medecin.Id_doc).ToString();
                    numberOfNewRv[0] = 0;
                    numberOfNewRv[1] = int.Parse(label_NewRV.Text);
                }
                else
                {
                    label_NewRV.Text = "!"; 
                }
                
                
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
            notification.Popup();
        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserName = String.Empty;
            Properties.Settings.Default.Save();
            Application.Exit(); 
        }

        int newrv; 
        private void CheckForNewRV_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UserName != String.Empty)
            {
                newrv = MedecinController.NewRV(Medecin.Id_doc); 
                if (newrv != -1)
                {
                    label_NewRV.Text = newrv.ToString();
                }
                
            }

            if(dataUpdated)
            {
                dataUpdated = false;
                label_welcome.Text = "Bienvenu!\nMr " + Medecin.Nom;

            }
        }

        
        private void label_NewRV_TextChanged(object sender, EventArgs e)
        {
            if(label_NewRV.Text != "!")
            { 
                if(Properties.Settings.Default.ShowNotification )
                {
                 
                    numberOfNewRv[0] = numberOfNewRv[1];
                    numberOfNewRv[1] = int.Parse(label_NewRV.Text);
                
                    if(numberOfNewRv[1] > numberOfNewRv[0])
                        notification.Popup();
                
                }
                Newrv = true;
            }


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

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_Time.Text = DateTime.Now.ToString("h:mm:ss tt");
        }

        private void Home_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Properties.Settings.Default.UserName != String.Empty && IsConnectedToInternet() == true)
            {
                Application.Exit(); 
            }
        }

        public bool IsConnectedToInternet()
        {
            try
            {
                Ping myPing = new Ping();
                String host = "google.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                return (reply.Status == IPStatus.Success);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
