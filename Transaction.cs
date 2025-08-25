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
    public class Transaction : IEquatable<Transaction>
    {
        public Guid Id { get; set; } //globally unique identifier
        public uint DayOfMonthToPay { get; set; } // required
        public  TransactionMonth? transactionMonth { get; set;  }    // required
        public decimal PaymentEstimated { get; set; } //required
        public string? Description { get; set; } //who's getting paid or paying - required
        public bool IsRecurringPayment { get; set; } // optional default true
        public bool IsAutoPaySetup { get; set; } //optional default false
        public bool IsPaid { get; set; } //optional default false                
        public decimal? PaymentActual { get; set; } //optional default 0        
        public TransactionType Type { get; set; } //is this a bill or income - required
        public string? Comments { get; set; } // optional default ""        
        public string? Category { get; set; } //initially user defined, may make enum later optional default "undefined"
        

        //Constructor - the only required arguments are dayOfMonthToPay, transactionMonth, paymentEstimated, and description
        public Transaction(uint dayOfMonthToPay, TransactionMonth month, decimal paymentEstimated, string description, bool isRecurringPayment = true, 
            bool isAutoPaySetup = true, bool isPaid = false, decimal paymentActual = 0, TransactionType type = TransactionType.Bill, string comments = " ", string category = "undefined")
        {
            Id = Guid.NewGuid();
            DayOfMonthToPay = dayOfMonthToPay;
            transactionMonth = month;
            PaymentEstimated = paymentEstimated;
            IsRecurringPayment = isRecurringPayment;
            IsAutoPaySetup = isAutoPaySetup;
            IsPaid = isPaid; //Do I need this?
            PaymentActual = paymentActual;
            Type = type;
            Comments = comments;
            Description = description;
            Category = category;
        }
        //Default empty constructor for a transaction
        public Transaction() 
        {
            Id = Guid.NewGuid();
        }

        public bool Equals(Transaction? other)
        {
            if (other == null) return false;
            return (this.Id.Equals(other.Id));
        }
    } 
    public class FundsData
    {
        public TransactionMonth? transactionMonth { get; set; }
        public decimal AvailableFunds { get; set; }
        public decimal EstimatedRemainingFunds { get; set; }
    }
    public enum TransactionMonth
    {
        TEMPLATE, January, February, March, April, May, June, 
        July, August, September, October, November, December
    }
    public enum TransactionType
    {
        Bill, Income
    }
    //List for ALL transactions accessible by all forms, static so no instantiation required
    public static class AllTransactionData
    {
        //This is a List and not a BindingList so that it's easier to filter and then
        //wrap the filtered list into a BindingList to use as a DataSource
        public static List<Transaction> TransactionList = new List<Transaction>();
        public static List<FundsData> MonthlyFundsList = new List<FundsData>();
    }
    public static class MonthTemplate
    {
        public static List<Transaction> TemplateMaster = new List<Transaction>();
    }

      
    
}
