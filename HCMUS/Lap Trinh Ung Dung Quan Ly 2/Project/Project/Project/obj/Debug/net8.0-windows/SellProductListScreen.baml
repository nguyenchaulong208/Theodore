   M S B A M L   `   `   `  ����B  >Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ProjectProject  5   	   #    Project.SellProductListScreen   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Project     5   	     � Title$  SellProductListScreen��5   	   $	��450��6'   $	��800��64   .��5	      � .+�5
   
   �� $#��BẢNG KÊ PHIẾU XUẤT KHO��6   $��Center=�62   $	��Top=�6O   $��0,10,0,0q�6g   $��18(�5      $
��Bold"�6   �� 5   
    �� Orientation$ 
Horizontal=�6   $
��Left=�6.   $	��Top=�6I   $��	10,50,0,0q�6a   .+�5      �� -   5        $��Thêm��5      $��83��6$   6/   �� 5      -   5        $
��Xóa��5      $��83��6#   $��10,0,0,0q�6.   6@   �� 5      -   5        $��Sửa��5      $��83��6#   $��10,0,0,0q�6.   6@   �� 5      -   5        $��
Làm mới��5      $��83��6'   $��10,0,0,0q�62   6D   �� 5      -   5        $��Xuất Excel��5      $��83��6*   $��10,0,0,0q�65   6G   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ productSellList��5         AutoGenerateColumns$ False��5         
IsReadOnly$
 True��5      $��10,102,10,10q�5         Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6)      Header$ Chọn��64      CellTemplate 5      �� 5      .R�5      �� 	 ��Name$	 
selectItem��6'   $��Center=�6\   $��Center=�6y   
 d� 	IsChecked
 6;   �� *
IsSelected+6y   5      5!      0  *System.Windows.Controls.DataGridTextColumn  5"      $	 STT��6)   $ * 6S   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *
STT_view+6S     5#      $ Mã Phiếu Xuất��6%   $ * 6\    6<   �� *SellId_view+6\     5$      $ Ngày Xuất��6%   $ * 6]    68   �� *InvoiceDate_view+6]     5&      $ Tổng Số Lượng��6%   $ * 6^    6<   �� *Quantity_view+6^     5'      $ Tổng Giá Trị��6%   $ * 6Z    6;   �� *
Total_view+6Z   5,      5-      5.      