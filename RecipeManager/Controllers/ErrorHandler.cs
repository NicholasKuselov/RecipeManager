using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RecipeManager.Controllers
{
    class ErrorHandler
    {
        public static void AuthFailed()
        {
            MessageBox.Show((string)Application.Current.Resources["AuthFailText"], (string)Application.Current.Resources["AuthFailcaption"], MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public static void NewPasswordsNotEquals()
        {
            MessageBox.Show((string)Application.Current.Resources["NewPasswordsNotEqualsText"], (string)Application.Current.Resources["NewPasswordscaption"], MessageBoxButton.OK, MessageBoxImage.Error);
        }
        public static void NewPasswordsFieldsIsClear()
        {
            MessageBox.Show((string)Application.Current.Resources["NewPasswordsFieldsIsClearText"], (string)Application.Current.Resources["NewPasswordscaption"], MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public static void NewUserFieldsIsClear()
        {
            MessageBox.Show((string)Application.Current.Resources["NewUserFieldsClearText"], (string)Application.Current.Resources["NewUsercaption"], MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public static void NewUserLoginAlreadyRegister()
        {
            MessageBox.Show((string)Application.Current.Resources["NewUserLoginAlreadyRegisterText"], (string)Application.Current.Resources["NewUsercaption"], MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public static void NoRecipeName()
        {
            MessageBox.Show((string)Application.Current.Resources["ErrorNoRecipeName"], (string)Application.Current.Resources["ErrorCaption"], MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public static void NoIngredientName()
        {
            MessageBox.Show((string)Application.Current.Resources["ErrorNoIngredientName"], (string)Application.Current.Resources["ErrorCaption"], MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public static void NoRecipeWeigth()
        {
            MessageBox.Show((string)Application.Current.Resources["ErrorNoRecipeWeigth"], (string)Application.Current.Resources["ErrorCaption"], MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public static void NoIngredientWeigth()
        {
            MessageBox.Show((string)Application.Current.Resources["ErrorNoIngredientWeigth"], (string)Application.Current.Resources["ErrorCaption"], MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public static void NoIClientName()
        {
            MessageBox.Show((string)Application.Current.Resources["ErrorNoClientName"], (string)Application.Current.Resources["ErrorCaption"], MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public static void NoIClientContactInformation()
        {
            MessageBox.Show((string)Application.Current.Resources["ErrorNoClientContact"], (string)Application.Current.Resources["ErrorCaption"], MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public static void RecipeNameAlreadyExist()
        {
            MessageBox.Show((string)Application.Current.Resources["ErrorRecipeNameAlreadyExist"], (string)Application.Current.Resources["ErrorCaption"], MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}

