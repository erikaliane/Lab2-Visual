using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Laboratorio2
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void RegistroSali(object sender, RoutedEventArgs e)
        {
            RegistroSalida registro_s= new RegistroSalida();
            this.Close();
            registro_s.Show();
        }

        private void RegistroCamiones(object sender, RoutedEventArgs e)
        {

            RegistroCamiones registro_s = new RegistroCamiones();
            this.Close();
            registro_s.Show();

        }

        private void ListaConductores(object sender, RoutedEventArgs e)
        {

            ListaConductores registro_s = new ListaConductores();

            this.Close();
            registro_s.Show();
        }
        private void ListaSalida(object sender, RoutedEventArgs e)
        {

        }



    }
}
