using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetWell
{
    class TeleConsultationController
    {
        public static DataTable TClist()
        {
            using (SqlConnection conn = new SqlConnection(MedecinController.ConnectionString))
            {
                DataTable dt = new DataTable();
                try
                {
                    string query = "teleconsultationList";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
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

        public static DataTable TcRecherche(string nom)
        {
            using (SqlConnection conn = new SqlConnection(DiagnostiqueController.ConnectionString))
            {
                DataTable dt = new DataTable();
                try
                {
                    string query = "teleconsultaitonSearch";
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
