   M S B A M L   `   `   `  ����H  DDemoContainer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:DemoContainerDemoContainer  5   	   F BWpfLibrary1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null>.clr-namespace:WpfLibrary1;assembly=WpfLibrary1WpfLibrary1 63       DemoContainer.MainWindow   5      N JFluent, Version=10.0.0.0, Culture=neutral, PublicKeyToken=3e436e32a8c5546fFluenturn:fluent-ribbon  W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:DemoContainer     5   	   Fwpflibrary1.clr-namespace:WpfLibrary1;assembly=WpfLibrary1     63   -   5          � Title$  
MainWindow��5   	   $	��450��6   $
��1053��6)    � 	Resources 5	      /  )DemoContainer.RelativeToAbsoluteConverter   	absoluter��%   &	          5
   
   6,   5      .��5      ]� .+�5   
     Fluent.Ribbon  -   5        $��ribbon��5      $	��Top=�6&      Menu 5        Fluent.Backstage  5        Fluent.RibbonControl   Header$
 File��6#      Content. 5         Fluent.BackstageTabControl  .@�5        Fluent.BackstageTabItem     Header$ Option1��62     5      $ Option2��62     5      $ Option3��62     5      $ Option4��62   5      5         Tabs. 5        Fluent.RibbonTabItem     Header$ 	Dashboard��6#      Groups. 5        Fluent.RibbonGroupBox  $��Group 1��6(   .@�5      	  Fluent.Button	  	 	  Header$	 Button 1��6$   
 	  Icon
 5      �� 5      $��/Images/excel.png��6$    �� BitmapScalingMode$ HighQuality=�6?   5      	  5      $	 Button 2��6$   
 5       �� 5!      $"��/Images/microsoft-access.png��6$   $ HighQuality=�6J   5#      5$      5%        5&      $ Products��6#   . 5'        $��Group 1��6(   .@�5(      	  $	 Button 2��6$   
 5)      �� 5*      $"��/Images/microsoft-access.png��6$   $ HighQuality=�6J   5,      5-      5.        5/      $ Orders��6#   . 50        $��Group 1��6(   .@�51      	  $	 Button 1��6$   
 52      �� 53      $��/Images/excel.png��6$   $ HighQuality=�6?   55      56      57        58      $ Reports��6#   . 59        $��Group 1��6(   .@�5:      	  $	 Button 1��6$   
 5;      �� 5<      $��/Images/excel.png��6$   $ HighQuality=�6?   5>      	  5?      $	 Button 2��6$   
 5@      �� 5A      $"��/Images/microsoft-access.png��6$   $ HighQuality=�6J   5C      5D      5E      5F      �� 5G   
   $��Bottom=�6   
�������$��30��6>   .@�5H      � -   5        $��loading��5H   1    � IsIndeterminate$
 True��6   $��50��6@   $��10��6K   �� 5I      -   5         ��Name$ statusTextBlock��5I      $��Ready��61   
�������6>   5J      �� 5K   
   $��0q�6    �� SelectedIndex 6)   ��  �� ElementName$ ribbon�� �� Path$ SelectedTabIndex� 5L       �� 
TargetType �� Property �� Value �� 
TargetType��%{   '��       �� 5M      " ��6   .�5N      ��  � �� 5O      �� 5P      " ��6.   5Q      5S      5T      5U      .@�5W      �� $��	Dashboard��6   .��5X      � .+�5Y       �   � Source$ 
Page1.xaml?�6     � NavigationUIVisibility$ Hidden=�60   5Z      5[      �� 5]      $��Products��6   .��5^      ]� $
��True��6   .+�5_      �� $	��Kim��6    
�������$��30��6>   $	��Top=�6J   �� 5`      $��Thủy��6    
����  �$��30��6>   $��Bottom=�6J   �� 5a      $��Mộc��6    
��� � �$	��100��6>   $��Right=�6J   �� 5b      
��� ���$	��100��65   $
��left=�6A   .+�5c      �� $��Settings��6!   ��5d      �� 5e   "   " ��62   .R�5f   &   �� �� 5g      5h   '   5i   #   ��5k      �� 5l   "   " ��6(   .�5m   &   ��  � ��
 ��  �6C    �� Triggers 5n   &   P� 5o   *    P� Property �@J�IsMouseOver P� Value$
 true��6I   . �5p   .   ��  � ��
 �  ��6K   5q   +   5s   #   5u      5v      �� 5w      -   5        $��dataListView��5w      $��Disabled=�63   ��5x      �� 5y      .R�5z   "   � 5{      ��5}      �� 5~      .R�5   "   �� $	��100��6-   $	��100��69   .+�5�   &   �� $��40��6,   $��40��67   ��6C   �� *Avatar+ �� 	Converter# [  �� 5�   &   �� 5�   *   �6.   �� *ID+-�� 6E   �6I   �� *Name+5�   '   5�   #   5�      5�      5�      5�      �� 5�      $��Orders��6   .��5�      '
   !DemoContainer.CategoryUserControl
  5�      �� 5�      $��Report��6   .��5�      &    DemoContainer.ProductUserControl  5�      5�      5�      5�      