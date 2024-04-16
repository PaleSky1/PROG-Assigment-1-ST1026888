using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaneleApp
{
    public class Recipe
    {
        private Ingredient[] ingredients;
        private double[] originalQuantities;

        private Step[] steps;

        public void EnterRecipeDetails()
        {
            Console.WriteLine("Enter the number of ingredients:");
            int ingredientCount = int.Parse(Console.ReadLine());
            ingredients = new Ingredient[ingredientCount];
            originalQuantities = new double[ingredientCount];

            for (int i = 0; i < ingredientCount; i++)
            {
                Console.WriteLine($"Enter name of ingredient {i + 1}:");
                string name = Console.ReadLine();

                Console.WriteLine($"Enter quantity of {name}:");
                double quantity = double.Parse(Console.ReadLine());

                Console.WriteLine($"Enter unit of measurement for {name}:");
                string unit = Console.ReadLine();

                ingredients[i] = new Ingredient { Name = name, Quantity = quantity, Unit = unit };
                originalQuantities[i] = quantity;
            }

            Console.WriteLine("Enter the number of steps:");
            int stepCount = int.Parse(Console.ReadLine());
            steps = new Step[stepCount];

            for (int i = 0; i < stepCount; i++)
            {
                Console.WriteLine($"Enter step {i + 1}:");
                string description = Console.ReadLine();
                steps[i] = new Step { Description = description };
            }
        }

        public void DisplayRecipe()
        {
            if (ingredients == null || ingredients.Length == 0)
            {
                Console.WriteLine("Recipe is empty. Please enter recipe details.");
                return;
            }

            Console.WriteLine("\nRecipe:");
            Console.WriteLine("Ingredients:");

            foreach (var ingredient in ingredients)
            {
                Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name}");
            }

            Console.WriteLine("\nSteps:");
            for (int i = 0; i < steps.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {steps[i].Description}");
            }
        }

        public void ScaleRecipe(double factor)
        {
            for (int i = 0; i < ingredients.Length; i++)
            {
                ingredients[i].Quantity = originalQuantities[i] * factor;
            }
        }

        public void ResetQuantities()
        {
            for (int i = 0; i < ingredients.Length; i++)
            {
                ingredients[i].Quantity = originalQuantities[i];
            }
        }
        public void ClearRecipe()
        {
            ingredients = null;
            steps = null;
        }
    }
}