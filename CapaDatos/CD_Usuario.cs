using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Usuario
    {
        // Listar todos los usuarios =======================================================================
        // Usuario viene desde CapaEntidad
        public List<Usuario> Listar()
        {
            // Crear lista tipada
            List<Usuario> lista = new List<Usuario> ();

            // Establecer conexion
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena)) 
            {

                try
                {
                    string query = "select IdUsuario, Documento, NombreCompleto, Correo, Clave, Estado from usuario";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    // Ejecutar
                    oconexion.Open();

                    // Leer resultado
                    // Devuelve una lista
                    using(SqlDataReader dr = cmd.ExecuteReader()) 
                    {
                        // Agregar cada usuario en la lista
                        while(dr.Read())
                        {
                            lista.Add(new Usuario()
                            {
                                IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                                Documento = dr["Documento"].ToString(),
                                NombreCompleto = dr["NombreCompleto"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                Clave = dr["Clave"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"])
                            });
                        }
                    }

                } catch (Exception e)
                {
                    Console.WriteLine(e);

                    // Si hay error, devoler lista vacia
                    lista = new List<Usuario> ();
                }

            };

        return lista;
        }
    }
}
