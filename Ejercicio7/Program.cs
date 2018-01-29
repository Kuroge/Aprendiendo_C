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
            ClasClientesConContacto cliente = new ClasClientesConContacto(0, "Adrián García Riera", "001", "HEHM", 1,
                                                                            "Adrián García Riera", "233333", "", 
                                                                            "manolo@gmail.com", "Calle Falsa 123", 
                                                                            "123", "", "La cueva del jaguar", "Ponferrada",
                                                                            "Chiapas", "15010");

            ClasDirecciones direcciones = new ClasDirecciones("Calle Falsa 123",
                                                               "123", "", "La cueva del jaguar",
                                                               "Ponferrada","Chiapas", "15010");
            

            ClasClientesConContacto clienteAlternativo = new ClasClientesConContacto(0, "Adrián García Riera", "001", "HEHM", 1,
                                                                            "Adrián García Riera", "233333", "",
                                                                            "manolo@gmail.com", direcciones);

            ClasImpresion Impresion = new ClasImpresion();
            Impresion.ImprimeCliente(clienteAlternativo);

        }
    }
}
