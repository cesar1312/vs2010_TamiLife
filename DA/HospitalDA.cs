using System.Collections.Generic;
using System.Linq;
using BE;

namespace DA
{
    public class HospitalDA
    {
        AccesoDB db = new AccesoDB();
        public List<Contact> ListaHospitales()
        {
            List<Contact> Hospitales = (from h in db.lifecycle_dc.Contacts  where h.cntActive == true && h.cntValid == true select h).ToList();
            return Hospitales;
        }
    }
}
