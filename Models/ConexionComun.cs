using Microsoft.Data.SqlClient;

namespace SigeFlot.Models
{
    public class ConexionComun
    {
        public SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Comun_Sistemas"].ToString());

        public SqlConnection coneccion()
        {
            return this.con;
        }
    }
}
