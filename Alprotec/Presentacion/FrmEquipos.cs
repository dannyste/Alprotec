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

namespace Presentacion
{
    public partial class FrmEquipos : Form
    {
        public FrmNuevaModificarRecepcionEquipo frmNuevaModificarRecepcionEquipo;

        public bool busqueda = false;

        private bool error = false;

        private String mensaje = String.Empty;

        private int opcion = 1;

        public FrmEquipos()
        {
            InitializeComponent();
        }

        public FrmEquipos(FrmNuevaModificarRecepcionEquipo frmNuevaModificarRecepcionEquipo, bool busqueda)
        {
            InitializeComponent();
            this.frmNuevaModificarRecepcionEquipo = frmNuevaModificarRecepcionEquipo;
            this.busqueda = busqueda;
        }

        private void FrmEquipos_Load(object sender, EventArgs e)
        {
            actualizarDgvEquipos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoModificarEquipo frmNuevoModificarEquipo = new FrmNuevoModificarEquipo(this, "N");
            frmNuevoModificarEquipo.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void actualizarDgvEquipos()
        {
            IEnumerable dataSource = ClienteBL.filtrarClientes(opcion, Convert.ToInt64(cbCliente.SelectedValue), txtBuscar.Text.Trim(), ref error, ref mensaje);
            if (!error)
            {
                dgvEquipos.DataSource = dataSource;
                dgvEquipos.Columns[0].Visible = false;
            }
            else
            {
                MessageBox.Show("Ocurrió un error.", "Alprotec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
