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
    public partial class Colasignatura : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Asignaturas ObjAsignatura = new Asignaturas();
            try
            {
             
                DataSet DatosAsignatura = ObjAsignatura.ConsultarAsignaturaTodos();


                DataTable DatosConsultados = DatosAsignatura.Tables["DatosConsultados"];


                int numregistros = DatosConsultados.Rows.Count;


                if (numregistros == 0)
                {
                    MessageBox.alert("No hay asignaturas en la base de datos");
                }
                else
                {

                    GridView1.DataSource = DatosConsultados;
                    GridView1.DataBind();

                }


            }
            catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjAsignatura.Mensaje); }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Areas ObjArea = new Areas();
            try
            {

                DataSet DatosArea = ObjArea.ConsultarAreaTodos();


                DataTable DatosConsultados = DatosArea.Tables["DatosConsultados"];


                int numregistros = DatosConsultados.Rows.Count;


                if (numregistros == 0)
                {
                    MessageBox.alert("No hay areas en la base de datos");
                }
                else
                {

                    GridView2.DataSource = DatosConsultados;
                    GridView2.DataBind();

                }


            }
            catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjArea.Mensaje); }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Asignaturas ObjAsignatura = new Asignaturas();
            try
            {

                DataSet DatosAsignatura = ObjAsignatura.ConsultarAsignaturaAreaTodos();


                DataTable DatosConsultados = DatosAsignatura.Tables["DatosConsultados"];


                int numregistros = DatosConsultados.Rows.Count;


                if (numregistros == 0)
                {
                    MessageBox.alert("No hay asignaturas en la base de datos");
                }
                else
                {

                    GridView3.DataSource = DatosConsultados;
                    GridView3.DataBind();

                }


            }
            catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjAsignatura.Mensaje); }

        }
    }
}