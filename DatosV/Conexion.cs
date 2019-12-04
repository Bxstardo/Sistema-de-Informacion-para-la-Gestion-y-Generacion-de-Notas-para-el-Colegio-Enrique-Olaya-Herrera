using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DatosV
{
    public class Conexion
    {
        private string mensaje; SqlConnection conn; public string Mensaje { get { return mensaje; } set { mensaje = value; } }

        public Conexion()
        {
            String cadenaconexion = @"Data Source=DESKTOP-GFI9B2I;Initial Catalog=NotasEOH2;Integrated Security=True";
            conn = new SqlConnection(cadenaconexion);
        }
        public DataSet ConsultarSQL(String SentenciaSQL)
        {
            try
            {
                conn.Open();

                SqlDataAdapter objRes = new SqlDataAdapter(SentenciaSQL, conn);
                DataSet datos = new DataSet();

                objRes.Fill(datos, "DatosConsultados");
                mensaje = "La consulta de datos fue Exitosa"
                    ;


                return datos;
            }
            catch (Exception MiExc)
            {
                DataSet datos2 = new DataSet(); mensaje = "ERROR: " + MiExc.Message; return datos2;

            }
            finally { conn.Close(); }
        }

        public bool EjecutarSQL(String SentenciaSQL)
        {
            try
            {
                conn.Open();

                SqlCommand miComando = new SqlCommand();
                miComando.Connection = conn;
                miComando.CommandText = SentenciaSQL;
                miComando.ExecuteNonQuery();

                mensaje = "Proceso Ejecutado con Exito";
                return true;
            }
            catch (Exception e) { mensaje = "Se presento el siguiente error " + e.Message; return false; }
            finally { conn.Close(); }
        }
    }
}
