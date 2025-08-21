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
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            transactionBindingSource = new BindingSource(components);
            btnSaveTransactions = new Button();
            btnNewTransaction = new Button();
            lblMonth = new Label();
            btnBackToMain = new Button();
            btnDeleteTransaction = new Button();
            transactionMonth = new DataGridViewTextBoxColumn();
            dayOfMonthToPayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paymentEstimatedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paymentActualDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isPaidDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            isRecurringPaymentDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            isAutoPaySetupDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            commentsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transactionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(314, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "CurrentAvailableFunds";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { transactionMonth, dayOfMonthToPayDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, paymentEstimatedDataGridViewTextBoxColumn, paymentActualDataGridViewTextBoxColumn, isPaidDataGridViewCheckBoxColumn, isRecurringPaymentDataGridViewCheckBoxColumn, isAutoPaySetupDataGridViewCheckBoxColumn, commentsDataGridViewTextBoxColumn, categoryDataGridViewTextBoxColumn });
            dataGridView1.DataSource = transactionBindingSource;
            dataGridView1.Location = new Point(12, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1051, 353);
            dataGridView1.TabIndex = 1;
            // 
            // transactionBindingSource
            // 
            transactionBindingSource.DataSource = typeof(Transaction);
            // 
            // btnSaveTransactions
            // 
            btnSaveTransactions.Location = new Point(939, 448);
            btnSaveTransactions.Name = "btnSaveTransactions";
            btnSaveTransactions.Size = new Size(124, 65);
            btnSaveTransactions.TabIndex = 2;
            btnSaveTransactions.Text = "Save Updates";
            btnSaveTransactions.UseVisualStyleBackColor = true;
            btnSaveTransactions.Click += btnSaveTransactions_Click;
            // 
            // btnNewTransaction
            // 
            btnNewTransaction.Location = new Point(361, 512);
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
            btnBackToMain.Location = new Point(939, 515);
            btnBackToMain.Name = "btnBackToMain";
            btnBackToMain.Size = new Size(124, 65);
            btnBackToMain.TabIndex = 5;
            btnBackToMain.Text = "Back to Main";
            btnBackToMain.UseVisualStyleBackColor = true;
            btnBackToMain.Click += btnBackToMain_Click;
            // 
            // btnDeleteTransaction
            // 
            btnDeleteTransaction.Location = new Point(527, 512);
            btnDeleteTransaction.Name = "btnDeleteTransaction";
            btnDeleteTransaction.Size = new Size(124, 65);
            btnDeleteTransaction.TabIndex = 6;
            btnDeleteTransaction.Text = "Delete Transaction";
            btnDeleteTransaction.UseVisualStyleBackColor = true;
            btnDeleteTransaction.Click += btnDeleteTransaction_Click;
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
            // paymentEstimatedDataGridViewTextBoxColumn
            // 
            paymentEstimatedDataGridViewTextBoxColumn.DataPropertyName = "PaymentEstimated";
            paymentEstimatedDataGridViewTextBoxColumn.HeaderText = "PaymentEstimated";
            paymentEstimatedDataGridViewTextBoxColumn.MinimumWidth = 6;
            paymentEstimatedDataGridViewTextBoxColumn.Name = "paymentEstimatedDataGridViewTextBoxColumn";
            paymentEstimatedDataGridViewTextBoxColumn.Width = 125;
            // 
            // paymentActualDataGridViewTextBoxColumn
            // 
            paymentActualDataGridViewTextBoxColumn.DataPropertyName = "PaymentActual";
            paymentActualDataGridViewTextBoxColumn.HeaderText = "PaymentActual";
            paymentActualDataGridViewTextBoxColumn.MinimumWidth = 6;
            paymentActualDataGridViewTextBoxColumn.Name = "paymentActualDataGridViewTextBoxColumn";
            paymentActualDataGridViewTextBoxColumn.Width = 125;
            // 
            // isPaidDataGridViewCheckBoxColumn
            // 
            isPaidDataGridViewCheckBoxColumn.DataPropertyName = "IsPaid";
            isPaidDataGridViewCheckBoxColumn.HeaderText = "IsPaid";
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
            // commentsDataGridViewTextBoxColumn
            // 
            commentsDataGridViewTextBoxColumn.DataPropertyName = "Comments";
            commentsDataGridViewTextBoxColumn.HeaderText = "Comments";
            commentsDataGridViewTextBoxColumn.MinimumWidth = 6;
            commentsDataGridViewTextBoxColumn.Name = "commentsDataGridViewTextBoxColumn";
            commentsDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            categoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // MonthViewDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 589);
            Controls.Add(btnDeleteTransaction);
            Controls.Add(btnBackToMain);
            Controls.Add(lblMonth);
            Controls.Add(btnNewTransaction);
            Controls.Add(btnSaveTransactions);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Name = "MonthViewDashboard";
            Text = "MonthViewDashboard";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)transactionBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private DataGridView dataGridView1;
        private BindingSource transactionBindingSource;
        private Button btnSaveTransactions;
        private Button btnNewTransaction;
        private Label lblMonth;
        private Button btnBackToMain;
        private Button btnDeleteTransaction;
        private DataGridViewTextBoxColumn transactionMonth;
        private DataGridViewTextBoxColumn dayOfMonthToPayDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paymentEstimatedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paymentActualDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isPaidDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn isRecurringPaymentDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn isAutoPaySetupDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
    }
}