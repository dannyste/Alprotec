namespace Presentacion
{
    partial class FrmTrabajadores
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
            this.dgvTrabajadores = new System.Windows.Forms.DataGridView();
            this.gbCriteriosBusqueda = new System.Windows.Forms.GroupBox();
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtCedulaIdentidad = new System.Windows.Forms.TextBox();
            this.lbCedulaIdentidad = new System.Windows.Forms.Label();
            this.txtTrabajador = new System.Windows.Forms.TextBox();
            this.lbTrabajador = new System.Windows.Forms.Label();
            this.pAcciones = new System.Windows.Forms.Panel();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.lbCargo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajadores)).BeginInit();
            this.gbCriteriosBusqueda.SuspendLayout();
            this.pAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTrabajadores
            // 
            this.dgvTrabajadores.AllowUserToAddRows = false;
            this.dgvTrabajadores.AllowUserToDeleteRows = false;
            this.dgvTrabajadores.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvTrabajadores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTrabajadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrabajadores.Location = new System.Drawing.Point(22, 154);
            this.dgvTrabajadores.Name = "dgvTrabajadores";
            this.dgvTrabajadores.ReadOnly = true;
            this.dgvTrabajadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrabajadores.Size = new System.Drawing.Size(420, 240);
            this.dgvTrabajadores.TabIndex = 29;
            this.dgvTrabajadores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrabajadores_CellDoubleClick);
            // 
            // gbCriteriosBusqueda
            // 
            this.gbCriteriosBusqueda.Controls.Add(this.txtCargo);
            this.gbCriteriosBusqueda.Controls.Add(this.lbCargo);
            this.gbCriteriosBusqueda.Controls.Add(this.btnRestablecer);
            this.gbCriteriosBusqueda.Controls.Add(this.btnConsultar);
            this.gbCriteriosBusqueda.Controls.Add(this.txtCedulaIdentidad);
            this.gbCriteriosBusqueda.Controls.Add(this.lbCedulaIdentidad);
            this.gbCriteriosBusqueda.Controls.Add(this.txtTrabajador);
            this.gbCriteriosBusqueda.Controls.Add(this.lbTrabajador);
            this.gbCriteriosBusqueda.Location = new System.Drawing.Point(22, 3);
            this.gbCriteriosBusqueda.Name = "gbCriteriosBusqueda";
            this.gbCriteriosBusqueda.Size = new System.Drawing.Size(420, 145);
            this.gbCriteriosBusqueda.TabIndex = 29;
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
            this.btnRestablecer.TabIndex = 56;
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
            this.btnConsultar.TabIndex = 55;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtCedulaIdentidad
            // 
            this.txtCedulaIdentidad.Font = new System.Drawing.Font("Cambria", 10F);
            this.txtCedulaIdentidad.Location = new System.Drawing.Point(32, 39);
            this.txtCedulaIdentidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCedulaIdentidad.Name = "txtCedulaIdentidad";
            this.txtCedulaIdentidad.Size = new System.Drawing.Size(174, 23);
            this.txtCedulaIdentidad.TabIndex = 54;
            // 
            // lbCedulaIdentidad
            // 
            this.lbCedulaIdentidad.AutoSize = true;
            this.lbCedulaIdentidad.Font = new System.Drawing.Font("Cambria", 10F);
            this.lbCedulaIdentidad.Location = new System.Drawing.Point(30, 21);
            this.lbCedulaIdentidad.Name = "lbCedulaIdentidad";
            this.lbCedulaIdentidad.Size = new System.Drawing.Size(130, 16);
            this.lbCedulaIdentidad.TabIndex = 51;
            this.lbCedulaIdentidad.Text = "Cédula de identidad";
            // 
            // txtTrabajador
            // 
            this.txtTrabajador.Font = new System.Drawing.Font("Cambria", 10F);
            this.txtTrabajador.Location = new System.Drawing.Point(32, 86);
            this.txtTrabajador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTrabajador.Name = "txtTrabajador";
            this.txtTrabajador.Size = new System.Drawing.Size(355, 23);
            this.txtTrabajador.TabIndex = 21;
            // 
            // lbTrabajador
            // 
            this.lbTrabajador.AutoSize = true;
            this.lbTrabajador.Font = new System.Drawing.Font("Cambria", 10F);
            this.lbTrabajador.Location = new System.Drawing.Point(30, 68);
            this.lbTrabajador.Name = "lbTrabajador";
            this.lbTrabajador.Size = new System.Drawing.Size(76, 16);
            this.lbTrabajador.TabIndex = 22;
            this.lbTrabajador.Text = "Trabajador";
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
            this.pAcciones.TabIndex = 30;
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
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = global::Presentacion.Properties.Resources.imprimir;
            this.btnImprimir.Location = new System.Drawing.Point(10, 189);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(50, 50);
            this.btnImprimir.TabIndex = 27;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::Presentacion.Properties.Resources.eliminar;
            this.btnEliminar.Location = new System.Drawing.Point(10, 129);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(50, 50);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::Presentacion.Properties.Resources.nuevo;
            this.btnNuevo.Location = new System.Drawing.Point(10, 9);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(50, 50);
            this.btnNuevo.TabIndex = 25;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // txtCargo
            // 
            this.txtCargo.Font = new System.Drawing.Font("Cambria", 10F);
            this.txtCargo.Location = new System.Drawing.Point(213, 39);
            this.txtCargo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(174, 23);
            this.txtCargo.TabIndex = 58;
            // 
            // lbCargo
            // 
            this.lbCargo.AutoSize = true;
            this.lbCargo.Font = new System.Drawing.Font("Cambria", 10F);
            this.lbCargo.Location = new System.Drawing.Point(211, 21);
            this.lbCargo.Name = "lbCargo";
            this.lbCargo.Size = new System.Drawing.Size(43, 16);
            this.lbCargo.TabIndex = 57;
            this.lbCargo.Text = "Cargo";
            // 
            // FrmTrabajadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 403);
            this.Controls.Add(this.pAcciones);
            this.Controls.Add(this.gbCriteriosBusqueda);
            this.Controls.Add(this.dgvTrabajadores);
            this.Font = new System.Drawing.Font("Cambria", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmTrabajadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trabajadores";
            this.Load += new System.EventHandler(this.FrmTrabajadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajadores)).EndInit();
            this.gbCriteriosBusqueda.ResumeLayout(false);
            this.gbCriteriosBusqueda.PerformLayout();
            this.pAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTrabajadores;
        private System.Windows.Forms.GroupBox gbCriteriosBusqueda;
        private System.Windows.Forms.Button btnRestablecer;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtCedulaIdentidad;
        private System.Windows.Forms.Label lbCedulaIdentidad;
        private System.Windows.Forms.TextBox txtTrabajador;
        private System.Windows.Forms.Label lbTrabajador;
        private System.Windows.Forms.Panel pAcciones;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label lbCargo;
    }
}