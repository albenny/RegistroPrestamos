   M S B A M L   `   `   `  ����L  HRegistroPrestamos, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:RegistroPrestamos.UI.RegistrosRegistroPrestamos.UI.Registros  5   	   +    %RegistroPrestamos.UI.Registros.rMoras   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:RegistroPrestamos.UI.Registros     5   	     � Title$  Registro de Moras��5   	   $	��550��6#   $	��530��60    � WindowStartupLocation$ CenterScreen=�6<   .��5	      � .+�5
   
   ��  �� Orientation$ Vertical=�6   $��15q�6,   .+�5      �� $��Mora Id��6   $
��Bold"�6&   �� 5      $ 
Horizontal=�6   .+�5      �� -   5         ��Name$ MoraIdTextbox��5      $��Center=�6I   $	��260��6k   ��61   �� *MoraId+6k   �� 5      -   5         ��Name$ BuscarButton��5      $��	100,0,0,0q�6J   $	��100��6]   .��5      �� $ 
Horizontal=�6!   .+�5      �� $��25��6    $��/Resources/buscar.png��6,   �� 5      $��Buscar��6    $
��Bold"�61   5      5      5      �� 5      $��
Fecha Mora��6   $
��Bold"�6)   $��0,10,0,0q�6;   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ FechaMoraDatePicker��5      $��30��6U      SelectedDateFormat$ Short=�6a   $��Center=�6|   $��0,0,0,10q�6�      SelectedDate 66   �� *Fecha+6�   �� 5      $ Vertical=�6   .+�5      �� $��Detalle Moras��6   $��0,5,0,0q�62   .��5      �� .+�5       �� $��Prestamo Id��6    �� 5!      -   5         ��Name$ PrestamoIdDetalleComboBox��5!   #   $	��100��6j   $
��Left=�6v   	 �� Text	 6F   �� *Detalle.PrestamoId+6v   �� 5$      $ 
Horizontal=�6%   .+�5%      �� $ Vertical=�6)   .+�5&   "   �� $��Valor��6(   �� 5'   "   -   5        $ ValorTextBox��5'   *   $	��150��6_   $��30��6k   $	��Top=�6w   ��6@   �� *Detalle.Valor+6w   5(      �� 5*      $ Vertical=�6)   $��	150,0,0,0q�6@   .+�5+   "   �� -   5        $ AgregarFilaButton��5+   )   $
��Bold"�6e   $	��120��6w   .��5,   &   �� $ 
Horizontal=�61   .+�5-   *   �� $��/Resources/Agregar.png��60   $��20��6P   �� 5.   *   $��Agregar fila��60   5/   '   50   #   �� 51   "   -   5        $ RemoverFilaButton��51   )   $��0,10,0,0q�6D   $	��120��6v   .��52   &   �� $ 
Horizontal=�61   .+�53   *   �� $��/Resources/Remover.png��60   $��20��6P   �� 54   *   $��Eliminar fila��60   $
��Bold"�6H   55   '   56   #   57      58      &   System.Windows.Controls.DataGrid  5:      -   5        
  Name$
 DetalleDataGrid��5:   #   $	��100��6<      AutoGenerateColumns$ False��6I   $��0,10,0,0q�6�   ��6e   �� *	Detalle+   Columns 5;      0  *System.Windows.Controls.DataGridTextColumn  5<   "   ,  &System.Windows.Controls.DataGridColumn   Header$ 
PrestamoId��65   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6I   �� *
PrestamoId+  5=   "   $ Valor��65    6D   �� *Valor+5?      �� 5A      $ 
Horizontal=�6%   $��Right=�6>   $��0,10,0,0q�6Z   .+�5B      �� $��Total��6$   $
��Bold"�64   �� 5C      -	   5        $ TotalMorasTextBox��5C   &   $	��100��6X    �� 
IsReadOnly$
 True��6d   $��30��6v   ��6A   �� *Total+6v   5D      5E      5F      5G      �� 5J      $ 
Horizontal=�6   $��0,5,0,0q�63   $
��Left=�6D   5L      �� 5O      $ 
Horizontal=�6   $��Center=�62   $��0,5,0,0q�6O   .+�5P      �� -
   5        $ NuevoButton��5P      $	��130��6.   .��5Q      �� $ 
Horizontal=�6!   .+�5R      �� $��25��6    $��/Resources/nuevo.png��6,   �� 5S      $��Nuevo��6    $��17(�60   $
��Bold"�6>   5T      5U      �� 5Y      -   5        $ GuardarButton��5Y      $��40,0,0,0q�60   $	��130��6B   .��5Z      �� $ 
Horizontal=�6!   .+�5[      �� $��30��6    $��/Resources/guardar.png��6,   �� 5\      $��Guardar��6    $��17(�62   $
��Bold"�6@   5]      5^      �� 5a      -   5        $ EliminarButton��5a      $��40,0,0,0q�61   $	��130��6C   .��5b      �� $ 
Horizontal=�6!   .+�5c      �� $��30��6    $��/Resources/Eliminar.png��6,   �� 5d      $��Eliminar��6    $��17(�63   $
��Bold"�6A   5e      5f      5g      5h      5i      5j      