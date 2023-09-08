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
    /// Lógica de interacción para RegistroSalida.xaml
    /// </summary>
    public partial class RegistroSalida : Window
    {
        public RegistroSalida()
        {
            InitializeComponent();
        }

        private void Regresar(object sender, RoutedEventArgs e)
        {
            Window1 menu = new Window1();
            this.Close();
            menu.Show();
        }
    }
}
