   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��300��6)    � 
ResizeMode$ NoResize=�65   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��0.3 �6   6+   �� 5      6   .+�5   
   �� $��0,7.667,-0.333,401q�6    �� TextAlignment$ Center=�60   $��Welcome To CRM��6G   $��24(�6]   $��1��6k   �� 5   
   $��1��6   $��
User Name:��6!   $��30(�63   $��0,0.667,-0.333,-1q�6A   6^   �� 5   
   $��1��6   $��0,39.667,-0.333,-1q�69   $��30(�6U   ��6   �� *
Username+6f   �� 5   
   $��1��6   $��	Password:��6!   $��0,79.667,-0.333,-1q�62   $��30(�6N   6^   G� 5   
   -   5         G�Name$ PasswordTbx��5      $��1��6+    G� Password$ 123456��68   $��0,119.667,-0.333,-1q�6J   $��30(�6h   6x   �� 5   
   $��1��6   $��0,227.667,-0.333,60q�6   $��Sign In��6;   $��30(�6M   ���	#FF81FF81��6[   �� *loginCommand+��6|   ��  �� ElementName$ PasswordTbx��6�   5      5      