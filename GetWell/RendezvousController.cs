using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dapper; 

namespace GetWell
{
    public static class RendezvousController
    {
        public static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["conStringHosted"].ConnectionString;
        public static List<Rendezvous> rvList; 

        public static List<Rendezvous> GetNonValidatedRvs(int Id)
        {
             
            using (var connection = new SqlConnection(ConnectionString))
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Open();

                rvList =  connection.Query<Rendezvous>("NonValidatedRvList", new { Id_Doc = Id }, commandType: CommandType.StoredProcedure).ToList(); 

                connection.Close();
            }

            
            return rvList; 
        }


        public static void AcceptRv(int id)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Open();

                connection.Execute("AcceptRv", new {Id_rv = id}, commandType: CommandType.StoredProcedure); 

                connection.Close();
            }
        }

        public static void RefuserRv(int id)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Open();

                connection.Execute("RefuserRv", new { Id_rv = id }, commandType: CommandType.StoredProcedure);

                connection.Close();
            }
        }

    }

    


}
