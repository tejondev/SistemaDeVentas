
using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_Rol
    {

        private CD_Rol obj_cd_rol = new CD_Rol();
        
        public List<Rol> Listar()
        {
            return obj_cd_rol.Listar();
        }
    }
}
