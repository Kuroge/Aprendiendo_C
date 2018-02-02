using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14
{
    public delegate void MuestraAvance(string valor);
    public class ClasArchivoProductos
    {
        public event MuestraAvance avance;
        public void ObtenProductos(List<ClasProductosBase> productos)
        {
            StreamReader sr = new StreamReader(@"C:\Proyectos\Tutorial_C\Exercise14\productos.txt");
            string cadena = sr.ReadLine();
            int i = 1;
            while (cadena != null)
            {
                string[] campos = cadena.Split(',');
                ClasProductosBase prod = new ClasProductosBase();
                prod.idProducto = Convert.ToInt32(campos[0]);
                prod.Clave = campos[1];
                prod.Descripcion = campos[2];
                productos.Add(prod);
                avance(i.ToString());
                i++;
                cadena = sr.ReadLine();
            }
            sr.Close();
        }
    }
}
