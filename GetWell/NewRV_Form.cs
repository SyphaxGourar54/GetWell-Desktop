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
    public partial class NewRV_Form : Form
    {
        public NewRV_Form()
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
            this.Close(); 
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; 
        }


        public void RemplireDataGridView()
        {
            
            List<Rendezvous> list = RendezvousController.GetNonValidatedRvs(Medecin.Id_doc);
            rendezvousBindingSource.Clear(); 
            foreach (Rendezvous rv in list)
            {
                rendezvousBindingSource.Add(rv);
            }
        }
        private void NewRV_Form_Load(object sender, EventArgs e)
        {

            Home_Form.Newrv = false;
            RemplireDataGridView(); 


        }

        private void NewRV_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login_Form.hf.Show();
        }

        private void btn_Accepter_Click(object sender, EventArgs e)
        {
            if(dataGridView_NewRv.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView_NewRv.SelectedCells[0].RowIndex;
                DataGridViewRow row = dataGridView_NewRv.Rows[selectedrowindex];
                int id = Convert.ToInt32(row.Cells["Id"].Value);

                RendezvousController.AcceptRv(id);
                rendezvousBindingSource.RemoveCurrent();
                MessageBox.Show("rendez-vous accepté!", "information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); 
            
            }
        }

        private void btn_refuser_Click(object sender, EventArgs e)
        {
            if (dataGridView_NewRv.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView_NewRv.SelectedCells[0].RowIndex;
                DataGridViewRow row = dataGridView_NewRv.Rows[selectedrowindex];
                int id = Convert.ToInt32(row.Cells["Id"].Value);

                RendezvousController.RefuserRv(id);
                rendezvousBindingSource.RemoveCurrent();
                MessageBox.Show("rendez-vous Refusé!", "information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
        }

        private void NewRvchecker_Tick(object sender, EventArgs e)
        {
            if(Home_Form.Newrv == true)
            {
                RemplireDataGridView();
                Home_Form.Newrv = false; 
            }
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
