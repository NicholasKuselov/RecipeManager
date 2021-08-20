using GalaSoft.MvvmLight.Command;
using RecipeManager.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace RecipeManager.Models
{
    public class Recipe
    {
        public string Name { get; set; }
        public int Weigth { get; set; }
        public List<IngredientForRecipe> Ingredients { get; set; }
        public List<InnerRecipe> InnerRecipes { get; set; }
        public string Tag { get; set; } = "";

        [JsonIgnore]
        public ICommand Delete
        {
            get
            {
                return new RelayCommand(() =>
                {
                    if(MessageBox.Show((string)Application.Current.Resources["DeleteRecipe"]+ " "+Name+"?", (string)Application.Current.Resources["DeleteCaption"], MessageBoxButton.YesNo, MessageBoxImage.Warning).Equals(MessageBoxResult.Yes)) RecipeHandler.DeleteRecipe(this);
                });
            }
        }
    }
}
