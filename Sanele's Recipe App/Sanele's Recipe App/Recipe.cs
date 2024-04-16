using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanele_s_Recipe_App
{
    internal class Recipe
    {
        public string RecipeName { get; set; }
        public string RecipeDescription { get; set; }
        public Ingredient[] Ingredients { get; set; }
        public Step[] Steps { get; set; }

        public Recipe(string recipeName, string recipeDescription, Ingredient[] ingredients, Step[] steps)
        {
            RecipeName = recipeName;
            RecipeDescription = recipeDescription;
            Ingredients = ingredients;
            Steps = steps;
        }
    }
}
