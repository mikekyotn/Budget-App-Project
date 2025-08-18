using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_App_Project
{
    //This is a single transaction made in one monthly budget list.
    //A transaction can be used to pay a debtor or to recieve payment/paycheck.
    public class Transaction
    {
        public uint DayOfMonthToPay { get; set; } // required
        public decimal PaymentEstimated { get; set; } //required
        public string? Description { get; set; } //who's getting paid or paying - required
        public bool IsRecurringPayment { get; set; } // optional default true
        public bool IsAutoPaySetup { get; set; } //optional default false
        public bool IsPaid { get; set; } //optional default false                
        public decimal PaymentActual { get; set; } //optional default 0        
        public string? Comments { get; set; } // optional default ""        
        public string? Category { get; set; } //initially user defined, may make enum later optional default "undefined"

        //Constructor - the only required arguments are dayOfMonthToPay, paymentEstimated, and description
        public Transaction(uint dayOfMonthToPay, decimal paymentEstimated, string description, bool isRecurringPayment = true, 
            bool isAutoPaySetup = true, bool isPaid = false, decimal paymentActual = 0, string comments = " ", string category = "undefined")
        {
            DayOfMonthToPay = dayOfMonthToPay;
            PaymentEstimated = paymentEstimated;
            IsRecurringPayment = isRecurringPayment;
            IsAutoPaySetup = isAutoPaySetup;
            IsPaid = isPaid;
            PaymentActual = paymentActual;
            Comments = comments;
            Description = description;
            Category = category;

        }
        public Transaction() { }

    }
}
