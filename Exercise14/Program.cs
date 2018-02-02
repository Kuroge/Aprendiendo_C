using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ClasProductosBase> productos = new List<ClasProductosBase>();
            ClasArchivoProductos arch = new ClasArchivoProductos();
            arch.avance += main_avance;
            arch.ObtenProductos(productos);
            Console.ReadKey();
        }

        private static void main_avance(string valor)
        {
            Console.WriteLine(valor);
        }
    }
}
