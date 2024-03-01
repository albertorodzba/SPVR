using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using SPVR.Windows;

namespace SPVR
{

    public partial class VistaConfiguraciones : UserControl
    {
        ConfiguraciónPlatillos platillosWindows;
        public VistaConfiguraciones()
        {
            InitializeComponent();
            
        }

       

        private void ConfigPlatillos_Click(object sender, RoutedEventArgs e)
        {
            platillosWindows = new ConfiguraciónPlatillos();
            platillosWindows.Show();

        }
    }
}
