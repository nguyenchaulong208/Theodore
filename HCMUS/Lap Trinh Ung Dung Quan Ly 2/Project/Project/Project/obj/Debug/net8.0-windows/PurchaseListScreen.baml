   M S B A M L   `   `   `  ����  Project     Project.PurchaseListScreen   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  PurchaseListScreen��5   	   $	��450��6$   $	��800��61   .��5      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��10q�6.   $��0��6:   .+�5      �� -   5        $��Thêm��5      $��75��6$   $��0,0,10,0q�6/   6A   �� 5      -   5        $��Sửa��5      $��75��6#   $��0,0,10,0q�6.   6@   �� 5      -   5        $
��Xóa��5      $��75��6#   6.   �� 5      $��Danh sách mua hàng��6   $��20(�61   $
��Bold"�6?   $��Center=�6Q   $��20,0,0,0q�6l   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ purchaseList��5         AutoGenerateColumns$ False��5         CanUserAddRows$ False��5      $��1��5      $��10q�5      $��Stretch=�5         
IsReadOnly$
 True��5       $��Stretch=�5!         Columns 5#      0  *System.Windows.Controls.DataGridTextColumn  5$      ,  &System.Windows.Controls.DataGridColumn   Header$	 STT��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 50 6O   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 62   �� *
STT_view+6O     5%      $ 	Mã Hàng��6%   $		 100 6Y   
 66   �� *ProductId_view+6Y     5&      $ 
Tên Hàng��6%   $	 * 6\   
 67   �� *ProductName_view+6\     5'      $ Đơn vị tính��6%   $		 100 6X   
 6:   �� *	Unit_view+6X     5(      $ Số lượng��6%   $		 100 6Y   
 67   �� *Quantity_view+6Y     5)      $ 
Đơn giá��6%   $		 100 6U   
 66   �� *
Price_view+6U     5*      $ Thành tiền��6%   $		 100 6X   
 69   �� *
Total_view+6X     5+      $ Số hóa đơn��6%   $		 150 6]   
 69   �� *PurchaseId_view+6]     5,      $ Ngày hóa đơn��6%   $		 150 6`   
 6;   �� *InvoiceDate_view+6`     5-      $ Thương hiệu��6%   $		 150 6]   
 6:   �� *BrandName_view+6]   5/      50      51      