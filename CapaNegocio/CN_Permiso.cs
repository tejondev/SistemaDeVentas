
using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_Permiso
    {
        private CD_Permiso obj_cd_permiso = new CD_Permiso();

        public List<Permiso> Listar(int idUsuario)
        {
            return obj_cd_permiso.Listar(idUsuario);
        }
    }
}
