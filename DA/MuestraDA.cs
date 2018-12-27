using System.Data;

namespace DA
{
    public class MuestraDA
    {
        private readonly ConsultaDB consultaDB = new ConsultaDB();

        public DataTable ListaMuestras(int month, int year, int testId, int contactId, int tipoResultado)
        {
            string query = "select ROW_NUMBER() OVER(ORDER BY s.spcExtcode1 ASC) AS Fila" +
                           ",s.spcExtcode1 as 'CodigoMuestra'" +
                           ", p.ptnFirstName as 'NombreNeonato'" +
                           ", p.ptnSurname as 'ApellidosNeonato'" +
                           ", a.ansValueText as 'Concentracion'" +
                           ", t.tstUnit as 'Unidad' " +
                           ", FORMAT(a.ansTimeMeasured, 'dd/MM/yyyy') as 'FechaResultado'" +
                           ", FORMAT(a.ansTimeAccepted, 'dd/MM/yyyy') as 'FechaAceptacion'" +
                           //", a.ansTimeMeasured as 'FechaResultado'" +
                           //", a.ansTimeAccepted  as 'FechaAceptacion'" +
                           ", t.tstDisplayName as 'Prueba'" +
                           ", t.TestID as 'TestId'" +
                           ", c.ContactId as 'IdEstablecimiento'" +
                           ", c.cntCode1 as 'CodigoEstablecimiento'" +
                           ", c.cntFacility as 'Establecimiento'" +
                           ", pr.prMotherFirstname as 'nombreMadre'" +
                           ", pr.prMotherSurname as 'apellidoMadre'" +
                           ", pr.prMotherSSN as 'DNI'" +
                           ", p.ptnCity as 'Departamento'" +
                           ", p.ptnState as 'Provincia'" +
                           ", p.ptnAddress3 as 'Distrito'" +
                           ", p.ptnPhone2 as 'telefono'" +
                           ", p.ptnMedicalRecord1 as 'historiaClinica'" +
                           ", p.ptnDateofBirth as 'fechaNacimiento'" +
                           ", s.spcTimeCollected as 'fechaToma'" +
                           ", d.sd2Gest as 'EdadGestacional'" +
                           ", d.sd2Weight as 'Peso'" +
                           ", CAST(CASE WHEN ptnSex = 2 THEN 'M' ELSE( CASE WHEN ptnSex = 1 THEN 'F' ELSE 'N.I.' END ) END AS varchar(20)) as 'Sexo'" +
                           ", ptnSex as 'SexoOri'" +
                           ", p.PatientID" +
                           ", s.SpecimenID" +
                           ", spcNotes as 'Notas'" +
                           ", pr.prMotherDOB as 'FechaRecepcion'" +
                           ", d.sd2BloodTransfusion as 'esTransFundido' " +
                           ", d.sd2PrematureSick as 'esPrematuro' " +
                           ", p.ptnPhone1 as 'telefono2' " +
                           ", rcd.rcdDeterminationLevel as 'CodigoResultado' " +
                           ", rcd.rcdName as 'ResultCode'" +
                           " from Patient p " +
                           " join Specimen s on s.PatientId = p.PatientID " +
                           " join SpecimenDetail2 d on s.SpecimenId = d.SpecimenId " +
                           " join RequestorAndSpecimen rs on  rs.SpecimenID = s.SpecimenId " +
                           " join Requestor r on r.RequestorId = rs.RequestorID " +
                           " join Contact c on c.ContactId = r.ContactID " +
                           " join PatientRelatives pr on p.PatientID = pr.PatientID " +
                           " join Answer a on a.SpecimenID = s.SpecimenID " +
                           " join test t on t.TestID = a.TestId " +
                           " join ResultCodeDef rcd on rcd.ResultCodeDefID = a.ResultCodeDefID " +
                           " where a.ansStatus in (110,116,130,140) and a.TestGroupId = 32 ";
            if (contactId > 0)
                query += " and c.ContactId = " + contactId;
            if (testId > 0)
                query += " and t.TestID = " + testId;
            if (month > 0)
                query += " and DATEPART(MONTH,a.ansTimeMeasured) = " + month;
            query += " and DATEPART(YEAR,a.ansTimeMeasured) = " + year + 
                     " order by s.spcExtcode1 asc";
            return consultaDB.ConsultaQuery_DataTable(query);
        }

        public DataTable BuscarResultadoxMuestra(string nombresNeonato, string apellidosNeonato, string dni, string hClinica)
        {
            string query = "select	s.spcExtcode1 as 'CodigoMuestra'" +
                           ", p.ptnFirstName as 'NombreNeonato'" +
                           ", p.ptnSurname as 'ApellidosNeonato'" +
                           ", a.ansValueText as 'Concentracion'" +
                           ", t.tstUnit as 'Unidad' " +
                           ", a.ansTimeMeasured as 'FechaResultado'" +
                           ", a.ansTimeAccepted  as 'FechaAceptacion'" +
                           //", FORMAT(a.ansTimeMeasured, 'dd/MM/yyyy') as 'FechaResultado'" +
                           //", FORMAT(a.ansTimeAccepted, 'dd/MM/yyyy')  as 'FechaAceptacion'" +
                           ", t.tstDisplayName as 'Prueba'" +
                           ", t.TestID as 'TestId'" +
                           ", c.ContactId as 'IdEstablecimiento'" +
                           ", c.cntCode1 as 'CodigoEstablecimiento'" +
                           ", c.cntFacility as 'Establecimiento'" +
                           ", pr.prMotherFirstname as 'nombreMadre'" +
                           ", pr.prMotherSurname as 'apellidoMadre'" +
                           ", pr.prMotherSSN as 'DNI'" +
                           ", p.ptnCity as 'Departamento'" +
                           ", p.ptnState as 'Provincia'" +
                           ", p.ptnAddress3 as 'Distrito'" +
                           ", p.ptnPhone2 as 'telefono'" +
                           ", p.ptnMedicalRecord1 as 'historiaClinica'" +
                           ", p.ptnDateofBirth as 'fechaNacimiento'" +
                           ", s.spcTimeCollected as 'fechaToma'" +
                           //", FORMAT(p.ptnDateofBirth, 'dd/MM/yyyy') as 'fechaNacimiento'" +
                           //", FORMAT(s.spcTimeCollected, 'dd/MM/yyyy') as 'fechaToma'" +
                           ", d.sd2Gest as 'EdadGestacional'" +
                           ", d.sd2Weight as 'Peso'" +
                           ", CAST(CASE WHEN ptnSex = 2 THEN 'M' ELSE( CASE WHEN ptnSex = 1 THEN 'F' ELSE 'N.I.' END ) END AS varchar(20)) as 'Sexo'" +
                           ", ptnSex as 'SexoOri'" +
                           ", p.PatientID" +
                           ", s.SpecimenID" +
                           ", spcNotes as 'Notas'" +
                           ", pr.prMotherDOB as 'FechaRecepcion'" +
                           ", d.sd2BloodTransfusion as 'esTransFundido' " +
                           ", d.sd2PrematureSick as 'esPrematuro' " +
                           ", p.ptnPhone1 as 'telefono2' " +
                           ", rcd.rcdDeterminationLevel as 'CodigoResultado' " +
                           ", rcd.rcdName as 'ResultCode'" +
                           "from Patient p " +
                           "join Specimen s on s.PatientId = p.PatientID " +
                           "join SpecimenDetail2 d on s.SpecimenId = d.SpecimenId " +
                           "join RequestorAndSpecimen rs on  rs.SpecimenID = s.SpecimenId " +
                           "join Requestor r on r.RequestorId = rs.RequestorID " +
                           "join Contact c on c.ContactId = r.ContactID " +
                           "join PatientRelatives pr on p.PatientID = pr.PatientID " +
                           "join Answer a on a.SpecimenID = s.SpecimenID " +
                           "join test t on t.TestID = a.TestId " +
                           "join ResultCodeDef rcd on rcd.ResultCodeDefID = a.ResultCodeDefID " +
                           "where a.ansStatus in (110,116,130,140) ";
            if (nombresNeonato.CompareTo(string.Empty) != 0)
                query += " and p.ptnFirstName like '%" + nombresNeonato + "%' ";
            if (apellidosNeonato.CompareTo(string.Empty) != 0)
                query += " and p.ptnSurname like '%" + apellidosNeonato + "%' ";
            if (dni.CompareTo(string.Empty) != 0)
                query += " and pr.prMotherSSN  like '%" + dni + "%' ";
            if (hClinica.CompareTo(string.Empty) != 0)
                query += " and p.ptnMedicalRecord1  like '%" + hClinica + "%' ";

            query += "order by s.spcExtcode1 asc";
            return consultaDB.ConsultaQuery_DataTable(query);
        }

        /*
        public DataTable ListaMuestras(int month, int year, int testId, int contactId, int tipoResultado)
        {
            var dt = new DataTable();
            var cn = new SqlConnection(db.conexionSG);

            string query = "select	s.spcExtcode1 as 'CodigoMuestra'" +
                            ", p.ptnFirstName as 'NombreNeonato'" +
                            ", p.ptnSurname as 'ApellidosNeonato'" +
                            ", a.ansValueText as 'Concentracion'" +
                            ", a.ansTimeMeasured as 'FechaResultado'" +
                            ", a.ansTimeAccepted  as 'FechaAceptacion'" +
                            //", FORMAT(a.ansTimeMeasured, 'dd/MM/yyyy') as 'FechaResultado'" +
                            //", FORMAT(a.ansTimeAccepted, 'dd/MM/yyyy')  as 'FechaAceptacion'" +
                            ", t.tstDisplayName as 'Prueba'" +
                            ", t.TestID as 'TestId'" +
                            ", c.ContactId as 'IdEstablecimiento'" +
                            ", c.cntCode1 as 'CodigoEstablecimiento'" +
                            ", c.cntFacility as 'Establecimiento'" +
                            ", pr.prMotherFirstname as 'nombreMadre'" +
                            ", pr.prMotherSurname as 'apellidoMadre'" +
                            ", pr.prMotherSSN as 'DNI'" +
                            ", p.ptnCity as 'Departamento'" +
                            ", p.ptnState as 'Provincia'" +
                            ", p.ptnAddress3 as 'Distrito'" +
                            ", p.ptnPhone2 as 'telefono'" +
                            ", p.ptnMedicalRecord1 as 'historiaClinica'" +
                            ", p.ptnDateofBirth as 'fechaNacimiento'" +
                            ", s.spcTimeCollected as 'fechaToma'" +
                            //", FORMAT(p.ptnDateofBirth, 'dd/MM/yyyy') as 'fechaNacimiento'" +
                            //", FORMAT(s.spcTimeCollected, 'dd/MM/yyyy') as 'fechaToma'" +
                            ", d.sd2Gest as 'EdadGestacional'" +
                            ", d.sd2Weight as 'Peso'" +
                            ", CAST(CASE WHEN ptnSex = 2 THEN 'M' ELSE( CASE WHEN ptnSex = 1 THEN 'F' ELSE 'N.I.' END ) END AS varchar(20)) as 'Sexo'" +
                            ", ptnSex as 'SexoOri'" +
                            ", p.PatientID" +
                            ", s.SpecimenID" +
                            ", spcNotes as 'Notas'" +
                            ", pr.prMotherDOB as 'FechaRecepcion'" +
                            ", d.sd2BloodTransfusion as 'esTransFundido' " +
                            ", d.sd2PrematureSick as 'esPrematuro' " +
                            ", p.ptnPhone1 as 'telefono2' " +
                            ", rcd.rcdDeterminationLevel as 'CodigoResultado' " + 
							", rcd.rcdName as 'ResultCode'" +
                            "from Patient p " +
                            "join Specimen s on s.PatientId = p.PatientID " +
                            "join SpecimenDetail2 d on s.SpecimenId = d.SpecimenId " +
                            "join RequestorAndSpecimen rs on  rs.SpecimenID = s.SpecimenId " +
                            "join Requestor r on r.RequestorId = rs.RequestorID " +
                            "join Contact c on c.ContactId = r.ContactID " +
                            "join PatientRelatives pr on p.PatientID = pr.PatientID " +
                            "join Answer a on a.SpecimenID = s.SpecimenID " +
                            "join test t on t.TestID = a.TestId " +
                            "join ResultCodeDef rcd on rcd.ResultCodeDefID = a.ResultCodeDefID " +
                            "where a.ansStatus in (110,116,130,140) ";
            if (contactId > 0)
                query += "and c.ContactId = " + contactId;
            if (testId > 0)
                query += "and t.TestID = " + testId;
            if (month > 0)
                query += "and DATEPART(MONTH,a.ansTimeMeasured) = " + month;
            query += " and DATEPART(YEAR,a.ansTimeMeasured) = " + year + " " +
                        "order by s.spcExtcode1 asc";
            cn.Open();

            var adapter = new SqlDataAdapter(query, cn);

            adapter.Fill(dt);
            cn.Close();
            return dt;
        }

        public DataTable BuscarResultadoxMuestra(string nombresNeonato,string apellidosNeonato, string dni, string hClinica)
        {
            var dt = new DataTable();
            var cn = new SqlConnection(db.conexionSG);

            string query = "select	s.spcExtcode1 as 'CodigoMuestra'" +
                            ", p.ptnFirstName as 'NombreNeonato'" +
                            ", p.ptnSurname as 'ApellidosNeonato'" +
                            ", a.ansValueText as 'Concentracion'" +
                            ", a.ansTimeMeasured as 'FechaResultado'" +
                            ", a.ansTimeAccepted  as 'FechaAceptacion'" +
                //", FORMAT(a.ansTimeMeasured, 'dd/MM/yyyy') as 'FechaResultado'" +
                //", FORMAT(a.ansTimeAccepted, 'dd/MM/yyyy')  as 'FechaAceptacion'" +
                            ", t.tstDisplayName as 'Prueba'" +
                            ", t.TestID as 'TestId'" +
                            ", c.ContactId as 'IdEstablecimiento'" +
                            ", c.cntCode1 as 'CodigoEstablecimiento'" +
                            ", c.cntFacility as 'Establecimiento'" +
                            ", pr.prMotherFirstname as 'nombreMadre'" +
                            ", pr.prMotherSurname as 'apellidoMadre'" +
                            ", pr.prMotherSSN as 'DNI'" +
                            ", p.ptnCity as 'Departamento'" +
                            ", p.ptnState as 'Provincia'" +
                            ", p.ptnAddress3 as 'Distrito'" +
                            ", p.ptnPhone2 as 'telefono'" +
                            ", p.ptnMedicalRecord1 as 'historiaClinica'" +
                            ", p.ptnDateofBirth as 'fechaNacimiento'" +
                            ", s.spcTimeCollected as 'fechaToma'" +
                //", FORMAT(p.ptnDateofBirth, 'dd/MM/yyyy') as 'fechaNacimiento'" +
                //", FORMAT(s.spcTimeCollected, 'dd/MM/yyyy') as 'fechaToma'" +
                            ", d.sd2Gest as 'EdadGestacional'" +
                            ", d.sd2Weight as 'Peso'" +
                            ", CAST(CASE WHEN ptnSex = 2 THEN 'M' ELSE( CASE WHEN ptnSex = 1 THEN 'F' ELSE 'N.I.' END ) END AS varchar(20)) as 'Sexo'" +
                            ", ptnSex as 'SexoOri'" +
                            ", p.PatientID" +
                            ", s.SpecimenID" +
                            ", spcNotes as 'Notas'" +
                            ", pr.prMotherDOB as 'FechaRecepcion'" +
                            ", d.sd2BloodTransfusion as 'esTransFundido' " +
                            ", d.sd2PrematureSick as 'esPrematuro' " +
                            ", p.ptnPhone1 as 'telefono2' " +
                            ", rcd.rcdDeterminationLevel as 'CodigoResultado' " +
                            ", rcd.rcdName as 'ResultCode'" +
                            "from Patient p " +
                            "join Specimen s on s.PatientId = p.PatientID " +
                            "join SpecimenDetail2 d on s.SpecimenId = d.SpecimenId " +
                            "join RequestorAndSpecimen rs on  rs.SpecimenID = s.SpecimenId " +
                            "join Requestor r on r.RequestorId = rs.RequestorID " +
                            "join Contact c on c.ContactId = r.ContactID " +
                            "join PatientRelatives pr on p.PatientID = pr.PatientID " +
                            "join Answer a on a.SpecimenID = s.SpecimenID " +
                            "join test t on t.TestID = a.TestId " +
                            "join ResultCodeDef rcd on rcd.ResultCodeDefID = a.ResultCodeDefID " +
                            "where a.ansStatus in (110,116,130,140) ";
            if (nombresNeonato.CompareTo(string.Empty) != 0)
                query += "and p.ptnFirstName like '%" + nombresNeonato + "%' ";
            if (apellidosNeonato.CompareTo(string.Empty) != 0)
                query += "and p.ptnSurname like '%" + apellidosNeonato + "%' ";
            if (dni.CompareTo(string.Empty) != 0)
                query += "and pr.prMotherSSN  like '%" + dni + "%' ";
            if (hClinica.CompareTo(string.Empty) != 0)
                query += "and p.ptnMedicalRecord1  like '%" + hClinica + "%' ";
           
            query += "order by s.spcExtcode1 asc";
            cn.Open();

            var adapter = new SqlDataAdapter(query, cn);

            adapter.Fill(dt);
            cn.Close();
            return dt;
        }
        */
    }
}
