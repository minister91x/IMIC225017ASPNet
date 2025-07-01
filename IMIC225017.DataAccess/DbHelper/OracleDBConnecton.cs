using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIC225017.DataAccess.DbHelper
{
    public class OracleDBConnecton : DbConnection<Oracle.ManagedDataAccess.Client.OracleConnection>
    {
        public override Oracle.ManagedDataAccess.Client.OracleConnection GetConnection()
        {
            try
            {
                var connectionStr = System.Configuration.ConfigurationManager.ConnectionStrings["IMIC225017ASPNetConnectionString"].ConnectionString.ToString() ?? "";
                var connection = new Oracle.ManagedDataAccess.Client.OracleConnection(connectionStr);
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                return connection;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
    {
    }
}
