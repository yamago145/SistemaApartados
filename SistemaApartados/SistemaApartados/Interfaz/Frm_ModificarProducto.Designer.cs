namespace SistemaApartados.Interfaz
{
    partial class Frm_ModificarProducto
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
            this.Lbl_Clave = new System.Windows.Forms.Label();
            this.TxbNombre_Producto = new System.Windows.Forms.TextBox();
            this.TxbPrecioProducto = new System.Windows.Forms.TextBox();
            this.CbTipoProducto = new System.Windows.Forms.ComboBox();
            this.Cb_Marca = new System.Windows.Forms.ComboBox();
            this.CB_Especie = new System.Windows.Forms.ComboBox();
            this.BtnGenerarClave = new System.Windows.Forms.Button();
            this.BtnGuardar_Producto = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Especie:";
            // 
            // Lbl_Clave
            // 
            this.Lbl_Clave.AutoSize = true;
            this.Lbl_Clave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Clave.Location = new System.Drawing.Point(193, 202);
            this.Lbl_Clave.Name = "Lbl_Clave";
            this.Lbl_Clave.Size = new System.Drawing.Size(52, 19);
            this.Lbl_Clave.TabIndex = 4;
            this.Lbl_Clave.Text = "Clave";
            // 
            // TxbNombre_Producto
            // 
            this.TxbNombre_Producto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbNombre_Producto.Location = new System.Drawing.Point(196, 18);
            this.TxbNombre_Producto.Name = "TxbNombre_Producto";
            this.TxbNombre_Producto.ShortcutsEnabled = false;
            this.TxbNombre_Producto.Size = new System.Drawing.Size(177, 26);
            this.TxbNombre_Producto.TabIndex = 1;
            // 
            // TxbPrecioProducto
            // 
            this.TxbPrecioProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbPrecioProducto.Location = new System.Drawing.Point(196, 151);
            this.TxbPrecioProducto.Name = "TxbPrecioProducto";
            this.TxbPrecioProducto.ShortcutsEnabled = false;
            this.TxbPrecioProducto.Size = new System.Drawing.Size(64, 26);
            this.TxbPrecioProducto.TabIndex = 5;
            this.TxbPrecioProducto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxbPrecioProducto_KeyUp);
            // 
            // CbTipoProducto
            // 
            this.CbTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTipoProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbTipoProducto.FormattingEnabled = true;
            this.CbTipoProducto.Items.AddRange(new object[] {
            "Cereales",
            "Semillas",
            "Alimentos"});
            this.CbTipoProducto.Location = new System.Drawing.Point(196, 50);
            this.CbTipoProducto.Name = "CbTipoProducto";
            this.CbTipoProducto.Size = new System.Drawing.Size(177, 26);
            this.CbTipoProducto.TabIndex = 2;
            // 
            // Cb_Marca
            // 
            this.Cb_Marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Marca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_Marca.FormattingEnabled = true;
            this.Cb_Marca.Items.AddRange(new object[] {
            "Purina",
            "SabAmex",
            "Otra"});
            this.Cb_Marca.Location = new System.Drawing.Point(196, 82);
            this.Cb_Marca.Name = "Cb_Marca";
            this.Cb_Marca.Size = new System.Drawing.Size(177, 26);
            this.Cb_Marca.TabIndex = 3;
            // 
            // CB_Especie
            // 
            this.CB_Especie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Especie.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Especie.FormattingEnabled = true;
            this.CB_Especie.Items.AddRange(new object[] {
            "Porcino",
            "Vacuno",
            "Bovino",
            "Ovino",
            "Caprino",
            "Equino",
            "Domesticos"});
            this.CB_Especie.Location = new System.Drawing.Point(196, 114);
            this.CB_Especie.Name = "CB_Especie";
            this.CB_Especie.Size = new System.Drawing.Size(177, 26);
            this.CB_Especie.TabIndex = 4;
            // 
            // BtnGenerarClave
            // 
            this.BtnGenerarClave.BackColor = System.Drawing.Color.Turquoise;
            this.BtnGenerarClave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerarClave.Image = global::SistemaApartados.Properties.Resources.ticket;
            this.BtnGenerarClave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGenerarClave.Location = new System.Drawing.Point(15, 193);
            this.BtnGenerarClave.Name = "BtnGenerarClave";
            this.BtnGenerarClave.Size = new System.Drawing.Size(127, 50);
            this.BtnGenerarClave.TabIndex = 6;
            this.BtnGenerarClave.Text = "Generar\r\nClave";
            this.BtnGenerarClave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGenerarClave.UseVisualStyleBackColor = false;
            this.BtnGenerarClave.Click += new System.EventHandler(this.BtnGenerarClave_Click);
            this.BtnGenerarClave.MouseEnter += new System.EventHandler(this.BtnGenerarClave_MouseEnter);
            this.BtnGenerarClave.MouseLeave += new System.EventHandler(this.BtnGenerarClave_MouseLeave);
            // 
            // BtnGuardar_Producto
            // 
            this.BtnGuardar_Producto.BackColor = System.Drawing.Color.LightCoral;
            this.BtnGuardar_Producto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar_Producto.Image = global::SistemaApartados.Properties.Resources.guardar;
            this.BtnGuardar_Producto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar_Producto.Location = new System.Drawing.Point(15, 261);
            this.BtnGuardar_Producto.Name = "BtnGuardar_Producto";
            this.BtnGuardar_Producto.Size = new System.Drawing.Size(127, 46);
            this.BtnGuardar_Producto.TabIndex = 7;
            this.BtnGuardar_Producto.Text = "Guardar\r\nCambios";
            this.BtnGuardar_Producto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar_Producto.UseVisualStyleBackColor = false;
            this.BtnGuardar_Producto.Click += new System.EventHandler(this.BtnGuardar_Producto_Click);
            this.BtnGuardar_Producto.MouseEnter += new System.EventHandler(this.BtnGuardar_Producto_MouseEnter);
            this.BtnGuardar_Producto.MouseLeave += new System.EventHandler(this.BtnGuardar_Producto_MouseLeave);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Red;
            this.BtnCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Image = global::SistemaApartados.Properties.Resources.eliminar;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(196, 261);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(177, 46);
            this.BtnCancelar.TabIndex = 8;
            this.BtnCancelar.Text = "Cancelar Cambios";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            this.BtnCancelar.MouseEnter += new System.EventHandler(this.BtnCancelar_MouseEnter);
            this.BtnCancelar.MouseLeave += new System.EventHandler(this.BtnCancelar_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Precio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(169, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "$";
            // 
            // Frm_ModificarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(390, 315);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar_Producto);
            this.Controls.Add(this.BtnGenerarClave);
            this.Controls.Add(this.CB_Especie);
            this.Controls.Add(this.Cb_Marca);
            this.Controls.Add(this.CbTipoProducto);
            this.Controls.Add(this.TxbPrecioProducto);
            this.Controls.Add(this.TxbNombre_Producto);
            this.Controls.Add(this.Lbl_Clave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_ModificarProducto";
            this.Text = "Modificar Producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lbl_Clave;
        private System.Windows.Forms.TextBox TxbNombre_Producto;
        private System.Windows.Forms.TextBox TxbPrecioProducto;
        private System.Windows.Forms.ComboBox CbTipoProducto;
        private System.Windows.Forms.ComboBox Cb_Marca;
        private System.Windows.Forms.ComboBox CB_Especie;
        private System.Windows.Forms.Button BtnGenerarClave;
        private System.Windows.Forms.Button BtnGuardar_Producto;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}