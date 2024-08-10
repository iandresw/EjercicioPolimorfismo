using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    public class Alumno : Persona
    {
        public override string DNI()
        {
            return identidad;
        }

        public override string Nombre()
        {
            return PNombre + " " + PApellido;
        }

        public bool Matriculado()
        {
            return true;
        }

        public void Imprimir()
        {
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("## DATOS EMPLEADO ALUMNO ##");
            Console.WriteLine("\n");
            Console.WriteLine($"Nombre empleado: {Nombre()}");
            Console.WriteLine($"DNI: {DNI()}");
            Console.WriteLine($"Matriculado: {(Matriculado() ? "Sí" : "No")}");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("## ULTIMA LINEA ##");
            Console.WriteLine("\n");
        }
    }
}