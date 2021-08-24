using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using RecipeManager.Controllers;
using RecipeManager.Models;
using RecipeManager.Models.DataBaseModels;
using RecipeManager.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace RecipeManager.ViewModels
{
    class ClientPunchaseHistoryWindowVM : ViewModelBase
    {
        public int SellsOwerviewPanelWidth { get; set; } = SidePanelState.Close;

        public Visibility CloseSellsOverviewPanelButtonVisibility { get; set; } = Visibility.Collapsed;


        public Client SelectedSellClient { get; set; }
        private SellsHistoryEntry _selectedSells = null;
        public SellsHistoryEntry SelectedSells
        {
            get { return _selectedSells; }
            set
            {
                _selectedSells = value;
                if (value != null)
                {
                    OpenClientOverviewPanel();
                    SelectedSellClient = DataBaseHandler.GetClientById(value.buyer);
                }
            }
        }
        public BindingList<SellsHistoryEntry> Sells { get; set; }

        public int AllPrice { get; set; }
        public int PunchaseCount { get; set; }

        public Client CurrentClient { get; set; }

        //Add Sell Panel
        public string SellDate { get; set; } = (string)Application.Current.Resources["SelectDate"];
        public BindingList<int> RecipesHashes { get; set; } = new BindingList<int>(RecipeHandler.GetRecipesHash());
        public int SelectedRecipeHash { get; set; } = 0;

        public string CostPrice { get; set; } = "0";
        public Client SelectedClient { get; set; }

        private string _sellWeigth = "";
        public string SellWeigth
        {
            get { return _sellWeigth; }
            set
            {
                if (SelectedRecipeHash != 0)
                {
                    Recipe recipe = RecipeHandler.GetRecipeByNameHash(SelectedRecipeHash);
                    CostPrice = (recipe.GetCostPrice(Convert.ToInt32(value)) / 100.0).ToString();
                    _sellWeigth = value;
                }

            }
        }
        public string SellPrice { get; set; } = "";

        private int GetAllPrice()
        {
            int price = 0;
            for (int i = 0; i < Sells.Count; i++)
            {
                price += Sells[i].price;
            }
            return price;
        }




        public ClientPunchaseHistoryWindowVM()
        {
            CurrentClient = ((ClientsPageVM)((FinancialStatementsWindowVM)((MainViewModel)App.Current.MainWindow.DataContext).financeStatementWindow.DataContext).clientsPage.DataContext).SelectedClient;
            Sells = new BindingList<SellsHistoryEntry>(DataBaseHandler.GetSellsEntryByClietnId(CurrentClient.idclient));
            AllPrice = GetAllPrice();
            PunchaseCount = Sells.Count;
        }


        public ICommand bOpenSellOverviewPanel
        {
            get
            {
                return new RelayCommand(() =>
                {
                    SellsOwerviewPanelWidth = SidePanelState.Close;
                    CloseSellsOverviewPanelButtonVisibility = Visibility.Collapsed;
                    SelectedSells = null;
                });
            }
        }


        public void OpenClientOverviewPanel()
        {

            SellsOwerviewPanelWidth = SidePanelState.Close;

            Task.Run(() =>
                {
                    for (int i = 0; i < SidePanelState.Open; i += 20)
                    {
                        SellsOwerviewPanelWidth = i;
                        Thread.Sleep(1);
                    }
                });

            CloseSellsOverviewPanelButtonVisibility = Visibility.Visible;






        }

        public class SidePanelState
        {
            //public static int Open = (int)((MainViewModel)App.Current.MainWindow.DataContext).financeStatementWindow.Width - 80;
            public static int Open = 800;

            public static int Close = 0;
        }



        public ICommand CloseWindowCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    ((ClientsPageVM)((FinancialStatementsWindowVM)((MainViewModel)App.Current.MainWindow.DataContext).financeStatementWindow.DataContext).clientsPage.DataContext).ClientPunchaseHistoryWindow.Close();

                });
            }
        }

        public ICommand MaximizeWindowCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    if (((ClientsPageVM)((FinancialStatementsWindowVM)((MainViewModel)App.Current.MainWindow.DataContext).financeStatementWindow.DataContext).clientsPage.DataContext).ClientPunchaseHistoryWindow.WindowState == WindowState.Maximized)
                    {
                        ((ClientsPageVM)((FinancialStatementsWindowVM)((MainViewModel)App.Current.MainWindow.DataContext).financeStatementWindow.DataContext).clientsPage.DataContext).ClientPunchaseHistoryWindow.WindowState = WindowState.Normal;
                    }
                    else
                    {
                        ((ClientsPageVM)((FinancialStatementsWindowVM)((MainViewModel)App.Current.MainWindow.DataContext).financeStatementWindow.DataContext).clientsPage.DataContext).ClientPunchaseHistoryWindow.WindowState = WindowState.Maximized;
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
                    ((ClientsPageVM)((FinancialStatementsWindowVM)((MainViewModel)App.Current.MainWindow.DataContext).financeStatementWindow.DataContext).clientsPage.DataContext).ClientPunchaseHistoryWindow.WindowState = WindowState.Minimized;
                });
            }
        }
    }
}
