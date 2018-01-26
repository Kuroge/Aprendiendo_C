namespace Ejercicio5
{
    public class ClsEmpleados
    {
        private string _Nombre;

        public ClsEmpleados()
        {
            Nombre = "";
            SueldoDiario = 0.0m;
            Edad = 0;
        }

        public string Nombre { get => _Nombre; set => _Nombre = value; }

        public decimal SueldoDiario { get; set; }

        public int Edad { get; set; }

        public decimal CalculaSalario(int NumeroDias)
        {
            return SueldoDiario * NumeroDias;
        }

    }
}
