using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjSaneleAppWPF
{
    public class RecipeCategory
    {
        public string Name { get; set; }
        public List<Recipe> Recipes { get; set; }

        public RecipeCategory()
        {
            Recipes = new List<Recipe>();
        }
    }
}