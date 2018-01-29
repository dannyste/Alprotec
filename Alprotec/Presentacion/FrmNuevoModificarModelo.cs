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
using Utilidades;

namespace Presentacion
{
    public partial class FrmNuevoModificarModelo : Form
    {
        private FrmModelos frmModelos;

        private String operacion;

        private bool error = false;

        private String mensaje = String.Empty;

        private Catalogo catalogo = new Catalogo();

        public FrmNuevoModificarModelo()
        {
            InitializeComponent();
        }

        public FrmNuevoModificarModelo(FrmModelos frmModelos, String operacion)
        {
            InitializeComponent();
            this.frmModelos = frmModelos;
            this.operacion = operacion;
        }

        private void FrmNuevoModificarModelo_Load(object sender, EventArgs e)
        {
            if (operacion == "N")
            {
                llenarCbMarca();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                switch (operacion)
                {
                    case "N":
                        CatalogoBL.insertarCatalogo(objetoModelo(), ref error, ref mensaje);
                        break;
                    case "M":
                        CatalogoBL.actualizarCatalogo(objetoModelo(), ref error, ref mensaje);
                        break;
                }
                if (!error)
                {
                    frmModelos.actualizarDgvModelos();
                    switch (operacion)
                    {
                        case "N":
                            mensaje = "Modelo registado exitosamente.";
                            break;
                        case "M":
                            mensaje = "Modelo actualizado exitosamente.";
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

        public void llenarCbMarca()
        {
            List<Catalogo> marcas = CatalogoBL.obtenerTipoCatalogo((long)Constantes.Catalogo.Marca, ref error, ref mensaje);
            if (!error)
            {
                Catalogo catalogo = new Catalogo();
                catalogo.idCatalogo = 0L;
                catalogo.valor = "Seleccione una marca";
                marcas.Insert(0, catalogo);
                cbMarca.DataSource = marcas;
                cbMarca.DisplayMember = "valor";
                cbMarca.ValueMember = "idCatalogo";
            }
            else
            {
                MessageBox.Show("Ocurrió un error.", "Remotran", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Catalogo objetoModelo()
        {
            catalogo.valor = txtNombre.Text.Trim();
            catalogo.idPadre = Convert.ToInt64(cbMarca.SelectedValue);
            catalogo.idTipoCatalogo = (long)Constantes.Catalogo.Modelo;
            catalogo.creadoPor = Globales.UsuarioGlobal.idUsuario;
            catalogo.fechaCreacion = DateTime.Now;
            catalogo.modificadoPor = Globales.UsuarioGlobal.idUsuario;
            catalogo.fechaModificacion = DateTime.Now;
            return catalogo;
        }

        public void modificarModelo(Catalogo catalogo)
        {
            this.catalogo.idCatalogo = catalogo.idCatalogo;
            cbMarca.SelectedValue = catalogo.idPadre;
            txtNombre.Text = catalogo.valor;
        }

        private bool validarCampos()
        {
            bool resultado = true;
            epError.Clear();
            if (Convert.ToInt64(cbMarca.SelectedValue) == 0L)
            {
                epError.SetError(cbMarca, lbMarca.Text + " es requerido");
                resultado = false;
            }
            if (txtNombre.Text == String.Empty)
            {
                epError.SetError(txtNombre, lbNombre.Text + " es requerido");
                resultado = false;
            }
            return resultado;
        }

        private void limpiarCampos()
        {
            cbMarca.SelectedIndex = 0;
            txtNombre.Text = String.Empty;
        }
    }
}
