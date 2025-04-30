using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_1
{
    internal class Program
    {
        public enum Menu
        {
            Consular = 1, Agregar, Actualizar, Eliminar
        }
        static void Main(string[] args)
        {
            Acciones acc = new Acciones();
            while (true)
            {
                switch (Men())
                {
                    case Menu.Consular:
                        var lista = acc.Consulatar();
                        foreach (var l in lista)
                        {
                            Console.WriteLine("-----------");
                            Console.WriteLine($"Nombre: {l.Nombre}");
                            Console.WriteLine($"Edad: {l.edad}");
                            Console.WriteLine($"Matricula: {l.Matricula}");
                            Console.WriteLine("-----------");
                        }
                        break;
                    case Menu.Agregar:
                        Console.WriteLine("Nombre");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Edad");
                        int edad = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Matricula");
                        int Matricula = Convert.ToInt32(Console.ReadLine());
                        break;
                    case Menu.Actualizar:
                        break;
                    case Menu.Eliminar: 
                        break;
                }
            }
        }

        public Menu Men()
        {
            Console.WriteLine("1) Consultar");
            Console.WriteLine("2) Agregar");
            Console.WriteLine("3) Actualizar");
            Console.WriteLine("4) ELiminar");
            Menu opc = (Menu)Convert.ToInt32(Console.ReadLine());

            return opc;
        }
    }
}
