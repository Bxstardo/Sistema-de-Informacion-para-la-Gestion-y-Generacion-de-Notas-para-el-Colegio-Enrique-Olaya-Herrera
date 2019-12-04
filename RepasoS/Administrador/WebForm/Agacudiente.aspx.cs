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
    public partial class Agacudiente : System.Web.UI.Page
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
                    Acudientes ObjAcudiente = new Acudientes();
                    SesionU ObjUsuario = new SesionU();
                    try
                    {
                        ObjAcudiente.IdentificacionAcu = int.Parse(TextBox6.Text);
                        ObjAcudiente.Nombres = TextBox1.Text;
                        ObjAcudiente.Apellidos = TextBox2.Text;
                        ObjAcudiente.Direccion = TextBox3.Text;
                        ObjAcudiente.Eps = TextBox4.Text;
                        ObjAcudiente.Email = TextBox5.Text;             
                        ObjAcudiente.Num_Contacto = TextBox4.Text;
                        ObjUsuario.Usuario = int.Parse(TextBox6.Text);
                        ObjUsuario.Contraseña = TextBox8.Text;
                        ObjUsuario.Tipo_Usuario = "Acudiente";
                        identificacion = TextBox6.Text;

                        bool respuestaSQL = ObjAcudiente.InsertarAcudiente();
                        bool respuestaSQL2 = ObjUsuario.InsertarUsuario();

                        if (respuestaSQL && respuestaSQL2 == true)
                        {
                            MessageBox.alert("Los datos del nuevo acudiente fueron insertados correctamente");
                           

                            TextBox1.Text = "";
                            TextBox2.Text = "";
                            TextBox3.Text = "";
                            TextBox4.Text = "";
                            TextBox6.Text = "";
                            TextBox5.Text = "";
                            TextBox8.Text = "";
                            TextBox9.Text = "";
                           


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
                                        ObjAcudiente.Id_Sesion = int.Parse(id_sesion);

                                        bool respuestaSQL3 = ObjAcudiente.ActualizarAcudienteSesion();

                                        if (respuestaSQL3 == true)
                                        {


                                        }
                                        else { MessageBox.alert(ObjAcudiente.Mensaje); }
                                    }
                                    catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjAcudiente.Mensaje); }
                                }
                            }




                            catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjAcudiente.Mensaje); }
                            



                        }
                        else
                        {
                            MessageBox.alert("La identificacion de este Acudiente ya existe en la base de datos");


                        }
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.alert("Error!: " + Ex.Message + " " + ObjAcudiente.Mensaje);
                        MessageBox.alert("Error!: " + Ex.Message + " " + ObjUsuario.Mensaje);
                    }

                }
            }

        }
    }
}