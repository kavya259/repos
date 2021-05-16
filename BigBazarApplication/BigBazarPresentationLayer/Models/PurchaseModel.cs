using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace BigBazarPresentationLayer.Models
{
    public partial class PurchaseModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PurchaseId { get; set; }
        public int ProductId { get; set; }
        public int PurchaseQuantity { get; set; }
        public double PurchasePrice { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public int CustomerId { get; set; }

        public virtual CustomerModel Customer { get; set; }
        public virtual ProductModel Product { get; set; }
    }
}
