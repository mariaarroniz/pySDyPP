using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace pySDyPP.Models
{
    public class Paciente
    {
        public int PacienteId { get; set; }

        [Required]
        public string Telefono { get; set; }

        [Required]
        public string Nombre { get; set; }
        
        [Required]
        public string Apellidos { get; set; }

        [Required]
        public int Edad { get; set; }

        [Required]
        public string Genero { get; set; }

        public DateTime FechaNacimiento { get; set; }

        [Required]
        public string TipoDiabetes { get; set; }

        public virtual ObservableCollectionListSource<Prueba> PruebasRealizadas { get; } = new();
    }
}
