   M S B A M L   `   `   `  ����H  DDemoContainer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:DemoContainerDemoContainer  5   	       DemoContainer.MainWindow   5      N JFluent, Version=10.0.0.0, Culture=neutral, PublicKeyToken=3e436e32a8c5546fFluenturn:fluent-ribbon  W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:DemoContainer     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $
��1053��6)    � 	Resources 5	      /  )DemoContainer.RelativeToAbsoluteConverter   	absoluter��%   &	          5
   
   6,   5      .��5      ]� .+�5   
     Fluent.Ribbon  -   5        $��ribbon��5         SelectedTabIndex$ 1��6&   $	��Top=�6;      Menu 5        Fluent.Backstage  5        Fluent.RibbonControl   Header$
 File��6#      Content. 5         Fluent.BackstageTabControl  .@�5        Fluent.BackstageTabItem     Header$ Option1��62     5      $ Option2��62     5      $ Option3��62     5      $ Option4��62   5      5         Tabs. 5        Fluent.RibbonTabItem     Header$ 	Dashboard��6#   	   Groups.	 5        Fluent.RibbonGroupBox  $��Group 1��6(   .@�5      	  Fluent.Button	  
 	  Header$
 Button 1��6$    	  Icon 5      �� 5      $��/Images/excel.png��6$    �� BitmapScalingMode$ HighQuality=�6?   5      	  5      $
 Button 2��6$    5       �� 5!      $"��/Images/microsoft-access.png��6$   $ HighQuality=�6J   5#      5$      5%        5&      $ Products��6#      
IsSelected$
 True��65   .	 5'        $��Group 1��6(   .@�5(      	  -   5        $	
 Add��5(   $    5)      �� 5*      $��/Images/plus.png��6$   $ HighQuality=�6>   5,      	  5-      -   5        $
 Delete��5-   $    5.      �� 5/      $��/Images/delete.png��6$   $ HighQuality=�6@   51      	  52      -   5        $

 Edit��52   $    53      �� 54      $��/Images/edit.png��6$   $ HighQuality=�6>   56      57      58        59      $ Orders��6#   .	 5:        $��Group 1��6(   .@�5;      	  $
 Button 1��6$    5<      �� 5=      $��/Images/excel.png��6$   $ HighQuality=�6?   5?      5@      5A        5B      $ Reports��6#   .	 5C        $��Group 1��6(   .@�5D      	  $
 Button 1��6$    5E      �� 5F      $��/Images/excel.png��6$   $ HighQuality=�6?   5H      	  5I      $
 Button 2��6$    5J      �� 5K      $"��/Images/microsoft-access.png��6$   $ HighQuality=�6J   5M      5N      5O      5P      �� 5Q   
   $��Bottom=�6   
�������$��30��6>   .@�5R      � -   5        $��loading��5R   1    � IsIndeterminate$
 True��6   $��50��6@   $��10��6K   �� 5S      -   5         ��Name$ statusTextBlock��5S      $��Ready��61   
�������6>   5T      �� 5U   
   $��0q�6    �� SelectedIndex 6)   ��  �� ElementName$ ribbon�� �� Path$ SelectedTabIndex� 5V       �� 
TargetType �� Property �� Value �� 
TargetType��%{   '��       �� 5W      " ��6   .�5X      ��  � �� 5Y      �� 5Z      " ��6.   5[      5]      5^      5_      .@�5a      �� $��	Dashboard��6   .��5b      � .+�5c       �   � Source$ 
Page1.xaml?�6     � NavigationUIVisibility$ Hidden=�60   5d      5e      �� 5g      $��Products��6   .��5h      ]� $
��True��6   .+�5i      �� $	��Kim��6    
�������$��30��6>   $	��Top=�6J   �� 5j      $��Thủy��6    
����  �$��30��6>   $��Bottom=�6J   �� 5k      $��Mộc��6    
��� � �$	��100��6>   $��Right=�6J   �� 5l      
��� ���$	��100��65   $
��left=�6A   .+�5m      �� $��Settings��6!   ��5n      �� 5o   "   " ��62   .R�5p   &   �� �� 5q      5r   '   5s   #   ��5u      �� 5v   "   " ��6(   .�5w   &   ��  � ��
 ��  �6C    �� Triggers 5x   &   P� 5y   *    P� Property �@J�IsMouseOver P� Value$
 true��6I   . �5z   .   ��  � ��
 �  ��6K   5{   +   5}   #   5      5�      �� 5�      -   5        $��dataListView��5�      $��Disabled=�63    5�        TenCuaContextMenu m� Icon��%�  &	       �� 5�      .@�5�   "   m� -	   5        $��View detail��5�   +    5�   &   �� 5�   *   $��/Images/excel.png��60   $ HighQuality=�6K   5�   #   m� 5�   "   -
   5        $��Delete��5�   +    5�   &   �� 5�   *   $��/Images/delete.png��60   $ HighQuality=�6L   5�   #   m� 5�   "   -   5        $
��Edit��5�   +    5�   &   �� 5�   *   $��/Images/edit.png��60   $ HighQuality=�6J   5�   #   5�      5�      ��5�      �� 5�      " ��6$   .�5�   "   ��  �@�ContextMenu# [ 6@   -   5        5�      ��5�      �� 5�      .R�5�   "   � 5�      ��5�      �� 5�      .R�5�   "   �� $	��100��6-   $	��100��69   .+�5�   &   �� $��40��6,   $��40��67   ��6C   �� *Avatar+ �� 	Converter# [  �� 5�   &   �� 5�   *   �6.   �� *ID+-�� 6E   �6I   �� *Name+5�   '   � 5�   &    � Minimum$ 0Q�62   $��10��6X   $	��100��6d    � Maximum$	 140Q�6p     � Value  6>   �� *	Credits+6p   5�   #   5�      5�      5�      5�      �� 5�      $��Orders��6   .��5�      '
   !DemoContainer.CategoryUserControl
  5�      �� 5�      $��Report��6   .��5�      &    DemoContainer.ProductUserControl  5�      5�      5�      5�      