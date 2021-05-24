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
    public partial class Settings_Form : Form
    {
        public Settings_Form()
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
                this.Close();
            }
        }


        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            
        }

        private void Settings_Form_Load(object sender, EventArgs e)
        {

        }

        private void Settings_Form_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void updatePass_btn_Click(object sender, EventArgs e)
        {
            UpdatePass_Form frm = new UpdatePass_Form();
            OpenForm(frm, "StPass_Frm");
        }

        private void UpdateData_btn_Click(object sender, EventArgs e)
        {

            UpdateInfo_Form Infofrm = new UpdateInfo_Form();
            OpenForm(Infofrm, "StDAta_Frm");
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Login_Form.hf.Show();
        }
    }
}
