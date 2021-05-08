﻿using GetWell.Properties;
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
    public partial class Login_Form : Form
    {
        public Login_Form()
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

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(txt_UserName.Text != String.Empty && txt_Password.Text!= String.Empty)
            {
                if (Controller.Login(txt_UserName.Text, txt_Password.Text) > 0)
                {
                    Properties.Settings.Default.UserName = txt_UserName.Text;
                    Properties.Settings.Default.Save();
                    Home_Form hf = new Home_Form();
                    hf.Show();
                    this.Hide();
                }
                else
                {
                    //
                    label_error.Visible = true;
                    label_error.Text = "incorrect user name or password!";
                }
            }
            else
            {
                label_error.Visible = true;
                label_error.Text = "merci de remplire tout les champs!"; 
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(txt_UserName.Focused)
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
            //Properties.Settings.Default.UserName = String.Empty;
            //Properties.Settings.Default.Save();

            this.Name = "MainForm"; 

            if (Properties.Settings.Default.UserName != String.Empty)
            {
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false; 
                Home_Form hf = new Home_Form();
                hf.Show();
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true; 
            }
            
        }

        private void IsLoggedTimer_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UserName == String.Empty)
            {
                List<Form> openForms = new List<Form>();

                foreach (Form f in Application.OpenForms)
                    openForms.Add(f);

                foreach (Form f in openForms)
                {
                    if (f.Name != "MainForm")
                        f.Close();
                }

                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
            }
        }
    }
}
