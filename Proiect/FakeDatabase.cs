public class FakeDatabase
{
    public static List<Profesor> Profesori = new List<Profesor>()
    {
        new Profesor { Id = 1, Nume = "Popescu", Prenume = "Ion", Catedra = "Informatica" },
        new Profesor { Id = 2, Nume = "Ionescu", Prenume = "Maria", Catedra = "Matematica" }
    };

    public static List<Materie> Materii = new List<Materie>();
    public static List<Sala> Sali = new List<Sala>();
    public static List<OraProgramata> OreProgramate = new List<OraProgramata>();
}