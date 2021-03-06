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
using Negocio;
using Entidad;

namespace Presentacion
{
    public partial class FrmModelos : Form
    {
        private FrmNuevoModificarEquipo frmNuevoModificarEquipo;

        private bool busqueda = false;

        private long idMarca;

        private bool error = false;

        private String mensaje = String.Empty;

        public FrmModelos()
        {
            InitializeComponent();
        }

        public FrmModelos(FrmNuevoModificarEquipo frmNuevoModificarEquipo, bool busqueda, long idMarca)
        {
            InitializeComponent();
            this.frmNuevoModificarEquipo = frmNuevoModificarEquipo;
            this.busqueda = busqueda;
            this.idMarca = idMarca;
        }

        private void FrmModelos_Load(object sender, EventArgs e)
        {
            llenarCbMarca();
            actualizarDgvModelos();
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            txtModelo.Text = String.Empty;
            actualizarDgvModelos();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            actualizarDgvModelos();
        }

        private void dgvModelos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && busqueda)
            {
                long idCatalogo = Convert.ToInt64(dgvModelos.Rows[e.RowIndex].Cells["Id"].Value);
                Catalogo modelo = CatalogoBL.obtenerCatalogo(idCatalogo, ref error, ref mensaje);
                if (!error)
                {
                    Catalogo marca = CatalogoBL.obtenerCatalogo(Convert.ToInt64(cbMarca.SelectedValue), ref error, ref mensaje);
                    if (!error)
                    {
                        frmNuevoModificarEquipo.establecerMarca(marca);
                        frmNuevoModificarEquipo.establecerModelo(modelo);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error.", "Remotran", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ocurrió un error.", "Remotran", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoModificarModelo frmNuevoModificarModelo = new FrmNuevoModificarModelo(this, "N");
            frmNuevoModificarModelo.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvModelos.Rows.Count > 0)
            {
                long idCatalogo = Convert.ToInt64(dgvModelos.Rows[dgvModelos.CurrentCell.RowIndex].Cells["Id"].Value);
                Catalogo catalogo = CatalogoBL.obtenerCatalogo(idCatalogo, ref error, ref mensaje);
                if (!error)
                {
                    FrmNuevoModificarModelo frmNuevoModificarModelo = new FrmNuevoModificarModelo(this, "M");
                    frmNuevoModificarModelo.llenarCbMarca();
                    frmNuevoModificarModelo.modificarModelo(catalogo);
                    frmNuevoModificarModelo.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error.", "Remotran", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvModelos.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar este modelo?", "Remotran", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    CatalogoBL.eliminarCatalogo(Convert.ToInt64(dgvModelos.Rows[dgvModelos.CurrentCell.RowIndex].Cells["Id"].Value), ref error, ref mensaje);
                    if (!error)
                    {
                        MessageBox.Show("Modelo eliminado exitosamente.", "Remotran", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error.", "Remotran", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No tiene ningún modelo.", "Remotran", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void llenarCbMarca()
        {
            List<Catalogo> marcas = CatalogoBL.obtenerTipoCatalogo(6L, ref error, ref mensaje);
            if (!error)
            {
                Catalogo catalogo = new Catalogo();
                catalogo.idCatalogo = 0L;
                catalogo.valor = "Todas";
                marcas.Insert(0, catalogo);
                cbMarca.DataSource = marcas;
                cbMarca.DisplayMember = "valor";
                cbMarca.ValueMember = "idCatalogo";
                cbMarca.SelectedValue = idMarca;
            }
            else
            {
                MessageBox.Show("Ocurrió un error.", "Remotran", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void actualizarDgvModelos()
        {
            IEnumerable dataSource = CatalogoBL.filtrarModelos(Convert.ToInt64(cbMarca.SelectedValue), txtModelo.Text.Trim(), ref error, ref mensaje);
            if (!error)
            {
                dgvModelos.DataSource = dataSource;
                dgvModelos.Columns[0].Visible = false;
            }
            else
            {
                MessageBox.Show("Ocurrió un error.", "Remotran", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
