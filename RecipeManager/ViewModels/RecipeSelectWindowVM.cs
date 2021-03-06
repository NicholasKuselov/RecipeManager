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
using System.Windows;
using System.Windows.Input;

namespace RecipeManager.ViewModels
{
    class RecipeSelectWindowVM : ViewModelBase
    {
        public BindingList<Recipe> Recipes { get; set; } = new BindingList<Recipe>(RecipeHandler.Recipes);

        public BindingList<string> Tags { get; set; }
        //public List<Recipe> Recipes { get; set; } = RecipeHandler.Recipes;
        public Recipe SelectedRecipe { get; set; }
        public string InnerRecipeWeigth { get; set; } = "";

        private string _selectedTag;
        public string SelectedTag
        {
            get { return _selectedTag; }
            set
            {
                _selectedTag = value;
                if (!value.Equals((string)Application.Current.Resources["RecipeTag"]))
                {
                    Search(value, SearchTypes.ByTag);
                }
                else
                {
                    Search("", SearchTypes.ByTag);
                }

            }
        }

        private string _searchText = "";
        public string SearchText
        {
            get { return _searchText; }
            set
            {
                _searchText = value;
                Search(value, SearchTypes.ByText);
            }
        }

        public RecipeSelectWindowVM()
        {
            List<string> tags = new List<string>();

            tags.Add((string)Application.Current.Resources["RecipeTag"]);
            for (int i = 0; i < RecipeHandler.Recipes.Count; i++)
            {
                if (!tags.Contains(RecipeHandler.Recipes[i].Tag.ToLower()) && !RecipeHandler.Recipes[i].Tag.Equals("")) tags.Add(RecipeHandler.Recipes[i].Tag.ToLower());
            }

            Tags = new BindingList<string>(tags);
        }

        //public Recipe SelectedRecipe { set { new RecipeOverviewWIndow(value).Show(); } }
        public ICommand SelectRecipe
        {
            get
            {
                return new RelayCommand(() =>
                {
                    //TODO: Add "if"es for check inner recipe params
                    //MessageBox.Show(SelectedRecipe.Name);
                    ((RecipeCreatePageVM)(((MainViewModel)App.Current.MainWindow.DataContext).createRecipePage.DataContext)).AddInnerRecipe(new InnerRecipe() { ARecipe = SelectedRecipe, Weigth = Convert.ToInt32(InnerRecipeWeigth) });
                    ((RecipeCreatePageVM)(((MainViewModel)App.Current.MainWindow.DataContext).createRecipePage.DataContext)).recipeSelectWindow.Close() ;

                });
            }
        }

        public void Search(string text, SearchTypes searchType)
        {
            if (text.Length > 0)
            {
                if (searchType.Equals(SearchTypes.ByText))
                {
                    Recipes = new BindingList<Recipe>(RecipeHandler.Recipes.FindAll(p => Filter(p.Name, text)));
                }
                else if (searchType.Equals(SearchTypes.ByTag))
                {
                    Recipes = new BindingList<Recipe>(RecipeHandler.Recipes.FindAll(p => p.Tag.ToLower().Equals(text.ToLower())));
                }
            }
            else
            {
                Recipes = new BindingList<Recipe>(RecipeHandler.Recipes);
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



        public enum SearchTypes
        {
            ByText,
            ByTag
        }
    }
}
