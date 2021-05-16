using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace BigBazarEntities
{
    public partial class Product
    {
        public Product()
        {
            Purchases = new HashSet<Purchase>();
        }
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public double ProductPrice { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}
