using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_A_Datos
{
    public class Consultas : SQLConection
    {
        public void ProbarConexion() {
            using (SqlConnection conexion = getConnection())
            {
                conexion.Open();
                Console.WriteLine("Conexion Realizada con Exito");
            }
        }
    }
}
