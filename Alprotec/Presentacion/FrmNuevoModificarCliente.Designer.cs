namespace Presentacion
{
    partial class FrmNuevoModificarCliente
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbTipoCliente = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lbTipoCliente = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.lbContactos = new System.Windows.Forms.Label();
            this.lbCiudad = new System.Windows.Forms.Label();
            this.dgvContactos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoElectronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbCiudad = new System.Windows.Forms.ComboBox();
            this.lbDocumento = new System.Windows.Forms.Label();
            this.cbDocumento = new System.Windows.Forms.ComboBox();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.lbNumeroDocumento = new System.Windows.Forms.Label();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnCancelar.Image = global::Presentacion.Properties.Resources.cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(159, 514);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(50, 50);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnGuardar.Image = global::Presentacion.Properties.Resources.guardar;
            this.btnGuardar.Location = new System.Drawing.Point(51, 514);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(50, 50);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cbTipoCliente
            // 
            this.cbTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoCliente.Font = new System.Drawing.Font("Cambria", 10F);
            this.cbTipoCliente.FormattingEnabled = true;
            this.cbTipoCliente.Location = new System.Drawing.Point(24, 20);
            this.cbTipoCliente.Name = "cbTipoCliente";
            this.cbTipoCliente.Size = new System.Drawing.Size(213, 23);
            this.cbTipoCliente.TabIndex = 1;
            this.cbTipoCliente.SelectionChangeCommitted += new System.EventHandler(this.cbTipoCliente_SelectionChangeCommitted);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Cambria", 10F);
            this.txtCodigo.Location = new System.Drawing.Point(24, 63);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(213, 23);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Cambria", 10F);
            this.lbCodigo.Location = new System.Drawing.Point(22, 45);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(49, 16);
            this.lbCodigo.TabIndex = 0;
            this.lbCodigo.Text = "Código";
            // 
            // lbTipoCliente
            // 
            this.lbTipoCliente.AutoSize = true;
            this.lbTipoCliente.Font = new System.Drawing.Font("Cambria", 10F);
            this.lbTipoCliente.Location = new System.Drawing.Point(22, 2);
            this.lbTipoCliente.Name = "lbTipoCliente";
            this.lbTipoCliente.Size = new System.Drawing.Size(103, 16);
            this.lbTipoCliente.TabIndex = 1;
            this.lbTipoCliente.Text = "Tipo de cliente*";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Cambria", 10F);
            this.txtDireccion.Location = new System.Drawing.Point(24, 235);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(213, 45);
            this.txtDireccion.TabIndex = 5;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Font = new System.Drawing.Font("Cambria", 10F);
            this.lbDireccion.Location = new System.Drawing.Point(22, 217);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(71, 16);
            this.lbDireccion.TabIndex = 5;
            this.lbDireccion.Text = "Dirección*";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Cambria", 10F);
            this.lbNombre.Location = new System.Drawing.Point(22, 174);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(64, 16);
            this.lbNombre.TabIndex = 4;
            this.lbNombre.Text = "Nombre*";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Cambria", 10F);
            this.txtNombre.Location = new System.Drawing.Point(24, 192);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(213, 23);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Cambria", 10F);
            this.txtTelefono.Location = new System.Drawing.Point(24, 300);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(213, 23);
            this.txtTelefono.TabIndex = 6;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumericoSigno_KeyPress);
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Font = new System.Drawing.Font("Cambria", 10F);
            this.lbTelefono.Location = new System.Drawing.Point(22, 282);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(65, 16);
            this.lbTelefono.TabIndex = 6;
            this.lbTelefono.Text = "Teléfono*";
            // 
            // lbContactos
            // 
            this.lbContactos.AutoSize = true;
            this.lbContactos.Font = new System.Drawing.Font("Cambria", 10F);
            this.lbContactos.Location = new System.Drawing.Point(22, 368);
            this.lbContactos.Name = "lbContactos";
            this.lbContactos.Size = new System.Drawing.Size(73, 16);
            this.lbContactos.TabIndex = 0;
            this.lbContactos.Text = "Contactos*";
            // 
            // lbCiudad
            // 
            this.lbCiudad.AutoSize = true;
            this.lbCiudad.Font = new System.Drawing.Font("Cambria", 10F);
            this.lbCiudad.Location = new System.Drawing.Point(22, 325);
            this.lbCiudad.Name = "lbCiudad";
            this.lbCiudad.Size = new System.Drawing.Size(57, 16);
            this.lbCiudad.TabIndex = 7;
            this.lbCiudad.Text = "Ciudad*";
            // 
            // dgvContactos
            // 
            this.dgvContactos.AllowUserToAddRows = false;
            this.dgvContactos.AllowUserToDeleteRows = false;
            this.dgvContactos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvContactos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvContactos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvContactos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.cargo,
            this.telefono,
            this.movil,
            this.correoElectronico,
            this.observaciones});
            this.dgvContactos.Location = new System.Drawing.Point(24, 386);
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.ReadOnly = true;
            this.dgvContactos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContactos.Size = new System.Drawing.Size(213, 84);
            this.dgvContactos.TabIndex = 0;
            this.dgvContactos.TabStop = false;
            this.dgvContactos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContactos_CellContentDoubleClick);
            this.dgvContactos.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvContactos_RowsAdded);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 83;
            // 
            // cargo
            // 
            this.cargo.HeaderText = "Cargo";
            this.cargo.Name = "cargo";
            this.cargo.ReadOnly = true;
            this.cargo.Visible = false;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Teléfono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Visible = false;
            // 
            // movil
            // 
            this.movil.HeaderText = "Móvil";
            this.movil.Name = "movil";
            this.movil.ReadOnly = true;
            this.movil.Visible = false;
            // 
            // correoElectronico
            // 
            this.correoElectronico.HeaderText = "Correo electrónico";
            this.correoElectronico.Name = "correoElectronico";
            this.correoElectronico.ReadOnly = true;
            this.correoElectronico.Visible = false;
            // 
            // observaciones
            // 
            this.observaciones.HeaderText = "Observaciones";
            this.observaciones.Name = "observaciones";
            this.observaciones.ReadOnly = true;
            this.observaciones.Visible = false;
            // 
            // cbCiudad
            // 
            this.cbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCiudad.Font = new System.Drawing.Font("Cambria", 10F);
            this.cbCiudad.FormattingEnabled = true;
            this.cbCiudad.Location = new System.Drawing.Point(24, 343);
            this.cbCiudad.Name = "cbCiudad";
            this.cbCiudad.Size = new System.Drawing.Size(213, 23);
            this.cbCiudad.TabIndex = 7;
            this.cbCiudad.SelectionChangeCommitted += new System.EventHandler(this.cbCiudad_SelectionChangeCommitted);
            // 
            // lbDocumento
            // 
            this.lbDocumento.AutoSize = true;
            this.lbDocumento.Font = new System.Drawing.Font("Cambria", 10F);
            this.lbDocumento.Location = new System.Drawing.Point(22, 88);
            this.lbDocumento.Name = "lbDocumento";
            this.lbDocumento.Size = new System.Drawing.Size(83, 16);
            this.lbDocumento.TabIndex = 2;
            this.lbDocumento.Text = "Documento*";
            // 
            // cbDocumento
            // 
            this.cbDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDocumento.Font = new System.Drawing.Font("Cambria", 10F);
            this.cbDocumento.FormattingEnabled = true;
            this.cbDocumento.Location = new System.Drawing.Point(24, 106);
            this.cbDocumento.Name = "cbDocumento";
            this.cbDocumento.Size = new System.Drawing.Size(213, 23);
            this.cbDocumento.TabIndex = 2;
            this.cbDocumento.SelectionChangeCommitted += new System.EventHandler(this.cbDocumento_SelectionChangeCommitted);
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Font = new System.Drawing.Font("Cambria", 10F);
            this.txtNumeroDocumento.Location = new System.Drawing.Point(24, 149);
            this.txtNumeroDocumento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(213, 23);
            this.txtNumeroDocumento.TabIndex = 3;
            this.txtNumeroDocumento.TextChanged += new System.EventHandler(this.txtNumeroDocumento_TextChanged);
            this.txtNumeroDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumerico_KeyPress);
            // 
            // lbNumeroDocumento
            // 
            this.lbNumeroDocumento.AutoSize = true;
            this.lbNumeroDocumento.Font = new System.Drawing.Font("Cambria", 10F);
            this.lbNumeroDocumento.Location = new System.Drawing.Point(22, 131);
            this.lbNumeroDocumento.Name = "lbNumeroDocumento";
            this.lbNumeroDocumento.Size = new System.Drawing.Size(157, 16);
            this.lbNumeroDocumento.TabIndex = 3;
            this.lbNumeroDocumento.Text = "Número del documento*";
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAñadir.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnAñadir.Location = new System.Drawing.Point(93, 476);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(69, 23);
            this.btnAñadir.TabIndex = 8;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnEliminar.Location = new System.Drawing.Point(168, 476);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(69, 23);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FrmNuevoModificarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 569);
            this.Controls.Add(this.txtNumeroDocumento);
            this.Controls.Add(this.lbNumeroDocumento);
            this.Controls.Add(this.cbDocumento);
            this.Controls.Add(this.lbDocumento);
            this.Controls.Add(this.cbCiudad);
            this.Controls.Add(this.dgvContactos);
            this.Controls.Add(this.lbCiudad);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.lbContactos);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lbTelefono);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lbDireccion);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.cbTipoCliente);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.lbTipoCliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Font = new System.Drawing.Font("Cambria", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmNuevoModificarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo cliente";
            this.Load += new System.EventHandler(this.FrmNuevoModificaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cbTipoCliente;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbTipoCliente;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.Label lbContactos;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lbCiudad;
        public System.Windows.Forms.DataGridView dgvContactos;
        private System.Windows.Forms.ComboBox cbCiudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn movil;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoElectronico;
        private System.Windows.Forms.DataGridViewTextBoxColumn observaciones;
        private System.Windows.Forms.ComboBox cbDocumento;
        private System.Windows.Forms.Label lbDocumento;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.Label lbNumeroDocumento;
    }
}