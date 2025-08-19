using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budget_App_Project
{
    public partial class MonthViewDashboard : Form
    {        
        public MonthViewDashboard()
        {
            InitializeComponent();           
            
            SampleData.CreateSampleMonth();
            dataGridView1.DataSource = AllTransactionData.TransactionList;            
            //textBox1.Text = testMonth.CurrentAvailableFunds.ToString();
        }
    }
}
