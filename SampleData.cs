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
            AllTransactionData.TransactionList.Add(new Transaction(1, TransactionMonth.January, 1100, "1st Pay Day"));
            AllTransactionData.TransactionList.Add(new Transaction(1, TransactionMonth.February, 1100, "1st Pay Day"));
            AllTransactionData.TransactionList.Add(new Transaction(15, TransactionMonth.January, 1500, "2nd Pay Day"));
            AllTransactionData.TransactionList.Add(new Transaction(3,TransactionMonth.February, 150, "Electric Bill"));
            AllTransactionData.TransactionList.Add(new Transaction(17, TransactionMonth.February, 16, "Netflix bill"));
            
           
        }
    }
}
