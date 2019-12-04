using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DatosV;


namespace LogicaV
{
    public class Notas : Conexion
    {

        private int nota;
        private string periodo;
        private string corte;
        private int id_asignaciones;
        private int identificacionest;

        public int Nota
        {
            get { return nota; }
            set { nota = value; }
        }

        public string Periodo
        {
            get { return periodo; }
            set { periodo = value; }
        }

        public string Corte
        {
            get { return corte; }
            set { corte = value; }
        }

        public int Id_Asignaciones
        {
            get { return id_asignaciones; }
            set { id_asignaciones = value; }
        }

        public int IdentificacionEst
        {
            get { return identificacionest; }
            set { identificacionest = value; }
        }


        public bool InsertarNota()
        {
            string ProcedimientoInsertar = "EXEC InsertarNotas @Nota = " + this.nota + ",@Periodo = '" + this.periodo + "', @Corte = '" + this.corte + "', @Id_Asignaciones = '" + this.id_asignaciones + "', @IdentificacionEst = '" + this.identificacionest + "'";

            bool respuestaSQL = EjecutarSQL(ProcedimientoInsertar); return respuestaSQL;
        }
        public DataSet ConsultarNotas()
        { 
            string ProcedimientoDeConsulta =
                "Select N.Nota, N.Periodo, N.Corte, A.Nombre as Asignatura from Notas as N inner join Asignaciones as As on As.Id_Asignaciones=N.Id_Asignaciones inner join Asignatura as A on A.Id_Asignatura = As.Id_Asignatura";
            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante; 
        }

        public DataSet ConsultarNota(int IdentificacionEst , string  Periodoo , string Cortee , string Asignatura)
        {
            string ProcedimientoDeConsulta =
                "Select N.Nota, N.Periodo, N.Corte, A.Nombre as Asignatura from Notas as N inner join Asignaciones as Aa on Aa.Id_Asignaciones=N.Id_Asignaciones inner join Asignatura as A on A.Id_Asignatura = Aa.Id_Asignatura inner join Estudiante as E on E.IdentificacionEst = N.IdentificacionEst where N.IdentificacionEst = " + IdentificacionEst +" and N.Periodo = '"+Periodoo + "' and N.Corte = '"+ Cortee +"' and A.Nombre = '"+ Asignatura + "' and E.Estado = 'Activo'";
            DataSet ConsultaResultante = ConsultarSQL(ProcedimientoDeConsulta); return ConsultaResultante;
        }


    }
}
