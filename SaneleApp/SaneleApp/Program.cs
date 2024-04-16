namespace SaneleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Recipe recipe = new Recipe();

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Enter recipe details");
                Console.WriteLine("2. Display recipe");
                Console.WriteLine("3. Scale recipe");
                Console.WriteLine("4. Reset quantities");
                Console.WriteLine("5. Clear recipe");
                Console.WriteLine("6. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        recipe.EnterRecipeDetails();
                        break;
                    case 2:
                        recipe.DisplayRecipe();
                        break;
                    case 3:
                        Console.WriteLine("Enter scaling factor (half, double, or triple):");
                        string factorInput = Console.ReadLine().ToLower(); // Convert input to lowercase for case-insensitive comparison
                        double factorValue = 1;
                        switch (factorInput)
                        {
                            case "half":
                                factorValue = 0.5;
                                break;
                            case "double":
                                factorValue = 2;
                                break;
                            case "triple":
                                factorValue = 3;
                                break;
                            default:
                                Console.WriteLine("Invalid factor. Please enter 'half', 'double', or 'triple'.");
                                continue;
                        }
                        recipe.ScaleRecipe(factorValue);
                        break;
                    case 4:
                        recipe.ResetQuantities();
                        break;
                    case 5:
                        recipe.ClearRecipe();
                        break;
                    case 6:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}