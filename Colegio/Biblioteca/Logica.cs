namespace Biblioteca;

public class Logica
{
    List<Colegio> colegios = new List<Colegio>();
    List<Curso> cursos = new List<Curso>();

    public void AgregarColegio(Colegio colegio)
    {
        colegios.Add(colegio);
    }
    public void InformarColegios()
    {
        foreach (Colegio colegioss in colegios)
        {
            Console.WriteLine($"Colegios registrados: {colegioss.Nombre}");

        }
    }
    public void AgregarCurso(Curso curso, Colegio colegio)
    {
        cursos.Add(curso);
        cursos.Add(colegio);
    }

}