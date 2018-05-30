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
    public partial class FrmTrabajadores : Form
    {
        public bool busqueda = false;

        private bool error = false;

        private String mensaje = String.Empty;

        private int opcion = 1;

        private FrmNuevoModificarDatosTecnicosMotorElectricoTrifasico frmNuevoModificarDatosTecnicosMotorElectricoTrifasico;
        private String tag;

        public FrmTrabajadores()
        {
            InitializeComponent();
        }

        public FrmTrabajadores(FrmNuevoModificarDatosTecnicosMotorElectricoTrifasico frmNuevoModificarDatosTecnicosMotorElectricoTrifasico, bool busqueda, String tag)
        {
            InitializeComponent();
            this.frmNuevoModificarDatosTecnicosMotorElectricoTrifasico = frmNuevoModificarDatosTecnicosMotorElectricoTrifasico;
            this.busqueda = busqueda;
            this.tag = tag;
        }

        private void FrmTrabajadores_Load(object sender, EventArgs e)
        {
            actualizarDgvTrabajadores();
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCedulaIdentidad.Checked)
            {
                opcion = 1;
            }
            else if (rbNombre.Checked)
            {
                opcion = 2;
            }
            else
            {
                opcion = 3;
            }
            actualizarDgvTrabajadores();
        }

        private void cbTrabajador_SelectionChangeCommitted(object sender, EventArgs e)
        {
            actualizarDgvTrabajadores();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            actualizarDgvTrabajadores();
        }

        private void dgvTrabajadores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                long idTrabajador = Convert.ToInt64(dgvTrabajadores.Rows[e.RowIndex].Cells["Id"].Value);
                Trabajador trabajador = TrabajadorBL.obtenerTrabajador(idTrabajador, ref error, ref mensaje);
                if (!error)
                {
                    if (frmNuevoModificarDatosTecnicosMotorElectricoTrifasico != null)
                    {
                        frmNuevoModificarDatosTecnicosMotorElectricoTrifasico.llenarTrabajador(trabajador, tag);
                        this.Close();
                    }
                    else
                    {
                        FrmNuevoModificarTrabajador frmNuevoModificarTrabajador = new FrmNuevoModificarTrabajador(this, "M");
                        frmNuevoModificarTrabajador.modificarTrabajador(trabajador);
                        frmNuevoModificarTrabajador.ShowDialog();
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
            FrmNuevoModificarTrabajador frmNuevoModificarTrabajador = new FrmNuevoModificarTrabajador(this, "N");
            frmNuevoModificarTrabajador.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTrabajadores.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar este trabajador?", "Alprotec", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    TrabajadorBL.eliminarTrabajador(Convert.ToInt64(dgvTrabajadores.Rows[dgvTrabajadores.CurrentCell.RowIndex].Cells["Id"].Value), ref error, ref mensaje);
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
                MessageBox.Show("No tiene ningún trabajador.", "Alprotec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Formulario formulario = FormularioBL.obtenerFormulario("AL-T-TR", ref error, ref mensaje);
            if (!error)
            {
                try
                {
                    AlprotecdbEntities db = new AlprotecdbEntities();
                    CRTrabajadores crTrabajadores = new CRTrabajadores();
                    crTrabajadores.SetDataSource(db.Trabajador.Select(t => new
                    {
                        CedulaIdentidad = t.cedulaIdentidad,
                        Nombre = t.nombre,
                        Cargo = t.cargo,
                        Telefono = t.telefono,
                        Movil = t.movil,
                        Direccion = t.direccion
                    }).ToList());
                    crTrabajadores.SetParameterValue("CodigoFormulario", formulario.codigo);
                    crTrabajadores.SetParameterValue("NombreFormulario", formulario.nombre);
                    crTrabajadores.SetParameterValue("AproboFormulario", formulario.aprobo);
                    crTrabajadores.SetParameterValue("NumeroEdicionFormulario", formulario.numeroEdicion.ToString());
                    FrmReportes frmReportes = new FrmReportes();
                    frmReportes.crvReportes.ReportSource = crTrabajadores;
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

        public void actualizarDgvTrabajadores()
        {
            IEnumerable dataSource = TrabajadorBL.filtrarTrabajadores(opcion, txtBuscar.Text.Trim(), ref error, ref mensaje);
            if (!error)
            {
                dgvTrabajadores.DataSource = dataSource;
                dgvTrabajadores.Columns[0].Visible = false;
            }
            else
            {
                MessageBox.Show("Ocurrió un error.", "Alprotec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
