using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

		private void btnCancelar_Click(object sender, EventArgs e)
		{
            this.Close();
		}

		private void btnInicio_Click(object sender, EventArgs e)
		{
			Usuario oUsuario = new CapaNegocio_Usuario().Listar().Where(u => u.Documento == txtDocumento.Text && u.Clave == txtClave.Text).FirstOrDefault();

			if (oUsuario != null)
			{
				Inicio inicio = new Inicio(oUsuario);
				inicio.Show();
				this.Hide();

				inicio.FormClosing += form_close;
			}
			else
			{
				MessageBox.Show("Usuario No Existe","Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}

			
		}
		private void form_close(object sender, FormClosingEventArgs e)
		{
			txtDocumento.Text= "";
			txtClave.Text = "";
			this.Show();
		}	
	}
}
