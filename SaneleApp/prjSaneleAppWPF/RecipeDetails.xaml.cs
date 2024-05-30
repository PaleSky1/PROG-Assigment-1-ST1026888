using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace prjSaneleAppWPF
{
    public partial class RecipeDetails : Window
    {
        public RecipeDetails(Recipe recipe)
        {
            InitializeComponent();
            DisplayRecipeDetails(recipe);
        }

        private void DisplayRecipeDetails(Recipe recipe)
        {
            txtBlock_Details.Text = $"Recipe Name: {recipe.Name}\n\nIngredients:\n";
            foreach (Ingredient ingredient in recipe.Ingredients)
            {
                txtBlock_Details.Text += $"{ingredient.Name}: {ingredient.Measurement} {ingredient.Unit}\n";
            }
            txtBlock_Details.Text += "\nSteps:\n";
            foreach (Step step in recipe.Steps)
            {
                txtBlock_Details.Text += $"{step.Description} (Time: {step.Time} minutes)\n";
            }
        }
    }
}
