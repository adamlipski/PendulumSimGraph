   M S B A M L   `   `   `  ����K  GPendulumSimGraph, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:PendulumSimGraphPendulumSimGraph  5   	   M+clr-namespace:PendulumSimGraph.UserControlsPendulumSimGraph.UserControls  5   	   !    PendulumSimGraph.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:PendulumSimGraph     5   	   :uc+clr-namespace:PendulumSimGraph.UserControls     5   	     � Title$  
MainWindow��5   	   $	��320��6   $	��500��6)   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��100 �6   6-   �� 5      $
��Auto �6   6.    � RowDefinitions 5   
   �� 5      $	��200 �6   �� 5      .+�5   
   �� -   5         ��Name$ stcPanelData��5      $��0��6+   $��2��6;   .+�5      �� $��	Length: r��6    �� TextAlignment$
 Left=�6)   $	��5,0q�6>   6M   �� 5      -   5         ��Name$ 
txtbRadius��5      $��40��6*   $��5q�64   �� 5      $��Teta: 0��6   6)   �� 5      -   5        $ txtbTeta��5      $��45��6(   $��5q�62   �� 5      $��Omega: w��6   6*   �� 5      -   5        $ 	txtbOmega��5      $��5q�6)   �� 5       $��Time:��6   6'   �� 5!      -   5        $ txtbTime��5!      $��5q�6(   �� 5"      -   5        $��Start��5"      $��5q�6%   5#   ,   �� 5$      $��X��6   �� 5%      -   5        $ Xp��5%      �� 5&      $��Y��6   �� 5'      -   5        $ Yp��5'      5)      �� 5+   
   -	   5         ��Name$ rysownik��5+      $��5q�6#   $��1��6.   $��0��6>   .+�5/      �� -
   5         ��Name$ wahadlo��5/      	 �� X1$ 0��50      		 �� Y1$	 0��6   	
 �� X2$
 30��51      	 �� Y2$ 40��6   $��4��52       �� Left$	 200��53      ��54      
� 55       
� GradientOrigin$ 0.5,0.5&�6*    
� Center$ 0.5,0.5&�6C    
� RadiusX$	 0.5Q�6T    
� RadiusY$	 0.5Q�6b   ��57      �  � Color$	 Red��6+    � Offset$ 0Q�67   � 58      $
 Blue��6+   $
 0.25Q�68   5:      5<      A� 5>      -   5         A�Name$
 Mass��5>      $��20��5?      $��20��5@      
 �� Top$ 30��5B      
���  �� 5A      ��  �� ElementName$ wahadlo��5E      �� 5I      -   5        $	 Vxy��5I      $y�Hidden=�6    $
 30��5L      $	 100��5M      $	 200��5O       5J      �� $ wahadlo�� �� Path$ X2�	 5K      �� $ wahadlo��$ Y2���5Q      �� 5R       �� Color$ 	DarkGreen��6&   5T      5V      5X      � 5Y   
   $��1��6   $��1��6   $	��300��6,   .+�5Z      �� -   5        $ 	drawGraph��5Z      6*   5\      5^      5`      