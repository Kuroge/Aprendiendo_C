using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14
{
    public class ClasProductosBase : ClasAbsProductos
    {
        public override int idProducto { get; set; }

        public override string Clave { get; set; }

        public override string Descripcion { get; set; }
    }
}
