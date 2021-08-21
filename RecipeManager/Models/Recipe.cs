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
 

        public int GetCostPrice(int weigth)
        {
            int Price = 0;

            double proc = (double)weigth / (double)Weigth;
            for (int i = 0; i < Ingredients.Count; i++)
            {
                Ingredients[i].Weigth = (int)(Ingredients[i].Weigth * proc);
                Price += (int)(Ingredients[i].Price * (Ingredients[i].Weigth / 100.0));
                Ingredients[i].Price = Ingredients[i].Price * (Ingredients[i].Weigth / 100);
            }

            for (int i = 0; i < InnerRecipes.Count; i++)
            {
                InnerRecipes[i].Weigth = (int)(InnerRecipes[i].Weigth * proc);
                Price += InnerRecipes[i].Price;
                //ingredients[i].Price = ingredients[i].Price * (ingredients[i].Weigth / 100);
            }
            return Price;
        }
    }
}
