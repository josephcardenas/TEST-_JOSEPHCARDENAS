using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DATOS
{
    public class BDConexion
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection Conn = new SqlConnection("Data Source =.; Initial Catalog = formularioBD; Integrated Security = True");
            Conn.Open();
            return Conn;



        }

    }
}
