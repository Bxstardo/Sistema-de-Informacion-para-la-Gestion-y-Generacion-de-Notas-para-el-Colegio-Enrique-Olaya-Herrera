using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RepasoS.scripts;
using System.Data;
using LogicaV;


namespace RepasoS.Administrador.WebForm
{
    public partial class Colacudiente : System.Web.UI.Page
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

                Estudiantes ObjEstudiante = new Estudiantes();
                Acudientes ObjAcudiente = new Acudientes();
                SesionU ObjSesion = new SesionU();
                try
                {
                    DataSet DatosAcudiente = ObjAcudiente.ConsultarAcudiente(TextBox2.Text, "IdentificacionAcu");


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
                        try
                        {
                            DataSet DatosEstudiante = ObjEstudiante.ConsultarAcudienteTodos5(TextBox2.Text);

                            DataTable DatosConsultados2 = DatosEstudiante.Tables["DatosConsultados"];

                            int numregistros2 = DatosConsultados2.Rows.Count;

                            if (numregistros2 == 0)
                            {

                            }
                            else
                            {
                                GridView2.DataSource = DatosConsultados2;
                                GridView2.DataBind();


                            }

                        }

                        catch (Exception ex) { MessageBox.alert("No se ha podido efectuar la consulta debido al siguiente Error: " + ex.Message); }

                    }
                }




                catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjAcudiente.Mensaje); }
                try
                {
                    DataSet DatosSesion = ObjSesion.ConsultarSesion(TextBox2.Text, "Usuario");


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
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Acudientes ObjAcudiente = new Acudientes();

            try
            {

                DataSet DatosAcudiente = ObjAcudiente.ConsultarAcudienteTodos();


                DataTable DatosConsultados = DatosAcudiente.Tables["DatosConsultados"];

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