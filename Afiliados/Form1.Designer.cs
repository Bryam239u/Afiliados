namespace Afiliados
{
    partial class FRMAfiliados
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMAfiliados));
            this.mS1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dGVAfiliados = new System.Windows.Forms.DataGridView();
            this.cBNumAf = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cBMunicipio = new System.Windows.Forms.ComboBox();
            this.chBFecha = new System.Windows.Forms.CheckBox();
            this.panelFechas = new System.Windows.Forms.Panel();
            this.dTPInicio = new System.Windows.Forms.DateTimePicker();
            this.dTPFinal = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tBArchivo = new System.Windows.Forms.TextBox();
            this.tBEstado = new System.Windows.Forms.TextBox();
            this.ofdExcel = new System.Windows.Forms.OpenFileDialog();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.municipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mS1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAfiliados)).BeginInit();
            this.panelFechas.SuspendLayout();
            this.SuspendLayout();
            // 
            // mS1
            // 
            this.mS1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mS1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem,
            this.archivoToolStripMenuItem});
            this.mS1.Location = new System.Drawing.Point(0, 0);
            this.mS1.Name = "mS1";
            this.mS1.Size = new System.Drawing.Size(985, 24);
            this.mS1.TabIndex = 0;
            this.mS1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirTSM});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // salirTSM
            // 
            this.salirTSM.Name = "salirTSM";
            this.salirTSM.Size = new System.Drawing.Size(180, 22);
            this.salirTSM.Text = "Salir";
            this.salirTSM.Click += new System.EventHandler(this.salirTSM_Click);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarTSM,
            this.nuevoTSM});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cargarTSM
            // 
            this.cargarTSM.Name = "cargarTSM";
            this.cargarTSM.Size = new System.Drawing.Size(180, 22);
            this.cargarTSM.Text = "Cargar";
            this.cargarTSM.Click += new System.EventHandler(this.cargarTSM_Click);
            // 
            // nuevoTSM
            // 
            this.nuevoTSM.Name = "nuevoTSM";
            this.nuevoTSM.Size = new System.Drawing.Size(180, 22);
            this.nuevoTSM.Text = "Nuevo";
            this.nuevoTSM.Click += new System.EventHandler(this.nuevoTSM_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Archivo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Municipio:";
            // 
            // dGVAfiliados
            // 
            this.dGVAfiliados.AllowUserToAddRows = false;
            this.dGVAfiliados.AllowUserToDeleteRows = false;
            this.dGVAfiliados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dGVAfiliados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVAfiliados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.entidad,
            this.municipio,
            this.nombre,
            this.fecha,
            this.estatus});
            this.dGVAfiliados.Location = new System.Drawing.Point(12, 185);
            this.dGVAfiliados.Name = "dGVAfiliados";
            this.dGVAfiliados.ReadOnly = true;
            this.dGVAfiliados.Size = new System.Drawing.Size(944, 280);
            this.dGVAfiliados.TabIndex = 2;
            // 
            // cBNumAf
            // 
            this.cBNumAf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBNumAf.FormattingEnabled = true;
            this.cBNumAf.Location = new System.Drawing.Point(233, 492);
            this.cBNumAf.Name = "cBNumAf";
            this.cBNumAf.Size = new System.Drawing.Size(145, 32);
            this.cBNumAf.TabIndex = 3;
            this.cBNumAf.SelectedIndexChanged += new System.EventHandler(this.cBNumAf_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 494);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Numero De Afilidado:";
            // 
            // cBMunicipio
            // 
            this.cBMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBMunicipio.FormattingEnabled = true;
            this.cBMunicipio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cBMunicipio.Items.AddRange(new object[] {
            "------"});
            this.cBMunicipio.Location = new System.Drawing.Point(142, 136);
            this.cBMunicipio.Name = "cBMunicipio";
            this.cBMunicipio.Size = new System.Drawing.Size(236, 32);
            this.cBMunicipio.TabIndex = 3;
            this.cBMunicipio.SelectedIndexChanged += new System.EventHandler(this.cBMunicipio_SelectedIndexChanged);
            // 
            // chBFecha
            // 
            this.chBFecha.AutoSize = true;
            this.chBFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBFecha.Location = new System.Drawing.Point(17, 541);
            this.chBFecha.Name = "chBFecha";
            this.chBFecha.Size = new System.Drawing.Size(83, 28);
            this.chBFecha.TabIndex = 4;
            this.chBFecha.Text = "Fecha";
            this.chBFecha.UseVisualStyleBackColor = true;
            this.chBFecha.CheckedChanged += new System.EventHandler(this.chBFecha_CheckedChanged);
            // 
            // panelFechas
            // 
            this.panelFechas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelFechas.Controls.Add(this.dTPFinal);
            this.panelFechas.Controls.Add(this.dTPInicio);
            this.panelFechas.Controls.Add(this.label6);
            this.panelFechas.Controls.Add(this.label5);
            this.panelFechas.Location = new System.Drawing.Point(12, 575);
            this.panelFechas.Name = "panelFechas";
            this.panelFechas.Size = new System.Drawing.Size(326, 121);
            this.panelFechas.TabIndex = 5;
            this.panelFechas.Visible = false;
            // 
            // dTPInicio
            // 
            this.dTPInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPInicio.Location = new System.Drawing.Point(150, 27);
            this.dTPInicio.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dTPInicio.Name = "dTPInicio";
            this.dTPInicio.Size = new System.Drawing.Size(132, 29);
            this.dTPInicio.TabIndex = 0;
            this.dTPInicio.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // dTPFinal
            // 
            this.dTPFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPFinal.Location = new System.Drawing.Point(150, 74);
            this.dTPFinal.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dTPFinal.Name = "dTPFinal";
            this.dTPFinal.Size = new System.Drawing.Size(132, 29);
            this.dTPFinal.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Fecha Inicio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Fecha Final:";
            // 
            // tBArchivo
            // 
            this.tBArchivo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tBArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBArchivo.Location = new System.Drawing.Point(142, 40);
            this.tBArchivo.Name = "tBArchivo";
            this.tBArchivo.ReadOnly = true;
            this.tBArchivo.Size = new System.Drawing.Size(236, 29);
            this.tBArchivo.TabIndex = 6;
            // 
            // tBEstado
            // 
            this.tBEstado.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tBEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBEstado.Location = new System.Drawing.Point(142, 89);
            this.tBEstado.Name = "tBEstado";
            this.tBEstado.ReadOnly = true;
            this.tBEstado.Size = new System.Drawing.Size(236, 29);
            this.tBEstado.TabIndex = 6;
            // 
            // ofdExcel
            // 
            this.ofdExcel.FileName = "openFileDialog1";
            this.ofdExcel.Filter = "Archivo de Excel|*.xlsx";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // entidad
            // 
            this.entidad.DataPropertyName = "Entidad";
            this.entidad.HeaderText = "Entidad";
            this.entidad.Name = "entidad";
            this.entidad.ReadOnly = true;
            this.entidad.Width = 150;
            // 
            // municipio
            // 
            this.municipio.DataPropertyName = "Municipio";
            this.municipio.HeaderText = "Municipio";
            this.municipio.Name = "municipio";
            this.municipio.ReadOnly = true;
            this.municipio.Width = 150;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "Nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 250;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "Fecha Afiliacion";
            this.fecha.HeaderText = "Fecha Afiliacion";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 125;
            // 
            // estatus
            // 
            this.estatus.DataPropertyName = "Estatus";
            this.estatus.HeaderText = "Estatus";
            this.estatus.Name = "estatus";
            this.estatus.ReadOnly = true;
            this.estatus.Width = 125;
            // 
            // FRMAfiliados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(985, 702);
            this.Controls.Add(this.tBEstado);
            this.Controls.Add(this.tBArchivo);
            this.Controls.Add(this.panelFechas);
            this.Controls.Add(this.chBFecha);
            this.Controls.Add(this.cBMunicipio);
            this.Controls.Add(this.cBNumAf);
            this.Controls.Add(this.dGVAfiliados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mS1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mS1;
            this.Name = "FRMAfiliados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Afiliados";
            this.mS1.ResumeLayout(false);
            this.mS1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAfiliados)).EndInit();
            this.panelFechas.ResumeLayout(false);
            this.panelFechas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mS1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirTSM;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarTSM;
        private System.Windows.Forms.ToolStripMenuItem nuevoTSM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dGVAfiliados;
        private System.Windows.Forms.ComboBox cBNumAf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBMunicipio;
        private System.Windows.Forms.CheckBox chBFecha;
        private System.Windows.Forms.Panel panelFechas;
        private System.Windows.Forms.DateTimePicker dTPFinal;
        private System.Windows.Forms.DateTimePicker dTPInicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBArchivo;
        private System.Windows.Forms.TextBox tBEstado;
        private System.Windows.Forms.OpenFileDialog ofdExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn entidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn municipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatus;
    }
}

