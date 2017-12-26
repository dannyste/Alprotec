namespace Presentacion
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsmiArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIniciarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMarcas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModelos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrabajadores = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEquipos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFormulario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRecepcionEquipos = new System.Windows.Forms.ToolStripMenuItem();
            this.msPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPrincipal
            // 
            this.msPrincipal.Font = new System.Drawing.Font("Cambria", 10F);
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiArchivo,
            this.tsmiMantenimiento,
            this.tsmiFormulario});
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.msPrincipal.Size = new System.Drawing.Size(331, 26);
            this.msPrincipal.TabIndex = 1;
            this.msPrincipal.Text = "menuStrip1";
            // 
            // tsmiArchivo
            // 
            this.tsmiArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiIniciarSesion,
            this.tsmiCerrarSesion,
            this.tsmiSalir});
            this.tsmiArchivo.Name = "tsmiArchivo";
            this.tsmiArchivo.Size = new System.Drawing.Size(67, 20);
            this.tsmiArchivo.Text = "Archivo";
            // 
            // tsmiIniciarSesion
            // 
            this.tsmiIniciarSesion.Name = "tsmiIniciarSesion";
            this.tsmiIniciarSesion.Size = new System.Drawing.Size(160, 22);
            this.tsmiIniciarSesion.Text = "Iniciar sesión";
            this.tsmiIniciarSesion.Click += new System.EventHandler(this.tsmiIniciarSesion_Click);
            // 
            // tsmiCerrarSesion
            // 
            this.tsmiCerrarSesion.Name = "tsmiCerrarSesion";
            this.tsmiCerrarSesion.Size = new System.Drawing.Size(160, 22);
            this.tsmiCerrarSesion.Text = "Cerrar sesión";
            this.tsmiCerrarSesion.Visible = false;
            this.tsmiCerrarSesion.Click += new System.EventHandler(this.tsmiCerrarSesion_Click);
            // 
            // tsmiSalir
            // 
            this.tsmiSalir.Name = "tsmiSalir";
            this.tsmiSalir.Size = new System.Drawing.Size(160, 22);
            this.tsmiSalir.Text = "Salir";
            this.tsmiSalir.Click += new System.EventHandler(this.tsmiSalir_Click);
            // 
            // tsmiMantenimiento
            // 
            this.tsmiMantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiClientes,
            this.tsmiMarcas,
            this.tsmiModelos,
            this.tsmiTrabajadores,
            this.tsmiEquipos});
            this.tsmiMantenimiento.Name = "tsmiMantenimiento";
            this.tsmiMantenimiento.Size = new System.Drawing.Size(113, 20);
            this.tsmiMantenimiento.Text = "Mantenimiento";
            this.tsmiMantenimiento.Visible = false;
            // 
            // tsmiClientes
            // 
            this.tsmiClientes.Name = "tsmiClientes";
            this.tsmiClientes.Size = new System.Drawing.Size(160, 22);
            this.tsmiClientes.Text = "Clientes";
            this.tsmiClientes.Click += new System.EventHandler(this.tsmiClientes_Click);
            // 
            // tsmiMarcas
            // 
            this.tsmiMarcas.Name = "tsmiMarcas";
            this.tsmiMarcas.Size = new System.Drawing.Size(160, 22);
            this.tsmiMarcas.Text = "Marcas";
            this.tsmiMarcas.Click += new System.EventHandler(this.tsmiMarcas_Click);
            // 
            // tsmiModelos
            // 
            this.tsmiModelos.Name = "tsmiModelos";
            this.tsmiModelos.Size = new System.Drawing.Size(160, 22);
            this.tsmiModelos.Text = "Modelos";
            this.tsmiModelos.Click += new System.EventHandler(this.tsmiModelos_Click);
            // 
            // tsmiTrabajadores
            // 
            this.tsmiTrabajadores.Name = "tsmiTrabajadores";
            this.tsmiTrabajadores.Size = new System.Drawing.Size(160, 22);
            this.tsmiTrabajadores.Text = "Trabajadores";
            this.tsmiTrabajadores.Click += new System.EventHandler(this.tsmiTrabajadores_Click);
            // 
            // tsmiEquipos
            // 
            this.tsmiEquipos.Name = "tsmiEquipos";
            this.tsmiEquipos.Size = new System.Drawing.Size(160, 22);
            this.tsmiEquipos.Text = "Equipos";
            this.tsmiEquipos.Click += new System.EventHandler(this.tsmiEquipos_Click);
            // 
            // tsmiFormulario
            // 
            this.tsmiFormulario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRecepcionEquipos});
            this.tsmiFormulario.Name = "tsmiFormulario";
            this.tsmiFormulario.Size = new System.Drawing.Size(88, 20);
            this.tsmiFormulario.Text = "Formulario";
            this.tsmiFormulario.Visible = false;
            // 
            // tsmiRecepcionEquipos
            // 
            this.tsmiRecepcionEquipos.Name = "tsmiRecepcionEquipos";
            this.tsmiRecepcionEquipos.Size = new System.Drawing.Size(210, 22);
            this.tsmiRecepcionEquipos.Text = "Recepción de equipos";
            this.tsmiRecepcionEquipos.Click += new System.EventHandler(this.tsmiRecepcionEquipos_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 301);
            this.Controls.Add(this.msPrincipal);
            this.Font = new System.Drawing.Font("Cambria", 10F);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msPrincipal;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmPrincipal";
            this.Text = "Alprotec";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmiArchivo;
        private System.Windows.Forms.ToolStripMenuItem tsmiIniciarSesion;
        private System.Windows.Forms.ToolStripMenuItem tsmiCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem tsmiSalir;
        private System.Windows.Forms.ToolStripMenuItem tsmiMantenimiento;
        private System.Windows.Forms.ToolStripMenuItem tsmiClientes;
        private System.Windows.Forms.ToolStripMenuItem tsmiMarcas;
        private System.Windows.Forms.ToolStripMenuItem tsmiModelos;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrabajadores;
        private System.Windows.Forms.ToolStripMenuItem tsmiEquipos;
        private System.Windows.Forms.ToolStripMenuItem tsmiFormulario;
        private System.Windows.Forms.ToolStripMenuItem tsmiRecepcionEquipos;
    }
}

