namespace pySDyPPApi.Models
{
    public class Analitica : Prueba
    {
        public Boolean Hba1 { get; set; }

        public Analitica() : base() { }

        public override void CalcularSiguienteRealizacion()
        {
            if (this.Hba1 == true)
            {
                this.SiguienteRealizacion = this.FechaRealizacion.AddMonths(6);
                return;
            }
            else
            {
                this.SiguienteRealizacion = this.FechaRealizacion.AddYears(1);
                return;
            }
        }
    }
}
