using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Negocio;
using Utilidades;

namespace Presentacion
{
    public partial class FrmIniciarSesion : Form
    {
        public FrmPrincipal frmPrincipal;

        private bool error = false;

        private String mensaje = String.Empty;

        public FrmIniciarSesion()
        {
            InitializeComponent();
        }

        public FrmIniciarSesion(FrmPrincipal frmPrincipal)
        {
            InitializeComponent();
            this.frmPrincipal = frmPrincipal;
        }

        private void txtContraseña_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIniciarSesion_Click(null, null);
            }
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                if (UsuarioBL.iniciarSesion(objetoUsuario(), ref error, ref mensaje))
                {
                    Usuario usuario = UsuarioBL.obtenerUsuario(objetoUsuario(), ref error, ref mensaje);
                    if (!error)
                    {
                        Globales.UsuarioGlobal = usuario;
                        frmPrincipal.visibilidadMsPrincipal();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error.", "Alprotec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (!error)
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.", "Alprotec", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error.", "Alprotec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Usuario objetoUsuario()
        {
            Usuario usuario = new Usuario();
            usuario.usuario1 = txtUsuario.Text.Trim();
            usuario.contraseña = txtContraseña.Text.Trim();
            return usuario;
        }

        private bool validarCampos()
        {
            bool resultado = true;
            epError.Clear();
            if (txtUsuario.Text == String.Empty)
            {
                epError.SetError(txtUsuario, lbUsuario.Text + " es requerido");
                resultado = false;
            }
            if (txtContraseña.Text == String.Empty)
            {
                epError.SetError(txtContraseña, lbContraseña.Text + " es requerida");
                resultado = false;
            }
            return resultado;
        }
    }
}
