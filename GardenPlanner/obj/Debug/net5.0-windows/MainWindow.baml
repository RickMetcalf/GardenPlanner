   M S B A M L   `   `   `  ����H  DGardenPlanner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:GardenPlannerGardenPlanner  5   	       GardenPlanner.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:GardenPlanner     5   	     � Title$  
MainWindow��5   	    � 
ResizeMode$ NoResize=�6   $	��450��62   $	��800��6?    � 	Resources 5	       �� MergedDictionaries �� Source�� 5
   
    5      �� 5      $ Buttons.xaml?�6%   %    5      .��5      � 
��� d �.+�5   
   �� -   5         ��Name$ Grass��5      $��/Images/grass.png��6   $��Center=�6;   $	��100��6X   $��	0,347,0,0q�6e   $	��Top=�6x   $	��800��6�   $
��None=�6�    �� StretchDirection$ DownOnly=�6�   �� 5   
   $��Garden Planner��6   $
��Left=�5      $��48��5      $��	522,0,0,0q�5      $	��Top=�5      $	��278��5      $��Arial Black)�5      $��30(�5      
�������5      �� 5   
   -   5         ��Name$ AddPlant��5         MainMenu#��[  6#   $��	Add Plant��6F   $
��Left=�6Z   $��	18,14,0,0q�6u   $	��Top=�6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      	   ShadowDepth$	 0Q�6#   
   
BlurRadius$
 5Q�63      Color$ 	#FF000000��6B   5       �� 5!   
   -   5        $ RemovePlant��5!      #��[  6&   $��Remove Plant��6I   $
��Left=�6`   $��	18,77,0,0q�6|   $	��Top=�6�    5"        5#      $	 0Q�6#   $
 5Q�63   $ 	#FF000000��6B   5%      �� 5&   
   -   5        $ 	TodayTask��5&      #��[  6$   $��Today's Tasks��6G   $
��Left=�6_   $��
18,140,0,0q�6{   $	��Top=�6�    5'        5(      $	 0Q�6#   $
 5Q�63   $ 	#FF000000��6B   5*      �� 5+   
   -   5        $ Calendar��5+      #��[  6#   $��Calendar��6F   $
��Left=�6Y   $��
18,203,0,0q�6u   $	��Top=�6�    5,        5-      $	 0Q�6#   $
 5Q�63   $ 	#FF000000��6B   5/      �� 50   
   -   5        $ 	AllPlants��50      #��[  6$   $��List All Plants��6G   $
��Left=�6a   $��
18,266,0,0q�6}   $	��Top=�6�    51        52      $	 0Q�6#   $
 5Q�63   $ 	#FF000000��6B   54      � 55   
   -   5         �Name$ 
gardenView��55      $
��Left=�6#   $
��Auto��6>   $
��Auto��6L   $��
228,64,0,0q�6Y   $	��Top=�6m   57      5<      5@      