   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5          WpfApp1.search   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp1     5        N� Title$  search��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��124* �6   �� 5      $	��83* �6   �� 5      $
��243* �6   ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6   � 5      $ 	#FF15D1CA��6    � Offset$ 1Q�61   5      .+�5   
   �� -   5         ��Name$ search_text��5      $
��Left=�6'   $��	72,54,0,0q�6B    �� TextWrapping$
 Wrap=�6U   $�� ��6i   $	��Top=�6q   $	��396��6�   $��54��6�   $��Arial Black)�6�   $��24(�6�   �� 5   
   -   5        $��search��5      $
��Left=�6#   $	��Top=�6>   $��61��6V   $	��136��6b   $��Arial Black)�6n   $��24(�6�   $��
536,47,0,0q�6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	data_grid��5      $��0,18,0,0q�6Q   $��2��6c   �� 5   
   -   5        	 ��Name$	 combo��5      $
��Left=�6"   $��
544,24,0,0q�6=   $	��Top=�6Q   $	��120��6i   $��1��6u   .@�5      �� .��6   order6"   �� 5      .��6   staff6"   �� 5      .��6   food6!   �� 5      .��6   branch6#   �� 5      .��6   
customer6%   5       �� 5!   
   $��
search for��6   
�������$
��Left=�68   $��
450,22,0,0q�6S   $	��Top=�6g   $��1��6   5$      5%      