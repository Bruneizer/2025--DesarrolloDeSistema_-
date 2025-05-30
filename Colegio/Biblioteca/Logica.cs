namespace Biblioteca;

public class Logica
{
    List<Colegio> colegios = new List<Colegio>();
    List<Curso> cursos = new List<Curso>();
    List<Materia> materias = new List<Materia>();
    List<Estudiante> estudiantes = new List<Estudiante>();

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
    public void AgregarCurso(Curso curso)
    {
        cursos.Add(curso);
    }
    public void InformarCursos()
    {
        foreach (Curso cursoss in cursos)
        {
            Console.WriteLine($"Cursos registrados: {cursoss.Nombre}");

        }
    }
    public void AgregarEstudianteAunCurso(Estudiante estudiante, Curso curso)
    {
        curso.AgregarEstudiante(estudiante);
    }

}