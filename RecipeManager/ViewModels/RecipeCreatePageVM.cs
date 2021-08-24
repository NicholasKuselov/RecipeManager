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
    class RecipeCreatePageVM : ViewModelBase
    {
        public Recipe Recipe;
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

        public RecipeCreatePageVM()
        {
            foreach (Ingredient item in DataBaseHandler.DataBase.ingredients.ToList())
            {
                AllIngredientsNames.Add(item.Name);
            }
        }

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

        public ICommand AddRecipe
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
                        if (!RecipeHandler.IsNameEmpty(RecipeName))
                        {
                            ErrorHandler.RecipeNameAlreadyExist();
                        }
                        else
                        {
                            Recipe = new Recipe() { Ingredients = this.Ingredients.ToList(), Weigth = Convert.ToInt32(RecipeWeigth), Name = RecipeName, Tag = RecipeTag, InnerRecipes = InnerRecipes.ToList() };
                            RecipeHandler.AddRecipe(Recipe);
                            Ingredients.Clear();
                            InnerRecipes.Clear();
                            RecipeWeigth = "";
                            RecipeName = "";
                            RecipeTag = "";
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
