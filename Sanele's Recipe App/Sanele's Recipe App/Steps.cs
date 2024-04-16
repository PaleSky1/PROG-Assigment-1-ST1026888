using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanele_s_Recipe_App
{
    internal class Steps
    {
        public string IngredientName { get; set; }
        public double IngredientAmount { get; set; }
        public string Measurement { get; set; }

        public Ingredient(string ingredientName, double ingredientAmount, string measurement)
        {
            IngredientName = ingredientName;
            IngredientAmount = ingredientAmount;
            Measurement = measurement;
        }

        public static Ingredient[] AddIngredientToArray(Ingredient[] array, Ingredient ingredient)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = ingredient;
            return array;
        }

        public static Ingredient[] ResizeArray(Ingredient[] array, int newSize)
        {
            Array.Resize(ref array, newSize);
            return array;
        }

        public static string GetIngredientsMessage(Ingredient[] ingredients, double multiplyValue)
        {
            StringBuilder message = new StringBuilder();
            message.AppendLine("Ingredients Added:");

            foreach (Ingredient ingredient in ingredients)
            {
                if (ingredient != null)
                {
                    double adjustedAmount = ingredient.IngredientAmount * multiplyValue;
                    message.AppendLine($"- {ingredient.IngredientName}: {adjustedAmount} {ingredient.Measurement}");
                }
            }
            return message.ToString();
        }
    }
}

