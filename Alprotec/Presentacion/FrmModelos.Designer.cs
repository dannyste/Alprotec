namespace Presentacion
{
    partial class FrmModelos
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
            this.dgvModelos = new System.Windows.Forms.DataGridView();
            this.gbCriteriosBusqueda = new System.Windows.Forms.GroupBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.lbMarca = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.pAcciones = new System.Windows.Forms.Panel();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelos)).BeginInit();
            this.gbCriteriosBusqueda.SuspendLayout();
            this.pAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvModelos
            // 
            this.dgvModelos.AllowUserToAddRows = false;
            this.dgvModelos.AllowUserToDeleteRows = false;
            this.dgvModelos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvModelos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvModelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModelos.Location = new System.Drawing.Point(22, 107);
            this.dgvModelos.Name = "dgvModelos";
            this.dgvModelos.ReadOnly = true;
            this.dgvModelos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModelos.Size = new System.Drawing.Size(420, 211);
            this.dgvModelos.TabIndex = 35;
            this.dgvModelos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModelos_CellDoubleClick);
            // 
            // gbCriteriosBusqueda
            // 
            this.gbCriteriosBusqueda.Controls.Add(this.cbMarca);
            this.gbCriteriosBusqueda.Controls.Add(this.lbMarca);
            this.gbCriteriosBusqueda.Controls.Add(this.txtNombre);
            this.gbCriteriosBusqueda.Controls.Add(this.lbNombre);
            this.gbCriteriosBusqueda.Location = new System.Drawing.Point(22, 2);
            this.gbCriteriosBusqueda.Name = "gbCriteriosBusqueda";
            this.gbCriteriosBusqueda.Size = new System.Drawing.Size(420, 103);
            this.gbCriteriosBusqueda.TabIndex = 36;
            this.gbCriteriosBusqueda.TabStop = false;
            this.gbCriteriosBusqueda.Text = "Criterios de búsqueda";
            // 
            // cbMarca
            // 
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.Font = new System.Drawing.Font("Cambria", 10F);
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(28, 35);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(179, 23);
            this.cbMarca.TabIndex = 31;
            this.cbMarca.SelectionChangeCommitted += new System.EventHandler(this.cbMarca_SelectionChangeCommitted);
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Font = new System.Drawing.Font("Cambria", 10F);
            this.lbMarca.Location = new System.Drawing.Point(26, 17);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(45, 16);
            this.lbMarca.TabIndex = 32;
            this.lbMarca.Text = "Marca";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Cambria", 10F);
            this.txtNombre.Location = new System.Drawing.Point(28, 78);
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
            this.lbNombre.Location = new System.Drawing.Point(26, 60);
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
            this.pAcciones.TabIndex = 37;
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
            // FrmModelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 326);
            this.Controls.Add(this.pAcciones);
            this.Controls.Add(this.dgvModelos);
            this.Controls.Add(this.gbCriteriosBusqueda);
            this.Font = new System.Drawing.Font("Cambria", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmModelos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modelos";
            this.Load += new System.EventHandler(this.FrmModelos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelos)).EndInit();
            this.gbCriteriosBusqueda.ResumeLayout(false);
            this.gbCriteriosBusqueda.PerformLayout();
            this.pAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvModelos;
        private System.Windows.Forms.GroupBox gbCriteriosBusqueda;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Panel pAcciones;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
    }
}