using System.Configuration;
using System.Data.SqlClient;

namespace Acceso_A_Datos
{
    public class SQLConection
    {
        /// <summary>
        /// La cadena de conexion
        /// </summary>
        private readonly string conectionString;

        /// <summary>
        /// Establece la cadena de conexion
        /// </summary>
        public SQLConection()
        {
            //Cargamos la cadena de conexion desde el Settings.settings
            conectionString = $"{ConfigurationManager.ConnectionStrings["SGA_ITSL.Properties.Settings.AsistenciaConnectionString"].ConnectionString}";
        }

        /// <summary>
        /// Procedimiento que nos devuelve la conexion con la base de datos
        /// </summary>
        /// <returns>La conexion con la base de datos</returns>
        protected SqlConnection getConnection()
        {
            return new SqlConnection(conectionString);
        }
    }
}
