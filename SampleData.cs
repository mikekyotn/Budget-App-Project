using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_App_Project
{
    public static class SampleData
    {
        public static void CreateSampleMonth()
        {
            AllTransactionData.TransactionList.Add(new Transaction(1, TransactionMonth.Jan, 1100, "1st Pay Day"));
            AllTransactionData.TransactionList.Add(new Transaction(1, TransactionMonth.Feb, 1100, "1st Pay Day"));
            AllTransactionData.TransactionList.Add(new Transaction(15, TransactionMonth.Jan, 1500, "2nd Pay Day"));
            AllTransactionData.TransactionList.Add(new Transaction(3,TransactionMonth.Feb, 150, "Electric Bill"));
            AllTransactionData.TransactionList.Add(new Transaction(17, TransactionMonth.Feb, 16, "Netflix bill"));
            
           
        }
    }
}
