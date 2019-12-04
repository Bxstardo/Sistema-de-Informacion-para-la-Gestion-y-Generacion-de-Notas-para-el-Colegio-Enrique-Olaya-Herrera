using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogicaV;
using System.Data;
using RepasoS.scripts;

namespace RepasoS.Administrador.WebForm
{
    public partial class Colcurso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Cursos ObjCurso = new Cursos();
   
            try
            {
                DataSet DatosCurso = ObjCurso.ConsultarCurso2(DropDownList7.Text,DropDownList3.Text,"JorYCur");

                DataTable DatosConsultados = DatosCurso.Tables["DatosConsultados"];

                int numregistros3 = DatosConsultados.Rows.Count;

                if (numregistros3 == 0)
                {
                    MessageBox.alert("Este curso no existe para la jornada " + DropDownList3.Text);
                }
                else
                {
                    
                    try
                    {

                        ObjCurso.Id_Curso = int.Parse(DatosConsultados.Rows[0]["Id_Curso"].ToString());

                        DataSet DatosCurso2 = ObjCurso.ConsultarCEst();


                        DataTable DatosConsultados2 = DatosCurso2.Tables["DatosConsultados"];


                        int numregistros = DatosConsultados2.Rows.Count;


                        if (numregistros == 0)
                        {
                            MessageBox.alert("No hay estudiantes ni docentes en el curso");
                        }
                        else
                        {

                            GridView1.DataSource = DatosConsultados2;
                            GridView1.DataBind();

                        }


                    }
                    catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjCurso.Mensaje); }

                }

            }

            catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjCurso.Mensaje); }

        }
    }
}