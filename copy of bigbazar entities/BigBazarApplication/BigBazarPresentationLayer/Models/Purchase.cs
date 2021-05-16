using System;
using System.Collections.Generic;

#nullable disable

namespace BigBazarPresentationLayer.Models
{
    public partial class Purchase
    {
        public int PurchaseId { get; set; }
        public int ProductId { get; set; }
        public int PurchaseQuantity { get; set; }
        public double PurchasePrice { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}
