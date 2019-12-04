using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DatosV;

namespace LogicaV
{
    public class Asignaturas : Conexion
    {

        private string nombre;
        private int id_area;
        private int id_asignatura;
        

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

        public int Id_Asignatura
        {
            get { return id_asignatura; }
            set { id_asignatura = value; }
        }

        public bool InsertarAsignatura()
        {
            string ProcedimientoInsertar = "EXEC InsertarAsignatura @Nombre = '" + this.nombre + "'";

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }

        public DataSet ConsultarAsignatura(string Valor, string Columna)
        {
            string ProcedimientoDeConsulta = "EXEC ConsultarAsignatura @Valor = '" + Valor + "', @Columna = '" + Columna + "'";

            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }

        public bool AsignarArea(string Valor1, string Valor2)
        {
            string ProcedimientoInsertar = "EXEC AsignarArea @NombreAsignatura = '" + Valor1 + "', @NombreArea = '" + Valor2 + "'";

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }
        public DataSet ConsultarAS(string IdentificacionDoc)
        {
            string ProcedimientoDeConsulta = "EXEC ConsultarAS @IdentificacionDoc = '" + IdentificacionDoc + "'";

            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }

        public DataSet ConsultarAsignaturaTodos()
        {
            string ProcedimientoDeConsulta = "select Nombre from Asignatura";

            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }

        public DataSet ConsultarAsignaturaTodos3()
        {
            string ProcedimientoDeConsulta = "select Nombre as Asignatura from Asignatura";

            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }

        public DataSet ConsultarAsignaturaTodos2(string valor)
        {
            string ProcedimientoDeConsulta = "select Nombre as Asignatura from Asignatura where Nombre = '"+ valor + "'";

            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }


        public DataSet ConsultarAsignaturaAreaTodos()
        {
            string ProcedimientoDeConsulta = 
                "select Asig.Nombre as Asignatura , Area.Nombre as Area from Asignatura as Asig inner join Area as Area on Area.Id_Area = Asig.Id_Area order by Area.Nombre";

            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }

        public DataSet ConsultarAreaTodos()
        {
            string ProcedimientoDeConsulta = "select Nombre as Asignatura from Area";

            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }

        public DataSet ConsultarAsignaturaAreaTodos2(string valor)
        {
            string ProcedimientoDeConsulta =
                "select Asig.Nombre as Asignatura , Area.Nombre as Area from Asignatura as Asig inner join Area as Area on Area.Id_Area = Asig.Id_Area where Area.Nombre ='" + valor + "'";

            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }

        public bool ModificarAsignatura(string Valor, string Valor2)
        {
            string ProcedimientoInsertar = "EXEC ModificarAsignatura @Asignatura = '" + Valor + "', @Nombre = '" + Valor2 + "'";

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }

        public bool EliminarAsignatura()
        {
            string ProcedimientoInsertar = "EXEC EliminarAsignatura @Nombre = '" + this.nombre + "'";

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }

    }
}
