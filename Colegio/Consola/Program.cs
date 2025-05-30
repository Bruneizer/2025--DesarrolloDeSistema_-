using System.Xml;
using Biblioteca;

bool activo = true;
Logica logica = new Logica();

while (activo)
{
    Console.Write("Presione 1 para agregar un curso: ");
    Console.Write("Presione 2 para agregar un estudiante a un curso: ");
    Console.Write("Presione 3 para saber los estudiantes de un curso: ");
    Console.Write("Presione 4 para agregar materia a un estudiante");
    Console.Write("Presione 6 para saber los nombres de los estudiantes de un curso: ");
    Console.Write("Presione 7 para saber la nota de un estudiante de un curso: ");
    Console.Write("Presione 8 para saber las notas los estudiante de un curso: ");
    Console.Write("Presione 9 para saber la nota de un estudiante en una materia: ");
    Console.Write("Presione A para saber la lista de materias de un estudiante: ");
    Console.Write("Presione B para saber la nota de los estudiantes desaprobados: ");
    Console.Write("Presione C para saber la cantidad de alumnos desaprobados de un curso: ");
    int ingresado = Convert.ToInt32(Console.ReadLine());
    switch (ingresado)
    {
        case 1:
            Console.Write("Ingrese el nombre del curso: ");
            string nombreCurso = Console.ReadLine();
            Curso curso = new Curso(nombreCurso);
            logica.AgregarCurso(curso);
            break;
        case 11:
            logica.InformarCursos();
            break;
        case 2:
            Console.Write("Ingrese el nombre del estudiante: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese el apellido del estudiante: ");
            string apellido = Console.ReadLine();
            Console.Write("Ingrese el legajo del estudiante: ");
            int legajo = Convert.ToInt32(Console.ReadLine());
            Estudiante estudiante = new Estudiante(nombre, apellido, legajo);
            logica.InformarCursos();
            Console.Write("A que curso desea agregar?: ");
            nombreCurso = Console.ReadLine();
            Curso? cursoSeleccionado = logica.BuscarCursoPorNombre(nombreCurso);
            logica.AgregarEstudianteAunCurso(estudiante, cursoSeleccionado);
            Console.WriteLine("Estudiante inscripto correctamente.");
            break;
        case 3:
            Console.Write("Alumnos de que curso desea saber: ");
            logica.InformarCursos();
            string cursoooo = Console.ReadLine();
            Curso? cursoBuscar = logica.BuscarCursoPorNombre(cursoooo);
            logica.InformarEstudiantesDentroDeUnCurso(cursoBuscar);
            break;
//- Las notas de un estudiante en un curso.

        case 4:
        Console.Write("Ingrese Curso:");
        Curso curso1 = Console.ReadLine();
        Console.Write("Ingrese el nombre y apellido del estudiante:");
        Estudiante estudiante1 = Console.ReadLine();
        break;


    
    
    
    
    
    
    
    
    
    }
}
