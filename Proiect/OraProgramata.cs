using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    public class OraProgramata
    {
        public int ID { get; set; }
        public int ProfesorID { get; set; }
        public int MaterieID { get; set; }
        public int SalaID { get; set; }
        public string Zi { get; set; }
        public string OraInceput { get; set; }
        public string OraSfarsit { get; set; }

        public Profesor Profesor { get; set; }
        public Materie Materie { get; set; }
        public Sala Sala { get; set; }

        public string NumeProfesor => Profesor != null ? Profesor.Nume + " " + Profesor.Prenume : "";
        public string NumeMaterie => Materie != null ? Materie.Denumire : "";
        public string NumarSalaAfisare => Sala != null ? Sala.NumarSala.ToString() : "";
    }
}
