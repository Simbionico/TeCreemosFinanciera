using System.Collections.Generic;
using SistemaCreditos.Datos;
using System.Windows.Forms;
using System.Data;
using System;

using SistemaCreditos.General;

namespace SistemaCreditos
{

    public partial class frmPanelCentral : Form
    {

        #region Atributos

        ConexionesDB _conexion;

        #endregion

        #region Propiedades
        #endregion

        #region Constructores

        public frmPanelCentral()
        {
            InitializeComponent();

            //var cadenaCifrado_ = Organismo.CifrarCadena("M1Contraseñ@");

            //var cadenaDecifrada_ = Organismo.DecifrarCadena(cadenaCifrado_);

            _conexion = new ConexionesDB();

        }

        #endregion

        #region Metodos

        private void CargaForm(object formulario_)
        {
            if (this.pnlBody.Controls.Count > 0)
            {

                this.pnlBody.Controls.RemoveAt(0);

            }

            Form formularioCargado_ = formulario_ as Form;

            //if (formularioCargado_.GetType().GetProperty("ConexionDB") != null)
            //{

            //    formularioCargado_.GetType().GetProperty("ConexionDB").SetValue(formularioCargado_, _conexion, null);

            //}

            formularioCargado_.TopLevel = false;

            formularioCargado_.Dock = DockStyle.Fill;

            this.pnlBody.Controls.Add(formularioCargado_);

            this.pnlBody.Tag = formularioCargado_;

            formularioCargado_.Show();

        }

        private void ibtnHome_Click(object sender, EventArgs e)
        {

            CargaForm(new frmCatalogoInicio());

        }

        private void ibtnUsuario_Click(object sender, EventArgs e)
        {

            CargaForm(new frmCatalogoUsuarios(_conexion));

        }

        private void ibtnCuentas_Click(object sender, EventArgs e)
        {

            CargaForm(new frmCatalogoCuentas(_conexion));

        }

        private void ibtnTransacciones_Click(object sender, EventArgs e)
        {

            CargaForm(new frmCatalogoTransacciones(_conexion));

        }

        #endregion

        private void frmPanelCentral_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();

        }
    }

}
