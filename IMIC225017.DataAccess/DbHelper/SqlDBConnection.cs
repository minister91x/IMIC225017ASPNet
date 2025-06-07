using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIC225017.DataAccess.DbHelper
{
    public  class SqlDBConnection : DbConnection<SqlConnection>
    {
        public  override SqlConnection GetConnection()
        {
			try
			{
				var connectionStr = System.Configuration.ConfigurationManager.ConnectionStrings["IMIC225017ASPNetConnectionString"].ConnectionString.ToString() ?? ""; 
				var connection = new SqlConnection(connectionStr);
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
}
