using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;

namespace Presentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void tsmiIniciarSesion_Click(object sender, EventArgs e)
        {
            FrmIniciarSesion frmIniciarSesion = new FrmIniciarSesion(this);
            frmIniciarSesion.frmPrincipal = this;
            frmIniciarSesion.ShowDialog();
        }

        private void tsmiCerrarSesion_Click(object sender, EventArgs e)
        {
            tsmiIniciarSesion.Visible = true;
            tsmiCerrarSesion.Visible = false;
            tsmiMantenimiento.Visible = false;
            tsmiFormulario.Visible = false;
        }

        private void tsmiSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiClientes_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes();
            frmClientes.ShowDialog();
        }

        private void tsmiMarcas_Click(object sender, EventArgs e)
        {
            FrmMarcas frmMarcas = new FrmMarcas();
            frmMarcas.ShowDialog();
        }

        private void tsmiModelos_Click(object sender, EventArgs e)
        {
            FrmModelos frmModelos = new FrmModelos();
            frmModelos.ShowDialog();
        }

        private void tsmiTrabajadores_Click(object sender, EventArgs e)
        {
            FrmTrabajadores frmTrabajadores = new FrmTrabajadores();
            frmTrabajadores.ShowDialog();
        }

        private void tsmiEquipos_Click(object sender, EventArgs e)
        {
            FrmEquipos frmEquipos = new FrmEquipos();
            frmEquipos.ShowDialog();
        }

        public void tsmiRecepcionEquipos_Click(object sender, EventArgs e)
        {
            FrmRecepcionEquipos frmRecepcionEquipos = new FrmRecepcionEquipos();
            frmRecepcionEquipos.ShowDialog();
        }

        public void visibilidadMsPrincipal() 
        {
            tsmiIniciarSesion.Visible = false;
            tsmiCerrarSesion.Visible = true;
            tsmiMantenimiento.Visible = true;
            tsmiFormulario.Visible = true;
        }
    }
}
