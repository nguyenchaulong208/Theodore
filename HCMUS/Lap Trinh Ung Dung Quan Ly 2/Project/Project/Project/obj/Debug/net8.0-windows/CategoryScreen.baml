   M S B A M L   `   `   `  ����B  >Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ProjectProject  5   	       Project.CategoryScreen   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Project     5   	     � Title$  Danh mục hàng hóa��5   	   $	��450��6#   $	��800��60    � WindowStartupLocation$ CenterScreen=�5	   
   .��5      � .+�5   
   �� $��DANH MỤC HÀNG HÓA��6   $��Center=�6-   $	��Top=�6J   $��0,10,0,0q�6b   $��18(�5      $
��Bold"�6"   �� 5   
    �� Orientation$ 
Horizontal=�6   $
��Left=�6.   $	��Top=�6I   $��	10,50,0,0q�6a   .+�5      �� -   5        $��Thêm��5      $��83��6$   6/   �� 5      -   5        $
��Xóa��5      $��83��6#   $��10,0,0,0q�6.   6@   �� 5      -   5        $��Sửa��5      $��83��6#   $��10,0,0,0q�6.   6@   �� 5      -   5        $��
Làm mới��5      $��83��6'   $��10,0,0,0q�62   6D   5      � 5   
   $	��Top=�6   $��10,100,10,10q�6'    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $��* �6    .+�5"      � $��0��6    � ColumnDefinitions 5#      �� 5$      $	��200 �6'   �� 5%      $	��350 �6'   �� 5&      $
��Auto �6'   .+�5(      �� -   5         ��Name$ searchCategoryId��5(      $	��190��64   $��5q�6@   $��Center=�6K   5)      �� 5*      -   5        $ searchCategoryName��5*      $��1��66   $	��340��6F   $��5q�6R   $��Center=�6]   5+      �� 5,      -   5        $ searchCategoryDescription��5,      $��2��6=   $
��Auto��6M   $��
5,5,-220,5q�6Z   $��Center=�6n   5-      5.      �� 51      -   5         ��Name$ categoryList��51      $��1��6-    �� View 52      �� 53      .P�54      �� $��MÃ DANH MỤC��6)    �� Width$	 200��6>   	 �� DisplayMemberBinding	 6J   �� *
CategoryId+�� 55      $��TÊN DANH MỤC��6)   $	 350��6?   	 6K   �� *CategoryName+�� 56      $��MÔ TẢ��6)   $
 Auto��68   	 6E   �� *CategoryDescription+57      59      5:      5;      5<      