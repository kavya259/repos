using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;


namespace BigBazarEntities
    {
    public class Receipt
        {
        public int ReceiptId
            {
            get; set;
            }
        public DateTime ReceiptDate
            {
            get; set;
            }
        public int CustomerId
            {
            get; set;
            }
        public double TotalBill
            {
            get; set;
            }
        public int NoOfItems
            {
            get; set;
            }

        public virtual Customer Customer
            {
            get; set;
            }
        }
    }
