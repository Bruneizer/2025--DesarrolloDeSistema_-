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
            Console.WriteLine($"Curso registrado/s:{cursoss.Nombre}");
        }
    }
    public void AgregarEstudianteAunCurso(Estudiante estudiante, Curso curso)
    {
        curso.AgregarEstudiante(estudiante);
    }
    public Curso? BuscarCursoPorNombre(string nombre)
    {
        return cursos.FirstOrDefault(c => c.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
    }
    public void InformarEstudiantesDentroDeUnCurso(Curso curso)
    {
        foreach (var estudiante in curso.Estudiantes)
        {
            Console.WriteLine($"{estudiante.Nombre} {estudiante.Apellido}");
        }
    }
// - Las notas de los estudiantes de un curso.
public void NotaEstudiante(Estudiante estudiante,Materia materia)
{
    estudiantes.Add(estudiante);
    
}


}