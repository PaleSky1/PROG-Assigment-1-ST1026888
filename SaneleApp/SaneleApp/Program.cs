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
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nChoose an option:");
                Console.ResetColor();
                Console.WriteLine("1. Enter recipe details");
                Console.WriteLine("2. Display recipe");
                Console.WriteLine("3. Scale recipe");
                Console.WriteLine("4. Reset quantities");
                Console.WriteLine("5. Clear recipe");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("6. Exit");
                Console.ResetColor();

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
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Enter scaling factor (half, double, or triple):");
                        Console.ResetColor();
                        string factorInput = Console.ReadLine().ToLower();
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
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid factor. Please enter 'half', 'double', or 'triple'.");
                                Console.ResetColor();
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
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid choice. Please try again.");
                        Console.ResetColor();
                        break;
                }
            }
        }
    }
}
//reference www.aztechit.co.uk. (n.d.). What is Cloud Based Solutions | With Examples & Benefits. [online] Available at: https://www.aztechit.co.uk/blog/what-is-cloud-based-solutions [Accessed 9 Jan. 2024]. 