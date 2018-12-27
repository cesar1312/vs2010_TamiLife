using System.Data;
using System.Data.SqlClient;

namespace DA
{
    public class ConsultaDB
    {
        readonly AccesoDB db = new AccesoDB();
    
        public DataTable ConsultaQuery_DataTable(string query)
        {
            var dt = new DataTable();
            var cn = new SqlConnection(db.conexionSG);

            cn.Open();

            var adapter = new SqlDataAdapter(query, cn);

            adapter.Fill(dt);
            cn.Close();
            return dt;
        }
    }
}
