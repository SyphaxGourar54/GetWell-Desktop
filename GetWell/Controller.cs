using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper; 

namespace GetWell
{
    public static class Controller
    {
        public static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString; 




        public static int Login(string userName, string Pass)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Open();

                return (int)connection.ExecuteScalar<int>("login_doc", new { Username = userName, Password = Pass },  commandType: CommandType.StoredProcedure);
                
            }
        }
    }
}
