   M S B A M L   `   `   `  ����@  <Task2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Task2Task2  5   	       Task2.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Task2     5   	   -   5        $��
mainWindow��5        � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	        Task2.ConvertorClass   	convertor��%   &	          5
   
   63   5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��0* �6   6,   �� 5      $��9* �6   �� 5      $
��391* �6   �� 5      $
��400* �6   6.    � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   .+�5   
   �� $��0��6   $��2��6   $��20(�6-   $��281,28,389,27q�6;   $��2��6R   .��6f   Name6l   �� 5   
   $��1��6   $��2��6   $��20(�6-   $��281,32,7,22q�6;   .��6P   Gender6X   �� 5   
   $��2��6   $��2��6   $��20(�6-   $��279,28,12,32q�6;   .��6Q   
Graduate6[   �� 5   
   $��3��6   $��3��6   $��66,19,255,54q�6.   ��6D   ��  �� Path$ submit�$��Submit��5   4   ��5      `� 5        `� 	Converter# [  6    `� UpdateSourceTrigger$ PropertyChanged=�6F   .1�5!      ��  �� ElementName$
 Name��6   $
 Text�61   6?   �� 5"      $ Gender��6   $
 Text�63   6A   �� 5#      $	 Yes��6   62   �� 5$      $ No��6   61   5%      5'      �� 5(   
   $��3��6   $��3��6   $��200,19,122,54q�6.   ��6E   �� $ 	cancelVar���6h   �� $ 
mainWindow��.��6�   Cancel6�   �� 5)   
   -   5        $
��Name��5)   /   $��0��6   $��3��6   $��66,28,108,43q�6;   6S   �� 5*   
   -   5        $��Gender��5*   B    �� SelectedIndex$ 0��6   $��1��6%   $��3��62   $��66,32,108,32q�6P   ��5+      -  'System.Windows.Data.CompositeCollection  5,      �� 5-      Male6&   �� 5.      Female6(   5/      51      	� 52   
   -   5        $	��Yes��52      $��2��6!   $��3��6.   $	��Yes��6>   $��66,33,236,55q�6L   	� 53   
   -   5        $��No��53      $��2��6!   $��3��6.   $��No��6>   $��210,33,116,33q�6K   57      58      