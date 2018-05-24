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

        private FrmNuevoModificarDatosTecnicosMotorElectricoTrifasico frmNuevoModificarDatosTecnicosMotorElectricoTrifasico;

        public FrmEquipos()
        {
            InitializeComponent();
        }

        public FrmEquipos(FrmNuevoModificarDatosTecnicosMotorElectricoTrifasico frmNuevoModificarDatosTecnicosMotorElectricoTrifasico, bool busqueda)
        {
            InitializeComponent();
            this.frmNuevoModificarDatosTecnicosMotorElectricoTrifasico = frmNuevoModificarDatosTecnicosMotorElectricoTrifasico;
            this.busqueda = busqueda;
        }

        public FrmEquipos(FrmNuevaModificarRecepcionEquipo frmNuevaModificarRecepcionEquipo, bool busqueda)
        {
            InitializeComponent();
            this.frmNuevaModificarRecepcionEquipo = frmNuevaModificarRecepcionEquipo;
            this.busqueda = busqueda;
        }

        private void FrmEquipos_Load(object sender, EventArgs e)
        {
            cbUd.SelectedIndex = 0;
            llenarCbMarca();
            actualizarDgvEquipos();
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            txtCliente.Text = String.Empty;
            nudPotencia.Value = 0;
            cbUd.SelectedIndex = 0;
            cbMarca.SelectedValue = 0L;
            actualizarDgvEquipos();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
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
                    if(frmNuevoModificarDatosTecnicosMotorElectricoTrifasico != null)
                    {
                        frmNuevoModificarDatosTecnicosMotorElectricoTrifasico.llenarEquipo(equipo);
                    }
                    else
                    {
                        frmNuevaModificarRecepcionEquipo.establecerEquipo = equipo;
                        frmNuevaModificarRecepcionEquipo.llenarTxtEquipo();
                    }
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
                    Cliente cliente = ClienteBL.obtenerCliente(equipo.idCliente, ref error, ref mensaje);
                    if (!error)
                    {
                        Catalogo modelo = CatalogoBL.obtenerCatalogo(equipo.idModeloCatalogo, ref error, ref mensaje);
                        if (!error)
                        {
                            Catalogo marca = CatalogoBL.obtenerCatalogo(Convert.ToInt64(modelo.idPadre), ref error, ref mensaje);
                            if (!error)
                            {
                                FrmNuevoModificarEquipo frmNuevoModificarEquipo = new FrmNuevoModificarEquipo(this, "M");
                                frmNuevoModificarEquipo.modificarEquipo(equipo, cliente, marca, modelo);
                                frmNuevoModificarEquipo.ShowDialog();
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
                cbMarca.SelectedValue = 0L;
            }
            else
            {
                MessageBox.Show("Ocurrió un error.", "Remotran", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void actualizarDgvEquipos()
        {
            try
            {
                IEnumerable dataSource = EquipoBL.filtrarEquipos(txtCliente.Text.Trim(), cbUd.SelectedIndex == 1 ? Convert.ToDouble(nudPotencia.Value) : 0D, cbUd.SelectedIndex == 2 ? Convert.ToDouble(nudPotencia.Value) : 0D, Convert.ToInt64(cbMarca.SelectedValue), ref error, ref mensaje);
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
            catch (Exception exception) 
            {
                MessageBox.Show("Ocurrió un error.", "Alprotec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
