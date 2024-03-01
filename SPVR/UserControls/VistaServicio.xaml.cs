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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace SPVR
{
    /// <summary>
    /// Lógica de interacción para VistaServicio.xaml
    /// </summary>
    public partial class VistaServicio : UserControl
    {
        int numeroMesas = 8;
        int contador = 1;
        Button mesa;
        public VistaServicio()
        {
            InitializeComponent();
        }

        private void AbrirMesa_Click(object sender, RoutedEventArgs e)
        {
            mesa = new Button();
            Thickness margin = mesa.Margin;
            margin.Left = 10;
            margin.Bottom = 10;
            mesa.Margin = margin;
            mesa.Height = 70;
            mesa.Width = 70;
            mesa.Content = "Mesa " + contador.ToString();
            mesa.Template = this.FindResource("OrangeButton") as ControlTemplate;
            wrapPanelMesas.Children.Add(mesa);
            contador++;
        }
    }
}
