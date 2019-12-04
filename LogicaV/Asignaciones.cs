using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DatosV;

namespace LogicaV
{
    public class Asignaciones : Conexion
    {

        private int id_curso;
        private int id_asignatura;
        private int identificaciondoc;

        public int Id_Curso
        {
            get { return id_curso; }
            set { id_curso = value; }
        }

        public int Id_Asignatura
        {
            get { return id_asignatura; }
            set { id_asignatura = value; }
        }

        public int IdentificacionDoc
        {
            get { return identificaciondoc; }
            set { identificaciondoc = value; }
        }

        public bool InsertarAsignacion(int IdentificacionEst, string Asignatura)
        {
            string ProcedimientoInsertar = "EXEC InsertarAsignacion @IdentificacionEst = " + IdentificacionEst + ",@Asignatura = '" + Asignatura + "', @IdentificacionDoc = '" + this.identificaciondoc + "'";

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }

        public DataSet ConsultarAsignacion(string Valor, string Valor2 , string Valor3, string Columna)
        {
            string ProcedimientoDeConsulta = "EXEC ConsultarAsignacion @Columna = '" + Columna + "', @Valor = '" + Valor + "', @Valor2 = '" + Valor2 + "', @Valor3 = '" + Valor3 + "'";


            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }

    }
}
