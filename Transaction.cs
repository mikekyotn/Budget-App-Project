using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Budget_App_Project
{
    //This is a single transaction made in one monthly budget list.
    //A transaction can be used to pay a debtor or to recieve payment/paycheck.
    public class Transaction : IEquatable<Transaction>, INotifyPropertyChanged
    {
        private decimal paymentEstimated;
        private decimal paymentActual;
        private bool isPaid;
        private TransactionType type;
        public Guid Id { get; set; } //globally unique identifier
        public uint DayOfMonthToPay { get; set; } // required
        public  TransactionMonth? transactionMonth { get; set;  }    // required
        public decimal PaymentEstimated 
        {
            get { return paymentEstimated; } 
            set
            {
                if (paymentEstimated != value)
                {
                    paymentEstimated = value;
                    OnPropertyChanged(nameof(PaymentEstimated));
                }
            }
        } //required
        public string Description { get; set; } = string.Empty; //who's getting paid or paying - required
        public bool IsRecurringPayment { get; set; } //defaults to True for Template item
        public bool IsAutoPaySetup { get; set; } //Not used; for possible future use
        public bool IsPaid 
        { 
            get { return isPaid; }
            set
            {
                if (isPaid != value)
                {
                    isPaid = value;
                    OnPropertyChanged(nameof(IsPaid));
                }
            }
        }                 
        public decimal PaymentActual 
        { 
            get { return paymentActual; }
            set
            {
                if (paymentActual != value)
                {
                    paymentActual = value;
                    OnPropertyChanged(nameof(PaymentActual));
                }
            }
        }         
        public TransactionType Type
        {
            get { return type; }
            set
            {
                if (type != value)
                {
                    type = value;
                    OnPropertyChanged(nameof(Type));
                }
            }
        }
        public string Comments { get; set; } = string.Empty; // optional default ""        
        public string Category { get; set; } = string.Empty; 
        
        //Constructor - the only required arguments are dayOfMonthToPay, transactionMonth, paymentEstimated, and description
        public Transaction(uint dayOfMonthToPay, TransactionMonth month, decimal paymentEstimated, string description, bool isRecurringPayment = true, 
            bool isAutoPaySetup = true, bool isPaid = false, decimal paymentActual = 0, TransactionType type = 0, string comments = " ", string category = "undefined")
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
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        public bool Equals(Transaction? other)
        {
            if (other == null) return false;
            return (this.Id.Equals(other.Id));
        }
    }  
    public enum TransactionMonth
    {
        TEMPLATE, January, February, March, April, May, June, 
        July, August, September, October, November, December
    }
    public enum TransactionType
    {
        Expense, Income, Transfer
    }
    //List for ALL transactions accessible by all forms, static so no instantiation required
    public static class AllTransactionData
    {
        //This is a List and not a BindingList so that it's easier to filter and then
        //wrap the filtered list into a BindingList to use as a DataSource
        public static List<Transaction> TransactionList = new List<Transaction>();
        public static Dictionary<TransactionMonth, decimal>MonthlyFundsList = new Dictionary<TransactionMonth, decimal>();
    }
    public class MirrorAllTransactionData
    {
        //used for writing to file with json, cannot write json direct from static class
        public List<Transaction> TransactionList { get; set; }
        public Dictionary<TransactionMonth, decimal> MonthlyFundsList { get; set; }
    }
    public static class MonthTemplate
    {
        public static List<Transaction> TemplateMaster = new List<Transaction>();        
    }    
}
