   M S B A M L   `   `   `  ���� K  GPendulumSimGraph, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:PendulumSimGraphPendulumSimGraph  M+clr-namespace:PendulumSimGraph.UserControlsPendulumSimGraph.UserControls  !    PendulumSimGraph.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     0localclr-namespace:PendulumSimGraph     :uc+clr-namespace:PendulumSimGraph.UserControls       � Title$  
MainWindow��$	��320��$	��500��.���  � ColumnDefinitions �� $	��100 ��� $
��Auto � � RowDefinitions �� $	��200 ��� .+��� -    ��Name$ stcPanelData��$��0��$��2��.+��� $��	Length: r�� �� TextAlignment$
 Left=�$	��5,0q��� -    ��Name$ 
txtbRadius��$��40��$��5q��� $��Teta: 0���� -   $ txtbTeta��$��45��$��5q��� $��Omega: w���� -   $ 	txtbOmega��$��5q��� $��Time:���� -   $ txtbTime��$��5q��� -   $��Start��$��5q��� $��X���� -   $ Xp���� $��Y���� -   $ Yp���� -	    ��Name$ rysownik��$��5q�$��1��$��0��.+��� -
    ��Name$ wahadlo��	 �� X1$ 0��		 �� Y1$	 0��	
 �� X2$
 30��	 �� Y2$ 40��$��4�� �� Left$	 200����
�  
� GradientOrigin$ 0.5,0.5&� 
� Center$ 0.5,0.5&� 
� RadiusX$	 0.5Q� 
� RadiusY$	 0.5Q����  � Color$	 Red�� � Offset$ 0Q�� $
 Blue��$
 0.25Q�A� -    A�Name$
 Mass��$��20��$��20��
 �� Top$ 30��
���  �� ��  �� ElementName$ wahadlo���� -   $	 Vxy��$y�Hidden=�$
 30��$	 100��$	 200�� �� $ wahadlo�� �� Path$ X2�	 �� $ wahadlo��$ Y2�����  �� Color$ 	DarkGreen��� $��1��$��1��$	��300��.+��� -   $ 	drawGraph��