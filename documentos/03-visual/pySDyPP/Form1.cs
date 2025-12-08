using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using pySDyPP.Data;
using pySDyPP.Models;

namespace pySDyPP
{
    public partial class Form1 : Form
    {
        private AppDbContext? dbContext;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dbContext = new AppDbContext();

            // Uncomment the line below to start fresh with a new database.
            this.dbContext.Database.EnsureDeleted();
            this.dbContext.Database.EnsureCreated();

            this.dbContext.pacientes.Load();

            this.pacienteBindingSource.DataSource = dbContext.pacientes.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        private void btnSave(object sender, EventArgs e)
        {
            this.dbContext!.SaveChanges();

            this.dataGridViewPacientes.Refresh();
            this.dataGridViewPruebas.Refresh();
        
        }

        private void dataGridViewPacientes_SelectionChanged(object sender, EventArgs e)
        {
            
            if (this.dbContext != null)
            {
                var paciente = (Paciente)this.dataGridViewPacientes.CurrentRow.DataBoundItem;

                if (paciente != null)
                {
                    this.dbContext.Entry(paciente).Collection(e => e.PruebasRealizadas).Load();
                }
            }
        }
    }
}
