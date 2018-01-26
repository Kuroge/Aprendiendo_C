using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int i = 10;
            decimal x = 12.2m;
            bool bandera = false;
            string cadena = string.Empty;
            i = Convert.ToInt32(bandera);
            DateTime fecha = DateTime.Today;
            Console.WriteLine("El valor de i es: {0}", i);
            Console.WriteLine("El valor de x es: {0:C}", x);
            Console.WriteLine("El valor de bandera es: " + bandera.ToString());
            Console.WriteLine("El valor de cadena es: " + cadena);
            Console.WriteLine("El valor de i es: " + fecha.ToShortDateString());
            Console.ReadKey();
        }
    }
}
