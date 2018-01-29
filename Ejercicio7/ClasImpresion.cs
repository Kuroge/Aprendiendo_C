using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
   public class ClasImpresion
    {
        public void ImprimeCliente(ClasAbsClientes cliente)
        {
            Console.WriteLine(cliente.Clave + " " + cliente.Nombre);
            Console.WriteLine(cliente.TipoRegimen);
            Console.WriteLine(cliente.RFC);
            Console.ReadKey();
        }
    }
}
