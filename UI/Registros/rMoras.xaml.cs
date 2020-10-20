using System;
using System.Windows;
using RegistroPrestamos.BLL;
using RegistroPrestamos.Entidades;

namespace RegistroPrestamos.UI.Registros
{
    public partial class rMoras : Window
    {
        private Moras moras = new Moras();
        public rMoras()
        {
            InitializeComponent();
            this.DataContext = moras;

            PrestamoIdDetalleComboBox.ItemsSource = PrestamosBLL.GetPrestamo();
            PrestamoIdDetalleComboBox.SelectedValuePath = "PrestamoId";
            PrestamoIdDetalleComboBox.DisplayMemberPath = "Concepto";
        }

        //CARGAR
        private void Cargar()
        {
            this.DataContext = null;
            this.DataContext = moras;
        }

        //LIMPIAR
        private void Limpiar()
        {
            this.moras = new Moras();
            this.DataContext = moras;
        }

        //VALIDAR
        private bool Validar()
        {
            bool Validado = true;
            if (MoraIdTextbox.Text.Length == 0)
            {
                Validado = false;
                MessageBox.Show("Transaccion Errada", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            return Validado;

        }

        //BUSCAR
        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            Moras encontrado = MorasBLL.Buscar(moras.MoraId);

            if (encontrado != null)
            {
                moras = encontrado;
                Cargar();
            }
            else
            {
                MessageBox.Show($"Esta Id de Articulo no fue encontrada.\n\nAsegurese que existe o cree una nueva.", "ERROR", MessageBoxButton.OK, MessageBoxImage.Warning);
                Limpiar();
            }
        }

        //AGREGAR FILA
        private void AgregarFilaButton_Click(object sender, RoutedEventArgs e)
        {
            var filaDetalle = new MorasDetalle
            {
                MoraId = this.moras.MoraId,
                PrestamoId = Convert.ToInt32(PrestamoIdDetalleComboBox.SelectedValue),
                Valor = Convert.ToSingle(ValorTextBox.Text)

            };
            moras.Total += Convert.ToDouble(ValorTextBox.Text.ToString());

            this.moras.Detalle.Add(filaDetalle);
            Cargar();


            ValorTextBox.Clear();
        }

        //REMOVER FILA
        private void RemoverFilaButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (DetalleDataGrid.Items.Count >= 1 && DetalleDataGrid.SelectedIndex <= DetalleDataGrid.Items.Count - 1)
                {
                    moras.Detalle.RemoveAt(DetalleDataGrid.SelectedIndex);
                    moras.Total -= Convert.ToDouble(TotalMorasTextBox.Text);
                    Cargar();
                }
            }
            catch
            {
                MessageBox.Show("No has seleccionado ninguna Fila\n\nSeleccione la Fila a Remover.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        //NUEVO
        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }
        //GUARDAR
        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            {
                if (!Validar())
                    return;

                var paso = MorasBLL.Guardar(moras);
                if (paso)
                {
                    Limpiar();
                    MessageBox.Show("Transaccion Exitosa", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                    MessageBox.Show("Transaccion Errada", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        //ELIMINAR
        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            {
                if (MorasBLL.Eliminar(Utiidades.ToInt(MoraIdTextbox.Text)))
                {
                    Limpiar();
                    MessageBox.Show("Registro Eliminado", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                    MessageBox.Show("No se pudo eliminar", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}