namespace Presentacion
{
    partial class FrmRecepcionEquipos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lbCliente = new System.Windows.Forms.Label();
            this.dgvRecepcionEquipos = new System.Windows.Forms.DataGridView();
            this.gbCriteriosBusqueda = new System.Windows.Forms.GroupBox();
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.lbFechaFinal = new System.Windows.Forms.Label();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.lbFechaInicial = new System.Windows.Forms.Label();
            this.pAcciones = new System.Windows.Forms.Panel();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecepcionEquipos)).BeginInit();
            this.gbCriteriosBusqueda.SuspendLayout();
            this.pAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Cambria", 10F);
            this.txtCliente.Location = new System.Drawing.Point(32, 86);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(355, 23);
            this.txtCliente.TabIndex = 21;
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Font = new System.Drawing.Font("Cambria", 10F);
            this.lbCliente.Location = new System.Drawing.Point(30, 68);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(51, 16);
            this.lbCliente.TabIndex = 22;
            this.lbCliente.Text = "Cliente";
            // 
            // dgvRecepcionEquipos
            // 
            this.dgvRecepcionEquipos.AllowUserToAddRows = false;
            this.dgvRecepcionEquipos.AllowUserToDeleteRows = false;
            this.dgvRecepcionEquipos.AllowUserToResizeColumns = false;
            this.dgvRecepcionEquipos.AllowUserToResizeRows = false;
            this.dgvRecepcionEquipos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvRecepcionEquipos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRecepcionEquipos.ColumnHeadersHeight = 30;
            this.dgvRecepcionEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRecepcionEquipos.Location = new System.Drawing.Point(22, 154);
            this.dgvRecepcionEquipos.Name = "dgvRecepcionEquipos";
            this.dgvRecepcionEquipos.ReadOnly = true;
            this.dgvRecepcionEquipos.RowHeadersVisible = false;
            this.dgvRecepcionEquipos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvRecepcionEquipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecepcionEquipos.Size = new System.Drawing.Size(420, 240);
            this.dgvRecepcionEquipos.TabIndex = 30;
            this.dgvRecepcionEquipos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecepcionEquipos_CellDoubleClick);
            // 
            // gbCriteriosBusqueda
            // 
            this.gbCriteriosBusqueda.Controls.Add(this.btnRestablecer);
            this.gbCriteriosBusqueda.Controls.Add(this.btnConsultar);
            this.gbCriteriosBusqueda.Controls.Add(this.dtpFechaFinal);
            this.gbCriteriosBusqueda.Controls.Add(this.lbFechaFinal);
            this.gbCriteriosBusqueda.Controls.Add(this.dtpFechaInicial);
            this.gbCriteriosBusqueda.Controls.Add(this.lbFechaInicial);
            this.gbCriteriosBusqueda.Controls.Add(this.txtCliente);
            this.gbCriteriosBusqueda.Controls.Add(this.lbCliente);
            this.gbCriteriosBusqueda.Location = new System.Drawing.Point(22, 3);
            this.gbCriteriosBusqueda.Name = "gbCriteriosBusqueda";
            this.gbCriteriosBusqueda.Size = new System.Drawing.Size(420, 145);
            this.gbCriteriosBusqueda.TabIndex = 31;
            this.gbCriteriosBusqueda.TabStop = false;
            this.gbCriteriosBusqueda.Text = "Criterios de búsqueda";
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestablecer.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnRestablecer.Location = new System.Drawing.Point(201, 115);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(90, 23);
            this.btnRestablecer.TabIndex = 58;
            this.btnRestablecer.Text = "Restablecer";
            this.btnRestablecer.UseVisualStyleBackColor = true;
            this.btnRestablecer.Click += new System.EventHandler(this.btnRestablecer_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsultar.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnConsultar.Location = new System.Drawing.Point(297, 115);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(90, 23);
            this.btnConsultar.TabIndex = 57;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Font = new System.Drawing.Font("Cambria", 10F);
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFinal.Location = new System.Drawing.Point(212, 39);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(175, 23);
            this.dtpFechaFinal.TabIndex = 33;
            // 
            // lbFechaFinal
            // 
            this.lbFechaFinal.AutoSize = true;
            this.lbFechaFinal.Font = new System.Drawing.Font("Cambria", 10F);
            this.lbFechaFinal.Location = new System.Drawing.Point(210, 21);
            this.lbFechaFinal.Name = "lbFechaFinal";
            this.lbFechaFinal.Size = new System.Drawing.Size(73, 16);
            this.lbFechaFinal.TabIndex = 32;
            this.lbFechaFinal.Text = "Fecha final";
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.Font = new System.Drawing.Font("Cambria", 10F);
            this.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicial.Location = new System.Drawing.Point(32, 39);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(175, 23);
            this.dtpFechaInicial.TabIndex = 31;
            // 
            // lbFechaInicial
            // 
            this.lbFechaInicial.AutoSize = true;
            this.lbFechaInicial.Font = new System.Drawing.Font("Cambria", 10F);
            this.lbFechaInicial.Location = new System.Drawing.Point(30, 21);
            this.lbFechaInicial.Name = "lbFechaInicial";
            this.lbFechaInicial.Size = new System.Drawing.Size(83, 16);
            this.lbFechaInicial.TabIndex = 30;
            this.lbFechaInicial.Text = "Fecha inicial";
            // 
            // pAcciones
            // 
            this.pAcciones.Controls.Add(this.btnModificar);
            this.pAcciones.Controls.Add(this.btnSalir);
            this.pAcciones.Controls.Add(this.btnImprimir);
            this.pAcciones.Controls.Add(this.btnEliminar);
            this.pAcciones.Controls.Add(this.btnNuevo);
            this.pAcciones.Font = new System.Drawing.Font("Cambria", 10F);
            this.pAcciones.Location = new System.Drawing.Point(453, 49);
            this.pAcciones.Name = "pAcciones";
            this.pAcciones.Size = new System.Drawing.Size(70, 309);
            this.pAcciones.TabIndex = 32;
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::Presentacion.Properties.Resources.modificar;
            this.btnModificar.Location = new System.Drawing.Point(10, 69);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(50, 50);
            this.btnModificar.TabIndex = 29;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Presentacion.Properties.Resources.salir;
            this.btnSalir.Location = new System.Drawing.Point(10, 249);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(50, 50);
            this.btnSalir.TabIndex = 28;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = global::Presentacion.Properties.Resources.imprimir;
            this.btnImprimir.Location = new System.Drawing.Point(10, 189);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(50, 50);
            this.btnImprimir.TabIndex = 27;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::Presentacion.Properties.Resources.eliminar;
            this.btnEliminar.Location = new System.Drawing.Point(10, 129);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(50, 50);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::Presentacion.Properties.Resources.nuevo;
            this.btnNuevo.Location = new System.Drawing.Point(10, 9);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(50, 50);
            this.btnNuevo.TabIndex = 25;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // FrmRecepcionEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 403);
            this.Controls.Add(this.pAcciones);
            this.Controls.Add(this.dgvRecepcionEquipos);
            this.Controls.Add(this.gbCriteriosBusqueda);
            this.Font = new System.Drawing.Font("Cambria", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmRecepcionEquipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recepción de Equipos";
            this.Load += new System.EventHandler(this.FrmRecepcionEquipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecepcionEquipos)).EndInit();
            this.gbCriteriosBusqueda.ResumeLayout(false);
            this.gbCriteriosBusqueda.PerformLayout();
            this.pAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.DataGridView dgvRecepcionEquipos;
        private System.Windows.Forms.GroupBox gbCriteriosBusqueda;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.Label lbFechaFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.Label lbFechaInicial;
        private System.Windows.Forms.Panel pAcciones;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnRestablecer;
        private System.Windows.Forms.Button btnConsultar;

    }
}