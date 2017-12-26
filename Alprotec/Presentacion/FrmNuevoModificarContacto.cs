using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidad;

namespace Presentacion
{
    public partial class FrmNuevoModificarContacto : Form
    {
        private FrmNuevoModificarCliente frmNuevoModificaCliente;

        private String operacion;

        private int fila;

        private Contacto contacto = new Contacto();

        public FrmNuevoModificarContacto()
        {
            InitializeComponent();
        }

        public FrmNuevoModificarContacto(FrmNuevoModificarCliente frmNuevoModificaCliente, String operacion, int fila)
        {
            InitializeComponent();
            this.frmNuevoModificaCliente = frmNuevoModificaCliente;
            this.operacion = operacion;
            this.fila = fila;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                if (operacion == "N")
                {
                    fila = frmNuevoModificaCliente.dgvContactos.Rows.Count;
                    frmNuevoModificaCliente.dgvContactos.Rows.Add();
                    frmNuevoModificaCliente.dgvContactos.Rows[fila].Cells["id"].Value = contacto.idContacto;
                    frmNuevoModificaCliente.dgvContactos.Rows[fila].Cells["nombre"].Value = txtNombre.Text.Trim();
                    frmNuevoModificaCliente.dgvContactos.Rows[fila].Cells["cargo"].Value = txtCargo.Text.Trim();
                    frmNuevoModificaCliente.dgvContactos.Rows[fila].Cells["telefono"].Value = txtTelefono.Text.Trim();
                    frmNuevoModificaCliente.dgvContactos.Rows[fila].Cells["movil"].Value = txtMovil.Text.Trim();
                    frmNuevoModificaCliente.dgvContactos.Rows[fila].Cells["correoElectronico"].Value = txtCorreoElectronico.Text.Trim();
                    frmNuevoModificaCliente.dgvContactos.Rows[fila].Cells["observaciones"].Value = txtObservaciones.Text.Trim();
                }
                else
                {
                    frmNuevoModificaCliente.dgvContactos.Rows[fila].Cells["id"].Value = contacto.idContacto;
                    frmNuevoModificaCliente.dgvContactos.Rows[fila].Cells["nombre"].Value = txtNombre.Text.Trim();
                    frmNuevoModificaCliente.dgvContactos.Rows[fila].Cells["cargo"].Value = txtCargo.Text.Trim();
                    frmNuevoModificaCliente.dgvContactos.Rows[fila].Cells["telefono"].Value = txtTelefono.Text.Trim();
                    frmNuevoModificaCliente.dgvContactos.Rows[fila].Cells["movil"].Value = txtMovil.Text.Trim();
                    frmNuevoModificaCliente.dgvContactos.Rows[fila].Cells["correoElectronico"].Value = txtCorreoElectronico.Text.Trim();
                    frmNuevoModificaCliente.dgvContactos.Rows[fila].Cells["observaciones"].Value = txtObservaciones.Text.Trim();
                }
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validarCampos()
        {
            bool resultado = true;
            epError.Clear();
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
            if (txtCorreoElectronico.Text == String.Empty)
            {
                epError.SetError(this.txtCorreoElectronico, lbCorreoElectronico.Text + " es requerido");
                resultado = false;
            }
            if (txtObservaciones.Text == String.Empty)
            {
                epError.SetError(this.txtObservaciones, lbObservaciones.Text + " es requerido");
                resultado = false;
            }
            return resultado;
        }

        public void modificarContacto(Contacto contacto)
        {
            this.contacto.idContacto = contacto.idContacto;
            txtNombre.Text = contacto.nombre;
            txtCargo.Text = contacto.cargo;
            txtTelefono.Text = contacto.telefono;
            txtMovil.Text = contacto.movil;
            txtCorreoElectronico.Text = contacto.correoElectronico;
            txtObservaciones.Text = contacto.observaciones;
        }
    }
}
