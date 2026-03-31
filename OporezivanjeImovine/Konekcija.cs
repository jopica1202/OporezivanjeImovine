using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Samostalni_2026_Milos_PusicB
{
    internal class Konekcija
    {
        static public SqlConnection povezi()
        {
            string CS = ConfigurationManager.ConnectionStrings["skola"].ConnectionString;
            SqlConnection veza = new SqlConnection(CS);
            return veza;
        }

    }
}
