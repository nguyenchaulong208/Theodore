   M S B A M L   `   `   `  ���� B  >Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ProjectProject  #    Project.SellProductListScreen   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:Project       � Title$  SellProductListScreen��$	��450��$	��800��.��� .+��� $#��BẢNG KÊ PHIẾU XUẤT KHO��$��Center=�$	��Top=�$��0,10,0,0q�$��18(�$
��Bold"���  �� Orientation$ 
Horizontal=�$
��Left=�$	��Top=�$��	10,50,0,0q�.+��� -   $��Thêm��$��83���� -   $
��Xóa��$��83��$��10,0,0,0q��� -   $��Sửa��$��83��$��10,0,0,0q��� -   $��
Làm mới��$��83��$��10,0,0,0q��� -   $��Xuất Excel��$��83��$��10,0,0,0q�&   System.Windows.Controls.DataGrid  -     Name$ productSellList��   AutoGenerateColumns$ False��   
IsReadOnly$
 True��$��10,102,10,10q�   Columns 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 50    Header$ Chọn��   CellTemplate �� .R��� 	 ��Name$	 
selectItem��$��Center=�$��Center=�
 d� 	IsChecked
 �� *
IsSelected+0  *System.Windows.Controls.DataGridTextColumn  $	 STT��$ * 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
STT_view+  $ Mã Phiếu Xuất��$ *  �� *SellId_view+  $ Ngày Xuất��$ *  �� *InvoiceDate_view+  $ Tổng Số Lượng��$ *  �� *Quantity_view+  $ Tổng Giá Trị��$ *  �� *
Total_view+