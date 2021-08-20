using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using RecipeManager.Controllers;
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



        //Add Sell Panel
        public string SellDate { get; set; } = (string)Application.Current.Resources["SelectDate"];
        public BindingList<int> RecipesHashes { get; set; } = new BindingList<int>(RecipeHandler.GetRecipesHash());
        public int SelectedRecipeHash { get; set; }
        public BindingList<Client> Clients { get; set; } = new BindingList<Client>(DataBaseHandler.DataBase.clients.ToList());
        public Client SelectedClient { get; set; }
        public string SellWeigth { get; set; } = "";
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

                });
            }
        }
        public ICommand bDeleteSell
        {
            get
            {
                return new RelayCommand(() =>
                {
                    //if (SelectedClient != null)
                    //{
                    //    //DataBaseHandler.DataBase.clients.Remove(SelectedClient);
                    //    //DataBaseHandler.DataBase.SaveChanges();
                    //    //Clients.Remove(SelectedClient);
                    //}

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
                            for (int i = 0; i < SidePanelState.Open; i+=20)
                            {
                                SellsAddingPanelWidth = i;
                                Thread.Sleep(1);
                            }
                        });
                    }
                    else
                    {
                        Task.Run(() =>
                        {
                            for (int i = SidePanelState.Open; i >= 0; i -= 20)
                            {
                                SellsAddingPanelWidth = i;
                                Thread.Sleep(1);
                            }
                        });
                        SellsAddingPanelWidth = SidePanelState.Close;
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

        private class SidePanelState
        {
            //public static int Open = (int)((MainViewModel)App.Current.MainWindow.DataContext).financeStatementWindow.Width - 80;
            public static int Open = 800;

            public static int Close = 0;
        }
    }
}
