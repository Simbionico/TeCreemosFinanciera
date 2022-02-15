using MySql.Data.MySqlClient;
using System;

namespace SistemaCreditos.Datos
{

    public class ConexionesDB : IConexiones
    {

        #region Atributos

        private String _servidor;

        private String _baseDatos;

        private String _usuario;

        private String _contraseña;

        private String _puerto;

        private MySqlConnection _conexion;

        #endregion

        #region Propiedades

        public string Servidor { get => _servidor; set => _servidor = value; }

        public string BaseDatos { get => _baseDatos; set => _baseDatos = value; }

        public string Usuario { get => _usuario; set => _usuario = value; }

        public string Contraseña { get => _contraseña; set => _contraseña = value; }

        public string Puerto { get => _puerto; set => _puerto = value; }

        public MySqlConnection Conexion
        {

            get
            {

                if (_conexion is null)
                {

                    Conectar();

                }

                return _conexion;

            }

        }

        #endregion

        #region Constructores

        public ConexionesDB()
        {

            _servidor = "localhost";

            _baseDatos = "tecreemos";

            _puerto = "3306";

            _usuario = "root";

            _contraseña = "";

            _conexion = null;

        }

        #endregion

        #region Metodos

        private void Conectar()
        {

            string cadenaConexion_ = "Database=" + _baseDatos + "; Data Source=" + _servidor + "; port= " + _puerto + "; User Id=" + _usuario + "; Password=" + _contraseña + "";

            _conexion = new MySqlConnection(cadenaConexion_);

            try
            {

                _conexion.Open();

                Console.WriteLine("Connection Successful");

            }
            catch (Exception e_)
            {

                Console.WriteLine(e_.Message + cadenaConexion_);

            }

        }

        public void CerrarConexion()
        {

            _conexion.Close();

        }

        #endregion

    }

}
