   M S B A M L   `   `   `  ����I  EProject_TPA_AN, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Project_TPA_AN.ViewProject_TPA_AN.View  5      -    'Project_TPA_AN.View.ViewManagerResponse   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:Project_TPA_AN.View     5        N� Title$  ViewManagerResponse��5	      .��5      � ���#d6cbb4$��
0,0,0,86.6q�6     � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $��20 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
EventTable��5      $��1��6'   $��1��67   $	��200��6E      AutoGenerateColumns . 5      	� 5   
   -   5         	�Name$ RideRadioButton��5      $��1��6/   $��2��6?   $
��Ride��6L    	� 	GroupName$ Event��6[   6�   	� 5   
   -   5        $ AttractionRadioButton��5      $��1��65   $��2��6E   $��
Attraction��6R   $ Event��6g   $��2��6y   $��59,0.4,-39,0.4q�6�   6�   �� 5   
   $��1��6   $��2��6$   $��15(�61   $��Input Id : ��5      $��2��6'   $��10,30.4,10,-30.6q�6;   �� 5   
   -   5         ��Name$ idText��5      $��1��6"   $��2��62   $	��150��5      $��81,30.4,529,-30.6q�6   �� 5   
   -   5         ��Name$ searchButton��5      $��Search��6'   $��1��5       $��2��6!   $��2q�6.   $��248,30.4,430,-30.6q�5!   !   �� 5"   
   -   5        	 ��Name$	 	NameLabel��5"      $��1��6#   $��2��63   $��2��6@   $��10,51.4,10,-65.6q�6T   .��6n   Result6v   �� 5#   
   -   5        $ executeButton��5#      $��Execute��6(   $��1��5$      $��2��6!   $��2q�6.   $��346,30.4,332,-30.6q�5%   .   5&      5(      