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
    public partial class Agdocente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            {
                string identificacion;
                string id_sesion;

                if (TextBox9.Text != TextBox8.Text)
                {
                    MessageBox.alert("Las contraseñas no coinciden");
                }
                else
                {
                    Docentes ObjDocente = new Docentes();
                    SesionU ObjUsuario = new SesionU();
                    try
                    {
                        ObjDocente.IdentificacionDoc = int.Parse(TextBox6.Text);
                        ObjDocente.Nombres = TextBox1.Text;
                        ObjDocente.Apellidos = TextBox2.Text;
                        ObjDocente.Direccion = TextBox3.Text;
                        ObjDocente.Eps = TextBox4.Text;
                        ObjDocente.Email = TextBox7.Text;
                        ObjDocente.Num_Contacto = TextBox11.Text;
                        ObjDocente.Profesion = TextBox10.Text;
                        ObjDocente.Jornada = DropDownList3.SelectedItem.Text;

                        ObjUsuario.Usuario = int.Parse(TextBox6.Text);
                        ObjUsuario.Contraseña = TextBox8.Text;
                        ObjUsuario.Tipo_Usuario = "Docente";
                        identificacion = TextBox6.Text;

                        bool respuestaSQL = ObjDocente.InsertarDocente();

                        bool respuestaSQL2 = ObjUsuario.InsertarUsuario();

                        if (respuestaSQL && respuestaSQL2 == true)
                        {
                            MessageBox.alert("Los datos del nuevo docente fueron insertados correctamente");
                           

                            TextBox1.Text = "";
                            TextBox2.Text = "";
                            TextBox3.Text = "";
                            TextBox4.Text = "";
                            TextBox6.Text = "";
                            TextBox7.Text = "";
                            TextBox8.Text = "";
                            TextBox9.Text = "";
                            TextBox10.Text = "";
                            TextBox11.Text = "";



                            try
                            {
                                DataSet DatosSesion = ObjUsuario.ConsultarSesion(identificacion, "Usuario");

                                DataTable DatosConsultados = DatosSesion.Tables["DatosConsultados"];

                                int numregistros = DatosConsultados.Rows.Count;

                                if (numregistros == 0)
                                {


                                }
                                else
                                {

                                    id_sesion = DatosConsultados.Rows[0]["Id_Sesion"].ToString();
                              
                                    try
                                    {
                                        ObjDocente.Id_Sesion = int.Parse(id_sesion);

                                        bool respuestaSQL3 = ObjDocente.ActualizarDocenteSesion();

                                        if (respuestaSQL3 == true)
                                        {


                                        }
                                        else { MessageBox.alert(ObjDocente.Mensaje); }
                                    }
                                    catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjDocente.Mensaje); }
                                }
                            }




                            catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjDocente.Mensaje); }




                        }
                        else
                        {
                            MessageBox.alert("La identificacion de este Docente ya existe en la base de datos");


                        }
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.alert("Error!: " + Ex.Message + " " + ObjDocente.Mensaje);
                        MessageBox.alert("Error!: " + Ex.Message + " " + ObjUsuario.Mensaje); 
                    }

                }
            }
        }
    }
}