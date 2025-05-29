using Biblioteca;

bool activo = true;
Logica logica = new Logica();
while (activo)
{
Console.WriteLine("Presione 1 para agregar un colegio: ");
Console.WriteLine("Presione 2 para agregar un curso: ");
Console.WriteLine("Presione 3 para agregar un estudiante");
Console.WriteLine("Presione 4 para agregar un estudiante a un curso: ");
Console.WriteLine("Presione 5 para agregar materia a un estudiante");
Console.WriteLine("Presione 6 para saber los nombres de los estudiantes de un curso: ");
Console.WriteLine("Presione 7 para saber la nota de un estudiante de un curso: ");
Console.WriteLine("Presione 8 para saber las notas los estudiante de un curso: ");
Console.WriteLine("Presione 9 para saber la nota de un estudiante en una materia: ");
Console.WriteLine("Presione A para saber la lista de materias de un estudiante: ");
Console.WriteLine("Presione B para saber la nota de los estudiantes desaprobados: ");
Console.WriteLine("Presione C para saber la cantidad de alumnos desaprobados de un curso: ");
int ingresado = Convert.ToInt32(Console.ReadLine());
    switch (ingresado)
    {
        case 1:
            Console.WriteLine("Ingrese el nombre del colegio: ");
            string nombreColegio = Console.ReadLine();
            Colegio colegio = new Colegio(nombreColegio);
            logica.AgregarColegio(colegio);
            break;
        case 11:
            logica.InformarColegios();
            break;
        case 2:
            Console.WriteLine("Ingrese el nombre del curso: ");
            string nombreCurso = Console.ReadLine();
            
            break;



    }    
} 
