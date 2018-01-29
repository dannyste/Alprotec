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
    public partial class FrmRecepcionEquipos : Form
    {
        public bool busqueda = false;

        private bool error = false;

        private String mensaje = String.Empty;

        public FrmRecepcionEquipos()
        {
            InitializeComponent();
        }

        private void FrmRecepcionEquipos_Load(object sender, EventArgs e)
        {
            actualizarDgvRecepcionEquipos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevaModificarRecepcionEquipo frmNuevaModificarRecepcionEquipo = new FrmNuevaModificarRecepcionEquipo(this, "N");
            frmNuevaModificarRecepcionEquipo.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvRecepcionEquipos.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar este equipo?", "Alprotec", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    RecepcionEquipoBL.eliminarRecepcionEquipo(Convert.ToInt64(dgvRecepcionEquipos.Rows[dgvRecepcionEquipos.CurrentCell.RowIndex].Cells["Id"].Value), ref error, ref mensaje);
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
                MessageBox.Show("No tiene ninguna recepción de equipo.", "Alprotec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void actualizarDgvRecepcionEquipos()
        {
            IEnumerable dataSource = RecepcionEquipoBL.filtrarRecepcionEquipos(1, txtBuscar.Text.Trim(), ref error, ref mensaje);
            if (!error)
            {
                dgvRecepcionEquipos.DataSource = dataSource;
                dgvRecepcionEquipos.Columns[0].Visible = false;
            }
            else
            {
                MessageBox.Show("Ocurrió un error.", "Alprotec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}