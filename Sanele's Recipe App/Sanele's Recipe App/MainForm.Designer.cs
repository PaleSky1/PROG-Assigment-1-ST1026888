namespace Sanele_s_Recipe_App
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MenuPanel = new Panel();
            btnViewRecipes = new Button();
            btnAddRecipes = new Button();
            btnBackViewRecipe = new Panel();
            btnReturnView = new Button();
            labRecipeTextBox = new Label();
            labRecipesList = new Label();
            txtRecipe = new TextBox();
            btnDeleteRecipe = new Button();
            btnEditRecipe = new Button();
            listBoxRecipes = new ListBox();
            AddRecipePanel = new Panel();
            btnReturnAdd = new Button();
            btnCompleteRecipe = new Button();
            labRecipeStepNumber = new Label();
            btnConfirmNumberSteps = new Button();
            StepNumber = new NumericUpDown();
            panel2 = new Panel();
            btnAddStep = new Button();
            txtStep = new TextBox();
            labStep = new Label();
            labIngredientNumber = new Label();
            labRecipeDescription = new Label();
            labRecipeName = new Label();
            panel1 = new Panel();
            labMeasurement = new Label();
            labAmountIngredient = new Label();
            labIngredient = new Label();
            btnAddIngredient = new Button();
            comboBoxMeasurement = new ComboBox();
            txtAmount = new TextBox();
            txtIngredient = new TextBox();
            btnConfirmNumberIngredients = new Button();
            IngredientNumber = new NumericUpDown();
            txtDescription = new TextBox();
            txtRecipeName = new TextBox();
            labRecipeTextBox2 = new Label();
            txtRecipe2 = new TextBox();
            labAmount = new Label();
            btnTriple = new Button();
            btnDouble = new Button();
            btnOriginal = new Button();
            btnHalf = new Button();
            MenuPanel.SuspendLayout();
            btnBackViewRecipe.SuspendLayout();
            AddRecipePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StepNumber).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IngredientNumber).BeginInit();
            SuspendLayout();
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = Color.FromArgb(224, 224, 224);
            MenuPanel.Controls.Add(btnViewRecipes);
            MenuPanel.Controls.Add(btnAddRecipes);
            MenuPanel.Location = new Point(0, 0);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(1146, 672);
            MenuPanel.TabIndex = 0;
            MenuPanel.Visible = false;
            // 
            // btnViewRecipes
            // 
            btnViewRecipes.BackColor = Color.White;
            btnViewRecipes.FlatAppearance.BorderSize = 0;
            btnViewRecipes.FlatStyle = FlatStyle.Flat;
            btnViewRecipes.Location = new Point(371, 234);
            btnViewRecipes.Name = "btnViewRecipes";
            btnViewRecipes.Size = new Size(405, 91);
            btnViewRecipes.TabIndex = 1;
            btnViewRecipes.Text = "View Recipes ";
            btnViewRecipes.UseVisualStyleBackColor = false;
            btnViewRecipes.Click += btnViewRecipes_Click;
            // 
            // btnAddRecipes
            // 
            btnAddRecipes.BackColor = Color.White;
            btnAddRecipes.FlatAppearance.BorderSize = 0;
            btnAddRecipes.FlatStyle = FlatStyle.Flat;
            btnAddRecipes.Location = new Point(371, 345);
            btnAddRecipes.Name = "btnAddRecipes";
            btnAddRecipes.Size = new Size(405, 91);
            btnAddRecipes.TabIndex = 0;
            btnAddRecipes.Text = "Add Recipes";
            btnAddRecipes.UseVisualStyleBackColor = false;
            btnAddRecipes.Click += btnAddRecipes_Click;
            // 
            // btnBackViewRecipe
            // 
            btnBackViewRecipe.BackColor = Color.Silver;
            btnBackViewRecipe.Controls.Add(btnReturnView);
            btnBackViewRecipe.Controls.Add(labRecipeTextBox);
            btnBackViewRecipe.Controls.Add(labRecipesList);
            btnBackViewRecipe.Controls.Add(txtRecipe);
            btnBackViewRecipe.Controls.Add(btnDeleteRecipe);
            btnBackViewRecipe.Controls.Add(btnEditRecipe);
            btnBackViewRecipe.Controls.Add(listBoxRecipes);
            btnBackViewRecipe.Location = new Point(0, 0);
            btnBackViewRecipe.Name = "btnBackViewRecipe";
            btnBackViewRecipe.Size = new Size(1146, 672);
            btnBackViewRecipe.TabIndex = 1;
            btnBackViewRecipe.Visible = false;
            // 
            // btnReturnView
            // 
            btnReturnView.Location = new Point(153, 619);
            btnReturnView.Name = "btnReturnView";
            btnReturnView.Size = new Size(162, 28);
            btnReturnView.TabIndex = 11;
            btnReturnView.Text = "Return";
            btnReturnView.UseVisualStyleBackColor = true;
            btnReturnView.Click += btnReturnView_Click;
            // 
            // labRecipeTextBox
            // 
            labRecipeTextBox.AutoSize = true;
            labRecipeTextBox.Location = new Point(646, 39);
            labRecipeTextBox.Name = "labRecipeTextBox";
            labRecipeTextBox.Size = new Size(42, 15);
            labRecipeTextBox.TabIndex = 5;
            labRecipeTextBox.Text = "Recipe";
            // 
            // labRecipesList
            // 
            labRecipesList.AutoSize = true;
            labRecipesList.Location = new Point(35, 39);
            labRecipesList.Name = "labRecipesList";
            labRecipesList.Size = new Size(63, 15);
            labRecipesList.TabIndex = 4;
            labRecipesList.Text = "Recipe List";
            // 
            // txtRecipe
            // 
            txtRecipe.Location = new Point(646, 57);
            txtRecipe.Multiline = true;
            txtRecipe.Name = "txtRecipe";
            txtRecipe.Size = new Size(463, 556);
            txtRecipe.TabIndex = 3;
            // 
            // btnDeleteRecipe
            // 
            btnDeleteRecipe.Location = new Point(277, 514);
            btnDeleteRecipe.Name = "btnDeleteRecipe";
            btnDeleteRecipe.Size = new Size(181, 76);
            btnDeleteRecipe.TabIndex = 2;
            btnDeleteRecipe.Text = "Delete Recipe";
            btnDeleteRecipe.UseVisualStyleBackColor = true;
            btnDeleteRecipe.Click += btnDeleteRecipe_Click;
            // 
            // btnEditRecipe
            // 
            btnEditRecipe.Location = new Point(35, 514);
            btnEditRecipe.Name = "btnEditRecipe";
            btnEditRecipe.Size = new Size(181, 76);
            btnEditRecipe.TabIndex = 1;
            btnEditRecipe.Text = "Edit Recipe";
            btnEditRecipe.UseVisualStyleBackColor = true;
            btnEditRecipe.Click += btnEditRecipe_Click;
            // 
            // listBoxRecipes
            // 
            listBoxRecipes.FormattingEnabled = true;
            listBoxRecipes.ItemHeight = 15;
            listBoxRecipes.Location = new Point(35, 57);
            listBoxRecipes.Name = "listBoxRecipes";
            listBoxRecipes.Size = new Size(423, 409);
            listBoxRecipes.TabIndex = 0;
            // 
            // AddRecipePanel
            // 
            AddRecipePanel.BackColor = Color.Gray;
            AddRecipePanel.Controls.Add(labAmount);
            AddRecipePanel.Controls.Add(btnTriple);
            AddRecipePanel.Controls.Add(btnDouble);
            AddRecipePanel.Controls.Add(btnOriginal);
            AddRecipePanel.Controls.Add(btnHalf);
            AddRecipePanel.Controls.Add(btnReturnAdd);
            AddRecipePanel.Controls.Add(btnCompleteRecipe);
            AddRecipePanel.Controls.Add(labRecipeStepNumber);
            AddRecipePanel.Controls.Add(btnConfirmNumberSteps);
            AddRecipePanel.Controls.Add(StepNumber);
            AddRecipePanel.Controls.Add(panel2);
            AddRecipePanel.Controls.Add(labIngredientNumber);
            AddRecipePanel.Controls.Add(labRecipeDescription);
            AddRecipePanel.Controls.Add(labRecipeName);
            AddRecipePanel.Controls.Add(panel1);
            AddRecipePanel.Controls.Add(btnConfirmNumberIngredients);
            AddRecipePanel.Controls.Add(IngredientNumber);
            AddRecipePanel.Controls.Add(txtDescription);
            AddRecipePanel.Controls.Add(txtRecipeName);
            AddRecipePanel.Controls.Add(labRecipeTextBox2);
            AddRecipePanel.Controls.Add(txtRecipe2);
            AddRecipePanel.Location = new Point(0, 0);
            AddRecipePanel.Name = "AddRecipePanel";
            AddRecipePanel.Size = new Size(1146, 672);
            AddRecipePanel.TabIndex = 1;
            // 
            // btnReturnAdd
            // 
            btnReturnAdd.Location = new Point(800, 620);
            btnReturnAdd.Name = "btnReturnAdd";
            btnReturnAdd.Size = new Size(162, 28);
            btnReturnAdd.TabIndex = 23;
            btnReturnAdd.Text = "Return";
            btnReturnAdd.UseVisualStyleBackColor = true;
            btnReturnAdd.Click += btnReturnAdd_Click;
            // 
            // btnCompleteRecipe
            // 
            btnCompleteRecipe.BackColor = SystemColors.ControlLightLight;
            btnCompleteRecipe.Location = new Point(104, 620);
            btnCompleteRecipe.Name = "btnCompleteRecipe";
            btnCompleteRecipe.Size = new Size(311, 40);
            btnCompleteRecipe.TabIndex = 20;
            btnCompleteRecipe.Text = "Complete";
            btnCompleteRecipe.UseVisualStyleBackColor = false;
            btnCompleteRecipe.Click += btnCompleteRecipe_Click;
            // 
            // labRecipeStepNumber
            // 
            labRecipeStepNumber.AutoSize = true;
            labRecipeStepNumber.Location = new Point(35, 391);
            labRecipeStepNumber.Name = "labRecipeStepNumber";
            labRecipeStepNumber.Size = new Size(96, 15);
            labRecipeStepNumber.TabIndex = 22;
            labRecipeStepNumber.Text = "Number of Steps";
            // 
            // btnConfirmNumberSteps
            // 
            btnConfirmNumberSteps.BackColor = SystemColors.ControlLightLight;
            btnConfirmNumberSteps.Location = new Point(335, 409);
            btnConfirmNumberSteps.Name = "btnConfirmNumberSteps";
            btnConfirmNumberSteps.Size = new Size(163, 23);
            btnConfirmNumberSteps.TabIndex = 21;
            btnConfirmNumberSteps.Text = "Confirm";
            btnConfirmNumberSteps.UseVisualStyleBackColor = false;
            btnConfirmNumberSteps.Click += btnConfirmNumberSteps_Click;
            // 
            // StepNumber
            // 
            StepNumber.Location = new Point(35, 409);
            StepNumber.Name = "StepNumber";
            StepNumber.Size = new Size(127, 23);
            StepNumber.TabIndex = 20;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(btnAddStep);
            panel2.Controls.Add(txtStep);
            panel2.Controls.Add(labStep);
            panel2.Location = new Point(35, 450);
            panel2.Name = "panel2";
            panel2.Size = new Size(463, 163);
            panel2.TabIndex = 19;
            // 
            // btnAddStep
            // 
            btnAddStep.BackColor = SystemColors.ControlLightLight;
            btnAddStep.Location = new Point(69, 100);
            btnAddStep.Name = "btnAddStep";
            btnAddStep.Size = new Size(311, 40);
            btnAddStep.TabIndex = 4;
            btnAddStep.Text = "Add";
            btnAddStep.UseVisualStyleBackColor = false;
            btnAddStep.Click += btnAddStep_Click;
            // 
            // txtStep
            // 
            txtStep.Location = new Point(19, 25);
            txtStep.Multiline = true;
            txtStep.Name = "txtStep";
            txtStep.Size = new Size(429, 69);
            txtStep.TabIndex = 3;
            // 
            // labStep
            // 
            labStep.AutoSize = true;
            labStep.Location = new Point(19, 7);
            labStep.Name = "labStep";
            labStep.Size = new Size(30, 15);
            labStep.TabIndex = 19;
            labStep.Text = "Step";
            // 
            // labIngredientNumber
            // 
            labIngredientNumber.AutoSize = true;
            labIngredientNumber.Location = new Point(35, 192);
            labIngredientNumber.Name = "labIngredientNumber";
            labIngredientNumber.Size = new Size(127, 15);
            labIngredientNumber.TabIndex = 15;
            labIngredientNumber.Text = "Number of Ingredients";
            // 
            // labRecipeDescription
            // 
            labRecipeDescription.AutoSize = true;
            labRecipeDescription.Location = new Point(35, 95);
            labRecipeDescription.Name = "labRecipeDescription";
            labRecipeDescription.Size = new Size(105, 15);
            labRecipeDescription.TabIndex = 14;
            labRecipeDescription.Text = "Recipe Description";
            // 
            // labRecipeName
            // 
            labRecipeName.AutoSize = true;
            labRecipeName.Location = new Point(35, 39);
            labRecipeName.Name = "labRecipeName";
            labRecipeName.Size = new Size(77, 15);
            labRecipeName.TabIndex = 13;
            labRecipeName.Text = "Recipe Name";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(labMeasurement);
            panel1.Controls.Add(labAmountIngredient);
            panel1.Controls.Add(labIngredient);
            panel1.Controls.Add(btnAddIngredient);
            panel1.Controls.Add(comboBoxMeasurement);
            panel1.Controls.Add(txtAmount);
            panel1.Controls.Add(txtIngredient);
            panel1.Location = new Point(35, 254);
            panel1.Name = "panel1";
            panel1.Size = new Size(463, 123);
            panel1.TabIndex = 12;
            // 
            // labMeasurement
            // 
            labMeasurement.AutoSize = true;
            labMeasurement.Location = new Point(386, 9);
            labMeasurement.Name = "labMeasurement";
            labMeasurement.Size = new Size(83, 15);
            labMeasurement.TabIndex = 18;
            labMeasurement.Text = "Measurement ";
            // 
            // labAmountIngredient
            // 
            labAmountIngredient.AutoSize = true;
            labAmountIngredient.Location = new Point(285, 9);
            labAmountIngredient.Name = "labAmountIngredient";
            labAmountIngredient.Size = new Size(51, 15);
            labAmountIngredient.TabIndex = 17;
            labAmountIngredient.Text = "Amount";
            // 
            // labIngredient
            // 
            labIngredient.AutoSize = true;
            labIngredient.Location = new Point(19, 9);
            labIngredient.Name = "labIngredient";
            labIngredient.Size = new Size(61, 15);
            labIngredient.TabIndex = 16;
            labIngredient.Text = "Ingredient";
            // 
            // btnAddIngredient
            // 
            btnAddIngredient.BackColor = SystemColors.ControlLightLight;
            btnAddIngredient.Location = new Point(69, 66);
            btnAddIngredient.Name = "btnAddIngredient";
            btnAddIngredient.Size = new Size(311, 40);
            btnAddIngredient.TabIndex = 4;
            btnAddIngredient.Text = "Add";
            btnAddIngredient.UseVisualStyleBackColor = false;
            btnAddIngredient.Click += btnAddIngredient_Click;
            // 
            // comboBoxMeasurement
            // 
            comboBoxMeasurement.FormattingEnabled = true;
            comboBoxMeasurement.Items.AddRange(new object[] { "cup", "tablespoon", "teaspoon", "mililiters", "liters", "grams" });
            comboBoxMeasurement.Location = new Point(386, 27);
            comboBoxMeasurement.Name = "comboBoxMeasurement";
            comboBoxMeasurement.Size = new Size(62, 23);
            comboBoxMeasurement.TabIndex = 2;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(285, 27);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(95, 23);
            txtAmount.TabIndex = 1;
            // 
            // txtIngredient
            // 
            txtIngredient.Location = new Point(19, 27);
            txtIngredient.Name = "txtIngredient";
            txtIngredient.Size = new Size(162, 23);
            txtIngredient.TabIndex = 0;
            // 
            // btnConfirmNumberIngredients
            // 
            btnConfirmNumberIngredients.BackColor = SystemColors.ControlLightLight;
            btnConfirmNumberIngredients.Location = new Point(335, 210);
            btnConfirmNumberIngredients.Name = "btnConfirmNumberIngredients";
            btnConfirmNumberIngredients.Size = new Size(163, 23);
            btnConfirmNumberIngredients.TabIndex = 11;
            btnConfirmNumberIngredients.Text = "Confirm";
            btnConfirmNumberIngredients.UseVisualStyleBackColor = false;
            btnConfirmNumberIngredients.Click += btnConfirmNumberIngredients_Click;
            // 
            // IngredientNumber
            // 
            IngredientNumber.Location = new Point(35, 210);
            IngredientNumber.Name = "IngredientNumber";
            IngredientNumber.Size = new Size(127, 23);
            IngredientNumber.TabIndex = 10;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(35, 113);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(463, 63);
            txtDescription.TabIndex = 9;
            // 
            // txtRecipeName
            // 
            txtRecipeName.Location = new Point(35, 57);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(463, 23);
            txtRecipeName.TabIndex = 8;
            // 
            // labRecipeTextBox2
            // 
            labRecipeTextBox2.AutoSize = true;
            labRecipeTextBox2.Location = new Point(646, 39);
            labRecipeTextBox2.Name = "labRecipeTextBox2";
            labRecipeTextBox2.Size = new Size(42, 15);
            labRecipeTextBox2.TabIndex = 7;
            labRecipeTextBox2.Text = "Recipe";
            // 
            // txtRecipe2
            // 
            txtRecipe2.Location = new Point(646, 57);
            txtRecipe2.Multiline = true;
            txtRecipe2.Name = "txtRecipe2";
            txtRecipe2.Size = new Size(463, 556);
            txtRecipe2.TabIndex = 6;
            // 
            // labAmount
            // 
            labAmount.AutoSize = true;
            labAmount.Location = new Point(841, 26);
            labAmount.Name = "labAmount";
            labAmount.Size = new Size(54, 15);
            labAmount.TabIndex = 28;
            labAmount.Text = "Amount:";
            // 
            // btnTriple
            // 
            btnTriple.Location = new Point(1063, 13);
            btnTriple.Name = "btnTriple";
            btnTriple.Size = new Size(45, 41);
            btnTriple.TabIndex = 27;
            btnTriple.Text = "x3";
            btnTriple.UseVisualStyleBackColor = true;
            // 
            // btnDouble
            // 
            btnDouble.Location = new Point(1012, 13);
            btnDouble.Name = "btnDouble";
            btnDouble.Size = new Size(45, 41);
            btnDouble.TabIndex = 26;
            btnDouble.Text = "x2";
            btnDouble.UseVisualStyleBackColor = true;
            // 
            // btnOriginal
            // 
            btnOriginal.Location = new Point(961, 13);
            btnOriginal.Name = "btnOriginal";
            btnOriginal.Size = new Size(45, 41);
            btnOriginal.TabIndex = 25;
            btnOriginal.Text = "x1";
            btnOriginal.UseVisualStyleBackColor = true;
            // 
            // btnHalf
            // 
            btnHalf.Location = new Point(910, 13);
            btnHalf.Name = "btnHalf";
            btnHalf.Size = new Size(45, 41);
            btnHalf.TabIndex = 24;
            btnHalf.Text = "x1/2";
            btnHalf.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 672);
            Controls.Add(AddRecipePanel);
            Controls.Add(MenuPanel);
            Controls.Add(btnBackViewRecipe);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            Text = "Sanele's Recipes";
            MenuPanel.ResumeLayout(false);
            btnBackViewRecipe.ResumeLayout(false);
            btnBackViewRecipe.PerformLayout();
            AddRecipePanel.ResumeLayout(false);
            AddRecipePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)StepNumber).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IngredientNumber).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel MenuPanel;
        private Panel btnBackViewRecipe;
        private Panel AddRecipePanel;
        private Button btnViewRecipes;
        private Button btnAddRecipes;
        private ListBox listBoxRecipes;
        private Button btnDeleteRecipe;
        private Button btnEditRecipe;
        private TextBox txtRecipe;
        private Label labRecipeTextBox;
        private Label labRecipesList;
        private Label labRecipeTextBox2;
        private TextBox txtRecipe2;
        private Panel panel1;
        private TextBox txtIngredient;
        private Button btnConfirmNumberIngredients;
        private NumericUpDown IngredientNumber;
        private TextBox txtDescription;
        private TextBox txtRecipeName;
        private Label labIngredientNumber;
        private Label labRecipeDescription;
        private Label labRecipeName;
        private Label labStep;
        private Label labMeasurement;
        private Label labAmountIngredient;
        private Label labIngredient;
        private Button btnAddIngredient;
        private TextBox txtStep;
        private ComboBox comboBoxMeasurement;
        private TextBox txtAmount;
        private Button btnCompleteRecipe;
        private Label labRecipeStepNumber;
        private Button btnConfirmNumberSteps;
        private NumericUpDown StepNumber;
        private Panel panel2;
        private Button btnAddStep;
        private Button btnReturnView;
        private Button btnReturnAdd;
        private Label labAmount;
        private Button btnTriple;
        private Button btnDouble;
        private Button btnOriginal;
        private Button btnHalf;
    }
}
