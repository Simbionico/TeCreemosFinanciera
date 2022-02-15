using System.Collections.Generic;
using SistemaCreditos.Gestores;
using SistemaCreditos.Datos;
using System.Windows.Forms;
using System.Data;
using System;

namespace SistemaCreditos
{
    public partial class frmCatalogoCuentas : Form
    {

        #region Atributos

        ConexionesDB _conexionDB;

        #endregion

        #region Propiedades

        #endregion

        #region Constructor

        public frmCatalogoCuentas(ConexionesDB conexionDB_)
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

            List<String> selec_ = new List<String> { "i_Cve_Cuenta AS Clave",
                                                    "t_NumeroCuenta AS Cuenta",
                                                    "i_Saldo AS 'Saldo'",
                                                    "t_Usuario AS 'Usuario'",
                                                    "t_TipoCuenta AS 'Tipo cuenta'",
                                                    "t_Estatus AS Estatus",
                                                    "f_FechaRegistro AS Registro"};

            DataTable resultado_ = consultaOperaciones_.RealizaConsultaEstandar(selec_, "vt006cuentas");

            if (resultado_.Rows.Count > 0)
            {

                dgvCatalogoCuentas.DataSource = resultado_;

            }

        }

        #endregion

        #region Eventos

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            LineaBaseOperaciones consultaOperaciones_ = new LineaBaseOperaciones();

            consultaOperaciones_.ConexionDB = _conexionDB;

            frmAltaCuentas altaCuentas_ = new frmAltaCuentas(consultaOperaciones_, LineaBaseOperaciones.TipoOperacion.Agregar);

            altaCuentas_.Show();

        }

        private void dgvCatalogoCuentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow filaSeleccionada_ = dgvCatalogoCuentas.SelectedRows[0];

            LineaBaseOperaciones consultaOperaciones_ = new LineaBaseOperaciones();

            consultaOperaciones_.ConexionDB = _conexionDB;

            consultaOperaciones_.ClaveFilaSeleccionada = Convert.ToInt64(filaSeleccionada_.Cells["Clave"].Value);

            frmAltaCuentas altaCuenta_ = new frmAltaCuentas(consultaOperaciones_, LineaBaseOperaciones.TipoOperacion.Editar);

            altaCuenta_.Controls["txbNumeroCuenta"].Text = filaSeleccionada_.Cells["Cuenta"].Value.ToString();

            altaCuenta_.Controls["txbSaldo"].Text = filaSeleccionada_.Cells["Saldo"].Value.ToString();

            altaCuenta_.Controls["cbxEstatus"].Text = filaSeleccionada_.Cells["Estatus"].Value.ToString();

            altaCuenta_.Controls["cbxUsuario"].Text = filaSeleccionada_.Cells["Usuario"].Value.ToString();

            altaCuenta_.Controls["cbxTipoCuentas"].Text = filaSeleccionada_.Cells["Tipo cuenta"].Value.ToString();

            altaCuenta_.Show();

        }

        #endregion

    }

}
