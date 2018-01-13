namespace xls_mkb_Parser
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnConvertToMkb = new System.Windows.Forms.Button();
            this.labelFileName = new System.Windows.Forms.Label();
            this.saveFD = new System.Windows.Forms.SaveFileDialog();
            this.btnConvertToXlsx = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFD
            // 
            this.openFD.Filter = "all|*.*|Excel file|*.xlsx|Expert system file|*.mkb";
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(11, 27);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(115, 23);
            this.btnChoose.TabIndex = 0;
            this.btnChoose.Text = "Choose File";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnConvertToMkb
            // 
            this.btnConvertToMkb.Location = new System.Drawing.Point(132, 27);
            this.btnConvertToMkb.Name = "btnConvertToMkb";
            this.btnConvertToMkb.Size = new System.Drawing.Size(115, 23);
            this.btnConvertToMkb.TabIndex = 1;
            this.btnConvertToMkb.Tag = "";
            this.btnConvertToMkb.Text = "Convert To Mkb";
            this.btnConvertToMkb.UseVisualStyleBackColor = true;
            this.btnConvertToMkb.Click += new System.EventHandler(this.btnConvertToMkb_Click);
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(8, 9);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(26, 13);
            this.labelFileName.TabIndex = 3;
            this.labelFileName.Text = "File:";
            this.labelFileName.TextChanged += new System.EventHandler(this.labelFileName_TextChanged);
            // 
            // saveFD
            // 
            this.saveFD.Filter = "Excel file|*.xlsx|Expert system file|*.mkb";
            // 
            // btnConvertToXlsx
            // 
            this.btnConvertToXlsx.Location = new System.Drawing.Point(253, 27);
            this.btnConvertToXlsx.Name = "btnConvertToXlsx";
            this.btnConvertToXlsx.Size = new System.Drawing.Size(115, 23);
            this.btnConvertToXlsx.TabIndex = 4;
            this.btnConvertToXlsx.Text = "Convert To Xlsx";
            this.btnConvertToXlsx.UseVisualStyleBackColor = true;
            this.btnConvertToXlsx.Click += new System.EventHandler(this.btnConvertToXlsx_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(378, 55);
            this.Controls.Add(this.btnConvertToXlsx);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.btnConvertToMkb);
            this.Controls.Add(this.btnChoose);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expert System Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnConvertToMkb;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.SaveFileDialog saveFD;
        private System.Windows.Forms.Button btnConvertToXlsx;
    }
}

