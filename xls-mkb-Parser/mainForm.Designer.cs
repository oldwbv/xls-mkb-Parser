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
            this.btnConvert = new System.Windows.Forms.Button();
            this.labelFileName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFD
            // 
            this.openFD.Filter = "Excel file|*.xlsx|Expert system file|*.mkb";
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(11, 27);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(86, 23);
            this.btnChoose.TabIndex = 0;
            this.btnChoose.Text = "Choose File";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(103, 27);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(88, 23);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(8, 9);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(26, 13);
            this.labelFileName.TabIndex = 3;
            this.labelFileName.Text = "File:";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(203, 58);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.btnConvert);
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
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label labelFileName;
    }
}

