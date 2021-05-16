using System;

namespace assignment2transaction
{
    class Program
    {
        static void Main(string[] args)
        {
            Transaction trans = new Transaction();
            trans = trans.createTransaction(trans);
            trans.showTransactionDetails(trans);

        }
    }
}
