using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using RecipeManager.Controllers;
using RecipeManager.Models;
using RecipeManager.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RecipeManager.ViewModels
{
    class RecipeOverviewWIndowVM : ViewModelBase
    {
        public Recipe Recipe { get; set; }
        public RecipeOverviewWIndowVM()
        {
        }

        public RecipeOverviewWIndowVM(Recipe recipe)
        {
            Recipe = recipe;

            RecipeName = recipe.Name;
            RecipeWeigth = recipe.Weigth.ToString();
            RecipeTag = recipe.Tag;

            Ingredients = new BindingList<IngredientForRecipe>(recipe.Ingredients);
            InnerRecipes = new BindingList<InnerRecipe>(recipe.InnerRecipes);
            foreach (Ingredient item in DataBaseHandler.DataBase.ingredients.ToList())
            {
                AllIngredientsNames.Add(item.Name);
            }
        }

        public BindingList<IngredientForRecipe> Ingredients { get; set; } = new BindingList<IngredientForRecipe>();
        public BindingList<InnerRecipe> InnerRecipes { get; set; } = new BindingList<InnerRecipe>();
        public BindingList<string> AllIngredientsNames { get; set; } = new BindingList<string>();

        //private string _selectedIngredietnName = "";
        public Recipe SelectedRecipe { get; set; }
        public string SelectedIngredientName { get; set; } = "";

        public RecipeSelectWindow recipeSelectWindow;

        public IngredientForRecipe SelectedIngredient { get; set; }

        public string IngWeigth { get; set; } = "";
        public string IngName { get; set; } = "";

        public string RecipeName { get; set; } = "";
        public string RecipeWeigth { get; set; } = "";
        public string RecipeTag { get; set; } = "";


        public ICommand DeleteIngredient
        {
            get
            {
                return new RelayCommand(() =>
                {
                    if (SelectedIngredient != null)
                    {
                        Ingredients.Remove(SelectedIngredient);
                    }

                });
            }
        }

        public ICommand AddIngredient
        {
            get
            {
                return new RelayCommand(() =>
                {
                    if (SelectedIngredientName.Length == 0)
                    {
                        ErrorHandler.NoIngredientName();
                    }
                    else if (IngWeigth.Length == 0)
                    {
                        ErrorHandler.NoIngredientWeigth();
                    }
                    else
                    {
                        Ingredient ingredient = DataBaseHandler.DataBase.ingredients.First(p => p.Name.Equals(SelectedIngredientName));

                        Ingredients.Add(new IngredientForRecipe() { id = ingredient.idingredient, Name = ingredient.Name, Price = ingredient.Price, Weigth = Convert.ToInt32(IngWeigth) });
                        IngWeigth = "";
                        //IngName = "";
                    }
                });
            }
        }

        public ICommand UpdateRecipe
        {
            get
            {
                return new RelayCommand(() =>
                {
                    if (RecipeName.Length == 0)
                    {
                        ErrorHandler.NoRecipeName();
                    }
                    else if (RecipeWeigth.Length == 0)
                    {
                        ErrorHandler.NoRecipeWeigth();
                    }
                    else
                    {
                        //int i = RecipeHandler.Recipes.FindIndex(p=> p.Name.Equals(Recipe.Name));
                        if (!RecipeHandler.IsNameEmpty(RecipeName))
                        {
                            ErrorHandler.RecipeNameAlreadyExist();
                        }
                        else
                        {
                            int oldHash = Recipe.Name.GetHashCode();
                            RecipeHandler.Recipes.RemoveAll(p => p.Name.Equals(Recipe.Name));
                            Recipe = new Recipe() { Ingredients = this.Ingredients.ToList(), Weigth = Convert.ToInt32(RecipeWeigth), Name = RecipeName, Tag = RecipeTag, InnerRecipes = InnerRecipes.ToList() };
                            RecipeHandler.AddRecipe(Recipe);
                            DataBaseHandler.UpdateSellsProductHash(oldHash, RecipeName.GetHashCode());
                        }
                    }
                });
            }
        }

        public void AddInnerRecipe(InnerRecipe innerRecipe)
        {
            InnerRecipes.Add(innerRecipe);
        }

        public ICommand bAddInnerRecipe
        {
            get
            {
                return new RelayCommand(() =>
                {
                    recipeSelectWindow = new RecipeSelectWindow();
                    recipeSelectWindow.Show();
                });
            }
        }
    }
}
