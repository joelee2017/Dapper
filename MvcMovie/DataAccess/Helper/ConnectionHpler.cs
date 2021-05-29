using System.Data.Common;
using System.Data.SqlClient;

namespace DataAccess.Helper
{
    public static class ConnectionHpler
    {
        public static DbConnection GetConnection(this string connection)
        {
            return new SqlConnection(connection);
        }
    }
}
