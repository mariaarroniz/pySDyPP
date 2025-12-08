using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;

namespace pySDyPPForms.ModelsForms.Models
{
    public class Paciente
    {
        public int PacienteId { get; set; }

        [Required]
        public string Telefono { get; set; } = string.Empty;

        [Required]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        public string Apellidos { get; set; } = string.Empty;

        [Required]
        public int Edad { get; set; }

        [Required]
        public string Genero { get; set; } = string.Empty;

        public DateTime FechaNacimiento { get; set; }

        [Required]
        public string TipoDiabetes { get; set; } = string.Empty;

        public virtual ObservableCollection<Prueba> PruebasRealizadas { get; } = new ObservableCollection<Prueba>();
    }
}
