   M S B A M L   `   `   `  ����L  HRegistroPrestamos, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:RegistroPrestamos.UI.RegistrosRegistroPrestamos.UI.Registros  5   	   .    (RegistroPrestamos.UI.Registros.rPersonas   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:RegistroPrestamos.UI.Registros     5   	     � Title$  Personas��5   	   $	��330��6   $	��450��6'    � WindowStartupLocation$ CenterScreen=�63   .��5	      � .+�5
   
   ��  �� Orientation$ Vertical=�6   $��15q�6,   .+�5      �� $ 
Horizontal=�6   .+�5      �� $��
PersonaId:��6   $
��Bold"�6.   �� 5      -   5         ��Name$ PersonasIdTextBox��5      $	��100��6P   ��65   �� *	PersonaId+6P   �� 5      -   5         ��Name$ BuscarButton��5      $	��100��60   $��30��6<   $��	100,0,0,0q�6c   .��5      �� $ 
Horizontal=�6!   .+�5      �� $��/Resources/Buscar.png��6    $��25��6@   �� 5      $��Buscar��6    $
��Bold"�61   5      5      5      �� 5      $��Nombres:��6   $
��Bold"�6(   $��0,10,0,0q�6:   �� 5      -   5        $ NombresTextBox��5      $��25��6G   ��6.   �� *	Nombres+6G   �� 5      $��Balance��6   $
��Bold"�6'   $��0,10,0,0q�6:   �� 5      -   5        $ BalanceTextBox��5      $��25��6G   ��6.   �� *	Balance+6G   �� 5!      $��Fecha��6   $
��Bold"�6%   $��0,10,0,0q�67   (  "System.Windows.Controls.DatePicker  5"      -   5          Name$ FechaDatePicker��5"      $��27��6Q      SelectedDate 62   �� *Fecha+6Q   �� 5$      $ 
Horizontal=�6   $��0,20,0,0q�62   $��Center=�6D   .+�5&      �� -   5        $ NuevoButton��5&      $	��100��6/   .��5'      �� $ 
Horizontal=�6!   .+�5(      �� $��/Resources/Nuevo.png��6    $��25��6?   �� 5)      $��Nuevo��6    $
��Bold"�60   5*      5+      �� 5.      -   5        $ GuardarButton��5.      $	��100��60   $��50,0,0,0q�6X   .��5/      �� $ 
Horizontal=�6!   .+�50      �� $��/Resources/Guardar.png��6    $��25��6A   �� 51      $��Guardar��6    $
��Bold"�62   52      53      �� 56      -   5        $ EliminarButton��56      $	��100��62   $��50,0,0,0q�6[   .��57      �� $ 
Horizontal=�6!   .+�58      �� $��/Resources/Eliminar.png��6    $��25��6B   �� 59      $��Eliminar��6    $
��Bold"�63   5:      5;      5<      5=      5>      5?      