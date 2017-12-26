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
    public partial class FrmRecepcionEquipos : Form
    {
        public FrmRecepcionEquipos()
        {
            InitializeComponent();
        }

        private void FrmRecepcionEquipos_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevaModificarRecepcionEquipo frmNuevaModificarRecepcionEquipo = new FrmNuevaModificarRecepcionEquipo();
            frmNuevaModificarRecepcionEquipo.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}