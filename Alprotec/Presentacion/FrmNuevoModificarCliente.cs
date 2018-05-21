﻿using System;
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
                llenarCbCliente();
                llenarCbDocumento();
                llenarCbCiudad();
            }
        }

        private void cbCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Convert.ToUInt64(cbCliente.SelectedValue) == 0L)
            {
                txtCodigo.Text = String.Empty;
            }
            else if (Convert.ToUInt64(cbCliente.SelectedValue) == 5L)
            {
                generarCodigo();
            }
            else
            {
                txtCodigo.Text = "0.0.0";
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
                if (dgvContactos.Rows.Count > 0)
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
                else
                {
                    MessageBox.Show("Debe agregar al menos un contacto.", "Remotran", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void llenarCbCliente()
        {
            List<Catalogo> clientes = CatalogoBL.obtenerTipoCatalogo(4L, ref error, ref mensaje);
            if (!error)
            {
                Catalogo catalogo = new Catalogo();
                catalogo.idCatalogo = 0L;
                catalogo.valor = "Seleccione un cliente";
                clientes.Insert(0, catalogo);
                cbCliente.DataSource = clientes;
                cbCliente.DisplayMember = "valor";
                cbCliente.ValueMember = "idCatalogo";
            }
            else
            {
                MessageBox.Show("Ocurrió un error.", "Remotran", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            cliente.idClienteCatalogo = Convert.ToInt64(cbCliente.SelectedValue);
            cliente.idDocumentoCatalog = Convert.ToInt64(cbDocumento.SelectedValue);
            cliente.idCiudadCatalogo = Convert.ToInt64(cbCiudad.SelectedValue);
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
            cbCliente.SelectedValue = cliente.idClienteCatalogo;
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
            epError.Clear();
            if (Convert.ToInt64(cbCliente.SelectedValue) == 0L)
            {
                epError.SetError(cbCliente, lbCliente.Text + " es requerido");
                resultado = false;
            }
            if (txtCodigo.Text == String.Empty)
            {
                epError.SetError(txtCodigo, lbCodigo.Text + " es requerido");
                resultado = false;
            }
            if (Convert.ToInt64(cbDocumento.SelectedValue) == 0L)
            {
                epError.SetError(cbDocumento, lbDocumento.Text + " es requerido");
                resultado = false;
            }
            if (txtNumeroDocumento.Text == String.Empty)
            {
                epError.SetError(txtNumeroDocumento, lbNumeroDocumento.Text + " es requerido");
                resultado = false;
            }
            if (txtNombre.Text == String.Empty)
            {
                epError.SetError(txtNombre, lbNombre.Text + " es requerido");
                resultado = false;
            }
            if (txtDireccion.Text == String.Empty)
            {
                epError.SetError(txtDireccion, lbDireccion.Text + " es requerido");
                resultado = false;
            }
            if (txtTelefono.Text == String.Empty)
            {
                epError.SetError(txtTelefono, lbTelefono.Text + " es requerido");
                resultado = false;
            }
            if (Convert.ToInt64(cbCiudad.SelectedValue) == 0L)
            {
                epError.SetError(cbCiudad, lbCiudad.Text + " es requerida");
                resultado = false;
            }
            return resultado;
        }

        public void limpiarCampos()
        {
            cbCliente.SelectedIndex = 0;
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
