   M S B A M L   `   `   `  ����O  KEntityFramework_Exam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:EntityFramework_Exam.ViewEntityFramework_Exam.View  5   	   O,clr-namespace:EntityFramework_Exam.ViewModelEntityFramework_Exam.ViewModel  5   	   a5clr-namespace:EntityFramework_Exam.Service.Converters'EntityFramework_Exam.Service.Converters  5   	   *    $EntityFramework_Exam.View.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:EntityFramework_Exam.View     5   	   B	ViewModel,clr-namespace:EntityFramework_Exam.ViewModel     5   	   L
Converters5clr-namespace:EntityFramework_Exam.Service.Converters     5   	   -   5        $��
mainWindow��5
   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   ��5      �� 5   
    �� 
TargetType" �6   .�5      ��  �� Property � �� �� Value 5      �� 5       �� 
StartPoint$ 0,0.5&�6*    �� EndPoint$ 1,0.5&�6=   .��5      �  � Color$ #4b6cb7��6'    � Offset$ 0Q�67   6D   � 5      $ #182848��6'   $ 1Q�67   6D   5      5      5       � DataContext 5      2   ,EntityFramework_Exam.ViewModel.MainViewModel  5   
   6$   	 � 	Resources	 5      ?   9EntityFramework_Exam.Service.Converters.UserMainConverter   userMainConverter��%   &	          5   
   6C   5      .��5      � .+�5    
   �� $��8��6   $��15(�6(   $
��Left=�66   $��5,5,0,0q�6n   ��6Q   �� *CurrentUser+6�   �� 5#   
   
������ $��5q�6*   $��0��6>   $��1��6N   $��9��6[   $��3��6l   
����ح�$��0,5,0,0q�6�   5$      �� 5%   
   $��1��6   $��0��6!   $��2��61   $��Center=�6E   $��15(�6`   $��	10,10,0,0q�6n   
����  �Items in Inventory6�   &   System.Windows.Controls.DataGrid  5&   
   -   5        $��DataGrid_Items��5&      $��0��5'      $��2��6#   $��3��60   $��9��6D   $��5q�6U   
   AutoGenerateColumns$
 False��5)         
IsReadOnly$
 True��5*         CanUserAddRows$ False��5+         CanUserDeleteRows$ False��5,         CanUserReorderColumns$ False��5-         CanUserResizeRows$ False��5.         CanUserSortColumns$
 True��5/         SelectionMode$ Extended=�50      
������    RowBackground
 ����    AlternatingRowBackground
 ���� ��5(      �� *!CurrentUser_ItemsCollectionView+   Columns 56      0  *System.Windows.Controls.DataGridTextColumn  57      ,  &System.Windows.Controls.DataGridColumn   Header$ Description��6E      Width5  /System.Windows.Controls.DataGridLengthConverter$ 3* 6Z   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Description+6Z     58      $ Weight��6@   $ 2* 6P    6%   �� *Weight+6P     59      $ Class��6B   $ 2* 6Q    6%   �� *
ItemType+6Q   5;      �� 5>   
   
������ $��5q�6*   $��3��6>   $��1��6N   $��9��6[   $��3��6l   
����ح�$��0,5,0,0q�6�   5?      �� 5@   
   $��1��6   $��3��5A      $��3��5B      $��1��5C      $��Center=�5D      $��13(�5E      $��	10,10,0,0q�5F      
������$
��Wrap=�5H      ��5I      �� *CurrentUser.Username+ �� StringFormat$  {0}`s Property ��6]     5J   
   -   5        $��DataGrid_Property��5J      $��3��5K      $��2��6#   $��3��60   $��8��6D   $��5q�6U   $
 False��5M      $
 True��5N      $ False��5O      $ False��5P      $ False��5Q      $ False��5R      $
 True��5S      $ Extended=�5T      
������ 
 ���� 
 ���� ��5L      �� *&$CurrentUser_PropertiesCollectionView+ 5Z        5[      $ Description��6E   $ 2* 6Z    6%   �� *Description+6Z     5\      $ Class��6F   $ 1* 6U    6%   �� *PropertyType+6U   5^      �� 5a   
   
������ $��5q�6*   $��6��6>   $��1��6N   $��9��6[   $��2��6l   
����ح�$��0,5,0,0q�6�   5b      �� 5c   
   $��1��6   $��6��5d      $��2��5e      $��1��5f      $��Center=�5g      $��13(�5h      $��	10,10,0,0q�5i      
����� �$
��Wrap=�5k      ��5l      �� *CurrentUser.Town+$ Players in {0}:��6X     5m   
   -   5        $��DataGrid_UsersInTown��5m      $��6��5n      $��2��6#   $��2��60   $��8��6D   $��5q�6U   $
 False��5p      $
 True��5q      $ False��5r      $ False��5s      $ False��5t      $ False��5u      $
 True��5v      $ Extended=�5w      
������ 
 ���� 
 ���� $ �� IsSynchronizedWithCurrentItem$
 TrueY�5{      ��5o      �� *'%CurrentUser_UsersInTownCollectionView+ J� InputBindings 5}      d� 5~       d� Gesture$ LeftDoubleClicka�6    �� Command 5      �� *TradeWithUserCmd+ �� CommandParameter 5�      `� 5�       `� 	Converter# [  6'   .1�5�      ��  �� Path$ SelectedItem�6&     �� ElementName$  DataGrid_UsersInTown��6:   6_   �� 5�      $  
mainWindow��6&   6A   5�      5�       5�        5�      $ Username��6B   $ 1* 6T    6%   �� *
Username+6T   5�      ! � ColumnDefinitions! 5�   
   �� 5�      �� 5�      �� 5�      �� 5�      �� 5�      �� 5�      �� 5�      �� 5�      " � RowDefinitions" 5�   
   �� 5�      $
��0.6* �6   �� 5�      �� 5�      �� 5�      �� 5�      �� 5�      �� 5�      �� 5�      �� 5�      �� 5�      5�      5�      