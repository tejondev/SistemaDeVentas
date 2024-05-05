
namespace CapaEntidad
{
    public class Permiso
    {
        public int IdPermiso { get; set; }
        public Rol ObjRol { get; set; }
        public string NombreMenu { get; set; }
        public string FechaRegistro { get; set; }
    }
}
