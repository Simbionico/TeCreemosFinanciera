using static SistemaCreditos.General.Organismo;
using System.Collections.Generic;
using SistemaCreditos.General;
using SistemaCreditos.Datos;
using System.Windows.Forms;
using System;
using System.Data;

namespace SistemaCreditos
{
    public partial class frmInicioSesion : Form
    {

        #region Atributos

        ConexionesDB _conexion;

        LineaBaseOperaciones _consultaOperaciones;

        Organismo _organismo;

        #endregion

        #region Constructores

        public frmInicioSesion()
        {
            
            InitializeComponent();

            _conexion = new ConexionesDB();

            _organismo = new Organismo();

            _consultaOperaciones = new LineaBaseOperaciones();

            _consultaOperaciones.ConexionDB = _conexion;

        }

        #endregion

        #region Eventos

        private void customButton1_Click(object sender, System.EventArgs e)
        {

            LimpiaValidaciones();

            bool tieneErrores_ = EjecutaValidaciones();

            if (!tieneErrores_)
            {

                LineaBaseOperaciones consultaOperaciones_ = new LineaBaseOperaciones();

                consultaOperaciones_.ConexionDB = _conexion;

                List<String> selec_ = new List<String> { "*" };

                Dictionary<String, Object> condicional_ = new Dictionary<string, Object> { { "t_Usuario = ", "'" + tbxUsuario.Text + "'" }, 
                                                                                            { " AND t_Contrasenia = ", "'" + Organismo.CifrarCadena(tbxContraseña.Text) + "'"} };

                DataTable resultado_ = consultaOperaciones_.RealizaConsultaEstandar(selec_, "cat000usuarios", condicional_);

                if(resultado_.Rows.Count > 0)
                {

                    frmPanelCentral nextForm = new frmPanelCentral();
                    
                    this.Hide();
                    
                    nextForm.ShowDialog();

                } else
                {

                    MessageBox.Show("El usuario o la contraseña son incorrectos");

                }

            }

        }

        #endregion

        #region Metodos

        private void LimpiaValidaciones()
        {

            lblErrorUsuaio.Text = "";

            lblErrorUsuaio.Visible = false;

            lblErrorContraseña.Text = "";

            lblErrorContraseña.Visible = false;

        }

        private bool EjecutaValidaciones()
        {

            bool tieneErrores_ = false;

            //Validate el campo usuario
            List<Organismo.TipoDatoValidacion> validacionesUsuario_ = new List<Organismo.TipoDatoValidacion> { TipoDatoValidacion.Requerido,
                                                                                                                TipoDatoValidacion.CorreoElectronico};

            Dictionary<String, Object> validacionUsuario_ = _organismo.ValidaDatos("Usuario", tbxUsuario.Text, validacionesUsuario_);

            if ((bool)validacionUsuario_["EsValido"])
            {

                List<String> listaErrores_ = (List<String>)validacionUsuario_["ListaErrores"];

                lblErrorUsuaio.Text = listaErrores_[0];

                lblErrorUsuaio.Visible = true;

                tieneErrores_ = true;

            }

            //Validate el campo contraseña
            List<Organismo.TipoDatoValidacion> validacionesContraseña_ = new List<Organismo.TipoDatoValidacion> { TipoDatoValidacion.Requerido,
                                                                                                                TipoDatoValidacion.Contraseña};

            Dictionary<String, Object> validacionContraseña_ = _organismo.ValidaDatos("Contraseña", tbxContraseña.Text, validacionesContraseña_);

            if ((bool)validacionContraseña_["EsValido"])
            {

                List<String> listaErrores_ = (List<String>)validacionContraseña_["ListaErrores"];

                lblErrorContraseña.Text = listaErrores_[0];

                lblErrorContraseña.Visible = true;

                tieneErrores_ = true;

            }

            return tieneErrores_;

        }

        #endregion

    }

}
