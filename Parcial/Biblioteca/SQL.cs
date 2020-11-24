using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Excepciones;


namespace Biblioteca
{
    public class SQL
    {
        private static SqlConnection sqlConnection;
        private static SqlCommand sqlCommand;
        string connectionString = "Server=.\\sqlexpress;Database=PedidosDB;Trusted_Connection=True;";
        public SQL()
        {
            sqlConnection = new SqlConnection(connectionString);
        }
        
        public static void InstertarProducto(Pedido pedido)
        {
            try
            {
                string command = "INSERT INTO Pedidos(TipoEntrega,Tipo) VALUES (@tipoentrega,@tipo);";
                sqlCommand = new SqlCommand(command, sqlConnection);


                sqlCommand.Parameters.AddWithValue("tipoentrega", pedido.Entrega.ToString());
                sqlCommand.Parameters.AddWithValue("tipo", pedido.Tipo.ToString());
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                throw new ExcepcionesArchivos("Falla al intentar trabajar sobre la base de datos", e);
            }
            finally
            {
                sqlConnection.Close();
            }
            

            

        }
        
        /*public List<Producto> ListarProductos()
        {
            using(SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string command = "SELECT * FROM Productos";

                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
            }
        }*/

    }
}
