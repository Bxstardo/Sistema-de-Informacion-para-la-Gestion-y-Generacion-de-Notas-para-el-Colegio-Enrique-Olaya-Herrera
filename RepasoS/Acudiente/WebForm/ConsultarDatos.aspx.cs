using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogicaV;
using System.Data;
using RepasoS.scripts;


namespace RepasoS.Acudiente.WebForm
{
    public partial class ConsultarDatos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Acudientes ObjAcudiente = new Acudientes();
            SesionU ObjSesion = new SesionU();
            Estudiantes ObjEstudiante = new Estudiantes();
            try
            {
                DataSet DatosAcudiente = ObjAcudiente.ConsultarAcudiente(Session["IdentificacionAcu"].ToString(), "IdentificacionAcu");


                DataTable DatosConsultados = DatosAcudiente.Tables["DatosConsultados"];


                int numregistros = DatosConsultados.Rows.Count;


                if (numregistros == 0)
                {
                    MessageBox.alert("No existe en la Base de Datos Acudiente con esta identificación");
                }
                else
                {

                    Label1.Text = DatosConsultados.Rows[0]["Nombres"].ToString();
                    Label2.Text = DatosConsultados.Rows[0]["Apellidos"].ToString();
                    Label3.Text = DatosConsultados.Rows[0]["Direccion"].ToString();
                    Label4.Text = DatosConsultados.Rows[0]["Eps"].ToString();

                    Label6.Text = DatosConsultados.Rows[0]["Num_Contacto"].ToString();
                    Label7.Text = DatosConsultados.Rows[0]["IdentificacionAcu"].ToString();
                    Label8.Text = DatosConsultados.Rows[0]["Email"].ToString();


                }
            }




            catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjAcudiente.Mensaje); }
            try
            {
                DataSet DatosSesion = ObjSesion.ConsultarSesion(Session["IdentificacionAcu"].ToString(), "Usuario");


                DataTable DatosConsultados = DatosSesion.Tables["DatosConsultados"];


                int numregistros = DatosConsultados.Rows.Count;


                if (numregistros == 0)
                {
                    MessageBox.alert("No existe en la Base de Datos Acudiente con esta identificación");
                }
                else
                {


                    Label9.Text = DatosConsultados.Rows[0]["Contraseña"].ToString();



                }
            }




            catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjSesion.Mensaje); }


            try
            {
                DataSet DatosEstudiante = ObjEstudiante.ConsultarAcudienteTodos5(Session["IdentificacionAcu"].ToString());

                DataTable DatosConsultados = DatosEstudiante.Tables["DatosConsultados"];

                int numregistros = DatosConsultados.Rows.Count;

                if (numregistros == 0)
                {
                  
                }
                else
                {
                    GridView1.DataSource = DatosConsultados;
                    GridView1.DataBind();


                }

            }

            catch (Exception ex) { MessageBox.alert("No se ha podido efectuar la consulta debido al siguiente Error: " + ex.Message); }
        }
    }
}