using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
	public class CapaNegocio_Permiso
	{
		private CapaDatos_Permisos objetoCapaDatos_Permiso = new CapaDatos_Permisos();

		public List<Permiso> Listar(int IdUsuario)
		{
			return objetoCapaDatos_Permiso.Listar(IdUsuario);
		}
	}
}
