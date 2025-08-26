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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transactionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // txtCurrentFunds
            // 
            txtCurrentFunds.Location = new Point(12, 39);
            txtCurrentFunds.Name = "txtCurrentFunds";
            txtCurrentFunds.Size = new Size(314, 27);
            txtCurrentFunds.TabIndex = 0;
            txtCurrentFunds.Text = "0";
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
            btnNewTransaction.Location = new Point(680, 448);
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
            btnDeleteTransaction.Location = new Point(680, 515);
            btnDeleteTransaction.Name = "btnDeleteTransaction";
            btnDeleteTransaction.Size = new Size(124, 65);
            btnDeleteTransaction.TabIndex = 6;
            btnDeleteTransaction.Text = "Delete Transaction";
            btnDeleteTransaction.UseVisualStyleBackColor = true;
            btnDeleteTransaction.Click += btnDeleteTransaction_Click;
            // 
            // btnCopyTemplateToMonth
            // 
            btnCopyTemplateToMonth.Location = new Point(63, 493);
            btnCopyTemplateToMonth.Name = "btnCopyTemplateToMonth";
            btnCopyTemplateToMonth.Size = new Size(124, 65);
            btnCopyTemplateToMonth.TabIndex = 7;
            btnCopyTemplateToMonth.Text = "Load Template";
            btnCopyTemplateToMonth.UseVisualStyleBackColor = true;
            btnCopyTemplateToMonth.Click += btnCopyTemplateToMonth_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 470);
            label1.Name = "label1";
            label1.Size = new Size(256, 20);
            label1.TabIndex = 8;
            label1.Text = "Replaces monthly data with template";
            // 
            // MonthViewDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1291, 589);
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
    }
}