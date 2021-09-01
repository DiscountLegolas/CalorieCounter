using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalorieCounter.Models
{
    public class Food
    {
        public string Food_Code { get; set; }
        public string Display_Name { get; set; }
        public decimal Portion_Default { get; set; }
        public decimal Portion_Amount { get; set; }
        public string Portion_Display_Name { get; set; }
        public decimal Factor { get; set; }
        public decimal Increment { get; set; }
        public decimal Multiplier { get; set; }
        public decimal Grains { get; set; }
        public decimal Whole_Grains { get; set; }
        public decimal Vegetables { get; set; }
        public decimal Orange_Vegetables { get; set; }
        public decimal Drkgreen_Vegetables { get; set; }
        public decimal Starchy_vegetables { get; set; }
        public decimal Other_Vegetables { get; set; }
        public decimal Fruits { get; set; }
        public decimal Milk { get; set; }
        public decimal Meats { get; set; }
        public decimal Soy { get; set; }
        public decimal Drybeans_Peas { get; set; }
        public decimal Oils { get; set; }
        public decimal Solid_Fats { get; set; }
        public decimal Added_Sugars { get; set; }
        public decimal Alcohol { get; set; }
        public decimal Calories { get; set; }
        public decimal Saturated_Fats { get; set; }
    }
}
