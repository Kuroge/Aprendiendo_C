using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class CtrEjercicio13
    {
        public CtrEjercicio13()
        {
            _Productos = new List<ClasProductosInventario>();
        }
        private List<ClasProductosInventario> Productos;

        public List<ClasProductosInventario> Productos { get; set; }

    }
}
