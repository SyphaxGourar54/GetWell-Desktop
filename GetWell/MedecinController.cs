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
        public static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["conStringHosted"].ConnectionString; 




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

        public static string error = "no error"; 
        public static bool GetDocData()
        {
            string userName = Properties.Settings.Default.UserName;
            if (userName != String.Empty)
            {
                try
                {


                    using (var connection = new SqlConnection(ConnectionString))
                    {
                        

                        if (connection.State != ConnectionState.Closed)
                            connection.Open();

                        var Med = connection.QuerySingle("GetMedecinByUserName", new { Username = userName }, commandType: CommandType.StoredProcedure);

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
                        else
                        {
                            return false;
                        }
                    }
                    return true; 
                }
                catch (Exception ex)
                {
                    MedecinController.error = ex.Message;
                    return true;
                    
                }
            }
            else
            {
                return false; 
            }
        }

        public static int NewRV(int id)
        {
            int result = 0; 
            using (var connection = new SqlConnection(ConnectionString))
            {
                try
                { 
                    if (connection.State != ConnectionState.Closed)
                        connection.Open();

                    result = (int)connection.ExecuteScalar<int>("NewRv", new { Id_Doc = id}, commandType: CommandType.StoredProcedure);
                    connection.Close();

                    return result;
                }
                catch
                {
                    return -1; 
                }
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

        public static void UpdateLocal(int Id, double lat, double longt)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Open();

                connection.Execute("UpdateLocalisation", new { lat = lat, longt = longt, Id = Id }, commandType: CommandType.StoredProcedure);
                connection.Close();

            }
        }

        public static void UpdateData(int id, string username, string nom, string prenom, string tel, string email, string ville, string adresse, string facebook, string whatsapp, string instagram, string twitter, string linkeden)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Open();

                connection.Execute("UpdateMedData", new { Id = id, username = username, nom = nom, prenom = prenom, tel = tel, email = email, ville = ville, adress = adresse, facebook = facebook, whatsapp = whatsapp, instagram = instagram, twitter= twitter, linkeden = linkeden}, commandType: CommandType.StoredProcedure);
                connection.Close();
            }
        }
    }
}
