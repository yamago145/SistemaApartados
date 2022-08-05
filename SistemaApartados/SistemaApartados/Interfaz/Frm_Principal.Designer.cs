namespace SistemaApartados
{
    partial class Frm_Principal
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
            this.BtnApartado = new System.Windows.Forms.Button();
            this.BtnProducto = new System.Windows.Forms.Button();
            this.Btncons_Producto = new System.Windows.Forms.Button();
            this.Btncons_Apartado = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnApartado
            // 
            this.BtnApartado.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnApartado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnApartado.Image = global::SistemaApartados.Properties.Resources.nuevo;
            this.BtnApartado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnApartado.Location = new System.Drawing.Point(12, 157);
            this.BtnApartado.Name = "BtnApartado";
            this.BtnApartado.Size = new System.Drawing.Size(160, 47);
            this.BtnApartado.TabIndex = 0;
            this.BtnApartado.Text = "Registrar Un Apartado";
            this.BtnApartado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnApartado.UseVisualStyleBackColor = false;
            this.BtnApartado.Click += new System.EventHandler(this.BtnApartado_Click);
            this.BtnApartado.MouseEnter += new System.EventHandler(this.BtnApartado_MouseEnter);
            this.BtnApartado.MouseLeave += new System.EventHandler(this.BtnApartado_MouseLeave);
            // 
            // BtnProducto
            // 
            this.BtnProducto.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BtnProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProducto.Image = global::SistemaApartados.Properties.Resources.anadirproducto;
            this.BtnProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProducto.Location = new System.Drawing.Point(305, 157);
            this.BtnProducto.Name = "BtnProducto";
            this.BtnProducto.Size = new System.Drawing.Size(156, 47);
            this.BtnProducto.TabIndex = 1;
            this.BtnProducto.Text = "Dar De Alta\r\nUn Producto";
            this.BtnProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnProducto.UseVisualStyleBackColor = false;
            this.BtnProducto.Click += new System.EventHandler(this.BtnProducto_Click);
            this.BtnProducto.MouseEnter += new System.EventHandler(this.BtnProducto_MouseEnter);
            this.BtnProducto.MouseLeave += new System.EventHandler(this.BtnProducto_MouseLeave);
            // 
            // Btncons_Producto
            // 
            this.Btncons_Producto.BackColor = System.Drawing.Color.Peru;
            this.Btncons_Producto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btncons_Producto.Image = global::SistemaApartados.Properties.Resources.anadir;
            this.Btncons_Producto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btncons_Producto.Location = new System.Drawing.Point(305, 236);
            this.Btncons_Producto.Name = "Btncons_Producto";
            this.Btncons_Producto.Size = new System.Drawing.Size(156, 49);
            this.Btncons_Producto.TabIndex = 2;
            this.Btncons_Producto.Text = "Consultar\r\nProductos";
            this.Btncons_Producto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btncons_Producto.UseVisualStyleBackColor = false;
            this.Btncons_Producto.Click += new System.EventHandler(this.Btncons_Producto_Click);
            this.Btncons_Producto.MouseEnter += new System.EventHandler(this.Btncons_Producto_MouseEnter);
            this.Btncons_Producto.MouseLeave += new System.EventHandler(this.Btncons_Producto_MouseLeave);
            // 
            // Btncons_Apartado
            // 
            this.Btncons_Apartado.BackColor = System.Drawing.Color.Orange;
            this.Btncons_Apartado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btncons_Apartado.Image = global::SistemaApartados.Properties.Resources.Consulta;
            this.Btncons_Apartado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btncons_Apartado.Location = new System.Drawing.Point(12, 236);
            this.Btncons_Apartado.Name = "Btncons_Apartado";
            this.Btncons_Apartado.Size = new System.Drawing.Size(160, 49);
            this.Btncons_Apartado.TabIndex = 3;
            this.Btncons_Apartado.Text = "Consultar\r\nApartados";
            this.Btncons_Apartado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btncons_Apartado.UseVisualStyleBackColor = false;
            this.Btncons_Apartado.Click += new System.EventHandler(this.Btncons_Apartado_Click);
            this.Btncons_Apartado.MouseEnter += new System.EventHandler(this.Btncons_Apartado_MouseEnter);
            this.Btncons_Apartado.MouseLeave += new System.EventHandler(this.Btncons_Apartado_MouseLeave);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnSalir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Image = global::SistemaApartados.Properties.Resources.eliminar;
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.Location = new System.Drawing.Point(184, 308);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(98, 60);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            this.BtnSalir.MouseEnter += new System.EventHandler(this.BtnSalir_MouseEnter);
            this.BtnSalir.MouseLeave += new System.EventHandler(this.BtnSalir_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 54);
            this.label1.TabIndex = 5;
            this.label1.Text = "FORRAJERA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 57);
            this.label2.TabIndex = 6;
            this.label2.Text = " \"EL AMIGO\"";
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(481, 374);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.Btncons_Apartado);
            this.Controls.Add(this.Btncons_Producto);
            this.Controls.Add(this.BtnProducto);
            this.Controls.Add(this.BtnApartado);
            this.Name = "Frm_Principal";
            this.Text = "Menú Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnApartado;
        private System.Windows.Forms.Button BtnProducto;
        private System.Windows.Forms.Button Btncons_Producto;
        private System.Windows.Forms.Button Btncons_Apartado;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

