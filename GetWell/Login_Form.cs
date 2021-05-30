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
using System.Threading;


namespace GetWell
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }



        public static Home_Form hf = new Home_Form();

        ///////////////////////////////check connection state///////////////////////
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
        //////////////////////////////////////////////////////

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
        private void siticoneRoundedTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.ActiveControl = label2;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void OpenForm()
        {
            hf = new Home_Form();

            hf.Show();

            this.Hide();
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_UserName.Text != String.Empty && txt_Password.Text != String.Empty)
            {
                if (MedecinController.Login(txt_UserName.Text, txt_Password.Text) > 0)
                {
                    Properties.Settings.Default.UserName = txt_UserName.Text;
                    Properties.Settings.Default.Save();
                    MedecinController.GetDocData();
                    Task.Delay(1000);
                    OpenForm(); 
                    



                }
                else
                {
                    //
                    MessageBox.Show("incorrect user name or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }
            }
            else
            {
                MessageBox.Show("merci de remplire tout les champs!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (txt_UserName.Focused)
            {
                txt_UserName.IconLeft = Resources.profileIcon2;
            }
            else
            {
                txt_UserName.IconLeft = Resources.profileIcon;
            }

            if (txt_Password.Focused)
            {
                txt_Password.IconLeft = Resources.password2;
            }
            else
            {
                txt_Password.IconLeft = Resources.password;
            }
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            //Properties.Settings.Default.UserName = "Gourar54";  //String.Empty;
            //Properties.Settings.Default.Save();
            //MessageBox.Show(Properties.Settings.Default.UserName); 
            //MedecinController.UpdatePasword("azerty", 23); 
            //MessageBox.Show(MedecinController.GetDocData().ToString());
            //MessageBox.Show(MedecinController.error); 

            checkInternetConnection();


            this.Name = "MainForm";

            if (Properties.Settings.Default.UserName != String.Empty)
            {
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
                if (MedecinController.GetDocData())
                {
                   
                    hf.Show();
                }
                    
                else
                    Properties.Settings.Default.UserName = String.Empty;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
            }

        }

        
        
        private void IsLoggedTimer_Tick(object sender, EventArgs e)
        {


            //checkInternetConnection();
            
            if (Properties.Settings.Default.UserName == String.Empty)
            {
                List<Form> openForms = new List<Form>();

                foreach (Form f in Application.OpenForms)
                    openForms.Add(f);

                foreach (Form f in openForms)
                {
                    if (f != this && f.Name != "error_frm")
                        f.Close();
                }

                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
            }

        }

        FormCollection fc = Application.OpenForms;
        public void checkInternetConnection()
        {
            if (!IsConnectedToInternet())
            {
               
                bool bFormNameOpen = false;
                foreach (Form form in fc)
                {
                    if (form.Name == "error_frm")
                    {
                        bFormNameOpen = true;
                    }
                }

                if (!bFormNameOpen)
                {
                    ConnectionError_Form error_frm = new ConnectionError_Form();
                    error_frm.Name = "error_frm";
                    error_frm.ShowDialog();
                    error_frm.TopMost = true;
                         
                    
                }
                
            }

        }

        private void label_error_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void siticonePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void siticonePictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
