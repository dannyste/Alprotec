namespace Presentacion
{
    partial class FrmNuevoModificarContacto
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.lbCargo = new System.Windows.Forms.Label();
            this.txtMovil = new System.Windows.Forms.TextBox();
            this.lbMovil = new System.Windows.Forms.Label();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.lbCorreoElectronico = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lbObservaciones = new System.Windows.Forms.Label();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnCancelar.Image = global::Presentacion.Properties.Resources.cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(154, 287);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(50, 50);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnGuardar.Image = global::Presentacion.Properties.Resources.guardar;
            this.btnGuardar.Location = new System.Drawing.Point(57, 287);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(50, 50);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Cambria", 10F);
            this.txtNombre.Location = new System.Drawing.Point(25, 21);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(213, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Cambria", 10F);
            this.lbNombre.Location = new System.Drawing.Point(23, 3);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(58, 16);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Cambria", 10F);
            this.txtTelefono.Location = new System.Drawing.Point(25, 107);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(213, 23);
            this.txtTelefono.TabIndex = 3;
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Font = new System.Drawing.Font("Cambria", 10F);
            this.lbTelefono.Location = new System.Drawing.Point(23, 89);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(59, 16);
            this.lbTelefono.TabIndex = 3;
            this.lbTelefono.Text = "Teléfono";
            // 
            // txtCargo
            // 
            this.txtCargo.Font = new System.Drawing.Font("Cambria", 10F);
            this.txtCargo.Location = new System.Drawing.Point(25, 64);
            this.txtCargo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(213, 23);
            this.txtCargo.TabIndex = 2;
            // 
            // lbCargo
            // 
            this.lbCargo.AutoSize = true;
            this.lbCargo.Font = new System.Drawing.Font("Cambria", 10F);
            this.lbCargo.Location = new System.Drawing.Point(23, 46);
            this.lbCargo.Name = "lbCargo";
            this.lbCargo.Size = new System.Drawing.Size(43, 16);
            this.lbCargo.TabIndex = 2;
            this.lbCargo.Text = "Cargo";
            // 
            // txtMovil
            // 
            this.txtMovil.Font = new System.Drawing.Font("Cambria", 10F);
            this.txtMovil.Location = new System.Drawing.Point(25, 150);
            this.txtMovil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMovil.Name = "txtMovil";
            this.txtMovil.Size = new System.Drawing.Size(213, 23);
            this.txtMovil.TabIndex = 4;
            // 
            // lbMovil
            // 
            this.lbMovil.AutoSize = true;
            this.lbMovil.Font = new System.Drawing.Font("Cambria", 10F);
            this.lbMovil.Location = new System.Drawing.Point(23, 132);
            this.lbMovil.Name = "lbMovil";
            this.lbMovil.Size = new System.Drawing.Size(41, 16);
            this.lbMovil.TabIndex = 4;
            this.lbMovil.Text = "Móvil";
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Font = new System.Drawing.Font("Cambria", 10F);
            this.txtCorreoElectronico.Location = new System.Drawing.Point(25, 193);
            this.txtCorreoElectronico.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(213, 23);
            this.txtCorreoElectronico.TabIndex = 5;
            // 
            // lbCorreoElectronico
            // 
            this.lbCorreoElectronico.AutoSize = true;
            this.lbCorreoElectronico.Font = new System.Drawing.Font("Cambria", 10F);
            this.lbCorreoElectronico.Location = new System.Drawing.Point(23, 175);
            this.lbCorreoElectronico.Name = "lbCorreoElectronico";
            this.lbCorreoElectronico.Size = new System.Drawing.Size(125, 16);
            this.lbCorreoElectronico.TabIndex = 5;
            this.lbCorreoElectronico.Text = "Corrreo electrónico";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Font = new System.Drawing.Font("Cambria", 10F);
            this.txtObservaciones.Location = new System.Drawing.Point(25, 236);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(213, 45);
            this.txtObservaciones.TabIndex = 6;
            // 
            // lbObservaciones
            // 
            this.lbObservaciones.AutoSize = true;
            this.lbObservaciones.Font = new System.Drawing.Font("Cambria", 10F);
            this.lbObservaciones.Location = new System.Drawing.Point(23, 218);
            this.lbObservaciones.Name = "lbObservaciones";
            this.lbObservaciones.Size = new System.Drawing.Size(96, 16);
            this.lbObservaciones.TabIndex = 6;
            this.lbObservaciones.Text = "Observaciones";
            // 
            // epError
            // 
            this.epError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epError.ContainerControl = this;
            // 
            // FrmNuevoModificarContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 343);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.lbObservaciones);
            this.Controls.Add(this.txtCorreoElectronico);
            this.Controls.Add(this.lbCorreoElectronico);
            this.Controls.Add(this.txtMovil);
            this.Controls.Add(this.lbMovil);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.lbCargo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lbTelefono);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Font = new System.Drawing.Font("Cambria", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmNuevoModificarContacto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo contacto";
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label lbCargo;
        private System.Windows.Forms.TextBox txtMovil;
        private System.Windows.Forms.Label lbMovil;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.Label lbCorreoElectronico;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lbObservaciones;
        private System.Windows.Forms.ErrorProvider epError;
    }
}