using System.Diagnostics.Metrics;
using System.Text;

namespace Sanele_s_Recipe_App
{
    public partial class MainForm : Form
    {
        private Ingredient[] ingredientsArray = new Ingredient[0];
        private double multiplyValue = 1;
        public MainForm()
        {
            InitializeComponent();
        }
        //MenuPanel (top) - ( two buttons for navagation to ViewRecipesPanel and AddRecipePanel)
        private void btnViewRecipes_Click(object sender, EventArgs e)
        {
            MenuPanel.Visible = false;
            btnBackViewRecipe.Visible = true;
        }
        private void btnAddRecipes_Click(object sender, EventArgs e)
        {
            MenuPanel.Visible = false;
            AddRecipePanel.Visible = true;
        }
        //MenuPanel (bottom)

        //ViewRecipePanel (Top) - (Navigate back to MenuPanel, View Recipes, Edit and Delete Recipes and change recipe amount)

        private void btnReturnView_Click(object sender, EventArgs e)
        {
            btnBackViewRecipe.Visible = false;
            MenuPanel.Visible = true;
        }
        private void btnEditRecipe_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteRecipe_Click(object sender, EventArgs e)
        {

        }
        //ViewRecipePanel (Bottom)

        //AddRecipePanel (Top) - (navigate back to MenuPanel and add recipe details)
        private void btnReturnAdd_Click(object sender, EventArgs e)
        {
            //AddRecipePanel.Visible = false;
            //MenuPanel.Visible = true;
        }

        private void btnConfirmNumberIngredients_Click(object sender, EventArgs e)
        {
            int numberOfIngredients = (int)IngredientNumber.Value;

            ingredientsArray = Ingredient.ResizeArray(ingredientsArray, numberOfIngredients);
        }

        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            string ingredientName = txtIngredient.Text;
            string sitingIngredientAmount = txtAmount.Text;
            double ingredientAmount = Convert.ToDouble(sitingIngredientAmount);

            string measurement = comboBoxMeasurement.SelectedItem?.ToString();

            Ingredient ingredient = new Ingredient(ingredientName, ingredientAmount, measurement);

            ingredientsArray = Ingredient.AddIngredientToArray(ingredientsArray, ingredient);
        }
        private Ingredient[] AddIngredientToArray(Ingredient[] array, Ingredient ingredient)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = ingredient;
            return array;
        }
        private void btnConfirmNumberSteps_Click(object sender, EventArgs e)
        {
            int numberOfSteps = (int)StepNumber.Value;
        }

        private string[] AddStepToArray(string[] array, string step)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = step;
            return array;
        }

        private void btnAddStep_Click(object sender, EventArgs e)
        {
            string step = txtStep.Text;
            // You can handle steps in a similar manner if needed
        }
        private void btnHalf_Click(object sender, EventArgs e)
        {
            multiplyValue = 0.5;
        }

        private void btnOriginal_Click(object sender, EventArgs e)
        {
            multiplyValue = 1;
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            multiplyValue = 2;
        }

        private void btnTriple_Click(object sender, EventArgs e)
        {
            multiplyValue = 3;
        }
        private void btnCompleteRecipe_Click(object sender, EventArgs e)
        {
            string message = Ingredient.GetIngredientsMessage(ingredientsArray, multiplyValue);
            MessageBox.Show(message, "Added Ingredients", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    //AddRecipePanel (Bottom)
    }
}
