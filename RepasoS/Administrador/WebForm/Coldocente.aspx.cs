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
    public partial class Coldocente : System.Web.UI.Page
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

                Docentes ObjDocente = new Docentes();
                SesionU ObjSesion = new SesionU();
                Cursos ObjCurso = new Cursos();
                try
                {
                    DataSet DatosDocente = ObjDocente.ConsultarDocente(TextBox2.Text, "IdentificacionDoc");


                    DataTable DatosConsultados = DatosDocente.Tables["DatosConsultados"];


                    int numregistros = DatosConsultados.Rows.Count;


                    if (numregistros == 0)
                    {
                        MessageBox.alert("No existe en la Base de Datos Docente con esta identificación");
                    }
                    else
                    {

                        Label1.Text = DatosConsultados.Rows[0]["Nombres"].ToString();
                        Label2.Text = DatosConsultados.Rows[0]["Apellidos"].ToString();
                        Label3.Text = DatosConsultados.Rows[0]["Direccion"].ToString();
                        Label4.Text = DatosConsultados.Rows[0]["Eps"].ToString();
                        Label5.Text = DatosConsultados.Rows[0]["Jornada"].ToString();
                        Label6.Text = DatosConsultados.Rows[0]["Num_Contacto"].ToString();
                        Label7.Text = DatosConsultados.Rows[0]["IdentificacionDoc"].ToString();
                        Label8.Text = DatosConsultados.Rows[0]["Email"].ToString();
                        Label9.Text = DatosConsultados.Rows[0]["Profesion"].ToString();
                        Label12.Text = DatosConsultados.Rows[0]["Jornada"].ToString();

                        try
                        {
                            DataSet DatosDocente2 = ObjDocente.ConsultarDocenteTodos4(int.Parse(TextBox2.Text));

                            DataTable DatosConsultados2 = DatosDocente2.Tables["DatosConsultados"];

                            int numregistros2 = DatosConsultados2.Rows.Count;

                            if (numregistros2 == 0)
                            {

                            }

                            else
                            {
                                for (int i = 0; i <= numregistros2; i++)
                                {
                                    Label objTemporal = new Label();
                                    contenedor.Controls.Add(objTemporal);

                                    objTemporal.Text = DatosConsultados2.Rows[i]["Asignatura"].ToString();
                                    contenedor.Controls.Add(new LiteralControl("</br>"));
                                }

                            }

                        }

                        catch
                        { }

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




                catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjDocente.Mensaje); }
                try
                {
                    DataSet DatosSesion = ObjSesion.ConsultarSesion(TextBox2.Text, "Usuario");


                    DataTable DatosConsultados = DatosSesion.Tables["DatosConsultados"];


                    int numregistros = DatosConsultados.Rows.Count;


                    if (numregistros == 0)
                    {
                        MessageBox.alert("No existe en la Base de Datos Usuario con esta identificación");
                    }
                    else
                    {


                        Label10.Text = DatosConsultados.Rows[0]["Contraseña"].ToString();



                    }
                }




                catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjSesion.Mensaje); }


            }
         
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Docentes ObjDocente = new Docentes();

            try
            {
                DataSet DatosDocente = ObjDocente.ConsultarDocenteTodos();

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