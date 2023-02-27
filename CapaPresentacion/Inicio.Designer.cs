﻿namespace CapaPresentacion
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.menu = new System.Windows.Forms.MenuStrip();
			this.menuUsuario = new FontAwesome.Sharp.IconMenuItem();
			this.menuMantenedor = new FontAwesome.Sharp.IconMenuItem();
			this.menuVentas = new FontAwesome.Sharp.IconMenuItem();
			this.menuCompras = new FontAwesome.Sharp.IconMenuItem();
			this.menuClientes = new FontAwesome.Sharp.IconMenuItem();
			this.menuProveedores = new FontAwesome.Sharp.IconMenuItem();
			this.menuReportes = new FontAwesome.Sharp.IconMenuItem();
			this.menuAcerca = new FontAwesome.Sharp.IconMenuItem();
			this.menuTitulo = new System.Windows.Forms.MenuStrip();
			this.label1 = new System.Windows.Forms.Label();
			this.contenedor = new System.Windows.Forms.Panel();
			this.Usuario = new System.Windows.Forms.Label();
			this.lbUsuario = new System.Windows.Forms.Label();
			this.menu.SuspendLayout();
			this.SuspendLayout();
			// 
			// menu
			// 
			this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuario,
            this.menuMantenedor,
            this.menuVentas,
            this.menuCompras,
            this.menuClientes,
            this.menuProveedores,
            this.menuReportes,
            this.menuAcerca});
			this.menu.Location = new System.Drawing.Point(0, 54);
			this.menu.Name = "menu";
			this.menu.Size = new System.Drawing.Size(1128, 83);
			this.menu.TabIndex = 0;
			this.menu.Text = "menuStrip1";
			// 
			// menuUsuario
			// 
			this.menuUsuario.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuUsuario.IconChar = FontAwesome.Sharp.IconChar.UserLarge;
			this.menuUsuario.IconColor = System.Drawing.Color.Black;
			this.menuUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.menuUsuario.IconSize = 50;
			this.menuUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.menuUsuario.Name = "menuUsuario";
			this.menuUsuario.Size = new System.Drawing.Size(94, 79);
			this.menuUsuario.Text = "Usuarios";
			this.menuUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// menuMantenedor
			// 
			this.menuMantenedor.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuMantenedor.IconChar = FontAwesome.Sharp.IconChar.Gear;
			this.menuMantenedor.IconColor = System.Drawing.Color.Black;
			this.menuMantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.menuMantenedor.IconSize = 50;
			this.menuMantenedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.menuMantenedor.Name = "menuMantenedor";
			this.menuMantenedor.Size = new System.Drawing.Size(123, 79);
			this.menuMantenedor.Text = "Mantenedor";
			this.menuMantenedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// menuVentas
			// 
			this.menuVentas.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuVentas.IconChar = FontAwesome.Sharp.IconChar.Box;
			this.menuVentas.IconColor = System.Drawing.Color.Black;
			this.menuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.menuVentas.IconSize = 50;
			this.menuVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.menuVentas.Name = "menuVentas";
			this.menuVentas.Size = new System.Drawing.Size(78, 79);
			this.menuVentas.Text = "Ventas";
			this.menuVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// menuCompras
			// 
			this.menuCompras.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuCompras.IconChar = FontAwesome.Sharp.IconChar.Tasks;
			this.menuCompras.IconColor = System.Drawing.Color.Black;
			this.menuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.menuCompras.IconSize = 50;
			this.menuCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.menuCompras.Name = "menuCompras";
			this.menuCompras.Size = new System.Drawing.Size(98, 79);
			this.menuCompras.Text = "Compras";
			this.menuCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// menuClientes
			// 
			this.menuClientes.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuClientes.IconChar = FontAwesome.Sharp.IconChar.Users;
			this.menuClientes.IconColor = System.Drawing.Color.Black;
			this.menuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.menuClientes.IconSize = 50;
			this.menuClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.menuClientes.Name = "menuClientes";
			this.menuClientes.Size = new System.Drawing.Size(87, 79);
			this.menuClientes.Text = "Clientes";
			this.menuClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// menuProveedores
			// 
			this.menuProveedores.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuProveedores.IconChar = FontAwesome.Sharp.IconChar.PersonShelter;
			this.menuProveedores.IconColor = System.Drawing.Color.Black;
			this.menuProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.menuProveedores.IconSize = 50;
			this.menuProveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.menuProveedores.Name = "menuProveedores";
			this.menuProveedores.Size = new System.Drawing.Size(125, 79);
			this.menuProveedores.Text = "Proveedores";
			this.menuProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// menuReportes
			// 
			this.menuReportes.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuReportes.IconChar = FontAwesome.Sharp.IconChar.ListSquares;
			this.menuReportes.IconColor = System.Drawing.Color.Black;
			this.menuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.menuReportes.IconSize = 50;
			this.menuReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.menuReportes.Name = "menuReportes";
			this.menuReportes.Size = new System.Drawing.Size(96, 79);
			this.menuReportes.Text = "Reportes";
			this.menuReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// menuAcerca
			// 
			this.menuAcerca.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuAcerca.IconChar = FontAwesome.Sharp.IconChar.Info;
			this.menuAcerca.IconColor = System.Drawing.Color.Black;
			this.menuAcerca.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.menuAcerca.IconSize = 50;
			this.menuAcerca.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.menuAcerca.Name = "menuAcerca";
			this.menuAcerca.Size = new System.Drawing.Size(78, 79);
			this.menuAcerca.Text = "Acerca";
			this.menuAcerca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// menuTitulo
			// 
			this.menuTitulo.AutoSize = false;
			this.menuTitulo.BackColor = System.Drawing.Color.Navy;
			this.menuTitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuTitulo.Location = new System.Drawing.Point(0, 0);
			this.menuTitulo.Name = "menuTitulo";
			this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.menuTitulo.Size = new System.Drawing.Size(1128, 54);
			this.menuTitulo.TabIndex = 1;
			this.menuTitulo.Text = "menuStrip2";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Navy;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(220, 29);
			this.label1.TabIndex = 2;
			this.label1.Text = "SISTEMA VENTAS";
			// 
			// contenedor
			// 
			this.contenedor.BackColor = System.Drawing.SystemColors.ControlDark;
			this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.contenedor.Location = new System.Drawing.Point(0, 137);
			this.contenedor.Name = "contenedor";
			this.contenedor.Size = new System.Drawing.Size(1128, 348);
			this.contenedor.TabIndex = 3;
			// 
			// Usuario
			// 
			this.Usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Usuario.AutoSize = true;
			this.Usuario.BackColor = System.Drawing.Color.Transparent;
			this.Usuario.Location = new System.Drawing.Point(952, 22);
			this.Usuario.Name = "Usuario";
			this.Usuario.Size = new System.Drawing.Size(54, 16);
			this.Usuario.TabIndex = 4;
			this.Usuario.Text = "Usuario";
			// 
			// lbUsuario
			// 
			this.lbUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lbUsuario.AutoSize = true;
			this.lbUsuario.BackColor = System.Drawing.Color.Transparent;
			this.lbUsuario.Location = new System.Drawing.Point(1022, 22);
			this.lbUsuario.Name = "lbUsuario";
			this.lbUsuario.Size = new System.Drawing.Size(69, 16);
			this.lbUsuario.TabIndex = 5;
			this.lbUsuario.Text = "LbUsuario";
			// 
			// Inicio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1128, 485);
			this.Controls.Add(this.lbUsuario);
			this.Controls.Add(this.Usuario);
			this.Controls.Add(this.contenedor);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menu);
			this.Controls.Add(this.menuTitulo);
			this.MainMenuStrip = this.menu;
			this.Name = "Inicio";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Inicio_Load);
			this.menu.ResumeLayout(false);
			this.menu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem menuUsuario;
        private FontAwesome.Sharp.IconMenuItem menuClientes;
        private FontAwesome.Sharp.IconMenuItem menuMantenedor;
        private FontAwesome.Sharp.IconMenuItem menuProveedores;
        private FontAwesome.Sharp.IconMenuItem menuCompras;
        private FontAwesome.Sharp.IconMenuItem menuVentas;
        private FontAwesome.Sharp.IconMenuItem menuReportes;
        private FontAwesome.Sharp.IconMenuItem menuAcerca;
        private System.Windows.Forms.Panel contenedor;
		private System.Windows.Forms.Label Usuario;
		private System.Windows.Forms.Label lbUsuario;
	}
}

