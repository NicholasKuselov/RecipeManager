using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RecipeManager.Pages
{
    /// <summary>
    /// Логика взаимодействия для RecipeCreatePage.xaml
    /// </summary>
    public partial class RecipeCreatePage : Page
    {
        public RecipeCreatePage()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            string text = ((TextBox)sender).Text;
            for (int i = text.Length - 1; i >=0; i--)
            {
                if (!Char.IsDigit(text[i]))
                {
                    text = text.Remove(i, 1);
                }
            }

            ((TextBox)sender).Text = text;
            ((TextBox)sender).CaretIndex = ((TextBox)sender).Text.Length;
        }
    }
}
