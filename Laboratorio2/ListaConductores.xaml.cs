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
    /// Lógica de interacción para ListaConductores.xaml
    /// </summary>
    public partial class ListaConductores : Window
    {
        public ListaConductores()
        {
            InitializeComponent();

            List<Conductores> conductores = new List<Conductores>

        {
            new Conductores{ pesoMaximo = "50" , placa ="50" , pesoVacio = "100" },

        };


            dataGrid.ItemsSource = conductores;
        }

        

    }
}
