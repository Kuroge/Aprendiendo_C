using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsClientesVentas Cliente = new ClsClientesVentas();
            Cliente.IdCliente = 123;
            Cliente.Apellidos = "Hernandez Hernandez";
            Cliente.Nombres = "Marcos";
            Cliente.Rfc = "HEMM";
            Cliente.Dirección = "Av Tigre 119";
            Cliente.Colonia = "La Cueva del Jaguar";
            Cliente.Municipio = "Tuxtla Gutierrez";
            Cliente.EsCredito = true;
            Console.WriteLine(Cliente.Apellidos + " " + Cliente.Nombres);
            Console.WriteLine(Cliente.Dirección + " " + Cliente.Colonia + " " + Cliente.Municipio);
            Console.WriteLine(Cliente.Rfc);
            if (Cliente.EsCredito)
            {
                Console.WriteLine("El cliente tiene crédito");
            }
            else
            {
                Console.WriteLine("El cliente no tiene crédito");
            }
            Console.ReadKey();
        }
    }
}
