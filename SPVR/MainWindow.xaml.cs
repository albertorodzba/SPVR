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
using System.Windows.Threading;
using System.Windows.Media.Animation;

namespace SPVR
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Boolean isHidden = false;
        Storyboard ocultarMenu, mostrarMenu;
        Grid gridVentana;
        Grid gridContenido;
        Grid menu;
        ListView listaMenu;
        public MainWindow()
        {
            InitializeComponent();
            ocultarMenu =(Storyboard) this.FindResource("OcultarMenu");
            mostrarMenu = (Storyboard)this.FindResource("MostrarMenu");
            gridVentana = mainGrid;
            menu = menuLateral;
            gridContenido = contenido;
            listaMenu = ListaOpciones;
            

        }
       

        private void UserControl_a_mostrar(UserControl e)
        {
            ventanaServicio.Visibility = Visibility.Collapsed;
            ventanaRewards.Visibility = Visibility.Collapsed;
            ventanaConfiguracion.Visibility = Visibility.Collapsed;

            e.Visibility = Visibility.Visible;
        }
        
        

        private void ServicioItem_Selected(object sender, RoutedEventArgs e)
        {
            UserControl_a_mostrar(ventanaServicio);
            //VistaServicio Servicio = new VistaServicio();
            //Console.WriteLine("Seleccionado Servicio");
            //contenido.Children.Add(Servicio);
            //menu.Opacity = 0.0;
  
        }

        private void RewardItem_Selected(object sender, RoutedEventArgs e)
        {
            UserControl_a_mostrar(ventanaRewards);
        }

        private void ConfigItem_Selected(object sender, RoutedEventArgs e)
        {
            UserControl_a_mostrar(ventanaConfiguracion);
        }

        private void Ocultar_click(object sender, RoutedEventArgs e)
        {
            if (isHidden == true)
            {
                mostrarMenu.Begin();
                isHidden = false;
                
            }
            else
            {
                ocultarMenu.Begin();
                isHidden = true;
               
            }
        }
    }

    
}
