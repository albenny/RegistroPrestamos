using System.Windows;
using RegistroPrestamos.UI.Registros;
using RegistroPrestamos.UI.Consultas;
using RegistroPrestamos.Entidades;

namespace RegistroPrestamos
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void rPersonasButton_Click(object sender, RoutedEventArgs e)
        {
            rPersonas rPersonas1 = new rPersonas();
            rPersonas1.Show();

        }
        private void rPrestamoButton_Click(object sender, RoutedEventArgs e)
        {
            rPrestamos rPrestamos = new rPrestamos();
            rPrestamos.Show();
        }
        private void rMorasMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rMoras rMoras = new rMoras();
            rMoras.Show();
        }
        
        private void cPersonasButton_Click(object sender, RoutedEventArgs e)
        {
            cPersonas cPersonas = new cPersonas();
            cPersonas.Show();
        }

        private void cPrestamoButton_Click(object sender, RoutedEventArgs e)
        {
            cPrestamos cPrestamos = new cPrestamos();
            cPrestamos.Show();
        }
    }
}