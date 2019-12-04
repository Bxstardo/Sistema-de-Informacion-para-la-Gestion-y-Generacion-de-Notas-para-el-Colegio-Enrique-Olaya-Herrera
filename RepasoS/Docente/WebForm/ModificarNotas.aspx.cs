using LogicaV;
using RepasoS.scripts;
using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace RepasoS.Docente.WebForm
{
    public partial class ModificarNotas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


          
        }

        public void CargarNota()
        {
            Asignaturas ObjAsignatura = new Asignaturas();
            Notas ObjNota = new Notas();
            int NotaS1 = 0;
            int NotaS2 = 0;
            int Final = 0;
            string escala1 = "";
            string escala2 = "";

            try
            {
                DataSet DatosAsignatura = ObjAsignatura.ConsultarAS(Session["IdentificacionDoc"].ToString());

                DataTable DatosConsultados = DatosAsignatura.Tables["DatosConsultados"];

                int numregistros = DatosConsultados.Rows.Count;

                if (numregistros == 0)
                {
                    MessageBox.alert("El docente no tiene asignaturas asignadas");
                }
                else
                {

                    for (int i = 0; i <= numregistros - 1; i++)
                    {
                        Div1.Controls.Add(new LiteralControl("<tr>"));

                        Label objTemporal = new Label();

                        Div1.Controls.Add(new LiteralControl("<td>"));

                        Div1.Controls.Add(objTemporal);

                        objTemporal.Text = DatosConsultados.Rows[i]["Asignatura"].ToString();

                        Div1.Controls.Add(new LiteralControl("</td>"));


                        try
                        {

                            DataSet DatosNotas2 = ObjNota.ConsultarNota(int.Parse(TextBox2.Text), "Primer Semestre", "Primer Corte", DatosConsultados.Rows[i]["Asignatura"].ToString());

                            DataTable DatosConsultados2 = DatosNotas2.Tables["DatosConsultados"];

                            int numregistros2 = DatosConsultados2.Rows.Count;

                            if (numregistros2 == 0)
                            {

                                Div1.Controls.Add(new LiteralControl("<td>"));

                                Div1.Controls.Add(new LiteralControl("</td>"));


                                Div1.Controls.Add(new LiteralControl("<td>"));

                                Div1.Controls.Add(new LiteralControl("</td>"));


                                Div1.Controls.Add(new LiteralControl("<td>"));

                                Div1.Controls.Add(new LiteralControl("</td>"));


                                Div1.Controls.Add(new LiteralControl("<td>"));

                                Div1.Controls.Add(new LiteralControl("</td>"));

                                Div1.Controls.Add(new LiteralControl("<td>"));

                                Div1.Controls.Add(new LiteralControl("</td>"));


                                Div1.Controls.Add(new LiteralControl("<td>"));

                                Div1.Controls.Add(new LiteralControl("</td>"));


                                Div1.Controls.Add(new LiteralControl("<td>"));

                                Div1.Controls.Add(new LiteralControl("</td>"));


                                Div1.Controls.Add(new LiteralControl("<td>"));

                                Div1.Controls.Add(new LiteralControl("</td>"));

                                Div1.Controls.Add(new LiteralControl("<td>"));

                                Div1.Controls.Add(new LiteralControl("</td>"));

                            }
                            else
                            {

                                Label objTemporal2 = new Label();

                                Div1.Controls.Add(new LiteralControl("<td>"));

                                Div1.Controls.Add(objTemporal2);

                                objTemporal2.Text = DatosConsultados2.Rows[0]["Nota"].ToString();

                                Div1.Controls.Add(new LiteralControl("</td>"));

                                NotaS1 = int.Parse(DatosConsultados2.Rows[0]["Nota"].ToString());

                                try
                                {

                                    DataSet DatosNotas3 = ObjNota.ConsultarNota(int.Parse(TextBox2.Text), "Primer Semestre", "Segundo Corte", DatosConsultados.Rows[i]["Asignatura"].ToString());

                                    DataTable DatosConsultados3 = DatosNotas3.Tables["DatosConsultados"];

                                    int numregistros3 = DatosConsultados3.Rows.Count;

                                    if (numregistros3 == 0)
                                    {

                                        Div1.Controls.Add(new LiteralControl("<td>"));

                                        Div1.Controls.Add(new LiteralControl("</td>"));


                                        Div1.Controls.Add(new LiteralControl("<td>"));

                                        Div1.Controls.Add(new LiteralControl("</td>"));


                                        Div1.Controls.Add(new LiteralControl("<td>"));

                                        Div1.Controls.Add(new LiteralControl("</td>"));




                                        Label objTemporal6 = new Label();

                                        Div1.Controls.Add(new LiteralControl("<td>"));

                                        Div1.Controls.Add(objTemporal6);

                                        objTemporal6.Text = NotaS1.ToString();

                                        Div1.Controls.Add(new LiteralControl("</td>"));


                                        Div1.Controls.Add(new LiteralControl("<td>"));

                                        Div1.Controls.Add(new LiteralControl("</td>"));

                                        if (NotaS1 <= 59)
                                        {
                                            escala1 = "Bajo";

                                        }
                                        else if (NotaS1 >= 60 && NotaS1 <= 70)
                                        {
                                            escala1 = "Basico";
                                        }
                                        else if (NotaS1 >= 71 && NotaS1 <= 89)
                                        {
                                            escala1 = "Ato";
                                        }
                                        else if (NotaS1 >= 90 && NotaS1 <= 100)
                                        {
                                            escala1 = "Superior";
                                        }

                                        Label objTemporal9 = new Label();

                                        Div1.Controls.Add(new LiteralControl("<td>"));

                                        Div1.Controls.Add(objTemporal9);

                                        objTemporal9.Text = escala1;

                                        Div1.Controls.Add(new LiteralControl("</td>"));

                                        Div1.Controls.Add(new LiteralControl("<td>"));

                                        Div1.Controls.Add(new LiteralControl("</td>"));



                                        Label objTemporal8 = new Label();

                                        Div1.Controls.Add(new LiteralControl("<td>"));

                                        Div1.Controls.Add(objTemporal8);

                                        objTemporal8.Text = NotaS1.ToString();

                                        Div1.Controls.Add(new LiteralControl("</td>"));
                                    }
                                    else
                                    {

                                        Label objTemporal3 = new Label();

                                        Div1.Controls.Add(new LiteralControl("<td>"));

                                        Div1.Controls.Add(objTemporal3);

                                        objTemporal3.Text = DatosConsultados3.Rows[0]["Nota"].ToString();

                                        Div1.Controls.Add(new LiteralControl("</td>"));

                                        NotaS1 = NotaS1 + int.Parse(DatosConsultados3.Rows[0]["Nota"].ToString());

                                        try
                                        {

                                            DataSet DatosNotas4 = ObjNota.ConsultarNota(int.Parse(TextBox2.Text), "Segundo Semestre", "Primer Corte", DatosConsultados.Rows[i]["Asignatura"].ToString());

                                            DataTable DatosConsultados4 = DatosNotas4.Tables["DatosConsultados"];

                                            int numregistros4 = DatosConsultados4.Rows.Count;

                                            if (numregistros4 == 0)
                                            {

                                                Div1.Controls.Add(new LiteralControl("<td>"));

                                                Div1.Controls.Add(new LiteralControl("</td>"));


                                                Div1.Controls.Add(new LiteralControl("<td>"));

                                                Div1.Controls.Add(new LiteralControl("</td>"));

                                                Label objTemporal6 = new Label();

                                                Div1.Controls.Add(new LiteralControl("<td>"));

                                                Div1.Controls.Add(objTemporal6);

                                                objTemporal6.Text = NotaS1.ToString();

                                                Div1.Controls.Add(new LiteralControl("</td>"));


                                                Div1.Controls.Add(new LiteralControl("<td>"));

                                                Div1.Controls.Add(new LiteralControl("</td>"));

                                                if (NotaS1 <= 59)
                                                {
                                                    escala1 = "Bajo";

                                                }
                                                else if (NotaS1 >= 60 && NotaS1 <= 70)
                                                {
                                                    escala1 = "Basico";
                                                }
                                                else if (NotaS1 >= 71 && NotaS1 <= 89)
                                                {
                                                    escala1 = "Alto";
                                                }
                                                else if (NotaS1 >= 90 && NotaS1 <= 100)
                                                {
                                                    escala1 = "Superior";
                                                }

                                                else
                                                {
                                                    escala1 = "";
                                                }


                                                Label objTemporal10 = new Label();

                                                Div1.Controls.Add(new LiteralControl("<td>"));

                                                Div1.Controls.Add(objTemporal10);

                                                objTemporal10.Text = escala1;

                                                Div1.Controls.Add(new LiteralControl("</td>"));



                                                Div1.Controls.Add(new LiteralControl("<td>"));

                                                Div1.Controls.Add(new LiteralControl("</td>"));


                                                Label objTemporal8 = new Label();

                                                Div1.Controls.Add(new LiteralControl("<td>"));

                                                Div1.Controls.Add(objTemporal8);

                                                objTemporal8.Text = NotaS1.ToString();

                                                Div1.Controls.Add(new LiteralControl("</td>"));
                                            }
                                            else
                                            {

                                                Label objTemporal4 = new Label();

                                                Div1.Controls.Add(new LiteralControl("<td>"));

                                                Div1.Controls.Add(objTemporal4);

                                                objTemporal4.Text = DatosConsultados4.Rows[0]["Nota"].ToString();

                                                Div1.Controls.Add(new LiteralControl("</td>"));

                                                NotaS2 = int.Parse(DatosConsultados4.Rows[0]["Nota"].ToString());

                                                try
                                                {

                                                    DataSet DatosNotas5 = ObjNota.ConsultarNota(int.Parse(TextBox2.Text), "Segundo Semestre", "Segundo Corte", DatosConsultados.Rows[i]["Asignatura"].ToString());

                                                    DataTable DatosConsultados5 = DatosNotas5.Tables["DatosConsultados"];

                                                    int numregistros5 = DatosConsultados5.Rows.Count;

                                                    if (numregistros5 == 0)
                                                    {

                                                        Div1.Controls.Add(new LiteralControl("<td>"));

                                                        Div1.Controls.Add(new LiteralControl("</td>"));

                                                        Label objTemporal6 = new Label();

                                                        Div1.Controls.Add(new LiteralControl("<td>"));

                                                        Div1.Controls.Add(objTemporal6);

                                                        objTemporal6.Text = NotaS1.ToString();

                                                        Div1.Controls.Add(new LiteralControl("</td>"));


                                                        Label objTemporal7 = new Label();

                                                        Div1.Controls.Add(new LiteralControl("<td>"));

                                                        Div1.Controls.Add(objTemporal7);

                                                        objTemporal7.Text = NotaS2.ToString();

                                                        Div1.Controls.Add(new LiteralControl("</td>"));


                                                        if (NotaS1 <= 59)
                                                        {
                                                            escala1 = "Bajo";

                                                        }
                                                        else if (NotaS1 >= 60 && NotaS1 <= 70)
                                                        {
                                                            escala1 = "Basico";
                                                        }
                                                        else if (NotaS1 >= 71 && NotaS1 <= 89)
                                                        {
                                                            escala1 = "Alto";
                                                        }
                                                        else if (NotaS1 >= 90 && NotaS1 <= 100)
                                                        {
                                                            escala1 = "Superior";
                                                        }

                                                        else
                                                        {
                                                            escala1 = "";
                                                        }


                                                        Label objTemporal10 = new Label();

                                                        Div1.Controls.Add(new LiteralControl("<td>"));

                                                        Div1.Controls.Add(objTemporal10);

                                                        objTemporal10.Text = escala1;

                                                        Div1.Controls.Add(new LiteralControl("</td>"));


                                                        if (NotaS2 <= 59)
                                                        {
                                                            escala2 = "Bajo";
                                                        }
                                                        else if (NotaS2 >= 60 && NotaS2 <= 70)
                                                        {
                                                            escala2 = "Basico";
                                                        }
                                                        else if (NotaS2 >= 71 && NotaS2 <= 89)
                                                        {
                                                            escala2 = "Alto";
                                                        }
                                                        else if (NotaS2 >= 90 && NotaS2 <= 100)
                                                        {
                                                            escala2 = "Superior";
                                                        }

                                                        else
                                                        {
                                                            escala2 = "";
                                                        }

                                                        Label objTemporal9 = new Label();

                                                        Div1.Controls.Add(new LiteralControl("<td>"));

                                                        Div1.Controls.Add(objTemporal9);

                                                        objTemporal9.Text = escala2;

                                                        Div1.Controls.Add(new LiteralControl("</td>"));


                                                        Label objTemporal8 = new Label();

                                                        Div1.Controls.Add(new LiteralControl("<td>"));

                                                        Div1.Controls.Add(objTemporal8);

                                                        objTemporal8.Text = NotaS1.ToString();

                                                        Div1.Controls.Add(new LiteralControl("</td>"));
                                                    }
                                                    else
                                                    {


                                                        Label objTemporal5 = new Label();

                                                        Div1.Controls.Add(new LiteralControl("<td>"));

                                                        Div1.Controls.Add(objTemporal5);

                                                        objTemporal5.Text = DatosConsultados5.Rows[0]["Nota"].ToString();

                                                        Div1.Controls.Add(new LiteralControl("</td>"));


                                                        NotaS2 = NotaS2 + int.Parse(DatosConsultados5.Rows[0]["Nota"].ToString());

                                                        Label objTemporal6 = new Label();

                                                        Div1.Controls.Add(new LiteralControl("<td>"));

                                                        Div1.Controls.Add(objTemporal6);

                                                        objTemporal6.Text = NotaS1.ToString();

                                                        Div1.Controls.Add(new LiteralControl("</td>"));



                                                        Label objTemporal7 = new Label();

                                                        Div1.Controls.Add(new LiteralControl("<td>"));

                                                        Div1.Controls.Add(objTemporal7);

                                                        objTemporal7.Text = NotaS2.ToString();

                                                        Div1.Controls.Add(new LiteralControl("</td>"));

                                                        if (NotaS1 <= 59)
                                                        {
                                                            escala1 = "Bajo";

                                                        }
                                                        else if (NotaS1 >= 60 && NotaS1 <= 70)
                                                        {
                                                            escala1 = "Basico";
                                                        }
                                                        else if (NotaS1 >= 71 && NotaS1 <= 89)
                                                        {
                                                            escala1 = "Alto";
                                                        }
                                                        else if (NotaS1 >= 90 && NotaS1 <= 100)
                                                        {
                                                            escala1 = "Superior";
                                                        }

                                                        else
                                                        {
                                                            escala1 = "";
                                                        }

                                                        if (NotaS2 <= 59)
                                                        {
                                                            escala2 = "Bajo";
                                                        }
                                                        else if (NotaS2 >= 60 && NotaS2 <= 70)
                                                        {
                                                            escala2 = "Basico";
                                                        }
                                                        else if (NotaS2 >= 71 && NotaS2 <= 89)
                                                        {
                                                            escala2 = "Alto";
                                                        }
                                                        else if (NotaS2 >= 90 && NotaS2 <= 100)
                                                        {
                                                            escala2 = "Superior";
                                                        }

                                                        else
                                                        {
                                                            escala2 = "";
                                                        }



                                                        Label objTemporal9 = new Label();

                                                        Div1.Controls.Add(new LiteralControl("<td>"));

                                                        Div1.Controls.Add(objTemporal9);

                                                        objTemporal9.Text = escala1;

                                                        Div1.Controls.Add(new LiteralControl("</td>"));



                                                        Label objTemporal10 = new Label();

                                                        Div1.Controls.Add(new LiteralControl("<td>"));

                                                        Div1.Controls.Add(objTemporal10);

                                                        objTemporal10.Text = escala2;

                                                        Div1.Controls.Add(new LiteralControl("</td>"));



                                                        Final = NotaS1 + NotaS2;

                                                        Label objTemporal8 = new Label();

                                                        Div1.Controls.Add(new LiteralControl("<td>"));

                                                        Div1.Controls.Add(objTemporal8);

                                                        objTemporal8.Text = Final.ToString();

                                                        Div1.Controls.Add(new LiteralControl("</td>"));

                                                    }


                                                }
                                                catch (Exception Ex) { MessageBox.alert("Error!: 1 " + Ex.Message + " " + ObjNota.Mensaje); }


                                            }


                                        }
                                        catch (Exception Ex) { MessageBox.alert("Error!: 1 " + Ex.Message + " " + ObjNota.Mensaje); }



                                    }


                                }
                                catch (Exception Ex) { MessageBox.alert("Error!: 1 " + Ex.Message + " " + ObjNota.Mensaje); }

                            }


                        }
                        catch (Exception Ex) { MessageBox.alert("Error!: 1 " + Ex.Message + " " + ObjNota.Mensaje); }

                        Div1.Controls.Add(new LiteralControl("</tr>"));
                    }






                }


            }
            catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjAsignatura.Mensaje); }

        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            Estudiantes ObjEstudiante = new Estudiantes();

            try
            {
                DataSet DatosEstudiante = ObjEstudiante.ConsultarEstudianteTodos2();

                DataTable DatosConsultados = DatosEstudiante.Tables["DatosConsultados"];

                int numregistros = DatosConsultados.Rows.Count;

                if (numregistros == 0)
                {
                    MessageBox.alert("No hay datos en la base de datos");
                }
                else
                {
                    GridView1.DataSource = DatosConsultados;
                    GridView1.DataBind();
                    GridView1.Visible = true;


                }

            }

            catch (Exception ex) { MessageBox.alert("No se ha podido efectuar la consulta debido al siguiente Error: " + ex.Message); }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            GridView1.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            if (TextBox1.Text == "")
            {
                MessageBox.alert("No deje ningun campo vacio");
            }
            else
            {
                Notas ObjNota = new Notas();
                Asignaciones ObjAsig = new Asignaciones();
                try
                {
                    ObjAsig.IdentificacionDoc = int.Parse(Session["IdentificacionDoc"].ToString());
                    bool RespuestaSql = ObjAsig.InsertarAsignacion(int.Parse(TextBox2.Text), DropDownList1.Text);

                    if (RespuestaSql == true)
                    {

                        try
                        {

                            DataSet DatosAsig = ObjAsig.ConsultarAsignacion(TextBox2.Text, DropDownList1.Text, Session["IdentificacionDoc"].ToString(), "Id_Asignaciones");

                            DataTable DatosConsultados = DatosAsig.Tables["DatosConsultados"];

                            int numregistros = DatosConsultados.Rows.Count;


                            if (numregistros == 0)
                            {

                                MessageBox.alert("2 " + ObjAsig.Mensaje);

                            }
                            else
                            {
                                try
                                {
                                    ObjNota.IdentificacionEst = int.Parse(TextBox2.Text);
                                    ObjNota.Nota = int.Parse(TextBox1.Text);
                                    ObjNota.Id_Asignaciones = int.Parse(DatosConsultados.Rows[0]["Id_Asignaciones"].ToString());
                                    ObjNota.Periodo = DropDownList2.Text;
                                    ObjNota.Corte = DropDownList3.Text;

                                    bool RespuestaSql2 = ObjNota.InsertarNota();

                                    if (RespuestaSql2 == true)
                                    {
                                        MessageBox.alert("La nota se ha insertado correctamente");
                                        TextBox1.Text = "";
                                        CargarNota();
                                    }
                                    else
                                    {
                                        MessageBox.alert("3 " + ObjNota.Mensaje);
                                    }

                                }
                                catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjNota.Mensaje); }


                            }

                        }
                        catch (Exception Ex) { MessageBox.alert("Error!:  " + Ex.Message + " " + ObjAsig.Mensaje); }



                    }
                    else
                    {
                        MessageBox.alert("1 " + ObjAsig.Mensaje);
                    }

                }
                catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjAsig.Mensaje); }
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text == "")
            {
                MessageBox.alert("No deje el campo vacio");
            }
            else
            {

                CargarNota();
            }

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = true;

            int Curso= 0;

            Estudiantes ObjEstudiante = new Estudiantes();
            Asignaturas ObjAsignatura = new Asignaturas();
            Notas ObjNota = new Notas();
            int NotaS1 = 0;
            int NotaS2 = 0;
            int Final = 0;
            string escala1 = "";
            string escala2 = "";
            int Prom1 = 0;
            int Prom2 = 0;
            int Prom3 = 0;
            int Prom4 = 0;
            int Proms1 = 0;
            int Proms2 = 0;
            int Proms3 = 0;
            int Proms4 = 0;
            int PromF = 0;
            int K=0;
            int PromFS1 = 0;
            int PromFS2 = 0;
            int FS1 = 0;
            int FS2 = 0;

            try
            {
                DataSet DatosEstudiante = ObjEstudiante.ConsultarEstudianteTodos3(int.Parse(TextBox2.Text));

                DataTable DatosConsultados = DatosEstudiante.Tables["DatosConsultados"];

                int numregistros = DatosConsultados.Rows.Count;

                if (numregistros == 0)
                {

                    

                }
                else
                {
                    Label1.Text = DatosConsultados.Rows[0]["Nombre"].ToString();
                    Label2.Text = DatosConsultados.Rows[0]["Usuario"].ToString();
                    Label8.Text = DatosConsultados.Rows[0]["Apellido"].ToString();
                    Label4.Text = DatosConsultados.Rows[0]["Curso"].ToString();
                    Label9.Text = DatosConsultados.Rows[0]["Jornada"].ToString();
                    Label5.Text = DatosConsultados.Rows[0]["DirectorN"].ToString();
                    Label10.Text = DatosConsultados.Rows[0]["DirectorA"].ToString();
                    Label12.Text = DatosConsultados.Rows[0]["DirectorN"].ToString();
                    Label13.Text = DatosConsultados.Rows[0]["DirectorA"].ToString();

                    Curso = int.Parse(Label4.Text = DatosConsultados.Rows[0]["Curso"].ToString());

                    if (Curso >= 100 && Curso < 200)
                    {
                        Label3.Text = "Primero";
                    }
                    else if (Curso >= 200 && Curso < 300)
                    {
                        Label3.Text = "Segundo";
                    }
                    else if (Curso >= 300 && Curso < 400)
                    {
                        Label3.Text = "Tercero";
                    }

                    else if (Curso >= 400 && Curso < 500)
                    {
                        Label3.Text = "Cuarto";
                    }

                    else if (Curso >= 500 && Curso < 600)
                    {
                        Label3.Text = "Quinto";
                    }

                    else if (Curso >= 600 && Curso < 700)
                    {
                        Label3.Text = "Sexto";
                    }

                    else if (Curso >= 700 && Curso < 800)
                    {
                        Label3.Text = "Septimo";
                    }

                    else if (Curso >= 800 && Curso < 900)
                    {
                        Label3.Text = "Octavo";
                    }

                    else if (Curso >= 900 && Curso < 1000)
                    {
                        Label3.Text = "Noveno";
                    }

                    else if (Curso >= 1000 && Curso < 1100)
                    {
                        Label3.Text = "Decimo";
                    }

                    else if (Curso >= 1100 && Curso < 1200)
                    {
                        Label3.Text = "Once";
                    }


                }

            }

            catch (Exception ex) { MessageBox.alert("No se ha podido efectuar la consulta debido al siguiente Error: " + ex.Message); }

            


            try
            {
                DataSet DatosAsignatura = ObjAsignatura.ConsultarAsignaturaTodos3();

                DataTable DatosConsultados = DatosAsignatura.Tables["DatosConsultados"];

                int numregistros = DatosConsultados.Rows.Count;

                if (numregistros == 0)
                {
                    MessageBox.alert("No existen asignaturas");
                }
                else
                {

                    for (int i = 0; i <= numregistros - 1; i++)
                    {
                        Div2.Controls.Add(new LiteralControl("<tr>"));

                        Label objTemporal = new Label();

                        Div2.Controls.Add(new LiteralControl("<td>"));

                        Div2.Controls.Add(objTemporal);

                        objTemporal.Text = DatosConsultados.Rows[i]["Asignatura"].ToString();

                        Div2.Controls.Add(new LiteralControl("</td>"));


                        try
                        {

                            DataSet DatosNotas2 = ObjNota.ConsultarNota(int.Parse(TextBox2.Text), "Primer Semestre", "Primer Corte", DatosConsultados.Rows[i]["Asignatura"].ToString());

                            DataTable DatosConsultados2 = DatosNotas2.Tables["DatosConsultados"];

                            int numregistros2 = DatosConsultados2.Rows.Count;

                            if (numregistros2 == 0)
                            {

                                Div2.Controls.Add(new LiteralControl("<td>"));

                                Div2.Controls.Add(new LiteralControl("</td>"));


                                Div2.Controls.Add(new LiteralControl("<td>"));

                                Div2.Controls.Add(new LiteralControl("</td>"));


                                Div2.Controls.Add(new LiteralControl("<td>"));

                                Div2.Controls.Add(new LiteralControl("</td>"));

                                Div2.Controls.Add(new LiteralControl("<td>"));

                                Div2.Controls.Add(new LiteralControl("</td>"));

                                Div2.Controls.Add(new LiteralControl("<td>"));

                                Div2.Controls.Add(new LiteralControl("</td>"));


                                Div2.Controls.Add(new LiteralControl("<td>"));

                                Div2.Controls.Add(new LiteralControl("</td>"));


                                Div2.Controls.Add(new LiteralControl("<td>"));

                                Div2.Controls.Add(new LiteralControl("</td>"));


                                Div2.Controls.Add(new LiteralControl("<td>"));

                                Div2.Controls.Add(new LiteralControl("</td>"));

                                Div2.Controls.Add(new LiteralControl("<td>"));

                                Div2.Controls.Add(new LiteralControl("</td>"));

                            }
                            else
                            {

                                Label objTemporal2 = new Label();

                                Div2.Controls.Add(new LiteralControl("<td>"));

                                Div2.Controls.Add(objTemporal2);

                                objTemporal2.Text = DatosConsultados2.Rows[0]["Nota"].ToString();

                                Div2.Controls.Add(new LiteralControl("</td>"));

                                NotaS1 = int.Parse(DatosConsultados2.Rows[0]["Nota"].ToString());

                                try
                                {

                                    DataSet DatosNotas3 = ObjNota.ConsultarNota(int.Parse(TextBox2.Text), "Primer Semestre", "Segundo Corte", DatosConsultados.Rows[i]["Asignatura"].ToString());

                                    DataTable DatosConsultados3 = DatosNotas3.Tables["DatosConsultados"];

                                    int numregistros3 = DatosConsultados3.Rows.Count;

                                    if (numregistros3 == 0)
                                    {

                                        Div2.Controls.Add(new LiteralControl("<td>"));

                                        Div2.Controls.Add(new LiteralControl("</td>"));


                                        Div2.Controls.Add(new LiteralControl("<td>"));

                                        Div2.Controls.Add(new LiteralControl("</td>"));


                                        Div2.Controls.Add(new LiteralControl("<td>"));

                                        Div2.Controls.Add(new LiteralControl("</td>"));




                                        Label objTemporal6 = new Label();

                                        Div2.Controls.Add(new LiteralControl("<td>"));

                                        Div2.Controls.Add(objTemporal6);

                                        objTemporal6.Text = NotaS1.ToString();

                                        Div2.Controls.Add(new LiteralControl("</td>"));


                                        Div2.Controls.Add(new LiteralControl("<td>"));

                                        Div2.Controls.Add(new LiteralControl("</td>"));

                                        if (NotaS1 <= 59)
                                        {
                                            escala1 = "Bajo";

                                        }
                                        else if (NotaS1 >= 60 && NotaS1 <= 70)
                                        {
                                            escala1 = "Basico";
                                        }
                                        else if (NotaS1 >= 71 && NotaS1 <= 89)
                                        {
                                            escala1 = "Alto";
                                        }
                                        else if (NotaS1 >= 90 && NotaS1 <= 100)
                                        {
                                            escala1 = "Superior";
                                        }

                                        Label objTemporal9 = new Label();

                                        Div2.Controls.Add(new LiteralControl("<td>"));

                                        Div2.Controls.Add(objTemporal9);

                                        objTemporal9.Text = escala1;

                                        Div2.Controls.Add(new LiteralControl("</td>"));

                                        Div2.Controls.Add(new LiteralControl("<td>"));

                                        Div2.Controls.Add(new LiteralControl("</td>"));



                                        Label objTemporal8 = new Label();

                                        Div2.Controls.Add(new LiteralControl("<td>"));

                                        Div2.Controls.Add(objTemporal8);

                                        objTemporal8.Text = NotaS1.ToString();

                                        Div2.Controls.Add(new LiteralControl("</td>"));
                                    }
                                    else
                                    {

                                        Label objTemporal3 = new Label();

                                        Div2.Controls.Add(new LiteralControl("<td>"));

                                        Div2.Controls.Add(objTemporal3);

                                        objTemporal3.Text = DatosConsultados3.Rows[0]["Nota"].ToString();

                                        Div2.Controls.Add(new LiteralControl("</td>"));

                                        NotaS1 = NotaS1 + int.Parse(DatosConsultados3.Rows[0]["Nota"].ToString());

                                        try
                                        {

                                            DataSet DatosNotas4 = ObjNota.ConsultarNota(int.Parse(TextBox2.Text), "Segundo Semestre", "Primer Corte", DatosConsultados.Rows[i]["Asignatura"].ToString());

                                            DataTable DatosConsultados4 = DatosNotas4.Tables["DatosConsultados"];

                                            int numregistros4 = DatosConsultados4.Rows.Count;

                                            if (numregistros4 == 0)
                                            {

                                                Div2.Controls.Add(new LiteralControl("<td>"));

                                                Div2.Controls.Add(new LiteralControl("</td>"));


                                                Div2.Controls.Add(new LiteralControl("<td>"));

                                                Div2.Controls.Add(new LiteralControl("</td>"));

                                                Label objTemporal6 = new Label();

                                                Div2.Controls.Add(new LiteralControl("<td>"));

                                                Div2.Controls.Add(objTemporal6);

                                                objTemporal6.Text = NotaS1.ToString();

                                                Div2.Controls.Add(new LiteralControl("</td>"));


                                                Div2.Controls.Add(new LiteralControl("<td>"));

                                                Div2.Controls.Add(new LiteralControl("</td>"));

                                                if (NotaS1 <= 59)
                                                {
                                                    escala1 = "Bajo";

                                                }
                                                else if (NotaS1 >= 60 && NotaS1 <= 70)
                                                {
                                                    escala1 = "Basico";
                                                }
                                                else if (NotaS1 >= 71 && NotaS1 <= 89)
                                                {
                                                    escala1 = "Alto";
                                                }
                                                else if (NotaS1 >= 90 && NotaS1 <= 100)
                                                {
                                                    escala1 = "Superior";
                                                }

                                                else
                                                {
                                                    escala1 = "";
                                                }


                                                Label objTemporal10 = new Label();

                                                Div2.Controls.Add(new LiteralControl("<td>"));

                                                Div2.Controls.Add(objTemporal10);

                                                objTemporal10.Text = escala1;

                                                Div2.Controls.Add(new LiteralControl("</td>"));



                                                Div2.Controls.Add(new LiteralControl("<td>"));

                                                Div2.Controls.Add(new LiteralControl("</td>"));


                                                Label objTemporal8 = new Label();

                                                Div2.Controls.Add(new LiteralControl("<td>"));

                                                Div2.Controls.Add(objTemporal8);

                                                objTemporal8.Text = NotaS1.ToString();

                                                Div2.Controls.Add(new LiteralControl("</td>"));
                                            }
                                            else
                                            {

                                                Label objTemporal4 = new Label();

                                                Div2.Controls.Add(new LiteralControl("<td>"));

                                                Div2.Controls.Add(objTemporal4);

                                                objTemporal4.Text = DatosConsultados4.Rows[0]["Nota"].ToString();

                                                Div2.Controls.Add(new LiteralControl("</td>"));

                                                NotaS2 = int.Parse(DatosConsultados4.Rows[0]["Nota"].ToString());

                                                try
                                                {

                                                    DataSet DatosNotas5 = ObjNota.ConsultarNota(int.Parse(TextBox2.Text), "Segundo Semestre", "Segundo Corte", DatosConsultados.Rows[i]["Asignatura"].ToString());

                                                    DataTable DatosConsultados5 = DatosNotas5.Tables["DatosConsultados"];

                                                    int numregistros5 = DatosConsultados5.Rows.Count;

                                                    if (numregistros5 == 0)
                                                    {

                                                        Div2.Controls.Add(new LiteralControl("<td>"));

                                                        Div2.Controls.Add(new LiteralControl("</td>"));

                                                        Label objTemporal6 = new Label();

                                                        Div2.Controls.Add(new LiteralControl("<td>"));

                                                        Div2.Controls.Add(objTemporal6);

                                                        objTemporal6.Text = NotaS1.ToString();

                                                        Div2.Controls.Add(new LiteralControl("</td>"));


                                                        Label objTemporal7 = new Label();

                                                        Div2.Controls.Add(new LiteralControl("<td>"));

                                                        Div2.Controls.Add(objTemporal7);

                                                        objTemporal7.Text = NotaS2.ToString();

                                                        Div2.Controls.Add(new LiteralControl("</td>"));


                                                        if (NotaS1 <= 59)
                                                        {
                                                            escala1 = "Bajo";

                                                        }
                                                        else if (NotaS1 >= 60 && NotaS1 <= 70)
                                                        {
                                                            escala1 = "Basico";
                                                        }
                                                        else if (NotaS1 >= 71 && NotaS1 <= 89)
                                                        {
                                                            escala1 = "Alto";
                                                        }
                                                        else if (NotaS1 >= 90 && NotaS1 <= 100)
                                                        {
                                                            escala1 = "Superior";
                                                        }

                                                        else
                                                        {
                                                            escala1 = "";
                                                        }


                                                        Label objTemporal10 = new Label();

                                                        Div2.Controls.Add(new LiteralControl("<td>"));

                                                        Div2.Controls.Add(objTemporal10);

                                                        objTemporal10.Text = escala1;

                                                        Div2.Controls.Add(new LiteralControl("</td>"));


                                                        if (NotaS2 <= 59)
                                                        {
                                                            escala2 = "Bajo";
                                                        }
                                                        else if (NotaS2 >= 60 && NotaS2 <= 70)
                                                        {
                                                            escala2 = "Basico";
                                                        }
                                                        else if (NotaS2 >= 71 && NotaS2 <= 89)
                                                        {
                                                            escala2 = "Alto";
                                                        }
                                                        else if (NotaS2 >= 90 && NotaS2 <= 100)
                                                        {
                                                            escala2 = "Superior";
                                                        }

                                                        else
                                                        {
                                                            escala2 = "";
                                                        }

                                                        Label objTemporal9 = new Label();

                                                        Div2.Controls.Add(new LiteralControl("<td>"));

                                                        Div2.Controls.Add(objTemporal9);

                                                        objTemporal9.Text = escala2;

                                                        Div2.Controls.Add(new LiteralControl("</td>"));


                                                        Label objTemporal8 = new Label();

                                                        Div2.Controls.Add(new LiteralControl("<td>"));

                                                        Div2.Controls.Add(objTemporal8);

                                                        objTemporal8.Text = NotaS1.ToString();

                                                        Div2.Controls.Add(new LiteralControl("</td>"));
                                                    }
                                                    else
                                                    {


                                                        Label objTemporal5 = new Label();

                                                        Div2.Controls.Add(new LiteralControl("<td>"));

                                                        Div2.Controls.Add(objTemporal5);

                                                        objTemporal5.Text = DatosConsultados5.Rows[0]["Nota"].ToString();

                                                        Div2.Controls.Add(new LiteralControl("</td>"));


                                                        NotaS2 = NotaS2 + int.Parse(DatosConsultados5.Rows[0]["Nota"].ToString());

                                                        Label objTemporal6 = new Label();

                                                        Div2.Controls.Add(new LiteralControl("<td>"));

                                                        Div2.Controls.Add(objTemporal6);

                                                        objTemporal6.Text = NotaS1.ToString();

                                                        Div2.Controls.Add(new LiteralControl("</td>"));



                                                        Label objTemporal7 = new Label();

                                                        Div2.Controls.Add(new LiteralControl("<td>"));

                                                        Div2.Controls.Add(objTemporal7);

                                                        objTemporal7.Text = NotaS2.ToString();

                                                        Div2.Controls.Add(new LiteralControl("</td>"));

                                                        if (NotaS1 <= 59)
                                                        {
                                                            escala1 = "Bajo";

                                                        }
                                                        else if (NotaS1 >= 60 && NotaS1 <= 70)
                                                        {
                                                            escala1 = "Basico";
                                                        }
                                                        else if (NotaS1 >= 71 && NotaS1 <= 89)
                                                        {
                                                            escala1 = "Alto";
                                                        }
                                                        else if (NotaS1 >= 90 && NotaS1 <= 100)
                                                        {
                                                            escala1 = "Superior";
                                                        }

                                                        else
                                                        {
                                                            escala1 = "";
                                                        }

                                                        if (NotaS2 <= 59)
                                                        {
                                                            escala2 = "Bajo";
                                                        }
                                                        else if (NotaS2 >= 60 && NotaS2 <= 70)
                                                        {
                                                            escala2 = "Basico";
                                                        }
                                                        else if (NotaS2 >= 71 && NotaS2 <= 89)
                                                        {
                                                            escala2 = "Alto";
                                                        }
                                                        else if (NotaS2 >= 90 && NotaS2 <= 100)
                                                        {
                                                            escala2 = "Superior";
                                                        }

                                                        else
                                                        {
                                                            escala2 = "";
                                                        }



                                                        Label objTemporal9 = new Label();

                                                        Div2.Controls.Add(new LiteralControl("<td>"));

                                                        Div2.Controls.Add(objTemporal9);

                                                        objTemporal9.Text = escala1;

                                                        Div2.Controls.Add(new LiteralControl("</td>"));



                                                        Label objTemporal10 = new Label();

                                                        Div2.Controls.Add(new LiteralControl("<td>"));

                                                        Div2.Controls.Add(objTemporal10);

                                                        objTemporal10.Text = escala2;

                                                        Div2.Controls.Add(new LiteralControl("</td>"));



                                                        Final = NotaS1 + NotaS2;

                                                        Label objTemporal8 = new Label();

                                                        Div2.Controls.Add(new LiteralControl("<td>"));

                                                        Div2.Controls.Add(objTemporal8);

                                                        objTemporal8.Text = Final.ToString();

                                                        Div2.Controls.Add(new LiteralControl("</td>"));





                                                    }


                                                }
                                                catch (Exception Ex) { MessageBox.alert("Error!: 1 " + Ex.Message + " " + ObjNota.Mensaje); }


                                            }


                                        }
                                        catch (Exception Ex) { MessageBox.alert("Error!: 1 " + Ex.Message + " " + ObjNota.Mensaje); }



                                    }


                                }
                                catch (Exception Ex) { MessageBox.alert("Error!: 1 " + Ex.Message + " " + ObjNota.Mensaje); }

                            }


                        }
                        catch (Exception Ex) { MessageBox.alert("Error!: 1 " + Ex.Message + " " + ObjNota.Mensaje); }

                        Div2.Controls.Add(new LiteralControl("</tr>"));
                    }






                }


            }
            catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjAsignatura.Mensaje); }


            try
            {
                DataSet DatosAsignatura = ObjAsignatura.ConsultarAreaTodos();

                DataTable DatosConsultados = DatosAsignatura.Tables["DatosConsultados"];

                int numregistros = DatosConsultados.Rows.Count;

                if (numregistros == 0)
                {
       
                }
                else
                {

                    for (int i = 0; i <= numregistros - 1; i++)
                    {
                        Prom1 = 0;
                        Prom2 = 0;
                        Prom3 = 0;
                        Prom4 = 0;
                        Proms1 = 0;
                        Proms2 = 0;
                        Proms3 = 0;
                        Proms4 = 0;
                       

                        Div3.Controls.Add(new LiteralControl("<tr>"));

                        Label objTemporal = new Label();

                        Div3.Controls.Add(new LiteralControl("<td>"));

                        Div3.Controls.Add(objTemporal);

                        objTemporal.Text = DatosConsultados.Rows[i]["Asignatura"].ToString();

                        Div3.Controls.Add(new LiteralControl("</td>"));


                        try
                        {

                            DataSet DatosAsignatura10 = ObjAsignatura.ConsultarAsignaturaAreaTodos2(DatosConsultados.Rows[i]["Asignatura"].ToString());

                            DataTable DatosConsultados10 = DatosAsignatura10.Tables["DatosConsultados"];

                            int numregistros10 = DatosConsultados10.Rows.Count;

                            if (numregistros10 == 0)
                            {
                                Div3.Controls.Add(new LiteralControl("<td>"));
                                Div3.Controls.Add(new LiteralControl("</td>"));

                                Div3.Controls.Add(new LiteralControl("<td>"));
                                Div3.Controls.Add(new LiteralControl("</td>"));

                                Div3.Controls.Add(new LiteralControl("<td>"));
                                Div3.Controls.Add(new LiteralControl("</td>"));

                                Div3.Controls.Add(new LiteralControl("<td>"));
                                Div3.Controls.Add(new LiteralControl("</td>"));

                                Div3.Controls.Add(new LiteralControl("<td>"));
                                Div3.Controls.Add(new LiteralControl("</td>"));

                                Div3.Controls.Add(new LiteralControl("<td>"));
                                Div3.Controls.Add(new LiteralControl("</td>"));

                                Div3.Controls.Add(new LiteralControl("<td>"));
                                Div3.Controls.Add(new LiteralControl("</td>"));

                                Div3.Controls.Add(new LiteralControl("<td>"));
                                Div3.Controls.Add(new LiteralControl("</td>"));

                                Div3.Controls.Add(new LiteralControl("<td>"));
                                Div3.Controls.Add(new LiteralControl("</td>"));

                            }
                            else
                            {
                                int z = 0;
                                for (int o = 0; o <= numregistros10 - 1; o++)
                                {
                                    DataSet DatosNotas2 = ObjNota.ConsultarNota(int.Parse(TextBox2.Text), "Primer Semestre", "Primer Corte", DatosConsultados10.Rows[o]["Asignatura"].ToString());

                                    DataTable DatosConsultados2 = DatosNotas2.Tables["DatosConsultados"];

                                    int numregistros2 = DatosConsultados2.Rows.Count;

                                    if (numregistros2 == 0)
                                    {


                                    }
                                    else
                                    {
                                        z++;
                                        Prom1 = int.Parse(DatosConsultados2.Rows[0]["Nota"].ToString()) + Prom1;
                                    }
                                }

                                Proms1 = Prom1 / z;

                                Label objTemporal2 = new Label();

                                Div3.Controls.Add(new LiteralControl("<td>"));

                                Div3.Controls.Add(objTemporal2);

                                objTemporal2.Text = Proms1.ToString();

                                Div3.Controls.Add(new LiteralControl("</td>"));



                                int z2 = 0;
                                for (int o1 = 0; o1 <= numregistros10 - 1; o1++)
                                {
                                    DataSet DatosNotas3 = ObjNota.ConsultarNota(int.Parse(TextBox2.Text), "Primer Semestre", "Segundo Corte", DatosConsultados10.Rows[o1]["Asignatura"].ToString());

                                    DataTable DatosConsultados3 = DatosNotas3.Tables["DatosConsultados"];

                                    int numregistros3 = DatosConsultados3.Rows.Count;

                                    if (numregistros3 == 0)
                                    {


                                    }
                                    else
                                    {
                                        z2++;
                                        Prom2 = int.Parse(DatosConsultados3.Rows[0]["Nota"].ToString()) + Prom2;
                                    }
                                }

                                Proms2 = Prom2 / z2;

                                Label objTemporal3 = new Label();

                                Div3.Controls.Add(new LiteralControl("<td>"));

                                Div3.Controls.Add(objTemporal3);

                                objTemporal3.Text = Proms2.ToString();

                                Div3.Controls.Add(new LiteralControl("</td>"));

                                int z3 = 0;
                                for (int o2 = 0; o2 <= numregistros10 - 1; o2++)
                                {
                                    DataSet DatosNotas4 = ObjNota.ConsultarNota(int.Parse(TextBox2.Text), "Segundo Semestre", "Primer Corte", DatosConsultados10.Rows[o2]["Asignatura"].ToString());

                                    DataTable DatosConsultados4 = DatosNotas4.Tables["DatosConsultados"];

                                    int numregistros4 = DatosConsultados4.Rows.Count;

                                    if (numregistros4 == 0)
                                    {


                                    }
                                    else
                                    {
                                        z3++;
                                        Prom3 = int.Parse(DatosConsultados4.Rows[0]["Nota"].ToString()) + Prom3;
                                    }
                                }

                                Proms3 = Prom3 / z3;

                                Label objTemporal4 = new Label();

                                Div3.Controls.Add(new LiteralControl("<td>"));

                                Div3.Controls.Add(objTemporal4);

                                objTemporal4.Text = Proms3.ToString();

                                Div3.Controls.Add(new LiteralControl("</td>"));

                                int z4 = 0;
                                for (int o4 = 0; o4 <= numregistros10 - 1; o4++)
                                {
                                    DataSet DatosNotas5 = ObjNota.ConsultarNota(int.Parse(TextBox2.Text), "Segundo Semestre", "Segundo Corte", DatosConsultados10.Rows[o4]["Asignatura"].ToString());

                                    DataTable DatosConsultados5 = DatosNotas5.Tables["DatosConsultados"];

                                    int numregistros5 = DatosConsultados5.Rows.Count;

                                    if (numregistros5 == 0)
                                    {


                                    }
                                    else
                                    {
                                        z4++;
                                        Prom4 = int.Parse(DatosConsultados5.Rows[0]["Nota"].ToString()) + Prom4;
                                    }
                                }

                                Proms4 = Prom4 / z4;

                                Label objTemporal5 = new Label();

                                Div3.Controls.Add(new LiteralControl("<td>"));

                                Div3.Controls.Add(objTemporal5);

                                objTemporal5.Text = Proms4.ToString();

                                Div3.Controls.Add(new LiteralControl("</td>"));

                                int S1 = Proms1 + Proms2;
                                int S2 = Proms3 + Proms4;
                                

                                PromFS1 = S1 + PromFS1;

                                PromFS2 = S2 + PromFS2;

                                FS1++;
                                FS2++;

                                Label objTemporal6 = new Label();

                                Div3.Controls.Add(new LiteralControl("<td>"));

                                Div3.Controls.Add(objTemporal6);

                                objTemporal6.Text = S1.ToString();

                                Div3.Controls.Add(new LiteralControl("</td>"));



                                Label objTemporal7 = new Label();

                                Div3.Controls.Add(new LiteralControl("<td>"));

                                Div3.Controls.Add(objTemporal7);

                                objTemporal7.Text = S2.ToString();

                                Div3.Controls.Add(new LiteralControl("</td>"));

                                if (S1 <= 59)
                                {
                                    escala1 = "Bajo";

                                }
                                else if (S1 >= 60 && S1 <= 70)
                                {
                                    escala1 = "Basico";
                                }
                                else if (S1 >= 71 && S1 <= 89)
                                {
                                    escala1 = "Alto";
                                }
                                else if (S1 >= 90 && S1 <= 100)
                                {
                                    escala1 = "Superior";
                                }

                                else
                                {
                                    escala1 = "";
                                }

                                if (S2 <= 59)
                                {
                                    escala2 = "Bajo";
                                }
                                else if (S2 >= 60 && S2 <= 70)
                                {
                                    escala2 = "Basico";
                                }
                                else if (S2 >= 71 && S2 <= 89)
                                {
                                    escala2 = "Alto";
                                }
                                else if (S2 >= 90 && S2 <= 100)
                                {
                                    escala2 = "Superior";
                                }

                                else
                                {
                                    escala2 = "";
                                }



                                Label objTemporal9 = new Label();

                                Div3.Controls.Add(new LiteralControl("<td>"));

                                Div3.Controls.Add(objTemporal9);

                                objTemporal9.Text = escala1;

                                Div3.Controls.Add(new LiteralControl("</td>"));



                                Label objTemporal10 = new Label();

                                Div3.Controls.Add(new LiteralControl("<td>"));

                                Div3.Controls.Add(objTemporal10);

                                objTemporal10.Text = escala2;

                                Div3.Controls.Add(new LiteralControl("</td>"));



                                int F = S1 + S2;

                                Label objTemporal8 = new Label();

                                Div3.Controls.Add(new LiteralControl("<td>"));

                                Div3.Controls.Add(objTemporal8);

                                objTemporal8.Text = F.ToString();

                                Div3.Controls.Add(new LiteralControl("</td>"));

                                K++;
                                PromF = PromF + F;
                            }







                            Div3.Controls.Add(new LiteralControl("</tr>"));
                        }

                        catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjAsignatura.Mensaje); }


                    }

                }

            }
            catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjAsignatura.Mensaje); }

            int PromedioFinal = PromF / K;
            int PromedioS1 = PromFS1 / FS1;
            int PromedioS2 = PromFS2 / FS2;

            Label11.Text = PromedioFinal.ToString();
            Label6.Text = PromedioS1.ToString();
            Label7.Text = PromedioS2.ToString();

      



        }
    }
}
