using System;
using System.Collections.Generic;

#nullable disable

namespace BigBazarPresentationLayer.Models
{
    public partial class Product
    {
        public Product()
        {
            Purchases = new HashSet<Purchase>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public double ProductPrice { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}
