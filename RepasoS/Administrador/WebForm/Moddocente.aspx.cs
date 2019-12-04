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
    public partial class Moddocente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (TextBox1.Text == "")
            {
                MessageBox.alert("No deje el campo vacio");
            }
            else
            {
                GridView1.DataBind();
                string Estado = "";
                Docentes ObjDocente = new Docentes();
                SesionU ObjSesion = new SesionU();
                Cursos ObjCurso = new Cursos();
                try
                {
                    DataSet DatosDocente = ObjDocente.ConsultarDocente(TextBox1.Text, "IdentificacionDoc");

                    DataTable DatosConsultados = DatosDocente.Tables["DatosConsultados"];

                    int numregistros = DatosConsultados.Rows.Count;

                    if (numregistros == 0)
                    {
                        MessageBox.alert("No existe en la Base de Datos Docente con esta identificación o el Docente se encuentra inactivo");

                    }
                    else
                    {
                        Estado = DatosConsultados.Rows[0]["Estado"].ToString();
                    }



                    if (Estado == "Activo")
                    {
                        ObjDocente.IdentificacionDoc = int.Parse(TextBox6.Text);
                        ObjDocente.Nombres = TextBox18.Text;
                        ObjDocente.Apellidos = TextBox19.Text;
                        ObjDocente.Direccion = TextBox2.Text;
                        ObjDocente.Eps = TextBox3.Text;
                        ObjDocente.Jornada = DropDownList3.SelectedItem.Text;
                        ObjDocente.Num_Contacto = TextBox5.Text;
                        ObjDocente.Email = TextBox7.Text;
                        ObjDocente.Profesion = TextBox9.Text;




                        ObjSesion.Usuario = int.Parse(TextBox6.Text);
                        ObjSesion.Contraseña = TextBox8.Text;


                        Label1.Text = TextBox18.Text;
                        Label2.Text = TextBox19.Text;
                        Label3.Text = TextBox2.Text;
                        Label4.Text = TextBox3.Text;
                        Label5.Text = DropDownList3.Text;
                        Label6.Text = TextBox5.Text;
                        Label7.Text = TextBox6.Text;
                        Label8.Text = TextBox7.Text;
                        Label9.Text = TextBox8.Text;
                        Label10.Text = TextBox9.Text;


                        bool respuestaSQL = ObjDocente.ActualizarDocente();
                        bool respuestaSQL2 = ObjSesion.ActualizarSesion();

                        if (respuestaSQL == true && respuestaSQL2 == true)
                        {
                            MessageBox.alert("Los datos del docente se han actualizado correctamente");


                        }
                        else { MessageBox.alert(ObjDocente.Mensaje); }

                    }
                    else
                    {
                        MessageBox.alert("No se puede actualizar el docente porque se encuentra inactivo o no existe");
                    }



                }
                catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjDocente.Mensaje); }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            if (TextBox1.Text == "")
            {
                MessageBox.alert("No deje el campo vacio");
            }
            else
            {
                GridView1.DataBind();
                Docentes ObjDocente = new Docentes();


                try
                {
                    bool respuestaSQL = ObjDocente.CambiarEstado(TextBox1.Text);


                    if (respuestaSQL == true)
                    {
                        TextBox6.Text = "";
                        TextBox18.Text = "";
                        TextBox19.Text = "";
                        TextBox2.Text = "";
                        TextBox3.Text = "";
                        TextBox5.Text = "";
                        TextBox7.Text = "";
                        TextBox8.Text = "";
                        TextBox18.Text = "";
                        TextBox9.Text = "";



                        Label1.Text = "";
                        Label2.Text = "";
                        Label3.Text = "";
                        Label4.Text = "";
                        Label5.Text = "";
                        Label6.Text = "";
                        Label7.Text = "";
                        Label8.Text = "";
                        Label9.Text = "";
                        Label10.Text = "";


                        MessageBox.alert("El docente ha cambiado su estado a inactivo correctamente");


                    }
                    else { MessageBox.alert(ObjDocente.Mensaje); }
                }

                catch (Exception Ex)
                {
                    MessageBox.alert("Error!: " + Ex.Message + " " + ObjDocente.Mensaje);

                }

            }
        }

     


        protected void Button3_Click(object sender, EventArgs e)
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

        protected void Button4_Click(object sender, EventArgs e)
        {

            if (TextBox1.Text == "")
            {
                MessageBox.alert("No deje el campo vacio");
            }
            else
            {

                TextBox6.Text = "";
                TextBox18.Text = "";
                TextBox19.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox5.Text = "";
                TextBox7.Text = "";
                TextBox8.Text = "";
                TextBox18.Text = "";
                TextBox9.Text = "";
                GridView1.DataBind();

                Label1.Text = "";
                Label2.Text = "";
                Label3.Text = "";
                Label4.Text = "";
                Label5.Text = "";
                Label6.Text = "";
                Label7.Text = "";
                Label8.Text = "";
                Label9.Text = "";
                Label10.Text = "";


                Docentes ObjDocente = new Docentes();
                Cursos ObjCurso = new Cursos();
                SesionU ObjSesion = new SesionU();
                string identificacion;
                string contraseña;

                try
                {
                    DataSet DatosDocente = ObjDocente.ConsultarDocente(TextBox1.Text, "IdentificacionDoc");


                    DataTable DatosConsultados = DatosDocente.Tables["DatosConsultados"];


                    int numregistros = DatosConsultados.Rows.Count;


                    if (numregistros == 0 || DatosConsultados.Rows[0]["Estado"].ToString() == "Inactivo")
                    {
                        MessageBox.alert("No existe en la Base de Datos Docente con esta identificación o el Estudiante se encuentra inactivo");




                    }

                    else
                    {
                        TextBox18.Text = DatosConsultados.Rows[0]["Nombres"].ToString();
                        Label1.Text = DatosConsultados.Rows[0]["Nombres"].ToString();
                        TextBox19.Text = DatosConsultados.Rows[0]["Apellidos"].ToString();
                        Label2.Text = DatosConsultados.Rows[0]["Apellidos"].ToString();
                        TextBox2.Text = DatosConsultados.Rows[0]["Direccion"].ToString();
                        Label3.Text = DatosConsultados.Rows[0]["Direccion"].ToString();
                        TextBox3.Text = DatosConsultados.Rows[0]["Eps"].ToString();
                        Label4.Text = DatosConsultados.Rows[0]["Eps"].ToString();
                        Label5.Text = DatosConsultados.Rows[0]["Jornada"].ToString();
                        TextBox5.Text = DatosConsultados.Rows[0]["Num_Contacto"].ToString();
                        Label6.Text = DatosConsultados.Rows[0]["Num_Contacto"].ToString();
                        TextBox6.Text = DatosConsultados.Rows[0]["IdentificacionDoc"].ToString();
                        Label7.Text = DatosConsultados.Rows[0]["IdentificacionDoc"].ToString();
                        TextBox7.Text = DatosConsultados.Rows[0]["Email"].ToString();
                        Label8.Text = DatosConsultados.Rows[0]["Email"].ToString();
                        DropDownList3.SelectedValue = DatosConsultados.Rows[0]["Jornada"].ToString();

                        identificacion = DatosConsultados.Rows[0]["IdentificacionDoc"].ToString();
                        Label10.Text = DatosConsultados.Rows[0]["Profesion"].ToString();
                        TextBox9.Text = DatosConsultados.Rows[0]["Profesion"].ToString();



                    }
                }




                catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjDocente.Mensaje); }
                try
                {
                    DataSet DatosSesion = ObjSesion.ConsultarSesion(TextBox1.Text, "Usuario");


                    DataTable DatosConsultados = DatosSesion.Tables["DatosConsultados"];


                    int numregistros = DatosConsultados.Rows.Count;


                    if (numregistros == 0)
                    {
                        MessageBox.alert("No existe en la Base de Datos Usuario con esta identificación");
                    }
                    else
                    {


                        Label9.Text = DatosConsultados.Rows[0]["Contraseña"].ToString();
                        TextBox8.Text = DatosConsultados.Rows[0]["Contraseña"].ToString();


                    }
                }




                catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjSesion.Mensaje); }
            }
        }
    }
}