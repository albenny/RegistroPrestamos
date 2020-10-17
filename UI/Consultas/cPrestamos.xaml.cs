using System.Collections.Generic;
using System.Windows;
using RegistroPrestamos.BLL;
using RegistroPrestamos.Entidades;

namespace RegistroPrestamos.UI.Consultas
{
    public partial class cPrestamos : Window
    {
        private Prestamos prestamos = new Prestamos();
        public cPrestamos()
        {
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, RoutedEventArgs e)
        {
            Datos.ItemsSource = null;
            var listado = new List<Prestamos>();

            if (DesdeDate.SelectedDate != null)
            {
                listado = PrestamosBLL.GetList(c => c.Fecha.Date >= HastaDate.SelectedDate);
            }
            else
            {
                listado = PrestamosBLL.GetList(c => true);
            }

            if (HastaDate.SelectedDate != null)
            {
                listado = PrestamosBLL.GetList(c => c.Fecha.Date <= HastaDate.SelectedDate);
            }
            else
            {
                listado = PrestamosBLL.GetList(c => true);
            }
            Datos.ItemsSource = listado;
        }
    }
}