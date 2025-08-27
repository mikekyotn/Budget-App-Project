namespace Budget_App_Project
{
    partial class AddTransactionForm
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
            label1 = new Label();
            lblHeaderMonth = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            cbBoxTransactType = new ComboBox();
            cbBoxPaymentDay = new ComboBox();
            txtDescription = new TextBox();
            txtEstPayment = new TextBox();
            chkBoxPayComplete = new CheckBox();
            txtActPayment = new TextBox();
            txtComments = new TextBox();
            button1 = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(56, 19);
            label1.Name = "label1";
            label1.Size = new Size(342, 41);
            label1.TabIndex = 0;
            label1.Text = "Add New Transaction to ";
            // 
            // lblHeaderMonth
            // 
            lblHeaderMonth.AutoSize = true;
            lblHeaderMonth.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblHeaderMonth.Location = new Point(445, 19);
            lblHeaderMonth.Name = "lblHeaderMonth";
            lblHeaderMonth.Size = new Size(157, 41);
            lblHeaderMonth.TabIndex = 1;
            lblHeaderMonth.Text = "(MONTH)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(28, 92);
            label2.Name = "label2";
            label2.Size = new Size(230, 35);
            label2.TabIndex = 2;
            label2.Text = "Type of Transaction";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(28, 143);
            label3.Name = "label3";
            label3.Size = new Size(266, 35);
            label3.TabIndex = 3;
            label3.Text = "Required Payment Day";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(28, 198);
            label4.Name = "label4";
            label4.Size = new Size(181, 35);
            label4.TabIndex = 4;
            label4.Text = "Payee / Debtor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(28, 247);
            label5.Name = "label5";
            label5.Size = new Size(226, 35);
            label5.TabIndex = 5;
            label5.Text = "Estimated Payment";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(28, 303);
            label6.Name = "label6";
            label6.Size = new Size(224, 35);
            label6.TabIndex = 6;
            label6.Text = "Payment Complete";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(312, 303);
            label7.Name = "label7";
            label7.Size = new Size(186, 35);
            label7.TabIndex = 7;
            label7.Text = "Actual Payment";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(28, 350);
            label8.Name = "label8";
            label8.Size = new Size(135, 35);
            label8.TabIndex = 8;
            label8.Text = "Comments";
            // 
            // cbBoxTransactType
            // 
            cbBoxTransactType.Font = new Font("Segoe UI", 15F);
            cbBoxTransactType.FormattingEnabled = true;
            cbBoxTransactType.Location = new Point(352, 84);
            cbBoxTransactType.Name = "cbBoxTransactType";
            cbBoxTransactType.Size = new Size(151, 43);
            cbBoxTransactType.TabIndex = 9;
            // 
            // cbBoxPaymentDay
            // 
            cbBoxPaymentDay.Font = new Font("Segoe UI", 15F);
            cbBoxPaymentDay.FormattingEnabled = true;
            cbBoxPaymentDay.IntegralHeight = false;
            cbBoxPaymentDay.Location = new Point(352, 135);
            cbBoxPaymentDay.MaxDropDownItems = 10;
            cbBoxPaymentDay.Name = "cbBoxPaymentDay";
            cbBoxPaymentDay.Size = new Size(151, 43);
            cbBoxPaymentDay.TabIndex = 10;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 12F);
            txtDescription.Location = new Point(352, 198);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(250, 34);
            txtDescription.TabIndex = 11;
            // 
            // txtEstPayment
            // 
            txtEstPayment.Font = new Font("Segoe UI", 15F);
            txtEstPayment.Location = new Point(352, 241);
            txtEstPayment.Name = "txtEstPayment";
            txtEstPayment.Size = new Size(146, 41);
            txtEstPayment.TabIndex = 12;
            // 
            // chkBoxPayComplete
            // 
            chkBoxPayComplete.AutoSize = true;
            chkBoxPayComplete.BackColor = SystemColors.ControlLightLight;
            chkBoxPayComplete.Font = new Font("Segoe UI", 9F);
            chkBoxPayComplete.Location = new Point(258, 314);
            chkBoxPayComplete.Name = "chkBoxPayComplete";
            chkBoxPayComplete.Size = new Size(18, 17);
            chkBoxPayComplete.TabIndex = 13;
            chkBoxPayComplete.UseVisualStyleBackColor = false;
            // 
            // txtActPayment
            // 
            txtActPayment.Font = new Font("Segoe UI", 15F);
            txtActPayment.Location = new Point(504, 300);
            txtActPayment.Name = "txtActPayment";
            txtActPayment.Size = new Size(146, 41);
            txtActPayment.TabIndex = 14;
            // 
            // txtComments
            // 
            txtComments.Font = new Font("Segoe UI", 12F);
            txtComments.Location = new Point(169, 352);
            txtComments.Name = "txtComments";
            txtComments.Size = new Size(481, 34);
            txtComments.TabIndex = 15;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(162, 400);
            button1.Name = "button1";
            button1.Size = new Size(94, 38);
            button1.TabIndex = 16;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.Location = new Point(424, 400);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 38);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // AddTransactionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 450);
            Controls.Add(btnSave);
            Controls.Add(button1);
            Controls.Add(txtComments);
            Controls.Add(txtActPayment);
            Controls.Add(chkBoxPayComplete);
            Controls.Add(txtEstPayment);
            Controls.Add(txtDescription);
            Controls.Add(cbBoxPaymentDay);
            Controls.Add(cbBoxTransactType);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblHeaderMonth);
            Controls.Add(label1);
            Name = "AddTransactionForm";
            Text = "Add Transaction";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblHeaderMonth;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox cbBoxTransactType;
        private ComboBox cbBoxPaymentDay;
        private TextBox txtDescription;
        private TextBox txtEstPayment;
        private CheckBox chkBoxPayComplete;
        private TextBox txtActPayment;
        private TextBox txtComments;
        private Button button1;
        private Button btnSave;
    }
}