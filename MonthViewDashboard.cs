using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Budget_App_Project
{
    public partial class MonthViewDashboard : Form
    {
        public MonthViewDashboard(string month)
        {
            InitializeComponent();

            //Load a BindingList from a json file that is either the TEMPLATE
            //or a BindingList filtered on the month desired from the AllTransactionData
            if (month == "TEMPLATE")
            {
                //MonthTemplate.TemplateMaster = LoadFromFile("Template.json");
                LoadTemplateFromFile("Template.json");
                UpdateTemplateDataSource();
                btnCopyTemplateToMonth.Enabled = false;
                txtCurrentFunds.Enabled = false;
            }
            else
            {
                LoadTransactionListFromFile("AllTransactions.json");                
                FilterAndUpdateDataSource(month);
                txtCurrentFunds.Text = GetCurrentFunds(month).ToString();
            }
            dataGridView1.DataError += DataGridView_DataError; //handle invalid data type entered
            dataGridView1.CellFormatting += DataGridViewCellFormatting; //show decimal values as currency
            lblMonth.Text = month;
            lblDeleteInstructions.Text = "Click on any cell in a row then click button to delete row";
            ReplaceEnumColumnWithCombo<TransactionType>(dataGridView1, "Type", "Type", 3); //ComboBox
            ReplaceCategoryColumnWithCombo(dataGridView1);
            txtCurrentFunds.TextChanged += TxtCurrentFunds_TextChanged; //listener for change in value
            CalculateTotalsForDashboard();
        }

        private void TxtCurrentFunds_TextChanged(object? sender, EventArgs e)
        {
            CalculateTotalsForDashboard();
        }

        private void DataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {            
            e.ThrowException = false; //prevent error message from appearing
            MessageBox.Show(
                $"You entered an INVALID entry at column {e.ColumnIndex}, row {e.RowIndex}.\n" +
                $"You cannot continue until you update.",
                "Acknowledge",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
        }
        public decimal GetCurrentFunds (string month)
        {
            TransactionMonth enumMonth = (TransactionMonth)Enum.Parse(typeof(TransactionMonth), month);
            if (AllTransactionData.MonthlyFundsList.ContainsKey(enumMonth))
            {
                return AllTransactionData.MonthlyFundsList[enumMonth];
            }
            else { return 0; }
        }
        public void UpdateTemplateDataSource()
        {            
            List<Transaction> sortedList = MonthTemplate.TemplateMaster.OrderBy(t => t.DayOfMonthToPay).ToList();
            var templateBindingList = new BindingList<Transaction>(sortedList);
            templateBindingList.ListChanged += TransactionListChanged;
            dataGridView1.DataSource = templateBindingList;
        }
        public void FilterAndUpdateDataSource(string month)
        {
            TransactionMonth enumMonth = (TransactionMonth)Enum.Parse(typeof(TransactionMonth), month);
            List<Transaction> filteredList = AllTransactionData.TransactionList.Where(t => t.transactionMonth == enumMonth).OrderBy(t => t.DayOfMonthToPay).ToList();
            var filteredBindingList = new BindingList<Transaction>(filteredList);
            filteredBindingList.ListChanged += TransactionListChanged;
            dataGridView1.DataSource = filteredBindingList;
        }
        public string GetFolderPath()
        {
            return AppSettingsManager.UserSettings.UserFolderPath;
        }
        public void LoadTemplateFromFile(string fileName)
        {
            string folderPath = GetFolderPath();
            string filePath = Path.Combine(folderPath, fileName);
            if (!File.Exists(filePath))
                return;
            else
            {
                var json = File.ReadAllText(filePath);
                MonthTemplate.TemplateMaster = JsonSerializer.Deserialize<List<Transaction>>(json);
            }
        }
        public void LoadTransactionListFromFile(string fileName)
        {
            string folderPath = GetFolderPath();
            string filePath = Path.Combine(folderPath, fileName);
            if (!File.Exists(filePath)) return;

            string json = File.ReadAllText(filePath);
            var loadedMirror = JsonSerializer.Deserialize<MirrorAllTransactionData>(json);

            if (loadedMirror != null) 
            {
                //assign data to the static Lists if null make new empty lists
                AllTransactionData.TransactionList = loadedMirror.TransactionList ?? new();
                AllTransactionData.MonthlyFundsList = loadedMirror.MonthlyFundsList ?? new();
            }
        }
        private void CalculateTotalsForDashboard()
        {
            decimal incomeEstimatedTotal = 0;
            decimal incomeActualTotal = 0;
            decimal incomeUnpaid = 0;
            decimal expenseEstimatedTotal = 0;
            decimal expenseActualTotal = 0;
            decimal expenseUnpaid = 0;
            decimal estimatedMonthEndBalance = ParseCurrentFunds();
            var data = (BindingList<Transaction>)dataGridView1.DataSource;
            foreach (var t in data)
            {
                if (t.Type == TransactionType.Income)
                {
                    incomeEstimatedTotal += t.PaymentEstimated;
                    incomeActualTotal += t.PaymentActual;
                    if (t.IsPaid == false)
                    {
                        estimatedMonthEndBalance += t.PaymentEstimated;
                        incomeUnpaid += t.PaymentEstimated;
                    }
                }
                else
                {
                    expenseEstimatedTotal += t.PaymentEstimated;
                    expenseActualTotal += t.PaymentActual;
                    if (t.IsPaid == false)
                    {
                        estimatedMonthEndBalance -= t.PaymentEstimated;
                        expenseUnpaid += t.PaymentEstimated;
                    }
                }
            }
            lblEstimatedEndBalance.Text = estimatedMonthEndBalance.ToString("C2");
            lblIncomeBudgeted.Text = incomeEstimatedTotal.ToString("C2");
            lblIncomeActual.Text = incomeActualTotal.ToString("C2");
            lblIncomeUnpaid.Text = incomeUnpaid.ToString("C2");
            lblExpenseBudgeted.Text = expenseEstimatedTotal.ToString("C2");
            lblExpenseActual.Text = expenseActualTotal.ToString("C2");
            lblExpenseUnpaid.Text = expenseUnpaid.ToString("C2");
        }
        private decimal ParseCurrentFunds()
        {
            decimal funds = 0;
            if (decimal.TryParse(txtCurrentFunds.Text, out funds))
                return funds;
            else return 0;
        }
        private void btnSaveTransactions_Click(object sender, EventArgs e)
        {
            string folderPath = GetFolderPath();
            //check if the value entered for CurrentFunds can be parsed into decimal
            //if it can save if it can't don't save and return message to fix
            decimal currentFunds = 0;
            if (decimal.TryParse(txtCurrentFunds.Text, out currentFunds))
            {
                string fileName;
                if (lblMonth.Text == "TEMPLATE")
                {
                    fileName = "Template.json";
                    string filePath = Path.Combine(folderPath, fileName);
                    List<Transaction> transactionsToPrintList = MonthTemplate.TemplateMaster;
                    if (transactionsToPrintList != null)
                    {
                        var json = JsonSerializer.Serialize(transactionsToPrintList, new JsonSerializerOptions
                        { WriteIndented = true });
                        File.WriteAllText(filePath, json);
                    }
                }
                else
                {
                    TransactionMonth enumMonth = (TransactionMonth)Enum.Parse(typeof(TransactionMonth), lblMonth.Text);
                    fileName = "AllTransactions.json";
                    string filePath = Path.Combine(folderPath, fileName);
                    if (AllTransactionData.MonthlyFundsList.ContainsKey(enumMonth))
                    {
                        AllTransactionData.MonthlyFundsList[enumMonth] = currentFunds;
                    }
                    else
                    {
                        AllTransactionData.MonthlyFundsList.Add(enumMonth, currentFunds);
                    }
                    var mirror = new MirrorAllTransactionData
                    {
                        TransactionList = AllTransactionData.TransactionList,
                        MonthlyFundsList = AllTransactionData.MonthlyFundsList
                    };
                    string json = JsonSerializer.Serialize(mirror, new JsonSerializerOptions
                    { WriteIndented = true });
                    File.WriteAllText(filePath, json);
                }
            }
            else
            {
                MessageBox.Show(
                $"Unable to Save \n" +
                $"Invalid Entry at: Current Funds Available\n" +
                "Please ensure it is a decimal value",
                "Error Saving",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
            }
        }
        private void btnNewTransaction_Click(object sender, EventArgs e)
        {
            AddTransactionForm addNewTransaction = new AddTransactionForm(lblMonth.Text);
            addNewTransaction.ShowDialog();
            

            if (lblMonth.Text == "TEMPLATE")
                //Only update required for dataGridView datasource
                UpdateTemplateDataSource();                
            else
                //need to refilter and update the dataGridView datasource
                FilterAndUpdateDataSource(lblMonth.Text);
            CalculateTotalsForDashboard();
        }
        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            var confirmBackToMain = MessageBox.Show(
                $"Any unsaved changes will be discarded.\n" +
                $"Are you sure you want EXIT this screen back to Main?",
                "Return to Main",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );
            if (confirmBackToMain == DialogResult.Yes)
                this.Close();            
        }
        private void btnDeleteTransaction_Click(object sender, EventArgs e)
        {
            Transaction selectedTransaction = (Transaction)dataGridView1.CurrentRow.DataBoundItem;
            var confirmDelete = MessageBox.Show(
                $"Are you sure you want to delete {selectedTransaction.Description} transaction?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );
            if (confirmDelete == DialogResult.Yes && lblMonth.Text == "TEMPLATE")
            {
                MonthTemplate.TemplateMaster.Remove(selectedTransaction);
                UpdateTemplateDataSource();
            }
            else if (confirmDelete == DialogResult.Yes)
            {
                AllTransactionData.TransactionList.Remove(selectedTransaction);
                FilterAndUpdateDataSource(lblMonth.Text);
            }
            CalculateTotalsForDashboard();
        }        
        private void btnCopyTemplateToMonth_Click(object sender, EventArgs e)
        {
            //Deletes all transactions in the AllTransactionData for the month
            //Writes the Template into this month with the TransactionMonth updated
            var confirmOverwrite = MessageBox.Show(
                $"All transactions will be overwritten for {lblMonth.Text}.\n" +
                $"Are you sure you want to load the TEMPLATE into {lblMonth.Text}?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );
            if (confirmOverwrite == DialogResult.Yes)
            {
                //Load the Template because it may not be loaded yet
                LoadTemplateFromFile("Template.json");
                TransactionMonth enumMonth = (TransactionMonth)Enum.Parse(typeof(TransactionMonth), lblMonth.Text);
                AllTransactionData.TransactionList.RemoveAll(t => t.transactionMonth == enumMonth);
                foreach (Transaction temp in MonthTemplate.TemplateMaster)
                {
                    AllTransactionData.TransactionList.Add(new Transaction
                    {
                        DayOfMonthToPay = temp.DayOfMonthToPay,
                        transactionMonth = enumMonth,
                        PaymentEstimated = temp.PaymentEstimated,
                        IsRecurringPayment = temp.IsRecurringPayment,
                        IsAutoPaySetup = temp.IsAutoPaySetup,
                        IsPaid = temp.IsPaid, //Do I need this?
                        PaymentActual = temp.PaymentActual,
                        Type = temp.Type,
                        Comments = temp.Comments,
                        Description = temp.Description,
                        Category = temp.Category
                    });
                }
                FilterAndUpdateDataSource(lblMonth.Text);
                CalculateTotalsForDashboard();
            }
        }
        private void DataGridViewCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "paymentEstimatedDataGridViewTextBoxColumn" && e.Value != null)
            {
                decimal value = (decimal)e.Value;
                e.Value = value.ToString("C2", new System.Globalization.CultureInfo("en-US"));
                e.FormattingApplied = true;
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "paymentActualDataGridViewTextBoxColumn" && e.Value != null)
            {
                decimal value = (decimal)e.Value;
                e.Value = value.ToString("C2", new System.Globalization.CultureInfo("en-US"));
                e.FormattingApplied = true;
            }
        }
        public void ReplaceEnumColumnWithCombo<T>(DataGridView grid, string propertyName, string headerName, int index)
        {
            grid.Columns.Remove(propertyName);

            var comboColumn = new DataGridViewComboBoxColumn
            {
                DataPropertyName = propertyName,
                Name = propertyName,
                HeaderText = headerName,
                DataSource = Enum.GetValues(typeof(T)),
                ValueType = typeof(T),
                DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton,
                DisplayIndex = index
            };
            grid.Columns.Add(comboColumn);
        }
        public void ReplaceCategoryColumnWithCombo(DataGridView grid)
        {
            grid.Columns.Remove("categoryDataGridViewTextBoxColumn");

            var comboColumn = new DataGridViewComboBoxColumn
            {
                DataPropertyName = "Category",
                Name = "Category",
                HeaderText = "Category",
                DataSource = AppSettingsManager.UserSettings.CategoryList,
                //ValueType = string,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton,
                DisplayIndex = 7
            };
            grid.Columns.Add(comboColumn);
        }
        private void TransactionListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemChanged)
            {
                var changedItem = ((BindingList<Transaction>)sender)[e.NewIndex];                                                
                CalculateTotalsForDashboard();
            }
        }

    }
}
