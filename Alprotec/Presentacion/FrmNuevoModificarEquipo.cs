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
using Negocio;
using Utilidades;

namespace Presentacion
{
    public partial class FrmNuevoModificarEquipo : Form
    {
        private FrmEquipos frmEquipos;

        private String operacion;

        private bool error = false;

        private String mensaje = String.Empty;

        private Cliente cliente;

        private Catalogo marca;

        private Catalogo modelo;

        private Equipo equipo = new Equipo();

        public FrmNuevoModificarEquipo()
        {
            InitializeComponent();
        }

        public FrmNuevoModificarEquipo(FrmEquipos frmEquipos, String operacion)
        {
            InitializeComponent();
            this.frmEquipos = frmEquipos;
            this.operacion = operacion;
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes(this, true);
            frmClientes.ShowDialog();
        }

        private void btnBuscarMarca_Click(object sender, EventArgs e)
        {
            FrmMarcas frmMarcas = new FrmMarcas(this, true);
            frmMarcas.ShowDialog();
        }

        private void btnBuscarModelo_Click(object sender, EventArgs e)
        {
            if (txtMarca.Text.Trim() != String.Empty)
            {
                FrmModelos frmMarcas = new FrmModelos(this, true, marca.idCatalogo);
                frmMarcas.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una marca.", "Remotran", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                switch (operacion)
                {
                    case "N":
                        EquipoBL.insertarEquipo(objetoEquipo(), ref error, ref mensaje);
                        break;
                    case "M":
                        EquipoBL.actualizarEquipo(objetoEquipo(), ref error, ref mensaje);
                        break;
                }
                if (!error)
                {
                    frmEquipos.actualizarDgvEquipos();
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

        public Cliente establecerCliente
        {
            set
            {
                this.cliente = value;
            }
        }

        public void llenarTxtCliente()
        {
            txtCliente.Text = cliente.nombre;
        }

        public Catalogo establecerMarca
        {
            set
            {
                this.marca = value;
            }
        }

        public void llenarTxtMarca()
        {
            txtMarca.Text = marca.valor;
        }

        public Catalogo establecerModelo
        {
            set
            {
                this.modelo = value;
            }
        }

        public void llenarTxtModelo()
        {
            txtModelo.Text = modelo.valor;
        }
        
        private Equipo objetoEquipo()
        {
            equipo.codigoInterno = txtCodigoInterno.Text.Trim();
            equipo.claseMaquina = txtClaseMaquina.Text.Trim();
            equipo.numeroSerie = txtNoSerie.Text.Trim();
            equipo.rpm = Convert.ToInt32(txtRPM.Text.Trim());
            equipo.amp = Convert.ToDouble(txtAMP.Text.Trim());
            equipo.numeroInventarioCliente = txtNoInventario.Text.Trim();
            equipo.potenciaHP = Convert.ToDouble(txtPotencia.Text.Trim());
            equipo.claseAislamiento = txtClaseAislamiento.Text.Trim();
            equipo.designacionNema = txtDesignacionNema.Text.Trim();
            equipo.frame = txtFrame.Text.Trim();
            equipo.voltaje = Convert.ToInt32(txtVoltaje.Text.Trim());
            equipo.factorServicio = txtFactorServicio.Text.Trim();
            equipo.idCliente = cliente.idCliente;
            equipo.idModeloCatalogo = modelo.idCatalogo;
            equipo.estado = true;
            equipo.creadoPor = Globales.UsuarioGlobal.idUsuario;
            equipo.fechaCreacion = DateTime.Now;
            equipo.modificadoPor = Globales.UsuarioGlobal.idUsuario;
            equipo.fechaModificacion = DateTime.Now;
            return equipo;
        }
        
        public void modificarEquipo(Equipo equipo, Cliente cliente, Catalogo marca, Catalogo modelo)
        {
            this.equipo.idEquipo = equipo.idEquipo;
            this.cliente = cliente;
            txtCliente.Text = cliente.nombre;
            txtCodigoInterno.Text = equipo.codigoInterno;
            txtClaseMaquina.Text = equipo.claseMaquina;
            this.marca = marca;
            txtMarca.Text = marca.valor;
            this.modelo = modelo;
            txtModelo.Text = modelo.valor;
            txtNoSerie.Text = equipo.numeroSerie;
            txtRPM.Text = Convert.ToString(equipo.rpm);
            txtAMP.Text = Convert.ToString(equipo.amp);
            txtNoInventario.Text = equipo.numeroInventarioCliente;
            txtPotencia.Text = Convert.ToString(equipo.potenciaHP);
            txtClaseAislamiento.Text = equipo.claseAislamiento;
            txtDesignacionNema.Text = equipo.designacionNema;
            txtFrame.Text = equipo.frame;
            txtVoltaje.Text = Convert.ToString(equipo.voltaje);
            txtFactorServicio.Text = equipo.factorServicio;
        }
        
        private bool validarCampos()
        {
            bool resultado = true;
            epError.Clear();
            if (txtCliente.Text == String.Empty)
            {
                epError.SetError(txtCliente, lbCliente.Text + " es requerido");
                resultado = false;
            }
            if (txtCodigoInterno.Text == String.Empty)
            {
                epError.SetError(txtCodigoInterno, lbCodigoInterno.Text + " es requerido");
                resultado = false;
            }
            if (txtClaseMaquina.Text == String.Empty)
            {
                epError.SetError(txtClaseMaquina, lbClaseMaquina.Text + " es requerido");
                resultado = false;
            }
            if (txtMarca.Text == String.Empty)
            {
                epError.SetError(txtMarca, lbMarca.Text + " es requerido");
                resultado = false;
            }
            if (txtModelo.Text == String.Empty)
            {
                epError.SetError(txtModelo, lbModelo.Text + " es requerido");
                resultado = false;
            }
            if (txtNoSerie.Text == String.Empty)
            {
                epError.SetError(txtNoSerie, lbNoSerie.Text + " es requerido");
                resultado = false;
            }
            if (txtRPM.Text == String.Empty)
            {
                epError.SetError(txtRPM, lbRPM.Text + " es requerido");
                resultado = false;
            }
            if (txtAMP.Text == String.Empty)
            {
                epError.SetError(txtAMP, lbAMP.Text + " es requerido");
                resultado = false;
            }
            return resultado;
        }

        public void limpiarCampos()
        {
            cliente = null;
            txtCliente.Text = String.Empty;
            txtCodigoInterno.Text = String.Empty;
            txtClaseMaquina.Text = String.Empty;
            marca = null;
            txtMarca.Text = String.Empty;
            modelo = null;
            txtModelo.Text = String.Empty;
            txtNoSerie.Text = String.Empty;
            txtRPM.Text = String.Empty;
            txtAMP.Text = String.Empty;
            txtNoInventario.Text = String.Empty;
            txtPotencia.Text = String.Empty;
            txtClaseAislamiento.Text = String.Empty;
            txtDesignacionNema.Text = String.Empty;
            txtFrame.Text = String.Empty;
            txtVoltaje.Text = String.Empty;
            txtFactorServicio.Text = String.Empty;
        }
    }
}
