using static SistemaCreditos.General.Organismo;
using System.Collections.Generic;
using SistemaCreditos.General;
using SistemaCreditos.Datos;
using System.Windows.Forms;
using System.Data;
using System;

namespace SistemaCreditos.Gestores
{
    public partial class frmAltaTransacciones : Form
    {

        #region Atributos

        Organismo _organismo;

        LineaBaseOperaciones _lineaBaseOperaciones;

        LineaBaseOperaciones.TipoOperacion _tipoOperacion;

        #endregion

        #region Propiedades

        #endregion

        #region Constructores

        public frmAltaTransacciones(LineaBaseOperaciones lineaBaseOperaciones_, LineaBaseOperaciones.TipoOperacion tipoOperacion_)
        {
            InitializeComponent();

            _organismo = new Organismo();

            _lineaBaseOperaciones = lineaBaseOperaciones_;

            switch (tipoOperacion_)
            {

                case LineaBaseOperaciones.TipoOperacion.Agregar:

                    _tipoOperacion = LineaBaseOperaciones.TipoOperacion.Agregar;

                    btnAgregar.Text = "Agregar";

                    break;

                case LineaBaseOperaciones.TipoOperacion.Editar:

                    _tipoOperacion = LineaBaseOperaciones.TipoOperacion.Editar;

                    btnAgregar.Text = "Actualizar";

                    break;

                default:

                    _tipoOperacion = LineaBaseOperaciones.TipoOperacion.SinFefinir;

                    break;

            }

            PreparaControles();

        }

        #endregion

        #region Metodos

        private void PreparaControles()
        {

            cbxUsuario.SelectedIndexChanged -= cbxUsuario_SelectedIndexChanged;

            // Carga el combobox de tipo de usuario
            Organismo.CargaComboBox(ref cbxUsuario,
                                    "Clave",
                                    "Usuario",
                                    _lineaBaseOperaciones.ConexionDB,
                                    new List<String> { "i_Cve_Usuario AS Clave", "t_Usuario AS Usuario" },
                                    "cat000usuarios",
                                    new Dictionary<string, Object> { { "i_Cve_Estado = ", 1 } });

            cbxUsuario.SelectedIndexChanged += cbxUsuario_SelectedIndexChanged;

            // Carga el combobox de tipo de usuario
            Organismo.CargaComboBox(ref cbxTipoTransaccion,
                                    "Clave",
                                    "Tipo",
                                    _lineaBaseOperaciones.ConexionDB,
                                    new List<String> { "i_Cve_TipoTransaccion AS Clave", "t_TipoTransaccion AS Tipo" },
                                    "cat006tipostransaccion",
                                    new Dictionary<string, Object> { { "i_Cve_Estado = ", 1 } });

        }

        private void LimpiaValidaciones()
        {

            lblErrorCuenta.Text = "";

            lblErrorCuenta.Visible = false;

            lblErrorMonto.Text = "";

            lblErrorMonto.Visible = false;

        }

        private bool EjecutaValidaciones()
        {

            bool tieneErrores_ = false;

            //Validate el campo cuenta
            List<Organismo.TipoDatoValidacion> validacionesCuenta_ = new List<Organismo.TipoDatoValidacion> { TipoDatoValidacion.Requerido };

            Dictionary<String, Object> validacionCuenta_ = _organismo.ValidaDatos("Cuenta", cbxCuentas.Text, validacionesCuenta_);

            if ((bool)validacionCuenta_["EsValido"])
            {

                List<String> listaErrores_ = (List<String>)validacionCuenta_["ListaErrores"];

                lblErrorCuenta.Text = listaErrores_[0];

                lblErrorCuenta.Visible = true;

                tieneErrores_ = true;

            }

            //Validate el campo usuario
            List<Organismo.TipoDatoValidacion> validacionesUsuario_ = new List<Organismo.TipoDatoValidacion> { TipoDatoValidacion.Requerido, TipoDatoValidacion.EsNumeroPositivo };

            Dictionary<String, Object> validacionUsuario_ = _organismo.ValidaDatos("Monto", txbMonto.Text, validacionesUsuario_);

            if ((bool)validacionUsuario_["EsValido"])
            {

                List<String> listaErrores_ = (List<String>)validacionUsuario_["ListaErrores"];

                lblErrorMonto.Text = listaErrores_[0];

                lblErrorMonto.Visible = true;

                tieneErrores_ = true;

            }

            return tieneErrores_;

        }

        private bool ValidaMontoTransaccionCuenta()
        {

            // Obtiene el monto actual
            List<String> selec_ = new List<String> { "i_Saldo AS Monto" };

            Dictionary<String, Object> condicional_ = new Dictionary<String, Object> { { "i_Cve_Cuenta = ", Convert.ToInt64(cbxCuentas.SelectedValue) } };

            DataTable resultado_ = _lineaBaseOperaciones.RealizaConsultaEstandar(selec_, "Cat006Cuentas", condicional_);

            float montoActual_ = float.Parse(resultado_.Rows[0]["Monto"].ToString());

            if ( float.Parse(txbMonto.Text) <= montoActual_ )
            {

                return true;

            } else
            {

                return false;

            }

        }

        private void ActualizaMontoCuenta()
        {

            // Obtiene el monto actual
            List<String> selec_ = new List<String> { "i_Saldo AS Monto"};

            Dictionary<String, Object> condicional_ = new Dictionary<String, Object> { { "i_Cve_Cuenta = ", Convert.ToInt64(cbxCuentas.SelectedValue) } };

            DataTable resultado_ = _lineaBaseOperaciones.RealizaConsultaEstandar(selec_, "Cat006Cuentas", condicional_);

            // Actualiza el monto actual
            Dictionary<String, object> camposValores_ = new Dictionary<String, object>();

            Int32 claveTipoTransaccion_ = (Int32)cbxTipoTransaccion.SelectedValue;

            float montoActualizado_;

            if (claveTipoTransaccion_ == 2)
            {

                montoActualizado_ = float.Parse(resultado_.Rows[0]["Monto"].ToString()) - float.Parse(txbMonto.Text);

            }
            else
            {

                montoActualizado_ = float.Parse(resultado_.Rows[0]["Monto"].ToString()) + float.Parse(txbMonto.Text);

            }

            camposValores_.Add("i_Saldo", montoActualizado_);

            _lineaBaseOperaciones.RealizaActualizacion("Cat006Cuentas", "i_Cve_Cuenta", Convert.ToInt64(cbxCuentas.SelectedValue), camposValores_);


        }

        private void EjecutaInsercionActualizacion()
        {

            LimpiaValidaciones();

            bool tieneErrores_ = EjecutaValidaciones();

            if (!tieneErrores_)
            {

                switch (_tipoOperacion)
                {
                    case LineaBaseOperaciones.TipoOperacion.Agregar:

                        ValidaMontoTransaccionCuenta();

                        List<String> campos_ = new List<string> { "i_Cve_Cuenta", "f_monto", "i_Cve_TipoTransaccion" };

                        List<List<Object>> listaValores_ = new List<List<Object>>();

                        listaValores_.Add(new List<Object> { cbxCuentas.SelectedValue, float.Parse(txbMonto.Text), cbxTipoTransaccion.SelectedValue });

                        Int64 claveInsertada_ = _lineaBaseOperaciones.RealizaInsercion("reg006transacciones", campos_, listaValores_);

                        if (claveInsertada_ > 0)
                        {

                            ActualizaMontoCuenta();

                            MessageBox.Show("Transacción agregada");

                        }
                        else
                        {

                            MessageBox.Show("A ocurrido un error");

                        }

                        break;

                    case LineaBaseOperaciones.TipoOperacion.Editar:

                        Dictionary<String, object> camposValores_ = new Dictionary<String, object>();

                        camposValores_.Add("i_Cve_Cuenta", cbxCuentas.SelectedValue);

                        camposValores_.Add("f_monto", float.Parse(txbMonto.Text));

                        camposValores_.Add("i_Cve_TipoTransaccion", cbxTipoTransaccion.SelectedValue);

                        bool actualizado_ = _lineaBaseOperaciones.RealizaActualizacion("reg006transacciones", "i_Cve_transaccion", _lineaBaseOperaciones.ClaveFilaSeleccionada, camposValores_);

                        if (actualizado_)
                        {

                            ActualizaMontoCuenta();

                            MessageBox.Show("La transacción fue actualizada");

                        }
                        else
                        {

                            MessageBox.Show("A ocurrido un error");

                        }

                        break;

                    default:
                        break;
                }

                this.Close();

            }

        }

        #endregion

        #region Eventos

        private void cbxUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

            cbxCuentas.DataSource = null;

            // Carga el combobox de tipo de usuario
            Organismo.CargaComboBox(ref cbxCuentas,
                                    "Clave",
                                    "Cuenta",
                                    _lineaBaseOperaciones.ConexionDB,
                                    new List<String> { "i_Cve_Cuenta AS Clave", "t_NumeroCuenta AS Cuenta" },
                                    "Cat006Cuentas",
                                    new Dictionary<string, Object> { { "i_Cve_Estado = ", 1 }, { " AND i_Cve_Usuario = ", Convert.ToInt64(cbxUsuario.SelectedValue) } });

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            Int32 claveTipoTransaccion_ = (Int32)cbxTipoTransaccion.SelectedValue;

            if(claveTipoTransaccion_ == 2)
            {

                if (ValidaMontoTransaccionCuenta())
                {

                    EjecutaInsercionActualizacion();

                } else
                {

                    MessageBox.Show("No cuenta con fondos para retirar");

                }

            } else if(claveTipoTransaccion_ == 1)
            {

                EjecutaInsercionActualizacion();

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        #endregion

    }

}
