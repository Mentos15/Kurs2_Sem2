   M S B A M L   `   `   `  ����B  >AirLane, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:AirLane.PagesAirLane.Pages  5          AirLane.Pages.History   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:AirLane.Pages     5        N� Title$  History��5	      .��5      � .+�5   
   �� $��обновить��6   $��80��6$   $��40��6/   $	��Top=�6;   $��10q�6S   ��6_   �� *Reload+�� 5   
    � DataContext 6   �� *Models+.+�5      � $��
20 80 20 0q�6   $��18��6'   
�������$	��Top=�6L    � ColumnDefinitions 5      �� 5      $	��150 �6'   �� 5      $	��150 �6'   �� 5      $	��150 �6'   �� 5      $	��150 �6'   �� 5      $��* �6'   .+�5      �� $��Center=�6   $��0��69   $��Дата вылета��6I   �� 5      $��Center=�6   $��1��69   $��От куда��6I   �� 5      $��Center=�6   $��2��69   $��Куда��6I   �� 5      $��Center=�6   $��3��69   $��Компания��6I   �� 5      $��Center=�6   $��4��69   $��
Класс��6I   5      &   System.Windows.Controls.DataGrid  5      -   5          Name$ dataGrid��5   u      HeadersVisibility$
 None=�6      CanUserAddRows .     CanUserDeleteRows .  $��
5, 0, 5, 5q�6a   $��1��6�      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 150 5   %   
   
IsReadOnly
 . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   )   �� *Date+5   1     5       $		 150 5!   %   
 .  5    )   �� *
TownFrom+5!   1     5"      $		 150 5#   %   
 .  5"   )   �� *TownTo+5#   1     5$      $		 150 5%   %   
 .  5$   )   �� *	Company+5%   1     5&      $	 * 5'   %   
 .  5&   )   �� *Clas+5'   /   5*      5+      5-      5.      