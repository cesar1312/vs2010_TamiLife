using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DA;

namespace BC
{
    public class MuestraBC
    {
        MuestraDA muestraDA = new MuestraDA();

        public DataTable ListaMuestras(int month, int year, int testId, int contactId, int tipoResultado)
        {
            return muestraDA.ListaMuestras(month, year,testId,contactId,tipoResultado);
        }

        public DataTable BuscarResultadoxMuestra(string nombresNeonato,string apellidosNeonato, string dni, string hClinica)
        {
            return muestraDA.BuscarResultadoxMuestra(nombresNeonato, apellidosNeonato, dni, hClinica);
        }
    }
}
