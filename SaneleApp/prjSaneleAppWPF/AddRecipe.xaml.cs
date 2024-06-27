using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace prjSaneleAppWPF
{
    public partial class AddRecipe : Window
    {
        private Manager<RecipeCategory> categoryManager;
        private Recipe currentRecipe;

        public AddRecipe(Manager<RecipeCategory> manager)
        {
            InitializeComponent();
            categoryManager = manager;
            currentRecipe = new Recipe();
            currentRecipe.CaloriesExceeded += OnCaloriesExceeded; // Subscribe to the event
            LoadCategories();
        }

        private void LoadCategories()
        {
            comb_RecipeCategory.ItemsSource = categoryManager.GetItemsSorted().Select(c => c.Name);
        }

        private void btn_AddIngredient_Click(object sender, RoutedEventArgs e)
        {
            string name = txt_IngredientName.Text;
            string type = (comb_IngredientTypes.SelectedItem as ComboBoxItem)?.Content.ToString();
            int calories = int.TryParse(txt_Calories.Text, out int cal) ? cal : 0;
            double measurement = double.TryParse(txt_Measurement.Text, out double meas) ? meas : 0;
            string unit = (comb_Units.SelectedItem as ComboBoxItem)?.Content.ToString();

            Ingredient ingredient = new Ingredient
            {
                Name = name,
                Type = type,
                Calories = calories,
                Measurement = measurement,
                Unit = unit
            };
            currentRecipe.AddIngredient(ingredient);

            lbl_TotalCalories.Content = $"Total Calories: {currentRecipe.TotalCalories}";

            txt_IngredientName.Clear();
            comb_IngredientTypes.SelectedIndex = -1;
            txt_Calories.Clear();
            txt_Measurement.Clear();
            comb_Units.SelectedIndex = -1;
        }

        private void OnCaloriesExceeded(int totalCalories)
        {
            CaloriesExceededPopup popup = new CaloriesExceededPopup();
            popup.ShowDialog();
        }

        private void btn_AddStep_Click(object sender, RoutedEventArgs e)
        {
            string description = txt_StepDescription.Text;
            int time = int.TryParse(txt_StepTime.Text, out int stepTime) ? stepTime : 0;

            Step step = new Step
            {
                Description = description,
                Time = time
            };
            currentRecipe.Steps.Add(step);

            txt_StepDescription.Clear();
            txt_StepTime.Clear();
        }

        private void btn_SaveRecipe_Click(object sender, RoutedEventArgs e)
        {
            currentRecipe.Name = txt_RecipeName.Text;

            string selectedCategory = comb_RecipeCategory.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedCategory))
            {
                MessageBox.Show("Please select a category.");
                return;
            }

            var category = categoryManager.Items.FirstOrDefault(c => c.Name == selectedCategory);
            if (category != null)
            {
                category.Recipes.Add(currentRecipe);
            }

            this.Close();
        }
    }
}
