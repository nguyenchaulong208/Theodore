   M S B A M L   `   `   `  ���� B  >Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ProjectProject  #    Project.EditSellProductScreen   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:Project       � Title$  EditSellProductScreen��$	��450��$	��800��.��� $��10q� � RowDefinitions �� $
��Auto ��� $��* ��� $
��Auto �.+���  �� Orientation$ Vertical=�$��0��$��0,0,0,10q�.+��� $��Thông Tin Phiếu Xuất��$
��Bold"�$��16(��� $ 
Horizontal=�$��0,5,0,0q�.+��� $��Ngày xuất: ��$	��100��$��Center=��� -    ��Name$ InvoiceDatePicker��$	��200���� $ 
Horizontal=�$��0,5,0,0q�.+��� $��Số phiếu xuất: ��$	��100��$��Center=��� -   $ 
editSellId��$	��200��&   System.Windows.Controls.DataGrid  -     Name$ editProductSell��$��1��   AutoGenerateColumns$ False��   CanUserAddRows$
 True��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Mã sản phẩm��	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 100 1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 �� *SellProductId+   EditingElementStyle ��  �� 
TargetType" ��.�-     $ Tên sản phẩm��$		 150 
 �� *SellProductName+  $ Số lượng��$		 100 
 �� *SellQuantity+  $ 	Giá bán��$		 120 
 �� *	SellPrice+  $ Thành tiền��$		 120 
 �� *	SellTotal+�� $ 
Horizontal=�$��2��$��Right=�$��0,10,0,0q�.+��� -   $��Lưu Phiếu Xuất��$	��120��$��5q��� -   $��Hủy��$	��120��$��5q�