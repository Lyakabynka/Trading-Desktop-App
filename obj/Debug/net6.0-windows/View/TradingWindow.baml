   M S B A M L   `   `   `  ����O  KEntityFramework_Exam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:EntityFramework_Exam.ViewEntityFramework_Exam.View  5   	   O,clr-namespace:EntityFramework_Exam.ViewModelEntityFramework_Exam.ViewModel  5   	   a5clr-namespace:EntityFramework_Exam.Service.Converters'EntityFramework_Exam.Service.Converters  5   	   -    'EntityFramework_Exam.View.TradingWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:EntityFramework_Exam.View     5   	   B	ViewModel,clr-namespace:EntityFramework_Exam.ViewModel     5   	   L
Converters5clr-namespace:EntityFramework_Exam.Service.Converters     5   	     � Title$  TradingWindow��5
   	   $	��450��6   $	��800��6,   ��5      �� 5   
    �� 
TargetType" �6   .�5      ��  �� Property � �� �� Value 5      �� 5       �� 
StartPoint$ 0,0.5&�6*    �� EndPoint$ 1,0.5&�6=   .��5      �  � Color$ #4b6cb7��6'    � Offset$ 0Q�67   6D   � 5      $ #182848��6'   $ 1Q�67   6D   5      5      5       � DataContext 5      5   /EntityFramework_Exam.ViewModel.TradingViewModel  5   
   6'   .��5      � .+�5   
   �� $��0��6   $��0��6!   $��2��61   $��15(�6E   $
��Left=�6S   $��5,5,0,0q�6n   ��5      �� *CurrentUser+64   �� 5   
   
������ $��5q�6*   $��0��6>   $��1��6N   $��5��6[   $��2��6l   
����ح�$��0,5,0,0q�6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $ ��DataGrid_CurrentUser_Items��5      $��0��5      $��1��6#   $��2��60   $��9��6D   $��5,10,5,5q�6U   	   AutoGenerateColumns$	 False��5!      
   CanUserAddRows$
 False��5"         CanUserDeleteRows$ False��5#         CanUserReorderColumns$ False��5$         CanUserResizeRows$ False��5%         CanUserSortColumns$
 True��5&         SelectionMode$ Extended=�5'      
������    RowBackground
 ����    AlternatingRowBackground
 ���� $ �� IsSynchronizedWithCurrentItem$
 TrueY�5+      ��5       �� *!CurrentUser_ItemsCollectionView+   Columns 5-      4  .System.Windows.Controls.DataGridCheckBoxColumn  5.      ,  &System.Windows.Controls.DataGridColumn   Header$ Trade��6G      Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 6V      
IsReadOnly$ False��6a   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   �� *	IsChecked+6v   0  *System.Windows.Controls.DataGridTextColumn  5/      $ Description��6E   $ 3* 6Z   $
 True��6e    6%   �� *Description+6e     50      $ Weight��6@   $ 2* 6P   $
 True��6[    6%   �� *Weight+6[     51      $ Class��6B   $ 2* 6Q   $
 True��6\    6%   �� *
ItemType+6\   53      �� 56   
   $��0��6   $��3��6!   $��2��61   $��15(�6E   $
��Left=�6S   $��5,5,0,0q�6n   ��57      �� *UserToTrade+64   �� 58   
   
������ $��5q�6*   $��3��6>   $��1��6N   $��5��6[   $��2��6l   
����ح�$��0,5,0,0q�6�   6�     59   
   -   5        $ ��DataGrid_UserToTrade_Items��59      $��3��5:      $��1��6#   $��2��60   $��9��6D   $��5,10,5,5q�6U   $	 False��5<      $
 False��5=      $ False��5>      $ False��5?      $ False��5@      $
 True��5A      $ Extended=�5B      
������ 
 ���� 
 ���� $
 TrueY�5F      ��5;      �� *!UserToTrade_ItemsCollectionView+ 5H        5I      $ Trade��6H   $ 1* 6W   $ False��6b    6*   �� *	IsChecked+6w     5J      $ Description��6E   $ 3* 6Z   $
 True��6e    6%   �� *Description+6e     5K      $ Weight��6@   $ 2* 6P   $
 True��6[    6%   �� *Weight+6[     5L      $ Class��6B   $ 2* 6Q   $
 True��6\    6%   �� *
ItemType+6\   5N      �� 5P   
   $��2��6   $��3��6!   
������ $��5q�6G   $��20(�6R   $��Trade��6`   ��6p   �� *
TradingCmd+5W       � RowDefinitions 5Y   
   �� 5Z      $
��0.5* �6   �� 5[      �� 5\      �� 5]      �� 5^      �� 5_       � ColumnDefinitions 5a   
   �� 5b      $��2* �6   �� 5c      $��2* �6   �� 5d      �� 5e      $��2* �6   �� 5f      $��2* �6   5h      5i      