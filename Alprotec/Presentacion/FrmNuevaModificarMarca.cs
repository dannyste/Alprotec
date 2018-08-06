using System;
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
using Utilidades;

namespace Presentacion
{
    public partial class FrmNuevaModificarMarca : Form
    {
        private FrmMarcas frmMarcas;

        private String operacion;

        private bool error = false;

        private String mensaje = String.Empty;

        private Catalogo catalogo = new Catalogo();

        public FrmNuevaModificarMarca()
        {
            InitializeComponent();
        }

        public FrmNuevaModificarMarca(FrmMarcas frmMarcas, String operacion)
        {
            InitializeComponent();
            this.frmMarcas = frmMarcas;
            this.operacion = operacion;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                switch (operacion)
                {
                    case "N":
                        CatalogoBL.insertarCatalogo(objetoMarca(), ref error, ref mensaje);
                        break;
                    case "M":
                        CatalogoBL.actualizarCatalogo(objetoMarca(), ref error, ref mensaje);
                        break;
                }
                if (!error)
                {
                    frmMarcas.actualizarDgvMarcas();
                    switch (operacion)
                    {
                        case "N":
                            mensaje = "Marca registada exitosamente.";
                            break;
                        case "M":
                            mensaje = "Marca actualizada exitosamente.";
                            break;
                    }
                    DialogResult result = MessageBox.Show(mensaje, "Remotran", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        switch (operacion)
                        {
                            case "N":
                                limpiarCampos();
                                break;
                            case "M":
                                this.Close();
                                break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ocurrió un error.", "Remotran", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Catalogo objetoMarca()
        {
            catalogo.valor = txtNombre.Text.Trim();
            catalogo.idTipoCatalogo = (long)Constantes.Catalogo.Marca;
            catalogo.creadoPor = Globales.UsuarioGlobal.idUsuario;
            catalogo.fechaCreacion = DateTime.Now;
            catalogo.modificadoPor = Globales.UsuarioGlobal.idUsuario;
            catalogo.fechaModificacion = DateTime.Now;
            return catalogo;
        }

        public void modificarMarca(Catalogo catalogo)
        {
            this.catalogo.idCatalogo = catalogo.idCatalogo;
            txtNombre.Text = catalogo.valor;
        }

        private bool validarCampos()
        {
            bool resultado = true;
            if (txtNombre.Text == String.Empty)
            {
                lbNombre.ForeColor = Color.Red;
                resultado = false;
            }
            return resultado;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text == String.Empty)
            {
                lbNombre.ForeColor = Color.Red;
            }
            else
            {
                lbNombre.ForeColor = Color.Black;
            }
        }

        private void limpiarCampos()
        {
            txtNombre.Text = String.Empty;
        }
    }
}
