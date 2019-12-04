using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DatosV;

namespace LogicaV
{
    public class Docentes : Conexion
    {

        private int identificaciondoc;
        private string nombres;
        private string apellidos;
        private string direccion;
        private string eps;
        private string email;
        private string profesion;
        private string jornada;
        private string num_contacto;
        private int id_sesion;
        private int id_curso;

        public int IdentificacionDoc
        {
            get { return identificaciondoc; }
            set { identificaciondoc = value; }
        }

        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string Eps
        {
            get { return eps; }
            set { eps = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Profesion
        {
            get { return profesion; }
            set { profesion = value; }
        }

        public string Jornada
        {
            get { return jornada; }
            set { jornada = value; }
        }
        public string Num_Contacto
        {
            get { return num_contacto; }
            set { num_contacto = value; }
        }

        public int Id_Sesion
        {
            get { return id_sesion; }
            set { id_sesion = value; }
        }

        public int Id_Curso
        {
            get { return id_curso; }
            set { id_curso = value; }
        }

        public bool InsertarDocente()
        {
            string ProcedimientoInsertar = "EXEC InsertarDocente @IdentificacionDoc = " + this.identificaciondoc + ",@Nombres = '" + this.nombres + "', @Apellidos = '" + this.apellidos + "', @Direccion = '" + this.direccion + "', @Eps = '" + this.eps + "', @Email = '" + this.email + "', @Profesion = '" + this.profesion + "', @Jornada = '" + this.jornada + "',  @Num_Contacto = '" + this.num_contacto + "'";

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }

        public DataSet ConsultarDocenteTodos()
        {
            string ProcedimientoDeConsulta = "select * from Docente";

            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }

        public DataSet ConsultarDocenteTodos2()
        {
            string ProcedimientoDeConsulta = "select IdentificacionDoc as Usuario ,Nombres, Apellidos, Jornada from Docente where Estado = 'Activo' ";

            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }

        public DataSet ConsultarDocenteTodos3()
        {
            string ProcedimientoDeConsulta = "select D.IdentificacionDoc as Usuario ,D.Nombres,D.Apellidos, D.Jornada, A.Nombre as Asignatura from Docente as D inner join AsignacionAsignatura As AA on AA.IdentificacionDoc = D.IdentificacionDoc inner join Asignatura as A on A.Id_Asignatura = AA.Id_Asignatura Where D.Estado = 'Activo' order by A.Nombre  ";

            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }

        public DataSet ConsultarDocenteTodos4(int IdentificacionDocc)
        {
            string ProcedimientoDeConsulta = "select A.Nombre as Asignatura from Docente as D inner join AsignacionAsignatura As AA on AA.IdentificacionDoc = D.IdentificacionDoc inner join Asignatura as A on A.Id_Asignatura = AA.Id_Asignatura where D.IdentificacionDoc = "+ IdentificacionDocc + " order by A.Nombre"  ;

            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }

        public DataSet ConsultarDocenteTodos5()
        {
            string ProcedimientoDeConsulta =
                "select D.IdentificacionDoc as Usuario_Docente , D.Nombres, D.Apellidos, C.Num_Curso as Dirige , C.Jornada from Docente as D inner join Curso as C on C.Id_Curso = D.Id_Curso Where D.Estado = 'Activo'";

            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }

        public bool ActualizarDocente()
        {
            string ProcedimientoInsertar = "EXEC ActualizarDocente @IdentificacionDoc = " + this.identificaciondoc + ",@Nombres = '" + this.nombres + "', @Apellidos = '" + this.apellidos + "', @Direccion = '" + this.direccion + "', @Eps = '" + this.eps + "', @Email = '" + this.email + "', @Profesion = '" + this.profesion + "', @Jornada = '" + this.jornada + "',  @Num_Contacto = '" + this.num_contacto + "'";

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }


        public bool CambiarEstado(string identificacion_buscar)
        {
            string ProcedimientoInsertar = "EXEC CambiarEstadoDoc @IdentificacionDoc = " + identificacion_buscar;

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }


        public DataSet ConsultarDocente(string Valor, string Columna)
        {
            string ProcedimientoDeConsulta = "EXEC ConsultarDocente @Valor = '" + Valor + "', @Columna = '" + Columna + "'";

            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }

        public bool ActualizarDocenteSesion()
        {
            string ProcedimientoInsertar = "EXEC ActualizarDocenteSesion @IdentificacionDoc = " + this.identificaciondoc + ", @Id_Sesion = '" + this.id_sesion + "'";

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }

        public DataSet ConsultarDocenteC(string valor)
        {
            string ProcedimientoDeConsulta =
                "select D.IdentificacionDoc from Docente as D where Id_Curso ='" + valor + "'";

            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }


    }
}
