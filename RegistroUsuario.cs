using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Empresa_SogDental
{
    class RegistroUsuario
    {
        public static int CrearCuentas(string pUsuario, string pContraseña)
        {
            int resultado = 0;
            SqlConnection conn = BDcomun.ObtenerConexion();

            conn.Open();

            SqlCommand comando = new SqlCommand(string.Format("Insert into Usuario (Nombre, Contraseña) values ('{0}', PwdEncrypt('{1}'))", pUsuario, pContraseña), conn);

            resultado = comando.ExecuteNonQuery();
            conn.Close();

            return resultado;
        }
    }
}
