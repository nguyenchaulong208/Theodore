   M S B A M L   `   `   `  ����H  DDemoContainer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:DemoContainerDemoContainer  5   	   F BWpfLibrary1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null>.clr-namespace:WpfLibrary1;assembly=WpfLibrary1WpfLibrary1 63       DemoContainer.MainWindow   5      N JFluent, Version=11.0.0.0, Culture=neutral, PublicKeyToken=3e436e32a8c5546fFluenturn:fluent-ribbon  W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:DemoContainer     5   	   Fwpflibrary1.clr-namespace:WpfLibrary1;assembly=WpfLibrary1     63     � Title$  
MainWindow��5   	   $	��450��6   $
��1053��6)   .��5	      ]� .+�5
   
     Fluent.Ribbon  -   5        $��ribbon��5
      $	��Top=�6&      Menu 5        Fluent.Backstage  5        Fluent.RibbonControl   Header$
 File��6#      Content. 5         Fluent.BackstageTabControl  .@�5        Fluent.BackstageTabItem     Header$ Option1��62     5      $ Option2��62     5      $ Option3��62     5      $ Option4��62   5      5         Tabs. 5        Fluent.RibbonTabItem     Header$ 	Dashboard��6#      Groups. 5        Fluent.RibbonGroupBox  $��Group 1��6(   .@�5        Fluent.Button     Header$ Button 1��6$   	   Icon	 5      �� 5      $��/Images/excel.png��6$   
 �� BitmapScalingMode$
 HighQuality=�6?   5        5      $ Button 2��6$   	 5      �� 5      $"��/Images/microsoft-access.png��6$   $
 HighQuality=�6J   5       5!      5"        5#      $ Products��6#   . 5$        $��Group 1��6(   .@�5%        $ Button 2��6$   	 5&      �� 5'      $"��/Images/microsoft-access.png��6$   $
 HighQuality=�6J   5)      5*      5+        5,      $ Orders��6#   . 5-        $��Group 1��6(   .@�5.        $ Button 1��6$   	 5/      �� 50      $��/Images/excel.png��6$   $
 HighQuality=�6?   52      53      54        55      $ Reports��6#   . 56        $��Group 1��6(   .@�57        $ Button 1��6$   	 58      �� 59      $��/Images/excel.png��6$   $
 HighQuality=�6?   5;        5<      $ Button 2��6$   	 5=      �� 5>      $"��/Images/microsoft-access.png��6$   $
 HighQuality=�6J   5@      5A      5B      5C      �� 5D   
   $��Bottom=�6   
�������$��30��6>   .@�5E      � -   5        $��loading��5E   1    � IsIndeterminate$
 True��6   $��50��6@   $��10��6K   �� 5F      -   5         ��Name$ statusTextBlock��5F      $��Ready��61   
�������6>   5G      �� 5H   
   $��0q�6    �� SelectedIndex 6)   ��  �� ElementName$ ribbon�� �� Path$ SelectedTabIndex� � 	Resources 5I       �� 
TargetType �� Property �� Value �� 
TargetType��%{   '��       �� 5J      " ��6   .�5K      ��  � �� 5L      �� 5M      " ��6.   5N      5P      5Q      5R      .@�5T      �� $��	Dashboard��6   .��5U      � .+�5V       �   � Source$ 
Page1.xaml?�6     � NavigationUIVisibility$ Hidden=�60   5W      5X      �� 5Z      $��Products��6   .��5[      ]� $
��True��6   .+�5\      �� $	��Kim��6    
�������$��30��6>   $	��Top=�6J   �� 5]      $��Thủy��6    
����  �$��30��6>   $��Bottom=�6J   �� 5^      $��Mộc��6    
��� � �$	��100��6>   $��Right=�6J   �� 5_      
��� ���$	��100��65   $
��left=�6A   .+�5`      �� $��Settings��6!   ��5a      �� 5b   "   " ��62   .R�5c   &   �� �� 5d      5e   '   5f   #   ��5h      �� 5i   "   " ��6(   .�5j   &   ��  � ��
 ��  �6C    �� Triggers 5k   &   P� 5l   *    P� Property �@J�IsMouseOver P� Value$
 true��6I   . �5m   .   ��  � ��
 �  ��6K   5n   +   5p   #   5r      5s      � 5t       � RowDefinitions 5u      �� 5v      $��50 �6,   �� 5w      $	��100 �6,   �� 5x      $��* �6,    � ColumnDefinitions 5z      �� 5{      $��1* �6/   �� 5|      $��2* �6/   �� 5}      $��3* �6/   .+�5      �� $��2��6$   $��0��61   
���  ��6A   �� 5�      $��1��6$   $��1��61   
��� ���6A   �� 5�      $��0��6$   $��0��61   
���� ��6A   �� 5�      $��2��6$   $��2��61   
����  �6A   5�      5�      5�      �� 5�      $��Orders��6   .��5�      '	   !DemoContainer.CategoryUserControl	  5�      �� 5�      $��Report��6   .��5�      &
    DemoContainer.ProductUserControl
  5�      5�      5�      5�      