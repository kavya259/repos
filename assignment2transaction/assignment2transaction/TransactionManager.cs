using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2transaction
{
    class TransactionManager
    {
        public Transaction createTransaction(Transaction trans)
        {
            Console.WriteLine("fill the transaction details ");
            Console.WriteLine("Enter transaction Id :");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the amount ");
            double amt = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the date in  yyyy-dd-mm  format ");
            DateTime date = Convert.ToDateTime(Console.ReadLine());

            trans = new Transaction(id, amt, date);
            return trans;
        }

        public void showTransactionDetails(Transaction trans)
        {

            Console.WriteLine("Transaction details are  ");
            Console.WriteLine("Transaction Id :  "+trans.TransactionId);
            Console.WriteLine("Transaction Amount :  " + trans.Amount);
            Console.WriteLine("Transaction Date :  " + trans.TransDate);






        }


    }
}
