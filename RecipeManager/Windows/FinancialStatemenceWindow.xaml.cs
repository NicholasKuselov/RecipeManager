using RecipeManager.Controllers;
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
    /// Логика взаимодействия для FinancialStatemenceWindow.xaml
    /// </summary>
    public partial class FinancialStatemenceWindow : Window
    {
        public FinancialStatemenceWindow()
        {
            InitializeComponent();
            this.MouseLeftButtonDown += delegate { this.DragMove(); };
            this.SourceInitialized += new EventHandler(Window1_SourceInitialized);
        }

        void Window1_SourceInitialized(object sender, EventArgs e)
        {
            WindowSizing.WindowInitialized(this);
        }
    }
}
