   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5          WpfApp1.show_customers   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp1     5        N� Title$  show_customers��5	      .��5      �  � RowDefinitions 5   
   �� 5      $	��74* �6   �� 5      $
��125* �6   �� 5      $	��76* �6   �� 5      $
��175* �6   ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6   � 5      $ 	#FF15D1CA��6    � Offset$ 1Q�61   5      .+�5   
   �� $��search��6   
�������$��80(�63   $
��Left=�6A   $��274,-23,0,0q�6\   $	��Top=�6q   $	��364��6�   $	��117��6�   $��2��6�   �� 5   
   -   5         ��Name$ search_t��5      $��Center=�6$    �� TextWrapping$
 Wrap=�6A   $�� ��6U   $��Center=�6]   $	��508��6x   $��75��6�   $��1��6�   �� 5   
   -   5         ��Name$ search��5      $��search��6!   ���	#FF79F9F4$��30(�6I   $��Center=�6W   $	��Top=�6t   $��66��6�   $	��336��6�   $��	0,118,0,0q�6�   $��2��6�   $��1��6�   &   System.Windows.Controls.DataGrid  5   
   -   5        	  Name$	 	data_grid��5      $	��NaN��6Q   $��0,22,0,0q�6^   $��3��6p   5      5      