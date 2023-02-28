using CapaEntidad;
using CapaNegocio;
using FontAwesome.Sharp;
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
        private static IconMenuItem MenuActivo = null;
        private static Form FormActivo = null;

        public Inicio(Usuario objUsuario)        
        {
            //Mostrar usuario actual
            usuarioActual = objUsuario;

            InitializeComponent();
        }

		private void Inicio_Load(object sender, EventArgs e)
		{
			List<Permiso> listPermiso = new CapaNegocio_Permiso().Listar(usuarioActual.IdUsuario);
			foreach (IconMenuItem iconMenuItem in menu.Items)
			{
				bool Encontrado = listPermiso.Any(m => m.NombreMenu == iconMenuItem.Name);
				if (Encontrado == false)
				{
					iconMenuItem.Visible = false;
				}
			}

            lbUsuario.Text = usuarioActual.NombreCompleto;
		}

        private void AbrirFormularios(IconMenuItem menu, Form form)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            if (FormActivo != null)
            {
                FormActivo.Close();
            }

            FormActivo = form;
            form.TopLevel = false;
            form.FormBorderStyle= FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.BackColor = Color.SteelBlue;

            contenedor.Controls.Add(form);
            form.Show();

        }

		private void menuUsuario_Click(object sender, EventArgs e)
		{
            AbrirFormularios((IconMenuItem)sender, new Usuarios());
		}

		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
            AbrirFormularios(menuMantenedor, new Categoria());
		}

		private void Submenu_Producto_Click(object sender, EventArgs e)
		{
			AbrirFormularios(menuMantenedor, new Producto());
		}

		private void menuVentas_Click(object sender, EventArgs e)
		{
			AbrirFormularios((IconMenuItem)sender, new Ventas());
		}

		private void Submenu_Registrar_Click(object sender, EventArgs e)
		{
			AbrirFormularios(menuMantenedor, new Ventas());
		}

		private void Submenu_Detalles_Click(object sender, EventArgs e)
		{
			AbrirFormularios(menuMantenedor, new DetalleVenta());
		}

		private void Submenu_RegistrarCompras_Click(object sender, EventArgs e)
		{
			AbrirFormularios(menuMantenedor, new Compras());
		}

		private void Submenu_VerDetallesCompras_Click(object sender, EventArgs e)
		{
			AbrirFormularios(menuMantenedor, new DetalleCompra());
		}

		private void menuClientes_Click(object sender, EventArgs e)
		{
			AbrirFormularios((IconMenuItem)sender, new Clientes());
		}

		private void menuProveedores_Click(object sender, EventArgs e)
		{
			AbrirFormularios((IconMenuItem)sender, new Proveedores());
		}
	}
}
