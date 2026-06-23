using Libreria_Datos;

namespace LIBRERIA_SAKURA_MANGA_SHOP
{
    /// <summary>
    /// Guarda los datos del usuario que inició sesión, accesibles
    /// desde cualquier formulario o UserControl de la aplicación.
    /// </summary>
    public static class SesionActual
    {
        public static UsuarioModel UsuarioLogueado { get; set; }
    }
}
