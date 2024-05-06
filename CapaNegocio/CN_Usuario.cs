using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_Usuario
    {

        // Instanciar Clase CD_Usuario que tiene todos los metodos necesarios
        private CD_Usuario obj_cd_usuario = new CD_Usuario();

        public List<Usuario> Listar()
        {
            return obj_cd_usuario.Listar();
        }
    }
}
