   M S B A M L   `   `   `  ����H  DRecipeManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:RecipeManagerRecipeManager  5   	   C&clr-namespace:RecipeManager.ViewModelsRecipeManager.ViewModels  5   	       RecipeManager.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:RecipeManager     5   	   =
viewmodels&clr-namespace:RecipeManager.ViewModels     5   	   Ishell9http://schemas.microsoft.com/netfx/2009/xaml/presentation    5   	      ProgramNameLocal  � Title#  �   5
   	   $	��450��64   $	��800��6A    � 
ResizeMode$ CanResizeWithGrip=�6M   
���  �����	#FF8F8F8F$��1q�6�   $��Center=�6�   $��Center=�6�    � AllowsTransparency .   � WindowStyle$
 None=�6
   J� SnapsToDevicePixels .  ��5      �� 5   
    �� 
TargetType" �6   .�5      �� '  !System.Windows.Shell.WindowChrome �� Property �@ WindowChrome �� Value 5        5         CaptionHeight$ 0Q�6)   	   CornerRadius$	 0��5   )   
   GlassFrameThickness$
 0,0,0,0q�5   )      NonClientFrameEdges$
 None=�5   )      ResizeBorderThickness$ 5q�5   )      UseAeroCaptionButtons .  5   )   5      5       � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5!      �� 5"      $= 7/Resources/Templates/MainWindow/NavButtonAnimation.xaml?�6%   �� 5#      $' !/Resources/Colors/MainColors.xaml?�6%   �� 5$      $ /Resources/Icons.xaml?�6%   �� 5%      $? 9/Resources/Templates/MainWindow/WindowControlButtons.xaml?�6%   �� 5&      $8 2/Resources/Templates/MainWindow/SettingButton.xaml?�6%   �� 5'      $: 4/Resources/Templates/MainWindow/WeekListButtons.xaml?�6%   %    5)       � DataContext 5-      ,   &RecipeManager.ViewModels.MainViewModel  5.   
   6%   .��51      � 
�������.+�52   
   ]� ��. $��0,0,0,0q�6)   .+�53      � $	��Top=�6   $��30��6(   $	��Top=�64     Color_MainWindow#���  6L   .+�54      �� $��30��6   $��30��6#   $
��Left=�6/   $��logo.ico��6J   �� 55        ProgramName#���  6    # Color_ProgramNameLaberForecolor#���  6@   $��37,0,0,4q�6�   $
��Left=�6�   $��Center=�6�   $��12(�6�   �� 56      -   5        $��pb_Logo��56   s   $
��Left=�6   $��30��63   $��30��6?   $��2,0,0,0q�6J   $	��Top=�6[   $��logo.ico��6�   �� 57        ProgramVersion#���  6   
�������$��0q�6W   $��	135,0,0,4q�6c   $
��Left=�6w   $��Center=�6�   $��12(�6�   �� 59      $	��150��6   $��30��6%     OpenFinanceWindowButton#���  6`   $��Right=�6�   $��	0,0,155,0q�6�   ��61   �� *OpenFinanceStatementWindow+6�   �� 5:      $��50��6   $��30��6K   $��0,0,0,0q�6W   $��Right=�6h   $	��Top=�6�     
ExitButton#���  6�   ��6$   �� *CloseWindowCommand+6�   �� 5;      $��50��6   $��30��6N   $��0,0,50,0q�6Z   $��Right=�6l   $	��Top=�6�     MaximizeButton#���  6�   ��6$   �� *MaximizeWindowCommand+6�   �� 5<      $��50��6   $��30��6N   $��	0,0,100,0q�6Z   $��Right=�6m   $	��Top=�6�     MinimizeButton#���  6�   ��6$   �� *MinimizeWindowCommand+6�   �� 5=      $y�Hidden=�6   $��30��6-   $��30��68   $��	0,0,155,0q�6D   $��Right=�6W   $	��Top=�6s    	 SettingButton#��� 	 6�   5?      �� 5@      $	��Top=�6   $��40��6.   $	��Top=�6:   #���  6R    �� Orientation$ 
Horizontal=�6�   .+�5A      	� -   5        $��b_Timetable��5A   �    
 MainNavigationButtonAnim#��� 
 6?     WithoutBackgroundAnim#���  6r   $��10,0,0,0q�6�   $
��Left=�6�    	 bCalc#���  6�   $��20(�6	    Color_MainNavButtons#���  6   	� 	GroupName$ NavButtonGoup��6K   d� 	IsChecked$
 TrueY�6e  ��6   �� *GoToCalcPage+6e  	� 5B      -   5        $��
b_Subjects��5B     #��� 
 6G   #���  6{   $��25,0,0,0q�6�   $
��Left=�6�     bRecipeCreate#���  6�   $��20(�6  #���  6'  $ NavButtonGoup��6[  ��6   �� *GoToRecipeCreatePage+6[  	� 5C      -   5        $��	b_Recipes��5C   �   #��� 
 6B   #���  6v   $��25,0,0,0q�6�   $
��Left=�6�     bRecipes#���  6�   $��20(�6  #���  6  $ NavButtonGoup��6P  ��6   �� *GoToRecipesPage+6P  	� 5D      -   5        $��b_Ingredients��5D     #��� 
 6F   #���  6z   $��25,0,0,0q�6�   $
��Left=�6�     Ingradients#���  6�   $��20(�6  #���  6'  $ NavButtonGoup��6[  ��6   �� *GoToIngredientsPage+6[  5J      �� 5K      	 �� X1$ 0��6   	 �� Y1$ 0��6   	 �� Y2$ 0��6!    ! Color_MainNavButtonsUnderline#���  6(   $	��Top=�6a   $��3��6v   	 �� X2$	 860��6�    �� Stretch$ UniformToFill=�6�   $��0,0,0,0q�6�    �� StrokeDashCap$ Square=�6�    �� StrokeDashArray$	 0 0R�6�    � 5L      $��Bottom=�6   
���   �  � NavigationUIVisibility$ Hidden=�6_   ��6?   �� *CurrentPage+6_   5N      5P      5Q      