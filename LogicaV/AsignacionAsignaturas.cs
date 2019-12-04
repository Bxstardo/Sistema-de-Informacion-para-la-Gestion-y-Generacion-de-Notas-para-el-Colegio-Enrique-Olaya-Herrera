using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosV;
using System.Data;

namespace LogicaV
{
    public class AsignacionAsignaturas : Conexion
    {

        private int identificaciondoc;
        private int id_asignacionasignatura;
        private int id_asignatura;


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

        public int Id_AsignacionAsignatura
        {
            get { return id_asignacionasignatura; }
            set { id_asignacionasignatura = value; }
        }

        public bool InsertarAsignacionAsignatura(string Nombre)
        {
            string ProcedimientoInsertar = "EXEC InsertarAS @IdentificacionDoc = " + this.identificaciondoc + ",@Asignatura = '" + Nombre + "'";

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }
        public bool EliminarAsignacionAsignatura(string Nombre)
        {
            string ProcedimientoInsertar = "EXEC EliminarAS @IdentificacionDoc = " + this.identificaciondoc + ",@Asignatura = '" + Nombre + "'";

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }


    }
}
