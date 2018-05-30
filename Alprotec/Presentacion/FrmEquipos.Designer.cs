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
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lbCliente = new System.Windows.Forms.Label();
            this.dgvEquipos = new System.Windows.Forms.DataGridView();
            this.gbCriteriosBusqueda = new System.Windows.Forms.GroupBox();
            this.nudPotencia = new System.Windows.Forms.NumericUpDown();
            this.cbUd = new System.Windows.Forms.ComboBox();
            this.lbUnidadMedida = new System.Windows.Forms.Label();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.lbMarca = new System.Windows.Forms.Label();
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lbPotencia = new System.Windows.Forms.Label();
            this.pAcciones = new System.Windows.Forms.Panel();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).BeginInit();
            this.gbCriteriosBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPotencia)).BeginInit();
            this.pAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCliente.Font = new System.Drawing.Font("Cambria", 10F);
            this.txtCliente.Location = new System.Drawing.Point(32, 39);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(355, 23);
            this.txtCliente.TabIndex = 21;
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Font = new System.Drawing.Font("Cambria", 10F);
            this.lbCliente.Location = new System.Drawing.Point(30, 21);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(51, 16);
            this.lbCliente.TabIndex = 22;
            this.lbCliente.Text = "Cliente";
            // 
            // dgvEquipos
            // 
            this.dgvEquipos.AllowUserToAddRows = false;
            this.dgvEquipos.AllowUserToDeleteRows = false;
            this.dgvEquipos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvEquipos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipos.Location = new System.Drawing.Point(22, 154);
            this.dgvEquipos.Name = "dgvEquipos";
            this.dgvEquipos.ReadOnly = true;
            this.dgvEquipos.RowHeadersVisible = false;
            this.dgvEquipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquipos.Size = new System.Drawing.Size(420, 240);
            this.dgvEquipos.TabIndex = 30;
            this.dgvEquipos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquipos_CellDoubleClick);
            // 
            // gbCriteriosBusqueda
            // 
            this.gbCriteriosBusqueda.Controls.Add(this.nudPotencia);
            this.gbCriteriosBusqueda.Controls.Add(this.cbUd);
            this.gbCriteriosBusqueda.Controls.Add(this.lbUnidadMedida);
            this.gbCriteriosBusqueda.Controls.Add(this.cbMarca);
            this.gbCriteriosBusqueda.Controls.Add(this.lbMarca);
            this.gbCriteriosBusqueda.Controls.Add(this.btnRestablecer);
            this.gbCriteriosBusqueda.Controls.Add(this.btnConsultar);
            this.gbCriteriosBusqueda.Controls.Add(this.lbPotencia);
            this.gbCriteriosBusqueda.Controls.Add(this.txtCliente);
            this.gbCriteriosBusqueda.Controls.Add(this.lbCliente);
            this.gbCriteriosBusqueda.Font = new System.Drawing.Font("Cambria", 10F);
            this.gbCriteriosBusqueda.Location = new System.Drawing.Point(22, 3);
            this.gbCriteriosBusqueda.Name = "gbCriteriosBusqueda";
            this.gbCriteriosBusqueda.Size = new System.Drawing.Size(420, 145);
            this.gbCriteriosBusqueda.TabIndex = 31;
            this.gbCriteriosBusqueda.TabStop = false;
            this.gbCriteriosBusqueda.Text = "Criterios de búsqueda";
            // 
            // nudPotencia
            // 
            this.nudPotencia.DecimalPlaces = 2;
            this.nudPotencia.Location = new System.Drawing.Point(32, 87);
            this.nudPotencia.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nudPotencia.Name = "nudPotencia";
            this.nudPotencia.Size = new System.Drawing.Size(89, 23);
            this.nudPotencia.TabIndex = 50;
            this.nudPotencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbUd
            // 
            this.cbUd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUd.Font = new System.Drawing.Font("Cambria", 10F);
            this.cbUd.FormattingEnabled = true;
            this.cbUd.Items.AddRange(new object[] {
            "Seleccione",
            "HP",
            "kW"});
            this.cbUd.Location = new System.Drawing.Point(127, 87);
            this.cbUd.Name = "cbUd";
            this.cbUd.Size = new System.Drawing.Size(84, 23);
            this.cbUd.TabIndex = 48;
            // 
            // lbUnidadMedida
            // 
            this.lbUnidadMedida.AutoSize = true;
            this.lbUnidadMedida.Font = new System.Drawing.Font("Cambria", 10F);
            this.lbUnidadMedida.Location = new System.Drawing.Point(125, 69);
            this.lbUnidadMedida.Name = "lbUnidadMedida";
            this.lbUnidadMedida.Size = new System.Drawing.Size(27, 16);
            this.lbUnidadMedida.TabIndex = 49;
            this.lbUnidadMedida.Text = "ud.";
            // 
            // cbMarca
            // 
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.Font = new System.Drawing.Font("Cambria", 10F);
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(237, 87);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(150, 23);
            this.cbMarca.TabIndex = 46;
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Font = new System.Drawing.Font("Cambria", 10F);
            this.lbMarca.Location = new System.Drawing.Point(235, 69);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(45, 16);
            this.lbMarca.TabIndex = 47;
            this.lbMarca.Text = "Marca";
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestablecer.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnRestablecer.Location = new System.Drawing.Point(201, 116);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(90, 23);
            this.btnRestablecer.TabIndex = 45;
            this.btnRestablecer.Text = "Restablecer";
            this.btnRestablecer.UseVisualStyleBackColor = true;
            this.btnRestablecer.Click += new System.EventHandler(this.btnRestablecer_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsultar.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnConsultar.Location = new System.Drawing.Point(297, 116);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(90, 23);
            this.btnConsultar.TabIndex = 44;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lbPotencia
            // 
            this.lbPotencia.AutoSize = true;
            this.lbPotencia.Font = new System.Drawing.Font("Cambria", 10F);
            this.lbPotencia.Location = new System.Drawing.Point(30, 68);
            this.lbPotencia.Name = "lbPotencia";
            this.lbPotencia.Size = new System.Drawing.Size(60, 16);
            this.lbPotencia.TabIndex = 33;
            this.lbPotencia.Text = "Potencia";
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
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Image = global::Presentacion.Properties.Resources.modificar;
            this.btnModificar.Location = new System.Drawing.Point(10, 69);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(50, 50);
            this.btnModificar.TabIndex = 29;
            this.btnModificar.UseVisualStyleBackColor = false;
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
            this.ClientSize = new System.Drawing.Size(533, 403);
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
            ((System.ComponentModel.ISupportInitialize)(this.nudPotencia)).EndInit();
            this.pAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.DataGridView dgvEquipos;
        private System.Windows.Forms.GroupBox gbCriteriosBusqueda;
        private System.Windows.Forms.Panel pAcciones;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lbPotencia;
        private System.Windows.Forms.Button btnRestablecer;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cbUd;
        private System.Windows.Forms.Label lbUnidadMedida;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.NumericUpDown nudPotencia;


    }
}