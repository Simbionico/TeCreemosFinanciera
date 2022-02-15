using SistemaCreditos.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCreditos
{

    public partial class frmCatalogoUsuarios : Form
    {

        #region Atributos

        ConexionesDB _conexionDB;

        #endregion

        #region Propiedades

        //public ConexionesDB ConexionDB { set => _conexionDB = value; }

        #endregion

        #region Constructor

        public frmCatalogoUsuarios(ConexionesDB conexionDB_)
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

            List<String> selec_ = new List<String> { "i_Cve_Usuario AS Clave", 
                                                    "t_Usuario AS Usuario",
                                                    "t_NombreUsuario AS 'Nombre usuario'",
                                                    "t_TipoUsuario AS 'Tipo usuario'",
                                                    "t_Estatus AS Estatus",
                                                    "f_FechaRegistro AS Registro"};

            DataTable resultado_ = consultaOperaciones_.RealizaConsultaEstandar(selec_, "vt000usuarios");

            if (resultado_.Rows.Count > 0)
            {

                //dgvCatalogoUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgvCatalogoUsuarios.DataSource = resultado_;

            }

        }

        #endregion

        #region Eventos

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            LineaBaseOperaciones consultaOperaciones_ = new LineaBaseOperaciones();

            consultaOperaciones_.ConexionDB = _conexionDB;

            frmAltaUsuarios altaUsuarios_ = new frmAltaUsuarios(consultaOperaciones_, LineaBaseOperaciones.TipoOperacion.Agregar);

            altaUsuarios_.Show();

        }
        
        private void dgvCatalogoUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //Int64 claveFila_ = Convert.ToInt64(dgvCatalogoUsuarios["Clave", dgvCatalogoUsuarios.SelectedRows[0].Index].Value);

            DataGridViewRow filaSeleccionada_ = dgvCatalogoUsuarios.SelectedRows[0];

            LineaBaseOperaciones consultaOperaciones_ = new LineaBaseOperaciones();

            consultaOperaciones_.ConexionDB = _conexionDB;

            consultaOperaciones_.ClaveFilaSeleccionada = Convert.ToInt64(filaSeleccionada_.Cells["Clave"].Value);

            frmAltaUsuarios altaUsuarios_ = new frmAltaUsuarios(consultaOperaciones_, LineaBaseOperaciones.TipoOperacion.Editar);

            altaUsuarios_.Controls["cbxPersona"].Text = filaSeleccionada_.Cells["Nombre usuario"].Value.ToString();

            altaUsuarios_.Controls["tbxNombreUsuario"].Text = filaSeleccionada_.Cells["Usuario"].Value.ToString();

            altaUsuarios_.Controls["cbxTipoUsuario"].Text = filaSeleccionada_.Cells["Tipo usuario"].Value.ToString();

            altaUsuarios_.Controls["cbxEstatus"].Text = filaSeleccionada_.Cells["Estatus"].Value.ToString();

            altaUsuarios_.Show();

        }

        #endregion

    }

}
