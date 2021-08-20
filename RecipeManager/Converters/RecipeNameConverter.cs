using RecipeManager.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace RecipeManager.Converters
{
    class RecipeNameConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            try
            {
                //for (int i = 0; i < RecipeHandler.Recipes.Count; i++)
                //{
                //    if (RecipeHandler.Recipes[i].Name.GetHashCode() == System.Convert.ToInt32(value))
                //    {
                //        return RecipeHandler.Recipes[i].Name;
                //    }
                //}
                //return value.ToString();
                if (value.GetType().Equals(new BindingList<int>().GetType()))
                {
                    //MessageBox.Show(value.GetType());
                    BindingList<int> first = (BindingList<int>)value;
                    BindingList<string> second = new BindingList<string>();
                    for (int i = 0; i < first.Count; i++)
                    {
                        second.Add(RecipeHandler.GetRecipeByNameHash(first[i]).Name);
                    }
                    return second;
                }
                else if (value.GetType().Equals(string.Empty.GetType()))
                {
                    return RecipeHandler.GetRecipeByNameHash(System.Convert.ToInt32(value)).Name;
                }
                else
                {
                    return value.ToString();
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
            return System.Convert.ToString(value).GetHashCode();
        }
    }
}
