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
    /// Lógica de interacción para FormularioConfigPlatillos.xaml
    /// </summary>
    public partial class FormularioConfigPlatillos : Window
    {
        
        Platillos p;
        int clave;
        string categoria, platillo, descripcion;
        float precio;
        MetodosSql metodosSql;
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.CadenaDeConexion);
        DataGrid tablaDataGrid;

        public FormularioConfigPlatillos(DataGrid DataGrid)
        {
            InitializeComponent();
            metodosSql = new MetodosSql();
            tablaDataGrid = DataGrid;
        }

        
        private void BotonGuardar_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;

            //Obtiene los datos de los textbox
            clave = int.Parse(txtClave.Text);
            categoria = txtCategoria.Text;
            platillo = txtPlatillo.Text;
            descripcion = txtDescripcion.Text;
            precio = float.Parse(txtPrecio.Text);

            //Se tiene que validar que los campos sean ingresados correctamente
            if (true)
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;

                command.CommandText = "insert into [Platillos] (Clave , Categoria, Platillo, Descripcion, Precio) values ('" + clave +"', ' " + categoria +" ', '"+platillo+" ', '"+descripcion+"','"+precio+"')";
                command.ExecuteNonQuery();
                connection.Close();

                metodosSql.showDataInTable(tablaDataGrid);

            }
            //Guardar en base de datos y actualizar
            this.Close();
        }

        private void BotonCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
