using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Empresa_SogDental
{
    class BDcomun
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conn = new SqlConnection(@"Server=DESKTOP-PP2RB31\SQLEXPRESS;Database=CONSULTORIOSOGDENTAL;Trusted_Connection=True;");

            return conn;
        }
    }
}
