namespace SistemaCreditos.Datos
{

    public interface IConexiones
    {

        #region Propiedades

        string Servidor { get; set; }

        string BaseDatos { get; set; }

        string Usuario { get; set; }

        string Contraseña { get; set; }

        string Puerto { get; set; }

        #endregion

    }

}
