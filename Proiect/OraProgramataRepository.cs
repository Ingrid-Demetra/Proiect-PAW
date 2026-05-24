using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proiect
{
    public class OraProgramataRepository
    {
        private const string CONNECTION_STRING =
            @"Data Source=(LocalDB)\MSSQLLocalDB;" +
            @"AttachDbFilename=|DataDirectory|\OrarDB.mdf;" +
            @"Integrated Security=True";

        private OraProgramata CitesteOra(SqlDataReader reader)
        {
            OraProgramata o = new OraProgramata();
            o.ID = (int)reader["ID"];
            o.ProfesorID = (int)reader["ProfesorID"];
            o.MaterieID = (int)reader["MaterieID"];
            o.SalaID = (int)reader["SalaID"];
            o.Zi = reader["Zi"].ToString();
            o.OraInceput = reader["OraInceput"].ToString();
            o.OraSfarsit = reader["OraSfarsit"].ToString();
            return o;
        }

        public List<OraProgramata> GetAll()
        {
            List<OraProgramata> ore = new List<OraProgramata>();
            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM OreProgramate", conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            ore.Add(CitesteOra(reader));
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Eroare la incarcarea orelor: " + ex.Message, ex);
            }
            return ore;
        }

        public void Add(OraProgramata o)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        @"INSERT INTO OreProgramate (ProfesorID, MaterieID, SalaID, Zi, OraInceput, OraSfarsit)
                          VALUES (@ProfesorID, @MaterieID, @SalaID, @Zi, @OraInceput, @OraSfarsit)", conn))
                    {
                        cmd.Parameters.AddWithValue("@ProfesorID", o.ProfesorID);
                        cmd.Parameters.AddWithValue("@MaterieID", o.MaterieID);
                        cmd.Parameters.AddWithValue("@SalaID", o.SalaID);
                        cmd.Parameters.AddWithValue("@Zi", o.Zi);
                        cmd.Parameters.AddWithValue("@OraInceput", o.OraInceput);
                        cmd.Parameters.AddWithValue("@OraSfarsit", o.OraSfarsit);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Eroare la adaugarea orei: " + ex.Message, ex);
            }
        }

        public void Update(OraProgramata o)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        @"UPDATE OreProgramate SET ProfesorID=@ProfesorID, MaterieID=@MaterieID, 
                          SalaID=@SalaID, Zi=@Zi, OraInceput=@OraInceput, OraSfarsit=@OraSfarsit 
                          WHERE ID=@ID", conn))
                    {
                        cmd.Parameters.AddWithValue("@ProfesorID", o.ProfesorID);
                        cmd.Parameters.AddWithValue("@MaterieID", o.MaterieID);
                        cmd.Parameters.AddWithValue("@SalaID", o.SalaID);
                        cmd.Parameters.AddWithValue("@Zi", o.Zi);
                        cmd.Parameters.AddWithValue("@OraInceput", o.OraInceput);
                        cmd.Parameters.AddWithValue("@OraSfarsit", o.OraSfarsit);
                        cmd.Parameters.AddWithValue("@ID", o.ID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Eroare la actualizarea orei: " + ex.Message, ex);
            }
        }

        public void Delete(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        "DELETE FROM OreProgramate WHERE ID=@ID", conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Eroare la stergerea orei: " + ex.Message, ex);
            }
        }
    }
}