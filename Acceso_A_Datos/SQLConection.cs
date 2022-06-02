using System.Configuration;
using System.Data.SqlClient;

namespace Acceso_A_Datos
{
    public class SQLConection
    {
        private readonly string conectionString;

        public SQLConection()
        {
            conectionString = $"{ConfigurationManager.ConnectionStrings["Plantilla_Bonita.Properties.Settings.AsistenciaConnectionString"].ConnectionString}";
        }

        protected SqlConnection getConnection()
        {
            return new SqlConnection(conectionString);
        }
    }
}
