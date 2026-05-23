
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    public class ProfesorRepository
    {
        public List<Profesor> GetAll()
        {
            return FakeDatabase.Profesori;
        }

        public void Add(Profesor profesor)
        {
            profesor.ID = FakeDatabase.Profesori.Count + 1;
            FakeDatabase.Profesori.Add(profesor);
        }

        public void Update(Profesor profesor)
        {
            var existing = FakeDatabase.Profesori.FirstOrDefault(p => p.ID == profesor.ID);
            if (existing != null)
            {
                existing.Nume = profesor.Nume;
                existing.Prenume = profesor.Prenume;
                existing.Catedra = profesor.Catedra;
            }
        }

        public void Delete(int ID)
        {
            var profesor = FakeDatabase.Profesori.FirstOrDefault(p => p.ID == ID);
            if (profesor != null)
                FakeDatabase.Profesori.Remove(profesor);
        }
    }
}