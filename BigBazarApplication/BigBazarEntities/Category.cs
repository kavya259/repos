using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace BigBazarEntities
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
