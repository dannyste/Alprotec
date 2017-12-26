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
    public partial class FrmNuevoModificarTrabajador : Form
    {
        private FrmTrabajadores frmTrabajadores;

        private String operacion;

        private bool error = false;

        private String mensaje = String.Empty;

        private Trabajador trabajador = new Trabajador();

        public FrmNuevoModificarTrabajador()
        {
            InitializeComponent();
        }

        public FrmNuevoModificarTrabajador(FrmTrabajadores frmTrabajadores, String operacion)
        {
            InitializeComponent();
            this.frmTrabajadores = frmTrabajadores;
            this.operacion = operacion;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                switch (operacion)
                {
                    case "N":
                        TrabajadorBL.insertarTrabajador(objetoTrabajador(), ref error, ref mensaje);
                        break;
                    case "M":
                        TrabajadorBL.actualizarTrabajador(objetoTrabajador(), ref error, ref mensaje);
                        break;
                }
                if (!error)
                {
                    frmTrabajadores.actualizarDgvTrabajadores();
                    DialogResult result = MessageBox.Show(mensaje, "Alprotec", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        switch (operacion)
                        {
                            case "N":
                                limpiarCampos();
                                break;
                            case "M":
                                this.Close();
                                break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ocurrió un error.", "Alprotec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Trabajador objetoTrabajador()
        {
            trabajador.cedulaIdentidad = txtCedulaIdentidad.Text.Trim();
            trabajador.nombre = txtNombre.Text.Trim();
            trabajador.cargo = txtCargo.Text.Trim();
            trabajador.telefono = txtTelefono.Text.Trim();
            trabajador.movil = txtMovil.Text.Trim();
            trabajador.direccion = txtDireccion.Text.Trim();
            trabajador.creadoPor = Globales.UsuarioGlobal.idUsuario;
            trabajador.fechaCreacion = DateTime.Now;
            trabajador.modificadoPor = Globales.UsuarioGlobal.idUsuario;
            trabajador.fechaModificacion = DateTime.Now;
            return trabajador;
        }

        public void modificarTrabajador(Trabajador trabajador)
        {
            this.trabajador.idTrabajador = trabajador.idTrabajador;
            txtCedulaIdentidad.Text = trabajador.cedulaIdentidad;
            txtNombre.Text = trabajador.nombre;
            txtCargo.Text = trabajador.cargo;
            txtTelefono.Text = trabajador.telefono;
            txtMovil.Text = trabajador.movil;
            txtDireccion.Text = trabajador.direccion;
        }

        private bool validarCampos()
        {
            bool resultado = true;
            epError.Clear();
            if (txtCedulaIdentidad.Text == String.Empty)
            {
                epError.SetError(txtCedulaIdentidad, lbCedulaIdentidad.Text + " es requerido");
                resultado = false;
            }
            if (txtNombre.Text == String.Empty)
            {
                epError.SetError(txtNombre, lbNombre.Text + " es requerido");
                resultado = false;
            }
            if (txtCargo.Text == String.Empty)
            {
                epError.SetError(txtCargo, lbCargo.Text + " es requerido");
                resultado = false;
            }
            if (txtTelefono.Text == String.Empty)
            {
                epError.SetError(txtTelefono, lbTelefono.Text + " es requerido");
                resultado = false;
            }
            if (txtMovil.Text == String.Empty)
            {
                epError.SetError(txtMovil, lbMovil.Text + " es requerido");
                resultado = false;
            }
            if (txtDireccion.Text == String.Empty)
            {
                epError.SetError(txtDireccion, lbDireccion.Text + " es requerido");
                resultado = false;
            }
            return resultado;
        }

        public void limpiarCampos()
        {
            txtCedulaIdentidad.Text = String.Empty;
            txtNombre.Text = String.Empty;
            txtCargo.Text = String.Empty;
            txtTelefono.Text = String.Empty;
            txtMovil.Text = String.Empty;
            txtDireccion.Text = String.Empty;
        }
    }
}
