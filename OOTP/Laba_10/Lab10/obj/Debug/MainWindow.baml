   M S B A M L   `   `   `  ����@  <Lab10, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Lab10Lab10  5   	   7 clr-namespace:Lab10.UserControlsLab10.UserControls  5   	   7 clr-namespace:Lab10.DependenciesLab10.Dependencies  5   	       Lab10.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Lab10     5   	   5controls clr-namespace:Lab10.UserControls     5   	   0dep clr-namespace:Lab10.Dependencies     5   	     � Title$  
MainWindow��5
   	   $	��450��6   $	��800��6)    � 	Resources 5      (   "Lab10.Dependencies.TaskPriorityDep   Priority   Priority��%*   &	          5   
   $ 0��6   6+   5       J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$' !local:NewCustomCommand.PnvCommand��5      5   &   .��5      � -   5         � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5    
   !   Lab10.UserControls.TaskName  -   5          Name$ TaskNameBox��5       $��0��62   $��0��6?      
NameOfTask$  ��6O   �� 5"   
   -   5        $��1��5"      $��0��6   $��10q�6.   
�������._�5#      %   Lab10.UserControls.TaskPriority  -   5        	  Name$	 TaskPriorityBox��5#   %   %   Lab10.UserControls.TaskPriority
   PreviewMouseDown$
 Button_MouseDown��6L      Priority$ 0��6?   6L   5$      �� 5&   
   -   5        $��2��5&      $��0��6   $��50��6.   $��Submit��6:   6M   �� 5'   
   -   5         ��Name$ ButtonT��5'      $��3��6"   $��0��6/   {�. $��50��6P   $��RoutedUICommand��6\   $'��!local:NewCustomCommand.PnvCommand��6v   �� 5(   
   -   5        $��Result��5(   5   $��1��6   $��2��6$   65   5)      5*      