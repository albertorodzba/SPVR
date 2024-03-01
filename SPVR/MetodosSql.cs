using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Controls;

namespace SPVR
{
    class MetodosSql
    {
        private SqlConnection conexion;
        public MetodosSql()
        {
            //Inicializa conexion
            conexion = new SqlConnection(SPVR.Properties.Settings.Default.CadenaDeConexion);

        }

        public int countData()
        {

            conexion.Open();
            SqlCommand command = new SqlCommand("select count(*) from [Platillos]", conexion);
            int count = Convert.ToInt32(command.ExecuteScalar());
            conexion.Close();

            return count;
        }

        public void showDataInTable(DataGrid dataGrid)
        {
            conexion.Open();
            SqlCommand newCommand = conexion.CreateCommand();
            newCommand.CommandText = "select * from [Platillos]";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(newCommand);
            DataTable data = new DataTable("Platillos");
            sqlDataAdapter.Fill(data);
            dataGrid.ItemsSource = data.DefaultView;
            conexion.Close();
        }

    }
}
