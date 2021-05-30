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
    public partial class Calendar_Form : Form
    {
        public Calendar_Form()
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

        bool go = false; 
        public void Rempliredgv()
        {
            if (RendezvousController.GetRvList().Rows.Count > 0)
            {
                dgv_rvs.DataSource = RendezvousController.GetRvList();
                dgv_rvs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                NoResult_lbl1.Visible = false;
            }
            else
            {
                NoResult_lbl1.Visible = true;
            }
        }
        private void Calendar_Form_Load(object sender, EventArgs e)
        {
            Rempliredgv();
            date.Value = DateTime.Now;
            go = true; 
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; 
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Calendar_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login_Form.hf.Show();
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {
            if(go)
            { 

                if (RendezvousController.GetRvListByDate(date.Value).Rows.Count > 0)
                {
                    dgv_rvs.DataSource = RendezvousController.GetRvListByDate(date.Value);
                    dgv_rvs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                    NoResult_lbl1.Visible = false;
                }
                else
                {
                    dgv_rvs.DataSource = null;
                    NoResult_lbl1.Visible = true;
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void search_txtbox_TextChanged(object sender, EventArgs e)
        {
            if(search_txtbox.Text != "")
            { 
                if (RendezvousController.GetRvListSearchByPat(search_txtbox.Text).Rows.Count > 0)
                {
                    dgv_rvs.DataSource = RendezvousController.GetRvListSearchByPat(search_txtbox.Text);
                    dgv_rvs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                    NoResult_lbl1.Visible = false;
                }
                else
                {
                    dgv_rvs.DataSource = null; 
                    NoResult_lbl1.Visible = true;
                }
            }
            else
            {
                Rempliredgv();
            }
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            date.Value = DateTime.Now;
            Rempliredgv();
        }
    }
}
