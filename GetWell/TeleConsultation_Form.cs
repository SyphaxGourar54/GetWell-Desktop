using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetWell
{
    public partial class TeleConsultation_Form : Form
    {
        public TeleConsultation_Form()
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


        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TeleConsultation_Form_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
            RemplireTable();
        }

        public void RemplireTable()
        {
            if (TeleConsultationController.TClist().Rows.Count > 0)
            {
                dgv_teleconsultation.DataSource = TeleConsultationController.TClist();
                dgv_teleconsultation.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                dgv_teleconsultation.Columns["Description"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgv_teleconsultation.Columns["Email1"].Visible = false;
                remplireData();
                NoResult_lbl1.Visible = false;
            }

        }

        private void TeleConsultation_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login_Form.hf.Show();
        }

        private void Description_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticonePanel1_Paint(object sender, PaintEventArgs e)
        {
            this.ActiveControl = Response_text;
        }

        private void TeleConsultation_Form_Click(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }

        void remplireData()
        {
            if (dgv_teleconsultation.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgv_teleconsultation.SelectedCells[0].RowIndex;
                DataGridViewRow row = dgv_teleconsultation.Rows[selectedrowindex];
                string Email = row.Cells["Email"].Value.ToString();
                string Patient = row.Cells["patient"].Value.ToString();

                patient_TextBox.Text = Patient;
                Email_textbox.Text = Email;


            }
        }
        private void dgv_teleconsultation_Click(object sender, EventArgs e)
        {

        }

        private void dgv_teleconsultation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            remplireData();
        }

        private void dgv_teleconsultation_SelectionChanged(object sender, EventArgs e)
        {
            remplireData();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string body = @"<center><img src='https://ofpptcasa-my.sharepoint.com/personal/gourar_abderrahim_ofppt-edu_ma/Documents/LogoPNG.png' alt='' width='100' style='margin: 10px auto; '>  </center>
                     <center><div class='from' style='width:fit-content;margin:20px; padding: 15px; background-color: rgb(15, 53, 102); color:white; border-radius: 30px;'>De: " + Medecin.Nom + " " + Medecin.Prenom
                     + @"</div></center>
                  <center><div class='message' style='width:fit-content; padding: 15px; background-color: rgb(221, 221, 221); color:rgb(31, 31, 31); border-radius: 30px;'>
                     <h2>Message:</h2><p style='max-width: 80vh;'>" + Response_text.Text + @"</p>
                   </div></center >
                   <center><p style='color: brown;'>this email was generated from GetWell desktop Application</p></center>";
                
                
                
                MailMessage mm = new MailMessage(Medecin.Email, Email_textbox.Text, "Reponse au TeleConsultation(GetWell)", body);
                mm.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;

                System.Net.NetworkCredential networkCredential = new System.Net.NetworkCredential("getwellapplication@gmail.com", "getwell54");
                smtp.Credentials = networkCredential;
                smtp.EnableSsl = true;
                smtp.Send(mm);
                Response_text.Text = "";
                OperationDone_Form op = new OperationDone_Form();
                op.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void search_txtbox_TextChanged(object sender, EventArgs e)
        {
            if (search_txtbox.Text != "")
            {
                if (TeleConsultationController.TcRecherche(search_txtbox.Text).Rows.Count > 0)
                {
                    NoResult_lbl1.Visible = false;
                    dgv_teleconsultation.DataSource = TeleConsultationController.TcRecherche(search_txtbox.Text);
                    dgv_teleconsultation.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                    dgv_teleconsultation.Columns["Description"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                }
                else
                {
                    dgv_teleconsultation.DataSource = null;
                    NoResult_lbl1.Visible = true;
                }
            }
            else
            {
                RemplireTable();
            }
        }
    }
}
