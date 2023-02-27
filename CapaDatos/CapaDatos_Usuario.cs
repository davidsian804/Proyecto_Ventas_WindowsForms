using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
	public class CapaDatos_Usuario
	{
		public List<Usuario> Listar() 
		{
			List<Usuario> lista = new List<Usuario>();

			using (SqlConnection oConexion = new SqlConnection(Conexion.Cadena)) 
			{
				try
				{
					string query = "Select IdUsuario, Documento, NombreCompleto, Correo, Clave, Estado From USUARIO";

					SqlCommand cmd = new SqlCommand(query, oConexion);
					cmd.CommandType = CommandType.Text;

					oConexion.Open();

					using (SqlDataReader reader = cmd.ExecuteReader()) 
					{
						while (reader.Read()) 
						{
							lista.Add(new Usuario {
								IdUsuario = Convert.ToInt32(reader["IdUsuario"]),
								Documento = reader["Documento"].ToString(),
								NombreCompleto = reader["NombreCompleto"].ToString(),
								Correo = reader["Correo"].ToString(),
								Clave = reader["Clave"].ToString(),
								Estado = Convert.ToBoolean(reader["Estado"])
							});
						}
					}

				}
				catch (Exception ex)
				{
					lista = new List<Usuario>();
				}
			}

			return lista;

		}
	}
}
