﻿using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static Usuario usuarioActual;
        public Inicio(Usuario objUsuario)        
        {
            //Mostrar usuario actual
            usuarioActual = objUsuario;

            InitializeComponent();
        }

		private void Inicio_Load(object sender, EventArgs e)
		{

		}
	}
}
