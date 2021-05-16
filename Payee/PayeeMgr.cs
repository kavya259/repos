using System;
using System.Collections.Generic;
using System.Text;

namespace Payee
{
    class PayeeMgr
    {


     /*   private int payeeId;
        private int accNo;
        private String accName;
        private String bank;
     */

        public Payee storeData(Payee payee)
        {

            Console.WriteLine("Enter the payee Id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Account number");
            int accontno= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Account name");
            String accname= Console.ReadLine();
            Console.WriteLine("Enter the bank");
            String bankname = Console.ReadLine();


            payee.AccName = accname;
            payee.AccNo = accontno;
            payee.PayeeId = id;
            payee.Bank = bankname;
            
            return payee;
        }
        public void showData(Payee payee)
        {
            Console.WriteLine("PayeeId             : " + payee.PayeeId);
            Console.WriteLine("Payee Account Name  : " + payee.AccName);
            Console.WriteLine("Payee Account number: " + payee.AccNo);
            Console.WriteLine("Bank                : " + payee.Bank);


        
        }

    }
}
