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
            SuspendLayout();
            // 
            // btnLoadMonth
            // 
            btnLoadMonth.Location = new Point(186, 125);
            btnLoadMonth.Name = "btnLoadMonth";
            btnLoadMonth.Size = new Size(232, 29);
            btnLoadMonth.TabIndex = 0;
            btnLoadMonth.Text = "Load Month";
            btnLoadMonth.UseVisualStyleBackColor = true;
            btnLoadMonth.Click += btnLoadMonth_Click;
            // 
            // LoadDataPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoadMonth);
            Name = "LoadDataPage";
            Text = "LoadDataPage";
            ResumeLayout(false);
        }

        #endregion

        private Button btnLoadMonth;
    }
}