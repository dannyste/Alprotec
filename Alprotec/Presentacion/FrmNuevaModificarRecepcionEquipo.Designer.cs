namespace Presentacion
{
    partial class FrmNuevaModificarRecepcionEquipo
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
            this.components = new System.ComponentModel.Container();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lbCliente = new System.Windows.Forms.Label();
            this.gbEstadoElementosExternos = new System.Windows.Forms.GroupBox();
            this.dgvEstadoElementosExternos = new System.Windows.Forms.DataGridView();
            this.elemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existe = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lbNumero = new System.Windows.Forms.Label();
            this.txtDiagnosticoFallas = new System.Windows.Forms.TextBox();
            this.lbDiagnosticoFallas = new System.Windows.Forms.Label();
            this.txtObservacionesCliente = new System.Windows.Forms.TextBox();
            this.lbObservacionesCliente = new System.Windows.Forms.Label();
            this.txtEquipo = new System.Windows.Forms.TextBox();
            this.lbEquipo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBuscarEquipo = new System.Windows.Forms.Button();
            this.gbEstadoElementosExternos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoElementosExternos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Cambria", 10F);
            this.txtCliente.Location = new System.Drawing.Point(25, 64);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(220, 23);
            this.txtCliente.TabIndex = 1;
            this.txtCliente.TabStop = false;
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Font = new System.Drawing.Font("Cambria", 10F);
            this.lbCliente.Location = new System.Drawing.Point(23, 46);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(51, 16);
            this.lbCliente.TabIndex = 2;
            this.lbCliente.Text = "Cliente";
            // 
            // gbEstadoElementosExternos
            // 
            this.gbEstadoElementosExternos.Controls.Add(this.dgvEstadoElementosExternos);
            this.gbEstadoElementosExternos.Font = new System.Drawing.Font("Cambria", 10F);
            this.gbEstadoElementosExternos.Location = new System.Drawing.Point(25, 88);
            this.gbEstadoElementosExternos.Name = "gbEstadoElementosExternos";
            this.gbEstadoElementosExternos.Size = new System.Drawing.Size(623, 387);
            this.gbEstadoElementosExternos.TabIndex = 12;
            this.gbEstadoElementosExternos.TabStop = false;
            this.gbEstadoElementosExternos.Text = "Estado de los elementos externos";
            // 
            // dgvEstadoElementosExternos
            // 
            this.dgvEstadoElementosExternos.AllowUserToAddRows = false;
            this.dgvEstadoElementosExternos.AllowUserToDeleteRows = false;
            this.dgvEstadoElementosExternos.AllowUserToResizeColumns = false;
            this.dgvEstadoElementosExternos.AllowUserToResizeRows = false;
            this.dgvEstadoElementosExternos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvEstadoElementosExternos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEstadoElementosExternos.ColumnHeadersHeight = 30;
            this.dgvEstadoElementosExternos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEstadoElementosExternos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.elemento,
            this.existe,
            this.estado});
            this.dgvEstadoElementosExternos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvEstadoElementosExternos.Location = new System.Drawing.Point(14, 19);
            this.dgvEstadoElementosExternos.Name = "dgvEstadoElementosExternos";
            this.dgvEstadoElementosExternos.RowHeadersVisible = false;
            this.dgvEstadoElementosExternos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvEstadoElementosExternos.RowTemplate.Height = 24;
            this.dgvEstadoElementosExternos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvEstadoElementosExternos.Size = new System.Drawing.Size(594, 361);
            this.dgvEstadoElementosExternos.TabIndex = 24;
            // 
            // elemento
            // 
            this.elemento.HeaderText = "Elemento";
            this.elemento.Name = "elemento";
            this.elemento.ReadOnly = true;
            this.elemento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.elemento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.elemento.Width = 271;
            // 
            // existe
            // 
            this.existe.HeaderText = "Existe";
            this.existe.Name = "existe";
            this.existe.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.existe.Width = 140;
            // 
            // estado
            // 
            this.estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.estado.HeaderText = "Estado";
            this.estado.Items.AddRange(new object[] {
            "Ninguno",
            "Bueno",
            "Regular",
            "Malo"});
            this.estado.Name = "estado";
            this.estado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.estado.Width = 163;
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Cambria", 10F);
            this.txtNumero.Location = new System.Drawing.Point(435, 21);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(213, 23);
            this.txtNumero.TabIndex = 15;
            this.txtNumero.TabStop = false;
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Font = new System.Drawing.Font("Cambria", 10F);
            this.lbNumero.Location = new System.Drawing.Point(433, 3);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(58, 16);
            this.lbNumero.TabIndex = 16;
            this.lbNumero.Text = "Número";
            // 
            // txtDiagnosticoFallas
            // 
            this.txtDiagnosticoFallas.Font = new System.Drawing.Font("Cambria", 10F);
            this.txtDiagnosticoFallas.Location = new System.Drawing.Point(358, 495);
            this.txtDiagnosticoFallas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiagnosticoFallas.Multiline = true;
            this.txtDiagnosticoFallas.Name = "txtDiagnosticoFallas";
            this.txtDiagnosticoFallas.Size = new System.Drawing.Size(290, 45);
            this.txtDiagnosticoFallas.TabIndex = 17;
            // 
            // lbDiagnosticoFallas
            // 
            this.lbDiagnosticoFallas.AutoSize = true;
            this.lbDiagnosticoFallas.Font = new System.Drawing.Font("Cambria", 10F);
            this.lbDiagnosticoFallas.Location = new System.Drawing.Point(356, 477);
            this.lbDiagnosticoFallas.Name = "lbDiagnosticoFallas";
            this.lbDiagnosticoFallas.Size = new System.Drawing.Size(131, 16);
            this.lbDiagnosticoFallas.TabIndex = 18;
            this.lbDiagnosticoFallas.Text = "Diagnóstico de fallas";
            // 
            // txtObservacionesCliente
            // 
            this.txtObservacionesCliente.Font = new System.Drawing.Font("Cambria", 10F);
            this.txtObservacionesCliente.Location = new System.Drawing.Point(25, 495);
            this.txtObservacionesCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtObservacionesCliente.Multiline = true;
            this.txtObservacionesCliente.Name = "txtObservacionesCliente";
            this.txtObservacionesCliente.Size = new System.Drawing.Size(290, 45);
            this.txtObservacionesCliente.TabIndex = 19;
            // 
            // lbObservacionesCliente
            // 
            this.lbObservacionesCliente.AutoSize = true;
            this.lbObservacionesCliente.Font = new System.Drawing.Font("Cambria", 10F);
            this.lbObservacionesCliente.Location = new System.Drawing.Point(23, 477);
            this.lbObservacionesCliente.Name = "lbObservacionesCliente";
            this.lbObservacionesCliente.Size = new System.Drawing.Size(162, 16);
            this.lbObservacionesCliente.TabIndex = 20;
            this.lbObservacionesCliente.Text = "Observaciones del cliente";
            // 
            // txtEquipo
            // 
            this.txtEquipo.Font = new System.Drawing.Font("Cambria", 10F);
            this.txtEquipo.Location = new System.Drawing.Point(363, 64);
            this.txtEquipo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEquipo.Name = "txtEquipo";
            this.txtEquipo.ReadOnly = true;
            this.txtEquipo.Size = new System.Drawing.Size(220, 23);
            this.txtEquipo.TabIndex = 23;
            this.txtEquipo.TabStop = false;
            // 
            // lbEquipo
            // 
            this.lbEquipo.AutoSize = true;
            this.lbEquipo.Font = new System.Drawing.Font("Cambria", 10F);
            this.lbEquipo.Location = new System.Drawing.Point(361, 46);
            this.lbEquipo.Name = "lbEquipo";
            this.lbEquipo.Size = new System.Drawing.Size(51, 16);
            this.lbEquipo.TabIndex = 24;
            this.lbEquipo.Text = "Equipo";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnCancelar.Image = global::Presentacion.Properties.Resources.cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(654, 298);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(50, 50);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnGuardar.Image = global::Presentacion.Properties.Resources.guardar;
            this.btnGuardar.Location = new System.Drawing.Point(654, 220);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(50, 50);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnBuscarCliente.Location = new System.Drawing.Point(251, 64);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(60, 23);
            this.btnBuscarCliente.TabIndex = 9;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // btnBuscarEquipo
            // 
            this.btnBuscarEquipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarEquipo.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnBuscarEquipo.Location = new System.Drawing.Point(588, 64);
            this.btnBuscarEquipo.Name = "btnBuscarEquipo";
            this.btnBuscarEquipo.Size = new System.Drawing.Size(60, 23);
            this.btnBuscarEquipo.TabIndex = 25;
            this.btnBuscarEquipo.Text = "Buscar";
            this.btnBuscarEquipo.UseVisualStyleBackColor = true;
            this.btnBuscarEquipo.Click += new System.EventHandler(this.btnBuscarEquipo_Click);
            // 
            // FrmNuevaModificarRecepcionEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 548);
            this.Controls.Add(this.btnBuscarEquipo);
            this.Controls.Add(this.txtEquipo);
            this.Controls.Add(this.lbEquipo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtObservacionesCliente);
            this.Controls.Add(this.lbObservacionesCliente);
            this.Controls.Add(this.txtDiagnosticoFallas);
            this.Controls.Add(this.lbDiagnosticoFallas);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lbNumero);
            this.Controls.Add(this.gbEstadoElementosExternos);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lbCliente);
            this.Font = new System.Drawing.Font("Cambria", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmNuevaModificarRecepcionEquipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Recepción de Equipo";
            this.Load += new System.EventHandler(this.FrmNuevaModificarRecepcionEquipo_Load);
            this.gbEstadoElementosExternos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoElementosExternos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.GroupBox gbEstadoElementosExternos;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.DataGridView dgvEstadoElementosExternos;
        private System.Windows.Forms.TextBox txtDiagnosticoFallas;
        private System.Windows.Forms.Label lbDiagnosticoFallas;
        private System.Windows.Forms.TextBox txtObservacionesCliente;
        private System.Windows.Forms.Label lbObservacionesCliente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtEquipo;
        private System.Windows.Forms.Label lbEquipo;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.Button btnBuscarEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn elemento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn existe;
        private System.Windows.Forms.DataGridViewComboBoxColumn estado;
    }
}