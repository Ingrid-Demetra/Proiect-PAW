using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    internal class MaterieRepository
    {
        public List<Materie> GetAll()
        {
            return FakeDatabase.Materii;
        }

        public void Add(Materie materie)
        {
            materie.ID = FakeDatabase.Materii.Count + 1;
            FakeDatabase.Materii.Add(materie);
        }

        public void Update(Materie materie)
        {
            var existing = FakeDatabase.Materii.FirstOrDefault(m => m.ID == materie.ID);
            if (existing != null)
            {
                existing.Denumire = materie.Denumire;
                existing.AnStudiu = materie.AnStudiu;
            }
        }

        public void Delete(int id)
        {
            var materie = FakeDatabase.Materii.FirstOrDefault(m => m.ID == id);
            if (materie != null)
                FakeDatabase.Materii.Remove(materie);
        }
    }
}
