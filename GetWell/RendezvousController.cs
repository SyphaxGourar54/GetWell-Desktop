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
        public static readonly string ConnectionString = MedecinController.ConnectionString; 
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
        public static DataTable GetRvList()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                DataTable dt = new DataTable();
                try
                {
                    string query = "RendezVousList";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id_Doc", Medecin.Id_doc);
                    connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);

                }
                catch (Exception)
                {
                }

                return dt;
            }
        }

        public static DataTable GetRvListByDate(DateTime date)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                DataTable dt = new DataTable();
                try
                {
                    string query = "RendezVousDate";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@Id_Doc", Medecin.Id_doc);
                    connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);

                }
                catch (Exception)
                {
                }

                return dt;
            }
        }

        public static DataTable GetRvListSearchByPat(string nom)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                DataTable dt = new DataTable();
                try
                {
                    string query = "RendezVousSearch";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nom", nom);
                    cmd.Parameters.AddWithValue("@Id_Doc", Medecin.Id_doc);
                    connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);

                }
                catch (Exception)
                {
                }

                return dt;
            }
        }


    }

    


}
