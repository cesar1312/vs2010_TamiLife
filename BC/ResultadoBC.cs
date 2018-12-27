using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DA;
using BE;

namespace BC
{
    public class ResultadoBC
    {
        ResultadoDA resultadoDA =  new ResultadoDA();

        public DataTable ListaResultados(int numEnsayo, int month, int year, int testId, int resultCode)
        {
            return resultadoDA.ListaResultados(numEnsayo, month, year, testId, resultCode);
        }
        public DataTable BuscarResultadoxTarjeta(string codigoMuestra)
        {
            return resultadoDA.BuscarResultadoxTarjeta(codigoMuestra);
        }
    }
}
