using RecipeManager.Models;
using RecipeManager.ViewModels;
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
using System.Windows.Shapes;

namespace RecipeManager.Windows
{
    /// <summary>
    /// Логика взаимодействия для RecipeOverviewWIndow.xaml
    /// </summary>
    public partial class RecipeOverviewWIndow : Window
    {
        public RecipeOverviewWIndow(Recipe recipe)
        {
            InitializeComponent();
            this.DataContext = new RecipeOverviewWIndowVM(recipe);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            string text = ((TextBox)sender).Text;
            for (int i = text.Length - 1; i >= 0; i--)
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
