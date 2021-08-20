using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RecipeManager.ViewModels
{
    class SelectDateWindowVM : ViewModelBase
    {
        public DateTime SelectedDate { get; set; }

       // public BindingList<week> weeks { get; set; }

        public SelectDateWindowVM()
        {
            SelectedDate = DateTime.Now;
            //DataBase.timetableDB.week.Load();
            //weeks = DataBase.timetableDB.week.Local.ToBindingList();
        }

        public ICommand bSelectDate
        {
            get
            {
                return new RelayCommand(() =>
                {
                    if (SelectedDate != null)
                    {
                        ((SellsPageVM)((FinancialStatementsWindowVM)(((MainViewModel)App.Current.MainWindow.DataContext).financeStatementWindow.DataContext)).sellsPage.DataContext).SellDate = SelectedDate.ToShortDateString();
                        ((SellsPageVM)((FinancialStatementsWindowVM)(((MainViewModel)App.Current.MainWindow.DataContext).financeStatementWindow.DataContext)).sellsPage.DataContext).SelectDateWindow.Close();
                    }
                });
            }
        }

    }
}
