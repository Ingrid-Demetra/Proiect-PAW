using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    public class FakeDatabase
    {
        public static List<Profesor> Profesori = new List<Profesor>()
    {
        new Profesor { ID = 1, Nume = "Popescu", Prenume = "Ion", Catedra = "Informatica" },
        new Profesor { ID = 2, Nume = "Ionescu", Prenume = "Maria", Catedra = "Matematica" }
    };

        public static List<Materie> Materii = new List<Materie>()
      {
             new Materie { ID = 1, Denumire = "Baze de Date", AnStudiu = 2 },
             new Materie { ID = 2, Denumire = "Algoritmi", AnStudiu = 1 },
             new Materie { ID = 3, Denumire = "Programare Web", AnStudiu = 3 }
      };
        public static List<Sala> Sali = new List<Sala>()
        {
             new Sala { ID = 1, NumarSala = 101, Capacitate = 30 },
             new Sala { ID = 2, NumarSala = 202, Capacitate = 50 },
             new Sala { ID = 3, NumarSala = 2025, Capacitate = 25 }
        };
        public static List<OraProgramata> OreProgramate = new List<OraProgramata>()
        {
            new OraProgramata { ID = 1, ProfesorID = 1, MaterieID = 1, SalaID = 1, Zi = "Luni", OraInceput = "08:00", OraSfarsit = "10:00" },
            new OraProgramata { ID = 2, ProfesorID = 2, MaterieID = 2, SalaID = 2, Zi = "Marti", OraInceput = "10:00", OraSfarsit = "12:00" }
        };
    }
}