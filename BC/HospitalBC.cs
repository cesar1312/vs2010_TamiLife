using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA;
using BE;

namespace BC
{
    public class HospitalBC
    {
        HospitalDA hospitalDA = new HospitalDA();

        public List<Contact> ListaHospitales()
        {
            List<Contact> hospitales = hospitalDA.ListaHospitales();
            Contact contactoTodos = new Contact();
            contactoTodos.ContactId = 0;
            contactoTodos.cntFacility = "TODOS";
            hospitales.Add(contactoTodos);

            return hospitales;
        }
    }
}
