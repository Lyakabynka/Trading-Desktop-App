   M S B A M L   `   `   `  ����O  KEntityFramework_Exam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:EntityFramework_ExamEntityFramework_Exam  5   	   O,clr-namespace:EntityFramework_Exam.ViewModelEntityFramework_Exam.ViewModel  5   	   a5clr-namespace:EntityFramework_Exam.Service.Converters'EntityFramework_Exam.Service.Converters  5   	   .    (EntityFramework_Exam.AuthorizationWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:EntityFramework_Exam     5   	   B	ViewModel,clr-namespace:EntityFramework_Exam.ViewModel     5   	   L
Converters5clr-namespace:EntityFramework_Exam.Service.Converters     5   	   -   5        $��authorizationWindow��5
   	     � Title$  Authorization��5   	   $	��260��6   $	��300��6,    � 
ResizeMode$ NoResize=�5   	   ��5      �� 5   
    �� 
TargetType" �6   .�5      ��  �� Property � �� �� Value 5      �� 5       �� 
StartPoint$ 0,0.5&�6*    �� EndPoint$ 1,0.5&�6=   .��5      �  � Color$ #4b6cb7��6'    � Offset$ 0Q�67   6D   � 5      $ #182848��6'   $ 1Q�67   6D   5      5      5      	 � DataContext	 5      ;   5EntityFramework_Exam.ViewModel.AuthorizationViewModel  5   
   6-   
 � 	Resources
 5      @   :EntityFramework_Exam.Service.Converters.UserLoginConverter   userLoginConverter��%   &	          5   
   6E   5      .��5      ��  �� Orientation$ Vertical=�6   .+�5    
   �� $��
10,20,10,5q�6   $��20(�6(   $��Center=�66   Login6Z   �� 5!   
   $��	10,5,10,0q�6   $��15(�6'   
�������	Username:6W   �� 5"   
   -   5         ��Name$ TextBox_Username��5"      $��	10,0,10,0q�6,   $��15(�6?   
������ 6h   �� 5#   
   $��	10,5,10,0q�6   $��15(�6'   
�������	Password:6W   �� 5$   
   -   5        $ TextBox_Password��5$      $��	10,0,10,0q�6,   $��15(�6?   
������ 6h   �� 5&   
   $��
25,10,25,0q�6   $��15(�6%   $��	Authorize��63   
������ 
��������5'      �� *CmdAuthorization+��5(      `� 5)       `� 	Converter# [  6   .1�5*      ��  �� Path$
 Text�6    �� ElementName$ TextBox_Username��6*   6K   �� 5+      $
 Text�6   $ TextBox_Password��6*   6K   �� 5,      $ authorizationWindow��6   6B   5-      5/      �� 50   
   $��
25,10,25,0q�6   $��15(�6%   
����ح�$��I do not have an account��53      
������ ��51      �� *CmdOpenRegistrationWindow+��52      �� $ authorizationWindow��54      55      56      