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

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            dtpFechaInicial.Value = DateTime.Now;
            dtpFechaFinal.Value = DateTime.Now;
            txtCliente.Text = String.Empty;
            actualizarDgvRecepcionEquipos();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            actualizarDgvRecepcionEquipos();
        }

        private void dgvRecepcionEquipos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && busqueda)
            {
                long idRecepcionEquipo = Convert.ToInt64(dgvRecepcionEquipos.Rows[e.RowIndex].Cells["Id"].Value);
                RecepcionEquipoDTO recepcionEquipoDTO = RecepcionEquipoBL.obtenerRecepcionEquipo(idRecepcionEquipo, ref error, ref mensaje);
                if (!error)
                {
                    if (frmNuevoModificarDatosTecnicosMotorElectricoTrifasico != null)
                    {
                        //frmNuevoModificarDatosTecnicosMotorElectricoTrifasico.establecerRecepcionEquipo(recepcionEquipoDTO.recepcionEquipo);
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
            FrmNuevaModificarRecepcionEquipo frmNuevaModificarRecepcionEquipo = new FrmNuevaModificarRecepcionEquipo(this, "N");
            frmNuevaModificarRecepcionEquipo.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvRecepcionEquipos.Rows.Count > 0)
            {
                long idRecepcionEquipo = Convert.ToInt64(dgvRecepcionEquipos.Rows[dgvRecepcionEquipos.CurrentCell.RowIndex].Cells["Id"].Value);
                RecepcionEquipoDTO recepcionEquipoDTO = RecepcionEquipoBL.obtenerRecepcionEquipo(idRecepcionEquipo, ref error, ref mensaje);
                if (!error)
                {
                    FrmNuevaModificarRecepcionEquipo frmNuevaModificarRecepcionEquipo = new FrmNuevaModificarRecepcionEquipo(this, "M");
                    frmNuevaModificarRecepcionEquipo.modificarRecepcionEquipo(recepcionEquipoDTO.recepcionEquipo, recepcionEquipoDTO.cliente, recepcionEquipoDTO.equipo);
                    frmNuevaModificarRecepcionEquipo.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error.", "Alprotec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No tiene ninguna recepción de equipo.", "Alprotec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvRecepcionEquipos.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar esta recepción de equipo?", "Alprotec", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            IEnumerable dataSource = RecepcionEquipoBL.filtrarRecepcionEquipos(dtpFechaInicial.Value.Date, dtpFechaFinal.Value.Date.AddHours(24), txtCliente.Text.Trim(), ref error, ref mensaje);
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