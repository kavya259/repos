using System;

namespace Payee
{
    class Program
    {
        static void Main(string[] args)
        {
            Payee payee = new Payee();
            payee.storeData(payee);
            payee.showData(payee);
        }
    }
}
