using Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmNuevoModificarDatosTecnicosMotorElectricoTrifasico : Form
    {
        private RecepcionEquipo recepcionEquipo;
        private Equipo equipo;
        private Trabajador trabajadorPruebasElectricasEntrada;
        private Trabajador trabajadorInspeccionMedicion;
        private int indexPagina = 0;

        public FrmNuevoModificarDatosTecnicosMotorElectricoTrifasico()
        {
            InitializeComponent();
            this.dgvRodamientos.Rows.Add("Delantero", "", "");
            this.dgvRodamientos.Rows.Add("Trasero", "", "");
            this.dgvAlojamientos.Rows.Add("Eje D.", "", "");
            this.dgvAlojamientos.Rows.Add("Eje T.", "", "");
            this.dgvEje.Rows.Add("Tapa D.", "", "");
            this.dgvEje.Rows.Add("Tapa T.", "", "");
        }

        private void gbProcesosRequieren_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void tpPagina33_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmNuevoModificarDatosTecnicosMotorElectricoTrifasico_Load(object sender, EventArgs e)
        {

        }

  

        private void btnBuscarRecepcionEquipo_Click(object sender, EventArgs e)
        {
            //FrmRecepcionEquipos frmClientes = new FrmRecepcionEquipos(this, true);
            //frmClientes.ShowDialog();
            FrmEquipos frmEquipos = new FrmEquipos(this, true);
            frmEquipos.ShowDialog();
        }

        private void btnBuscarRealizadoPorRealizadoPorPruebasElectricasEntrada_Click(object sender, EventArgs e)
        {
            FrmTrabajadores frmTrabajadores = new FrmTrabajadores(this, true, "TrabajadorPruebasElectricasEntrada");
            frmTrabajadores.ShowDialog();
        }

        private void btnBuscarRealizadoPorInspeccionMedicion_Click(object sender, EventArgs e)
        {
            FrmTrabajadores frmTrabajadores = new FrmTrabajadores(this, true, "TrabajadorInspeccionMedicion");
            frmTrabajadores.ShowDialog();
        }

        public void llenarCodigoRecepcionEquipo(RecepcionEquipo recepcionEquipo)
        {
            this.recepcionEquipo = recepcionEquipo;
            this.txtRealizadoPorMontajeRodamientos.Text = recepcionEquipo.numero.ToString();
        }

        public void llenarEquipo(Equipo equipo)
        {
            this.equipo = equipo;
            this.txtRecepcionEquipo.Text = equipo.codigoInterno;
        }

        public void llenarTrabajador(Trabajador trabajador, String tag)
        {
            switch (tag)
            {
                case "TrabajadorPruebasElectricasEntrada":
                    this.trabajadorPruebasElectricasEntrada = trabajador;
                    this.txtRealizadoPorPruebasElectricasEntrada.Text = trabajador.nombre;
                    break;
                case "TrabajadorInspeccionMedicion":
                    this.trabajadorInspeccionMedicion = trabajador;
                    this.txtRealizadoPorInspeccionMedicion.Text = trabajador.nombre;
                    break;
            }
            
        }

        private bool validarCamposPagina1()
        {
            bool resultado = true;
            epError.Clear();

            if (!validarDataGridView(dgvRodamientos))
            {
                epError.SetError(dgvRodamientos,  "Todos los campos en la tabla son requeridos");
                resultado = false;
            }
            if (!validarDataGridView(dgvAlojamientos))
            {
                epError.SetError(dgvAlojamientos, "Todos los campos en la tabla son requeridos");
                resultado = false;
            }
            if (!validarDataGridView(dgvEje))
            {
                epError.SetError(dgvEje, "Todos los campos en la tabla son requeridos");
                resultado = false;
            }
            if (txtRecepcionEquipo.Text == String.Empty)
            {
                epError.SetError(txtRecepcionEquipo, lbRecepcionEquipo.Text + " es requerido");
                resultado = false;
            }
            if (txtRealizadoPorPruebasElectricasEntrada.Text == String.Empty)
            {
                epError.SetError(txtRealizadoPorPruebasElectricasEntrada, lbRealizadoPorPruebasElectricasEntrada.Text + " es requerido");
                resultado = false;
            }
            if (txtInspeccion.Text == String.Empty)
            {
                epError.SetError(txtInspeccion, lbInspeccion.Text + " es requerido");
                resultado = false;
            }
            if (txtResistenciaAislamiento.Text == String.Empty)
            {
                epError.SetError(txtResistenciaAislamiento, lbResistenciaAislamiento.Text + " es requerido");
                resultado = false;
            }
            if (txtVoltajePrueba.Text == String.Empty)
            {
                epError.SetError(txtVoltajePrueba, lbVoltajePrueba.Text + " es requerido");
                resultado = false;
            }
            if (txtIndicePolaridad.Text == String.Empty)
            {
                epError.SetError(txtIndicePolaridad, lbIndicePolaridad.Text + " es requerido");
                resultado = false;
            }
            if (txtlbContinuidadEntreLineas.Text == String.Empty)
            {
                epError.SetError(txtlbContinuidadEntreLineas, lbContinuidadEntreLineas.Text + " es requerido");
                resultado = false;
            }
            if (txtRealizadoPorInspeccionMedicion.Text == String.Empty)
            {
                epError.SetError(txtRealizadoPorInspeccionMedicion, lbRealizadoPorInspeccionMedicion.Text + " es requerido");
                resultado = false;
            }
            if (txtObservaciones.Text == String.Empty)
            {
                epError.SetError(txtObservaciones, lbObservaciones.Text + " es requerido");
                resultado = false;
            }
            if (txtOtros.Text == String.Empty)
            {
                epError.SetError(txtOtros, lbOtros.Text + " es requerido");
                resultado = false;
            }

       

            return resultado;
        }

        private bool validarCamposPagina2()
        {
            bool resultado = true;
            epError.Clear();

            if (txtNoRanuras.Text == String.Empty)
            {
                epError.SetError(txtNoRanuras, lbNoRanuras.Text + " es requerido");
                resultado = false;
            }
            if (txtCalibre.Text == String.Empty)
            {
                epError.SetError(txtCalibre, lbCalibre.Text + " es requerido");
                resultado = false;
            }
            if (txtNoGrupos.Text == String.Empty)
            {
                epError.SetError(txtNoGrupos, lbNoGrupos.Text + " es requerido");
                resultado = false;
            }
            if (txtHilos.Text == String.Empty)
            {
                epError.SetError(txtHilos, lbHilos.Text + " es requerido");
                resultado = false;
            }
            if (txtBobinaPorGrupo.Text == String.Empty)
            {
                epError.SetError(txtBobinaPorGrupo, lbBobinaPorGrupo.Text + " es requerido");
                resultado = false;
            }
            if (txtCabeza.Text == String.Empty)
            {
                epError.SetError(txtCabeza, lbCabeza.Text + " es requerido");
                resultado = false;
            }
            if (txtPaso.Text == String.Empty)
            {
                epError.SetError(txtPaso, lbPaso.Text + " es requerido");
                resultado = false;
            }
            if (txtHierro.Text == String.Empty)
            {
                epError.SetError(txtHierro, lbHierro.Text + " es requerido");
                resultado = false;
            }
            if (txtEspiras.Text == String.Empty)
            {
                epError.SetError(txtEspiras, lbEspiras.Text + " es requerido");
                resultado = false;
            }
            if (txtLongBobina.Text == String.Empty)
            {
                epError.SetError(txtLongBobina, lbLongBobina.Text + " es requerido");
                resultado = false;
            }
            if (txtDescripcionReparacion.Text == String.Empty)
            {
                epError.SetError(txtDescripcionReparacion, gbDescripcionReparacion.Text + " es requerido");
                resultado = false;
            }
            if (txtLadoAcople.Text == String.Empty)
            {
                epError.SetError(txtLadoAcople, lbLadoAcople.Text + " es requerido");
                resultado = false;
            }
            if (txtLadoVentilador.Text == String.Empty)
            {
                epError.SetError(txtLadoVentilador, lbLadoVentilador.Text + " es requerido");
                resultado = false;
            }

            return resultado;
        }

        private bool validarDataGridView(DataGridView dataGridView)
        {
            DataGridViewRowCollection rowCollection = dataGridView.Rows;

            foreach(DataGridViewRow row in rowCollection){
                DataGridViewCellCollection cellCollection = row.Cells;
                int i = 0;
                foreach (DataGridViewCell cell in cellCollection)
                {
                    if(i != 0)
                    {
                        if (cell.Value.ToString().Trim() == String.Empty)
                        {
                            return false;
                        }
                    }
                    i++;
                }
            }

            return true;
        }

        private void btnSiguienteGuardar_Click(object sender, EventArgs e)
        {
            switch (tcPaginas.SelectedIndex)
            {
                case 0:
                    if (validarCamposPagina1())
                    {
                        tcPaginas.SelectTab(1);
                    }
                    break;
                case 1:
                    if (validarCamposPagina2())
                    {
                        tcPaginas.SelectTab(2);
                    }
                    break;
                case 2:

                    break;
            }
        }

        private void tcPaginas_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (indexPagina)
            {
                case 0:
                    if (!validarCamposPagina1())
                    {
                        tcPaginas.SelectTab(0);
                    }
                    else
                    {
                        indexPagina = tcPaginas.SelectedIndex;
                    }
                    break;
                case 1:
                    if (!validarCamposPagina2())
                    {
                        tcPaginas.SelectTab(1);
                    }
                    else
                    {
                        indexPagina = tcPaginas.SelectedIndex;
                    }
                    break;
                case 2:

                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Debería preguntar si está seguro de cerrar la ventana, 
            //se perderán los datos ingresados
            this.Close();
        }

        private void tcPaginas_TabIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
