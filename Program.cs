using EjercicioPolimorfismo;


Console.WriteLine("########### INICIO EJERCICIO POLIMORFISMO ###########");

Maestro maestro = new Maestro();
Console.WriteLine("Ingrese el Nombre del Maestro: ");
maestro.PNombre = Console.ReadLine();
Console.WriteLine("Ingrese el Apellido del Maestro: ");
maestro.PApellido = Console.ReadLine();
Console.WriteLine("Ingrese el DNI del Maestro: ");
maestro.identidad = Console.ReadLine();
maestro.Imprimir();

Alumno alumno = new Alumno();

Console.WriteLine("Ingrese el Nombre del Alumno: ");
alumno.PNombre = Console.ReadLine();
Console.WriteLine("Ingrese el Apellido del Alumno: ");
alumno.PApellido = Console.ReadLine();
Console.WriteLine("Ingrese la identidad del empleado cajero: ");
alumno.identidad = Console.ReadLine();
alumno.Imprimir();