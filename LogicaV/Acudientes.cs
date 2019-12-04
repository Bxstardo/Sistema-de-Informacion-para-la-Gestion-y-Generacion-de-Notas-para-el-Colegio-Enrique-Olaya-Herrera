using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosV;
using System.Data;

namespace LogicaV
{
    public class Acudientes : Conexion
    {
        private int identificacionacu;
        private string nombres;
        private string apellidos;
        private string direccion;
        private string eps;
        private string email;
        private string num_contacto;
        private int id_sesion;

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
        public bool InsertarAcudiente()
        {
            string ProcedimientoInsertar = "EXEC InsertarAcudiente @IdentificacionAcu = " + this.identificacionacu + ",@Nombres = '" + this.nombres + "', @Apellidos = '" + this.apellidos + "', @Direccion = '" + this.direccion + "', @Eps = '" + this.eps + "', @Email = '" + this.email + "', @Num_Contacto = '" + this.num_contacto + "'";

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }

        public DataSet ConsultarAcudienteTodos()
        {
            string ProcedimientoDeConsulta = "select * from Acudiente";

            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }

        


        public bool ActualizarAcudiente()
        {
            string ProcedimientoInsertar = "EXEC ActualizarAcudiente @IdentificacionAcu = " + this.identificacionacu + ",@Nombres = '" + this.nombres + "', @Apellidos = '" + this.apellidos + "', @Direccion = '" + this.direccion + "', @Eps = '" + this.eps + "', @Email = '" + this.email + "', @Num_Contacto = '" + this.num_contacto + "'";

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }


        public bool CambiarEstado(string identificacion_buscar)
        {
            string ProcedimientoInsertar = "EXEC CambiarEstadoAcu @IdentificacionAcu = " + identificacion_buscar;

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }


        public DataSet ConsultarAcudiente(string Valor, string Columna)
        {
            string ProcedimientoDeConsulta = "EXEC ConsultarAcudiente @Valor = '" + Valor + "', @Columna = '" + Columna + "'";

            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }

        public bool ActualizarAcudienteSesion()
        {
            string ProcedimientoInsertar = "EXEC ActualizarAcudienteSesion @IdentificacionAcu = " + this.identificacionacu + ", @Id_Sesion = '" + this.id_sesion + "'";

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }


    }
}
