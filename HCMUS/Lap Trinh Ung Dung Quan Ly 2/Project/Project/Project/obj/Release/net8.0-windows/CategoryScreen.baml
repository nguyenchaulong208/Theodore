   M S B A M L   `   `   `  ���� B  >Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ProjectProject      Project.CategoryScreen   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:Project       � Title$  Danh mục hàng hóa��$	��450��$	��800�� � WindowStartupLocation$ CenterScreen=�.��� .+��� $��DANH MỤC HÀNG HÓA��$��Center=�$	��Top=�$��0,10,0,0q�$��18(�$
��Bold"���  �� Orientation$ 
Horizontal=�$
��Left=�$	��Top=�$��	10,50,0,0q�.+��� -   $��Thêm��$��83���� -   $
��Xóa��$��83��$��10,0,0,0q��� -   $��Sửa��$��83��$��10,0,0,0q��� -   $��
Làm mới��$��83��$��10,0,0,0q�� $	��Top=�$��10,100,10,10q� � RowDefinitions �� $
��Auto ��� $��* �.+�� $��0�� � ColumnDefinitions �� $	��200 ��� $	��350 ��� $
��Auto �.+��� -    ��Name$ searchCategoryId��$	��190��$��5q�$��Center=��� -   $ searchCategoryName��$��1��$	��340��$��5q�$��Center=��� -   $ searchCategoryDescription��$��2��$
��Auto��$��
5,5,-220,5q�$��Center=��� -    ��Name$ categoryList��$��1�� �� View �� .P��� $��MÃ DANH MỤC�� �� Width$	 200��	 �� DisplayMemberBinding	 �� *
CategoryId+�� $��TÊN DANH MỤC��$	 350��	 �� *CategoryName+�� $��MÔ TẢ��$
 Auto��	 �� *CategoryDescription+