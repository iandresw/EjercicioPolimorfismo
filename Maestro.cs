using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    public class Maestro : Persona
    {
        public override string DNI()
        {
            return identidad;
        }

        public override string Nombre()
        {
            return PNombre + " " + PApellido;
        }

        static List<string> ClasesImpartidas()
        {
            return new List<string> { "Matemáticas", "Física", "Programación" };
        }

        public void Imprimir()
        {
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("## DATOS EMPLEADO MAESTRO ##");
            Console.WriteLine("\n");
            Console.WriteLine($"Nombre Maestro: {Nombre()}");
            Console.WriteLine($"DNI: {DNI()}");
            Console.WriteLine("\n");
            Console.WriteLine("Clases Impartidas:");
            foreach (var clase in ClasesImpartidas())
            {
                Console.WriteLine($"- {clase}");
            }
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("## ULTIMA LINEA ##");
            Console.WriteLine("\n");
        }
    }
}
