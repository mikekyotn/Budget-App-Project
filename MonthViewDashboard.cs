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

namespace Budget_App_Project
{
    public partial class MonthViewDashboard : Form
    {
        public MonthViewDashboard(string month)
        {
            InitializeComponent();

            //Load a BindingList from a json file that is filtered on the month desired
            AllTransactionData.TransactionList = LoadFromFile();

            //convert month to Enum type so can do comparison and filter
            TransactionMonth enumMonth = (TransactionMonth)Enum.Parse(typeof(TransactionMonth), month);
            List<Transaction> filteredList = AllTransactionData.TransactionList.Where(t => t.transactionMonth == enumMonth).ToList();
            dataGridView1.DataSource = new BindingList<Transaction>(filteredList);


            //Once I get a file made we can replace this sampledata with loading from file
            //should filter on the month if data available
            //SampleData.CreateSampleMonth(); 
            //dataGridView1.DataSource = AllTransactionData.TransactionList;

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
    }
}
