   M S B A M L   `   `   `  ����O  KEntityFramework_Exam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:EntityFramework_Exam.ViewEntityFramework_Exam.View  5   	   O,clr-namespace:EntityFramework_Exam.ViewModelEntityFramework_Exam.ViewModel  5   	   a5clr-namespace:EntityFramework_Exam.Service.Converters'EntityFramework_Exam.Service.Converters  5   	   2    ,EntityFramework_Exam.View.RegistrationWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:EntityFramework_Exam.View     5   	   B	ViewModel,clr-namespace:EntityFramework_Exam.ViewModel     5   	   L
Converters5clr-namespace:EntityFramework_Exam.Service.Converters     5   	   -   5        $��registrationWindow��5   	     � Title$  Registration��5
   	   $	��280��6   $	��300��6+    � 
ResizeMode$ NoResize=�5   	   ��5      �� 5   
    �� 
TargetType" �6   .�5      ��  �� Property � �� �� Value 5      �� 5       �� 
StartPoint$ 0,0.5&�6*    �� EndPoint$ 1,0.5&�6=   .��5      �  � Color$ #4b6cb7��6'    � Offset$ 0Q�67   6D   � 5      $ #182848��6'   $ 1Q�67   6D   5      5      5      	 � DataContext	 5      :   4EntityFramework_Exam.ViewModel.RegistrationViewModel  5   
   6,   
 � 	Resources
 5      G   AEntityFramework_Exam.Service.Converters.UserRegistrationConverter   userRegistrationConverter��%   &	          5   
   6S   5      .��5      ��  �� Orientation$ Vertical=�6   .+�5    
   �� $��
10,20,10,5q�6   $��20(�6(   $��Center=�66   Registration6a   �� 5!   
   $��	10,5,10,0q�6   $��15(�6'   
�������	Username:6W   �� 5"   
   -   5         ��Name$ TextBox_Username��5"      $��	10,0,10,0q�6,   $��15(�6?   
������ 6h   �� 5#   
   $��	10,5,10,0q�6   $��15(�6'   
�������	Password:6W   �� 5$   
   -   5        $ TextBox_Password��5$      $��	10,0,10,0q�6,   $��15(�6?   
������ 6h   �� 5&   
   $��	10,5,10,0q�6   $��15(�6'   
�������Select your town:6_   �� 5'   
   -   5         ��Name$ ComboBox_Towns��5'      $��	10,0,10,0q�6+   
������ ��5(      �� *TownsCollectionView+6Z   �� 5*   
   $��
25,15,25,0q�6   $��15(�6%   $��Register��63   
������ 
����ح���6F   �� *CmdRegistration+��5-      `� 5.       `� 	Converter# [  6   .1�5/      ��  �� Path$
 Text�6    �� ElementName$ TextBox_Username��6*   6K   �� 50      $
 Text�6   $ TextBox_Password��6*   6K   �� 51      $ SelectedItem�6   $ ComboBox_Towns��62   6Q   �� 52      $ registrationWindow��6   6A   53      55      56      57      