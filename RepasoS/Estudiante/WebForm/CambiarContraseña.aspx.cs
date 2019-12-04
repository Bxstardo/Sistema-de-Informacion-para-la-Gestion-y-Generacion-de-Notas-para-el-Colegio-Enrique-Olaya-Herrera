using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogicaV;
using RepasoS.scripts;
using System.Data;

namespace RepasoS.Estudiante.WebForm
{
    public partial class CambiarContraseña : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "")
            {
                MessageBox.alert("No deje ningun campo vacio");
            }
            else
            {


                SesionU ObjSesion = new SesionU();
                try
                {
                    DataSet DatosSesion = ObjSesion.ConsultarSesion((Session["IdentificacionEst"]).ToString(), "Usuario");


                    DataTable DatosConsultados = DatosSesion.Tables["DatosConsultados"];


                    int numregistros = DatosConsultados.Rows.Count;


                    if (numregistros == 0)
                    {
                        MessageBox.alert("No existe en la Base de Datos Usuario con esta identificación");
                    }
                    else
                    {


                        Session["Contraseña"] = DatosConsultados.Rows[0]["Contraseña"].ToString();

                        try
                        {
                            if (TextBox1.Text == Session["Contraseña"].ToString())
                            {

                                if (TextBox2.Text == TextBox3.Text)
                                {
                                    ObjSesion.Usuario = int.Parse(Session["IdentificacionEst"].ToString());
                                    ObjSesion.Contraseña = TextBox2.Text;

                                    bool RespuestaSql = ObjSesion.CambiarContraseña();

                                    if (RespuestaSql == true)
                                    {
                                        MessageBox.alert("La contraseña se ha cambiado correctamente");
                                        TextBox1.Text = "";
                                        TextBox2.Text = "";
                                        TextBox3.Text = "";
                                    }
                                    else
                                    {
                                        MessageBox.alert(ObjSesion.Mensaje);
                                    }
                                }
                                else
                                {
                                    MessageBox.alert("Las contraseñas nuevas no coinciden");
                                    TextBox2.Text = "";
                                    TextBox3.Text = "";
                                }

                            }
                            else
                            {
                                MessageBox.alert("Las contraseña actual es incorrecta");
                                TextBox1.Text = "";
                                TextBox2.Text = "";
                                TextBox3.Text = "";
                            }
                        }
                        catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjSesion.Mensaje); }


                    }
                }




                catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjSesion.Mensaje); }

            }

        }
    }
}