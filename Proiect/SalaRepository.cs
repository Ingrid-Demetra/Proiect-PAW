using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proiect
{
    public class SalaRepository
    {
        private const string CONNECTION_STRING =
            @"Data Source=(LocalDB)\MSSQLLocalDB;" +
            @"AttachDbFilename=|DataDirectory|\OrarDB.mdf;" +
            @"Integrated Security=True";

        private Sala CitesteSala(SqlDataReader reader)
        {
            Sala s = new Sala();
            s.ID = (int)reader["ID"];
            s.NumarSala = (int)reader["NumarSala"];
            s.Capacitate = (int)reader["Capacitate"];
            return s;
        }

        public List<Sala> GetAll()
        {
            List<Sala> sali = new List<Sala>();
            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Sali", conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            sali.Add(CitesteSala(reader));
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Eroare la incarcarea salilor: " + ex.Message, ex);
            }
            return sali;
        }

        public void Add(Sala s)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Sali (NumarSala, Capacitate) VALUES (@NumarSala, @Capacitate)", conn))
                    {
                        cmd.Parameters.AddWithValue("@NumarSala", s.NumarSala);
                        cmd.Parameters.AddWithValue("@Capacitate", s.Capacitate);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Eroare la adaugarea salii: " + ex.Message, ex);
            }
        }

        public void Update(Sala s)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        "UPDATE Sali SET NumarSala=@NumarSala, Capacitate=@Capacitate WHERE ID=@ID", conn))
                    {
                        cmd.Parameters.AddWithValue("@NumarSala", s.NumarSala);
                        cmd.Parameters.AddWithValue("@Capacitate", s.Capacitate);
                        cmd.Parameters.AddWithValue("@ID", s.ID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Eroare la actualizarea salii: " + ex.Message, ex);
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
                        "DELETE FROM Sali WHERE ID=@ID", conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Eroare la stergerea salii: " + ex.Message, ex);
            }
        }
    }
}