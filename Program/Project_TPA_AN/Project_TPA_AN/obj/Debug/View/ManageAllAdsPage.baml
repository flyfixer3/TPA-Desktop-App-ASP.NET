   M S B A M L   `   `   `  ����I  EProject_TPA_AN, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Project_TPA_AN.ViewProject_TPA_AN.View  5      *    $Project_TPA_AN.View.ManageAllAdsPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:Project_TPA_AN.View     5        N� Title$  ManageAllAdsPage��5	      .��5      � ���#d6cbb4$��0,0,0,-94.4q�6     � ColumnDefinitions 5   
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
��auto �6    .+�5)      �� $��0��6   $��1��6(   $��15(�65   $��Input Id : ��5*      $��	0,15,0,10q�6'   �� 5+      -   5         ��Name$ idText��5+      $��1��6&   $��1��66   $	��150��5,      $��	0,15,0,10q�6   �� 5-      -   5         ��Name$ searchButton��5-      $��Search��6+   $��2��5.      $��1��6!   $��2q�6.   $��10.2,14.2,10,6.4q�5/       J� RenderTransformOrigin$ 	0.5,0.504&�6F   �� 51      $��0��6   $��3��6(   $��15(�65   $��Advertisement Desc : ��52      $��0,0,0,10q�61   �� 53      -   5        $" advertisementDescriptionText��53      $��1��6<   $��3��6L   $��65��6Y   $	��150��54      $��0.4,0.8,60,10.2q�6   $��2��67   �� 56      $��0��6   $��4��6(   $��15(�65   $��Advertisement Deadline: ��57      $��0,0,0,10q�64   (  "System.Windows.Controls.DatePicker  58      -   5          Name$ AdsDeadline��58      $��1��6.   $��3��6>   $��0.4,75,0.2,0.6q�6K   $��2��6c   59      �� 5:      -   5        $ deleteButton��5:      $��
Delete Ads��6+   $��0��5;      $��7��6!   $��5q�6.   $��76,46.2,105.2,-0.2q�5<      $��2��6H   �� 5=      -   5        $ updateButton��5=      $��
Update Ads��6+   $��1��5>      $��7��6!   $��5q�6.   $��10.4,46,0.2,-0.2q�5?      6+   �� 5@      -   5        $ CreateButton��5@      $��
Create Ads��6+   $��2��5A      $��7��6!   $��5q�6.   $��10.8,46,0,-0.2q�5B      6)   5C      �� 5D   
   $��1��6   $��1��6$   $��30(�61   $��Under The Sea��5E      $��3��6)   $��0,0,0,15q�6=   �� 5F   
   $��1��6   $��2��6$   $��20(�61   $��Manage All Advertisement��5G      $��3��64   $��0,0,0,10q�6H   &   System.Windows.Controls.DataGrid  5H   
   -   5          Name$ adsTable��5H      $��2��6%   $��3��65   $	��200��6C      AutoGenerateColumns . 5I      5L      5M      