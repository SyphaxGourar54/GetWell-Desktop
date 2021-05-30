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
    public partial class listDiag_and_listPatient_Form : Form
    {
        public listDiag_and_listPatient_Form()
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
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; 
        }

        private void listDiag_and_listPatient_Form_Load(object sender, EventArgs e)
        {
            RemplireTables(); 
        }

        public void RemplireTables()
        {
            if (DiagnostiqueController.PatientsList().Rows.Count > 0)
            {
                dgv_patient.DataSource = DiagnostiqueController.PatientsList();
                dgv_patient.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                dgv_patient.Columns["Id_Patient"].Width = 50;
                dgv_patient.Columns["Id_Patient"].HeaderText = "Id";
                dgv_patient.Columns["Email"].Width = 400;
            }
            if (DiagnostiqueController.ConsultationsList().Rows.Count > 0)
            {
                dgv_consultation.DataSource = DiagnostiqueController.ConsultationsList();
                dgv_consultation.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                dgv_consultation.Columns["Description"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                NoResult_lbl1.Visible = false;
                NoResult_lbl2.Visible = false;
            }
            

        }

        

        private void siticoneGradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void search_txtbox_TextChanged(object sender, EventArgs e)
        {
            if(search_txtbox.Text != "")
            {
                if(DiagnostiqueController.DiagRecherche(search_txtbox.Text).Rows.Count > 0)
                { 
                    dgv_consultation.DataSource = DiagnostiqueController.DiagRecherche(search_txtbox.Text); 
                    dgv_consultation.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                    dgv_consultation.Columns["Description"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                }
                else
                {
                    dgv_consultation.DataSource = null; 
                    NoResult_lbl1.Visible = true; 
                }
            }
            else
            {
                RemplireTables(); 
            }
        }

      

        private void search_textbox2_TextChanged(object sender, EventArgs e)
        {

            if (search_textbox2.Text != "")
            {
                if (DiagnostiqueController.PatientRecherche(search_textbox2.Text).Rows.Count > 0)
                {
                    dgv_patient.DataSource = DiagnostiqueController.PatientRecherche(search_textbox2.Text);
                    dgv_patient.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                    dgv_patient.Columns["Id_Patient"].Width = 50;
                    dgv_patient.Columns["Id_Patient"].HeaderText = "Id";
                    dgv_patient.Columns["Email"].Width = 400;
                }
                else
                {
                    dgv_patient.DataSource = null;
                    NoResult_lbl2.Visible = true;
                }
                
            }
            else
            {
                RemplireTables();
            }
        }
    }
}
