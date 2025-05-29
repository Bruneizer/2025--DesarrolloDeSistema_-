namespace Biblioteca;

public class Curso
{
    public string Nombre { get; set; }
    List<Estudiante> Estudiantes = new List<Estudiante>();
    public Curso(String nombre)
    {
        Nombre = nombre;
        List<Estudiante> Estudiantes = new List<Estudiante>();

    }
}
