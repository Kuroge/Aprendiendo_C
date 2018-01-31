using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    public class ClasDirecciones
    {
        public ClasDirecciones()
        {
            Calle = string.Empty;
            NumeroExterior = string.Empty;
            NumeroInterior = string.Empty;
            Colonia = string.Empty;
            Municipio = string.Empty;
            Estado = string.Empty;
            CP = string.Empty;
        }
        public ClasDirecciones(string pCalle, string pNumeroExterior, string pNumeroInterior,
                                        string pColonia, string pMunicipio, string pEstado, string pCP)
        {
            Calle = pCalle;
            NumeroExterior = pNumeroExterior;
            NumeroInterior = pNumeroInterior;
            Colonia = pColonia;
            Municipio = pMunicipio;
            Estado = pEstado;
            CP = pCP;
        }

        public string Calle { get; set; }

        public string NumeroExterior{ get; set; }

        public string NumeroInterior { get; set; }

        public string Colonia { get; set; }

        public string Municipio { get; set; }

        public string Estado { get; set; }

        public string CP { get; set; }
    }
}
