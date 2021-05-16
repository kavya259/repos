using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace BigBazarPresentationLayer.Models
{
    public partial class ProductModel
    {
        public ProductModel()
        {
            Purchases = new HashSet<PurchaseModel>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public double ProductPrice { get; set; }
        public int CategoryId { get; set; }

        public virtual CategoryModel Category { get; set; }
        public virtual ICollection<PurchaseModel> Purchases { get; set; }
    }
}
