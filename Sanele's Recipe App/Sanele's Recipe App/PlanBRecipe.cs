using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanele_s_Recipe_App
{
    internal class PlanBRecipe
    {
        private Ingredient[] ingredients;
        private Step[] steps;

        public void EnterRecipeDetails()
        {
            Console.WriteLine("Enter the number of ingredients:");
            int ingredientCount = int.Parse(Console.ReadLine());
            ingredients = new Ingredient[ingredientCount];

            for (int i = 0; i < ingredientCount; i++)
            {
                Console.WriteLine($"Enter name of ingredient {i + 1}:");
                string name = Console.ReadLine();

                Console.WriteLine($"Enter quantity of {name}:");
                double quantity = double.Parse(Console.ReadLine());

                Console.WriteLine($"Enter unit of measurement for {name}:");
                string unit = Console.ReadLine();

                ingredients[i] = new Ingredient { Name = name, Quantity = quantity, Unit = unit };
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
            foreach (var ingredient in ingredients)
            {
                ingredient.Quantity *= factor;
            }
        }

        public void ResetQuantities()
        {
            EnterRecipeDetails();
        }

        public void ClearRecipe()
        {
            ingredients = null;
            steps = null;
        }
    }
}
