   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApp1.WindowsWpfApp1.Windows  5   	   #    WpfApp1.Windows.SimulatorView   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfApp1.Windows     5   	     � Title$  SimulatorView��5	   	   $	��600��6   $	��600��6,   .��5      �  � RowDefinitions 5   
   �� 5      $
��0.6* �6   6,   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6    � ColumnDefinitions 5   
   �� 5      $
��0.6* �6   6.   �� 5      6!   .+�5   
   ��  �� TextAlignment$ Center=�6   $��Welcome To Simulator��6,   $��2��6H   $��24(�6\   $��0��6j   �� 5   
   $��1��6   $��Client Name:��6!   $��30(�65   $��0��6C   6U   �� 5   
   $��1��6.   $��1��6<   $��30(�6L   ��6   �� *
clientName+6]   �� 5    
   $��2��6   $��Client Line:��6!   $��30(�65   $��0��6C   6U   �� 5!   
   -   5         ��Name$ 
LinesCombo��5!       J� 	AllowDrop . $��1��5"   $   $��2��64   ��5!   (   �� *Lines+5"   4   �� 5$   
   $��Min Duraition:��6   $��3��6*   $��0��68   $��30(�6H   6Y   �� 5%   
   $��3��6/   $��30(�6<   $��1��6J   ��6   �� *minDuration+6\   �� 5'   
   $��Man Duraition:��6   $��4��6*   $��30(�67   $��0��6E   6W   �� 5(   
   $��4��6/   $��30(�6<   $��1��6J   ��6   �� *maxDuration+6\   �� 5*   
   $��Number Of Calls/SMS:��6   $��0��60   $��30(�6@   $��5��6N   6]   �� 5+   
   $��5��6.   $��30(�6;   $��1��6I   ��6   �� *
numOfCalls+6[   �� 5-   
   $��Destenation:��6   $��6��6)   $��0��66   $��30(�6F   6V   �� 5.   
   $��6��6,   $��30(�69   $��1��6G   ��6   �� *
destCall+6Y   �� 50   
   $��7��6   $��Simulate��6   $��2��6V   ��62   �� *simulateCommand+6l   53      54      