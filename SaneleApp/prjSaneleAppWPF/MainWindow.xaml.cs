using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace prjSaneleAppWPF
{
    public partial class MainWindow : Window
    {
        private Manager<RecipeCategory> categoryManager;

        public MainWindow()
        {
            InitializeComponent();
            categoryManager = new Manager<RecipeCategory>();
            LoadCategories();
        }

        private void LoadCategories()
        {
            var appetizers = new RecipeCategory { Name = "Appetizers" };
            var mainCourses = new RecipeCategory { Name = "Main Courses" };
            var desserts = new RecipeCategory { Name = "Desserts" };

            //Add categories to the manager
            categoryManager.AddItem(appetizers);
            categoryManager.AddItem(mainCourses);
            categoryManager.AddItem(desserts);

            //Bind categories to the combobox
            comb_Categories.ItemsSource = categoryManager.GetItemsSorted().Select(c => c.Name);
        }

        private void comb_Categories_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comb_Categories.SelectedItem != null)
            {
                //Get the category
                string selectedCategory = comb_Categories.SelectedItem.ToString();
                var category = categoryManager.Items.FirstOrDefault(c => c.Name == selectedCategory);
                if (category != null)
                {
                    //Bind recipes to the recipe list
                    list_Recipes.ItemsSource = category.Recipes.OrderBy(r => r.Name).ToList();
                }
            }
        }

        private void list_Recipes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (list_Recipes.SelectedItem != null)
            {
                //Display details of the recipe
                Recipe selectedRecipe = (Recipe)list_Recipes.SelectedItem;
                ShowRecipeDetails(selectedRecipe);
            }
        }

        //Show details of the selected recipe
        private void ShowRecipeDetails(Recipe recipe)
        {
            RecipeDetails recipeDetailsWindow = new RecipeDetails(recipe);
            recipeDetailsWindow.ShowDialog();
        }

        private void btn_AddRecipe_Click(object sender, RoutedEventArgs e)
        {
            //Open the AddRecipe
            AddRecipe addRecipeWindow = new AddRecipe(categoryManager);
            this.Hide();
            addRecipeWindow.ShowDialog();
            this.Show();

            comb_Categories_SelectionChanged(null, null);
        }
        private void btn_GenerateChart_Click(object sender, RoutedEventArgs e)
        {
            var selectedRecipes = list_Recipes.SelectedItems.Cast<Recipe>().ToList();
            if (selectedRecipes.Count > 0)
            {
                var foodGroupPercentages = CalculateFoodGroupPercentages(selectedRecipes);
                ShowPieChart(foodGroupPercentages);
            }
            else
            {
                MessageBox.Show("Please select at least one recipe.");
            }
        }

        private Dictionary<string, double> CalculateFoodGroupPercentages(List<Recipe> recipes)
        {
            Dictionary<string, double> foodGroupPercentages = new Dictionary<string, double>();

            foreach (var recipe in recipes)
            {
                foreach (var ingredient in recipe.Ingredients)
                {
                    if (foodGroupPercentages.ContainsKey(ingredient.Type))
                    {
                        foodGroupPercentages[ingredient.Type] += ingredient.Calories;
                    }
                    else
                    {
                        foodGroupPercentages[ingredient.Type] = ingredient.Calories;
                    }
                }
            }

            return foodGroupPercentages;
        }

        private void ShowPieChart(Dictionary<string, double> foodGroupPercentages)
        {
            PieChartWindow pieChartWindow = new PieChartWindow(foodGroupPercentages);
            pieChartWindow.ShowDialog();
        }
    }
}