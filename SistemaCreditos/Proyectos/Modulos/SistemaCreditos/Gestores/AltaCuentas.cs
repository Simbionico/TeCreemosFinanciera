using static SistemaCreditos.General.Organismo;
using System.Collections.Generic;
using SistemaCreditos.General;
using SistemaCreditos.Datos;
using System.Windows.Forms;
using System.Data;
using System;

namespace SistemaCreditos.Gestores
{
    
    public partial class frmAltaCuentas : Form
    {

        #region Atributos

        Organismo _organismo;

        LineaBaseOperaciones _lineaBaseOperaciones;

        LineaBaseOperaciones.TipoOperacion _tipoOperacion;

        #endregion

        #region Propiedades

        #endregion

        #region Constructores

        public frmAltaCuentas(LineaBaseOperaciones lineaBaseOperaciones_, LineaBaseOperaciones.TipoOperacion tipoOperacion_)
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

            // Carga saldo
            txbSaldo.Text = "0";

            // Carga el combobox de tipo de usuario
            Organismo.CargaComboBox(ref cbxUsuario,
                                    "Clave",
                                    "Usuario",
                                    _lineaBaseOperaciones.ConexionDB,
                                    new List<String> { "i_Cve_Usuario AS Clave", "t_Usuario AS Usuario" },
                                    "cat000usuarios",
                                    new Dictionary<string, Object> { { "i_Cve_Estado = ", 1 } });

            // Carga el combobox de personas
            Organismo.CargaComboBox(ref cbxTipoCuentas,
                                    "Clave",
                                    "Tipo",
                                    _lineaBaseOperaciones.ConexionDB,
                                    new List<String> { "i_Cve_TipoCuenta AS Clave", "t_TipoCuenta AS Tipo" },
                                    "cat006TipoCuentas",
                                    new Dictionary<string, Object> { { "i_Cve_Estado = ", 1 } });

            // Carga el combobox de estatus
            Dictionary<Int32, String> cbxEstatusRecurso_ = new Dictionary<Int32, String>();

            cbxEstatusRecurso_.Add(1, "Habilitado");

            cbxEstatusRecurso_.Add(0, "Deshabilitado");

            cbxEstatus.DataSource = new BindingSource(cbxEstatusRecurso_, null);

            cbxEstatus.DisplayMember = "Value";

            cbxEstatus.ValueMember = "Key";

            // Número de cuenta: año + clave usuario + tipo cuenta + numero aleatorio: 2022-000001-1-100
            Random random_ = new Random();

            String numeroAleatorio_ = random_.Next(0, 100000).ToString();

            txbNumeroCuenta.Text = (numeroAleatorio_ + "000000000000").Substring(0, 12);

        }

        private void LimpiaValidaciones()
        {

        }

        private bool EjecutaValidaciones()
        {

            bool tieneErrores_ = false;

            return tieneErrores_;

        }

        #endregion

        #region Eventos

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            LimpiaValidaciones();

            bool tieneErrores_ = EjecutaValidaciones();

            if (!tieneErrores_)
            {

                switch (_tipoOperacion)
                {
                    case LineaBaseOperaciones.TipoOperacion.Agregar:

                        List<String> campos_ = new List<string> { "t_NumeroCuenta", "i_Saldo", "i_Cve_Estatus", "i_Cve_Usuario", "i_Cve_TipoCuenta" };

                        List<List<Object>> listaValores_ = new List<List<Object>>();

                        listaValores_.Add(new List<Object> { txbNumeroCuenta.Text, float.Parse(txbSaldo.Text), cbxEstatus.SelectedValue, cbxUsuario.SelectedValue, cbxTipoCuentas.SelectedValue });

                        Int64 claveInsertada_ = _lineaBaseOperaciones.RealizaInsercion("Cat006Cuentas", campos_, listaValores_);

                        if (claveInsertada_ > 0)
                        {

                            MessageBox.Show("Cuenta agregada");

                        }
                        else
                        {

                            MessageBox.Show("A ocurrido un error");

                        }

                        break;

                    case LineaBaseOperaciones.TipoOperacion.Editar:

                        Dictionary<String, object> camposValores_ = new Dictionary<String, object>();

                        camposValores_.Add("t_NumeroCuenta", txbNumeroCuenta.Text);

                        camposValores_.Add("i_Saldo", float.Parse(txbSaldo.Text));

                        camposValores_.Add("i_Cve_Estatus", cbxEstatus.SelectedValue);

                        camposValores_.Add("i_Cve_Usuario", cbxUsuario.SelectedValue);

                        camposValores_.Add("i_Cve_TipoCuenta", cbxTipoCuentas.SelectedValue);

                        bool actualizado_ = _lineaBaseOperaciones.RealizaActualizacion("Cat006Cuentas", "i_Cve_Cuenta", _lineaBaseOperaciones.ClaveFilaSeleccionada, camposValores_);

                        if (actualizado_)
                        {

                            MessageBox.Show("la cuenta fue actualizada");

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        #endregion

    }

}
