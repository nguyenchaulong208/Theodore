   M S B A M L   `   `   `  ����B  >Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ProjectProject  5   	       Project.SellProductSceen   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Project     5   	     � Title$  SellProductSceen��5   	   $	��450��6"   $	��800��6/    � WindowStartupLocation$ CenterScreen=�5	   	   .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   ��  �� Orientation$ Vertical=�6   $��0��6,   $��0,0,0,10q�69   .+�5      �� $��Thông Tin Phiếu Xuất��6   $
��Bold"�64   $��16(�6F   �� 5      $ 
Horizontal=�6   $��0,5,0,0q�62   .+�5      �� $��Ngày xuất: ��6   $	��100��6/   $��Center=�6;   �� 5      -   5         ��Name$ InvoiceDatePicker��5      $	��200��65   5      �� 5      $ 
Horizontal=�6   $��0,5,0,0q�62   .+�5      �� $��Số phiếu xuất: ��6   $	��100��63   $��Center=�6?   �� 5      -   5        $ orderId��5      $	��200��6+   5      5      &   System.Windows.Controls.DataGrid  5    
   -   5          Name$ ProductDataGrid��5       $��1��6-      AutoGenerateColumns$ False��6:      CanUserAddRows$
 True��6V      Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Mã sản phẩm��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 100 6\   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� *SellProductId+   EditingElementStyle 5#      �� 5$       �� 
TargetType" ��6    .�5%      -   5        5&      5(        5)      $	 Tên sản phẩm��6%   $	
 150 6_    6;   �� *SellProductName+6_     5*      $	 Số lượng��6%   $	
 100 6X    67   �� *SellQuantity+6X     5+      $	 	Giá bán��6%   $	
 120 6T    66   �� *	SellPrice+6T     5,      $	 Thành tiền��6%   $	
 120 6W    69   �� *	SellTotal+6W   5.      �� 51   
   $ 
Horizontal=�6   $��2��6.   $��Right=�6;   $��0,10,0,0q�6W   .+�52      �� -   5        $��Lưu Phiếu Xuất��52      $	��120��6.   $��5q�6:   6E   �� 53      -   5        $��Hủy��53      $	��120��6#   $��5q�6/   6:   54      55      56      