   M S B A M L   `   `   `  ����@  <Task1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Task1Task1  5   	       Task1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Task1     5   	   -   5        $��
mainWindow��5        � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	        Task1.ConvertorClass   	convertor��%   &	          5
   
   63   5      .��5      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   .+�5   
   �� $��UserId��6   $��25(�6!   $��0��6/   $��0��6<   $��42,27,192,10q�6L   6d   �� 5   
   $��Old Password��6   $��25(�6'   $��1��65   $��0��6B   $��42,25,168,86q�6R   $��2��6h   6{   �� 5   
   $��New Password��6   $��25(�6'   $��2��65   $��0��6B   $��42,18,166,17q�6R   6j   �� 5   
   $��Verify New Password��6   $��25(�6.   $��3��6<   $��0��6I   $��42,19,95,18q�6Y   �� 5   
   -   5        $��UserId��5      $��0��6    $��322,18,170,18q�6-   $��2��6D   �� 5   
   -   5        $��OldPassword��5      $��1��6%   $��322,25,170,11q�62   $��2��6I   �� 5   
   -   5        $��NewPassword��5      $��2��6%   $��322,26,170,10q�62   $��2��6I   �� 5    
   -   5        $��ConfirmPassword��5       $��3��6)   $��322,18,170,18q�66   $��2��6M   �� 5!   
   
����  �$��25(�6"   $��3��60   $��1��6=   
���  ��$y�Visible=�6�   $��257,19,34,18q�6�   ��6N   �� *passwordMatched+6�   �� 5"   
   $��25(�6   $��4��6   $��279,14,349,14q�6,   $��2��6_   ��6D   �� *submit+$��Submit��5#   4   ��5$      `� 5%       `� 	Converter# [  6   .1�5&      ��  �� ElementName$ UserId��6    �� Path$
 Text�63   �� 5'      $ OldPassword��6   $
 Text�68   �� 5(      $ NewPassword��6   $
 Text�68   �� 5)      $ ConfirmPassword��6   $
 Text�6<   5*      5,      �� 5-   
   $��25(�6   $��4��6   $��1��6,   $��76,18,152,10q�6<   ��6R   �� $ 	cancelVar���6u   �� $ 
mainWindow��.��6�   Cancel6�   5/      50      