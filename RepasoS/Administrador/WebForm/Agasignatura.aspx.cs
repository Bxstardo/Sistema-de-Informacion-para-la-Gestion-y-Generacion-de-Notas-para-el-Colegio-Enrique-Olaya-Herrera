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
    public partial class Agasignatura : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (TextBox2.Text == "")
            {
                MessageBox.alert("No deje el campo vacio");
            }
            else
            {
                Asignaturas ObjAsignatura = new Asignaturas();

                try
                {
                    DataSet DatosAsignatura = ObjAsignatura.ConsultarAsignatura(TextBox2.Text, "Nombre");

                    DataTable DatosConsultados = DatosAsignatura.Tables["DatosConsultados"];

                    int numregistros = DatosConsultados.Rows.Count;

                    if (numregistros == 0)
                    {
                        try
                        {
                            ObjAsignatura.Nombre = TextBox2.Text;

                            bool RespuestaSql = ObjAsignatura.InsertarAsignatura();

                            if (RespuestaSql == true)
                            {
                                MessageBox.alert("Se ha agregado la asignatura correctamente");
                                TextBox2.Text = "";
                                DropDownList1.DataBind();

                               


                            }
                            else
                            {
                                MessageBox.alert(ObjAsignatura.Mensaje);
                            }
                        }
                        catch
                         (Exception Ex)
                        { MessageBox.alert("Error!: " + Ex.Message + " " + ObjAsignatura.Mensaje); }
                    }
                    else
                    {
                        MessageBox.alert("Esta asignatura ya existe");
                    }
                }
                catch
               (Exception Ex)
                { MessageBox.alert("Error!: " + Ex.Message + " " + ObjAsignatura.Mensaje); }
            }
           


        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            if (TextBox3.Text == "")
            {
                MessageBox.alert("No deje el campo vacio");
            }
            else
            {

                Areas ObjArea = new Areas();

                try
                {
                    DataSet DatosArea = ObjArea.ConsultarArea(TextBox3.Text, "Nombre");

                    DataTable DatosConsultados = DatosArea.Tables["DatosConsultados"];

                    int numregistros = DatosConsultados.Rows.Count;

                    if (numregistros == 0)
                    {
                        try
                        {
                            ObjArea.Nombre = TextBox3.Text;

                            bool RespuestaSql = ObjArea.InsertarArea();

                            if (RespuestaSql == true)
                            {
                                DropDownList2.DataBind();
                                MessageBox.alert("Se ha agregado el area correctamente");
                                TextBox3.Text = "";
                            }
                            else
                            {
                                MessageBox.alert(ObjArea.Mensaje);
                            }
                        }
                        catch
                         (Exception Ex)
                        { MessageBox.alert("Error!: " + Ex.Message + " " + ObjArea.Mensaje); }
                    }
                    else
                    {
                        MessageBox.alert("Esta Area ya existe");
                    }
                }
                catch
               (Exception Ex)
                { MessageBox.alert("Error!: " + Ex.Message + " " + ObjArea.Mensaje); }
            }
            

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Asignaturas ObjAsignaturas = new Asignaturas();
            try
            {
                bool RespuestaSql = ObjAsignaturas.AsignarArea(DropDownList1.Text, DropDownList2.Text);

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

       
    }
}
