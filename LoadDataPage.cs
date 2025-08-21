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
    public partial class LoadDataPage : Form
    {
        public LoadDataPage()
        {
            InitializeComponent();
            //lstMonths allows user to select month to filter the data by month when loading
            lstMonths.DataSource = Enum.GetValues(typeof(TransactionMonth));
        }
        private void btnLoadMonth_Click(object sender, EventArgs e)
        {
            string selectedMonth = lstMonths.SelectedItem.ToString(); //use this to set the selected item
            MonthViewDashboard monthView = new MonthViewDashboard(selectedMonth);
            monthView.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
