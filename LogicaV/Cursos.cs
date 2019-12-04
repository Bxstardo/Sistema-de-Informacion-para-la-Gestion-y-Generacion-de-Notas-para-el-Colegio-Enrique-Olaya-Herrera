using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosV;
using System.Data;

namespace LogicaV
{
    public class Cursos : Conexion
    {

        private string num_curso;
        private string nivel;
        private string jornada;
        private int identificacionest;
        private int identificaciondoc;
        private int id_curso;

        public int Id_Curso
        {
            get { return id_curso; }
            set { id_curso = value; }
        }


        public string Num_Curso
        {
            get { return num_curso; }
            set { num_curso = value; }
        }

        public string Nivel
        {
            get { return nivel; }
            set { nivel = value; }
        }

        public string Jornada
        {
            get { return jornada; }
            set { jornada = value; }
        }

        public int IdentificacionEst
        {
            get { return identificacionest; }
            set { identificacionest = value; }
        }

        public int IdentificacionDoc
        {
            get { return identificaciondoc; }
            set { identificaciondoc = value; }
        }

        public bool InsertarCurso()
        {
            string ProcedimientoInsertar = "EXEC InsertarCurso @Num_Curso = " + this.Num_Curso + ",@Nivel = '" + this.Nivel + "', @Jornada = '" + this.Jornada + "'";

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }

        public bool InsertarCursoEst()
        {
            string ProcedimientoInsertar = "EXEC InsertarCursoEst @Num_Curso = " + this.Num_Curso + ",@IdentificacionEst = '" + this.IdentificacionEst + "', @Jornada = '" + this.Jornada + "'";

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }

        public bool InsertarCursoDoc()
        {
            string ProcedimientoInsertar = "EXEC InsertarCursoDoc @Num_Curso = " + this.Num_Curso + ",@IdentificacionDoc = '" + this.IdentificacionDoc + "', @Jornada = '" + this.Jornada + "'";

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }

        public bool EliminarCurso()
        {
            string ProcedimientoInsertar = "EXEC EliminarCurso @Id_Curso = '" + Id_Curso + "'";

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }

        public bool EliminarCursoD()
        {
            string ProcedimientoInsertar = "EXEC EliminarCursoD  @Num_Curso = " + this.Num_Curso + ",@IdentificacionDoc = '" + this.IdentificacionDoc + "', @Jornada = '" + this.Jornada + "'";

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }

        public DataSet ConsultarCurso(string Valor, string Columna)
        {
            string ProcedimientoDeConsulta = "EXEC ConsultarCurso @Valor = '" + Valor + "', @Columna = '" + Columna + "'";

            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }

        public DataSet ConsultarCurso2(string Valor1, string Valor2, string Columna)
        {
            string ProcedimientoDeConsulta = "EXEC ConsultarCurso2 @Valor1 = '" + Valor1 + "', @Valor2 = '" + Valor2 + "', @Columna = '" + Columna + "'";

            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }


        public DataSet ConsultarCEst()
        {
            string ProcedimientoDeConsulta = "EXEC ConsultarCEst @Id_Curso = '" + Id_Curso + "'";

            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }


        public DataSet ConsultarCursoTodos()
        {
            string ProcedimientoDeConsulta = "select * from Curso";

            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }

        public bool ActualizarCurso()
        {
            string ProcedimientoInsertar = "EXEC ActualizarCurso @Num_Curso = " + this.Num_Curso + ",@Nivel = '" + this.Nivel + "', @Jornada = '" + this.Jornada + "', @Id_Curso = '" + this.Id_Curso + "'";

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }

        public DataSet ConsultarDocenteCurso(string valor)
        {
            string ProcedimientoDeConsulta =
                "select D.IdentificacionDoc as Usuario_Docente , C.Num_Curso as Dirige , C.Jornada from Docente as D inner join Curso as C on C.Id_Curso = D.Id_Curso Where D.Estado = 'Activo' and C.Id_Curso = '" + valor + "'";

            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }

        public DataSet ConsultarEstudianteCurso(string valor)
        {
            string ProcedimientoDeConsulta =
                "select D.IdentificacionEst as Usuario_Estudiante , C.Num_Curso as Curso , C.Jornada from Estudiante as D inner join Curso as C on C.Id_Curso = D.Id_Curso Where D.Estado = 'Activo' and C.Id_Curso = '" + valor + "'";

            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }

    }
}
