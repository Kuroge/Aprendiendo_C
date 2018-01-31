using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Esta sería la manera incorrecta
            /*ClasClientesConContacto cliente = new ClasClientesConContacto(0, "Adrián García Riera", "001", "HEHM", 1,
                                                                            "Adrián García Riera", "233333", "", 
                                                                            "manolo@gmail.com", "Calle Falsa 123", 
                                                                            "123", "", "La cueva del jaguar", "Ponferrada",
                                                                            "Chiapas", "15010");*/


            //Esta sería la manera correcta, creamos el objeto y se lo pasamos como parámetro a la clase ClasClientesConContacto
            ClasDirecciones direcciones = new ClasDirecciones("Calle Falsa 123",
                                                               "123", "", "La cueva del jaguar",
                                                               "Ponferrada", "Chiapas", "15010");


            ClasClientesConContacto clienteAlternativo = new ClasClientesConContacto(0, "Adrián García Riera", "001", "HEHM", 1,
                                                                            "Adrián García Riera", "233333", "",
                                                                            "manolo@gmail.com", direcciones);

            IntSalidas Impresion;
            string cadena = Console.ReadLine();
            if (cadena == "1")
            {
                Impresion = new ClasImpresion();
            }
            else
            {
                Impresion = new ClasArchivos();
            }
            try
            {
                Impresion.ImprimeCliente(clienteAlternativo);
            }catch(Exception e)
            {
                Console.WriteLine($"Ocurrió un error: {e.Message}");
                Console.ReadKey();
            }
        }
    }
}
