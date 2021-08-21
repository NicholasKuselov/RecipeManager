using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace RecipeManager.Converters
{
    class PriceConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            try
            {
                if (System.Convert.ToDouble(value) == 0) return "NN";
                return System.Convert.ToDouble(value) / 100;
            }
            catch (Exception)
            {
                return "error";
            }

        }


        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                if (System.Convert.ToDouble(value) == 0) return "";
                return (int)(System.Convert.ToDouble(value) * 100);
            }
            catch
            {
                return "";
            }
        }
    }
}
