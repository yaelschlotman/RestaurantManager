using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    public class Ingredient
    {
        public Ingredient(string ingredientName, int ingredientAmountOnHand, string quantityType)
        {
            this.IngredientName = ingredientName;
            this.IngredientAmountOnHand = ingredientAmountOnHand;
            this.QuantityType = quantityType;
        }        

        public int IngredientAmountOnHand { get; set; }

        public string IngredientName { get; set; }
        public string QuantityType { get; set; }
    }
}
