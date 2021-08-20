using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using RecipeManager.Controllers;
using RecipeManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace RecipeManager.ViewModels
{
    class IngredientsPageVM : ViewModelBase
    {
        public BindingList<Ingredient> Ingredients { get; set; }

        public Ingredient SelectedIngredient { get; set; }

        public string IngName { get; set; } = "";
        public string IngPrice { get; set; } = "";

        private string _searchText = "";
        public string SearchText
        {
            get { return _searchText; }
            set
            {
                _searchText = value;
                Search(value);
            }
        }
        public IngredientsPageVM()
        {
            Ingredients = new BindingList<Ingredient>(DataBaseHandler.DataBase.ingredients.ToList());

        }

        public ICommand AddIngredient
        {
            get
            {
                return new RelayCommand(() =>
                {
                    if (IngName.Length == 0)
                    {
                        ErrorHandler.NoIngredientName();
                    }
                    else if (IngPrice.Length == 0)
                    {
                        ErrorHandler.NoIngredientWeigth();
                    }
                    else
                    {
                        try
                        {
                            Ingredient ingredient = new Ingredient() { Name = IngName, Price = Convert.ToInt32(IngPrice) };
                            DataBaseHandler.DataBase.ingredients.Add(ingredient);
                            DataBaseHandler.DataBase.SaveChanges();
                            Ingredients.Add(ingredient);
                        }
                        catch
                        {
                            MessageBox.Show("Error");
                        }
                    }
                });
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
                        DataBaseHandler.DataBase.ingredients.Remove(SelectedIngredient);
                        DataBaseHandler.DataBase.SaveChanges();
                        Ingredients.Remove(SelectedIngredient);
                    }

                });
            }
        }

        public void Search(string text)
        {
            if (text.Length > 0)
            {
                Ingredients = new BindingList<Ingredient>(DataBaseHandler.DataBase.ingredients.ToList().FindAll(p => Filter(p.Name, text)));
            }
            else
            {
                Ingredients = new BindingList<Ingredient>(DataBaseHandler.DataBase.ingredients.ToList());
            }
        }




        private bool Filter(string first, string second)
        {
            first = first.ToLower();
            second = second.ToLower();

            int min = first.Length;
            if (second.Length < min)
            {
                min = second.Length;
            }

            for (int i = 0; i < min; i++)
            {
                if (!first[i].Equals(second[i]))
                {
                    if (Levenshtein.LevenshteinDistance(first.Substring(0, min), second.Substring(0, min)) < min / 2) return true;
                    return false;
                }
            }
            return true;
        }
    }
}
