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
using System.Data.SqlClient;
using System.Data;

namespace SPVR.Windows
{
    /// <summary>
    /// Lógica de interacción para ConfiguraciónPlatillos.xaml
    /// </summary>
    /// 
    class Platillos
    {
        //Campos
        public string clave { get; set; }
        public string categoria { get; set; }
        public string platillo { get; set; }
        public string descripcion { get; set; }
        public string precio { get; set; }



        //Constructor
        public Platillos(string Clave, string Categoria, string Platillo, string Descripcion, string Precio)
        {
            this.clave = Clave;
            this.categoria = Categoria;
            this.platillo = Platillo;
            this.descripcion = Descripcion;
            this.precio = Precio;
        }
    }

    public partial class ConfiguraciónPlatillos : Window
    {
        FormularioConfigPlatillos formularioConfig;
        Platillos p;
        public string clave, categoria, platillo, descripcion, precio;

        MetodosSql metodosSql;

        public ConfiguraciónPlatillos()
        {
            InitializeComponent();
            metodosSql = new MetodosSql();
            int count = metodosSql.countData();

            if (count<=0)
            {
                MessageBox.Show("No hay datos para mostrar, haga un alta nuevo", "SIN DATOS");
            }
            else
            {
                metodosSql.showDataInTable(tablaPlatillos);
            }
         
        }

        private void AgregarProducto_Click(object sender, RoutedEventArgs e)
        {
            formularioConfig = new FormularioConfigPlatillos(tablaPlatillos);
            formularioConfig.ShowDialog();
        }


        //private void tablaPlatillos_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        //{
        //    formularioConfig.ShowDialog();
        //    if (formularioConfig.DialogResult == true)
        //    {
        //        clave = formularioConfig.txtClave.Text;
        //        categoria = clave = formularioConfig.txtCategoria.Text;
        //        platillo = formularioConfig.txtPlatillo.Text;
        //        descripcion = formularioConfig.txtDescripcion.Text;
        //        precio = formularioConfig.txtPrecio.Text;

        //        p = new Platillos(clave, categoria, platillo, descripcion, precio);
        //        Console.WriteLine(p.clave + p.categoria + p.platillo + p.descripcion + p.precio);
        //        tablaPlatillos.Items.Add(p);

        //    }

        //}
    }
}
