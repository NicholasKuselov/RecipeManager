   M S B A M L   `   `   `  ����H  DRecipeManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:RecipeManager.WindowsRecipeManager.Windows  5   	   C&clr-namespace:RecipeManager.ViewModelsRecipeManager.ViewModels  6;   5    /RecipeManager.Windows.FinancialStatemenceWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:RecipeManager.Windows     5   	   =
viewmodels&clr-namespace:RecipeManager.ViewModels     6;   Ishell9http://schemas.microsoft.com/netfx/2009/xaml/presentation    6u   -   5           FinanceWindow  � Title#  �   5   	   $	��450��61   $	��800��6>    � 
ResizeMode$ CanResizeWithGrip=�6J   
���  �����	#FF8F8F8F$��1q�6�   $��Center=�6�   $��Center=�6�    � AllowsTransparency .   � WindowStyle$
 None=�6   J� SnapsToDevicePixels .  ��5
      �� 5   
    �� 
TargetType" �6   .�5      �� '  !System.Windows.Shell.WindowChrome �� Property �@ WindowChrome �� Value 5        5         CaptionHeight$ 0Q�6)   	   CornerRadius$	 0��5   )   
   GlassFrameThickness$
 0,0,0,0q�5   )      NonClientFrameEdges$
 None=�5   )      ResizeBorderThickness$ 5q�5   )      UseAeroCaptionButtons .  5   )   5      5       � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $' !/Resources/Colors/MainColors.xaml?�6%   �� 5      $ /Resources/Icons.xaml?�6%   �� 5       $D >/Resources/Templates/EntryWindow/EntryWindowControlButton.xaml?�6%   �� 5!      $> 8/Resources/Templates/EntryWindow/EntryWindowButtons.xaml?�6%   �� 5"      $D >/Resources/Templates/EntryWindow/EntryWindowTextBoxStyles.xaml?�6%   �� 5#      $8 2/Resources/Templates/MainWindow/SettingButton.xaml?�6%   �� 5$      $= 7/Resources/Templates/MainWindow/NavButtonAnimation.xaml?�6%   �� 5%      $' !/Resources/Colors/MainColors.xaml?�6%   �� 5&      $ /Resources/Icons.xaml?�6%   �� 5'      $? 9/Resources/Templates/MainWindow/WindowControlButtons.xaml?�6%   �� 5(      $8 2/Resources/Templates/MainWindow/SettingButton.xaml?�6%   �� 5)      $: 4/Resources/Templates/MainWindow/WeekListButtons.xaml?�6%   %    5+       � DataContext 5/      :  4RecipeManager.ViewModels.FinancialStatementsWindowVM  50   
   63   .��52      �  � RowDefinitions 53   
   �� 54      $��30 �6   �� 55      $��* �6   .+�58   
   � $��0��6   $��30��6   $	��Top=�6(     Color_MainWindow#���  6@   .+�59      �� #���   6    # Color_ProgramNameLaberForecolor#���  6>   $��10,0,0,0q�6~   $
��Left=�6�   $��Center=�6�   $��12(�6�   �� 5:      -   5        $��pb_Logo��5:   o   $
��Left=�6   $��30��6/   $��30��6;   $��2,0,0,0q�6F   $	��Top=�6W   6o   �� 5<      $��50��6   $��30��6G   $��0,0,0,0q�6S   $��Right=�6d   $	��Top=�6�     
ExitButton#���  6�   ��6    �� *CloseWindowCommand+6�   �� 5=      $��50��6   $��30��6J   $��0,0,50,0q�6V   $��Right=�6h   $	��Top=�6�     MaximizeButton#���  6�   ��6    �� *MaximizeWindowCommand+6�   �� 5>      $��50��6   $��30��6J   $��	0,0,100,0q�6V   $��Right=�6i   $	��Top=�6�     MinimizeButton#���  6�   ��6    �� *MinimizeWindowCommand+6�   5?      � 5A   
   $��1��6   
�������.+�5B      ]� ��. $��0,0,0,0q�6-   .+�5D      �� $	��Top=�6   $��40��62   $	��Top=�6>   #���  6V    �� Orientation$ 
Horizontal=�6�   .+�5E      	� -   5        $��b_Timetable��5E   �     MainNavigationButtonAnim#���  6D     WithoutBackgroundAnim#���  6w   $��10,0,0,0q�6�   $
��Left=�6�     FSSells#���  6�   $��20(�6   	 Color_MainNavButtons#��� 	 6   	� 	GroupName$ NavButtonGoup��6R   d� 	IsChecked$
 TrueY�6l  ��6"   �� *GoToSellsPage+6l  	� 5F      -   5        $��
b_Subjects��5F     #���  6F   #���  6z   $��25,0,0,0q�6�   $
��Left=�6�    
 	FSClients#��� 
 6�   $��20(�6  #��� 	 6"  $ NavButtonGoup��6V  ��6"   �� *GoToClientsPage+6V  	� 5G      -   5        $��	b_Recipes��5G     $y�	Collapsed=�6"   #���  6Z   #���  6�   $��25,0,0,0q�6�   $
��Left=�6�     	FSAllStat#���  6�   $��20(�6'  #��� 	 65  $ NavButtonGoup��6i  ��69   �� *GoToStatPage+6i  5M      �� 5N      	 �� X1$ 0��6   	 �� Y1$ 0��6   	 �� Y2$ 0��6%    ! Color_MainNavButtonsUnderline#���  6,   $	��Top=�6e   $��3��6z   	 �� X2$	 860��6�    �� Stretch$ UniformToFill=�6�   $��0,0,0,0q�6�    �� StrokeDashCap$ Square=�6�    �� StrokeDashArray$	 0 0R�6�    � 5O      $��Bottom=�6   
���   �  � NavigationUIVisibility$ Hidden=�6c   ��6C   �� *CurrentPage+6c   5Q      5S      5U      5V      