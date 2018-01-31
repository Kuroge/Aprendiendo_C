using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[4];
            string cadena;
            for (int i = 0; i < 4; i++)
            {
                cadena = Console.ReadLine();
                array[i] = Convert.ToInt32(cadena);
            }
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
    }
}
