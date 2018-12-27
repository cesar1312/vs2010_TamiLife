using System.Data;

namespace DA
{
    public class ResultadoDA
    {
        private readonly ConsultaDB consultaDB = new ConsultaDB();

        public DataTable ListaResultados(int numEnsayo, int month, int year, int testId, int resultCode)
        {
            string query = "select s.spcExtcode1 as 'CodigoMuestra' " +
                           ",a.AssayRunId as 'NumEnsayo' " +
                           ",a.ansValueText as 'Concentracion' " +
                           ",t.tstUnit as 'Unidad' " +
                           ",t.tstDisplayName as 'Prueba' " +
                           ",r.rcdDeterminationLevel as 'CodigoResultado' " +
                           ",r.rcdName as 'ResultCode' " +
                           ",a.ansTimeMeasured as 'FechaResultado' " +
                           ",a.ansTimeAccepted as 'FechaAceptacion' " +
                           "from Specimen s " +
                           "join Answer a on s.SpecimenID = a.SpecimenID " +
                           "join Test t on a.TestId = t.TestID " +
                           "join ResultCodeDef r on a.ResultCodeDefID = r.ResultCodeDefID " +
                           "where ansStatus in (110,116,130,140) ";
            if (year > 0)
                query += " and DATEPART(YEAR,a.ansTimeMeasured) = " + year;
            if (month > 0)
                query += " and DATEPART(MONTH,a.ansTimeMeasured) = " + month;
            if (testId > 0)
                query += " and t.TestId = " + testId;
            if (numEnsayo > 0)
                query += " and a.AssayRunId = " + numEnsayo;
            if (resultCode > 0)
                query += " and r.rcdDeterminationLevel <> 20";

            query += " order by s.spcExtcode1 asc";

            return consultaDB.ConsultaQuery_DataTable(query);
        }
        public DataTable BuscarResultadoxTarjeta(string codigoMuestra)
        {
            string query = "select s.spcExtcode1 as 'CodigoMuestra' " +
                           ",a.AssayRunId as 'NumEnsayo' " +
                           ",a.ansValueText as 'Concentracion' " +
                           ",t.tstUnit as 'Unidad' " +
                           ",t.tstDisplayName as 'Prueba' " +
                           ",r.rcdDeterminationLevel as 'CodigoResultado' " +
                           ",r.rcdName as 'ResultCode' " +
                           ",a.ansTimeMeasured as 'FechaResultado' " +
                           ",a.ansTimeAccepted as 'FechaAceptacion' " +
                           "from Specimen s " +
                           "join Answer a on s.SpecimenID = a.SpecimenID " +
                           "join Test t on a.TestId = t.TestID " +
                           "join ResultCodeDef r on a.ResultCodeDefID = r.ResultCodeDefID " +
                           "where ansStatus in (110,116,130,140) " +
                           "and s.spcExtcode1 = '" + codigoMuestra + "' ";
            query += " order by s.spcExtcode1 asc";
            return consultaDB.ConsultaQuery_DataTable(query);
        }

        /*
        public DataTable ListaResultados(int numEnsayo, int month, int year, int testId, int resultCode)
        {
            var dt = new DataTable();
            var cn = new SqlConnection(db.conexionSG);

            string query = "select s.spcExtcode1 as 'CodigoMuestra' " +
                           ",a.AssayRunId as 'NumEnsayo' " +
                           ",a.ansValueText as 'Concentracion' " +
                           //",p.Unidad as 'Unidad' " +
                           //",p.Nombre as 'Prueba' " +
                           ",t.tstUnit as 'Unidad' " +
                           ",t.tstDisplayName as 'Prueba' " +
                           ",r.rcdDeterminationLevel as 'CodigoResultado' " +
                           ",r.rcdName as 'ResultCode' " +
                           ",a.ansTimeMeasured as 'FechaResultado' " +
                           ",a.ansTimeAccepted as 'FechaAceptacion' " +
                           //",FORMAT(a.ansTimeMeasured, 'dd/MM/yyyy') as 'FechaResultado' " +
                           //",FORMAT(a.ansTimeAccepted, 'dd/MM/yyyy')  as 'FechaAceptacion' " +
                           "from Specimen s " +
                           "join Answer a on s.SpecimenID = a.SpecimenID " +
                           "join Test t on a.TestId = t.TestID " +
                           "join ResultCodeDef r on a.ResultCodeDefID = r.ResultCodeDefID " +
                           //"join [TamizajeSanBartolome].[dbo].[Prueba] p on p.idTest = a.TestId " +
                           "where ansStatus in (110,116,130,140) ";
            if (year > 0)
                query += " and DATEPART(YEAR,a.ansTimeMeasured) = " + year;
            //"and DATEPART(MONTH,a.ansTimeMeasured) = 8 " +
            //"and DATEPART(YEAR,a.ansTimeMeasured) = 2017 and rcdName like '%NORM'";
            if (month > 0)
                query += " and DATEPART(MONTH,a.ansTimeMeasured) = " + month;
            if (testId > 0)
                query += " and t.TestId = " + testId;
                //query += " and p.idTest = " + testId;
            if (numEnsayo > 0)
                query += " and a.AssayRunId = " + numEnsayo;
            if (resultCode > 0)
                query += " and r.rcdDeterminationLevel <> 20";
            //if ()

            query += " order by s.spcExtcode1 asc";
            cn.Open();

            var adapter = new SqlDataAdapter(query, cn);

            adapter.Fill(dt);
            cn.Close();
            return dt;
        }
        
        public DataTable BuscarResultadoxTarjeta(string codigoMuestra)
        {
            var dt = new DataTable();
            var cn = new SqlConnection(db.conexionSG);

            string query = "select s.spcExtcode1 as 'CodigoMuestra' " +
                           ",a.AssayRunId as 'NumEnsayo' " +
                           ",a.ansValueText as 'Concentracion' " +
                           ",t.tstUnit as 'Unidad' " +
                           ",t.tstDisplayName as 'Prueba' " +
                           ",r.rcdDeterminationLevel as 'CodigoResultado' " +
                           ",r.rcdName as 'ResultCode' " +
                           ",a.ansTimeMeasured as 'FechaResultado' " +
                           ",a.ansTimeAccepted as 'FechaAceptacion' " +
                //",FORMAT(a.ansTimeMeasured, 'dd/MM/yyyy') as 'FechaResultado' " +
                //",FORMAT(a.ansTimeAccepted, 'dd/MM/yyyy')  as 'FechaAceptacion' " +
                           "from Specimen s " +
                           "join Answer a on s.SpecimenID = a.SpecimenID " +
                           "join Test t on a.TestId = t.TestID " +
                           "join ResultCodeDef r on a.ResultCodeDefID = r.ResultCodeDefID " +
                           "where ansStatus in (110,116,130,140) " +
                           "and s.spcExtcode1 = '" + codigoMuestra + "' ";
            query += " order by s.spcExtcode1 asc";
            cn.Open();

            var adapter = new SqlDataAdapter(query, cn);

            adapter.Fill(dt);
            cn.Close();
            return dt;
        }
        */
    }
}
