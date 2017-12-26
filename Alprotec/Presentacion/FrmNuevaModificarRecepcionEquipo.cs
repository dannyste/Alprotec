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

namespace Presentacion
{
    public partial class FrmNuevaModificarRecepcionEquipo : Form
    {
        private Cliente cliente;

        private Equipo equipo;

        public FrmNuevaModificarRecepcionEquipo()
        {
            InitializeComponent();
        }

        private void FrmNuevaModificarRecepcionEquipo_Load(object sender, EventArgs e)
        {
            dgvEstadoElementosExternos.Rows.Add();
            dgvEstadoElementosExternos.Rows[0].Cells["elemento"].Value = "Estator";
            dgvEstadoElementosExternos.Rows.Add();
            dgvEstadoElementosExternos.Rows[1].Cells["elemento"].Value = "Rotor";
            dgvEstadoElementosExternos.Rows.Add();
            dgvEstadoElementosExternos.Rows[2].Cells["elemento"].Value = "Posición de la caja de conexión - Izquierda";
            dgvEstadoElementosExternos.Rows.Add();
            dgvEstadoElementosExternos.Rows[3].Cells["elemento"].Value = "Posición de la caja de conexión - Derecha";
            dgvEstadoElementosExternos.Rows.Add();
            dgvEstadoElementosExternos.Rows[4].Cells["elemento"].Value = "Base de la caja de conexión";
            dgvEstadoElementosExternos.Rows.Add();
            dgvEstadoElementosExternos.Rows[5].Cells["elemento"].Value = "Ventilador";
            dgvEstadoElementosExternos.Rows.Add();
            dgvEstadoElementosExternos.Rows[6].Cells["elemento"].Value = "Tapa del ventilador";
            dgvEstadoElementosExternos.Rows.Add();
            dgvEstadoElementosExternos.Rows[7].Cells["elemento"].Value = "Tapa frontal";
            dgvEstadoElementosExternos.Rows.Add();
            dgvEstadoElementosExternos.Rows[8].Cells["elemento"].Value = "Tapa posterior";
            dgvEstadoElementosExternos.Rows.Add();
            dgvEstadoElementosExternos.Rows[9].Cells["elemento"].Value = "Polea";
            dgvEstadoElementosExternos.Rows.Add();
            dgvEstadoElementosExternos.Rows[10].Cells["elemento"].Value = "Acople";
            dgvEstadoElementosExternos.Rows.Add();
            dgvEstadoElementosExternos.Rows[11].Cells["elemento"].Value = "Base del motor";
            dgvEstadoElementosExternos.Rows.Add();
            dgvEstadoElementosExternos.Rows[12].Cells["elemento"].Value = "Capacitor de arranque";
            dgvEstadoElementosExternos.Rows.Add();
            dgvEstadoElementosExternos.Rows[13].Cells["elemento"].Value = "Capacitor permanente";
            dgvEstadoElementosExternos.Rows.Add();
            dgvEstadoElementosExternos.Rows[14].Cells["elemento"].Value = "Centrífugo";
            dgvEstadoElementosExternos.Rows.Add();
            dgvEstadoElementosExternos.Rows[15].Cells["elemento"].Value = "Platinera";
        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes(this, true);
            frmClientes.pAcciones.Visible = false;
            frmClientes.Width = 477;
            frmClientes.ShowDialog();
        }
        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            FrmNuevoModificarCliente frmNuevoModificarCliente = new FrmNuevoModificarCliente(this, "N", true);
            frmNuevoModificarCliente.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Cliente establecerCliente
        {
            set 
            {
                this.cliente = value;
            }
        }

        public void llenarTxtCliente()
        {
            txtCliente.Text = cliente.nombre;
        }

        public Equipo establecerEquipo
        {
            set
            {
                this.equipo = value;
            }
        }

        public void llenarTxtEquipo()
        {
            txtEquipo.Text = equipo.codigoInterno;
        }
    }
}
