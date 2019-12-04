using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DatosV;

namespace LogicaV
{
    public class SesionU : Conexion
    {
        private int usuario;
        private string tipo_usuario;
        private string contraseña;

        public int Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public string Tipo_Usuario
        {
            get { return tipo_usuario; }
            set { tipo_usuario = value; }
        }

        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }

        public bool InsertarUsuario()
        {
            string ProcedimientoInsertar = "EXEC InsertarSesion @Usuario = " + this.usuario + ",@Tipo_Usuario = '" + this.tipo_usuario + "', @Contraseña = '" + this.contraseña + "'"; 

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }

        public bool CambiarContraseña()
        {
            string ProcedimientoInsertar = "EXEC CambiarContraseña @Usuario = " + this.usuario + ", @Contraseña = '" + this.contraseña + "'";

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }


        public DataSet ConsultarSesion(string Valor, string Columna)
        {
            string ProcedimientoDeConsulta = "EXEC ConsultarSesion @Valor = '" + Valor + "', @Columna = '" + Columna + "'";

            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }

        public bool ActualizarSesion()
        {
            string ProcedimientoInsertar = "EXEC ActualizarSesion @Usuario = " + this.usuario+ ", @Contraseña = '" + this.contraseña + "'";

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }

        public bool EliminarSesion(string usuario_buscar)
        {
            string ProcedimientoInsertar = "EXEC EliminarSesion @Usuario = " + usuario_buscar;

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }

    }
}
