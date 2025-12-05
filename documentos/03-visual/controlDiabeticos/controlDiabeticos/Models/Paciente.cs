namespace controlDiabeticos.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Telefono { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public string Genero { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string TipoDiabetes { get; set; }
        public bool? AlteracionesTipoII { get; set; }
        public ICollection<Prueba> PruebasRealizadas { get; set; }
        
        public Paciente()
        {
            PruebasRealizadas = new HashSet<Prueba>();
        }
    }
}
