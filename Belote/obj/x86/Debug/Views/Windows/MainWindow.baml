   M S B A M L   `   `   `  ����A  =Belote, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Belote.ModelsBelote.Models  5   	   5clr-namespace:Belote.ViewModelsBelote.ViewModels  5   	   %    Belote.Views.Windows.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   .modelsclr-namespace:Belote.Models     5   	   6
viewmodelsclr-namespace:Belote.ViewModels     5   	     � Title$  Belote (klaverjassen)��5   	   $	��600��5   	   $	��800��5   	   $	��500��5	   	   $	��700��5
   	    � 	Resources 5         playerTemplate �� DataType $� Orientation��%�   &	        �� 5   
   $
 Card��5      .R�5      $� $ Vertical=�6%   .+�5      �� ��6   �� *	CardValue+�� 5      ��6   �� *	CardColor+5      5      5      .��5      ]� .+�5   
   �� $	��Top=�6   
���**��$��50��5       � DataContext 5      '  !Belote.ViewModels.PlayerViewModel  5      .+�5      �� $��Header��6   �� 5       �� Orientation$ 
Horizontal=�6   $��Center=�5      .+�5      �� $��Name:��6   �� 5      $
��Name��6   $	��5,0q�5       $	��100��5!      �� 5"      -   5         ��Name$ ButtonAddPlayer��5"      $��
Add player��5$      ��5#      �� *
AddCommand+5$      5%      5&      �� 5'   
   $��Bottom=�6   
���**��$��40��5)      .+�5*      �� $��Bottom��6   5+      �� 5,   
   
��� � �$	��200��5-      .+�5.      �� $��Reclame��6   5/      �� 50   
   $��Right=�6   
���**��$	��100��52      .+�53      �� $��Score��6   54      � 55   
   
���/��� � RowDefinitions 56      �� 57      $��2* �6    �� 58      $��4* �6    �� 59      $��2* �6     � ColumnDefinitions 5;      �� 5<      $��2* �6#   �� 5=      $��4* �6#   �� 5>      $��2* �6#   .+�5@      �� $��0��6   $��1��5A      .+�5B      �� 
���� ��$��20��61    5C        5D      .+�5F      �� ��6   �� *SelectedPlayer.Name+5G      �� 5H      
��� ��� 5I      %  Belote.ViewModels.HandViewModel  5J      .+�5L      �� #��[  5M      $��69��6J   ��5L      �� *Cards+��5N      �� 5O      .R�5P   "   �� $ 
Horizontal=�6-   5Q      5S      5T      5U      �� 5X      $��1��6   $��2��5Y      $��Computer 2 (Oost)��5Z      �� 5[      $��2��6   $��1��5\      $��Player (Zuid)��5]      �� 5^      $��1��6   $��Computer 3 (West)��5_      �� 5`      $��1��6   $��1��5a      $��Table (Midden)��5b      5c      5d      5e      