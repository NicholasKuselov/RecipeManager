   M S B A M L   `   `   `  ����H  DRecipeManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:RecipeManager.Pages.FinanceStatements%RecipeManager.Pages.FinanceStatements  5      C&clr-namespace:RecipeManager.ViewModelsRecipeManager.ViewModels  6I   C&clr-namespace:RecipeManager.ConvertersRecipeManager.Converters  6�   5    /RecipeManager.Pages.FinanceStatements.SellsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Elocal3clr-namespace:RecipeManager.Pages.FinanceStatements     5      =
viewmodels&clr-namespace:RecipeManager.ViewModels     6I   >conversters&clr-namespace:RecipeManager.Converters     6�     N� Title$  	SellsPage��5   0    � DataContext 5
      *  $RecipeManager.ViewModels.SellsPageVM  5   
   6#    � 	Resources 5      2  ,RecipeManager.Converters.RecipeNameConverter   RecipeNameConverter.  (RecipeManager.Converters.ClientConverter  ClientConverter-  'RecipeManager.Converters.PriceConverter  PriceConverter��%W   &	        &	      &	 &       5   
   6*     5   
   6&     5   
   6%   5      .��5      �   Color_MainWindow#���  6    5   
     ClientsNameConverter��%:   &	        &	        5      6.     5      6*   5       � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��* �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5       $	��120 �6#   .+�5#      ��  �� Orientation$ 
Horizontal=�6   $��Right=�62   $��1��6N   .+�5$      �� $��25��6   $��25��6$   $��0,0,10,0q�60     DeleteButton#���  6B   ��6l   �� *bDeleteSell+y�6�   �� *DeleteSellButtonVisibility+�� 5%      $��30��6   $��30��6$   $��0,0,10,0q�60    " CloseClientOvewviewPanelButton#���  6B   ��6~   �� *bOpenSellOverviewPanel+y�6�   �� *)'CloseSellsOverviewPanelButtonVisibility+�� 5&      $��30��6   $��30��6$   $��0,0,0,0q�60     	AddButton#���  6g   ��6A   �� *bOpenSellAddPanel+6g   5'      �� 5(      $��0��6   $ 
Horizontal=�6)   .+�5)      �� $��Center=�6     CHCount#���  63   $��14(�6W    	 Color_DayDateForeground#��� 	 6e   �� 5*      $��Center=�6   $��14(�6U   
���������63   �� *AllSellsCount+6c   �� 5+      $��Center=�6    
 
CHAllPrice#��� 
 63   $��14(�6Z   $��20,0,0,0q�6h   #��� 	 6z   �� 5,      $��Center=�6   $��14(�6   
���������63   �� *AllSellsPrice+ �� 	Converter# [ 6�   5-      5.      � 50   
   $��1��6    51      �� 52      $��* �6#   �� 53      ��6#   �� *SellsAddingPanelWidth+�� 54      ��6#   �� *SellsOwerviewPanelWidth+.+�5:      �� $��0��6     Color_DaysColumnsBackground#���  6M   $��Stretch=�6�   $��Stretch=�6�   $��Stretch=�6�     SellsListBox#���  6  $��0,0,0,0q�6:  $��Disabled=�6T   �� SelectedItem 6&   �� *SelectedSells+��6�   �� *Sells+5<      �� 5>      $��1��6   
�������$��0q�6:   ._�5?      �   Color_DarkBlue1#���  6    5@      �� 5A      $��30 �6(   �� 5B      $��* �6(   �� 5C      $��50 �6(   .+�5F      �� $��0��6     
SellAdding#���  6)   $��Center=�6P   $��16(�6m   
�������6{   � 5I      $��1��6    5J      �� 5K      $��* �6/   �� 5L      $��* �6/   .+�5O      �� $ Vertical=�6%   $��0��6<   .+�5P      ��   SellDate#���  6$   $��Center=�6I   $��14(�6f   $��Center=�6t   
�������6�   �� 5Q      $	��200��6%   $��30��61     OpenDateSelectWindowButton#���  6=   ��6u   �� *bOpenSelectDateWindow+�� 5R        
SellRecipe#���  6$   $��Center=�6K   $��0,0,0,0q�6h   $��14(�6y   $��Center=�6�   
�������6�   �� 5S      $��	10,0,10,0q�6�    �� SelectedIndex$ 0��6�     comboBoxStyle#���  6�   $��Center=�6'  $	��200��6K  $��Center=�6W  $��Center=�6z  
������ $��30��6�  ��6(   �� *RecipesHashes+# [   6~   �� *SelectedRecipeHash+# [  6�  �� 5T        	SellBuyer#���  6$   $��Center=�6J   $��0,0,0,0q�6g   $��14(�6x   $��Center=�6�   
�������6�   �� 5U      $��	10,0,10,0q�6�   $ 0��6�   #���  6�   $��Center=�6   $	��200��6D  $��Center=�6P  $��Center=�6s  
������ $��30��6�  ��6(   �� *	Clients+# [  6y   �� *SelectedClient+# [ 6�  5V      �� 5X      $ Vertical=�6%   $��1��6<   .+�5Z      ��   	SellPrice#���  6$   $��Center=�6J   $��0,0,0,0q�6g   $��14(�6x   $��Center=�6�   
�������6�   �� 5[      -   5          NameTextBox#���  5[   &   $��Center=�6L   $	��200��6�   ��6i   �� *	SellPrice+# [ 6�   �� 5\        
SellWeigth#���  6$   $��Center=�6K   $��0,0,0,0q�6h   $��14(�6y   $��Center=�6�   
�������6�   �� 5]      -   5        #���  5]   &   $��Center=�6L   $	��200��6�   ��6i   �� *
SellWeigth+6�   �� 5^        	CostPrice#���  6$   $��Center=�6J   $��0,0,0,0q�6g   $��14(�6x   $��Center=�6�   
�������6�   �� 5_      $��Center=�6B   $��0,0,0,0q�6_   $��14(�6p   $��Center=�6~   
���������6$   �� *	CostPrice+6�   5a      5b      � 5e      $��2��6    5f      �� 5g      $��* �6/   �� 5h      $��* �6/   .+�5k      �� $��0��6!     AddClientButton#���  6N   $��16(�6{   $	��220��6�   $��30��6�   $��0,0,0,0q�6�   ��61   �� *
bAddSell+6�   5n      5o      5p      � 5r      $��2��6   #���  6#    5t      �� 5u      $��* �6'   �� 5v      $��* �6'   .+�5y      �� $��0��6   $ Vertical=�6-   .+�5z      ��  
 FSSell#���  6   $��Center=�6?   $��14(�6\   $��Center=�6j   
�������6�   �� 5|      $��0��6!   $ 
Horizontal=�61   .+�5}      �� $��Center=�6    #���  6;   $��14(�6`   #��� 	 6n   �� 5~      $��Center=�6    $��14(�6b   
���������6;   �� *SelectedSells.date+6p   5      �� 5�      $��1��6!   $ 
Horizontal=�61   .+�5�      �� $��Center=�6    #���  6;   $��14(�6a   #��� 	 6o   �� 5�      $��Center=�6    $��14(�6�   
���������6;   �� *SelectedSells.buyer+# [ 6�   5�      �� 5�      $��2��6!   $ 
Horizontal=�61   .+�5�      �� $��Center=�6    #���  6;   $��14(�6b   #��� 	 6p   �� 5�      $��Center=�6    $��14(�6�   
���������6;   �� *SelectedSells.recipe+# [  6�   5�      �� 5�      $��3��6!   $ 
Horizontal=�61   .+�5�      �� $��Center=�6    #���  6;   $��14(�6b   #��� 	 6p   �� 5�      $��Center=�6    $��14(�6d   
���������6;   �� *SelectedSells.weigth+6r   5�      �� 5�      $��4��6!   $ 
Horizontal=�61   .+�5�      �� $��Center=�6    #���  6;   $��14(�6a   #��� 	 6o   �� 5�      $��Center=�6    $��14(�6�   
���������6;   �� *SelectedSells.price+# [ 6�   5�      5�      �� 5�      $��1��6   $ Vertical=�6-   .+�5�      �� #���  6   $��Center=�6B   $��14(�6_   $��Center=�6m   
�������6�   �� 5�      $��0��6!   $ 
Horizontal=�61   .+�5�      ��   
ClientName#���  6    $��Center=�6G   $��14(�6d   $��Center=�6r   
�������6�   �� 5�      $��Center=�6L   $��14(�6i   $��Center=�6w   
���������6    �� *SelectedSellClient.name+6�   5�      �� 5�      $��1��6!   $ 
Horizontal=�61   .+�5�      ��   ClientPhone#���  6    $��Center=�6H   $��0,0,0,0q�6e   $��14(�6v   $��Center=�6�   
�������6�   �� 5�      $��Center=�6M   $��0,0,0,0q�6j   $��14(�6{   $��Center=�6�   
���������6    �� *SelectedSellClient.phone+6�   5�      �� 5�      $��2��6!   $ 
Horizontal=�61   .+�5�      ��   ClientContactInformation#���  6    $��Center=�6U   $��14(�6r   $��Center=�6�   
�������6�   �� 5�      $��Center=�6[   $��14(�6x   $��Center=�6�   
���������6    �� *(&SelectedSellClient.contact_information+6�   5�      �� 5�      $��3��6!   $ 
Horizontal=�61   .+�5�      ��   ClientComments#���  6    $��Center=�6K   $��14(�6h   $��Center=�6v   
�������6�   �� 5�      $��Center=�6P   $��14(�6m   $��Center=�6{   
���������6    �� *SelectedSellClient.comments+6�   5�      5�      5�      5�      5�      5�      