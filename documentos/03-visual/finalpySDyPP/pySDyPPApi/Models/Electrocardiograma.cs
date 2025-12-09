namespace pySDyPPApi.Models
{
    public class Electrocardiograma : Prueba
    {
        public Electrocardiograma() : base() { }
        public override void CalcularSiguienteRealizacion()
        {
            this.SiguienteRealizacion = this.FechaRealizacion.AddYears(2);
            return;
        }
    }
}
