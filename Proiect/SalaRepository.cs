using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    public class SalaRepository
    {
        public List<Sala> GetAll()
        {
            return FakeDatabase.Sali;
        }

        public void Add(Sala sala)
        {
            sala.ID = FakeDatabase.Sali.Count + 1;
            FakeDatabase.Sali.Add(sala);
        }

        public void Update(Sala sala)
        {
            var existing = FakeDatabase.Sali.FirstOrDefault(s => s.ID == sala.ID);
            if (existing != null)
            {
                existing.NumarSala = sala.NumarSala;
                existing.Capacitate = sala.Capacitate;
            }
        }

        public void Delete(int id)
        {
            var sala = FakeDatabase.Sali.FirstOrDefault(s => s.ID == id);
            if (sala != null)
                FakeDatabase.Sali.Remove(sala);
        }
    }
}
