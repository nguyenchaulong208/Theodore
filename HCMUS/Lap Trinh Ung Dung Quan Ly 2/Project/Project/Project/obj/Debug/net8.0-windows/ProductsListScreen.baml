   M S B A M L   `   `   `  ����B  >Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ProjectProject  5   	        Project.ProductsListScreen   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Project     5   	     � Title$  ProductsListScreen��5   	   $	��450��6$   $	��800��61   .��5
      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��DANH MỤC HÀNG HÓA��6   $��18(�5      $
��Bold"�6"   $��Center=�5      $	��Top=�61   $��0��5      $��	0,10,0,10q�6!   �� 5   
    �� Orientation$ 
Horizontal=�6   $
��Left=�6.   $��	10,0,0,10q�6I   $��1��6\   .+�5      �� -   5        $��Thêm��5      $��83��6$   $��0,0,10,0q�6/   6A   �� 5      -   5        $
��Xóa��5      $��83��6#   $��0,0,10,0q�6.   6@   �� 5      -   5        $��Sửa��5      $��83��6#   $��0,0,10,0q�6.   6@   �� 5       -   5        $��
Làm mới��5       $��83��6'   62   5!      &   System.Windows.Controls.DataGrid  5$   
   -   5          Name$ productsList��5$      $��Stretch=�5%      $��Stretch=�5&      $��2��5'      $��10q�6      AutoGenerateColumns$ False��5(         CanUserAddRows$ False��5)         CanUserDeleteRows$ False��5*         
IsReadOnly$
 True��5+   
      Columns 5-      0  *System.Windows.Controls.DataGridTextColumn  5/      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Mã hàng hóa��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 200 6Z   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� *ProductCode+6Z     50      $	 Tên hàng hóa��6%   $	
 350 6[    6;   �� *ProductName+6[     51      $	 Đơn vị tính��6%   $	
 100 6Z    6:   �� *ProductUnit+6Z     52      $	 Loại hàng��6%   $	
 100 6^    68   �� *CategoryProductId+6^     53      $	 Mô tả��6%   $
 * 6\    64   �� *CategoryDescription+6\     54      $	 Hình ảnh��6%   $
 * 6X    67   �� *ProductImage+6X   56      58      59      