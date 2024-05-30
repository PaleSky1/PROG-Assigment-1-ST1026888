using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjSaneleAppWPF
{
    public class Manager<T>
    {
        //List to hold items 
        public List<T> Items { get; private set; }

        //Constructor
        public Manager()
        {
            Items = new List<T>();
        }

        //Add Method
        public void AddItem(T item)
        {
            Items.Add(item);
        }

        //Sort Method
        public IEnumerable<T> GetItemsSorted()
        {
            return Items.OrderBy(item => item.GetType().GetProperty("Name").GetValue(item, null));
        }
    }
}