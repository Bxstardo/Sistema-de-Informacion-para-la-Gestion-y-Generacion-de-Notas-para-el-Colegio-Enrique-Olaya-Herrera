using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RepasoS.scripts;
using LogicaV;
using System.Data;

namespace RepasoS.Administrador.WebForm
{
    public partial class Modasignatura : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Asignaturas ObjAsignatura = new Asignaturas();
            try
            {

                bool RespuestaSql = ObjAsignatura.ModificarAsignatura(DropDownList3.Text, TextBox1.Text);

                if (RespuestaSql == true)
                {
                    DropDownList3.DataBind();
                    DropDownList6.DataBind();
                    DropDownList5.DataBind();
                    DropDownList4.DataBind();
                    MessageBox.alert("Se ha modificado la asignatura con exito");
                    TextBox1.Text = "";
                    GridView1.Visible = false;

                }
                else
                {
                    MessageBox.alert(ObjAsignatura.Mensaje);
                }

            }
            catch (Exception Ex)
            { MessageBox.alert("Error!: " + Ex.Message + " " + ObjAsignatura.Mensaje); }

        }


        protected void Button2_Click(object sender, EventArgs e)
        {


            Areas ObjArea = new Areas();
            try
            {

                bool RespuestaSql = ObjArea.ModificarArea(DropDownList4.Text, TextBox2.Text);

                if (RespuestaSql == true)
                {
                    DropDownList3.DataBind();
                    DropDownList6.DataBind();
                    DropDownList5.DataBind();
                    DropDownList4.DataBind();
                    MessageBox.alert("Se ha modificado el area con exito");
                    GridView1.Visible = false;
                    TextBox2.Text = "";
                }
                else
                {
                    MessageBox.alert(ObjArea.Mensaje);
                }

            }
            catch (Exception Ex)
            { MessageBox.alert("Error!: " + Ex.Message + " " + ObjArea.Mensaje); }
        }
           

        protected void Button3_Click(object sender, EventArgs e)
        {
            GridView1.DataBind();
            Asignaturas ObjAsignaturas = new Asignaturas();
            try
            {
                bool RespuestaSql = ObjAsignaturas.AsignarArea(DropDownList5.Text, DropDownList6.Text);

                if (RespuestaSql == true)
                {
                    MessageBox.alert("Se ha asignado el area correctamente a la asignatura");
                   
                }
                else
                {
                    MessageBox.alert(ObjAsignaturas.Mensaje);
                }
            }
            catch
                    (Exception Ex)
            { MessageBox.alert("Error!: " + Ex.Message + " " + ObjAsignaturas.Mensaje); }

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            MessageBox.alert("Se han guardado con exito los cambios!");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {


            Asignaturas ObjAsignatura = new Asignaturas();
            try
            {
                ObjAsignatura.Nombre = DropDownList3.Text;

                bool RespuestaSql = ObjAsignatura.EliminarAsignatura();

                if (RespuestaSql == true)

                {
                    GridView1.Visible = false;
                    DropDownList3.DataBind();
                    DropDownList6.DataBind();
                    DropDownList5.DataBind();
                    DropDownList4.DataBind();
                    MessageBox.alert("Se ha borrado la asignatura correctamente");
                    TextBox1.Text = "";
                }

                else
                {
                    MessageBox.alert(ObjAsignatura.Mensaje);
                }

            }
            catch (Exception Ex)
            { MessageBox.alert("Error!: " + Ex.Message + " " + ObjAsignatura.Mensaje); }

        }


        protected void Button7_Click(object sender, EventArgs e)
        {


            Areas ObjArea = new Areas();
            try
            {
                ObjArea.Nombre = DropDownList4.Text;

                bool RespuestaSql = ObjArea.EliminarArea();

                if (RespuestaSql == true)

                {
                    DropDownList3.DataBind();
                    DropDownList6.DataBind();
                    DropDownList5.DataBind();
                    DropDownList4.DataBind();
                    MessageBox.alert("Se ha borrado el area correctamente");
                    TextBox2.Text = "";
                }

                else
                {
                    MessageBox.alert("Borra o cambia de areas las asignaturas que se muestran en la tabla para poder eliminar el area");
                    Asignaturas ObjAsignatura = new Asignaturas();
                    try
                    {

                        DataSet DatosAsignatura = ObjAsignatura.ConsultarAsignaturaAreaTodos2(DropDownList4.Text);


                        DataTable DatosConsultados = DatosAsignatura.Tables["DatosConsultados"];


                        int numregistros = DatosConsultados.Rows.Count;


                        if (numregistros == 0)
                        {
                            MessageBox.alert("No hay asignaturas en la base de datos");
                        }
                        else
                        {
                            GridView1.Visible = true;
                            GridView1.DataSource = DatosConsultados;
                            GridView1.DataBind();


                        }


                    }
                    catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjAsignatura.Mensaje); }

                }

            }
            catch (Exception Ex)
            { MessageBox.alert("Error!: " + Ex.Message + " " + ObjArea.Mensaje); }
        }


    }
}