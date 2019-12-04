using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Biblioteca
{
    class Conexion
    {
        public SqlConnection getConexion()
        {
            try
            {
                string cadena = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Proyecto_Notas;Integrated Security=True";
                SqlConnection cnn = new SqlConnection(cadena);
                cnn.Open();
                return cnn;
            }
            catch (Exception)
            {

                return null;
            }

        }
    }
}

