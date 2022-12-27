using Microsoft.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace DAL
{
    public class DapperContext
    {
        private string connectionString;
        public DapperContext(IConfiguration configuration)
        {
            connectionString = configuration.GetSection("ConnectionStrings")["ClientsDB"];
        }

        public void DynamicQuery(string query)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var result = connection.Query(query).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<T> ModeledQuery<T>(string query)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    return connection.Query<T>(query).ToList();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}