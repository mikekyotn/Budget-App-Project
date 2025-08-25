using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Budget_App_Project
{
    public partial class LoadDataPage : Form
    {
        public LoadDataPage()
        {
            InitializeComponent();
            //cbBoxMonth allows user to select month to filter the data by month when loading
            //filteredMonths hides the TEMPLATE option from the user in the comboBox
            var filteredMonths = Enum.GetValues(typeof(TransactionMonth))
                          .Cast<TransactionMonth>()
                          .Where(s => s != TransactionMonth.TEMPLATE);
            cbBoxMonth.DataSource = filteredMonths.ToList();
            cbBoxMonth.SelectedItem = TransactionMonth.January;
        }
        private void btnLoadMonth_Click(object sender, EventArgs e)
        {
            string selectedMonth = cbBoxMonth.SelectedItem.ToString(); //use this to set the selected item
            MonthViewDashboard monthView = new MonthViewDashboard(selectedMonth);
            monthView.Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoadTemplateFromFile_Click(object sender, EventArgs e)
        {
            MonthViewDashboard monthView = new MonthViewDashboard("TEMPLATE");
            monthView.Show();
        }
    }
}
