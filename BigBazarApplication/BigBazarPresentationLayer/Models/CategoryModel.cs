using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace BigBazarPresentationLayer.Models
{
    public partial class CategoryModel
    {
        public CategoryModel()
        {
            Products = new HashSet<ProductModel>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<ProductModel> Products { get; set; }
    }
}
