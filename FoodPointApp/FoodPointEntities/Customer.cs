using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FoodPointEntities
    {
   public class Customer
        {/// <summary>
        /// this class has Customer properties who visit food point
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId        /// customerid-primarykey..autoincremented
            {
            get; set;
            }
     //   [Column(TypeName ="text")]
        public string CustomerName
            {
            get;set;
            }
      //  [Column(TypeName = "text")]

        public string MobileNo
            {
            get;set;
            }
        [ForeignKey("foodItem")]
        public int ItemId        // itemid--foriegnkey
            {
            get;set;
            }
        //public FoodItem foodItem
        //    {
        //    get;set;
        //    }
        }
    }
