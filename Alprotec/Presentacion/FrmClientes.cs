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
using Negocio;
using Entidad;
using Utilidades;

namespace Presentacion
{
    public partial class FrmClientes : Form
    {
        public FrmNuevoModificarEquipo frmNuevoModificarEquipo;

        public FrmNuevaModificarRecepcionEquipo frmNuevaModificarRecepcionEquipo;

        public bool busqueda = false;

        private bool error = false;

        private String mensaje = String.Empty;

        private int opcion = 1;

        public FrmClientes()
        {
            InitializeComponent();
        }

        public FrmClientes(FrmNuevoModificarEquipo frmNuevoModificarEquipo, bool busqueda)
        {
            InitializeComponent();
            this.frmNuevoModificarEquipo = frmNuevoModificarEquipo;
            this.busqueda = busqueda;
        }

        public FrmClientes(FrmNuevaModificarRecepcionEquipo frmNuevaModificarRecepcionEquipo, bool busqueda)
        {
            InitializeComponent();
            this.frmNuevaModificarRecepcionEquipo = frmNuevaModificarRecepcionEquipo;
            this.busqueda = busqueda;
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            llenarCbDocumento();
            actualizarDgvClientes();
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            txtNumeroDocumento.Text = String.Empty;
            cbDocumento.SelectedValue = 0L;
            txtCliente.Text = String.Empty;
            actualizarDgvClientes();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            actualizarDgvClientes();
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && busqueda)
            {
                long idCliente = Convert.ToInt64(dgvClientes.Rows[e.RowIndex].Cells["Id"].Value);
                ClienteDTO clienteDTO = ClienteBL.obtenerCliente(idCliente, ref error, ref mensaje);
                if (!error)
                {
                    if (frmNuevoModificarEquipo != null)
                    {
                        frmNuevoModificarEquipo.establecerCliente = clienteDTO.cliente;
                        frmNuevoModificarEquipo.llenarTxtCliente();
                        this.Close();
                    }
                    else if (frmNuevaModificarRecepcionEquipo != null)
                    {
                        frmNuevaModificarRecepcionEquipo.establecerCliente(clienteDTO.cliente);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Ocurrió un error.", "Alprotec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoModificarCliente frmNuevoModificarCliente = new FrmNuevoModificarCliente(this, "N");
            frmNuevoModificarCliente.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.Rows.Count > 0)
            {
                long idCliente = Convert.ToInt64(dgvClientes.Rows[dgvClientes.CurrentCell.RowIndex].Cells["Id"].Value);
                ClienteDTO clienteDTO = ClienteBL.obtenerCliente(idCliente, ref error, ref mensaje);
                if (!error)
                {
                    FrmNuevoModificarCliente frmNuevoModificarCliente = new FrmNuevoModificarCliente(this, "M");
                    frmNuevoModificarCliente.llenarCbTipoCliente();
                    frmNuevoModificarCliente.llenarCbDocumento();
                    frmNuevoModificarCliente.llenarCbCiudad();
                    frmNuevoModificarCliente.modificarCliente(clienteDTO.cliente);
                    frmNuevoModificarCliente.modificarContactos(clienteDTO.contactos);
                    frmNuevoModificarCliente.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error.", "Alprotec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No tiene ningún cliente.", "Alprotec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar este cliente?", "Alprotec", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ClienteBL.eliminarCliente(Convert.ToInt64(dgvClientes.Rows[dgvClientes.CurrentCell.RowIndex].Cells["Id"].Value), ref error, ref mensaje);
                    if (!error)
                    {
                        MessageBox.Show(mensaje, "Alprotec", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error.", "Alprotec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No tiene ningún cliente.", "Alprotec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Formulario formulario = FormularioBL.obtenerFormulario("AL-T-CL", ref error, ref mensaje);
            if (!error)
            {
                try
                {
                    AlprotecdbEntities db = new AlprotecdbEntities();
                    CRClientes crClientes = new CRClientes();
                    crClientes.SetDataSource(db.Contacto.Select(c => new
                    {
                        Id = c.Cliente.idCliente,
                        Tipo = c.Cliente.Catalogo1.valor,
                        Codigo = c.Cliente.codigo,
                        Documento = c.Cliente.Catalogo2.valor,
                        NumeroDocumento = c.Cliente.numeroDocumento,
                        Nombre = c.Cliente.nombre,
                        Telefono = c.Cliente.telefono,
                        Direccion = c.Cliente.direccion,
                        Ciudad = c.Cliente.Catalogo.valor,
                        NombreContacto = c.nombre,
                        CargoContacto = c.cargo,
                        TelefonoContacto = c.telefono,
                        MovilContacto = c.movil,
                        CorreoElectronicoContacto = c.correoElectronico,
                        ObservacionesContacto = c.observaciones
                        
                    }).ToList());
                    crClientes.SetParameterValue("CodigoFormulario", formulario.codigo);
                    crClientes.SetParameterValue("NombreFormulario", formulario.nombre);
                    crClientes.SetParameterValue("AproboFormulario", formulario.aprobo);
                    crClientes.SetParameterValue("NumeroEdicionFormulario", formulario.numeroEdicion.ToString());
                    FrmReportes frmReportes = new FrmReportes();
                    frmReportes.crvReportes.ReportSource = crClientes;
                    frmReportes.ShowDialog();
                }
                catch (Exception exception) 
                {
                    MessageBox.Show("Ocurrió un error.", "Alprotec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ocurrió un error.", "Alprotec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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

        public void actualizarDgvClientes()
        {
            IEnumerable dataSource = ClienteBL.filtrarClientes(txtNumeroDocumento.Text.Trim(), Convert.ToInt64(cbDocumento.SelectedValue), txtCliente.Text.Trim(), ref error, ref mensaje);
            if (!error)
            {
                dgvClientes.DataSource = dataSource;
                dgvClientes.Columns[0].Visible = false;
            }
            else
            {
                MessageBox.Show("Ocurrió un error.", "Alprotec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gbCriteriosBusqueda_Enter(object sender, EventArgs e)
        {

        }
    }
}