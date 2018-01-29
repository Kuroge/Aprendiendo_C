using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class ClasArchivos : IntSalidas
    {
        public void ImprimeCliente(ClasAbsClientes cliente)
        {
            StreamWriter ar = new StreamWriter(@"C:\Proyectos\Tutorial_C\Ejercicio7\ArchBitacora.log", true);
            ar.WriteLine(cliente.Clave + " " + cliente.Nombre);
            if (cliente.TipoRegimen == 1)
            {
                ar.WriteLine("Tipo: PERSONA FÍSICA");
            }
            else
            {
                ar.WriteLine("Tipo: PERSONA MORAL");
            }
            ar.WriteLine("RFC: " + cliente.RFC);
            ar.Close();
        }

        public void ImprimeDireccion(ClasDirecciones direccion)
        {

        }
    }
}
