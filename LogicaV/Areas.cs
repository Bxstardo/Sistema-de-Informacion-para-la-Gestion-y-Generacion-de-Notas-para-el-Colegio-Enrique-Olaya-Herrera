using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosV;
using System.Data;

namespace LogicaV
{
    public class Areas : Conexion
    {
        private int id_area;
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Id_Area
        {
            get { return id_area; }
            set { id_area = value; }
        }

        public bool InsertarArea()
        {
            string ProcedimientoInsertar = "EXEC InsertarArea @Nombre = '" + this.nombre + "'";

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }

        public DataSet ConsultarArea(string Valor, string Columna)
        {
            string ProcedimientoDeConsulta = "EXEC ConsultarArea @Valor = '" + Valor + "', @Columna = '" + Columna + "'";

            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }

        public DataSet ConsultarAreaTodos()
        {
            string ProcedimientoDeConsulta = "select Nombre from Area";

            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }

        public bool ModificarArea(string Valor, string Valor2)
        {
            string ProcedimientoInsertar = "EXEC ModificarArea @Area = '" + Valor + "', @Nombre = '" + Valor2 + "'";

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }

        public bool EliminarArea()
        {
            string ProcedimientoInsertar = "EXEC EliminarArea @Nombre = '" + this.nombre + "'";

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }



    }
}
