using System;
using System.IO;
using System.Windows.Forms;


namespace xls_mkb_Parser
{
    public partial class mainForm : System.Windows.Forms.Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                labelFileName.Text = "File: " + openFD.FileName;
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            CheckConversionPossibility();
        }


        private void labelFileName_Click(object sender, EventArgs e)
        {

        }
    }
}
