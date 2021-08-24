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
    class SellsPageVM : ViewModelBase
    {

        public int SellsAddingPanelWidth { get; set; } = SidePanelState.Close;
        public int SellsOwerviewPanelWidth { get; set; } = SidePanelState.Close;

        public Visibility CloseSellsOverviewPanelButtonVisibility { get; set; } = Visibility.Collapsed;
        public Visibility DeleteSellButtonVisibility { get; set; } = Visibility.Collapsed;


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
                    DeleteSellButtonVisibility = Visibility.Visible;
                }
                else
                {
                    DeleteSellButtonVisibility = Visibility.Collapsed;
                }
            }
        }

        private BindingList<SellsHistoryEntry> _sells ;
        public BindingList<SellsHistoryEntry> Sells
        {
            get
            {
                return _sells;
            }
            set
            {
                _sells = value;
                GetStat();
            }
        } 


        public int AllSellsCount { get; set; } = 0;
        public int AllSellsPrice { get; set; } = 0;
        //Add Sell Panel
        public string SellDate { get; set; } = (string)Application.Current.Resources["SelectDate"];
        public BindingList<int> RecipesHashes { get; set; } = new BindingList<int>(RecipeHandler.GetRecipesHash());
        public int SelectedRecipeHash { get; set; } = 0;

        public string CostPrice { get; set; } = "0";
        public BindingList<Client> Clients { get; set; } = new BindingList<Client>(DataBaseHandler.DataBase.clients.ToList());
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

        public SelectDateWindow SelectDateWindow;




        public SellsPageVM()
        {
            Sells = new BindingList<SellsHistoryEntry>(DataBaseHandler.DataBase.history.ToList());
        }

        public ICommand bAddSell
        {
            get
            {
                return new RelayCommand(() =>
                {
                    DataBaseHandler.DataBase.history.Add(new SellsHistoryEntry()
                    {
                        buyer = SelectedClient.idclient,
                        date = SellDate,
                        price = Convert.ToInt32(SellPrice),
                        recipe = SelectedRecipeHash.ToString(),
                        weigth = Convert.ToInt32(SellWeigth)

                    });
                    DataBaseHandler.DataBase.SaveChanges();
                    Sells = new BindingList<SellsHistoryEntry>(DataBaseHandler.DataBase.history.ToList());
                    SellPrice = "";
                    SellWeigth = "";

                });
            }
        }
        public ICommand bDeleteSell
        {
            get
            {
                return new RelayCommand(() =>
                {
                    if (SelectedSells != null)
                    {
                        if (MessageBox.Show((string)Application.Current.Resources["DeleteSell"], (string)Application.Current.Resources["DeleteCaption"], MessageBoxButton.YesNo, MessageBoxImage.Warning).Equals(MessageBoxResult.Yes))
                        {
                            DataBaseHandler.DataBase.history.Remove(SelectedSells);
                            DataBaseHandler.DataBase.SaveChanges();
                            Sells.Remove(SelectedSells);
                            SellsOwerviewPanelWidth = SidePanelState.Close;
                            GetStat();
                        }
                        
                    }

                });
            }
        }
        public ICommand bOpenSellAddPanel
        {
            get
            {
                return new RelayCommand(() =>
                {
                    if (SellsAddingPanelWidth == SidePanelState.Close)
                    {
                        if (SellsOwerviewPanelWidth == SidePanelState.Open)
                        {
                            SellsOwerviewPanelWidth = SidePanelState.Close;
                        }

                        Task.Run(() =>
                        {
                            for (int i = 0; i < SidePanelState.Open; i += SidePanelState.Open / 40)
                            {
                                SellsAddingPanelWidth = i;
                                Thread.Sleep(1);
                            }
                            SellsAddingPanelWidth = SidePanelState.Open;
                        });
                    }
                    else
                    {
                        Task.Run(() =>
                        {
                            for (int i = SidePanelState.Open; i >= 0; i -= SidePanelState.Open / 40)
                            {
                                SellsAddingPanelWidth = i;
                                Thread.Sleep(1);
                            }
                            SellsAddingPanelWidth = SidePanelState.Close;
                        });

                    }

                });
            }
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
        public ICommand bOpenSelectDateWindow
        {
            get
            {
                return new RelayCommand(() =>
                {
                    SelectDateWindow = new SelectDateWindow();
                    SelectDateWindow.Show();
                });
            }
        }

        public void OpenClientOverviewPanel()
        {
            if (SellsOwerviewPanelWidth == SidePanelState.Close)
            {
                if (SellsAddingPanelWidth == SidePanelState.Open)
                {
                    SellsAddingPanelWidth = SidePanelState.Close;
                }
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
            else
            {
                Task.Run(() =>
                {
                    for (int i = SidePanelState.Open; i >= 0; i -= 20)
                    {
                        SellsOwerviewPanelWidth = i;
                        Thread.Sleep(1);
                    }
                });
                CloseSellsOverviewPanelButtonVisibility = Visibility.Collapsed;

            }
        }

        public void GetStat()
        {
            AllSellsCount = _sells.Count;
            AllSellsPrice = 0;
            for (int i = 0; i < _sells.Count; i++)
            {
                AllSellsPrice += _sells[i].price;
            }
        }
        public class SidePanelState
        {
            //public static int Open = (int)((MainViewModel)App.Current.MainWindow.DataContext).financeStatementWindow.Width - 80;
            public static int Open = 800;

            public static int Close = 0;
        }
    }
}
