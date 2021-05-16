using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace BigBazarEntities
{
    public partial class Customer
    {
        public Customer()
        {
            Purchases = new HashSet<Purchase>();
            Receipts = new HashSet<Receipt>();
        }
        [Key]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public virtual ICollection<Purchase> Purchases { get; set; }
        public virtual ICollection<Receipt> Receipts { get; set; }
    }
}
