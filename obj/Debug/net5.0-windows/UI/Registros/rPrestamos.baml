   M S B A M L   `   `   `  ����L  HRegistroPrestamos, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:RegistroPrestamos.UI.RegistrosRegistroPrestamos.UI.Registros  5   	   /    )RegistroPrestamos.UI.Registros.rPrestamos   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:RegistroPrestamos.UI.Registros     5   	     � Title$  Prestamo��5      $	��430��6   $	��450��6&    � WindowStartupLocation$ CenterScreen=�62   .��5	      � .+�5
   
   ��  �� Orientation$ Vertical=�6   $��15q�6,   .+�5      �� $ 
Horizontal=�6   .+�5      �� $��PrestamoId:��6   $
��Bold"�6/   �� 5      -   5         ��Name$ PrestamoIdTextBox��5      $	��100��6Q   ��65   �� *
PrestamoId+6Q   �� 5      -   5         ��Name$ BuscarButton��5      $	��100��60   $��30��6<   $��	100,0,0,0q�6c   .��5      �� $ 
Horizontal=�6!   .+�5      �� $��/Resources/Buscar.png��6    $��25��6@   �� 5      $��Buscar��6    $
��Bold"�61   5      5      5      �� 5      $��	PersonaId��6   $
��Bold"�6)   $��0,10,0,0q�6;   �� 5      -   5         ��Name$ PersonasIdComboBox��5      $	��100��6W   $��25��6c   $
��Left=�6o    �� SelectedValue 63   �� *	PersonaId+6o   �� 5      $��Concepto��6   $
��Bold"�6(   $��0,5,0,0q�6:   �� 5      -   5        $ ConceptoTextBox��5      $��25��6I   ��6/   �� *
Concepto+6I   �� 5!      $��Balance��6   $
��Bold"�6'   $��0,5,0,0q�69   �� 5"      -   5        $ BalanceTextBox��5"      $��25��6G   ��6.   �� *	Balance+6G   �� 5%      $��Monto��6   $
��Bold"�6%   $��0,5,0,0q�67   �� 5&      -   5        $ MontoTextBox��5&      $��25��6C   ��6,   �� *Monto+6C   �� 5)      $��Fecha��6   $
��Bold"�6%   $��0,5,0,0q�67   (  "System.Windows.Controls.DatePicker  5*      -   5          Name$ FechaTextBox��5*      $��25��6N      SelectedDate 6/   �� *Fecha+6N   �� 5,      $ 
Horizontal=�6   $��0,20,0,0q�62   $��Center=�6D   .+�5.      �� -   5        $ NuevoButton��5.      $	��100��6/   .��5/      �� $ 
Horizontal=�6!   .+�50      �� $��/Resources/Nuevo.png��6    $��25��6?   �� 51      $��Nuevo��6    $
��Bold"�60   52      53      �� 56      -	   5        $ GuardarButton��56      $	��100��60   $��50,0,0,0q�6X   .��57      �� $ 
Horizontal=�6!   .+�58      �� $��/Resources/Guardar.png��6    $��25��6A   �� 59      $��Guardar��6    $
��Bold"�62   5:      5;      �� 5>      -
   5        $ EliminarButton��5>      $	��100��62   $��50,0,0,0q�6[   .��5?      �� $ 
Horizontal=�6!   .+�5@      �� $��/Resources/Eliminar.png��6    $��25��6B   �� 5A      $��Eliminar��6    $
��Bold"�63   5B      5C      5D      5E      5F      5G      