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

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCliente.Checked)
            {
                opcion = 1;
            }
            else if (rbPotencia.Checked)
            {
                opcion = 2;
            }
            else
            {
                opcion = 3;
            }
            actualizarDgvEquipos();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            actualizarDgvEquipos();
        }

        private void dgvEquipos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && busqueda)
            {
                long idEquipo = Convert.ToInt64(dgvEquipos.Rows[e.RowIndex].Cells["Id"].Value);
                Equipo equipo = EquipoBL.obtenerEquipo(idEquipo, ref error, ref mensaje);
                if (!error)
                {
                    frmNuevaModificarRecepcionEquipo.establecerEquipo = equipo;
                    frmNuevaModificarRecepcionEquipo.llenarTxtEquipo();
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
            FrmNuevoModificarEquipo frmNuevoModificarEquipo = new FrmNuevoModificarEquipo(this, "N");
            frmNuevoModificarEquipo.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvEquipos.Rows.Count > 0)
            {
                long idEquipo = Convert.ToInt64(dgvEquipos.Rows[dgvEquipos.CurrentCell.RowIndex].Cells["Id"].Value);
                Equipo equipo = EquipoBL.obtenerEquipo(idEquipo, ref error, ref mensaje);
                if (!error)
                {
                    FrmNuevoModificarEquipo frmNuevoModificarEquipo = new FrmNuevoModificarEquipo(this, "M");
                    //frmNuevoModificarEquipo.modificarEquipo(equipo);
                    frmNuevoModificarEquipo.ShowDialog();
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
            if (dgvEquipos.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar este equipo?", "Alprotec", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    EquipoBL.eliminarEquipo(Convert.ToInt64(dgvEquipos.Rows[dgvEquipos.CurrentCell.RowIndex].Cells["Id"].Value), ref error, ref mensaje);
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
                MessageBox.Show("No tiene ningún equipo.", "Alprotec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            IEnumerable dataSource = EquipoBL.filtrarEquipos(opcion, txtBuscar.Text.Trim(), ref error, ref mensaje);
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
