using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using BE;
using DA;
namespace BC
{
    public class ParametroGeneralBC
    {
        ParametroGeneralDA da = new ParametroGeneralDA();
        public List<ParametroGeneral> ListaAnhos()
        {
            return da.ListaAnhos();
        }

        public List<ParametroGeneral> AgregarParametroTodos(List<ParametroGeneral> lista)
        {
            var parametroTodos = new ParametroGeneral();
            parametroTodos.idParametroGeneral = 0;
            parametroTodos.ValorTexto = "TODOS";
            lista.Add(parametroTodos);
            return lista;
        }

        public List<ParametroGeneral> ListaMeses()
        {
            //List<ParametroGeneral> lista = da.ListaMeses();
            //ParametroGeneral parametroTodos = new ParametroGeneral();
            //parametroTodos.idParametroGeneral = 0;
            //parametroTodos.ValorTexto = "TODOS";
            //lista.Add(parametroTodos);
            return da.ListaMeses();
        }

        public List<ParametroGeneral> ListaPruebas()
        {
            return da.ListaPruebas();
        }

        public List<ParametroGeneral> ListarTipoResultados()
        {
            return da.ListarTipoResultados();
        }

        
    }
}
