using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetWell
{
    public partial class Consultation_Form : Form
    {
        public Consultation_Form()
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
        private void Consultation_Form_Load(object sender, EventArgs e)
        {
           remplireCombo(); 
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; 
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void Consultation_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login_Form.hf.Show();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Diagnostique diag = new Diagnostique();
            diag.Id_doc = Medecin.Id_doc;
            diag.Description = Description_text.Text;
            diag.Date_diag = DateTimePicker1.Value;
            diag.Id_patient = int.Parse(Patient_combobox.SelectedValue.ToString());
            DiagnostiqueController.AddDiag(diag);
            OperationDone_Form op = new OperationDone_Form();
            op.ShowDialog(); 
        }

        public void remplireCombo()
        {
            using (SqlConnection conn = new SqlConnection(DiagnostiqueController.ConnectionString))
            {
                try
                {
                    string query = "select Nom + ' ' + Prenom as 'Name', Id_patient from patient";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Patients");
                    Patient_combobox.DisplayMember = "Name";
                    Patient_combobox.ValueMember = "Id_patient";
                    Patient_combobox.DataSource = ds.Tables["Patients"];
                }
                catch(Exception)
                {
                    MessageBox.Show("Error occured!");
                }
            }
        }

        private void show_consultations_btn_Click(object sender, EventArgs e)
        {
            listDiag_and_listPatient_Form frm = new listDiag_and_listPatient_Form();
            frm.Show(); 
        }
    }
}
