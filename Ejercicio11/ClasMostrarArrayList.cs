using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    public class ClasMostrarArrayList
    {
        ArrayList Lista;

        public ClasMostrarArrayList()
        {
            Lista = new ArrayList();
        }

        public void CapturaDatos()
        {
            string cadena;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Dame el dato {i+1}");
                cadena = Console.ReadLine();
                Lista.Add(cadena);
            }
        }
        public void ImprimeDatos()
        {
            foreach (var item in Lista)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
