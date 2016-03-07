using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    class IngredientInventory
    {
        public Ingredient CreateIngredient(string ingredientName, int ingredientAmountOnHand, string quantityType)
        {
            return (new Ingredient(ingredientName, ingredientAmountOnHand, quantityType));
        }
        public List<Ingredient> TakeInventory()
        {
            List<Ingredient> ingredientsOnHand = new List<Ingredient>();
            ingredientsOnHand.Add(CreateIngredient("Chicken patties", 250, "units"));
            ingredientsOnHand.Add(CreateIngredient("Hamburger patties", 500, "units"));
            ingredientsOnHand.Add(CreateIngredient("Fish filets", 175, "units"));
            ingredientsOnHand.Add(CreateIngredient("Cucumbers", 50, "lbs"));
            ingredientsOnHand.Add(CreateIngredient("Tomatoes", 400, "lbs"));
            ingredientsOnHand.Add(CreateIngredient("Lettuce", 100, "lbs"));
            ingredientsOnHand.Add(CreateIngredient("Sandwich buns", 500, "units"));
            ingredientsOnHand.Add(CreateIngredient("Sprouts", 20, "lbs"));
            ingredientsOnHand.Add(CreateIngredient("Secret sauce", 12, "gallons"));
            foreach (var ingredient in ingredientsOnHand)
            {
                Console.WriteLine(ingredient.IngredientName + ":  " + ingredient.IngredientAmountOnHand + ingredient.QuantityType);
            }
            return ingredientsOnHand;
        }

    }
}
