using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_1
{
    internal class Acciones : IAcciones
    { 
        Alumno a = new Alumno();
        private List<Alumno> listaalumnos = new List<Alumno>()
        {  new Alumno("Rebeca", 20, 112969),
        new Alumno("Maya",19,112901)};

        public List<Alumno> Consulatar()
        { 
            return listaalumnos; 
        }

        public void Actualizar(int matricula, string nombre, int edad)
        {
            throw new NotImplementedException();
        }
        public void Agregar(int matricula, string nombre, int edad)
        {
            listaalumnos.Add(new Alumno(a.Nombre = nombre,a.Edad = edad,a.Matricula = matricula));
        }
        public void Eliminar(int matricula)
        {
            var objecteliminar = listaalumnos.FirstOrDefault(x =>  x.Matricula == matricula);
            if (objecteliminar != null) 
                listaalumnos.Remove(objecteliminar);

            else
                Console.WriteLine("No se pudo eliminar, no se encontro nada");
        }
        public void ExportarExcel()
        {
            throw new NotImplementedException();
        }

        public List<Alumno> Consultar()
        {
            throw new NotImplementedException();
        }
    }
}
