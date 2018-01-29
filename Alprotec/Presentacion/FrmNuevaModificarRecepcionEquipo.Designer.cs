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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevaModificarRecepcionEquipo));
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
            this.btnNuevoEquipo = new System.Windows.Forms.Button();
            this.btnConsultarEquipo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.btnConsultarCliente = new System.Windows.Forms.Button();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
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
            this.dgvEstadoElementosExternos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEstadoElementosExternos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
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
            this.dgvEstadoElementosExternos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvEstadoElementosExternos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvEstadoElementosExternos.Size = new System.Drawing.Size(595, 361);
            this.dgvEstadoElementosExternos.TabIndex = 24;
            // 
            // elemento
            // 
            this.elemento.FillWeight = 152.2842F;
            this.elemento.HeaderText = "Elemento";
            this.elemento.Name = "elemento";
            this.elemento.ReadOnly = true;
            // 
            // existe
            // 
            this.existe.FillWeight = 70.4614F;
            this.existe.HeaderText = "Existe";
            this.existe.Name = "existe";
            // 
            // estado
            // 
            this.estado.FillWeight = 77.25427F;
            this.estado.HeaderText = "Estado";
            this.estado.Items.AddRange(new object[] {
            "Ninguno",
            "Bueno",
            "Regular",
            "Malo"});
            this.estado.Name = "estado";
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
            this.txtEquipo.Location = new System.Drawing.Point(356, 64);
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
            this.lbEquipo.Location = new System.Drawing.Point(354, 46);
            this.lbEquipo.Name = "lbEquipo";
            this.lbEquipo.Size = new System.Drawing.Size(51, 16);
            this.lbEquipo.TabIndex = 24;
            this.lbEquipo.Text = "Equipo";
            // 
            // btnNuevoEquipo
            // 
            this.btnNuevoEquipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevoEquipo.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnNuevoEquipo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoEquipo.Image")));
            this.btnNuevoEquipo.Location = new System.Drawing.Point(618, 58);
            this.btnNuevoEquipo.Name = "btnNuevoEquipo";
            this.btnNuevoEquipo.Size = new System.Drawing.Size(30, 30);
            this.btnNuevoEquipo.TabIndex = 26;
            this.btnNuevoEquipo.UseVisualStyleBackColor = true;
            // 
            // btnConsultarEquipo
            // 
            this.btnConsultarEquipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsultarEquipo.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnConsultarEquipo.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarEquipo.Image")));
            this.btnConsultarEquipo.Location = new System.Drawing.Point(582, 58);
            this.btnConsultarEquipo.Name = "btnConsultarEquipo";
            this.btnConsultarEquipo.Size = new System.Drawing.Size(30, 30);
            this.btnConsultarEquipo.TabIndex = 25;
            this.btnConsultarEquipo.UseVisualStyleBackColor = true;
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
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevoCliente.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnNuevoCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoCliente.Image")));
            this.btnNuevoCliente.Location = new System.Drawing.Point(287, 58);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(30, 30);
            this.btnNuevoCliente.TabIndex = 10;
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // btnConsultarCliente
            // 
            this.btnConsultarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsultarCliente.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnConsultarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarCliente.Image")));
            this.btnConsultarCliente.Location = new System.Drawing.Point(251, 58);
            this.btnConsultarCliente.Name = "btnConsultarCliente";
            this.btnConsultarCliente.Size = new System.Drawing.Size(30, 30);
            this.btnConsultarCliente.TabIndex = 9;
            this.btnConsultarCliente.UseVisualStyleBackColor = true;
            this.btnConsultarCliente.Click += new System.EventHandler(this.btnConsultarCliente_Click);
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // FrmNuevaModificarRecepcionEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 548);
            this.Controls.Add(this.btnNuevoEquipo);
            this.Controls.Add(this.btnConsultarEquipo);
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
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.btnConsultarCliente);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lbCliente);
            this.Font = new System.Drawing.Font("Cambria", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Button btnConsultarCliente;
        private System.Windows.Forms.Button btnNuevoCliente;
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
        private System.Windows.Forms.Button btnNuevoEquipo;
        private System.Windows.Forms.Button btnConsultarEquipo;
        private System.Windows.Forms.TextBox txtEquipo;
        private System.Windows.Forms.Label lbEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn elemento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn existe;
        private System.Windows.Forms.DataGridViewComboBoxColumn estado;
        private System.Windows.Forms.ErrorProvider epError;
    }
}