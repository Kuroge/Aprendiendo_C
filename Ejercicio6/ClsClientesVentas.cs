namespace Ejercicio6
{
    public class ClsClientesVentas : ClsClientes
    {
        private string rfc;

        private string dirección;

        private string colonia;

        private string municipio;

        private bool esCredito;

        public string Rfc { get => rfc; set => rfc = value; }
        public string Dirección { get => dirección; set => dirección = value; }
        public string Colonia { get => colonia; set => colonia = value; }
        public string Municipio { get => municipio; set => municipio = value; }
        public bool EsCredito { get => esCredito; set => esCredito = value; }
    }
}
