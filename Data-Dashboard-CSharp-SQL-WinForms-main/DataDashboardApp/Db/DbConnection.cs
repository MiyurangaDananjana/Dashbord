using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardApp.Db
{
    public abstract class DbConnection
    {
        private readonly string connectionString;

        public DbConnection()
        {
            connectionString = "Data Source=DESKTOP-EKOD5FK;Initial Catalog=NorthwindStore;Integrated Security=True";
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
