namespace SistemaApartados
{
    partial class Frm_ConsultarApartados
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
            this.TxtNombreCliente = new System.Windows.Forms.TextBox();
            this.TxtFolio = new System.Windows.Forms.TextBox();
            this.BtnBajaApartado = new System.Windows.Forms.Button();
            this.BtnLiquidar = new System.Windows.Forms.Button();
            this.DgvApartados = new System.Windows.Forms.DataGridView();
            this.BtnModificarApartado = new System.Windows.Forms.Button();
            this.BtnReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvApartados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(464, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Folio:";
            // 
            // TxtNombreCliente
            // 
            this.TxtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreCliente.Location = new System.Drawing.Point(210, 4);
            this.TxtNombreCliente.Name = "TxtNombreCliente";
            this.TxtNombreCliente.Size = new System.Drawing.Size(178, 31);
            this.TxtNombreCliente.TabIndex = 2;
            this.TxtNombreCliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtNombreCliente_KeyUp);
            // 
            // TxtFolio
            // 
            this.TxtFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFolio.Location = new System.Drawing.Point(533, 4);
            this.TxtFolio.Name = "TxtFolio";
            this.TxtFolio.Size = new System.Drawing.Size(130, 31);
            this.TxtFolio.TabIndex = 3;
            this.TxtFolio.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtFolio_KeyUp);
            // 
            // BtnBajaApartado
            // 
            this.BtnBajaApartado.BackColor = System.Drawing.Color.Goldenrod;
            this.BtnBajaApartado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBajaApartado.Image = global::SistemaApartados.Properties.Resources.Cancelarapartado;
            this.BtnBajaApartado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBajaApartado.Location = new System.Drawing.Point(427, 54);
            this.BtnBajaApartado.Name = "BtnBajaApartado";
            this.BtnBajaApartado.Size = new System.Drawing.Size(115, 47);
            this.BtnBajaApartado.TabIndex = 8;
            this.BtnBajaApartado.Text = "Dar De\r\nBaja";
            this.BtnBajaApartado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBajaApartado.UseVisualStyleBackColor = false;
            this.BtnBajaApartado.Click += new System.EventHandler(this.BtnBajaApartado_Click);
            this.BtnBajaApartado.MouseEnter += new System.EventHandler(this.BtnBajaApartado_MouseEnter);
            this.BtnBajaApartado.MouseLeave += new System.EventHandler(this.BtnBajaApartado_MouseLeave);
            // 
            // BtnLiquidar
            // 
            this.BtnLiquidar.BackColor = System.Drawing.Color.MediumPurple;
            this.BtnLiquidar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLiquidar.Image = global::SistemaApartados.Properties.Resources.anadir;
            this.BtnLiquidar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLiquidar.Location = new System.Drawing.Point(630, 54);
            this.BtnLiquidar.Name = "BtnLiquidar";
            this.BtnLiquidar.Size = new System.Drawing.Size(129, 47);
            this.BtnLiquidar.TabIndex = 9;
            this.BtnLiquidar.Text = "Liquidar Apartado";
            this.BtnLiquidar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLiquidar.UseVisualStyleBackColor = false;
            this.BtnLiquidar.Click += new System.EventHandler(this.BtnLiquidar_Click);
            this.BtnLiquidar.MouseEnter += new System.EventHandler(this.BtnLiquidar_MouseEnter);
            this.BtnLiquidar.MouseLeave += new System.EventHandler(this.BtnLiquidar_MouseLeave);
            // 
            // DgvApartados
            // 
            this.DgvApartados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvApartados.Location = new System.Drawing.Point(9, 126);
            this.DgvApartados.Name = "DgvApartados";
            this.DgvApartados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvApartados.Size = new System.Drawing.Size(750, 283);
            this.DgvApartados.TabIndex = 10;
            // 
            // BtnModificarApartado
            // 
            this.BtnModificarApartado.BackColor = System.Drawing.Color.Moccasin;
            this.BtnModificarApartado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarApartado.Image = global::SistemaApartados.Properties.Resources.Consulta1;
            this.BtnModificarApartado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificarApartado.Location = new System.Drawing.Point(223, 54);
            this.BtnModificarApartado.Name = "BtnModificarApartado";
            this.BtnModificarApartado.Size = new System.Drawing.Size(137, 47);
            this.BtnModificarApartado.TabIndex = 7;
            this.BtnModificarApartado.Text = "Modificar";
            this.BtnModificarApartado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnModificarApartado.UseVisualStyleBackColor = false;
            this.BtnModificarApartado.Click += new System.EventHandler(this.BtnModificarApartado_Click);
            this.BtnModificarApartado.MouseEnter += new System.EventHandler(this.BtnModificarApartado_MouseEnter);
            this.BtnModificarApartado.MouseLeave += new System.EventHandler(this.BtnModificarApartado_MouseLeave);
            // 
            // BtnReporte
            // 
            this.BtnReporte.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.BtnReporte.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReporte.Image = global::SistemaApartados.Properties.Resources.ticket;
            this.BtnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReporte.Location = new System.Drawing.Point(12, 54);
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.Size = new System.Drawing.Size(131, 47);
            this.BtnReporte.TabIndex = 6;
            this.BtnReporte.Text = "Generar\r\nReporte";
            this.BtnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnReporte.UseVisualStyleBackColor = false;
            this.BtnReporte.Click += new System.EventHandler(this.BtnReporte_Click);
            this.BtnReporte.MouseEnter += new System.EventHandler(this.BtnReporte_MouseEnter);
            this.BtnReporte.MouseLeave += new System.EventHandler(this.BtnReporte_MouseLeave);
            // 
            // Frm_ConsultarApartados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(771, 419);
            this.Controls.Add(this.DgvApartados);
            this.Controls.Add(this.BtnLiquidar);
            this.Controls.Add(this.BtnBajaApartado);
            this.Controls.Add(this.BtnModificarApartado);
            this.Controls.Add(this.BtnReporte);
            this.Controls.Add(this.TxtFolio);
            this.Controls.Add(this.TxtNombreCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_ConsultarApartados";
            this.Text = "Consultar Apartados";
            ((System.ComponentModel.ISupportInitialize)(this.DgvApartados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNombreCliente;
        private System.Windows.Forms.TextBox TxtFolio;
        private System.Windows.Forms.Button BtnReporte;
        private System.Windows.Forms.Button BtnModificarApartado;
        private System.Windows.Forms.Button BtnBajaApartado;
        private System.Windows.Forms.Button BtnLiquidar;
        private System.Windows.Forms.DataGridView DgvApartados;
    }
}