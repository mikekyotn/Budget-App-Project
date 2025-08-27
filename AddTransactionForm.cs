using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Budget_App_Project
{
    public partial class AddTransactionForm : Form
    {
        public AddTransactionForm(string month)
        {
            InitializeComponent();
            List<uint> days = new List<uint> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31};

            cbBoxPaymentDay.DataSource = days;
            cbBoxPaymentDay.SelectedItem = days[0];
            cbBoxTransactType.DataSource = Enum.GetValues(typeof(TransactionType));
            cbBoxTransactType.SelectedItem = 0;
            cbBoxCategory.DataSource = AppSettingsManager.UserSettings.CategoryList;
            lblHeaderMonth.Text = month;       
            txtActPayment.Text = "0";
        }        
        private void button1_Click(object sender, EventArgs e)
        {
            //This is for the Cancel button
            this.Close();
        }

        //UPDATE: this works, but need to come back to add some error handling of
        // entries for decimal data types and required values.
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool validInput = true;            
                try
                {
                    uint day = (uint)cbBoxPaymentDay.SelectedItem;
                    TransactionType type = (TransactionType)cbBoxTransactType.SelectedItem;
                    string category = cbBoxCategory.SelectedItem.ToString();
                    if (lblHeaderMonth.Text == "TEMPLATE")
                    {
                        MonthTemplate.TemplateMaster.Add(
                            new Transaction(
                            day,
                            TransactionMonth.TEMPLATE,
                            decimal.Parse(txtEstPayment.Text),
                            txtDescription.Text,
                            true,
                            false,
                            chkBoxPayComplete.Checked,
                            decimal.Parse(txtActPayment.Text),
                            type,
                            txtComments.Text,
                            category
                            ));
                    }
                    else
                    {
                        TransactionMonth thisMonth = (TransactionMonth)Enum.Parse(typeof(TransactionMonth), lblHeaderMonth.Text);
                        AllTransactionData.TransactionList.Add(
                            new Transaction(
                            day,
                            thisMonth,
                            decimal.Parse(txtEstPayment.Text),
                            txtDescription.Text,
                            false,
                            false,
                            chkBoxPayComplete.Checked,
                            decimal.Parse(txtActPayment.Text),
                            type,
                            txtComments.Text,
                            category
                        ));
                    }          
                }
                catch 
                {
                    validInput = false;
                    MessageBox.Show(
                    $"Unable to Save \n" +
                    $"Invalid Entry in the Payment Field(s)\n" +
                    "Please ensure it is a decimal value",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                }
            if ( validInput ) 
                this.Close();
        }
    }
}
