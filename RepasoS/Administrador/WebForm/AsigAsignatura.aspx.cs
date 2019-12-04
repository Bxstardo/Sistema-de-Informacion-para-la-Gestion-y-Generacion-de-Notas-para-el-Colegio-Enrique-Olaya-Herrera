using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using LogicaV;
using RepasoS.scripts;

namespace RepasoS.Administrador.WebForm
{
    public partial class AsigAsignatura : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (TextBox4.Text == "")
            {
                MessageBox.alert("No deje el campo vacio");
            }
            else
            {
                AsignacionAsignaturas ObjAS = new AsignacionAsignaturas();
                try
                {
                    ObjAS.IdentificacionDoc = int.Parse(TextBox4.Text);
                    bool RespuestaSql = ObjAS.InsertarAsignacionAsignatura(DropDownList3.Text);
                    if (RespuestaSql == true)
                    {
                        MessageBox.alert("Se ha asignado la asignatura al docente correctamente");
                        TextBox4.Text = "";
                    }
                    else
                    {
                        MessageBox.alert(ObjAS.Mensaje);
                    }

                }
                catch
                (Exception ex)
                { MessageBox.alert("Error!: " + ex.Message + " " + ObjAS.Mensaje); }
            }
               
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            if (TextBox4.Text == "")
            {
                MessageBox.alert("No deje el campo vacio");
            }
            else
            {
                GridView1.DataBind();
                AsignacionAsignaturas ObjAS = new AsignacionAsignaturas();
                try
                {
                    ObjAS.IdentificacionDoc = int.Parse(TextBox4.Text);
                    bool RespuestaSql = ObjAS.EliminarAsignacionAsignatura(DropDownList3.Text);
                    if (RespuestaSql == true)
                    {
                        MessageBox.alert("Se ha eliminado la asignatura al docente correctamente");
                        TextBox4.Text = "";
                    }
                    else
                    {
                        MessageBox.alert(ObjAS.Mensaje);
                    }

                }
                catch
                (Exception ex)
                { MessageBox.alert("Error!: " + ex.Message + " " + ObjAS.Mensaje); }
            }
               
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Docentes ObjDocente = new Docentes();

            try
            {
                DataSet DatosDocente = ObjDocente.ConsultarDocenteTodos2();

                DataTable DatosConsultados = DatosDocente.Tables["DatosConsultados"];

                int numregistros = DatosConsultados.Rows.Count;

                if (numregistros == 0)
                {
                    MessageBox.alert("No hay datos en la base de datos");
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