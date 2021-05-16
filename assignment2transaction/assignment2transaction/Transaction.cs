using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2transaction
{
    class Transaction :TransactionManager
    {
        private int transactionId;
        private double amount;
        private DateTime transDate;

        public Transaction()
        { }
            

        public Transaction(int transactionId, double amount, DateTime transDate)
        {
            this.TransactionId = transactionId;
            this.Amount = amount;
            this.TransDate = transDate;
        }

        public int TransactionId { get => transactionId; set => transactionId = value; }
        public double Amount { get => amount; set => amount = value; }
        public DateTime TransDate { get => transDate; set => transDate = value; }
    }
}
