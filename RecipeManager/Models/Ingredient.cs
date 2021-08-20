using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager.Models
{
    [Table("ingredients")]
    public class Ingredient
    {
        [Key]
        public int idingredient { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
