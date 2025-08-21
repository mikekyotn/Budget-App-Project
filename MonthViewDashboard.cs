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
using static System.Net.Mime.MediaTypeNames;

namespace Budget_App_Project
{
    public partial class MonthViewDashboard : Form
    {

        public MonthViewDashboard(string month)
        {
            InitializeComponent();

            //Load a BindingList from a json file that is filtered on the month desired
            AllTransactionData.TransactionList = LoadFromFile();
            lblMonth.Text = month;
            FilterAndUpdateDataSource(month);
            //convert month to Enum type so can do comparison and filter
            //TransactionMonth enumMonth = (TransactionMonth)Enum.Parse(typeof(TransactionMonth), month);
            //List<Transaction> filteredList = AllTransactionData.TransactionList.Where(t => t.transactionMonth == enumMonth).ToList();
            //dataGridView1.DataSource = new BindingList<Transaction>(filteredList);
        }

        public void FilterAndUpdateDataSource (string month)
        {
            TransactionMonth enumMonth = (TransactionMonth)Enum.Parse(typeof(TransactionMonth), month);
            List<Transaction> filteredList = AllTransactionData.TransactionList.Where(t => t.transactionMonth == enumMonth).ToList();
            dataGridView1.DataSource = new BindingList<Transaction>(filteredList);
        }

        public string GetFolderPath()
        {
            return @"d:\G5ProgSpace\BudgetAppFiles";
        }

        public List<Transaction> LoadFromFile()
        {
            string folderPath = GetFolderPath();
            string filePath = Path.Combine(folderPath, "AllTransactions.json");
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
            //for testing hard coding location
            string folderPath = GetFolderPath();
            string filePath = Path.Combine(folderPath, "AllTransactions.json");

            //Because the bindingList and AllTrasn.TransList reference the same obj,
            //edits reflect in the master List.  But adds/removes are not reflected.
            var transactionsToPrintList = AllTransactionData.TransactionList;

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

            //need to refilter and update the dataGridView datasource
            FilterAndUpdateDataSource(lblMonth.Text);
            //TransactionMonth enumMonth = (TransactionMonth)Enum.Parse(typeof(TransactionMonth), lblMonth.Text);
            //List<Transaction> updatedfilteredList = AllTransactionData.TransactionList.Where(t => t.transactionMonth == enumMonth).ToList();
            //dataGridView1.DataSource = new BindingList<Transaction>(updatedfilteredList);
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
