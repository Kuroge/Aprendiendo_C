using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ejercicio11
{
    public class ClasMuestraHashTable
    {
        Hashtable Tabla;

        public ClasMuestraHashTable()
        {
            Tabla = new Hashtable();
        }

        public void AgregarDatos()
        {
            Tabla.Add("C001", "Producto 1");
            Tabla.Add("B123", "Producto 3");
            Tabla.Add("J452", "Producto 4");
            Tabla.Add("Z099", "Producto 5");
        }
        public void ImprimirDatos()
        {
            Console.WriteLine($"Existen {Tabla.Count}. Introduce la clave: ");
            string cadena = Console.ReadLine();
            if (Tabla[cadena] == null)
            {
                Console.WriteLine("El elemento no existe");
            }
            else
            {
                Console.WriteLine("El elemento encontrado es:");
                Console.WriteLine($"{Tabla[cadena]}");
                
            }
            Console.ReadKey();
        }
        public void EliminarElemento(string key)
        {
            Tabla.Remove(key);
        }
    }
}
