using static SistemaCreditos.General.Organismo;
using System.Collections.Generic;
using SistemaCreditos.General;
using SistemaCreditos.Datos;
using System.Windows.Forms;
using System.Data;
using System;

namespace SistemaCreditos
{
    public partial class frmAltaUsuarios : Form
    {

        #region Atributos

        //ConexionesDB _conexionDB;

        Organismo _organismo;

        LineaBaseOperaciones _lineaBaseOperaciones;

        LineaBaseOperaciones.TipoOperacion _tipoOperacion;

        #endregion

        #region Propiedades

        //public ConexionesDB ConexionDB { set => _conexionDB = value; }

        #endregion

        #region Constructores

        public frmAltaUsuarios(LineaBaseOperaciones lineaBaseOperaciones_, LineaBaseOperaciones.TipoOperacion tipoOperacion_)
        {

            InitializeComponent();

            _organismo = new Organismo();

            //_conexionDB = conexionDB_;

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

            // Carga el combobox de personas
            Organismo.CargaComboBox(ref cbxPersona,
                                    "Clave",
                                    "Persona",
                                    _lineaBaseOperaciones.ConexionDB,
                                    new List<String> { "i_Cve_Persona AS Clave", "CONCAT(t_Nombre, ' ', t_ApellidoPaterno, ' ', t_ApellidoMaterno) AS Persona" },
                                    "cat002personas",
                                    new Dictionary<string, Object> { { "i_Cve_Estado = ", 1 } });

            // Carga el combobox de tipo de usuario
            Organismo.CargaComboBox(ref cbxTipoUsuario,
                                    "Clave",
                                    "Tipo",
                                    _lineaBaseOperaciones.ConexionDB,
                                    new List<String> { "i_Cve_TipoUsuario AS Clave", "t_TipoUsuario AS Tipo" },
                                    "cat000tipousuarios",
                                    new Dictionary<string, Object> { { "i_Cve_Estado = ", 1 } });

            // Carga el combobox de estatus
            Dictionary<Int32, String> cbxEstatusRecurso_ = new Dictionary<Int32, String>();

            cbxEstatusRecurso_.Add(1, "Habilitado");

            cbxEstatusRecurso_.Add(0, "Deshabilitado");

            cbxEstatus.DataSource = new BindingSource(cbxEstatusRecurso_, null);

            cbxEstatus.DisplayMember = "Value";

            cbxEstatus.ValueMember = "Key";
            //object selectedKey = cbxPersona.SelectedValue;

        }

        private void LimpiaValidaciones()
        {

            lblErrorUsuario.Text = "";

            lblErrorUsuario.Visible = false;

        }
        
        private bool EjecutaValidaciones()
        {

            bool tieneErrores_ = false;

            //Validate el campo usuario
            List<Organismo.TipoDatoValidacion> validacionesUsuario_ = new List<Organismo.TipoDatoValidacion> { TipoDatoValidacion.Requerido,
                                                                                                                TipoDatoValidacion.CorreoElectronico};

            Dictionary<String, Object> validacionUsuario_ = _organismo.ValidaDatos("Usuario", tbxNombreUsuario.Text, validacionesUsuario_);

            if ((bool)validacionUsuario_["EsValido"])
            {

                List<String> listaErrores_ = (List<String>)validacionUsuario_["ListaErrores"];

                lblErrorUsuario.Text = listaErrores_[0];

                lblErrorUsuario.Visible = true;

                tieneErrores_ = true;

            }

            return tieneErrores_;

        }

        #endregion

        #region Eventos

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            LimpiaValidaciones();

            bool tieneErrores_ = EjecutaValidaciones();

            if (!tieneErrores_)
            {

                switch (_tipoOperacion)
                {
                    case LineaBaseOperaciones.TipoOperacion.Agregar:

                        //LineaBaseOperaciones consultaOperaciones_ = new LineaBaseOperaciones();

                        //consultaOperaciones_.ConexionDB = _lineaBaseOperaciones.ConexionDB;

                        List<String> campos_ = new List<string> { "i_Cve_Persona", "t_Usuario", "i_Cve_TipoUsuario", "i_Cve_Estatus" };

                        List<List<Object>> listaValores_ = new List<List<Object>>();

                        listaValores_.Add(new List<Object> { cbxPersona.SelectedValue, tbxNombreUsuario.Text, cbxTipoUsuario.SelectedValue, cbxEstatus.SelectedValue });

                        Int64 claveInsertada_ = _lineaBaseOperaciones.RealizaInsercion("cat000usuarios", campos_, listaValores_);

                        if (claveInsertada_ > 0)
                        {

                            MessageBox.Show("Usuario agregado");

                        }
                        else
                        {

                            MessageBox.Show("A ocurrido un error");

                        }

                        break;

                    case LineaBaseOperaciones.TipoOperacion.Editar:

                        Dictionary<String, object> camposValores_ = new Dictionary<String, object>();

                        camposValores_.Add("i_Cve_Persona", cbxPersona.SelectedValue);
                        
                        camposValores_.Add("t_Usuario", tbxNombreUsuario.Text);
                        
                        camposValores_.Add("i_Cve_TipoUsuario", cbxTipoUsuario.SelectedValue);
                        
                        camposValores_.Add("i_Cve_Estatus", cbxEstatus.SelectedValue);

                        bool actualizado_ = _lineaBaseOperaciones.RealizaActualizacion("cat000usuarios", "i_Cve_Usuario", _lineaBaseOperaciones.ClaveFilaSeleccionada, camposValores_);

                        if (actualizado_)
                        {

                            MessageBox.Show("El usuario fue actualizado");

                        } else
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

    }

}
