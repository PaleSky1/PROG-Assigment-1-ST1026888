using System;
using System.Collections.Generic;
using System.Linq;

namespace prjSaneleAppWPF
{
    public class Recipe
    {
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public List<Step> Steps { get; set; }
        public int TotalCalories => Ingredients.Sum(i => i.Calories);

        // Delegate and Event for exceeding calories
        public delegate void CaloriesExceededHandler(int totalCalories);
        public event CaloriesExceededHandler CaloriesExceeded;

        public Recipe()
        {
            Ingredients = new List<Ingredient>();
            Steps = new List<Step>();
        }

        public void AddIngredient(Ingredient ingredient)
        {
            Ingredients.Add(ingredient);
            if (TotalCalories > 300)
            {
                CaloriesExceeded?.Invoke(TotalCalories);
            }
        }
    }
}
