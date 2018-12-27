using System.Configuration;
using BE;

namespace DA
{
    public class AccesoDB
    {
        public string conexionSG { get; set; }
        public string conexionTamiLife { get; set; }
        public TamiLifeDBDataContext tamilife_dc { get; set; }
        public LifeCycleDBDataContext  lifecycle_dc { get; set; }

        public AccesoDB()
        {
            conexionSG = ConfigurationManager.ConnectionStrings["Lenovo_SG"].ConnectionString;
            conexionTamiLife = ConfigurationManager.ConnectionStrings["TamiLifeDB"].ConnectionString;


            tamilife_dc = new TamiLifeDBDataContext(conexionTamiLife);
            lifecycle_dc = new LifeCycleDBDataContext(conexionSG);
        }
    }
}
