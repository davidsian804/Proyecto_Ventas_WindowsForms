using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
	public class CapaDatos_Permisos
	{
		public List<Permiso> Listar(int IdUsuario)
		{
			List<Permiso> lista = new List<Permiso>();

			using (SqlConnection oConexion = new SqlConnection(Conexion.Cadena))
			{
				try
				{

					StringBuilder query = new StringBuilder();
					query.AppendLine("select p.IdRol, p.NombreMenu from PERMISO p");
					query.AppendLine("inner join ROL r on r.IdRol = p.IdRol");
					query.AppendLine("inner join USUARIO u on u.IdRol = r.IdRol");
					query.AppendLine("where  u.IdRol = @IdUsuario");

					SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
					cmd.Parameters.AddWithValue("@IdUsuario", IdUsuario);
					cmd.CommandType = CommandType.Text;

					oConexion.Open();

					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							lista.Add(new Permiso
							{
								oRol = new Rol() { IdRol = Convert.ToInt32(reader["IdRol"]) },
								NombreMenu = reader["NombreMenu"].ToString(),
							});
						}
					}

				}
				catch (Exception ex)
				{
					lista = new List<Permiso>();
				}
			}

			return lista;

		}
	}
}
