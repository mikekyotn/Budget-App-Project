namespace Budget_App_Project
{
    partial class LoadDataPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLoadMonth = new Button();
            btnExit = new Button();
            cbBoxMonth = new ComboBox();
            btnLoadTemplateFromFile = new Button();
            SuspendLayout();
            // 
            // btnLoadMonth
            // 
            btnLoadMonth.Location = new Point(295, 95);
            btnLoadMonth.Name = "btnLoadMonth";
            btnLoadMonth.Size = new Size(232, 29);
            btnLoadMonth.TabIndex = 0;
            btnLoadMonth.Text = "Load Month";
            btnLoadMonth.UseVisualStyleBackColor = true;
            btnLoadMonth.Click += btnLoadMonth_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(659, 383);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // cbBoxMonth
            // 
            cbBoxMonth.FormattingEnabled = true;
            cbBoxMonth.Location = new Point(542, 96);
            cbBoxMonth.Name = "cbBoxMonth";
            cbBoxMonth.Size = new Size(151, 28);
            cbBoxMonth.TabIndex = 3;
            // 
            // btnLoadTemplateFromFile
            // 
            btnLoadTemplateFromFile.Location = new Point(301, 138);
            btnLoadTemplateFromFile.Name = "btnLoadTemplateFromFile";
            btnLoadTemplateFromFile.Size = new Size(226, 29);
            btnLoadTemplateFromFile.TabIndex = 4;
            btnLoadTemplateFromFile.Text = "Load Template";
            btnLoadTemplateFromFile.UseVisualStyleBackColor = true;
            btnLoadTemplateFromFile.Click += btnLoadTemplateFromFile_Click;
            // 
            // LoadDataPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoadTemplateFromFile);
            Controls.Add(cbBoxMonth);
            Controls.Add(btnExit);
            Controls.Add(btnLoadMonth);
            Name = "LoadDataPage";
            Text = "LoadDataPage";
            ResumeLayout(false);
        }

        #endregion

        private Button btnLoadMonth;
        private Button btnExit;
        private ComboBox cbBoxMonth;
        private Button btnLoadTemplateFromFile;
    }
}