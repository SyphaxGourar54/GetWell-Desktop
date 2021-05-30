using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetWell
{
    public static class DiagnostiqueController
    {
        public static readonly string ConnectionString = MedecinController.ConnectionString; 
        

        public static void AddDiag(Diagnostique diag)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Open();

                connection.Execute("AddDiagnostic", new {Description = diag.Description, Date_diag = diag.Date_diag, Id_patient = diag.Id_patient, Id_doc = diag.Id_doc}, commandType: CommandType.StoredProcedure);

                connection.Close();
            }
        }

        public static DataTable ConsultationsList()
        {
            using (SqlConnection conn = new SqlConnection(DiagnostiqueController.ConnectionString))
            {
                DataTable dt = new DataTable(); 
                try
                {
                    string query = "select diagnostique.Date_diag, patient.Nom + ' ' + patient.Prenom as 'Patient', diagnostique.Description from diagnostique inner join patient on patient.Id_patient = diagnostique.#Id_Patient where #Id_doc = @Id_Doc";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id_Doc", Medecin.Id_doc); 
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr); 

                }
                catch (Exception)
                {
                }

                return dt; 
            }
        }

        public static DataTable PatientsList()
        {
            using (SqlConnection conn = new SqlConnection(DiagnostiqueController.ConnectionString))
            {
                DataTable dt = new DataTable();
                try
                {
                    string query = "select * from patient";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);

                }
                catch (Exception)
                {
                }

                return dt;
            }
        }

        public static DataTable PatientRecherche(string nom)
        {
            using (SqlConnection conn = new SqlConnection(DiagnostiqueController.ConnectionString))
            {
                DataTable dt = new DataTable();
                try
                {
                    string query = "patientSearch";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nom", nom); 
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);

                }
                catch (Exception)
                {
                }

                return dt;
            }
        }


        public static DataTable DiagRecherche(string nom)
        {
            using (SqlConnection conn = new SqlConnection(DiagnostiqueController.ConnectionString))
            {
                DataTable dt = new DataTable();
                try
                {
                    string query = "diagnostiqueSearch";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nom", nom);
                    cmd.Parameters.AddWithValue("@Id_Doc", Medecin.Id_doc); 
                    conn.Open();
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
