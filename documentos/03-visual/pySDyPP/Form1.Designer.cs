namespace pySDyPP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridViewPacientes = new DataGridView();
            pacienteIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            edadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            generoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaNacimientoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoDiabetesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            alteracionesTipoIIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pacienteBindingSource = new BindingSource(components);
            dataGridViewPruebas = new DataGridView();
            pruebaIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            realizadaDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            fechaRealizacionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            siguienteRealizacionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            resultadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            observacionesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pacienteIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            pacienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pruebasRealizadasBindingSource = new BindingSource(components);
            buttonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPacientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pacienteBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPruebas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pruebasRealizadasBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPacientes
            // 
            dataGridViewPacientes.AutoGenerateColumns = false;
            dataGridViewPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPacientes.Columns.AddRange(new DataGridViewColumn[] { pacienteIdDataGridViewTextBoxColumn, telefonoDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, apellidosDataGridViewTextBoxColumn, edadDataGridViewTextBoxColumn, generoDataGridViewTextBoxColumn, fechaNacimientoDataGridViewTextBoxColumn, tipoDiabetesDataGridViewTextBoxColumn, alteracionesTipoIIDataGridViewTextBoxColumn });
            dataGridViewPacientes.DataSource = pacienteBindingSource;
            dataGridViewPacientes.Location = new Point(12, 12);
            dataGridViewPacientes.Name = "dataGridViewPacientes";
            dataGridViewPacientes.RowHeadersWidth = 82;
            dataGridViewPacientes.Size = new Size(1683, 337);
            dataGridViewPacientes.TabIndex = 0;
            dataGridViewPacientes.SelectionChanged += dataGridViewPacientes_SelectionChanged;
            // 
            // pacienteIdDataGridViewTextBoxColumn
            // 
            pacienteIdDataGridViewTextBoxColumn.DataPropertyName = "PacienteId";
            pacienteIdDataGridViewTextBoxColumn.HeaderText = "PacienteId";
            pacienteIdDataGridViewTextBoxColumn.MinimumWidth = 10;
            pacienteIdDataGridViewTextBoxColumn.Name = "pacienteIdDataGridViewTextBoxColumn";
            pacienteIdDataGridViewTextBoxColumn.ReadOnly = true;
            pacienteIdDataGridViewTextBoxColumn.Width = 200;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            telefonoDataGridViewTextBoxColumn.MinimumWidth = 10;
            telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            telefonoDataGridViewTextBoxColumn.Width = 200;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.MinimumWidth = 10;
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.Width = 200;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            apellidosDataGridViewTextBoxColumn.MinimumWidth = 10;
            apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            apellidosDataGridViewTextBoxColumn.Width = 200;
            // 
            // edadDataGridViewTextBoxColumn
            // 
            edadDataGridViewTextBoxColumn.DataPropertyName = "Edad";
            edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            edadDataGridViewTextBoxColumn.MinimumWidth = 10;
            edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            edadDataGridViewTextBoxColumn.Width = 200;
            // 
            // generoDataGridViewTextBoxColumn
            // 
            generoDataGridViewTextBoxColumn.DataPropertyName = "Genero";
            generoDataGridViewTextBoxColumn.HeaderText = "Genero";
            generoDataGridViewTextBoxColumn.MinimumWidth = 10;
            generoDataGridViewTextBoxColumn.Name = "generoDataGridViewTextBoxColumn";
            generoDataGridViewTextBoxColumn.Width = 200;
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaNacimiento";
            fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "FechaNacimiento";
            fechaNacimientoDataGridViewTextBoxColumn.MinimumWidth = 10;
            fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            fechaNacimientoDataGridViewTextBoxColumn.Width = 200;
            // 
            // tipoDiabetesDataGridViewTextBoxColumn
            // 
            tipoDiabetesDataGridViewTextBoxColumn.DataPropertyName = "TipoDiabetes";
            tipoDiabetesDataGridViewTextBoxColumn.HeaderText = "TipoDiabetes";
            tipoDiabetesDataGridViewTextBoxColumn.MinimumWidth = 10;
            tipoDiabetesDataGridViewTextBoxColumn.Name = "tipoDiabetesDataGridViewTextBoxColumn";
            tipoDiabetesDataGridViewTextBoxColumn.Width = 200;
            // 
            // alteracionesTipoIIDataGridViewTextBoxColumn
            // 
            alteracionesTipoIIDataGridViewTextBoxColumn.DataPropertyName = "AlteracionesTipoII";
            alteracionesTipoIIDataGridViewTextBoxColumn.HeaderText = "AlteracionesTipoII";
            alteracionesTipoIIDataGridViewTextBoxColumn.MinimumWidth = 10;
            alteracionesTipoIIDataGridViewTextBoxColumn.Name = "alteracionesTipoIIDataGridViewTextBoxColumn";
            alteracionesTipoIIDataGridViewTextBoxColumn.Width = 200;
            // 
            // pacienteBindingSource
            // 
            pacienteBindingSource.DataSource = typeof(Models.Paciente);
            // 
            // dataGridViewPruebas
            // 
            dataGridViewPruebas.AutoGenerateColumns = false;
            dataGridViewPruebas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPruebas.Columns.AddRange(new DataGridViewColumn[] { pruebaIdDataGridViewTextBoxColumn, tipoDataGridViewTextBoxColumn, realizadaDataGridViewCheckBoxColumn, fechaRealizacionDataGridViewTextBoxColumn, siguienteRealizacionDataGridViewTextBoxColumn, resultadoDataGridViewTextBoxColumn, observacionesDataGridViewTextBoxColumn, estadoDataGridViewTextBoxColumn, pacienteIdDataGridViewTextBoxColumn1, pacienteDataGridViewTextBoxColumn });
            dataGridViewPruebas.DataSource = pruebasRealizadasBindingSource;
            dataGridViewPruebas.Location = new Point(12, 374);
            dataGridViewPruebas.Name = "dataGridViewPruebas";
            dataGridViewPruebas.RowHeadersWidth = 82;
            dataGridViewPruebas.Size = new Size(1683, 323);
            dataGridViewPruebas.TabIndex = 1;
            // 
            // pruebaIdDataGridViewTextBoxColumn
            // 
            pruebaIdDataGridViewTextBoxColumn.DataPropertyName = "PruebaId";
            pruebaIdDataGridViewTextBoxColumn.HeaderText = "PruebaId";
            pruebaIdDataGridViewTextBoxColumn.MinimumWidth = 10;
            pruebaIdDataGridViewTextBoxColumn.Name = "pruebaIdDataGridViewTextBoxColumn";
            pruebaIdDataGridViewTextBoxColumn.ReadOnly = true;
            pruebaIdDataGridViewTextBoxColumn.Width = 200;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            tipoDataGridViewTextBoxColumn.MinimumWidth = 10;
            tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            tipoDataGridViewTextBoxColumn.Width = 200;
            // 
            // realizadaDataGridViewCheckBoxColumn
            // 
            realizadaDataGridViewCheckBoxColumn.DataPropertyName = "Realizada";
            realizadaDataGridViewCheckBoxColumn.HeaderText = "Realizada";
            realizadaDataGridViewCheckBoxColumn.MinimumWidth = 10;
            realizadaDataGridViewCheckBoxColumn.Name = "realizadaDataGridViewCheckBoxColumn";
            realizadaDataGridViewCheckBoxColumn.Width = 200;
            // 
            // fechaRealizacionDataGridViewTextBoxColumn
            // 
            fechaRealizacionDataGridViewTextBoxColumn.DataPropertyName = "FechaRealizacion";
            fechaRealizacionDataGridViewTextBoxColumn.HeaderText = "FechaRealizacion";
            fechaRealizacionDataGridViewTextBoxColumn.MinimumWidth = 10;
            fechaRealizacionDataGridViewTextBoxColumn.Name = "fechaRealizacionDataGridViewTextBoxColumn";
            fechaRealizacionDataGridViewTextBoxColumn.Width = 200;
            // 
            // siguienteRealizacionDataGridViewTextBoxColumn
            // 
            siguienteRealizacionDataGridViewTextBoxColumn.DataPropertyName = "SiguienteRealizacion";
            siguienteRealizacionDataGridViewTextBoxColumn.HeaderText = "SiguienteRealizacion";
            siguienteRealizacionDataGridViewTextBoxColumn.MinimumWidth = 10;
            siguienteRealizacionDataGridViewTextBoxColumn.Name = "siguienteRealizacionDataGridViewTextBoxColumn";
            siguienteRealizacionDataGridViewTextBoxColumn.Width = 200;
            // 
            // resultadoDataGridViewTextBoxColumn
            // 
            resultadoDataGridViewTextBoxColumn.DataPropertyName = "Resultado";
            resultadoDataGridViewTextBoxColumn.HeaderText = "Resultado";
            resultadoDataGridViewTextBoxColumn.MinimumWidth = 10;
            resultadoDataGridViewTextBoxColumn.Name = "resultadoDataGridViewTextBoxColumn";
            resultadoDataGridViewTextBoxColumn.Width = 200;
            // 
            // observacionesDataGridViewTextBoxColumn
            // 
            observacionesDataGridViewTextBoxColumn.DataPropertyName = "Observaciones";
            observacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones";
            observacionesDataGridViewTextBoxColumn.MinimumWidth = 10;
            observacionesDataGridViewTextBoxColumn.Name = "observacionesDataGridViewTextBoxColumn";
            observacionesDataGridViewTextBoxColumn.Width = 200;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            estadoDataGridViewTextBoxColumn.MinimumWidth = 10;
            estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            estadoDataGridViewTextBoxColumn.Width = 200;
            // 
            // pacienteIdDataGridViewTextBoxColumn1
            // 
            pacienteIdDataGridViewTextBoxColumn1.DataPropertyName = "PacienteId";
            pacienteIdDataGridViewTextBoxColumn1.HeaderText = "PacienteId";
            pacienteIdDataGridViewTextBoxColumn1.MinimumWidth = 10;
            pacienteIdDataGridViewTextBoxColumn1.Name = "pacienteIdDataGridViewTextBoxColumn1";
            pacienteIdDataGridViewTextBoxColumn1.Width = 200;
            // 
            // pacienteDataGridViewTextBoxColumn
            // 
            pacienteDataGridViewTextBoxColumn.DataPropertyName = "Paciente";
            pacienteDataGridViewTextBoxColumn.HeaderText = "Paciente";
            pacienteDataGridViewTextBoxColumn.MinimumWidth = 10;
            pacienteDataGridViewTextBoxColumn.Name = "pacienteDataGridViewTextBoxColumn";
            pacienteDataGridViewTextBoxColumn.Width = 200;
            // 
            // pruebasRealizadasBindingSource
            // 
            pruebasRealizadasBindingSource.DataMember = "PruebasRealizadas";
            pruebasRealizadasBindingSource.DataSource = pacienteBindingSource;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(1532, 930);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(163, 59);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += btnSave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1750, 1001);
            Controls.Add(buttonSave);
            Controls.Add(dataGridViewPruebas);
            Controls.Add(dataGridViewPacientes);
            Name = "Form1";
            Text = "Pacientes y pruebas";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPacientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pacienteBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPruebas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pruebasRealizadasBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewPacientes;
        private DataGridView dataGridViewPruebas;
        private Button buttonSave;
        private BindingSource pacienteBindingSource;
        private BindingSource pruebasRealizadasBindingSource;
        private DataGridViewTextBoxColumn pacienteIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDiabetesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn alteracionesTipoIIDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pruebaIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn realizadaDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn fechaRealizacionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn siguienteRealizacionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn resultadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn observacionesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pacienteIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn pacienteDataGridViewTextBoxColumn;
    }
}
