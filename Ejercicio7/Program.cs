using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            ClasClientesBase cliente = new ClasClientesBase(0, "Adrián García Riera", "001", "HEHM", 1, "Adrián García Riera");

            Console.WriteLine(cliente.Clave + " " + cliente.Nombre);
            Console.WriteLine(cliente.TipoRegimen);
            Console.WriteLine(cliente.RFC);
            Console.ReadKey();

        }
    }
}
