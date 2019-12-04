using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RepasoS.scripts;
using LogicaV;
using System.Data;

namespace RepasoS.Acudiente.WebForm
{
    public partial class ConsultarDatosEst : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        
        protected void Button1_Click(object sender, EventArgs e)
        {

            Estudiantes ObjEstudiante = new Estudiantes();
            SesionU ObjSesion = new SesionU();
            Cursos ObjCurso = new Cursos();
            Acudientes ObjAcudiente = new Acudientes();
            try
            {
                DataSet DatosEstudiante = ObjEstudiante.ConsultarEstudiante(DropDownList1.Text, "IdentificacionEst");


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



        }
    }
}