   M S B A M L   `   `   `  ����W  SComunicación Seríal Micros, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Comunicación_Seríal_MicrosComunicación_Seríal_Micros  5   	   -    'Comunicación_Seríal_Micros.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:Comunicación_Seríal_Micros     5   	     � Title$  
MainWindow��5   	   $	��250��6   $	��800��6)   .��5	      � -   5         �Name$ grdPrincipal��5	       � RowDefinitions 5
   
   �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� $3��-Interfaz De Control De Motor A Pasos 28BYJ-48��6   $��30(�5      $��Center=�5      $��Center=�5      $
��Bold"�5      $��0��5      $��3��5      � 5   
   $��0��6   $��2��6   $��
0,62,266,0q�63   $��2��6G    5      �� 5      $��* �6#   �� 5      $
��1.5* �6#   �� 5      $��* �6#   .+�5       �� -   5         ��Name$ lblOff��5       $	��OFF��5!      $��0��5"      $��35(�5#      $��Center=�5$      $��Right=�5%      �� 5&      -   5         ��Name$ chkEncender��5&      $��Center=�5'      $��Center=�5(      $��1��5)      ��5,      �� 5-       �� 
TargetType" ��6&   .R�5.      �� $	��100��6!   $��50��6-   
���   �$��2q�6M    �� CornerRadius$ 25��6a   #��z��6s   ._�5/      � .+�50   "   ��  ��Name$ SwitchBackground��6,   
�������	 �� RadiusX$	 20��6R   
 �� RadiusY$
 20��6_   A� 51   "    A�Name$ SwitchCircle��6*   
�������$��50��6M   $��50��6X   $
��Left=�6d   52      53       �� Triggers 54      P� 55       P� Property �@d�	IsChecked P� Value$
 TrueY�6;   . �56   "   ��  �� 
TargetName$ SwitchBackground��6)    �� Property � �� �� Value
 � � �6W   �� 57   "   $ SwitchCircle��6)    � ��$ Right=�6b   58      5:      5<      �� 5=      -   5        $ lblOn��5=      $��ON��5>      $��2��5?      $��35(�5@      $��Center=�5A      $
��Left=�5B      5C      � 5D   
   $��1��6   $��1��5E      $��Center=�5F      $��Center=�5G       5H      �� 5I      �� 5J      $
��110* �6     5L      �� 5M      $��* �6#   �� 5N      $��* �6#   .+�5Q      A� -   5        $ ledOff��5Q      $��1��5R      $	��100��5S      $	��100��5T      $��Center=�5U      $��Center=�5V      A� 5W      -   5        $ ledOn��5W      $��1��5X      $��1��5Y      $	��100��5Z      $	��100��5[      $��Center=�5\      $��Center=�5]      5^      �� 5`   
    �� Orientation$ Vertical=�6   $��2��5a      $��1��5b      $��Center=�5c      .+�5d      �� -   5         ��Name$ cmbSerialPorts��5d      $��1��5e      $��2��5f      $��5,0,5,0q�5g      �� 5h      -   5         ��Name$ 
btnConnect��5h      $��Conectar��5i      $��25q�5j      5k      5l      5n      5o      