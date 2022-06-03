using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plantilla_Bonita
{
    public class SQLConection
    {
        private readonly string conectionString;

        public SQLConection()
        {
            conectionString = global::Plantilla_Bonita.Properties.Settings.Default.AsistenciaConnectionString;
        }

        protected SqlConnection getConnection()
        {
            return new SqlConnection(conectionString);
        }
    }
}
