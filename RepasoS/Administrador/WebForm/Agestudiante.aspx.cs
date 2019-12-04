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
    public partial class Agestudiante : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void Button2_Click(object sender, EventArgs e)
        {
            string identificacion;
            string id_sesion;
           
            if (TextBox9.Text != TextBox8.Text)
            {
                MessageBox.alert("Las contraseñas no coinciden");
            }
            else
            {
                Estudiantes ObjEstudiantes = new Estudiantes(); 
                SesionU ObjUsuario = new SesionU(); 
                try
                {
                    ObjEstudiantes.IdentificacionEst = int.Parse(TextBox6.Text);                  
                    ObjEstudiantes.Nombres = TextBox1.Text;
                    ObjEstudiantes.Apellidos = TextBox2.Text;
                    ObjEstudiantes.Direccion = TextBox3.Text;
                    ObjEstudiantes.Eps = TextBox4.Text;
                    ObjEstudiantes.Email = TextBox7.Text;
                    ObjEstudiantes.Jornada = DropDownList1.SelectedItem.Text;
                    ObjEstudiantes.Num_Contacto = TextBox10.Text;
                    ObjUsuario.Usuario = int.Parse(TextBox6.Text);
                    ObjUsuario.Contraseña = TextBox8.Text;
                    ObjUsuario.Tipo_Usuario = "Estudiante";
                    identificacion = TextBox6.Text;

                    bool respuestaSQL = ObjEstudiantes.InsertarEstudiante();
                    bool respuestaSQL2 = ObjUsuario.InsertarUsuario();

                    if (respuestaSQL && respuestaSQL2 == true)
                    {
                        MessageBox.alert("Los datos del nuevo estudiante fueron insertados correctamente");
                        Label1.Text = "Los datos del nuevo estudiante fueron insertados correctamente";

                        TextBox1.Text = "";
                        TextBox2.Text = "";
                        TextBox3.Text = "";
                        TextBox4.Text = "";
                        TextBox6.Text = "";
                        TextBox7.Text = "";
                        TextBox8.Text = "";
                        TextBox9.Text = "";
                        TextBox10.Text = "";
                        

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
                                Label2.Text = id_sesion;
                                try
                                {
               
                                    ObjEstudiantes.Id_Sesion = int.Parse(id_sesion);

                                    bool respuestaSQL3 = ObjEstudiantes.ActualizarEstudianteSesion();

                                    if (respuestaSQL3 == true)
                                    {
                                      

                                    }
                                    else { MessageBox.alert(ObjEstudiantes.Mensaje); }
                                }
                                catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjEstudiantes.Mensaje); }
                            }
                        }




                        catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjEstudiantes.Mensaje); }

                       

                    }
                    else
                    {
                        MessageBox.alert("La identificacion de este Estudiante ya existe en la base de datos");
           
                    }
                }
                catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjEstudiantes.Mensaje); Label1.Text = "Error!: " + Ex.Message + " " + ObjEstudiantes.Mensaje;
                    MessageBox.alert("Error!: " + Ex.Message + " " + ObjUsuario.Mensaje); Label1.Text = "Error!: " + Ex.Message + " " + ObjUsuario.Mensaje;
                }

            }
        }
    }
}