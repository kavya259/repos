using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace BigBazarPresentationLayer.Models
{
    public partial class ReceiptModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReceiptId { get; set; }
        public DateTime ReceiptDate { get; set; }
        public int CustomerId { get; set; }
        public double TotalBill { get; set; }
        public int NoOfItems { get; set; }

        public virtual CustomerModel Customer { get; set; }
    }
}
