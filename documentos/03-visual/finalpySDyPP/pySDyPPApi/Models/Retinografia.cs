namespace pySDyPPApi.Models
{
    public class Retinografia : Prueba
    {
        public string Tipo { get; set; }
        public bool AlteracionesTipoII { get; set; }

        public Retinografia() : base() { }

        public override void CalcularSiguienteRealizacion()
        {
            if (this.Tipo == "TipoI")
            {
                this.SiguienteRealizacion = this.FechaRealizacion.AddYears(1);
                return;

            }
            else
            {
                if (this.AlteracionesTipoII == true)
                {
                    this.SiguienteRealizacion = this.FechaRealizacion.AddYears(1);
                    return;
                }
                else
                {
                    this.SiguienteRealizacion = this.FechaRealizacion.AddYears(3);
                    return;
                }
            }
        }
    }
}