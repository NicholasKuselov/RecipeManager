   M S B A M L   `   `   `  ����H  DRecipeManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:RecipeManager.PagesRecipeManager.Pages  5   	   C&clr-namespace:RecipeManager.ViewModelsRecipeManager.ViewModels  69   *    $RecipeManager.Pages.SelectDateWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:RecipeManager.Pages     5   	   =
viewmodels&clr-namespace:RecipeManager.ViewModels     69      
SelectDate  � Title#  �   5   	   $	��150��6.   $	��300��6;    � 
ResizeMode$ NoResize=�6G    � DataContext 5	      1  +RecipeManager.ViewModels.SelectDateWindowVM  5
   
   6*    � 	Resources 5        ttt �� 
TargetType&   System.Windows.Controls.Calendar �� Property �� Value��%�   &	       �� 5   
   "  6   .�5      ��  �@ SelectionMode$ 
SingleDate=�6.   �� 5       �@ DisplayMode$ Decade=�6,   �� 5       �@ DisplayDate$  ��6,   5      5      .��5      � .+�5   
   (  "System.Windows.Controls.DatePicker  $��Center=�6      CalendarStyle# [ 62   $��Center=�6X      IsTodayHighlighted . 	   FirstDayOfWeek$	 Monday=�6�   $��80,39,80,63q�6�   $	��134��6�   $��23��6�   
   SelectedDate
 6s   �� *
dateFrom+6�   �� 5   
   #���   6   $��20��68   $��Bottom=�6D   $��Center=�6_   $��0,0,0,10q�6|   $��75��6�   ��6�   �� *bSelectDate+5      5      