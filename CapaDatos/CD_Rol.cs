
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace CapaDatos
{
    public class CD_Rol
    {
        public List<Rol> Listar()
        {
            // Crear lista tipada
            List<Rol> lista = new List<Rol>();

            // Establecer conexion
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select IdRol, Descripcion from ROL");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
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
                            lista.Add(new Rol()
                            {
                                IdRol = Convert.ToInt32(dr["IdRol"]),
                                Descripcion = dr["Descripcion"].ToString(),
                            });
                        }
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);

                    // Si hay error, devoler lista vacia
                    lista = new List<Rol>();
                }
            };
            return lista;
        }
    }
}
