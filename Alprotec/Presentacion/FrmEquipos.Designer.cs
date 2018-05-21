namespace Presentacion
{
    partial class FrmEquipos
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.dgvEquipos = new System.Windows.Forms.DataGridView();
            this.gbCriteriosBusqueda = new System.Windows.Forms.GroupBox();
            this.rbCodigoInterno = new System.Windows.Forms.RadioButton();
            this.rbClaseMaquina = new System.Windows.Forms.RadioButton();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.pAcciones = new System.Windows.Forms.Panel();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).BeginInit();
            this.gbCriteriosBusqueda.SuspendLayout();
            this.pAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBuscar.Font = new System.Drawing.Font("Cambria", 10F);
            this.txtBuscar.Location = new System.Drawing.Point(33, 60);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(355, 23);
            this.txtBuscar.TabIndex = 21;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lbBuscar
            // 
            this.lbBuscar.AutoSize = true;
            this.lbBuscar.Font = new System.Drawing.Font("Cambria", 10F);
            this.lbBuscar.Location = new System.Drawing.Point(31, 42);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(50, 16);
            this.lbBuscar.TabIndex = 22;
            this.lbBuscar.Text = "Buscar";
            // 
            // dgvEquipos
            // 
            this.dgvEquipos.AllowUserToAddRows = false;
            this.dgvEquipos.AllowUserToDeleteRows = false;
            this.dgvEquipos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvEquipos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipos.Location = new System.Drawing.Point(22, 92);
            this.dgvEquipos.Name = "dgvEquipos";
            this.dgvEquipos.ReadOnly = true;
            this.dgvEquipos.RowHeadersVisible = false;
            this.dgvEquipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquipos.Size = new System.Drawing.Size(420, 228);
            this.dgvEquipos.TabIndex = 30;
            this.dgvEquipos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquipos_CellDoubleClick);
            // 
            // gbCriteriosBusqueda
            // 
            this.gbCriteriosBusqueda.Controls.Add(this.rbCodigoInterno);
            this.gbCriteriosBusqueda.Controls.Add(this.rbClaseMaquina);
            this.gbCriteriosBusqueda.Controls.Add(this.rbCliente);
            this.gbCriteriosBusqueda.Controls.Add(this.txtBuscar);
            this.gbCriteriosBusqueda.Controls.Add(this.lbBuscar);
            this.gbCriteriosBusqueda.Font = new System.Drawing.Font("Cambria", 10F);
            this.gbCriteriosBusqueda.Location = new System.Drawing.Point(22, 3);
            this.gbCriteriosBusqueda.Name = "gbCriteriosBusqueda";
            this.gbCriteriosBusqueda.Size = new System.Drawing.Size(420, 88);
            this.gbCriteriosBusqueda.TabIndex = 31;
            this.gbCriteriosBusqueda.TabStop = false;
            this.gbCriteriosBusqueda.Text = "Criterios de búsqueda";
            // 
            // rbCodigoInterno
            // 
            this.rbCodigoInterno.AutoSize = true;
            this.rbCodigoInterno.Font = new System.Drawing.Font("Cambria", 10F);
            this.rbCodigoInterno.Location = new System.Drawing.Point(128, 17);
            this.rbCodigoInterno.Name = "rbCodigoInterno";
            this.rbCodigoInterno.Size = new System.Drawing.Size(115, 20);
            this.rbCodigoInterno.TabIndex = 31;
            this.rbCodigoInterno.Text = "Código interno";
            this.rbCodigoInterno.UseVisualStyleBackColor = true;
            this.rbCodigoInterno.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbClaseMaquina
            // 
            this.rbClaseMaquina.AutoSize = true;
            this.rbClaseMaquina.Font = new System.Drawing.Font("Cambria", 10F);
            this.rbClaseMaquina.Location = new System.Drawing.Point(267, 17);
            this.rbClaseMaquina.Name = "rbClaseMaquina";
            this.rbClaseMaquina.Size = new System.Drawing.Size(133, 20);
            this.rbClaseMaquina.TabIndex = 25;
            this.rbClaseMaquina.Text = "Clase de máquina";
            this.rbClaseMaquina.UseVisualStyleBackColor = true;
            this.rbClaseMaquina.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Checked = true;
            this.rbCliente.Font = new System.Drawing.Font("Cambria", 10F);
            this.rbCliente.Location = new System.Drawing.Point(33, 17);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(69, 20);
            this.rbCliente.TabIndex = 24;
            this.rbCliente.TabStop = true;
            this.rbCliente.Text = "Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
            this.rbCliente.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // pAcciones
            // 
            this.pAcciones.Controls.Add(this.btnModificar);
            this.pAcciones.Controls.Add(this.btnSalir);
            this.pAcciones.Controls.Add(this.btnImprimir);
            this.pAcciones.Controls.Add(this.btnEliminar);
            this.pAcciones.Controls.Add(this.btnNuevo);
            this.pAcciones.Font = new System.Drawing.Font("Cambria", 10F);
            this.pAcciones.Location = new System.Drawing.Point(443, 11);
            this.pAcciones.Name = "pAcciones";
            this.pAcciones.Size = new System.Drawing.Size(70, 309);
            this.pAcciones.TabIndex = 32;
            // 
            // btnModificar
            // 
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Image = global::Presentacion.Properties.Resources.modificar;
            this.btnModificar.Location = new System.Drawing.Point(10, 69);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(50, 50);
            this.btnModificar.TabIndex = 29;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Image = global::Presentacion.Properties.Resources.salir;
            this.btnSalir.Location = new System.Drawing.Point(10, 249);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(50, 50);
            this.btnSalir.TabIndex = 28;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimir.Image = global::Presentacion.Properties.Resources.imprimir;
            this.btnImprimir.Location = new System.Drawing.Point(10, 189);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(50, 50);
            this.btnImprimir.TabIndex = 27;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Image = global::Presentacion.Properties.Resources.eliminar;
            this.btnEliminar.Location = new System.Drawing.Point(10, 129);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(50, 50);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevo.Image = global::Presentacion.Properties.Resources.nuevo;
            this.btnNuevo.Location = new System.Drawing.Point(10, 9);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(50, 50);
            this.btnNuevo.TabIndex = 25;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // FrmEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 326);
            this.Controls.Add(this.pAcciones);
            this.Controls.Add(this.dgvEquipos);
            this.Controls.Add(this.gbCriteriosBusqueda);
            this.Font = new System.Drawing.Font("Cambria", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmEquipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipos";
            this.Load += new System.EventHandler(this.FrmEquipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).EndInit();
            this.gbCriteriosBusqueda.ResumeLayout(false);
            this.gbCriteriosBusqueda.PerformLayout();
            this.pAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lbBuscar;
        private System.Windows.Forms.DataGridView dgvEquipos;
        private System.Windows.Forms.GroupBox gbCriteriosBusqueda;
        private System.Windows.Forms.RadioButton rbCodigoInterno;
        private System.Windows.Forms.RadioButton rbClaseMaquina;
        private System.Windows.Forms.RadioButton rbCliente;
        private System.Windows.Forms.Panel pAcciones;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;


    }
}