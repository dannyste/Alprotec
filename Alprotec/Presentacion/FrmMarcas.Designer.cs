namespace Presentacion
{
    partial class FrmMarcas
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
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.gbCriterioBusqueda = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.pAcciones = new System.Windows.Forms.Panel();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.gbCriterioBusqueda.SuspendLayout();
            this.pAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.AllowUserToAddRows = false;
            this.dgvMarcas.AllowUserToDeleteRows = false;
            this.dgvMarcas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMarcas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Location = new System.Drawing.Point(22, 69);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.ReadOnly = true;
            this.dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcas.Size = new System.Drawing.Size(420, 249);
            this.dgvMarcas.TabIndex = 29;
            this.dgvMarcas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMarcas_CellDoubleClick);
            // 
            // gbCriterioBusqueda
            // 
            this.gbCriterioBusqueda.Controls.Add(this.txtNombre);
            this.gbCriterioBusqueda.Controls.Add(this.lbNombre);
            this.gbCriterioBusqueda.Location = new System.Drawing.Point(22, 2);
            this.gbCriterioBusqueda.Name = "gbCriterioBusqueda";
            this.gbCriterioBusqueda.Size = new System.Drawing.Size(420, 65);
            this.gbCriterioBusqueda.TabIndex = 30;
            this.gbCriterioBusqueda.TabStop = false;
            this.gbCriterioBusqueda.Text = "Criterio de búsqueda";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Cambria", 10F);
            this.txtNombre.Location = new System.Drawing.Point(28, 36);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(362, 23);
            this.txtNombre.TabIndex = 21;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Cambria", 10F);
            this.lbNombre.Location = new System.Drawing.Point(26, 18);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(58, 16);
            this.lbNombre.TabIndex = 22;
            this.lbNombre.Text = "Nombre";
            // 
            // pAcciones
            // 
            this.pAcciones.Controls.Add(this.btnModificar);
            this.pAcciones.Controls.Add(this.btnSalir);
            this.pAcciones.Controls.Add(this.btnImprimir);
            this.pAcciones.Controls.Add(this.btnEliminar);
            this.pAcciones.Controls.Add(this.btnNuevo);
            this.pAcciones.Font = new System.Drawing.Font("Cambria", 10F);
            this.pAcciones.Location = new System.Drawing.Point(443, 9);
            this.pAcciones.Name = "pAcciones";
            this.pAcciones.Size = new System.Drawing.Size(70, 309);
            this.pAcciones.TabIndex = 31;
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
            // FrmMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 326);
            this.Controls.Add(this.pAcciones);
            this.Controls.Add(this.dgvMarcas);
            this.Controls.Add(this.gbCriterioBusqueda);
            this.Font = new System.Drawing.Font("Cambria", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcas";
            this.Load += new System.EventHandler(this.FrmMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.gbCriterioBusqueda.ResumeLayout(false);
            this.gbCriterioBusqueda.PerformLayout();
            this.pAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.GroupBox gbCriterioBusqueda;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Panel pAcciones;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;


    }
}