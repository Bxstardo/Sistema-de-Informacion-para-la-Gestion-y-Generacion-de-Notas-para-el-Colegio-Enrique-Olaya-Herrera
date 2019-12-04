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
    public partial class Modacudiente : System.Web.UI.Page
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
                Acudientes ObjAcudiente = new Acudientes();
                SesionU ObjSesion = new SesionU();
                try
                {
                    DataSet DatosAcudiente = ObjAcudiente.ConsultarAcudiente(TextBox1.Text, "IdentificacionAcu");

                    DataTable DatosConsultados = DatosAcudiente.Tables["DatosConsultados"];

                    int numregistros = DatosConsultados.Rows.Count;

                    if (numregistros == 0)
                    {
                        MessageBox.alert("No existe en la base de datos Acudientes con esta identificación o el Acudiente se encuentra inactivo");

                    }
                    else
                    {
                        Estado = DatosConsultados.Rows[0]["Estado"].ToString();

                    }




                    if (Estado == "Activo")
                    {

                        ObjAcudiente.IdentificacionAcu = int.Parse(TextBox6.Text);
                        ObjAcudiente.Nombres = TextBox18.Text;
                        ObjAcudiente.Apellidos = TextBox19.Text;
                        ObjAcudiente.Direccion = TextBox2.Text;
             
                        ObjAcudiente.Num_Contacto = TextBox5.Text;
                        ObjAcudiente.Email = TextBox7.Text;

                        ObjSesion.Usuario = int.Parse(TextBox6.Text);
                        ObjSesion.Contraseña = TextBox8.Text;

                        Label1.Text = TextBox18.Text;
                        Label2.Text = TextBox19.Text;
                        Label3.Text = TextBox2.Text;
                     

                        Label6.Text = TextBox5.Text;
                        Label7.Text = TextBox6.Text;
                        Label8.Text = TextBox7.Text;
                        Label9.Text = TextBox8.Text;
                   

                        bool respuestaSQL = ObjAcudiente.ActualizarAcudiente();
                        bool respuestaSQL2 = ObjSesion.ActualizarSesion();

                        if (respuestaSQL == true && respuestaSQL2 == true)
                        {
                            MessageBox.alert("Los datos del acudiente fueron actualizados correctamente");


                        }
                        else { MessageBox.alert(ObjAcudiente.Mensaje); }
                    }
                    else
                    {
                        MessageBox.alert("No se puede actualizar el acudiente porque se encuentra inactivo o no existe");
                    }



                }
                catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjAcudiente.Mensaje); }
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
                Acudientes ObjAcudiente = new Acudientes();
                GridView1.DataBind();

                try
                {
                    bool respuestaSQL = ObjAcudiente.CambiarEstado(TextBox1.Text);


                    if (respuestaSQL == true)
                    {
                        TextBox6.Text = "";
                        TextBox18.Text = "";
                        TextBox19.Text = "";
                        TextBox2.Text = "";
                       
                        TextBox5.Text = "";
                        TextBox7.Text = "";
                        TextBox8.Text = "";
                        TextBox18.Text = "";



                        Label1.Text = "";
                        Label2.Text = "";
                        Label3.Text = "";
                        

                        Label6.Text = "";
                        Label7.Text = "";
                        Label8.Text = "";
                        Label9.Text = "";
        


                        MessageBox.alert("El acudiente ha cambiado su estado a inactivo correctamente");


                    }
                    else { MessageBox.alert(ObjAcudiente.Mensaje); }
                }

                catch (Exception Ex)
                {
                    MessageBox.alert("Error!: " + Ex.Message + " " + ObjAcudiente.Mensaje);

                }
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
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

        protected void Button4_Click(object sender, EventArgs e)
        {

            if (TextBox1.Text == "")
            {
                MessageBox.alert("No deje el campo vacio");
            }
            else
            {

                GridView1.DataBind();

                TextBox6.Text = "";
                TextBox18.Text = "";
                TextBox19.Text = "";
                TextBox2.Text = "";
        
                TextBox5.Text = "";
                TextBox7.Text = "";
                TextBox8.Text = "";
                TextBox18.Text = "";



                Label1.Text = "";
                Label2.Text = "";
                Label3.Text = "";
  

                Label6.Text = "";
                Label7.Text = "";
                Label8.Text = "";
                Label9.Text = "";
                


                Acudientes ObjAcudiente = new Acudientes();

                SesionU ObjSesion = new SesionU();
                string identificacion;
                string contraseña;
                try
                {

                    DataSet DatosAcudiente = ObjAcudiente.ConsultarAcudiente(TextBox1.Text, "IdentificacionAcu");

                    DataTable DatosConsultados = DatosAcudiente.Tables["DatosConsultados"];

                    int numregistros = DatosConsultados.Rows.Count;

                    if (numregistros == 0 || DatosConsultados.Rows[0]["Estado"].ToString() == "Inactivo")
                    {
                        MessageBox.alert("No existe en la Base de Datos Acudiente con esta identificación o el Acudiente se encuentra inactivo");




                    }
                    else
                    {

                        TextBox18.Text = DatosConsultados.Rows[0]["Nombres"].ToString();
                        Label1.Text = DatosConsultados.Rows[0]["Nombres"].ToString();
                        TextBox19.Text = DatosConsultados.Rows[0]["Apellidos"].ToString();
                        Label2.Text = DatosConsultados.Rows[0]["Apellidos"].ToString();
                        TextBox2.Text = DatosConsultados.Rows[0]["Direccion"].ToString();
                        Label3.Text = DatosConsultados.Rows[0]["Direccion"].ToString();
     
                        TextBox5.Text = DatosConsultados.Rows[0]["Num_Contacto"].ToString();
                        Label6.Text = DatosConsultados.Rows[0]["Num_Contacto"].ToString();
                        TextBox6.Text = DatosConsultados.Rows[0]["IdentificacionAcu"].ToString();
                        Label7.Text = DatosConsultados.Rows[0]["IdentificacionAcu"].ToString();
                        TextBox7.Text = DatosConsultados.Rows[0]["Email"].ToString();
                        Label8.Text = DatosConsultados.Rows[0]["Email"].ToString();
                        identificacion = DatosConsultados.Rows[0]["IdentificacionAcu"].ToString();


                        try
                        {
                            DataSet DatosSesion = ObjSesion.ConsultarSesion(identificacion, "Usuario");

                            DataTable DatosConsultados2 = DatosSesion.Tables["DatosConsultados"];

                            int numregistros2 = DatosConsultados2.Rows.Count;

                            if (numregistros2 == 0)
                            {


                            }
                            else
                            {

                                contraseña = DatosConsultados2.Rows[0]["Contraseña"].ToString();
                                Label9.Text = contraseña;
                                TextBox8.Text = contraseña;

                            }
                        }
                        catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjSesion.Mensaje); }


                    }
                }




                catch (Exception Ex) { }
               
            }
        }
    }
}