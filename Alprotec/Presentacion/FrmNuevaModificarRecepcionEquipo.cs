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
    public partial class FrmNuevaModificarRecepcionEquipo : Form
    {
        private FrmRecepcionEquipos frmRecepcionEquipos;

        private String operacion;

        private bool busqueda = false;

        private bool error = false;

        private String mensaje = String.Empty;

        private Cliente cliente;

        private Equipo equipo;

        private RecepcionEquipo recepcionEquipo = new RecepcionEquipo();

        public FrmNuevaModificarRecepcionEquipo()
        {
            InitializeComponent();
        }

        public FrmNuevaModificarRecepcionEquipo(FrmRecepcionEquipos frmRecepcionEquipos, String operacion)
        {
            InitializeComponent();
            this.frmRecepcionEquipos = frmRecepcionEquipos;
            this.operacion = operacion;
        }

        private void FrmNuevaModificarRecepcionEquipo_Load(object sender, EventArgs e)
        {
            dgvEstadoElementosExternos.Rows.Add();
            dgvEstadoElementosExternos.Rows[0].Cells["elemento"].Value = "Estator";
            dgvEstadoElementosExternos.Rows[0].Cells["estado"].Value = "Ninguno";
            dgvEstadoElementosExternos.Rows.Add();
            dgvEstadoElementosExternos.Rows[1].Cells["elemento"].Value = "Rotor";
            dgvEstadoElementosExternos.Rows[1].Cells["estado"].Value = "Ninguno";
            dgvEstadoElementosExternos.Rows.Add();
            dgvEstadoElementosExternos.Rows[2].Cells["elemento"].Value = "Posición de la caja de conexión - Izquierda";
            dgvEstadoElementosExternos.Rows[2].Cells["estado"].Value = "Ninguno";
            dgvEstadoElementosExternos.Rows.Add();
            dgvEstadoElementosExternos.Rows[3].Cells["elemento"].Value = "Posición de la caja de conexión - Derecha";
            dgvEstadoElementosExternos.Rows[3].Cells["estado"].Value = "Ninguno";
            dgvEstadoElementosExternos.Rows.Add();
            dgvEstadoElementosExternos.Rows[4].Cells["elemento"].Value = "Base de la caja de conexión";
            dgvEstadoElementosExternos.Rows[4].Cells["estado"].Value = "Ninguno";
            dgvEstadoElementosExternos.Rows.Add();
            dgvEstadoElementosExternos.Rows[5].Cells["elemento"].Value = "Ventilador";
            dgvEstadoElementosExternos.Rows[5].Cells["estado"].Value = "Ninguno";
            dgvEstadoElementosExternos.Rows.Add();
            dgvEstadoElementosExternos.Rows[6].Cells["elemento"].Value = "Tapa del ventilador";
            dgvEstadoElementosExternos.Rows[6].Cells["estado"].Value = "Ninguno";
            dgvEstadoElementosExternos.Rows.Add();
            dgvEstadoElementosExternos.Rows[7].Cells["elemento"].Value = "Tapa frontal";
            dgvEstadoElementosExternos.Rows[7].Cells["estado"].Value = "Ninguno";
            dgvEstadoElementosExternos.Rows.Add();
            dgvEstadoElementosExternos.Rows[8].Cells["elemento"].Value = "Tapa posterior";
            dgvEstadoElementosExternos.Rows[8].Cells["estado"].Value = "Ninguno";
            dgvEstadoElementosExternos.Rows.Add();
            dgvEstadoElementosExternos.Rows[9].Cells["elemento"].Value = "Polea";
            dgvEstadoElementosExternos.Rows[9].Cells["estado"].Value = "Ninguno";
            dgvEstadoElementosExternos.Rows.Add();
            dgvEstadoElementosExternos.Rows[10].Cells["elemento"].Value = "Acople";
            dgvEstadoElementosExternos.Rows[10].Cells["estado"].Value = "Ninguno";
            dgvEstadoElementosExternos.Rows.Add();
            dgvEstadoElementosExternos.Rows[11].Cells["elemento"].Value = "Base del motor";
            dgvEstadoElementosExternos.Rows[11].Cells["estado"].Value = "Ninguno";
            dgvEstadoElementosExternos.Rows.Add();
            dgvEstadoElementosExternos.Rows[12].Cells["elemento"].Value = "Capacitor de arranque";
            dgvEstadoElementosExternos.Rows[12].Cells["estado"].Value = "Ninguno";
            dgvEstadoElementosExternos.Rows.Add();
            dgvEstadoElementosExternos.Rows[13].Cells["elemento"].Value = "Capacitor permanente";
            dgvEstadoElementosExternos.Rows[13].Cells["estado"].Value = "Ninguno";
            dgvEstadoElementosExternos.Rows.Add();
            dgvEstadoElementosExternos.Rows[14].Cells["elemento"].Value = "Centrífugo";
            dgvEstadoElementosExternos.Rows[14].Cells["estado"].Value = "Ninguno";
            dgvEstadoElementosExternos.Rows.Add();
            dgvEstadoElementosExternos.Rows[15].Cells["elemento"].Value = "Platinera";
            dgvEstadoElementosExternos.Rows[15].Cells["estado"].Value = "Ninguno";
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes(this, true);
            frmClientes.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                switch (operacion)
                {
                    case "N":
                        RecepcionEquipoBL.insertarRecepcionEquipo(objetoRecepcionEquipo(), ref error, ref mensaje);
                        break;
                    case "M":
                        RecepcionEquipoBL.actualizarRecepcionEquipo(objetoRecepcionEquipo(), ref error, ref mensaje);
                        break;
                }
                if (!error)
                {
                    if (!busqueda)
                    {
                        //frmRecepcionEquipos.actualizarDgvRecepcionEquipos();
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
                        DialogResult result = MessageBox.Show(mensaje, "Remotran", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                        {
                            //frmNuevaModificarRecepcionEquipo.establecerEquipo = equipo;
                            //frmNuevaModificarRecepcionEquipo.llenarTxtEquipo();
                            this.Close();
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

        public Equipo establecerEquipo
        {
            set
            {
                this.equipo = value;
            }
        }

        public void llenarTxtEquipo()
        {
            txtEquipo.Text = equipo.codigoInterno;
        }

        private RecepcionEquipo objetoRecepcionEquipo()
        {
            recepcionEquipo.numero = Convert.ToInt32(txtNumero.Text.Trim());
            recepcionEquipo.existeEstator = Convert.ToBoolean(dgvEstadoElementosExternos.Rows[0].Cells["existe"].Value);
            recepcionEquipo.estadoEstator = Convert.ToString(dgvEstadoElementosExternos.Rows[0].Cells["estado"].Value).Equals("Bueno") ? 1 : Convert.ToString(dgvEstadoElementosExternos.Rows[0].Cells["estado"].Value).Equals("Regular") ? 2 : Convert.ToString(dgvEstadoElementosExternos.Rows[0].Cells["estado"].Value).Equals("Malo") ? 3 : 0;
            recepcionEquipo.existeRotor = Convert.ToBoolean(dgvEstadoElementosExternos.Rows[1].Cells["existe"].Value);
            recepcionEquipo.estadoRotor = Convert.ToString(dgvEstadoElementosExternos.Rows[1].Cells["estado"].Value).Equals("Bueno") ? 1 : Convert.ToString(dgvEstadoElementosExternos.Rows[0].Cells["estado"].Value).Equals("Regular") ? 2 : Convert.ToString(dgvEstadoElementosExternos.Rows[1].Cells["estado"].Value).Equals("Malo") ? 3 : 0;
            recepcionEquipo.posicionCajaConexion = Convert.ToBoolean(dgvEstadoElementosExternos.Rows[2].Cells["existe"].Value) ? 1 : Convert.ToBoolean(dgvEstadoElementosExternos.Rows[3].Cells["existe"].Value) ? 2 : 0;
            recepcionEquipo.existeCajaConexion = recepcionEquipo.posicionCajaConexion != 0 ? true : false;
            recepcionEquipo.estadoCajaConexion = recepcionEquipo.posicionCajaConexion == 1 ? Convert.ToString(dgvEstadoElementosExternos.Rows[2].Cells["estado"].Value).Equals("Bueno") ? 1 : Convert.ToString(dgvEstadoElementosExternos.Rows[2].Cells["estado"].Value).Equals("Regular") ? 2 : Convert.ToString(dgvEstadoElementosExternos.Rows[2].Cells["estado"].Value).Equals("Malo") ? 3 : 0 : recepcionEquipo.posicionCajaConexion == 2 ? Convert.ToString(dgvEstadoElementosExternos.Rows[3].Cells["estado"].Value).Equals("Bueno") ? 1 : Convert.ToString(dgvEstadoElementosExternos.Rows[3].Cells["estado"].Value).Equals("Regular") ? 2 : Convert.ToString(dgvEstadoElementosExternos.Rows[2].Cells["estado"].Value).Equals("Malo") ? 3 : 0 : 0;
            recepcionEquipo.existeBaseCajaConexion = Convert.ToBoolean(dgvEstadoElementosExternos.Rows[4].Cells["existe"].Value);
            recepcionEquipo.estadoBaseCajaConexion = Convert.ToString(dgvEstadoElementosExternos.Rows[4].Cells["estado"].Value).Equals("Bueno") ? 1 : Convert.ToString(dgvEstadoElementosExternos.Rows[4].Cells["estado"].Value).Equals("Regular") ? 2 : Convert.ToString(dgvEstadoElementosExternos.Rows[4].Cells["estado"].Value).Equals("Malo") ? 3 : 0;
            recepcionEquipo.existeVentilador = Convert.ToBoolean(dgvEstadoElementosExternos.Rows[5].Cells["existe"].Value);
            recepcionEquipo.estadoVentilador = Convert.ToString(dgvEstadoElementosExternos.Rows[5].Cells["estado"].Value).Equals("Bueno") ? 1 : Convert.ToString(dgvEstadoElementosExternos.Rows[5].Cells["estado"].Value).Equals("Regular") ? 2 : Convert.ToString(dgvEstadoElementosExternos.Rows[5].Cells["estado"].Value).Equals("Malo") ? 3 : 0;
            recepcionEquipo.existeTapaVentilador = Convert.ToBoolean(dgvEstadoElementosExternos.Rows[6].Cells["existe"].Value); ;
            recepcionEquipo.estadoTapaVentilador = Convert.ToString(dgvEstadoElementosExternos.Rows[6].Cells["estado"].Value).Equals("Bueno") ? 1 : Convert.ToString(dgvEstadoElementosExternos.Rows[6].Cells["estado"].Value).Equals("Regular") ? 2 : Convert.ToString(dgvEstadoElementosExternos.Rows[6].Cells["estado"].Value).Equals("Malo") ? 3 : 0;
            recepcionEquipo.existeTapaFrontal = Convert.ToBoolean(dgvEstadoElementosExternos.Rows[7].Cells["existe"].Value);
            recepcionEquipo.estadoTapaFrontal = Convert.ToString(dgvEstadoElementosExternos.Rows[7].Cells["estado"].Value).Equals("Bueno") ? 1 : Convert.ToString(dgvEstadoElementosExternos.Rows[7].Cells["estado"].Value).Equals("Regular") ? 2 : Convert.ToString(dgvEstadoElementosExternos.Rows[7].Cells["estado"].Value).Equals("Malo") ? 3 : 0;
            recepcionEquipo.existeTapaPosterior = Convert.ToBoolean(dgvEstadoElementosExternos.Rows[8].Cells["existe"].Value);
            recepcionEquipo.estadoTapaPosterior = Convert.ToString(dgvEstadoElementosExternos.Rows[8].Cells["estado"].Value).Equals("Bueno") ? 1 : Convert.ToString(dgvEstadoElementosExternos.Rows[8].Cells["estado"].Value).Equals("Regular") ? 2 : Convert.ToString(dgvEstadoElementosExternos.Rows[8].Cells["estado"].Value).Equals("Malo") ? 3 : 0;
            recepcionEquipo.existePolea = Convert.ToBoolean(dgvEstadoElementosExternos.Rows[9].Cells["existe"].Value);
            recepcionEquipo.estadoPolea = Convert.ToString(dgvEstadoElementosExternos.Rows[9].Cells["estado"].Value).Equals("Bueno") ? 1 : Convert.ToString(dgvEstadoElementosExternos.Rows[9].Cells["estado"].Value).Equals("Regular") ? 2 : Convert.ToString(dgvEstadoElementosExternos.Rows[9].Cells["estado"].Value).Equals("Malo") ? 3 : 0;
            recepcionEquipo.existeAcople = Convert.ToBoolean(dgvEstadoElementosExternos.Rows[10].Cells["existe"].Value);
            recepcionEquipo.estadoAcople = Convert.ToString(dgvEstadoElementosExternos.Rows[10].Cells["estado"].Value).Equals("Bueno") ? 1 : Convert.ToString(dgvEstadoElementosExternos.Rows[10].Cells["estado"].Value).Equals("Regular") ? 2 : Convert.ToString(dgvEstadoElementosExternos.Rows[10].Cells["estado"].Value).Equals("Malo") ? 3 : 0;
            recepcionEquipo.existeBaseMotor = Convert.ToBoolean(dgvEstadoElementosExternos.Rows[11].Cells["existe"].Value);
            recepcionEquipo.estadoBaseMotor = Convert.ToString(dgvEstadoElementosExternos.Rows[11].Cells["estado"].Value).Equals("Bueno") ? 1 : Convert.ToString(dgvEstadoElementosExternos.Rows[11].Cells["estado"].Value).Equals("Regular") ? 2 : Convert.ToString(dgvEstadoElementosExternos.Rows[11].Cells["estado"].Value).Equals("Malo") ? 3 : 0;
            recepcionEquipo.existeCapacitorArranque = Convert.ToBoolean(dgvEstadoElementosExternos.Rows[12].Cells["existe"].Value);
            recepcionEquipo.estadoCapacitorArranque = Convert.ToString(dgvEstadoElementosExternos.Rows[12].Cells["estado"].Value).Equals("Bueno") ? 1 : Convert.ToString(dgvEstadoElementosExternos.Rows[12].Cells["estado"].Value).Equals("Regular") ? 2 : Convert.ToString(dgvEstadoElementosExternos.Rows[12].Cells["estado"].Value).Equals("Malo") ? 3 : 0;
            recepcionEquipo.existeCapacitorPermanente = Convert.ToBoolean(dgvEstadoElementosExternos.Rows[13].Cells["existe"].Value);
            recepcionEquipo.estadoCapacitorPermanente = Convert.ToString(dgvEstadoElementosExternos.Rows[13].Cells["estado"].Value).Equals("Bueno") ? 1 : Convert.ToString(dgvEstadoElementosExternos.Rows[13].Cells["estado"].Value).Equals("Regular") ? 2 : Convert.ToString(dgvEstadoElementosExternos.Rows[13].Cells["estado"].Value).Equals("Malo") ? 3 : 0;
            recepcionEquipo.existeCentrifugo = Convert.ToBoolean(dgvEstadoElementosExternos.Rows[14].Cells["existe"].Value);
            recepcionEquipo.estadoCentrifugo = Convert.ToString(dgvEstadoElementosExternos.Rows[14].Cells["estado"].Value).Equals("Bueno") ? 1 : Convert.ToString(dgvEstadoElementosExternos.Rows[14].Cells["estado"].Value).Equals("Regular") ? 2 : Convert.ToString(dgvEstadoElementosExternos.Rows[14].Cells["estado"].Value).Equals("Malo") ? 3 : 0;
            recepcionEquipo.existePlatinera = Convert.ToBoolean(dgvEstadoElementosExternos.Rows[15].Cells["existe"].Value);
            recepcionEquipo.estadoPlatinera = Convert.ToString(dgvEstadoElementosExternos.Rows[15].Cells["estado"].Value).Equals("Bueno") ? 1 : Convert.ToString(dgvEstadoElementosExternos.Rows[15].Cells["estado"].Value).Equals("Regular") ? 2 : Convert.ToString(dgvEstadoElementosExternos.Rows[15].Cells["estado"].Value).Equals("Malo") ? 3 : 0;
            recepcionEquipo.observacionesCliente = txtObservacionesCliente.Text.Trim();
            recepcionEquipo.diagnosticoFallas = txtDiagnosticoFallas.Text.Trim();
            recepcionEquipo.idCliente = cliente.idCliente;
            recepcionEquipo.idEquipo = equipo.idEquipo;
            recepcionEquipo.creadoPor = Globales.UsuarioGlobal.idUsuario;
            recepcionEquipo.fechaCreacion = DateTime.Now;
            recepcionEquipo.modificadoPor = Globales.UsuarioGlobal.idUsuario;
            recepcionEquipo.fechaModificacion = DateTime.Now;
            return recepcionEquipo;
        }
        
        public void modificarRecepcionEquipo(RecepcionEquipo recepcionEquipo, Cliente cliente, Equipo equipo)
        {
            this.recepcionEquipo.idEquipo = recepcionEquipo.idEquipo;
        }
        
        private bool validarCampos()
        {
            bool resultado = true;
            epError.Clear();
            return resultado;
        }

        public void limpiarCampos()
        {
            txtNumero.Text = String.Empty;
            cliente = null;
            txtCliente.Text = String.Empty; 
            equipo = null;
            txtEquipo.Text = String.Empty;
            for (int i = 0; i < 16; i++)
            {
                dgvEstadoElementosExternos.Rows[i].Cells["existe"].Value = false;
                dgvEstadoElementosExternos.Rows[i].Cells["estado"].Value = "Ninguno";
            }
            txtObservacionesCliente.Text = String.Empty;
            txtDiagnosticoFallas.Text = String.Empty;
        }
    }
}
