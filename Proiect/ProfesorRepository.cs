
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proiect
{
    public class ProfesorRepository
    {
        private const string CONNECTION_STRING =
            @"Data Source=(LocalDB)\MSSQLLocalDB;" +
            @"AttachDbFilename=|DataDirectory|\OrarDB.mdf;" +
            @"Integrated Security=True";
        private Profesor CitesteProfesor(SqlDataReader reader)
        {
            Profesor p = new Profesor();
            p.ID = (int)reader["ID"];
            p.Nume = reader["Nume"].ToString();
            p.Prenume = reader["Prenume"].ToString();
            p.Catedra = reader["Catedra"].ToString();
            return p;
        }

        public List<Profesor> GetAll()
        {
            List<Profesor> profesori = new List<Profesor>();
            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Profesori", conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            profesori.Add(CitesteProfesor(reader));
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Eroare la incarcarea profesorilor: " + ex.Message, ex);
            }
            return profesori;
        }

        public void Add(Profesor p)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Profesori (Nume, Prenume, Catedra) VALUES (@Nume, @Prenume, @Catedra)", conn))
                    {
                        cmd.Parameters.AddWithValue("@Nume", p.Nume);
                        cmd.Parameters.AddWithValue("@Prenume", p.Prenume);
                        cmd.Parameters.AddWithValue("@Catedra", p.Catedra);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Eroare la adaugarea profesorului: " + ex.Message, ex);
            }
        }

        public void Update(Profesor p)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        "UPDATE Profesori SET Nume=@Nume, Prenume=@Prenume, Catedra=@Catedra WHERE ID=@ID", conn))
                    {
                        cmd.Parameters.AddWithValue("@Nume", p.Nume);
                        cmd.Parameters.AddWithValue("@Prenume", p.Prenume);
                        cmd.Parameters.AddWithValue("@Catedra", p.Catedra);
                        cmd.Parameters.AddWithValue("@ID", p.ID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Eroare la actualizarea profesorului: " + ex.Message, ex);
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
                        "DELETE FROM Profesori WHERE ID=@ID", conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Eroare la stergerea profesorului: " + ex.Message, ex);
            }
        }
    }
}