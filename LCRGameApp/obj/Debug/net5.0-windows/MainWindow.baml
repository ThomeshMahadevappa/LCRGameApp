   M S B A M L   `   `   `  ����  
LCRGameApp    LCRGameApp.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � DataContext$.  (LCRGameApp.ViewModel.MainWindowViewModel��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$ 
ToolWindow=�5   	    � Title$ LCR Dice Game��5
   	   $	��250��6   $	��400��6,    � 	Resources 5         
ErrorImage T� X T� Y  Key � MappingMode 
� Center	 
� RadiusX
 
� RadiusY � Color � Offset �� Left
 �� Top 
 Svgid1  TextBoxErrorTemplate �� ElementName �� Path � ToolTip��%   &	        7  &	 �    7   �� 5   
   .R�5      (� .��5      �� $��50.25��6   $��50.25��6'   z�5      T� 5      $ 0Q�6-   $ 0Q�63    5      ��
� 5      
Svgid1 $ Absolute=�6=   $ 5.9912,4.9375&�6T   $	 48.4666Q�6k   $
 48.4666Q�6}   ��5   "   � � 5   &   $ #FFFFFF��63   $ 0Q�6C   � 5   &   $ #ED2024��63   $ 1Q�6C   5   #   5      5      .+�5      A� $ 0.819000000000003��6   $ 0.822000000000003��6>   $��48.312��6]   $��48.312��6l   8��  6|   A� 5      $ 1.411000000000001��6   $ 1.411000000000001��6>   $��47.428��6]   $��47.428��6l   ���#C02026$��2.8217��6�   �� 5      .+�5      F� ���#FFFFFFC����8.Rخ��p�?��x �����ҍ=@��x Qp����/݄>@Q8.R��/݄>@	6.   5       �� 5!      $ 22.021��6    $ 34.437��65   $��6.771��6I   $��6.771��6W   ���#FFFFFF6f   5"      5#      5$      �� 5&   
   .R�5'      �� 
���  ��$��0q�6'   ._�5(      ]�   6   �� $ 	MyAdorner��$8 2AdornedElement.(Validation.Errors)[0].ErrorContent�.+�5)      �� 8��  $��Right=�5*   !   $��	-18,0,0,0q�68   $��16��6K   $��16��6V    5)   %   �� 5*   V   �� 5+      $��	MyAdorner��6B   $��0,0,-6,0q�60   6B   5,      5-      5.      5/      .��50      �  � RowDefinitions 51   
   �� 52      $
��Auto �6   �� 53      $
��Auto �6   �� 54      $
��Auto �6   �� 55      $��10 �6   �� 56      $
��Auto �6   �� 57      $
��Auto �6   �� 58      $
��Auto �6   �� 59      $
��Auto �6    � ColumnDefinitions 5;   
   �� 5<      $	��150 �6   �� 5=      $	��150 �6   �� 5>      $
��Auto �6   .+�5@   
   �� $��0��6   $��0��6!   $��No. Of People��61   $��5q�6F    �� TextAlignment$ Right=�6Q   �� 5A   
   -   5         =� ErrorTemplate# [ 5A   �   $��0��6�   $��1��6�   $��5q�6�    �� TextAlignment$
 Left=�6�   ��6   �� *NumberOfPlayers+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors$
 True��6�   �� 5B   
   $��1��6   $��0��6!   $��No. Of Games��61   $��5q�6E   $ Right=�6P   $��Stretch=�6f   $��Center=�6�   �� 5C   
   -   5        # [ 5C      $��1��6�   $��1��6�   $��5q�6�   $
 Left=�6�   ��6   �� *NumberOfGames+$ TwoWay=�$ PropertyChanged=�$
 True��6�   �� 5D   
   $��_Start Game��6   $��2��6'   $��2��64   ��6D   �� *SimulateCommand+�� 5F   
   $��4��6   $��0��6!   $��No. Of Turns��61   $��5q�6E   $ Right=�6P   �� 5G   
   $��4��6   $��1��6!   $��5q�6]   $
 Left=�6h   ��61   �� *NumberOfTurns+$ OneWay=�6h   �� 5H   
   $��5��6   $��0��6!   $��Shortest Length Game��61   $��5q�6M   $ Right=�6X   �� 5I   
   $��5��6   $��1��6!   $��5q�6\   $
 Left=�6g   ��61   �� *ShortestGame+$ OneWay=�6g   �� 5J   
   $��6��6   $��0��6!   $��Longest Length Game��61   $��5q�6L   $ Right=�6W   �� 5K   
   $��6��6   $��1��6!   $��5q�6[   $
 Left=�6f   ��61   �� *LongestGame+$ OneWay=�6f   �� 5L   
   $��7��6   $��0��6!   $��Average Length Game��61   $��5q�6L   $ Right=�6W   �� 5M   
   $��7��6   $��1��6!   $��5q�6[   $
 Left=�6f   ��61   �� *AverageGame+$ OneWay=�6f   5N      5O      