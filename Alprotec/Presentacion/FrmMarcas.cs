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
    public partial class FrmMarcas : Form
    {
        private bool error = false;

        private String mensaje = String.Empty;

        public FrmMarcas()
        {
            InitializeComponent();
        }

        private void FrmMarcas_Load(object sender, EventArgs e)
        {
            actualizarDgvMarcas();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            actualizarDgvMarcas();
        }

        private void dgvMarcas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                long idCatalogo = Convert.ToInt64(dgvMarcas.Rows[e.RowIndex].Cells["Id"].Value);
                Catalogo catalogo = CatalogoBL.obtenerCatalogo(idCatalogo, ref error, ref mensaje);
                if (!error)
                {
                    FrmNuevaModificarMarca frmNuevaModificarMarca = new FrmNuevaModificarMarca(this, "M");
                    frmNuevaModificarMarca.modificarMarca(catalogo);
                    frmNuevaModificarMarca.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error.", "Remotran", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevaModificarMarca frmNuevaModificarMarca = new FrmNuevaModificarMarca(this, "N");
            frmNuevaModificarMarca.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar esta marca?", "Remotran", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    CatalogoBL.eliminarCatalogo(Convert.ToInt64(dgvMarcas.Rows[dgvMarcas.CurrentCell.RowIndex].Cells["Id"].Value), ref error, ref mensaje);
                    if (!error)
                    {
                        MessageBox.Show("Marca eliminada exitosamente.", "Remotran", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error.", "Remotran", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No tiene ninguna marca.", "Remotran", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void actualizarDgvMarcas()
        {
            IEnumerable dataSource = CatalogoBL.filtrarMarcas(txtNombre.Text.Trim(), ref error, ref mensaje);
            if (!error)
            {
                dgvMarcas.DataSource = dataSource;
                dgvMarcas.Columns[0].Visible = false;
            }
            else
            {
                MessageBox.Show("Ocurrió un error.", "Remotran", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
