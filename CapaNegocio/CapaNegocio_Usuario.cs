using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
	public class CapaNegocio_Usuario
	{
		private CapaDatos_Usuario objetoCapaDatos_Usuario = new CapaDatos_Usuario();

		public List<Usuario> Listar()
		{
			return objetoCapaDatos_Usuario.Listar();
		}

	}
}
