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
            // Example categories
            var appetizers = new RecipeCategory { Name = "Appetizers" };
            var mainCourses = new RecipeCategory { Name = "Main Courses" };
            var desserts = new RecipeCategory { Name = "Desserts" };

            categoryManager.AddItem(appetizers);
            categoryManager.AddItem(mainCourses);
            categoryManager.AddItem(desserts);

            comb_Categories.ItemsSource = categoryManager.GetItemsSorted().Select(c => c.Name);
        }

        private void comb_Categories_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comb_Categories.SelectedItem != null)
            {
                string selectedCategory = comb_Categories.SelectedItem.ToString();
                var category = categoryManager.Items.FirstOrDefault(c => c.Name == selectedCategory);
                if (category != null)
                {
                    list_Recipes.ItemsSource = category.Recipes.OrderBy(r => r.Name).ToList();
                }
            }
        }

        private void list_Recipes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (list_Recipes.SelectedItem != null)
            {
                Recipe selectedRecipe = (Recipe)list_Recipes.SelectedItem;
                ShowRecipeDetails(selectedRecipe);
            }
        }

        private void ShowRecipeDetails(Recipe recipe)
        {
            RecipeDetails recipeDetailsWindow = new RecipeDetails(recipe);
            recipeDetailsWindow.ShowDialog();
        }

        private void btn_AddRecipe_Click(object sender, RoutedEventArgs e)
        {
            AddRecipe addRecipeWindow = new AddRecipe(categoryManager);
            this.Hide();
            addRecipeWindow.ShowDialog();
            this.Show();

            // Refresh the recipe list
            comb_Categories_SelectionChanged(null, null);
        }
    }
}