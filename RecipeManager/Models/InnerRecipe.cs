using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager.Models
{
    public class InnerRecipe
    {
        public int Weigth { get; set; }
        public Recipe ARecipe { get; set; }
    }
}
