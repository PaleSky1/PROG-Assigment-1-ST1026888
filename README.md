Sanele Recipe App
https://youtu.be/V5byXW179LY?si=1jA0msEF2qUc55SA
YouTube Video
Introduction
------------
The Sanele Recipe App is a WPF application designed to help users manage their recipes and ingredients efficiently. 
Users can add new recipes, list them by categories, and filter recipes based on ingredients, food groups, or calorie content. 
Additionally, users can visualize the nutritional content of their selected recipes through a pie chart.


Features
------------
  Add and view recipes with detailed ingredients and steps.

  Filter recipes by ingredient, food group, or maximum calories.

  Select multiple recipes to include in a menu and visualize the nutritional breakdown using a pie chart.

  Notification if the total calorie count of a recipe exceeds 300 calories.


Updates
------------
  Pie Chart Keys: Added keys to the pie chart to clearly indicate the food group representation.

  Improved Error Handling: Enhanced error handling for better user experience.

  Code Refactoring: Refactored code for better readability and maintainability.

  Unit Testing: Added unit tests to cover the calorie calculation functionality.


Installation
------------
  Clone the repository from GitHub: git clone: https://github.com/PaleSky1/PROG-Assigment-1-ST10268888.git

  Open the project in Visual Studio.

  Build the solution to restore the necessary packages and dependencies.


Usage
------------
  Add Recipe: Click on the "Add Recipe" button in the main window. Fill in the recipe details, including name, category, ingredients, and steps.

  Filter Recipes: Use the filter options to search for recipes by ingredient, food group, or calorie limit.

  View Recipes: Select a recipe from the list to view its details.

  Pie Chart: Choose multiple recipes to include in a menu. The app will display a pie chart showing the percentage that each food group makes up of the total menu.


Code Structure
------------
  Ingredient.cs: Represents an ingredient with properties like Name, Type, Calories, Measurement, and Unit.

  Recipe.cs: Represents a recipe with properties like Name, Ingredients, Steps, and TotalCalories.

  RecipeCategory.cs: Represents a category of recipes.

  Step.cs: Represents a step in a recipe.

  Manager.cs: Generic class to manage a list of items, with methods to add items and get them sorted.

  MainWindow.xaml: The main window of the application where users can view and filter recipes.

  AddRecipe.xaml: The window for adding new recipes.

  PieChartWindow.xaml: The window displaying the pie chart of the selected recipes.

  CaloriesExceededPopup.xaml: Popup window to notify when calories exceed the set limit.


Additional Notes
------------
  The 300-calorie notification is implemented using a delegate to ensure smooth program flow after notification.

  Make sure to set the MainWindow.xaml as the startup window in your project settings.
