namespace pySDyPPForms.ModelsForms.Models
{
    public abstract class Prueba
    {
        public int PruebaId { get; set; }
        public string Tipo { get; set; }
        public bool Realizada { get; set; }
        public DateTime FechaRealizacion { get; set; }
        public DateTime SiguienteRealizacion { get; set; }
        public string Resultado { get; set; }
        public string Observaciones { get; set; }
        public string Estado { get; set; }

        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }

        public virtual void CalcularSiguienteRealizacion()
        {
            return;
        }
    }
}