using System;
using System.IO;
using System.Windows.Forms;


namespace xls_mkb_Parser
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
        //
        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                labelFileName.Text = "File: " + openFD.FileName;
            }
            else
            {
                labelFileName.Text = "File: ";
                btnConvertToMkb.Enabled = true;
                btnConvertToXlsx.Enabled = true;
                saveFD.Filter = @"Excel file | *.xlsx | Expert system file| *.mkb";
            }
        }

        private void btnConvertToMkb_Click(object sender, EventArgs e)
        {
            Convert(".mkb", ExpSysConverter.ConvertFromXlsxToMkb);     
        }

        private void btnConvertToXlsx_Click(object sender, EventArgs e)
        {
            Convert(".xlsx", ExpSysConverter.ConvertFromMkbToXlsx);
        }

        private void Convert(string typeTo, Func<string, string, bool> methodFunc)
        {
            if (ExpSysConverter.CheckConversionPossibility(Path.GetExtension(openFD.FileName), typeTo) == false)
            {
                MessageBox.Show("Error!\nНесоответствие доступных для конвертации типов");
                return;
            }
            else
            {
                saveFD.InitialDirectory = Path.GetDirectoryName(openFD.FileName);
                saveFD.FileName = Path.GetFileNameWithoutExtension(openFD.FileName) + typeTo;
                if (saveFD.ShowDialog() == DialogResult.OK)
                {
                    methodFunc(openFD.FileName, saveFD.FileName);
                }

            }
        }
        private void labelFileName_TextChanged(object sender, EventArgs e)
        {
            if (Path.GetExtension(openFD.FileName) == ".xlsx")
            {
                btnConvertToXlsx.Enabled = false;
                btnConvertToMkb.Enabled = true;
                saveFD.Filter = @"Expert system file| *.mkb";
            }
            else if (Path.GetExtension(openFD.FileName) == ".mkb")
            {
                btnConvertToXlsx.Enabled = true;
                btnConvertToMkb.Enabled = false;
                saveFD.Filter = @"Excel file | *.xlsx";
            }
            else
            {
                btnConvertToMkb.Enabled = true;
                btnConvertToXlsx.Enabled = true;
                saveFD.Filter = @"Excel file | *.xlsx | Expert system file| *.mkb";
            }

        }

    }
}
