   M S B A M L   `   `   `  ����I  EProject_TPA_AN, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Project_TPA_AN.ViewProject_TPA_AN.View  5      #    Project_TPA_AN.View.LoginPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:Project_TPA_AN.View     5        N� Title$  	LoginPage��5	      .��5      � ���#d6cbb4 � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5"   
   �� $��1��6   $��1��6$   $��30(�61   $��Under The Sea��5#      $��3��6)   $��0,0,0,15q�6=   �� 5'   
   $��1��6   $��3��6$   $��20(�61   $��Username : ��6?   $��0,0,0,15q�6R   �� 5(   
   -   5         ��Name$ usernameText��5(      $��2��6(   $��3��68   $	��150��6E   $��0,0,0,15q�6Q   �� 5,   
   $��1��6   $��4��6$   $��20(�61   $��Password : ��6?   $��0,0,0,15q�6R   G� 5-   
   -   5         G�Name$ passwordText��5-      $��2��6,   $��4��6<   $	��150��6I   $��0,0,0,15q�6U   �� 51   
   -   5         ��Name$ loginButton��51      $��Login��6&   $��1��52      $��5��6!   $��	0,0,15,15q�53      $��5q�6$   54      �� 58   
   -   5         ��Name$ errorLabelText��58      $��1��6,   $��7��6<   $��15(�6I   $�� ��59      $��0,0,0,15q�6   5;      5<      