namespace SistemaApartados
{
    partial class Frm_ConsultaProductos
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
            this.TxtID_Clave = new System.Windows.Forms.TextBox();
            this.TxtNombre_Producto = new System.Windows.Forms.TextBox();
            this.BtnGenerar_Reporte = new System.Windows.Forms.Button();
            this.BtnModificar_Producto = new System.Windows.Forms.Button();
            this.BtnBaja_Producto = new System.Windows.Forms.Button();
            this.DgLista = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgLista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clave:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Producto:";
            // 
            // TxtID_Clave
            // 
            this.TxtID_Clave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtID_Clave.Location = new System.Drawing.Point(66, 9);
            this.TxtID_Clave.Name = "TxtID_Clave";
            this.TxtID_Clave.Size = new System.Drawing.Size(104, 26);
            this.TxtID_Clave.TabIndex = 2;
            this.TxtID_Clave.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtID_Clave_KeyUp);
            // 
            // TxtNombre_Producto
            // 
            this.TxtNombre_Producto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre_Producto.Location = new System.Drawing.Point(390, 12);
            this.TxtNombre_Producto.Name = "TxtNombre_Producto";
            this.TxtNombre_Producto.Size = new System.Drawing.Size(154, 26);
            this.TxtNombre_Producto.TabIndex = 3;
            this.TxtNombre_Producto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtNombre_Producto_KeyUp);
            // 
            // BtnGenerar_Reporte
            // 
            this.BtnGenerar_Reporte.BackColor = System.Drawing.Color.Gold;
            this.BtnGenerar_Reporte.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerar_Reporte.Image = global::SistemaApartados.Properties.Resources.ticket;
            this.BtnGenerar_Reporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGenerar_Reporte.Location = new System.Drawing.Point(16, 52);
            this.BtnGenerar_Reporte.Name = "BtnGenerar_Reporte";
            this.BtnGenerar_Reporte.Size = new System.Drawing.Size(151, 59);
            this.BtnGenerar_Reporte.TabIndex = 6;
            this.BtnGenerar_Reporte.Text = "Generar E \r\nImprimir Reporte";
            this.BtnGenerar_Reporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGenerar_Reporte.UseVisualStyleBackColor = false;
            this.BtnGenerar_Reporte.Click += new System.EventHandler(this.BtnGenerar_Reporte_Click);
            this.BtnGenerar_Reporte.MouseEnter += new System.EventHandler(this.BtnGenerar_Reporte_MouseEnter);
            this.BtnGenerar_Reporte.MouseLeave += new System.EventHandler(this.BtnGenerar_Reporte_MouseLeave);
            // 
            // BtnModificar_Producto
            // 
            this.BtnModificar_Producto.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnModificar_Producto.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar_Producto.Image = global::SistemaApartados.Properties.Resources.Consulta1;
            this.BtnModificar_Producto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificar_Producto.Location = new System.Drawing.Point(210, 52);
            this.BtnModificar_Producto.Name = "BtnModificar_Producto";
            this.BtnModificar_Producto.Size = new System.Drawing.Size(151, 59);
            this.BtnModificar_Producto.TabIndex = 7;
            this.BtnModificar_Producto.Text = "Modificar";
            this.BtnModificar_Producto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnModificar_Producto.UseVisualStyleBackColor = false;
            this.BtnModificar_Producto.Click += new System.EventHandler(this.BtnModificar_Producto_Click);
            this.BtnModificar_Producto.MouseEnter += new System.EventHandler(this.BtnModificar_Producto_MouseEnter);
            this.BtnModificar_Producto.MouseLeave += new System.EventHandler(this.BtnModificar_Producto_MouseLeave);
            // 
            // BtnBaja_Producto
            // 
            this.BtnBaja_Producto.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnBaja_Producto.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBaja_Producto.Image = global::SistemaApartados.Properties.Resources.anadir;
            this.BtnBaja_Producto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBaja_Producto.Location = new System.Drawing.Point(390, 52);
            this.BtnBaja_Producto.Name = "BtnBaja_Producto";
            this.BtnBaja_Producto.Size = new System.Drawing.Size(151, 59);
            this.BtnBaja_Producto.TabIndex = 8;
            this.BtnBaja_Producto.Text = "Dar De\r\nBaja";
            this.BtnBaja_Producto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBaja_Producto.UseVisualStyleBackColor = false;
            this.BtnBaja_Producto.Click += new System.EventHandler(this.BtnBaja_Producto_Click);
            this.BtnBaja_Producto.MouseEnter += new System.EventHandler(this.BtnBaja_Producto_MouseEnter);
            this.BtnBaja_Producto.MouseLeave += new System.EventHandler(this.BtnBaja_Producto_MouseLeave);
            // 
            // DgLista
            // 
            this.DgLista.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.DgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgLista.Location = new System.Drawing.Point(12, 127);
            this.DgLista.Name = "DgLista";
            this.DgLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgLista.Size = new System.Drawing.Size(529, 199);
            this.DgLista.TabIndex = 10;
            // 
            // Frm_ConsultaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(556, 339);
            this.Controls.Add(this.DgLista);
            this.Controls.Add(this.BtnBaja_Producto);
            this.Controls.Add(this.BtnModificar_Producto);
            this.Controls.Add(this.BtnGenerar_Reporte);
            this.Controls.Add(this.TxtNombre_Producto);
            this.Controls.Add(this.TxtID_Clave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_ConsultaProductos";
            this.Text = "Consultar Productos";
            ((System.ComponentModel.ISupportInitialize)(this.DgLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtID_Clave;
        private System.Windows.Forms.TextBox TxtNombre_Producto;
        private System.Windows.Forms.Button BtnGenerar_Reporte;
        private System.Windows.Forms.Button BtnModificar_Producto;
        private System.Windows.Forms.Button BtnBaja_Producto;
        private System.Windows.Forms.DataGridView DgLista;
    }
}