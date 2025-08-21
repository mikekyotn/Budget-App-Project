using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_App_Project
{
    //This is a single transaction made in one monthly budget list.
    //A transaction can be used to pay a debtor or to recieve payment/paycheck.
    public class Transaction
    {
        public Guid Id { get; set; } //globally unique identifier
        public uint DayOfMonthToPay { get; set; } // required
        public  TransactionMonth transactionMonth { get; set;  }    // required
        public decimal PaymentEstimated { get; set; } //required
        public string? Description { get; set; } //who's getting paid or paying - required
        public bool IsRecurringPayment { get; set; } // optional default true
        public bool IsAutoPaySetup { get; set; } //optional default false
        public bool IsPaid { get; set; } //optional default false                
        public decimal PaymentActual { get; set; } //optional default 0        
        public string? Comments { get; set; } // optional default ""        
        public string? Category { get; set; } //initially user defined, may make enum later optional default "undefined"

        //Constructor - the only required arguments are dayOfMonthToPay, transactionMonth, paymentEstimated, and description
        public Transaction(uint dayOfMonthToPay, TransactionMonth month, decimal paymentEstimated, string description, bool isRecurringPayment = true, 
            bool isAutoPaySetup = true, bool isPaid = false, decimal paymentActual = 0, string comments = " ", string category = "undefined")
        {
            Id = Guid.NewGuid();
            DayOfMonthToPay = dayOfMonthToPay;
            transactionMonth = month;
            PaymentEstimated = paymentEstimated;
            IsRecurringPayment = isRecurringPayment;
            IsAutoPaySetup = isAutoPaySetup;
            IsPaid = isPaid;
            PaymentActual = paymentActual;
            Comments = comments;
            Description = description;
            Category = category;
        }
        //Default empty constructor for a transaction
        public Transaction() 
        {
            Id = Guid.NewGuid();
        }
    }

    public enum TransactionMonth
    {
        Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec
    }
    
    //List for ALL transactions accessible by all forms, static so no instantiation required
    public static class AllTransactionData
    {
        //public static BindingList<Transaction> TransactionList = new BindingList<Transaction>();
        public static List<Transaction> TransactionList = new List<Transaction>();
    }

    
    
}
