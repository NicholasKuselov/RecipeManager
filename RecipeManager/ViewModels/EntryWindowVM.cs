using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using RecipeManager.Controllers;
using RecipeManager.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace RecipeManager.ViewModels
{
    class EntryWindowVM : ViewModelBase
    {
        EntryWindow entryWindow;
        MainWindow parent;

        public string login { get; set; }

        public string password { get; set; } = "";

        public EntryWindowVM() { }

        public EntryWindowVM(EntryWindow entryWindow,MainWindow mainWindow)
        {
            parent = mainWindow;
            this.entryWindow = entryWindow;
        }

        public ICommand bAuth
        {
            get
            {
                return new RelayCommand(() =>
                {
                    //Auth();
                });
            }
        }

        public ICommand CloseWindowCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
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


        //private void Auth()
        //{
        //    string passHex = sha256(password);

        //    if(DataBase.Auth(login,passHex))
        //    {
        //       // Setting.currentUserName = login;
        //        OpenMainWindow();
        //    }
        //    else
        //    {
        //        ErrorHandler.AuthFailed();
        //    }
            
        //}

        //public void OpenMainWindow()
        //{
        //    parent.AuthSuccess();
        //    this.entryWindow.Close();
        //}

        static string sha256(string randomString)
        {
            var crypt = new System.Security.Cryptography.SHA256Managed();
            var hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(randomString));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }


    }
}
