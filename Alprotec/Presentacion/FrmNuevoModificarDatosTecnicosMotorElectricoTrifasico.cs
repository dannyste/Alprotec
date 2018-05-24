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
        private Trabajador trabajadorPruebasElectricasEntrada;
        private Trabajador trabajadorInspeccionMedicion;

        public FrmNuevoModificarDatosTecnicosMotorElectricoTrifasico()
        {
            InitializeComponent();
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarRecepcionEquipo_Click(object sender, EventArgs e)
        {
            FrmRecepcionEquipos frmClientes = new FrmRecepcionEquipos(this, true);
            frmClientes.ShowDialog();
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
            this.tbMontajeRodamientoRealizadoPor.Text = recepcionEquipo.numero.ToString();
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
    }
}
