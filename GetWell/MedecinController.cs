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
    public static class MedecinController
    {
        public static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString; 




        public static int Login(string userName, string Pass)
        {
            int result = -1; 
            using (var connection = new SqlConnection(ConnectionString))
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Open();

                result =  (int)connection.ExecuteScalar<int>("login_doc", new { Username = userName, Password = Pass },  commandType: CommandType.StoredProcedure);

                connection.Close();
                if (result > 0)
                {
                    

                }
            }

            

            return result; 
        }


        public static void GetDocData()
        {
            var userName = Properties.Settings.Default.UserName;
            if (userName != String.Empty)
            { 
                using (var connection = new SqlConnection(ConnectionString))
                {
                    var sql = "select * from medecin where Username = @Username";

                    if (connection.State != ConnectionState.Closed)
                        connection.Open();

                    var Med = connection.QuerySingle(sql, new { Username = userName });

                    connection.Close();
                    if (Med != null)
                    {
                        Medecin.Id_doc = Med.Id_doc;
                        Properties.Settings.Default.DocId = Med.Id_doc;

                        Medecin.Username = Med.Username;
                        Medecin.Nom = Med.Nom;
                        Medecin.Prenom = Med.Prenom;
                        Medecin.Tel = Med.Tel;
                        Medecin.Image = Med.Image;
                        Medecin.Email = Med.Email;
                        Medecin.Nbrpatients = Med.Nbrpatients;
                        Medecin.ville = Med.ville;
                        Medecin.Adresse = Med.Adresse;
                        Medecin.Facebook = Med.Facebook;
                        Medecin.Whatsapp = Med.Whatsapp;
                        Medecin.Instagram = Med.Instagram;
                        Medecin.Twitter = Med.Twitter;
                        Medecin.Linkeden = Med.Linkeden;
                        Medecin.latitude = Med.latitude;
                        Medecin.longitude = Med.longitude;
                    }
                }
            }
        }

        public static int NewRV(int id)
        {
            int result = 0; 
            using (var connection = new SqlConnection(ConnectionString))
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Open();

                result = (int)connection.ExecuteScalar<int>("NewRv", new { Id_Doc = id}, commandType: CommandType.StoredProcedure);
                connection.Close();

                return result; 
            }
        }

        public static void UpdatePasword(string NewPass, int id)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Open();

                connection.Execute("UpdatPassword", new { password = NewPass, Id_doc = id }, commandType: CommandType.StoredProcedure); 
                connection.Close();

            }
        }
    }
}
