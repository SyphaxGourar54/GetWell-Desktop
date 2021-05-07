using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetWell
{
    public partial class ConfirmLocalusation_Form : Form
    {
        public ConfirmLocalusation_Form()
        {
            InitializeComponent();
        }

        private void ConfirmLocalusation_Form_Load(object sender, EventArgs e)
        {
            label_data.Text = LocalisationData.Get(); 
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
