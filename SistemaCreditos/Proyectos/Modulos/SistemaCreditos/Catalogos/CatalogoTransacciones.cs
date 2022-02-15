using System.Collections.Generic;
using SistemaCreditos.Gestores;
using SistemaCreditos.Datos;
using System.Windows.Forms;
using System.Data;
using System;

namespace SistemaCreditos
{

    public partial class frmCatalogoTransacciones : Form
    {

        #region Atributos

        ConexionesDB _conexionDB;

        #endregion

        #region Propiedades

        #endregion

        #region Constructor

        public frmCatalogoTransacciones(ConexionesDB conexionDB_)
        {

            InitializeComponent();

            _conexionDB = conexionDB_;

            CargaCatalogo();

        }

        #endregion

        #region Metodos

        private void CargaCatalogo()
        {

            LineaBaseOperaciones consultaOperaciones_ = new LineaBaseOperaciones();

            consultaOperaciones_.ConexionDB = _conexionDB;

            List<String> selec_ = new List<String> { "i_Cve_transaccion AS Clave",
                                                    "t_NumeroCuenta AS Cuenta",
                                                    "f_monto AS 'Monto'",
                                                    "t_TipoTransaccion AS 'Tipo transaccion'",
                                                    "t_Usuario AS 'Usuario'",
                                                    "f_FechaRegistro AS Registro"};

            DataTable resultado_ = consultaOperaciones_.RealizaConsultaEstandar(selec_, "vt006transacciones");

            if (resultado_.Rows.Count > 0)
            {

                dgvCatalogoTransacciones.DataSource = resultado_;

            }

        }

        #endregion

        #region Eventos

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            LineaBaseOperaciones consultaOperaciones_ = new LineaBaseOperaciones();

            consultaOperaciones_.ConexionDB = _conexionDB;

            frmAltaTransacciones altaTransaccion_ = new frmAltaTransacciones(consultaOperaciones_, LineaBaseOperaciones.TipoOperacion.Agregar);

            altaTransaccion_.Show();

        }

        private void dgvCatalogoTransacciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow filaSeleccionada_ = dgvCatalogoTransacciones.SelectedRows[0];

            LineaBaseOperaciones consultaOperaciones_ = new LineaBaseOperaciones();

            consultaOperaciones_.ConexionDB = _conexionDB;

            consultaOperaciones_.ClaveFilaSeleccionada = Convert.ToInt64(filaSeleccionada_.Cells["Clave"].Value);

            frmAltaTransacciones altaTransaccion_ = new frmAltaTransacciones(consultaOperaciones_, LineaBaseOperaciones.TipoOperacion.Editar);

            altaTransaccion_.Controls["cbxUsuario"].Text = filaSeleccionada_.Cells["Usuario"].Value.ToString();

            altaTransaccion_.Controls["cbxCuentas"].Text = filaSeleccionada_.Cells["Cuenta"].Value.ToString();

            altaTransaccion_.Controls["txbMonto"].Text = filaSeleccionada_.Cells["Monto"].Value.ToString();

            altaTransaccion_.Controls["cbxTipoTransaccion"].Text = filaSeleccionada_.Cells["Tipo transaccion"].Value.ToString();

            altaTransaccion_.Show();

        }

        #endregion

    }

}
