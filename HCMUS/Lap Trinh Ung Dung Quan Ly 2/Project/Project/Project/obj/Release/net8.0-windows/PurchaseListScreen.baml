   M S B A M L   `   `   `  ����   Project     Project.PurchaseListScreen   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006       � Title$  PurchaseListScreen��$	��450��$	��800��.���  � RowDefinitions �� $
��Auto ��� $��* �.+���  �� Orientation$ 
Horizontal=�$��10q�$��0��.+��� -   $��Thêm��$��75��$��0,0,10,0q��� -   $��Sửa��$��75��$��0,0,10,0q��� -   $
��Xóa��$��75���� $��Danh sách mua hàng��$��20(�$
��Bold"�$��Center=�$��20,0,0,0q�&   System.Windows.Controls.DataGrid  -     Name$ purchaseList��   AutoGenerateColumns$ False��   CanUserAddRows$ False��$��1��$��10q�$��Stretch=�   
IsReadOnly$
 True��$��Stretch=�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$	 STT��	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 50 1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 �� *
STT_view+  $ 	Mã Hàng��$		 100 
 �� *ProductId_view+  $ 
Tên Hàng��$	 * 
 �� *ProductName_view+  $ Đơn vị tính��$		 100 
 �� *	Unit_view+  $ Số lượng��$		 100 
 �� *Quantity_view+  $ 
Đơn giá��$		 100 
 �� *
Price_view+  $ Thành tiền��$		 100 
 �� *
Total_view+  $ Số hóa đơn��$		 150 
 �� *PurchaseId_view+  $ Ngày hóa đơn��$		 150 
 �� *InvoiceDate_view+  $ Thương hiệu��$		 150 
 �� *BrandName_view+