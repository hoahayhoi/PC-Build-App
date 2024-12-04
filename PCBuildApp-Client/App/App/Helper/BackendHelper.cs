using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Helper
{
    public class BackendHelper
    {
        private static string connectionString = "Data Source=34.80.167.226,1433;Initial Catalog=PCBuild;User Id=sqlserver;Password=admin;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
