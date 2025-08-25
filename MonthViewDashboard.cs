using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
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
                MonthTemplate.TemplateMaster = LoadFromFile("Template.json");
                UpdateTemplateDataSource();
                btnCopyTemplateToMonth.Enabled = false;
            }
            else
            {
                AllTransactionData.TransactionList = LoadFromFile("AllTransactions.json");
                FilterAndUpdateDataSource(month);
            }
            lblMonth.Text = month;
        }
        public void UpdateTemplateDataSource()
        {
            List<Transaction> sortedList = MonthTemplate.TemplateMaster.OrderBy(t => t.DayOfMonthToPay).ToList();
            dataGridView1.DataSource = new BindingList<Transaction>(sortedList);
        }
        public void FilterAndUpdateDataSource(string month)
        {
            TransactionMonth enumMonth = (TransactionMonth)Enum.Parse(typeof(TransactionMonth), month);
            List<Transaction> filteredList = AllTransactionData.TransactionList.Where(t => t.transactionMonth == enumMonth).OrderBy(t => t.DayOfMonthToPay).ToList();
            dataGridView1.DataSource = new BindingList<Transaction>(filteredList);
        }
        public string GetFolderPath()
        {
            return @"d:\G5ProgSpace\BudgetAppFiles";
        }
        public List<Transaction> LoadFromFile(string fileName)
        {
            string folderPath = GetFolderPath();
            string filePath = Path.Combine(folderPath, fileName);
            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                var transactList = JsonSerializer.Deserialize<List<Transaction>>(json);
                return new List<Transaction>(transactList);
            }
            return new List<Transaction>();
        }
        private void btnSaveTransactions_Click(object sender, EventArgs e)
        {
            string folderPath = GetFolderPath();
            List<Transaction> transactionsToPrintList = new List<Transaction>();
            string fileName;

            if (lblMonth.Text == "TEMPLATE")
            {
                fileName = "Template.json";
                transactionsToPrintList = MonthTemplate.TemplateMaster;
            }
            else
            {
                fileName = "AllTransactions.json";
                transactionsToPrintList = AllTransactionData.TransactionList;
                
            }
            string filePath = Path.Combine(folderPath, fileName);
            if (transactionsToPrintList != null)
            {
                var json = JsonSerializer.Serialize(transactionsToPrintList, new JsonSerializerOptions
                {
                    WriteIndented = true
                });
                File.WriteAllText(filePath, json);
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
        }
        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            var confirmBackToMain = MessageBox.Show(
                $"Any unsaved changes will be discarded.\n" +
                $"Are you sure you want EXIT this screen back to Main?",
                "Confirm Deletion",
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
            else
            {
                AllTransactionData.TransactionList.Remove(selectedTransaction);
                FilterAndUpdateDataSource(lblMonth.Text);
            }
        }
        //Deletes all transactions in the AllTransactionData for the month
        //Writes the Template into this month with the TransactionMonth updated
        private void btnCopyTemplateToMonth_Click(object sender, EventArgs e)
        {
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
                MonthTemplate.TemplateMaster = LoadFromFile("Template.json");
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
            }
        }
    }
}
