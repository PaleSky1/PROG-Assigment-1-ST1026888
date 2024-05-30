using NUnit.Framework;
using UnitTestProject; // Replace YourProjectNamespace with the actual namespace of your project

namespace UnitTestProject
{
    public class ManagerTests
    {
        private Manager<Recipe> recipeManager;

        [SetUp]
        public void Setup()
        {
            recipeManager = new Manager<Recipe>();
        }

        [Test]
        public void AddItem_AddsItemToList()
        {

            var recipe = new Recipe { Name = "Test Recipe" };

            recipeManager.AddItem(recipe);

            Assert.AreEqual(1, recipeManager.Items.Count);
            Assert.AreEqual(recipe, recipeManager.Items[0]);
        }

        [Test]
        public void GetItemsSorted_ReturnsItemsInSortedOrder()
        {
            var recipe1 = new Recipe { Name = "Z" };
            var recipe2 = new Recipe { Name = "A" };
            var recipe3 = new Recipe { Name = "B" };

            recipeManager.AddItem(recipe1);
            recipeManager.AddItem(recipe2);
            recipeManager.AddItem(recipe3);

            var sortedItems = recipeManager.GetItemsSorted();

            Assert.AreEqual(3, sortedItems.Count);
            Assert.AreEqual("A", sortedItems[0].Name);
            Assert.AreEqual("B", sortedItems[1].Name);
            Assert.AreEqual("Z", sortedItems[2].Name);
        }
    }
}