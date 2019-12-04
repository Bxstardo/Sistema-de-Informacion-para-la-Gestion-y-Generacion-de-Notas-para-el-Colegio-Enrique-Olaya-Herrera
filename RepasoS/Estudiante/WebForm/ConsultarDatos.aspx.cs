using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using LogicaV;
using RepasoS.scripts;

namespace RepasoS.Estudiante.WebForm
{
    public partial class ConsultarDatos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string IdentificacionAcu;
            Estudiantes ObjEstudiante = new Estudiantes();
            SesionU ObjSesion = new SesionU();
            Cursos ObjCurso = new Cursos();
            Acudientes ObjAcudiente = new Acudientes();
            try
            {
                DataSet DatosEstudiante = ObjEstudiante.ConsultarEstudiante(Session["IdentificacionEst"].ToString(), "IdentificacionEst");


                DataTable DatosConsultados = DatosEstudiante.Tables["DatosConsultados"];


                int numregistros = DatosConsultados.Rows.Count;


                if (numregistros == 0)
                {
                    MessageBox.alert("No existe en la Base de Datos Estudiante con esta identificación");
                }
                else
                {

                    Label1.Text = DatosConsultados.Rows[0]["Nombres"].ToString();
                    Label2.Text = DatosConsultados.Rows[0]["Apellidos"].ToString();
                    Label3.Text = DatosConsultados.Rows[0]["Direccion"].ToString();
                    Label4.Text = DatosConsultados.Rows[0]["Eps"].ToString();
                    Label5.Text = DatosConsultados.Rows[0]["Jornada"].ToString();
                    Label6.Text = DatosConsultados.Rows[0]["Num_Contacto"].ToString();
                    Label7.Text = DatosConsultados.Rows[0]["IdentificacionEst"].ToString();
                    Label8.Text = DatosConsultados.Rows[0]["Email"].ToString();

                    Label12.Text = DatosConsultados.Rows[0]["Jornada"].ToString();

                    IdentificacionAcu = DatosConsultados.Rows[0]["IdentificacionAcu"].ToString();

                    try
                    {
                        DataSet DatosAcudiente = ObjAcudiente.ConsultarAcudiente(IdentificacionAcu, "IdentificacionAcu");


                        DataTable DatosConsultados2 = DatosAcudiente.Tables["DatosConsultados"];


                        int numregistros2 = DatosConsultados2.Rows.Count;


                        if (numregistros2 == 0)
                        {
                           
                        }
                        else
                        {

                            Label10.Text = DatosConsultados2.Rows[0]["Nombres"].ToString();
                            Label13.Text = DatosConsultados2.Rows[0]["Apellidos"].ToString();
                            

                        }
                    }




                    catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjAcudiente.Mensaje); }

                    try
                    {
                        DataSet DatosCurso = ObjCurso.ConsultarCurso(DatosConsultados.Rows[0]["Id_Curso"].ToString(), "Id_Curso");

                        DataTable DatosConsultados3 = DatosCurso.Tables["DatosConsultados"];

                        int numregistros3 = DatosConsultados3.Rows.Count;


                        if (numregistros3 == 0)
                        {
                            Label11.Text = "(Sin Curso)";
                        }
                        else
                        {
                            Label11.Text = DatosConsultados3.Rows[0]["Num_Curso"].ToString();

                        }

                    }

                    catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjCurso.Mensaje); }


                }
            }




            catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjEstudiante.Mensaje); }

            try
            {
                DataSet DatosSesion = ObjSesion.ConsultarSesion(Session["IdentificacionEst"].ToString(), "Usuario");


                DataTable DatosConsultados = DatosSesion.Tables["DatosConsultados"];


                int numregistros = DatosConsultados.Rows.Count;


                if (numregistros == 0)
                {
                    MessageBox.alert("No existe en la Base de Datos Usuario con esta identificación");
                }
                else
                {


                    Label9.Text = DatosConsultados.Rows[0]["Contraseña"].ToString();



                }
            }



            catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjSesion.Mensaje); }





        }
    }
}