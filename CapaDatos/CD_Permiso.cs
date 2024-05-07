
using CapaEntidad;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System;
using System.Text;

namespace CapaDatos
{
    public class CD_Permiso
    {
        public List<Permiso> Listar(int idUsuario)
        {
            // Crear lista tipada
            List<Permiso> lista = new List<Permiso>();

            // Establecer conexion
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {

                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT p.IdRol, p.NombreMenu FROM PERMISO p");
                    query.AppendLine("INNER JOIN ROL r ON r.IdRol = p.IdRol");
                    query.AppendLine("INNER JOIN USUARIO u ON u.IdRol = r.IdRol");
                    query.AppendLine("WHERE u.IdUsuario = @idUsuario");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    cmd.CommandType = CommandType.Text;

                    // Ejecutar
                    oconexion.Open();

                    // Leer resultado
                    // Devuelve una lista
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        // Agregar cada usuario en la lista
                        while (dr.Read())
                        {
                            lista.Add(new Permiso()
                            {
                                ObjRol = new Rol() { IdRol = Convert.ToInt32(dr["IdRol"]) },
                                NombreMenu = dr["NombreMenu"].ToString(),
                            }); ;
                        }
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);

                    // Si hay error, devoler lista vacia
                    lista = new List<Permiso>();
                }

            };

            return lista;
        }
    }
}
