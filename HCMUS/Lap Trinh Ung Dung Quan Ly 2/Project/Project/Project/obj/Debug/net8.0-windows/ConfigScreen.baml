   M S B A M L   `   `   `  ����B  >Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ProjectProject  5          Project.ConfigScreen   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:Project     5        N� Title$  ConfigScreen��5      .��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��90 �6   �� 5      $	��300 �6   .+�5   
   �� $��Server��6   $��Center=�6"   $��0��6=   $��0��6J   $��5q�6Z   �� 5    
   -   5         ��Name$ 
serverPort��5       $��30��6'   $��0��63   $��1��6@   $��5q�6P   �� 5#   
   $��Database��6   $��Center=�6$   $��1��6?   $��0��6L   $��5q�6\   �� 5$   
   -   5        $ db��5$      $��30��6   $��1��6+   $��1��68   $��5q�6H   �� 5'   
   $��Username��6   $��Center=�6$   $��2��6?   $��0��6L   $��5q�6\   �� 5(   
   -   5        $ userName��5(      $��30��6$   $��2��60   $��1��6=   $��5q�6M   �� 5+   
   $��Password��6   $��Center=�6$   $��3��6?   $��0��6L   $��5q�6\   G� 5,   
   -   5         G�Name$ 
passServer��5,      $��30��6*   $��3��66   $��1��6C   $��5q�6S   	� 5/   
   -   5         	�Name$ 
windowAuth��5/   7   $��Windows Authentication��6   $��4��6K   $��1��6X   $��5q�6h   	� 50   
   -   5        $ sqlAuht��50   :   $��SQL Server Authentication��6   $��5��6K   $��1��6X   $��5q�6h   �� 53   
   -   5         ��Name$ connectServer��53   *   $��Kết nối Server��6   $��6��54      $��1��6   $��Center=�6.   $	��Top=�6K   $	��150��6c   $��40��6o   $��10q�6{   55      56      