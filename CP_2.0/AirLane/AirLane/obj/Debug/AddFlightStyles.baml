   M S B A M L   `   `   `  ����B  >AirLane, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:AirLaneAirLane  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   Button.Static.Background  �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Border  Button.Disabled.Foreground 	 Words �� 
TargetType �� Property �� Value 		 Route �� 
TargetType ��Name ��Name �� Triggers ]� 
Conditions	 �� Property
 �� Value �� 
TargetName 
 	AddFlight ��Name J� SnapsToDevicePixels ��Name P� Property P� Value  AddCompanyWord 
 Route2 �� Padding'   !System.Windows.VisualStateManager    VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState   
Storyboard8  2System.Windows.Media.Animation.EasingColorKeyFrame �� KeyTime �� Value�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      localclr-namespace:AirLane  5      %  &	        &	 #     &	 F     &	 g     &	 �     &	 �     &	 �     &	 �     &	     &		 `    &	
 �    7  &	 �    &	 �    �� 5      $  	#FFDDDDDD��67   �� 5      $  	#FF707070��63   �� 5      $  #BA1111��6:   �� 5	      $  	#FF3C7FB1��66   �� 5
      $  	#FFC4E5F6��68   �� 5      $  	#FF2C628B��64   �� 5      $  	#FFADB2B5��65   �� 5      $  	#FF838383��69   �� 5)      " ��6   .�5+   
   ��  � ��
 �����6'   5,      �� 5/      " ��6   .�50   
   ��  � �� 51      �� 52      " ��6"   .R�53      � .+�54      �� 
����������	#FF7D8683$��1q�6L   �� 55      $ PART_ContentHost��6'   $��5,0,0,0q�6A   $��Center=�6R   �� 56      $ WaterMarkLabel��61   $��2,0,0,0q�6    $��Маршрут��6I   $��Center=�6[   $y�Hidden=�57      
�������$��Arial)�6'   58       59      ]� 5:       5;      �� 5<   "   	 �@��Text$
  ��6<   ./�5>      �� $ WaterMarkLabel��6;    � y�$ Visible=�6W   5?      5B      5D      �� 5E   
    � ��$	 200��6"   �� 5F   
    � ��$ 0 20 0 0q�6#   5G      �� 5K      " ��6   .�5L   
   ��  � �� 5M      �� 5N      " ��6"   .R�5O      �� $ border��6   #��z��6-   #��z��6Y   #��z��6�    . ._�5P      �� $ contentPresenter��6+   |�.  #��z��6W   #��z��6�   ��. # z 6�   #��z��6  5Q       5R      P� 5S       �@J�IsMouseOver . . �5T      �� $ border��6;   8    � ��6O   5U      5W      5Y      �� 5Z   
    � �� �#FFFFFF6/   �� 5[   
    � ��$ 40��6#   �� 5\   
    � ��$	 150��6"   �� 5]   
    � ��$ 20(�6-   �� 5^   
    � �� �#092C526'   �� 5_   
    � ��$ 
0 250 0 0 q�6#   �� 5`   
    � ��$ Добавить��6$   5a      �� 5e      " ��6#   .�5f   
   ��  �@J�Opacity$ 1Q�6$   �� 5g   
    � �� �#092C526/   �� 5h   
    � ��$ 20(�6%   �� 5i   
    � ��$	 220��6"   �� 5j   
    � ��$ Center=�60   �� 5k   
    � ��$ Center=�6.   5l      �� 5q      " ��6   .�5r   
   ��  �@J�SnapsToDevicePixels . 60   �� 5s   
    �@�OverridesDefaultStyle . 62   �� 5t   
    � �� 5u      �� 5v      " ��6"   .R�5w      �� $ Border��6   $ 2q�6-    . 
������  5x        5y      SelectionStates��. 5z   "     
Unselected��6.     5{   "   Selected��. 5|   &   �� .��5}   *   �� .g�5~   .     $ 0��6B   $	 Red��6N   5   +   5�   '   5�   #     5�   "   SelectedUnfocused��. 5�   &   �� .��5�   *   �� .g�5�   .     $ 0��6B   $ Yellow��6N   5�   +   5�   '   5�   #   5�      ._�5�      �� 5�      5�      5�      5�      5�      