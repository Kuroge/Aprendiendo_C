using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14
{
    public abstract class ClasAbsProductos
    {
        public abstract int idProducto { get; set; }

        public abstract string Clave { get; set; }

        public abstract string Descripcion { get; set; }
    }
}
