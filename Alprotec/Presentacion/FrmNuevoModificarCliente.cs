using System;
using System.Collections;
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
    public partial class FrmNuevoModificarCliente : Form
    {
        private FrmClientes frmClientes;

        private String operacion;

        private bool error = false;

        private String mensaje = String.Empty;

        private Cliente cliente = new Cliente();

        public FrmNuevoModificarCliente()
        {
            InitializeComponent();
        }

        public FrmNuevoModificarCliente(FrmClientes frmClientes, String operacion)
        {
            InitializeComponent();
            this.frmClientes = frmClientes;
            this.operacion = operacion;
        }

        private void FrmNuevoModificaCliente_Load(object sender, EventArgs e)
        {
            if (operacion == "N")
            {
                llenarCbTipoCliente();
                llenarCbDocumento();
                llenarCbCiudad();
            }
        }

        private void txtNumerico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNumericoSigno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '+') && (e.KeyChar != '-') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            FrmNuevoModificarContacto frmNuevoModificarContacto = new FrmNuevoModificarContacto(this, "N", 0);
            frmNuevoModificarContacto.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvContactos.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar este contacto?", "Remotran", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    dgvContactos.Rows.RemoveAt(dgvContactos.CurrentCell.RowIndex);
                }
            }
            else
            {
                MessageBox.Show("No tiene ningún contacto.", "Remotran", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvContactos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;
            Contacto contacto = new Contacto();
            contacto.idContacto = Convert.ToInt64(dgvContactos.Rows[fila].Cells["Id"].Value);
            contacto.nombre = dgvContactos.Rows[fila].Cells["nombre"].Value.ToString();
            contacto.cargo = dgvContactos.Rows[fila].Cells["cargo"].Value.ToString();
            contacto.telefono = dgvContactos.Rows[fila].Cells["telefono"].Value.ToString();
            contacto.movil = dgvContactos.Rows[fila].Cells["movil"].Value.ToString();
            contacto.correoElectronico = dgvContactos.Rows[fila].Cells["correoElectronico"].Value.ToString();
            contacto.observaciones = dgvContactos.Rows[fila].Cells["observaciones"].Value.ToString();
            FrmNuevoModificarContacto frmNuevoModificarContacto = new FrmNuevoModificarContacto(this, "M", fila);
            frmNuevoModificarContacto.Text = "Modificar contacto";
            frmNuevoModificarContacto.modificarContacto(contacto);
            frmNuevoModificarContacto.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                switch (operacion)
                {
                    case "N":
                        ClienteBL.insertarCliente(objetoCliente(), objetosContactos(), ref error, ref mensaje);
                        break;
                    case "M":
                        ClienteBL.actualizarCliente(objetoCliente(), objetosContactos(), ref error, ref mensaje);
                        break;
                }
                if (!error)
                {
                    frmClientes.actualizarDgvClientes();
                    DialogResult result = MessageBox.Show(mensaje, "Remotran", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("Ocurrió un error.", "Remotran", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void llenarCbTipoCliente()
        {
            List<Catalogo> clientes = CatalogoBL.obtenerTipoCatalogo(4L, ref error, ref mensaje);
            if (!error)
            {
                Catalogo catalogo = new Catalogo();
                catalogo.idCatalogo = 0L;
                catalogo.valor = "Seleccione un tipo de cliente";
                clientes.Insert(0, catalogo);
                cbTipoCliente.DataSource = clientes;
                cbTipoCliente.DisplayMember = "valor";
                cbTipoCliente.ValueMember = "idCatalogo";
            }
            else
            {
                MessageBox.Show("Ocurrió un error.", "Remotran", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbTipoCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Convert.ToInt64(cbTipoCliente.SelectedValue) == 0L)
            {
                txtCodigo.Text = String.Empty;
            }
            else if (Convert.ToInt64(cbTipoCliente.SelectedValue) == 5L)
            {
                generarCodigo();
            }
            else
            {
                txtCodigo.Text = "0.0.0";
            }
        }

        public void generarCodigo()
        {
            String codigo = ClienteBL.secuenciaCodigoCliente(ref error, ref mensaje);
            if (!error)
            {
                txtCodigo.Text = codigo;
            }
            else 
            {
                MessageBox.Show("Ocurrió un error.", "Remotran", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void llenarCbDocumento()
        {
            List<Catalogo> documentos = CatalogoBL.obtenerTipoCatalogo(5L, ref error, ref mensaje);
            if (!error)
            {
                Catalogo catalogo = new Catalogo();
                catalogo.idCatalogo = 0L;
                catalogo.valor = "Seleccione un documento";
                documentos.Insert(0, catalogo);
                cbDocumento.DataSource = documentos;
                cbDocumento.DisplayMember = "valor";
                cbDocumento.ValueMember = "idCatalogo";
            }
            else
            {
                MessageBox.Show("Ocurrió un error.", "Remotran", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void llenarCbCiudad()
        {
            List<Catalogo> ciudades = CatalogoBL.obtenerTipoCatalogo(3L, ref error, ref mensaje);
            if (!error)
            {
                Catalogo catalogo = new Catalogo();
                catalogo.idCatalogo = 0L;
                catalogo.valor = "Seleccione una ciudad";
                ciudades.Insert(0, catalogo);
                cbCiudad.DataSource = ciudades;
                cbCiudad.DisplayMember = "valor";
                cbCiudad.ValueMember = "idCatalogo";
            }
            else 
            {
                MessageBox.Show("Ocurrió un error.", "Remotran", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Cliente objetoCliente()
        {
            cliente.codigo = txtCodigo.Text.Trim();
            cliente.numeroDocumento = txtNumeroDocumento.Text.Trim();
            cliente.nombre = txtNombre.Text.Trim();
            cliente.direccion = txtDireccion.Text.Trim();
            cliente.telefono = txtTelefono.Text.Trim();
            cliente.idTipoClienteCatalogo = Convert.ToInt64(cbTipoCliente.SelectedValue);
            cliente.idDocumentoCatalog = Convert.ToInt64(cbDocumento.SelectedValue);
            cliente.idCiudadCatalogo = Convert.ToInt64(cbCiudad.SelectedValue);
            cliente.estado = true;
            cliente.creadoPor = Globales.UsuarioGlobal.idUsuario;
            cliente.fechaCreacion = DateTime.Now;
            cliente.modificadoPor = Globales.UsuarioGlobal.idUsuario;
            cliente.fechaModificacion = DateTime.Now;
            return cliente;
        }

        private List<Contacto> objetosContactos()
        {
            List<Contacto> contactos = new List<Contacto>();
            for (int fila = 0; fila < dgvContactos.Rows.Count; fila++)
            {
                Contacto contacto = new Contacto();
                contacto.idContacto = Convert.ToInt64(dgvContactos.Rows[fila].Cells["id"].Value);
                contacto.nombre = dgvContactos.Rows[fila].Cells["nombre"].Value.ToString();
                contacto.cargo = dgvContactos.Rows[fila].Cells["cargo"].Value.ToString();
                contacto.telefono = dgvContactos.Rows[fila].Cells["telefono"].Value.ToString();
                contacto.movil = dgvContactos.Rows[fila].Cells["movil"].Value.ToString();
                contacto.correoElectronico = dgvContactos.Rows[fila].Cells["correoElectronico"].Value.ToString();
                contacto.observaciones = dgvContactos.Rows[fila].Cells["observaciones"].Value.ToString();
                contacto.estado = true;
                contacto.creadoPor = Globales.UsuarioGlobal.idUsuario;
                contacto.fechaCreacion = DateTime.Now;
                contacto.modificadoPor = Globales.UsuarioGlobal.idUsuario;
                contacto.fechaModificacion = DateTime.Now;
                contactos.Add(contacto);
            }    
            return contactos;
        }

        public void modificarCliente(Cliente cliente)
        {
            this.cliente.idCliente = cliente.idCliente;
            cbTipoCliente.SelectedValue = cliente.idTipoClienteCatalogo;
            txtCodigo.Text = cliente.codigo;
            cbDocumento.SelectedValue = cliente.idDocumentoCatalog;
            txtNumeroDocumento.Text = cliente.numeroDocumento;
            txtNombre.Text = cliente.nombre;
            txtDireccion.Text = cliente.direccion;
            txtTelefono.Text = cliente.telefono;
            cbCiudad.SelectedValue = cliente.idCiudadCatalogo;
        }

        public void modificarContactos(List<Contacto> contactos)
        {
            foreach (Contacto contacto in contactos)
            {
                int fila = dgvContactos.Rows.Count;
                dgvContactos.Rows.Add();
                dgvContactos.Rows[fila].Cells["id"].Value = contacto.idContacto.ToString();
                dgvContactos.Rows[fila].Cells["nombre"].Value = contacto.nombre;
                dgvContactos.Rows[fila].Cells["cargo"].Value = contacto.cargo;
                dgvContactos.Rows[fila].Cells["telefono"].Value = contacto.telefono;
                dgvContactos.Rows[fila].Cells["movil"].Value = contacto.movil;
                dgvContactos.Rows[fila].Cells["correoElectronico"].Value = contacto.correoElectronico;
                dgvContactos.Rows[fila].Cells["observaciones"].Value = contacto.observaciones;
            }
        }

        private bool validarCampos()
        {
            bool resultado = true;
            if (Convert.ToInt64(cbTipoCliente.SelectedValue) == 0L)
            {
                lbTipoCliente.ForeColor = Color.Red;
                resultado = false;
            }
            if (Convert.ToInt64(cbDocumento.SelectedValue) == 0L)
            {
                lbDocumento.ForeColor = Color.Red;
                resultado = false;
            }
            if (txtNumeroDocumento.Text == String.Empty)
            {
                lbNumeroDocumento.ForeColor = Color.Red;
                resultado = false;
            }
            if (txtNombre.Text == String.Empty)
            {
                lbNombre.ForeColor = Color.Red;
                resultado = false;
            }
            if (txtDireccion.Text == String.Empty)
            {
                lbDireccion.ForeColor = Color.Red;
                resultado = false;
            }
            if (txtTelefono.Text == String.Empty)
            {
                lbTelefono.ForeColor = Color.Red;
                resultado = false;
            }
            if (Convert.ToInt64(cbCiudad.SelectedValue) == 0L)
            {
                lbCiudad.ForeColor = Color.Red;
                resultado = false;
            }
            if (dgvContactos.Rows.Count == 0)
            {
                lbContactos.ForeColor = Color.Red;
                resultado = false;
            }
            return resultado;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text == String.Empty)
            {
                lbTipoCliente.ForeColor = Color.Red;
            }
            else
            {
                lbTipoCliente.ForeColor = Color.Black;
            }
        }

        private void cbDocumento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Convert.ToInt64(cbDocumento.SelectedValue) == 0L)
            {
                lbDocumento.ForeColor = Color.Red;
            }
            else
            {
                lbDocumento.ForeColor = Color.Black;
            }
        }

        private void txtNumeroDocumento_TextChanged(object sender, EventArgs e)
        {
            if (txtNumeroDocumento.Text == String.Empty)
            {
                lbNumeroDocumento.ForeColor = Color.Red;
            }
            else
            {
                lbNumeroDocumento.ForeColor = Color.Black;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text == String.Empty)
            {
                lbNombre.ForeColor = Color.Red;
            }
            else
            {
                lbNombre.ForeColor = Color.Black;
            }
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            if (txtDireccion.Text == String.Empty)
            {
                lbDireccion.ForeColor = Color.Red;
            }
            else
            {
                lbDireccion.ForeColor = Color.Black;
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            if (txtTelefono.Text == String.Empty)
            {
                lbTelefono.ForeColor = Color.Red;
            }
            else
            {
                lbTelefono.ForeColor = Color.Black;
            }
        }

        private void cbCiudad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Convert.ToInt64(cbCiudad.SelectedValue) == 0L)
            {
                lbCiudad.ForeColor = Color.Red;
            }
            else
            {
                lbCiudad.ForeColor = Color.Black;
            }
        }

        private void dgvContactos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dgvContactos.Rows.Count == 0)
            {
                lbContactos.ForeColor = Color.Red;
            }
            else
            {
                lbContactos.ForeColor = Color.Black;
            }
        }

        public void limpiarCampos()
        {
            cbTipoCliente.SelectedIndex = 0;
            txtCodigo.Text = String.Empty;
            cbDocumento.SelectedIndex = 0;
            txtNumeroDocumento.Text = String.Empty;
            txtNombre.Text = String.Empty;
            txtDireccion.Text = String.Empty;
            txtTelefono.Text = String.Empty;
            cbCiudad.SelectedIndex = 0;
            dgvContactos.Rows.Clear();
        }
    }
}
