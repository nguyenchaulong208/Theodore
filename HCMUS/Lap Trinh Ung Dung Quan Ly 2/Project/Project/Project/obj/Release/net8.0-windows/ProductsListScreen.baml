   M S B A M L   `   `   `  ���� B  >Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ProjectProject       Project.ProductsListScreen   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:Project       � Title$  ProductsListScreen��$	��450��$	��800��.���  � RowDefinitions �� $
��Auto ��� $
��Auto ��� $��* �.+��� $��DANH MỤC HÀNG HÓA��$��18(�$
��Bold"�$��Center=�$	��Top=�$��0��$��	0,10,0,10q���  �� Orientation$ 
Horizontal=�$
��Left=�$��	10,0,0,10q�$��1��.+��� -   $��Thêm��$��83��$��0,0,10,0q��� -   $
��Xóa��$��83��$��0,0,10,0q��� -   $��Sửa��$��83��$��0,0,10,0q��� -   $��
Làm mới��$��83��&   System.Windows.Controls.DataGrid  -     Name$ productsList��$��Stretch=�$��Stretch=�$��2��$��10q�   AutoGenerateColumns$ False��   CanUserAddRows$ False��   CanUserDeleteRows$ False��   
IsReadOnly$
 True��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn	   Header$	 Mã hàng hóa��
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 200 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *ProductCode+  $	 Tên hàng hóa��$	
 350  �� *ProductName+  $	 Đơn vị tính��$	
 100  �� *ProductUnit+  $	 Loại hàng��$	
 100  �� *CategoryProductId+  $	 Mô tả��$
 *  �� *CategoryDescription+  $	 Hình ảnh��$
 *  �� *ProductImage+