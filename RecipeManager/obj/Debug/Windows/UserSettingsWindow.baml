   M S B A M L   `   `   `  ����H  DRecipeManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:RecipeManager.WindowsRecipeManager.Windows  5   	   C&clr-namespace:RecipeManager.ViewModelsRecipeManager.ViewModels  6;   .    (RecipeManager.Windows.UserSettingsWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:RecipeManager.Windows     5   	   =
viewmodels&clr-namespace:RecipeManager.ViewModels     6;     � Title$5  /Налаштування користувача��5   	   $	��400��6*   $	��500��67    � 	Resources 5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $= 7/Resources/Templates/MainWindow/NavButtonAnimation.xaml?�6%   �� 5      $' !/Resources/Colors/MainColors.xaml?�6%   �� 5      $ /Resources/Icons.xaml?�6%   �� 5      $? 9/Resources/Templates/MainWindow/WindowControlButtons.xaml?�6%   �� 5      $8 2/Resources/Templates/MainWindow/SettingButton.xaml?�6%   �� 5      $: 4/Resources/Templates/MainWindow/WeekListButtons.xaml?�6%   �� 5      $? 9/Resources/Templates/UserSettingsWindow/ButtonStyles.xaml?�6%   �� 5      $> 8/Resources/Templates/UserSettingsWindow/LabelStyles.xaml?�6%   �� 5      $@ :/Resources/Templates/UserSettingsWindow/TextBoxStyles.xaml?�6%   %    5       � DataContext 5      3  -RecipeManager.ViewModels.UserSettingsWindowVM  5   
   6,   .��5       �    Color_MainWindow#���   6    � RowDefinitions 5!   
   �� 5"      $��* �6   �� 5#      $��* �6   �� 5$      $��* �6   �� 5%      $��* �6   �� 5&      $��* �6   �� 5'      $��* �6   �� 5(      $��* �6    � ColumnDefinitions 5*   
   �� 5+      $��* �6   �� 5,      $��* �6   .+�5/   
   �� $��0��6   $��0��6   
�������$��16(�6]   $��Center=�6k   $��Center=�6�   ��6-   �� *
userName+6�   �� 50   
   -   5        $��0��50      $��1��6     
ExitButton#���  6.   $	��250��6V   $��40��6b   6n   �� 51   
   $��1��6   $��0��6     PassTextBoxStyle#���  6M   $	��200��6x   ��60   �� *newPassword+6x   �� 52   
   $��1��6   $��1��6     PassSecondTextBoxStyle#���  6R   $	��200��6�   ��6/   �� *newPasswordSecond+6�   �� 53   
   $��2��6   $��0��6   $��2��6.     ChangePasswordButton#���  6f   $	��250��6�   $��40��6�   ��6B   �� *SaveNewPassword+6�   �� 54   
   $��3��6   $��0��6   $��2��6-     bAddNewUser#���  6A   
�������$��16(�6|   $��Center=�6�   $��Center=�6�   �� 55   
   $��4��6   $��0��6     LoginTextBoxStyle#���  6N   $	��200��6z   ��60   �� *newUserLogin+6z   �� 56   
   $��4��6   $��1��6     NameTextBoxStyle#���  6L   $	��200��6w   ��6/   �� *newUserName+6w   �� 57   
   $��5��6   $��0��6   #���  6Q   $	��200��6|   ��60   �� *newUserPassword+6|   �� 58   
   $��5��6   $��1��6   #���  6V   $	��200��6�   ��6/   �� *newUserPasswordSecond+6�   �� 59   
   $��6��6   $��0��6   $��2��6.     AddNewUserButton#���  6B   $	��250��6p   $��40��6|   ��6�   �� *
AddNewUser+5:      5;      