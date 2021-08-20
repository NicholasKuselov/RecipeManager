using GalaSoft.MvvmLight;
using RecipeManager.Controllers;
using RecipeManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RecipeManager.ViewModels
{
    class RecipeCalculatorPageVM : ViewModelBase
    {
        public List<IngredientForRecipe> Ingredients { get; set; }

        public Recipe SelectedRecipe { get; set; }

        public BindingList<Recipe> Recipes { get; set; }

        public int Price { get; set; } = 0;

        private int _needWeigth = 0;
        public string NeedWeigth
        {
            get { return _needWeigth.ToString(); }
            set
            {
                _needWeigth = Convert.ToInt32(value);
                if (Ingredients != null) CalcNeedWeigth();
            }
        }



        public List<string> RecipesNames { get; set; } = new List<string>();

        private string _selectedRecipeName;
        public string SelectedRecipeName
        {
            get { return _selectedRecipeName; }
            set
            {
                _selectedRecipeName = value;
                SelectedRecipe = Recipes.First(p => p.Name.Equals(value));
                if (SelectedRecipe != null)
                {
                    NeedWeigth = SelectedRecipe.Weigth.ToString();

                    Ingredients = new List<IngredientForRecipe>(GetDefaultIngradients());
                }
            }
        }

        public RecipeCalculatorPageVM()
        {
            RecipeHandler.Load();
            Recipes = new BindingList<Recipe>(RecipeHandler.Recipes);
            RecipesNames.Add((string)Application.Current.Resources["SelectRecipe"]);
            foreach (Recipe recipe in Recipes)
            {
                RecipesNames.Add(recipe.Name);
            }
        }

        private void CalcNeedWeigth()
        {
            Price = 0;
            List<IngredientForRecipe> ingredients = new List<IngredientForRecipe>(GetDefaultIngradients());
            double proc = (double)_needWeigth / (double)SelectedRecipe.Weigth;
            for (int i = 0; i < ingredients.Count; i++)
            {
                ingredients[i].Weigth = (int)(ingredients[i].Weigth * proc);
                Price += (int)(ingredients[i].Price * (ingredients[i].Weigth / 100.0));
                ingredients[i].Price = ingredients[i].Price * (ingredients[i].Weigth / 100);
            }
            Ingredients = new List<IngredientForRecipe>(ingredients);
        }

        private List<IngredientForRecipe> GetDefaultIngradients()
        {
            List<IngredientForRecipe> ss = new List<IngredientForRecipe>();
            for (int i = 0; i < SelectedRecipe.Ingredients.Count; i++)
            {
                ss.Add(new IngredientForRecipe()
                {

                    Name = SelectedRecipe.Ingredients[i].Name,
                    Price = SelectedRecipe.Ingredients[i].Price,
                    Weigth = SelectedRecipe.Ingredients[i].Weigth
                });


            }
            return ss;
        }
    }
}
