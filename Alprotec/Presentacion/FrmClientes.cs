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
        public FrmNuevaModificarRecepcionEquipo frmNuevaModificarRecepcionEquipo;

        public bool busqueda = false;

        private bool error = false;

        private String mensaje = String.Empty;

        private int opcion = 1;

        public FrmClientes()
        {
            InitializeComponent();
        }

        public FrmClientes(FrmNuevaModificarRecepcionEquipo frmNuevaModificarRecepcionEquipo, bool busqueda)
        {
            InitializeComponent();
            this.frmNuevaModificarRecepcionEquipo = frmNuevaModificarRecepcionEquipo;
            this.busqueda = busqueda;
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            llenarCbCliente();
            actualizarDgvClientes();
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCedulaIdentidad.Checked)
            {
                opcion = 1;
            }
            else if (rbRUC.Checked)
            {
                opcion = 2;
            }
            else 
            {
                opcion = 3;
            }
            actualizarDgvClientes();
        }

        private void cbCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            actualizarDgvClientes();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            actualizarDgvClientes();
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && busqueda)
            {
                long idCliente = Convert.ToInt64(dgvClientes.Rows[e.RowIndex].Cells["Id"].Value);
                Cliente cliente = ClienteBL.obtenerCliente(idCliente, ref error, ref mensaje);
                if (!error)
                {
                    frmNuevaModificarRecepcionEquipo.establecerCliente = cliente;
                    frmNuevaModificarRecepcionEquipo.llenarTxtCliente();
                    this.Close();
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
                Cliente cliente = ClienteBL.obtenerCliente(idCliente, ref error, ref mensaje);
                if (!error)
                {
                    List<Contacto> contactos = ContactoBL.obtenerContactos(idCliente, ref error, ref mensaje);
                    if (!error)
                    {
                        FrmNuevoModificarCliente frmNuevoModificarCliente = new FrmNuevoModificarCliente(this, "M");
                        frmNuevoModificarCliente.llenarCbCliente();
                        frmNuevoModificarCliente.llenarCbDocumento();
                        frmNuevoModificarCliente.llenarCbCiudad();
                        frmNuevoModificarCliente.modificarCliente(cliente);
                        frmNuevoModificarCliente.modificarContactos(contactos);
                        frmNuevoModificarCliente.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error.", "Alprotec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
                catch (Exception ex) 
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

        private void llenarCbCliente()
        {
            List<Catalogo> clientes = CatalogoBL.obtenerTipoCatalogo((long)Constantes.Catalogo.TipoCliente, ref error, ref mensaje);
            if (!error)
            {
                Catalogo catalogo = new Catalogo();
                catalogo.idCatalogo = 0L;
                catalogo.valor = "Todos";
                clientes.Insert(0, catalogo);
                cbCliente.DataSource = clientes;
                cbCliente.DisplayMember = "valor";
                cbCliente.ValueMember = "idCatalogo";
            }
            else
            {
                MessageBox.Show("Ocurrió un error.", "Alprotec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void actualizarDgvClientes()
        {
            IEnumerable dataSource = ClienteBL.filtrarClientes(opcion, Convert.ToInt64(cbCliente.SelectedValue), txtBuscar.Text.Trim(), ref error, ref mensaje);
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