   M S B A M L   `   `   `  ����H  DRecipeManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:RecipeManager.WindowsRecipeManager.Windows  5   	   C&clr-namespace:RecipeManager.ViewModelsRecipeManager.ViewModels  5   Q   C&clr-namespace:RecipeManager.ConvertersRecipeManager.Converters  6�   7    1RecipeManager.Windows.ClientPunchaseHistoryWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:RecipeManager.Windows     5   	   Ishell9http://schemas.microsoft.com/netfx/2009/xaml/presentation    5   	   ;
viewmodels&clr-namespace:RecipeManager.ViewModels    6Q   <conversters&clr-namespace:RecipeManager.Converters    6�      ClientHistory  � Title#  �   5	   	   $	��450��61   $	��800��6>    � 
ResizeMode$ NoResize=�6J   
���  �����	#FF8F8F8F$��1q�6�   $��Center=�6�   $��Center=�6�    � AllowsTransparency .   � WindowStyle$
 None=�6�    J� SnapsToDevicePixels .  ��5      �� 5   
    �� 
TargetType" �6   .�5      �� '  !System.Windows.Shell.WindowChrome �� Property �@ WindowChrome �� Value 5        5         CaptionHeight$ 0Q�6)   	   CornerRadius$	 0��5   )   
   GlassFrameThickness$
 0,0,0,0q�5   )      NonClientFrameEdges$
 None=�5   )      ResizeBorderThickness$ 5q�5   )      UseAeroCaptionButtons .  5   )   5      5       � DataContext 5      <  6RecipeManager.ViewModels.ClientPunchaseHistoryWindowVM  5    
   65   .��5#      �   Color_MainWindow#���  6    � 	Resources 5$   
   2  ,RecipeManager.Converters.RecipeNameConverter  RecipeNameConverter.  (RecipeManager.Converters.ClientConverter  ClientsNameConverter-  'RecipeManager.Converters.PriceConverter  PriceConverter��%W   &	       &	      &	 &       5%      6.     5&      6*     5'      6)   5(       � RowDefinitions 5)   
   �� 5*      $��30 �6   �� 5+      $��30 �6   �� 5,      $��* �6   .+�5.   
   � $��0��6   $��30��6   $	��Top=�6(   #���  6@   .+�5/      ��  # Color_ProgramNameLaberForecolor#���  6;   $��37,0,0,4q�6{   $
��Left=�6�   $��Center=�6�   $��12(�6�   ��6   �� *CurrentClient.name+6�   �� 51      $��50��6   $��30��6G   $��0,0,0,0q�6S   $��Right=�6d   $	��Top=�6�     
ExitButton#���  6�   ��6    �� *CloseWindowCommand+6�   �� 52      $��50��6   $��30��6J   $��0,0,50,0q�6V   $��Right=�6h   $	��Top=�6�     MaximizeButton#���  6�   ��6    �� *MaximizeWindowCommand+6�   �� 53      $��50��6   $��30��6J   $��	0,0,100,0q�6V   $��Right=�6i   $	��Top=�6�     MinimizeButton#���  6�   ��6    �� *MinimizeWindowCommand+6�   �� 54      $y�Hidden=�6   $��30��6)   $��30��64   $��	0,0,155,0q�6@   $��Right=�6S   $	��Top=�6o    	 SettingButton#��� 	 6�   56      � 57   
   $��1��6    � ColumnDefinitions 58      �� 59      $��* �6#   �� 5:      $��60 �6#   .+�5=      �� $��0��6    �� Orientation$ 
Horizontal=�6)   .+�5>      �� $��Center=�6    
 CHCount#��� 
 63   $��14(�6W     Color_DayDateForeground#���  6e   �� 5?      $��Center=�6   $��14(�6U   
���������63   �� *PunchaseCount+6c   �� 5@      $��Center=�6     
CHAllPrice#���  63   $��14(�6Z   $��20,0,0,0q�6h   #���  6z   �� 5A      $��Center=�6   $��14(�6z   
���������63   �� *
AllPrice+ �� 	Converter# [ 6�   5B      �� 5D      $ 
Horizontal=�6   $��Right=�62   $��1��6N   .+�5E      �� $��30��6   $��30��6$   $��0,0,10,0q�60    " CloseClientOvewviewPanelButton#���  6B   ��6~   �� *bOpenSellOverviewPanel+y�6�   �� *)'CloseSellsOverviewPanelButtonVisibility+5F      5G      � 5I   
   $��2��6    5J      �� 5K      $��* �6#   �� 5L      ��6#   �� *SellsOwerviewPanelWidth+.+�5R      �� $��0��6     Color_DaysColumnsBackground#���  6M   $��Stretch=�6�   $��Stretch=�6�   $��Stretch=�6�     SellsListBox#���  6  $��0,0,0,0q�6:  $��Disabled=�6T   �� SelectedItem 6&   �� *SelectedSells+��6�   �� *Sells+5T      � 5X      $��1��6     Color_DarkBlue1#���  6#    5Z      �� 5[      $��* �6'   �� 5\      $��* �6'   .+�5_      �� $��0��6   $ Vertical=�6-   .+�5`      ��  
 FSSell#���  6   $��Center=�6?   $��14(�6\   $��Center=�6j   
�������6�   �� 5b      $��0��6!   $ 
Horizontal=�61   .+�5c      �� $��Center=�6      SellDate#���  6;   $��14(�6`   #���  6n   �� 5d      $��Center=�6    $��14(�6b   
���������6;   �� *SelectedSells.date+6p   5e      �� 5g      $��1��6!   $ 
Horizontal=�61   .+�5h      �� $��Center=�6      	SellBuyer#���  6;   $��14(�6a   #���  6o   �� 5i      $��Center=�6    $��14(�6�   
���������6;   �� *SelectedSells.buyer+# [ 6�   5j      �� 5l      $��2��6!   $ 
Horizontal=�61   .+�5m      �� $��Center=�6      
SellRecipe#���  6;   $��14(�6b   #���  6p   �� 5n      $��Center=�6    $��14(�6�   
���������6;   �� *SelectedSells.recipe+# [ 6�   5o      �� 5q      $��3��6!   $ 
Horizontal=�61   .+�5r      �� $��Center=�6      
SellWeigth#���  6;   $��14(�6b   #���  6p   �� 5s      $��Center=�6    $��14(�6d   
���������6;   �� *SelectedSells.weigth+6r   5t      �� 5v      $��4��6!   $ 
Horizontal=�61   .+�5w      �� $��Center=�6      	SellPrice#���  6;   $��14(�6a   #���  6o   �� 5x      $��Center=�6    $��14(�6�   
���������6;   �� *SelectedSells.price+# [ 6�   5y      5z      �� 5}      $��1��6   $ Vertical=�6-   .+�5~      �� #���  6   $��Center=�6B   $��14(�6_   $��Center=�6m   
�������6�   �� 5      $��0��6!   $ 
Horizontal=�61   .+�5�      ��   
ClientName#���  6    $��Center=�6G   $��14(�6d   $��Center=�6r   
�������6�   �� 5�      $��Center=�6L   $��14(�6i   $��Center=�6w   
���������6    �� *SelectedSellClient.name+6�   5�      �� 5�      $��1��6!   $ 
Horizontal=�61   .+�5�      ��   ClientPhone#���  6    $��Center=�6H   $��0,0,0,0q�6e   $��14(�6v   $��Center=�6�   
�������6�   �� 5�      $��Center=�6M   $��0,0,0,0q�6j   $��14(�6{   $��Center=�6�   
���������6    �� *SelectedSellClient.phone+6�   5�      �� 5�      $��2��6!   $ 
Horizontal=�61   .+�5�      ��   ClientContactInformation#���  6    $��Center=�6U   $��14(�6r   $��Center=�6�   
�������6�   �� 5�      $��Center=�6[   $��14(�6x   $��Center=�6�   
���������6    �� *(&SelectedSellClient.contact_information+6�   5�      �� 5�      $��3��6!   $ 
Horizontal=�61   .+�5�      ��   ClientComments#���  6    $��Center=�6K   $��14(�6h   $��Center=�6v   
�������6�   �� 5�      $��Center=�6P   $��14(�6m   $��Center=�6{   
���������6    �� *SelectedSellClient.comments+6�   5�      5�      5�      5�      5�      5�      