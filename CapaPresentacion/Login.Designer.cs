namespace CapaPresentacion
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.label1 = new System.Windows.Forms.Label();
			this.txtDocumento = new System.Windows.Forms.TextBox();
			this.txtClave = new System.Windows.Forms.TextBox();
			this.iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
			this.btnInicio = new FontAwesome.Sharp.IconButton();
			this.btnCancelar = new FontAwesome.Sharp.IconButton();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Location = new System.Drawing.Point(330, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 29);
			this.label1.TabIndex = 3;
			this.label1.Text = "LOGIN";
			// 
			// txtDocumento
			// 
			this.txtDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDocumento.Location = new System.Drawing.Point(205, 118);
			this.txtDocumento.Name = "txtDocumento";
			this.txtDocumento.Size = new System.Drawing.Size(337, 24);
			this.txtDocumento.TabIndex = 4;
			// 
			// txtClave
			// 
			this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtClave.Location = new System.Drawing.Point(205, 194);
			this.txtClave.Name = "txtClave";
			this.txtClave.Size = new System.Drawing.Size(337, 24);
			this.txtClave.TabIndex = 5;
			// 
			// iconDropDownButton1
			// 
			this.iconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None;
			this.iconDropDownButton1.IconColor = System.Drawing.Color.Black;
			this.iconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconDropDownButton1.Name = "iconDropDownButton1";
			this.iconDropDownButton1.Size = new System.Drawing.Size(23, 23);
			this.iconDropDownButton1.Text = "iconDropDownButton1";
			// 
			// btnInicio
			// 
			this.btnInicio.BackColor = System.Drawing.Color.MidnightBlue;
			this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnInicio.IconChar = FontAwesome.Sharp.IconChar.Lock;
			this.btnInicio.IconColor = System.Drawing.Color.White;
			this.btnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnInicio.IconSize = 20;
			this.btnInicio.Location = new System.Drawing.Point(205, 251);
			this.btnInicio.Name = "btnInicio";
			this.btnInicio.Size = new System.Drawing.Size(164, 41);
			this.btnInicio.TabIndex = 6;
			this.btnInicio.Text = "INICIO";
			this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnInicio.UseVisualStyleBackColor = false;
			this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackColor = System.Drawing.Color.Crimson;
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
			this.btnCancelar.IconColor = System.Drawing.Color.White;
			this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnCancelar.IconSize = 20;
			this.btnCancelar.Location = new System.Drawing.Point(388, 251);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(154, 41);
			this.btnCancelar.TabIndex = 7;
			this.btnCancelar.Text = "CANCELAR";
			this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(797, 413);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnInicio);
			this.Controls.Add(this.txtClave);
			this.Controls.Add(this.txtDocumento);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "x";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtClave;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
        private FontAwesome.Sharp.IconButton btnInicio;
        private FontAwesome.Sharp.IconButton btnCancelar;
    }
}