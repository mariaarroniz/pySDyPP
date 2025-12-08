namespace pySDyPPApi.Models
{
    public class Electrocardiograma : Prueba
    {
        public override void CalcularSiguienteRealizacion()
        {
            this.SiguienteRealizacion = this.FechaRealizacion.AddYears(2);
            return;
        }
    }
}
