using System;

namespace Transaction
{
    class Program
    {
        static void Main(string[] args)
        {
            Transaction transaction1 = new Transaction();
            Console.WriteLine("Transaction1 details");

            Console.WriteLine("Enter the transaction id");
            transaction1.TransactionId =Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Enter the transaction amount");
            transaction1.Amount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the date in dd-mm-yyyy  format ");
            transaction1.TransDate = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Transaction2 details");
            Transaction transaction2 = new Transaction();
            Console.WriteLine("Enter the transaction id");
            transaction2.TransactionId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the transaction amount");
            transaction2.Amount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the date in dd-mm-yyyy  format ");
            transaction2.TransDate = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Transaction 1 and transaction 2 are equal?");
            Console.WriteLine(transaction1.Equals(transaction2));


        }
    }

    public class Transaction
    {

        private int transactionId;
        private double amount;
        private DateTime transDate;

        public int TransactionId { get; set; }
        public double Amount { get; set ; }
        public DateTime TransDate { get ; set ; }


        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Transaction))
            {
                return false;
            }
            return this.TransactionId == ((Transaction)obj).TransactionId && this.Amount == ((Transaction)obj).Amount && this.TransDate == ((Transaction)obj).TransDate; 



       }
        public override int GetHashCode()
        {
            return this.TransactionId.GetHashCode() ^ this.Amount.GetHashCode() ^ this.transDate.GetHashCode();
        }




    }



}
