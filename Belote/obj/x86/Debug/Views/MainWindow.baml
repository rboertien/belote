   M S B A M L   `   `   `  ����A  =Belote, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Belote.ModelsBelote.Models  5   	       Belote.Views.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -modelclr-namespace:Belote.Models     5   	     � Title$  Belote (klaverjassen)��5   	   $	��600��6'   $	��800��64   $	��500��6@   $	��700��6P    � 	Resources 5         playerTemplate �� DataType �� Orientation��%�   &	        �� 5   
   $
 Card��6.   .R�5      �� $ Vertical=�6   .+�5	      �� $
��Test��6   �� 5
      ��6   �� *	CardColor+5      5      5      .��5      ]� .+�5   
   �� $	��Top=�6   
���**��$��40��6=   .+�5      �� $��Header��6   5      �� 5   
   $��Bottom=�6   
���**��$��40��6@   .+�5      �� $��Bottom��6   5      �� 5   
   
��� � �$	��200��6(   .+�5      �� $��Reclame��6   5      �� 5   
   $��Right=�6   
���**��$	��100��6?   .+�5      �� $��Score��6   5      � 5   
   
���/��� � RowDefinitions 5      �� 5      $��2* �6    �� 5      $��4* �6    �� 5      $��2* �6     � ColumnDefinitions 5!      �� 5"      $��2* �6#   �� 5#      $��4* �6#   �� 5$      $��2* �6#   .+�5'      �� $��0��64   $��1��6A   #���   5)       � DataContext 5'      �� *Hand+��5(      �� *Cards+5*      �� 5-      $��1��6   $��2��6%   $��Computer 2 (Oost)��66   �� 5.      $��2��6   $��1��6%   $��Player (Zuid)��65   �� 5/      $��1��6   $��Computer 3 (West)��6%   �� 50      $��1��6   $��1��6%   $��Table (Midden)��66   51      52      53      