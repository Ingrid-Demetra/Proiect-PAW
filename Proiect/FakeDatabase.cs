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

        public static List<Materie> Materii = new List<Materie>();
        public static List<Sala> Sali = new List<Sala>();
        public static List<OraProgramata> OreProgramate = new List<OraProgramata>();
    }
}