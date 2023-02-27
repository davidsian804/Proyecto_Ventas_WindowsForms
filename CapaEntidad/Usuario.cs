﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
	public class Usuario
	{
		public int IdUsuario { get; set; }
		public string Documento { get; set; }
		public string NombreCompleto { get; set; }
		public String Correo { get; set; }
		public String Clave { get; set; }
		public Rol oRol { get; set; }
		public bool Estado { get; set; }
		public string FechaRegistro { get; set; }
	}
}
