public class ProfesorRepository
{
    public List<Profesor> GetAll()
    {
        return FakeDatabase.Profesori;
    }

    public void Add(Profesor profesor)
    {
        profesor.Id = FakeDatabase.Profesori.Count + 1;
        FakeDatabase.Profesori.Add(profesor);
    }

    public void Update(Profesor profesor)
    {
        var existing = FakeDatabase.Profesori.FirstOrDefault(p => p.Id == profesor.Id);
        if (existing != null)
        {
            existing.Nume = profesor.Nume;
            existing.Prenume = profesor.Prenume;
            existing.Catedra = profesor.Catedra;
        }
    }

    public void Delete(int id)
    {
        var profesor = FakeDatabase.Profesori.FirstOrDefault(p => p.Id == id);
        if (profesor != null)
            FakeDatabase.Profesori.Remove(profesor);
    }
}