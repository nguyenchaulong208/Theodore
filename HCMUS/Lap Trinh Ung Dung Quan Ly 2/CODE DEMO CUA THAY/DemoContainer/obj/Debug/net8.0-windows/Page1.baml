   M S B A M L   `   `   `  ����H  DDemoContainer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:DemoContainerDemoContainer  5          DemoContainer.Page1   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:DemoContainer     5      -   5          N� Title$  Page1��5	       � 	Resources 5
      0   *DemoContainer.CreditsToPercentageConverter   	converter
   Max��%'   &	          5   
   $	 155��6?   5      .��5      �� .+�5   
   �� �� 5      $�MSSV: ��6   $
��Bold"�6     �� 5      �6   �� *ID+5      �� 5   
   �� 5      $�Họ và tên: ��6   $
��Bold"�6%    �� 5      �6   �� *
Fullname+5      �� 5   
    �� Orientation$ 
Horizontal=�6   .+�5      �� $"��Số tín chỉ tích lũy: ��6   � 5      -   5        $��maxCreditsProgresbar��5       � Minimum$ 0Q�5       � Maximum$	 140Q�6&   $��
0, 2, 0, 0q�64   $	��150��5   A   $��10��6M    � Value 6   �� *	Credits+6M   �� 5      $��
5, 0, 0, 0q�6   �� 5      �6   �� *	Credits+ �� 	Converter# [  5      5      �� 5    
   -   5         ��Name$ dataTextBox��5       $	��200��6'   $��35��63   �� 5!   
   -   5        $
��Edit��5!      $��80��6    $��35��6+   67   5"      5#      