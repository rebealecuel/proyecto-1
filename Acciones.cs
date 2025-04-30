using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_1
{
    internal class Acciones : IAcciones
    {
        private List<Alumno> listaalumnos = new List<Alumno>()
        { new Alumno("Rebeca", 20, 112969),
        new Alumno("Maya",19,112901)};

        public List<Alumno> Consulatar()
        { return listaalumnos; }

        public void Actualizar(int matricula, string nombre, int edad)
        {
            throw new NotImplementedException();
        }
        public void Agregar(int matricula, string nombre, int edad)
        {
            throw new NotImplementedException();
        }
        public void Eliminar(int matricula)
        {
            throw new NotImplementedException();
        }
        public void ExportarExcel()
        {
            throw new NotImplementedException();
        }
    }
}
