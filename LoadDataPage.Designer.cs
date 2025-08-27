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
            label1 = new Label();
            lblInstructions = new Label();
            btnChooseSaveLocation = new Button();
            SuspendLayout();
            // 
            // btnLoadMonth
            // 
            btnLoadMonth.Location = new Point(320, 315);
            btnLoadMonth.Name = "btnLoadMonth";
            btnLoadMonth.Size = new Size(220, 30);
            btnLoadMonth.TabIndex = 0;
            btnLoadMonth.Text = "Update Month";
            btnLoadMonth.UseVisualStyleBackColor = true;
            btnLoadMonth.Click += btnLoadMonth_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(458, 12);
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
            cbBoxMonth.Location = new Point(163, 316);
            cbBoxMonth.Name = "cbBoxMonth";
            cbBoxMonth.Size = new Size(151, 28);
            cbBoxMonth.TabIndex = 3;
            // 
            // btnLoadTemplateFromFile
            // 
            btnLoadTemplateFromFile.Location = new Point(320, 367);
            btnLoadTemplateFromFile.Name = "btnLoadTemplateFromFile";
            btnLoadTemplateFromFile.Size = new Size(220, 30);
            btnLoadTemplateFromFile.TabIndex = 4;
            btnLoadTemplateFromFile.Text = "Edit Template";
            btnLoadTemplateFromFile.UseVisualStyleBackColor = true;
            btnLoadTemplateFromFile.Click += btnLoadTemplateFromFile_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 35F, FontStyle.Bold);
            label1.Location = new Point(49, 56);
            label1.Name = "label1";
            label1.Size = new Size(453, 78);
            label1.TabIndex = 5;
            label1.Text = "Budget Tracker";
            // 
            // lblInstructions
            // 
            lblInstructions.Location = new Point(103, 146);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(350, 160);
            lblInstructions.TabIndex = 6;
            lblInstructions.Text = "Instructions";
            // 
            // btnChooseSaveLocation
            // 
            btnChooseSaveLocation.Location = new Point(12, 337);
            btnChooseSaveLocation.Name = "btnChooseSaveLocation";
            btnChooseSaveLocation.Size = new Size(103, 60);
            btnChooseSaveLocation.TabIndex = 7;
            btnChooseSaveLocation.Text = "Change Save Location";
            btnChooseSaveLocation.UseVisualStyleBackColor = true;
            btnChooseSaveLocation.Click += btnChooseSaveLocation_Click;
            // 
            // LoadDataPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 420);
            ControlBox = false;
            Controls.Add(btnChooseSaveLocation);
            Controls.Add(lblInstructions);
            Controls.Add(label1);
            Controls.Add(btnLoadTemplateFromFile);
            Controls.Add(cbBoxMonth);
            Controls.Add(btnExit);
            Controls.Add(btnLoadMonth);
            Name = "LoadDataPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoadMonth;
        private Button btnExit;
        private ComboBox cbBoxMonth;
        private Button btnLoadTemplateFromFile;
        private Label label1;
        private Label lblInstructions;
        private Button btnChooseSaveLocation;
    }
}