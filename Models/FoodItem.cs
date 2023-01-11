using System;
using System.Collections.Generic;
using System.Text;

namespace fatmee.Models
{
    internal class FoodItem
    {
        public int FoodItemId { get; set; }
        public string FoodItemImg { get; set; }
        public string FoodItemName { get; set; }
        public int FoodItemRestaurentId { get; set; }
        public int FoodItemCategory { get; set; }
        public int FoodItemPrice { get; set; }
    }
}