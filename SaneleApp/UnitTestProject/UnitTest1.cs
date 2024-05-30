using NUnit.Framework;
using UnitTestProject; // Replace YourProjectNamespace with the actual namespace of your project

namespace UnitTestProject
{
    public class ManagerTests
    {
        private Manager<DummyItem> manager;

        [SetUp]
        public void Setup()
        {
            manager = new Manager<DummyItem>();
        }

        [Test]
        public void AddItem_AddsItemToList()
        {
            var item = new DummyItem { Name = "Test Item" };

            manager.AddItem(item);

            Assert.AreEqual(1, manager.Items.Count);
            Assert.AreEqual(item, manager.Items[0]);
        }

        [Test]
        public void GetItemsSorted_ReturnsItemsInSortedOrder()
        {
            var item1 = new DummyItem { Name = "Z" };
            var item2 = new DummyItem { Name = "A" };
            var item3 = new DummyItem { Name = "B" };

            manager.AddItem(item1);
            manager.AddItem(item2);
            manager.AddItem(item3);

            var sortedItems = manager.GetItemsSorted();

            Assert.AreEqual(3, sortedItems.Count());
            Assert.AreEqual("A", sortedItems.ElementAt(0).Name);
            Assert.AreEqual("B", sortedItems.ElementAt(1).Name);
            Assert.AreEqual("Z", sortedItems.ElementAt(2).Name);
        }
    }

    public class DummyItem
    {
        public string Name { get; set; }
    }