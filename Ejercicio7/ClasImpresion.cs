using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
   public class ClasImpresion : IntSalidas
    {
        public void ImprimeCliente(ClasAbsClientes cliente)
        {
            Console.WriteLine(cliente.Clave + " " + cliente.Nombre);
            if (cliente.TipoRegimen == 1)
            {
                Console.WriteLine("Tipo: PERSONA FÍSICA");
            }
            else
            {
                Console.WriteLine("Tipo: PERSONA MORAL");
            }
            Console.WriteLine("RFC: " + cliente.RFC);
            Console.ReadKey();
        }
        public void ImprimeDireccion(ClasDirecciones direccion)
        {
            Console.WriteLine(direccion.Calle + " No " + direccion.NumeroExterior);
            Console.WriteLine(direccion.Colonia);
            Console.WriteLine(direccion.CP);
            Console.WriteLine(direccion.Estado);
        }
    }
}
