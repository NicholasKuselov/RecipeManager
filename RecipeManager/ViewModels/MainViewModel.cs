using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using RecipeManager.Controllers;
using RecipeManager.Properties;
using RecipeManager.Windows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Resources;

namespace RecipeManager.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public Page recipeCalculatorPage;
        public Page createRecipePage;
        public Page recipesPage;
        public Page ingredientsPage;
        public Page CurrentPage { get; set; }

        public Window financeStatementWindow;


        public MainViewModel()
        {
            recipeCalculatorPage = new Pages.RecipeCalculatorPage();
            createRecipePage = new Pages.RecipeCreatePage();
            recipesPage = new Pages.RecipePage();
            //DataBaseHandler.test();
            ingredientsPage = new Pages.IngredientsPage();
            //Subject = new Pages.Subjects();
            //Group = new Pages.Group();
            //Course = new Pages.Course();

            CurrentPage = recipeCalculatorPage;
        }

        public ICommand GoToRecipeCreatePage
        {
            get
            {
                return new RelayCommand(() =>
                {
                    if (CurrentPage != createRecipePage)
                    {
                        createRecipePage = new Pages.RecipeCreatePage();
                        CurrentPage = createRecipePage;
                    }
                });
            }
        }

        public ICommand GoToIngredientsPage
        {
            get
            {
                return new RelayCommand(() =>
                {
                    if (CurrentPage != ingredientsPage)
                    {
                        ingredientsPage = new Pages.IngredientsPage();
                        CurrentPage = ingredientsPage;
                    }
                });
            }
        }

        public ICommand GoToCalcPage
        {
            get
            {
                return new RelayCommand(() =>
                {
                    if (CurrentPage != recipeCalculatorPage)
                    {
                        recipeCalculatorPage = new Pages.RecipeCalculatorPage();
                        CurrentPage = recipeCalculatorPage;
                    }
                });
            }
        }

        public ICommand GoToRecipesPage
        {
            get
            {
                return new RelayCommand(() =>
                {
                    if (CurrentPage != recipesPage)
                    {
                        recipesPage = new Pages.RecipePage();
                        CurrentPage = recipesPage;
                    }
                });
            }
        }


        public ICommand CloseWindowCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    Application.Current.Shutdown();
                    Application.Current.MainWindow.Close();
                });
            }
        }

        public ICommand MaximizeWindowCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    if (Application.Current.MainWindow.WindowState == WindowState.Maximized)
                    {
                        Application.Current.MainWindow.WindowState = WindowState.Normal;
                    }
                    else
                    {
                        Application.Current.MainWindow.WindowState = WindowState.Maximized;
                    }

                });
            }
        }
        
        public ICommand MinimizeWindowCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    Application.Current.MainWindow.WindowState = WindowState.Minimized;
                });
            }
        }

        public ICommand OpenFinanceStatementWindow
        {
            get
            {
                return new RelayCommand(() =>
                {
                    financeStatementWindow = new FinancialStatemenceWindow();
                    financeStatementWindow.Show();
                });
            }
        }


    }
}
