using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using RecipeManager.Controllers;
using RecipeManager.Models.DataBaseModels;
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
    class ClientsPageVM : ViewModelBase
    {

        public int ClientAddingPanelWidth { get; set; } = SidePanelState.Close;
        public int ClientOwerviewPanelWidth { get; set; } = SidePanelState.Close;

        public Visibility CloseClientOverviewPanelButtonVisibility { get; set; } = Visibility.Collapsed;

        private Client _selectedClient;
        public Client SelectedClient
        {
            get
            {
                return _selectedClient;
            }
            set
            {
                _selectedClient = value;
                if (value != null)
                {
                    OpenClientOverviewPanel();
                }
            }
        }
        public BindingList<Client> Clients { get; set; }

        public string ClientName { get; set; } = "";
        public string ClientPhone { get; set; } = "";
        public string ClientContactIndormation { get; set; } = "";
        public string ClientComments { get; set; } = "";


        public ClientsPageVM()
        {
            Clients = new BindingList<Client>(DataBaseHandler.DataBase.clients.ToList());
        }




        public ICommand bAddClient
        {
            get
            {
                return new RelayCommand(() =>
                {
                    //DataBaseHandler.DataBase.clients.Add(new Client()
                    //{
                    //    name = ClientName,
                    //    comments = ClientComments,
                    //    contact_information = ClientContactIndormation,
                    //    phone = ClientPhone
                    //});
                    //DataBaseHandler.DataBase.SaveChanges();
                    //Clients = new BindingList<Client>(DataBaseHandler.DataBase.clients.ToList());

                });
            }
        }

        public ICommand bDeleteClient
        {
            get
            {
                return new RelayCommand(() =>
                {
                    if (SelectedClient != null)
                    {
                        //DataBaseHandler.DataBase.clients.Remove(SelectedClient);
                        //DataBaseHandler.DataBase.SaveChanges();
                        //Clients.Remove(SelectedClient);
                    }

                });
            }
        }



        public ICommand bOpenClientAddPanel
        {
            get
            {
                return new RelayCommand(() =>
                {
                    if (ClientAddingPanelWidth == SidePanelState.Close)
                    {
                        if (ClientOwerviewPanelWidth == SidePanelState.Open)
                        {
                            ClientOwerviewPanelWidth = SidePanelState.Close;
                        }
                        ClientAddingPanelWidth = SidePanelState.Open;
                    }
                    else
                    {
                        ClientAddingPanelWidth = SidePanelState.Close;
                    }

                });
            }
        }

        public ICommand bOpenClientOverviewPanel
        {
            get
            {
                return new RelayCommand(() =>
                {
                    ClientOwerviewPanelWidth = SidePanelState.Close;
                    CloseClientOverviewPanelButtonVisibility = Visibility.Collapsed;
                    SelectedClient = null;
                });
            }
        }

        public void OpenClientOverviewPanel()
        {
            if (ClientOwerviewPanelWidth == SidePanelState.Close)
            {
                if (ClientAddingPanelWidth == SidePanelState.Open)
                {
                    ClientAddingPanelWidth = SidePanelState.Close;
                }
                ClientOwerviewPanelWidth = SidePanelState.Open;
                CloseClientOverviewPanelButtonVisibility = Visibility.Visible;

            }
            else
            {
                ClientOwerviewPanelWidth = SidePanelState.Close;
            }
        }

        private class SidePanelState
        {
            public static int Open = 300;
            public static int Close = 0;
        }
    }
}
