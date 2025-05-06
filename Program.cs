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
            Consular = 1, Agregar, Actualizar, Eliminar, Salir
        }
        static void Main(string[] args)
        {
            Acciones acc = new Acciones();
            while (true)
            {
                switch (Menun())
                {
                    case Menu.Consular:
                        var lista = acc.Consulatar();
                        foreach (var l in lista)
                        {
                            Console.WriteLine("-----------");
                            Console.WriteLine($"Nombre: {l.Nombre}");
                            Console.WriteLine($"Edad: {l.Edad}");
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
                        acc.Agregar(Matricula, nombre, edad);
                        break;
                    case Menu.Actualizar:
                        Console.WriteLine("Dame la matricula a actualizar");
                        int matri = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Edad");
                        int eda = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Matricula");
                        string name = Console.ReadLine();
                        break;
                    case Menu.Eliminar:
                        Console.WriteLine("Dame la matricula a eliminar");
                        int matriculaeliminar = Convert.ToInt32(Console.ReadLine());
                        acc.Eliminar(matriculaeliminar);
                        break;
                    case Menu.Salir:
                        Environment.Exit(0);
                        break;
                    default: 
                        Console.WriteLine("no valido");
                        break;
                }
            }
        }

        static Menu Menun()
        {
            Console.WriteLine("1) Consultar");
            Console.WriteLine("2) Agregar");
            Console.WriteLine("3) Actualizar");
            Console.WriteLine("4) ELiminar");
            Console.WriteLine("5) Salir");
            Menu opc = (Menu)Convert.ToInt32(Console.ReadLine());

            return opc;
        }
    }
}
