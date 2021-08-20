using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RecipeManager.Models
{
    public class IngredientForRecipe 
    {
        //public Ingredient Ingredient { get; set; }
        public int Weigth {get;set;}
        public int id { get; set; }

        [JsonIgnore]
        public string Name { get; set; }
        [JsonIgnore]
        public int Price { get; set; }
    }
}
