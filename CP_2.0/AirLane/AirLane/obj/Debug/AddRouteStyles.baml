   M S B A M L   `   `   `  ����B  >AirLane, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:AirLaneAirLane  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   Button.Static.Background  �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Border  Button.Disabled.Foreground  airport_name_from �� 
TargetType �� Property �� Value �� 
TargetType ��Name ��Name �� Triggers ]� 
Conditions	 �� Property
 �� Value �� 
TargetName 	 airport_name_to 
 length_of_route  AddRoute ��Name J� SnapsToDevicePixels ��Name P� Property P� Value  AddRouteWord 
 Route2 �� Padding'   !System.Windows.VisualStateManager    VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState   
Storyboard8  2System.Windows.Media.Animation.EasingColorKeyFrame �� KeyTime �� Value�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      localclr-namespace:AirLane  5      %�  &	        &	 #     &	 F     &	 g     &	 �     &	 �     &	 �     &	 �     &	     &		 �    &	
 �    &	 �	    7  &	 m    &	 �    �� 5      $  	#FFDDDDDD��67   �� 5      $  	#FF707070��63   �� 5      $  #BA1111��6:   �� 5      $  	#FF3C7FB1��66   �� 5	      $  	#FFC4E5F6��68   �� 5
      $  	#FF2C628B��64   �� 5      $  	#FFADB2B5��65   �� 5      $  	#FF838383��69   �� 5      " ��6&   .�5   
   ��  � �� 5      �� 5      " ��6"   .R�5      � .+�5      �� 
����������	#FF7D8683$��1q�6L   �� 5      $ PART_ContentHost��6'   $��5,0,0,0q�6A   $��Center=�6R   �� 5      $ WaterMarkLabel��61   $��2,0,0,0q�6    $7��1Название аэропорта от куда��6I   $��Center=�6n   $y�Hidden=�5      
�������$��Arial)�6'   5       5      ]� 5       5      �� 5   "   	 � ��$
  ��6<   ./�5      �� $ WaterMarkLabel��6;    � y�$ Visible=�6W   5      5!      5#      �� 5$   
    � ��$	 200��6"   �� 5%   
    � ��$ 0 20 0 0q�6#   �� 5&   
    �@��	MaxLength$ 35��6&   5'      �� 5(      " ��6$   .�5)   
   ��  � �� 5*      �� 5+      " ��6"   .R�5,      � .+�5-      �� 
����������	#FF7D8683$��1q�6L   �� 5.      $ PART_ContentHost��6'   $��5,0,0,0q�6A   $��Center=�6R   �� 5/      $ WaterMarkLabel��61   $��2,0,0,0q�6    $2��,Название аэропорта куда��6I   $��Center=�6k   $y�Hidden=�50      
�������$��Arial)�6'   51       52      ]� 53       54      �� 55   "   	 � ��$
  ��6<   ./�57      �� $ WaterMarkLabel��6;    � y�$ Visible=�6W   58      5;      5=      �� 5>   
    � ��$	 200��6"   �� 5?   
    � ��$ 0 20 0 0q�6#   �� 5@   
    �@��	MaxLength$ 35��6&   5A      �� 5D      " ��6$   .�5E   
   ��  � �� 5F      �� 5G      " ��6"   .R�5H      � .+�5I      �� 
����������	#FF7D8683$��1q�6L   �� 5J      $ PART_ContentHost��6'   $��5,0,0,0q�6A   $��Center=�6R   �� 5K      $ WaterMarkLabel��61   $��2,0,0,0q�6    $��Длинна пути��6I   $��Center=�6_   $y�Hidden=�5L      
�������$��Arial)�6'   5M       5N      ]� 5O       5P      �� 5Q   "   	 � ��$
  ��6<   ./�5S      �� $ WaterMarkLabel��6;    � y�$ Visible=�6W   5T      5W      5Y      �� 5Z   
    � ��$	 200��6"   �� 5[   
    � ��$ 0 20 0 0q�6#   �� 5\   
    �@��	MaxLength$ 35��6&   5]      �� 5a      " ��6   .�5b   
   ��  � �� 5c      �� 5d      " ��6"   .R�5e      �� $ border��6   #��z��6-   #��z��6Y   #��z��6�    . ._�5f      �� $ contentPresenter��6+   |�.  #��z��6W   #��z��6�   ��. # z 6�   #��z��6  5g       5h      P� 5i       �@J�IsMouseOver . . �5j      �� $ border��6;   8    � ��6O   5k      5m      5o      �� 5p   
    � �� �#FFFFFF6/   �� 5q   
    � ��$ 40��6#   �� 5r   
    � ��$	 150��6"   �� 5s   
    � ��$ 20(�6-   �� 5t   
    � �� �#092C526'   �� 5u   
    � ��$ 
0 150 0 0 q�6#   �� 5v   
    � ��$ Добавить��6$   5w      �� 5{      " ��6!   .�5|   
   ��  �@J�Opacity$ 1Q�6$   �� 5}   
    � �� �#092C526/   �� 5~   
    � ��$ 20(�6%   �� 5   
    � ��$	 190��6"   �� 5�   
    � ��$ Center=�60   �� 5�   
    � ��$ Center=�6.   �� 5�   
    � ��$% Добавить маршрут��6!   5�      �� 5�      " ��6   .�5�   
   ��  �@J�SnapsToDevicePixels . 60   �� 5�   
    �@�OverridesDefaultStyle . 62   �� 5�   
    � �� 5�      �� 5�      " ��6"   .R�5�      �� $ Border��6   $ 2q�6-    . 
������  5�        5�      SelectionStates��. 5�   "     
Unselected��6.     5�   "   Selected��. 5�   &   �� .��5�   *   �� .g�5�   .     $ 0��6B   $	 Red��6N   5�   +   5�   '   5�   #     5�   "   SelectedUnfocused��. 5�   &   �� .��5�   *   �� .g�5�   .     $ 0��6B   $ Yellow��6N   5�   +   5�   '   5�   #   5�      ._�5�      �� 5�      5�      5�      5�      5�      