using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodPointEntities
    {
    public class FoodItem
        {/// <summary>
        /// items here refers to food items in the food point which are to be added to the menu
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ItemId//item id =>primary key>autoincremented
            {
            get; set;
            }
        public string ItemName//food item name
            {
            get; set;
            }
        }
    }
