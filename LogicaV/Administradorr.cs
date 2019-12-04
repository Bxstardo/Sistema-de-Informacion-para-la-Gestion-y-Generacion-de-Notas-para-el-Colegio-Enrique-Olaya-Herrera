using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosV;
using System.Data;

namespace LogicaV
{
    public class Administradorr : Conexion
    {
        private int identificacionadm;
        private string nombres;
        private string apellidos;
        private string direccion;
        private string eps;
        private string email;
        private string num_contacto;
        private string estado;
        private int id_sesion;


        public int IdentificacionAdm
        {
            get { return identificacionadm; }
            set { identificacionadm = value; }
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

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public DataSet ConsultarAdministrador(string Valor, string Columna)
        {
            string ProcedimientoDeConsulta = "EXEC ConsultarAdministrador @Valor = '" + Valor + "', @Columna = '" + Columna + "'";

            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }


    }
}
