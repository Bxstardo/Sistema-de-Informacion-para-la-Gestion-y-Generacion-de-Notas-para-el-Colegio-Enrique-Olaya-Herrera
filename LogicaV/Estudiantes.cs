using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DatosV;

namespace LogicaV
{
    public class Estudiantes : Conexion
    {
        private int identificacionest;
        private string nombres;
        private string apellidos;
        private string direccion;
        private string eps;
        private string email;
        private string jornada;
        private string num_contacto;
        private int id_sesion;
        private int id_curso;
        private string estado;
        private int identificacionacu;

        public int IdentificacionEst
        {
            get { return identificacionest; }
            set { identificacionest = value; }
        }

        public int IdentificacionAcu
        {
            get { return identificacionacu; }
            set { identificacionacu = value; }
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

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
   

        public bool InsertarEstudiante()
        {
            string ProcedimientoInsertar = "EXEC InsertarEstudiante @IdentificacionEst = " + this.identificacionest + ",@Nombres = '" + this.nombres + "', @Apellidos = '" + this.apellidos + "', @Direccion = '" + this.direccion + "', @Eps = '" + this.eps + "', @Email = '" + this.email + "', @Jornada = '" + this.jornada + "', @Num_Contacto = '" + this.num_contacto + "'";

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }

        public DataSet ConsultarEstudianteTodos()
        {
            string ProcedimientoDeConsulta = "select * from Estudiante";

            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }
        public DataSet ConsultarEstudianteTodos2()
        {
            string ProcedimientoDeConsulta = "select IdentificacionEst as Usuario ,Nombres, Apellidos, Jornada from Estudiante where Estado = 'Activo' ";

            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }

        public DataSet ConsultarEstudianteTodos3(int Valor)
        {
            string ProcedimientoDeConsulta = "select E.IdentificacionEst as Usuario ,E.Nombres as Nombre, E.Apellidos as Apellido, E.Jornada as Jornada, C.Num_Curso as Curso, D.Nombres as DirectorN, D.Apellidos as DirectorA  from Estudiante as E  inner join Curso as C on C.Id_Curso = E.Id_Curso inner join Docente as D on D.Id_Curso = C.Id_Curso where E.Estado = 'Activo' and E.IdentificacionEst = "+ Valor;

            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }

        public bool ActualizarEstudiante()
        {
            string ProcedimientoInsertar = "EXEC ActualizarEstudiante @IdentificacionEst = " + this.identificacionest + ",@Nombres = '" + this.nombres + "', @Apellidos = '" + this.apellidos + "', @Direccion = '" + this.direccion + "', @Eps = '" + this.eps + "', @Email = '" + this.email + "', @Jornada = '" + this.jornada + "', @Num_Contacto = '" + this.num_contacto + "'";

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }

        public bool AsignarAcu()
        {
            string ProcedimientoInsertar = "EXEC AsignarAcu @IdentificacionEst = '" + this.identificacionest + "', @IdentificacionAcu = '" + this.identificacionacu + "'";

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }


        public bool CambiarEstado(string identificacion_buscar)
        {
            string ProcedimientoInsertar = "EXEC CambiarEstadoEst2 @IdentificacionEst = " + identificacion_buscar;

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }


        public DataSet ConsultarEstudiante(string Valor, string Columna)
        {
            string ProcedimientoDeConsulta = "EXEC ConsultarEstudiante @Valor = '" + Valor + "', @Columna = '" + Columna + "'";

            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }

        public bool ActualizarEstudianteSesion()
        {
            string ProcedimientoInsertar = "EXEC ActualizarEstudianteSesion @IdentificacionEst = " + this.identificacionest + ", @Id_Sesion = '" + this.id_sesion + "'";

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }
        public DataSet ConsultarAcudienteTodos5(string valor)
        {
            string ProcedimientoDeConsulta = "select E.IdentificacionEst as Usuario, E.Nombres , E.Apellidos from Estudiante as E inner join Acudiente as A on E.IdentificacionAcu = A.IdentificacionAcu where E.IdentificacionAcu = " + valor;

            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }


    }
}
    

