using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    public abstract class Persona
    {
        public string PNombre { get; set; }
        public string PApellido { get; set; }
        public string identidad { get; set; }
        public abstract string Nombre();
        public abstract string DNI();
    }
}
