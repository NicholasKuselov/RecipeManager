using RecipeManager.Controllers;
using RecipeManager.Models.DataBaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace RecipeManager.Converters
{
    class ClientConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            try
            {
                if (value.GetType().Equals(new BindingList<Client>().GetType()))
                {
                    //MessageBox.Show(value.GetType());
                    BindingList<Client> first = (BindingList<Client>)value;
                    BindingList<string> second = new BindingList<string>();
                    for (int i = 0; i < first.Count; i++)
                    {
                        second.Add(first[i].name + " id :" +first[i].idclient.ToString());
                    }
                    return second;
                }
                else if (value.GetType().Equals(new Client().GetType()))
                {
                    return ((Client)value).name;
                }
                else
                {
                    return DataBaseHandler.GetClientById((int)value).name;
                }

            }
            catch (Exception)
            {
                //if (value.GetType().Equals(TypeCode.String))
                //{
                //    return System.Convert.ToInt32(value);
                //}
                return "";
            }

        }


        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int id = System.Convert.ToInt32(System.Convert.ToString(value).Split(':')[1]);
            return DataBaseHandler.GetClientById(id);
        }
    }
}
