   M S B A M L   `   `   `  ����I  EProject_TPA_AN, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Project_TPA_AN.ViewProject_TPA_AN.View  5      ,    &Project_TPA_AN.View.AttractionHomePage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:Project_TPA_AN.View     5        N� Title$  AttractionHomePage��5	      .��5      � ���#d6cbb4$��0,0,0,-94.4q�6     � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��20 �6   .+�5   
   � $��1��6   $��3��6   $��6��6,    5      �� 5      $	��170 �6#   �� 5      $��* �6#   �� 5      $��* �6#    5      �� 5       $��20 �6    �� 5!      $
��auto �6    �� 5"      $
��auto �6    �� 5#      $
��auto �6    �� 5$      $
��auto �6    �� 5%      $
��auto �6    �� 5&      $
��auto �6    �� 5'      $
��auto �6    .+�5)      �� $��0��6   $��1��6(   $��15(�65   $��Input TransactionID : ��5*      $��	0,15,0,10q�62   �� 5+      -   5         ��Name$ idText��5+      $��1��6&   $��1��66   $	��150��5,      $��	0,15,0,10q�6   �� 5-      -   5         ��Name$ searchButton��5-      $��Search��6+   $��2��5.      $��1��6!   $��2q�6.   $��10.2,14.2,10,6.4q�5/       J� RenderTransformOrigin$ 	0.5,0.504&�6F   �� 51      $��0��6   $��3��6(   $��15(�65   $��
Quantity :��52      $��0,0,0,10q�6&   �� 53      -   5        $ QuantityText��53      $��1��6,   $��3��6<   $��20��6I   $	��150��54      $��0.4,0.8,60,10.2q�6   $��2��67   �� 55      -   5        $ deleteButton��55      $��Delete ��6+   $��0��56      $��7��6!   $��5q�6.   $��16,46.4,59.6,-0.2q�57      6,   �� 58      -   5        $ updateButton��58      $��Update��6+   $��7��6<   $��5q�6I   $��120,46.4,60.2,-0.2q�59      $��2��6H   �� 5:      -   5        $ CreateButton��5:      $��Create��6+   $��1��5;      $��7��6!   $��5q�6.   $��56.4,46.4,60,-0.2q�5<      $��29��6G   $	��Top=�6S   $��2��6k   �� 5=      -   5        $ printButton��5=      $��Print��6*   $��7��6:   $��5q�6G   $��120,91.4,62.2,-43.6q�5>      $��29��6H   $	��Top=�6T   $��2��6l   5?      �� 5@   
   $��1��6   $��1��6$   $��30(�61   $��Under The Sea��5A      $��3��6)   $��0,0,0,15q�6=   �� 5B   
   $��1��6   $��2��6$   $��20(�61   $��Attraction Department��5C      $��3��61   $��0,0,0,10q�6E   &   System.Windows.Controls.DataGrid  5D   
   -   5          Name$ TicketTransactionTable��5D      $��2��63   $��3��6C   $	��200��6Q      AutoGenerateColumns . 5E      �� 5F   
   -	   5        $
 Scan��5F      $��Scan Barcode��6!   $��2��68   $
��Left=�6H   $��34��6c   $��129,184.8,0,-198q�6o   $��4��6�   $	��Top=�6�   $	��130��6�   6�   �� 5G   
   -
   5         ��Name$ imageQR��5G      $��2��6!   $
��Left=�61   $	��152��6L   $��119,20.8,0,-152q�6Y   $��4��6r   $	��Top=�6   $	��152��6�   �� 5H   
   -   5        $ logout��5H      $��Logout��6!   $��1��62   $
��Left=�6B   $��37��6]   $��10,181.8,0,-198q�6i   $��4��6�   $	��Top=�6�   $��93��6�   6�   5K      5L      