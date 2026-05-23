using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    public class OraProgramataRepository
    {
        public List<OraProgramata> GetAll()
        {
            return FakeDatabase.OreProgramate;
        }

        public void Add(OraProgramata ora)
        {
            ora.ID = FakeDatabase.OreProgramate.Count + 1;
            FakeDatabase.OreProgramate.Add(ora);
        }
        public void Update(OraProgramata ora)
        {
            var existing = FakeDatabase.OreProgramate.FirstOrDefault(o => o.ID == ora.ID);
            if (existing != null)
            {
                existing.ProfesorID = ora.ProfesorID;
                existing.MaterieID = ora.MaterieID;
                existing.SalaID = ora.SalaID;
                existing.Zi = ora.Zi;
                existing.OraInceput = ora.OraInceput;
                existing.OraSfarsit = ora.OraSfarsit;
            }
        }
        public void Delete(int id)
        {
            var ora = FakeDatabase.OreProgramate.FirstOrDefault(o => o.ID == id);
            if (ora != null)
                FakeDatabase.OreProgramate.Remove(ora);
        }
    }

}
