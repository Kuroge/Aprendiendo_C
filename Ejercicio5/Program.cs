using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            ClsEmpleados empleado;
            empleado = new ClsEmpleados();
            empleado.Edad = 25;
            empleado.Nombre = "Marcos Hernandez";
            empleado.SueldoDiario = 12.5m;
            decimal total;
            total = empleado.CalculaSalario(30);
            Console.WriteLine($"El salario mensual del empleado {empleado.Nombre} es: {total:C}");
            Console.ReadKey();

        }
    }
}
