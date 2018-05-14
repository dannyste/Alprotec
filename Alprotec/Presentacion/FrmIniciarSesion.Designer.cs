namespace Presentacion
{
    partial class FrmIniciarSesion
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
            this.lbUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lbContraseña = new System.Windows.Forms.Label();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Cambria", 10F);
            this.lbUsuario.Location = new System.Drawing.Point(23, 3);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(55, 16);
            this.lbUsuario.TabIndex = 0;
            this.lbUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Cambria", 10F);
            this.txtUsuario.Location = new System.Drawing.Point(25, 21);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(213, 23);
            this.txtUsuario.TabIndex = 1;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Cambria", 10F);
            this.txtContraseña.Location = new System.Drawing.Point(25, 64);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(213, 23);
            this.txtContraseña.TabIndex = 3;
            // 
            // lbContraseña
            // 
            this.lbContraseña.AutoSize = true;
            this.lbContraseña.Font = new System.Drawing.Font("Cambria", 10F);
            this.lbContraseña.Location = new System.Drawing.Point(23, 46);
            this.lbContraseña.Name = "lbContraseña";
            this.lbContraseña.Size = new System.Drawing.Size(77, 16);
            this.lbContraseña.TabIndex = 2;
            this.lbContraseña.Text = "Contraseña";
            // 
            // epError
            // 
            this.epError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epError.ContainerControl = this;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Location = new System.Drawing.Point(25, 98);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(100, 23);
            this.btnIniciarSesion.TabIndex = 19;
            this.btnIniciarSesion.Text = "Iniciar sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(138, 98);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 23);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmIniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 129);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lbContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lbUsuario);
            this.Font = new System.Drawing.Font("Cambria", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmIniciarSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autenticación";
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lbContraseña;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnIniciarSesion;
    }
}