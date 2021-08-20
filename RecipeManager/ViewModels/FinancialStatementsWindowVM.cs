using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace RecipeManager.ViewModels
{
    class FinancialStatementsWindowVM : ViewModelBase
    {
        public Page sellsPage;
        public Page clientsPage;
        public Page statPage;
        public Page CurrentPage { get; set; }



        public FinancialStatementsWindowVM()
        {
            sellsPage = new Pages.FinanceStatements.SellsPage();
            clientsPage = new Pages.FinanceStatements.ClientsPage();
            statPage = new Pages.FinanceStatements.StatPage();


            CurrentPage = sellsPage;
        }

        public ICommand GoToSellsPage
        {
            get
            {
                return new RelayCommand(() =>
                {
                    if (CurrentPage != sellsPage)
                    {
                        sellsPage = new Pages.FinanceStatements.SellsPage();
                        CurrentPage = sellsPage;
                    }
                });
            }
        }

        public ICommand GoToClientsPage
        {
            get
            {
                return new RelayCommand(() =>
                {
                    if (CurrentPage != clientsPage)
                    {
                        clientsPage = new Pages.FinanceStatements.ClientsPage();
                        CurrentPage = clientsPage;
                    }
                });
            }
        }

        public ICommand GoToStatPage
        {
            get
            {
                return new RelayCommand(() =>
                {
                    if (CurrentPage != statPage)
                    {
                        statPage = new Pages.FinanceStatements.StatPage();
                        CurrentPage = statPage;
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
                    ((MainViewModel)App.Current.MainWindow.DataContext).financeStatementWindow.Close();
                });
            }
        }

        public ICommand MaximizeWindowCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    if (((MainViewModel)App.Current.MainWindow.DataContext).financeStatementWindow.WindowState == WindowState.Maximized)
                    {
                        ((MainViewModel)App.Current.MainWindow.DataContext).financeStatementWindow.WindowState = WindowState.Normal;
                    }
                    else
                    {
                        ((MainViewModel)App.Current.MainWindow.DataContext).financeStatementWindow.WindowState = WindowState.Maximized;
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
                    ((MainViewModel)App.Current.MainWindow.DataContext).financeStatementWindow.WindowState = WindowState.Minimized;
                });
            }
        }
    }
}
