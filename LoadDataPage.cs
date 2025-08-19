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
        }
        private void btnLoadMonth_Click(object sender, EventArgs e)
        {
            MonthViewDashboard monthView = new MonthViewDashboard();
            monthView.Show();
        }
    }
}
