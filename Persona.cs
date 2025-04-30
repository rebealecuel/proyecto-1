using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_1
{
    internal class Persona
    {
        public Persona() { }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            this.edad = edad;
        }

        public string Nombre { get; set; }

        public int edad { get; set; }
    }
}
