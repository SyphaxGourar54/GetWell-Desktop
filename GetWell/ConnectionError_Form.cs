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

namespace GetWell
{
    public partial class ConnectionError_Form : Form
    {
        public ConnectionError_Form()
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
        
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void panel_error_Paint(object sender, PaintEventArgs e)
        {

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


        private void timer1_Tick(object sender, EventArgs e)
        {
            if(IsConnectedToInternet())
            {
                this.Close(); 
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {

            if (IsConnectedToInternet())
            {
                this.Close();
            }
            else
            {
                refresh_img.Visible = true; 
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ConnectionError_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r; 
            if(IsConnectedToInternet() == false)
            {
                r = MessageBox.Show("voulez Vous quittiez l'application?", "information!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (r == DialogResult.Yes)
                {
                    Application.Exit(); 
                }
            
            }
        }
    }
}
