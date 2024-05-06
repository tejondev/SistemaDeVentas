using System.Configuration;

namespace CapaDatos
{
    public class Conexion
    {
        // Acceder a la cadena de conexion de Presentacion
        // Accediendo utilizando el "name" 
        public static string cadena = ConfigurationManager.ConnectionStrings["cadena_conexion"].ToString();
    }
}
