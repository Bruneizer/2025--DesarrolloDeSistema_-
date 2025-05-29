namespace Biblioteca;

public class Curso
{
    public string Nombre { get; set; }
    List<Estudiante> estudiantes = new List<Estudiante>();
    public Curso(string nombre)
    {
        Nombre = nombre;

    }
}
