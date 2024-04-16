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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter the number of ingredients:");
            Console.ResetColor();

            int ingredientCount = int.Parse(Console.ReadLine());
            ingredients = new Ingredient[ingredientCount];
            originalQuantities = new double[ingredientCount];

            for (int i = 0; i < ingredientCount; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Enter name of ingredient {i + 1}:");
                Console.ResetColor();

                string name = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Enter quantity of {name}:");
                Console.ResetColor();

                double quantity = double.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Enter unit of measurement for {name}:");
                Console.ResetColor();

                string unit = Console.ReadLine();

                ingredients[i] = new Ingredient { Name = name, Quantity = quantity, Unit = unit };
                originalQuantities[i] = quantity;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter the number of steps:");
            Console.ResetColor();

            int stepCount = int.Parse(Console.ReadLine());
            steps = new Step[stepCount];

            for (int i = 0; i < stepCount; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Enter step {i + 1}:");
                Console.ResetColor();

                string description = Console.ReadLine();
                steps[i] = new Step { Description = description };
            }
        }

        public void DisplayRecipe()
        {
            if (ingredients == null || ingredients.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Recipe is empty. Please enter recipe details.");
                Console.ResetColor();
                return;
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
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
            Console.ResetColor();
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
//reference www.aztechit.co.uk. (n.d.). What is Cloud Based Solutions | With Examples & Benefits. [online] Available at: https://www.aztechit.co.uk/blog/what-is-cloud-based-solutions [Accessed 9 Jan. 2024]. 