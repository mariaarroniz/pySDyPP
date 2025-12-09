namespace pySDyPPApi.Models
{
    public class Preguntas : Prueba
    {
        public string ActividadFisica { get; set; }
        public string Fumar { get; set; }
        public string Drogas { get; set; }
        public string Alcohol { get; set; }
        public string TomaMedicacionCorectamente { get; set; }

        public Preguntas(): base() {}

        public override void CalcularSiguienteRealizacion()
        {
            this.SiguienteRealizacion = this.FechaRealizacion.AddMonths(2);
            return;
        }
    }
}
