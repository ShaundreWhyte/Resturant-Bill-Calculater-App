   M S B A M L   `   `   `  ����S  ORestaurantBillCalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:RestaurantBillCalculatorRestaurantBillCalculator  5   	   )    #RestaurantBillCalculator.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:RestaurantBillCalculator     5   	     � Title$   Restaurant Bill Calculater��5   	   $��526.488��6,   $	��725��6=   .��5	      � -   5         �Name$ 	orderList��5	      #��� ��6    � ColumnDefinitions 5
   
   �� 5      $��0* �6   �� 5      .+�5   
   �� $��	Appetizer��6   $
��Left=�6%   $��
399,47,0,0q�6@   $	��Top=�6T   $��2��6l   �� 5   
   -   5         ��Name$ AppetizerCombo��5      $��2��5      $
��Left=�5      $��
372,78,0,0q�5      $	��Top=�5      $	��120��5      $��22��5      ��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� ��6$   �� *Name+5      5      5      �� 5   
   $��2��6   $��	Beverages��6$   $
��Left=�68   $��	55,47,0,0q�6S   $	��Top=�6f   �� 5    
   -   5        $ beverageCombo��5       $��2��5!      $
��Left=�5"      $��	30,78,0,0q�5#      $	��Top=�5$      $	��120��6+    J� RenderTransformOrigin$ -1.455,-0.295&�5%      $��22��5'      ��5(      �� 5)      .R�5*      �� $ 
Horizontal=�6!   .+�5+      �� ��6$   �� *Name+5,      5-      5/      �� 51   
   $��2��6   $��Dessert��6$   $��Right=�66   $��	0,47,68,0q�6R   $	��Top=�6e   �� 52   
   -   5        $ DessertCombo��52      $��2��53      $
��Left=�54      $��
573,78,0,0q�55      $	��Top=�56      $	��120��57      $��22��59      ��5:      �� 5;      .R�5<      �� $ 
Horizontal=�6!   .+�5=      �� ��6$   �� *Name+5>      5?      5A      �� 5B   
   $��2��6   $��Main_Course��6&   $
��Left=�6<   $��
221,47,0,0q�6W   $	��Top=�6k   �� 5C   
   -   5        $ 	MainCombo��5C      $��2��5D      $
��Left=�5E      $��
200,78,0,0q�5F      $	��Top=�5G      $	��120��6+   $ -2.492,-0.07&�5H      $��22��5J      ��5K      �� 5L      .R�5M      �� $ 
Horizontal=�6!   .+�5N      �� ��6$   �� *Name+5O      5P      5R      �� 5S   
   -   5         ��Name$ btnClear��5S      $��2��6#   $��Clear��67   $
��Left=�6G   $��600,237,0,0q�6b   $	��Top=�6w   $��75��6�   5U      �� 5W   
   $��2��6   $��	Subtotal:��5X      $
��Left=�5Y      $��328,327,0,0q�5Z      $	��Top=�5[      �� 5\   
   -   5         ��Name$ subtxt��5\      $
��left=�5]      $��447,306,0,0q�5^      $
��Wrap=�5_      $	��Top=�5`      �� 5b   
   $��2��6   $
��Tax:��6$   $
��Left=�63   $��328,353,0,0q�6N   $	��Top=�6c   �� 5c   
   -   5        $
 taxT��5c      $
��Left=�6"   $��447,353,0,0q�6=   $
��Wrap=�6R   $	��Top=�6f   �� 5e   
   $��2��6   $��Total:��5f      $
��Left=�5g      $��328,387,0,0q�5h      $	��Top=�5i      $ 1.337,0.654&�5j      �� 5l   
   $��Bottom=�6   $��2��5m      $��Bottom=�5n      $��43��60   .@�5o      �� -	   5         ��Name$
 Name��5o      $��	330,0,0,0q�5p      	 �� TextWrapping$
	 Wrap=�5r      $��Shaundre Whyte 300873223��6*   $	��165��6J   �� 5s      -
   5        $ btnCentennial��5t      $��30��5u      $��85��5v      $��Right=�5x      $��0q�5y      .��5z      �� $��cc.png��6   5{      5|      �� 5}   
   5      �� 5�   
   -   5        $ btRemove��5�      $��2��6#   $��Remove��67   $
��Left=�6H   $��600,278,0,0q�6c   $	��Top=�6x   $��75��6�   6�   �� 5�   
   -   5        $��2��5�      $��Order��5�      $
��Left=�5�      $��600,195,0,0q�5�      $	��Top=�5�      $��75��5�      5�      �� 5�   
   -   5        $ TxtSub��5�      $��2��5�      $
��Left=�5�      $��23��5�      $��390,322,0,0q�6   $
	 Wrap=�5�      $	��Top=�6&   $	��120��5�      �� 5�   
   -   5        $ txttax��5�      $��2��5�      $
��Left=�5�      $��23��5�      $��390,356,0,0q�6   $
	 Wrap=�5�      $	��Top=�5�      $	��120��5�      $ 0.494,-0.137&�5�      �� 5�   
   -   5        $ txtTotal��5�      $��2��5�      $
��Left=�5�      $��23��5�      $��390,390,0,0q�6   $
	 Wrap=�5�      $	��Top=�5�      $	��120��5�      &   System.Windows.Controls.DataGrid  5�   
   -   5        
  Name$
 dataGridOrder��5�      $��2��5�      $
��Left=�5�         AutoGenerateColumns .  $	��185��5�      $��
29,132,0,0q�5�      $	��Top=�5�      $	��500��5�         Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      -   5        
NameColumn��,  &System.Windows.Controls.DataGridColumn   Header$
 Name��5�   %      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 5�   %      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 5�   %   �� *Name+5�   %     5�      -   5        CategoryColumn��$ Category��5�   %   $ * 5�   %    .  5�   %   �� *
Category+5�   %     5�      -   5        PriceColumn��$ Price��5�   %   $ * 5�   %    .  5�   %   �� *Price+5�   %   5�      �� 5�   
   -   5        $ btnLogin��5�      $��2��5�      $��Login��6!   $
��Left=�61   $��530,418,0,0q�6L   $	��Top=�6a   $��75��6y   6�   �� 5�   
   -   5        $	��btn��5�      $��1��6!   $ Vertical=�6.   � 5�   
   $��2��6   $
��Left=�6*   $��10��6E   $	��Top=�6Q   $	��100��6i   5�      5�      