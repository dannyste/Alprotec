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
        public FrmNuevoModificarDatosTecnicosMotorElectricoTrifasico frmNuevoModificarDatosTecnicosMotorElectricoTrifasico;

        public bool busqueda = false;

        private bool error = false;

        private String mensaje = String.Empty;

        public FrmRecepcionEquipos()
        {
            InitializeComponent();
        }

        public FrmRecepcionEquipos(FrmNuevoModificarDatosTecnicosMotorElectricoTrifasico frmNuevoModificarDatosTecnicosMotorElectricoTrifasico, bool busqueda)
        {
            InitializeComponent();
            this.frmNuevoModificarDatosTecnicosMotorElectricoTrifasico = frmNuevoModificarDatosTecnicosMotorElectricoTrifasico;
            this.busqueda = busqueda;
        }

        private void FrmRecepcionEquipos_Load(object sender, EventArgs e)
        {
            actualizarDgvRecepcionEquipos();
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            actualizarDgvRecepcionEquipos();
        }

        private void dgvRecepcionEquipos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && busqueda)
            {

            }
            else
            {
                MessageBox.Show("Ocurrió un error.", "Alprotec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevaModificarRecepcionEquipo frmNuevaModificarRecepcionEquipo = new FrmNuevaModificarRecepcionEquipo(this, "N");
            frmNuevaModificarRecepcionEquipo.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvRecepcionEquipos.Rows.Count > 0)
            {

            }
            else
            {
                MessageBox.Show("No tiene ningún cliente.", "Alprotec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            IEnumerable dataSource = RecepcionEquipoBL.filtrarRecepcionEquipos(1, txtCliente.Text.Trim(), ref error, ref mensaje);
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