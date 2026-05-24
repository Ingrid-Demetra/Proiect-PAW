using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proiect
{
    public class MaterieRepository
    {
        private const string CONNECTION_STRING =
            @"Data Source=(LocalDB)\MSSQLLocalDB;" +
            @"AttachDbFilename=|DataDirectory|\OrarDB.mdf;" +
            @"Integrated Security=True";

        private Materie CitesteMaterie(SqlDataReader reader)
        {
            Materie m = new Materie();
            m.ID = (int)reader["ID"];
            m.Denumire = reader["Denumire"].ToString();
            m.AnStudiu = (int)reader["AnStudiu"];
            return m;
        }

        public List<Materie> GetAll()
        {
            List<Materie> materii = new List<Materie>();
            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Materii", conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            materii.Add(CitesteMaterie(reader));
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Eroare la incarcarea materiilor: " + ex.Message, ex);
            }
            return materii;
        }

        public void Add(Materie m)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Materii (Denumire, AnStudiu) VALUES (@Denumire, @AnStudiu)", conn))
                    {
                        cmd.Parameters.AddWithValue("@Denumire", m.Denumire);
                        cmd.Parameters.AddWithValue("@AnStudiu", m.AnStudiu);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Eroare la adaugarea materiei: " + ex.Message, ex);
            }
        }

        public void Update(Materie m)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        "UPDATE Materii SET Denumire=@Denumire, AnStudiu=@AnStudiu WHERE ID=@ID", conn))
                    {
                        cmd.Parameters.AddWithValue("@Denumire", m.Denumire);
                        cmd.Parameters.AddWithValue("@AnStudiu", m.AnStudiu);
                        cmd.Parameters.AddWithValue("@ID", m.ID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Eroare la actualizarea materiei: " + ex.Message, ex);
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
                        "DELETE FROM Materii WHERE ID=@ID", conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Eroare la stergerea materiei: " + ex.Message, ex);
            }
        }
    }
}