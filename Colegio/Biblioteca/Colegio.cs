namespace Biblioteca;

public class Colegio
{
    public string Nombre { get; set; }
    public Curso curso { get; set; }
    public Colegio(string nombre)
    {
        Nombre = nombre;
    }

}


