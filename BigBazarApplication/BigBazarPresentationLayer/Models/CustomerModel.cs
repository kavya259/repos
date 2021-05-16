using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace BigBazarPresentationLayer.Models
{
    public partial class CustomerModel
    {
        public CustomerModel()
        {
            Purchases = new HashSet<PurchaseModel>();
            Receipts = new HashSet<ReceiptModel>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public virtual ICollection<PurchaseModel> Purchases { get; set; }
        public virtual ICollection<ReceiptModel> Receipts { get; set; }
    }
}
