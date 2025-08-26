namespace Budget_App_Project
{
    partial class MonthViewDashboard
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
            components = new System.ComponentModel.Container();
            txtCurrentFunds = new TextBox();
            dataGridView1 = new DataGridView();
            transactionMonth = new DataGridViewTextBoxColumn();
            dayOfMonthToPayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            paymentEstimatedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paymentActualDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isPaidDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            isRecurringPaymentDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            isAutoPaySetupDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            commentsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transactionBindingSource = new BindingSource(components);
            btnSaveTransactions = new Button();
            btnNewTransaction = new Button();
            lblMonth = new Label();
            btnBackToMain = new Button();
            btnDeleteTransaction = new Button();
            btnCopyTemplateToMonth = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblEstimatedEndBalance = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblIncomeBudgeted = new Label();
            lblExpenseBudgeted = new Label();
            lblIncomeActual = new Label();
            lblExpenseActual = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transactionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // txtCurrentFunds
            // 
            txtCurrentFunds.Location = new Point(80, 39);
            txtCurrentFunds.Name = "txtCurrentFunds";
            txtCurrentFunds.Size = new Size(98, 27);
            txtCurrentFunds.TabIndex = 0;
            txtCurrentFunds.Text = "0";
            txtCurrentFunds.TextAlign = HorizontalAlignment.Right;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { transactionMonth, dayOfMonthToPayDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, Type, paymentEstimatedDataGridViewTextBoxColumn, paymentActualDataGridViewTextBoxColumn, isPaidDataGridViewCheckBoxColumn, isRecurringPaymentDataGridViewCheckBoxColumn, isAutoPaySetupDataGridViewCheckBoxColumn, categoryDataGridViewTextBoxColumn, commentsDataGridViewTextBoxColumn });
            dataGridView1.DataSource = transactionBindingSource;
            dataGridView1.Location = new Point(12, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1258, 353);
            dataGridView1.TabIndex = 1;
            // 
            // transactionMonth
            // 
            transactionMonth.DataPropertyName = "transactionMonth";
            transactionMonth.HeaderText = "transactionMonth";
            transactionMonth.MinimumWidth = 6;
            transactionMonth.Name = "transactionMonth";
            transactionMonth.Visible = false;
            transactionMonth.Width = 125;
            // 
            // dayOfMonthToPayDataGridViewTextBoxColumn
            // 
            dayOfMonthToPayDataGridViewTextBoxColumn.DataPropertyName = "DayOfMonthToPay";
            dayOfMonthToPayDataGridViewTextBoxColumn.HeaderText = "Due Day";
            dayOfMonthToPayDataGridViewTextBoxColumn.MinimumWidth = 6;
            dayOfMonthToPayDataGridViewTextBoxColumn.Name = "dayOfMonthToPayDataGridViewTextBoxColumn";
            dayOfMonthToPayDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.Width = 250;
            // 
            // Type
            // 
            Type.DataPropertyName = "Type";
            Type.HeaderText = "Type";
            Type.MinimumWidth = 6;
            Type.Name = "Type";
            Type.Width = 125;
            // 
            // paymentEstimatedDataGridViewTextBoxColumn
            // 
            paymentEstimatedDataGridViewTextBoxColumn.DataPropertyName = "PaymentEstimated";
            paymentEstimatedDataGridViewTextBoxColumn.HeaderText = "Budgeted";
            paymentEstimatedDataGridViewTextBoxColumn.MinimumWidth = 6;
            paymentEstimatedDataGridViewTextBoxColumn.Name = "paymentEstimatedDataGridViewTextBoxColumn";
            paymentEstimatedDataGridViewTextBoxColumn.Width = 125;
            // 
            // paymentActualDataGridViewTextBoxColumn
            // 
            paymentActualDataGridViewTextBoxColumn.DataPropertyName = "PaymentActual";
            paymentActualDataGridViewTextBoxColumn.HeaderText = "Amount Paid";
            paymentActualDataGridViewTextBoxColumn.MinimumWidth = 6;
            paymentActualDataGridViewTextBoxColumn.Name = "paymentActualDataGridViewTextBoxColumn";
            paymentActualDataGridViewTextBoxColumn.Width = 125;
            // 
            // isPaidDataGridViewCheckBoxColumn
            // 
            isPaidDataGridViewCheckBoxColumn.DataPropertyName = "IsPaid";
            isPaidDataGridViewCheckBoxColumn.HeaderText = "Payment Complete";
            isPaidDataGridViewCheckBoxColumn.MinimumWidth = 6;
            isPaidDataGridViewCheckBoxColumn.Name = "isPaidDataGridViewCheckBoxColumn";
            isPaidDataGridViewCheckBoxColumn.Width = 125;
            // 
            // isRecurringPaymentDataGridViewCheckBoxColumn
            // 
            isRecurringPaymentDataGridViewCheckBoxColumn.DataPropertyName = "IsRecurringPayment";
            isRecurringPaymentDataGridViewCheckBoxColumn.HeaderText = "IsRecurringPayment";
            isRecurringPaymentDataGridViewCheckBoxColumn.MinimumWidth = 6;
            isRecurringPaymentDataGridViewCheckBoxColumn.Name = "isRecurringPaymentDataGridViewCheckBoxColumn";
            isRecurringPaymentDataGridViewCheckBoxColumn.Visible = false;
            isRecurringPaymentDataGridViewCheckBoxColumn.Width = 125;
            // 
            // isAutoPaySetupDataGridViewCheckBoxColumn
            // 
            isAutoPaySetupDataGridViewCheckBoxColumn.DataPropertyName = "IsAutoPaySetup";
            isAutoPaySetupDataGridViewCheckBoxColumn.HeaderText = "IsAutoPaySetup";
            isAutoPaySetupDataGridViewCheckBoxColumn.MinimumWidth = 6;
            isAutoPaySetupDataGridViewCheckBoxColumn.Name = "isAutoPaySetupDataGridViewCheckBoxColumn";
            isAutoPaySetupDataGridViewCheckBoxColumn.Visible = false;
            isAutoPaySetupDataGridViewCheckBoxColumn.Width = 125;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            categoryDataGridViewTextBoxColumn.Width = 150;
            // 
            // commentsDataGridViewTextBoxColumn
            // 
            commentsDataGridViewTextBoxColumn.DataPropertyName = "Comments";
            commentsDataGridViewTextBoxColumn.HeaderText = "Comments";
            commentsDataGridViewTextBoxColumn.MinimumWidth = 6;
            commentsDataGridViewTextBoxColumn.Name = "commentsDataGridViewTextBoxColumn";
            commentsDataGridViewTextBoxColumn.Width = 300;
            // 
            // transactionBindingSource
            // 
            transactionBindingSource.DataSource = typeof(Transaction);
            // 
            // btnSaveTransactions
            // 
            btnSaveTransactions.Location = new Point(1146, 519);
            btnSaveTransactions.Name = "btnSaveTransactions";
            btnSaveTransactions.Size = new Size(124, 65);
            btnSaveTransactions.TabIndex = 2;
            btnSaveTransactions.Text = "Save Updates";
            btnSaveTransactions.UseVisualStyleBackColor = true;
            btnSaveTransactions.Click += btnSaveTransactions_Click;
            // 
            // btnNewTransaction
            // 
            btnNewTransaction.Location = new Point(821, 519);
            btnNewTransaction.Name = "btnNewTransaction";
            btnNewTransaction.Size = new Size(124, 65);
            btnNewTransaction.TabIndex = 3;
            btnNewTransaction.Text = "Add Transaction";
            btnNewTransaction.UseVisualStyleBackColor = true;
            btnNewTransaction.Click += btnNewTransaction_Click;
            // 
            // lblMonth
            // 
            lblMonth.AutoSize = true;
            lblMonth.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblMonth.Location = new Point(780, 22);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(152, 46);
            lblMonth.TabIndex = 4;
            lblMonth.Text = "(month)";
            // 
            // btnBackToMain
            // 
            btnBackToMain.Location = new Point(1146, 17);
            btnBackToMain.Name = "btnBackToMain";
            btnBackToMain.Size = new Size(124, 65);
            btnBackToMain.TabIndex = 5;
            btnBackToMain.Text = "Back to Main";
            btnBackToMain.UseVisualStyleBackColor = true;
            btnBackToMain.Click += btnBackToMain_Click;
            // 
            // btnDeleteTransaction
            // 
            btnDeleteTransaction.Location = new Point(951, 519);
            btnDeleteTransaction.Name = "btnDeleteTransaction";
            btnDeleteTransaction.Size = new Size(124, 65);
            btnDeleteTransaction.TabIndex = 6;
            btnDeleteTransaction.Text = "Delete Transaction";
            btnDeleteTransaction.UseVisualStyleBackColor = true;
            btnDeleteTransaction.Click += btnDeleteTransaction_Click;
            // 
            // btnCopyTemplateToMonth
            // 
            btnCopyTemplateToMonth.Location = new Point(13, 536);
            btnCopyTemplateToMonth.Name = "btnCopyTemplateToMonth";
            btnCopyTemplateToMonth.Size = new Size(128, 31);
            btnCopyTemplateToMonth.TabIndex = 7;
            btnCopyTemplateToMonth.Text = "Load Template";
            btnCopyTemplateToMonth.UseVisualStyleBackColor = true;
            btnCopyTemplateToMonth.Click += btnCopyTemplateToMonth_Click;
            // 
            // label1
            // 
            label1.Location = new Point(12, 491);
            label1.Name = "label1";
            label1.Size = new Size(138, 42);
            label1.TabIndex = 8;
            label1.Text = "Replaces monthly data with template";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 10);
            label2.Name = "label2";
            label2.Size = new Size(165, 20);
            label2.TabIndex = 9;
            label2.Text = "Current Funds Available";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(239, 10);
            label3.Name = "label3";
            label3.Size = new Size(225, 20);
            label3.TabIndex = 10;
            label3.Text = "Estimated End of Month Balance";
            // 
            // lblEstimatedEndBalance
            // 
            lblEstimatedEndBalance.AutoSize = true;
            lblEstimatedEndBalance.Location = new Point(447, 39);
            lblEstimatedEndBalance.Name = "lblEstimatedEndBalance";
            lblEstimatedEndBalance.Size = new Size(17, 20);
            lblEstimatedEndBalance.TabIndex = 11;
            lblEstimatedEndBalance.Text = "0";
            lblEstimatedEndBalance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(371, 455);
            label4.Name = "label4";
            label4.Size = new Size(117, 20);
            label4.TabIndex = 12;
            label4.Text = "Budgeted Totals";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(516, 455);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 13;
            label5.Text = "Actual Totals";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(293, 484);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 14;
            label6.Text = "Income";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(282, 530);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 15;
            label7.Text = "Expenses";
            // 
            // lblIncomeBudgeted
            // 
            lblIncomeBudgeted.Location = new Point(371, 484);
            lblIncomeBudgeted.Name = "lblIncomeBudgeted";
            lblIncomeBudgeted.Size = new Size(100, 20);
            lblIncomeBudgeted.TabIndex = 16;
            lblIncomeBudgeted.Text = "Amount";
            lblIncomeBudgeted.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblExpenseBudgeted
            // 
            lblExpenseBudgeted.Location = new Point(371, 530);
            lblExpenseBudgeted.Name = "lblExpenseBudgeted";
            lblExpenseBudgeted.Size = new Size(100, 20);
            lblExpenseBudgeted.TabIndex = 17;
            lblExpenseBudgeted.Text = "Amount";
            lblExpenseBudgeted.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblIncomeActual
            // 
            lblIncomeActual.Location = new Point(510, 484);
            lblIncomeActual.Name = "lblIncomeActual";
            lblIncomeActual.Size = new Size(100, 20);
            lblIncomeActual.TabIndex = 18;
            lblIncomeActual.Text = "Amount";
            lblIncomeActual.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblExpenseActual
            // 
            lblExpenseActual.Location = new Point(510, 530);
            lblExpenseActual.Name = "lblExpenseActual";
            lblExpenseActual.Size = new Size(100, 20);
            lblExpenseActual.TabIndex = 19;
            lblExpenseActual.Text = "Amount";
            lblExpenseActual.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(61, 42);
            label8.Name = "label8";
            label8.Size = new Size(17, 20);
            label8.TabIndex = 20;
            label8.Text = "$";
            // 
            // MonthViewDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1291, 589);
            Controls.Add(label8);
            Controls.Add(lblExpenseActual);
            Controls.Add(lblIncomeActual);
            Controls.Add(lblExpenseBudgeted);
            Controls.Add(lblIncomeBudgeted);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblEstimatedEndBalance);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCopyTemplateToMonth);
            Controls.Add(btnDeleteTransaction);
            Controls.Add(btnBackToMain);
            Controls.Add(lblMonth);
            Controls.Add(btnNewTransaction);
            Controls.Add(btnSaveTransactions);
            Controls.Add(dataGridView1);
            Controls.Add(txtCurrentFunds);
            Name = "MonthViewDashboard";
            Text = "MonthViewDashboard";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)transactionBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCurrentFunds;
        private DataGridView dataGridView1;
        private BindingSource transactionBindingSource;
        private Button btnSaveTransactions;
        private Button btnNewTransaction;
        private Label lblMonth;
        private Button btnBackToMain;
        private Button btnDeleteTransaction;
        private Button btnCopyTemplateToMonth;
        private DataGridViewTextBoxColumn transactionMonth;
        private DataGridViewTextBoxColumn dayOfMonthToPayDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn paymentEstimatedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paymentActualDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isPaidDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn isRecurringPaymentDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn isAutoPaySetupDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblEstimatedEndBalance;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lblIncomeBudgeted;
        private Label lblExpenseBudgeted;
        private Label lblIncomeActual;
        private Label lblExpenseActual;
        private Label label8;
    }
}