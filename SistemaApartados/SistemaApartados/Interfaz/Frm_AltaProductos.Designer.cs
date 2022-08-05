namespace SistemaApartados
{
    partial class Frm_AltaProductos
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.TxtNombre_Producto = new System.Windows.Forms.TextBox();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.CbTipo_Producto = new System.Windows.Forms.ComboBox();
            this.CbMarca = new System.Windows.Forms.ComboBox();
            this.CbEspecie = new System.Windows.Forms.ComboBox();
            this.BtnGuardarProducto = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnGenerar_Clave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Especie:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio unitario:";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(191, 217);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(71, 27);
            this.lblClave.TabIndex = 6;
            this.lblClave.Text = "Clave";
            // 
            // TxtNombre_Producto
            // 
            this.TxtNombre_Producto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre_Producto.Location = new System.Drawing.Point(196, 15);
            this.TxtNombre_Producto.Name = "TxtNombre_Producto";
            this.TxtNombre_Producto.ShortcutsEnabled = false;
            this.TxtNombre_Producto.Size = new System.Drawing.Size(177, 26);
            this.TxtNombre_Producto.TabIndex = 1;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecio.Location = new System.Drawing.Point(196, 163);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.ShortcutsEnabled = false;
            this.TxtPrecio.Size = new System.Drawing.Size(177, 26);
            this.TxtPrecio.TabIndex = 5;
            this.TxtPrecio.TextChanged += new System.EventHandler(this.TxtPrecio_TextChanged);
            this.TxtPrecio.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtPrecio_KeyUp);
            // 
            // CbTipo_Producto
            // 
            this.CbTipo_Producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTipo_Producto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbTipo_Producto.FormattingEnabled = true;
            this.CbTipo_Producto.Items.AddRange(new object[] {
            "Alimentos",
            "Cereales",
            "Semillas"});
            this.CbTipo_Producto.Location = new System.Drawing.Point(196, 54);
            this.CbTipo_Producto.Name = "CbTipo_Producto";
            this.CbTipo_Producto.Size = new System.Drawing.Size(177, 26);
            this.CbTipo_Producto.TabIndex = 2;
            // 
            // CbMarca
            // 
            this.CbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbMarca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbMarca.FormattingEnabled = true;
            this.CbMarca.Items.AddRange(new object[] {
            "Otra",
            "Purina",
            "SabAmex"});
            this.CbMarca.Location = new System.Drawing.Point(196, 89);
            this.CbMarca.Name = "CbMarca";
            this.CbMarca.Size = new System.Drawing.Size(177, 26);
            this.CbMarca.TabIndex = 3;
            // 
            // CbEspecie
            // 
            this.CbEspecie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbEspecie.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbEspecie.FormattingEnabled = true;
            this.CbEspecie.Items.AddRange(new object[] {
            "Bovino",
            "Caprino",
            "Domesticos",
            "Equino",
            "Ovino",
            "Porcino",
            "Vacuno",
            ""});
            this.CbEspecie.Location = new System.Drawing.Point(196, 128);
            this.CbEspecie.Name = "CbEspecie";
            this.CbEspecie.Size = new System.Drawing.Size(177, 26);
            this.CbEspecie.TabIndex = 4;
            // 
            // BtnGuardarProducto
            // 
            this.BtnGuardarProducto.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnGuardarProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarProducto.Image = global::SistemaApartados.Properties.Resources.guardar;
            this.BtnGuardarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarProducto.Location = new System.Drawing.Point(16, 263);
            this.BtnGuardarProducto.Name = "BtnGuardarProducto";
            this.BtnGuardarProducto.Size = new System.Drawing.Size(123, 54);
            this.BtnGuardarProducto.TabIndex = 7;
            this.BtnGuardarProducto.Text = "Guardar";
            this.BtnGuardarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardarProducto.UseVisualStyleBackColor = false;
            this.BtnGuardarProducto.Click += new System.EventHandler(this.BtnGuardarproducto_Click);
            this.BtnGuardarProducto.MouseEnter += new System.EventHandler(this.BtnGuardarProducto_MouseEnter);
            this.BtnGuardarProducto.MouseLeave += new System.EventHandler(this.BtnGuardarProducto_MouseLeave);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Goldenrod;
            this.BtnCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Image = global::SistemaApartados.Properties.Resources.eliminar;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(196, 263);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(171, 54);
            this.BtnCancelar.TabIndex = 8;
            this.BtnCancelar.Text = "Cancelar/Cerrar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            this.BtnCancelar.MouseEnter += new System.EventHandler(this.BtnCancelar_MouseEnter);
            this.BtnCancelar.MouseLeave += new System.EventHandler(this.BtnCancelar_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(172, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "$";
            // 
            // BtnGenerar_Clave
            // 
            this.BtnGenerar_Clave.BackColor = System.Drawing.Color.Salmon;
            this.BtnGenerar_Clave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerar_Clave.Image = global::SistemaApartados.Properties.Resources.ticket;
            this.BtnGenerar_Clave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGenerar_Clave.Location = new System.Drawing.Point(12, 207);
            this.BtnGenerar_Clave.Name = "BtnGenerar_Clave";
            this.BtnGenerar_Clave.Size = new System.Drawing.Size(126, 50);
            this.BtnGenerar_Clave.TabIndex = 6;
            this.BtnGenerar_Clave.Text = "Generar\r\nClave";
            this.BtnGenerar_Clave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGenerar_Clave.UseVisualStyleBackColor = false;
            this.BtnGenerar_Clave.Click += new System.EventHandler(this.BtnGenerar_Clave_Click);
            this.BtnGenerar_Clave.MouseEnter += new System.EventHandler(this.BtnGenerar_Clave_MouseEnter);
            this.BtnGenerar_Clave.MouseLeave += new System.EventHandler(this.BtnGenerar_Clave_MouseLeave);
            // 
            // Frm_AltaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(385, 338);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardarProducto);
            this.Controls.Add(this.BtnGenerar_Clave);
            this.Controls.Add(this.CbEspecie);
            this.Controls.Add(this.CbMarca);
            this.Controls.Add(this.CbTipo_Producto);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.TxtNombre_Producto);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_AltaProductos";
            this.Text = "Alta de Productos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox TxtNombre_Producto;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.ComboBox CbTipo_Producto;
        private System.Windows.Forms.ComboBox CbMarca;
        private System.Windows.Forms.ComboBox CbEspecie;
        private System.Windows.Forms.Button BtnGenerar_Clave;
        private System.Windows.Forms.Button BtnGuardarProducto;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label label6;
    }
}