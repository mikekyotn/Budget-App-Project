using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_App_Project
{
    public class MonthBudgetData
    {
        public string? Month {  get; set; }
        public decimal CurrentAvailableFunds { get; set; }

        public BindingList<Transaction> TransactionList { get; set; }

        public MonthBudgetData()
        {
            Month = null;
            CurrentAvailableFunds = 0;
            TransactionList = new BindingList<Transaction>();
        }

    }
}
