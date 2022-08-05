namespace SistemaApartados
{
    partial class Frm_LiquidarApartado
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
            this.dtpFechaE = new System.Windows.Forms.DateTimePicker();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.LblTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvListaApartados = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtEfectivo = new System.Windows.Forms.TextBox();
            this.LblCantidadRestante = new System.Windows.Forms.Label();
            this.LblCambio = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnLiquidar = new System.Windows.Forms.Button();
            this.LblIDCliente = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.LblImporte = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaApartados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFechaE
            // 
            this.dtpFechaE.Enabled = false;
            this.dtpFechaE.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaE.Location = new System.Drawing.Point(167, 130);
            this.dtpFechaE.Name = "dtpFechaE";
            this.dtpFechaE.Size = new System.Drawing.Size(258, 25);
            this.dtpFechaE.TabIndex = 35;
            // 
            // DtpFecha
            // 
            this.DtpFecha.Enabled = false;
            this.DtpFecha.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFecha.Location = new System.Drawing.Point(167, 97);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(258, 25);
            this.DtpFecha.TabIndex = 34;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(37, 52);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(62, 38);
            this.LblTotal.TabIndex = 31;
            this.LblTotal.Text = "0.0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 29);
            this.label10.TabIndex = 30;
            this.label10.Text = "$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "Fecha de Entrega:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "Fecha de Pedido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nombre del Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "ID del Cliente:";
            // 
            // DgvListaApartados
            // 
            this.DgvListaApartados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaApartados.Location = new System.Drawing.Point(22, 349);
            this.DgvListaApartados.Name = "DgvListaApartados";
            this.DgvListaApartados.Size = new System.Drawing.Size(589, 165);
            this.DgvListaApartados.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(215, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 30);
            this.label6.TabIndex = 45;
            this.label6.Text = "Su cambio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 19);
            this.label7.TabIndex = 46;
            this.label7.Text = "Efectivo:  $";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(352, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 24);
            this.label8.TabIndex = 47;
            this.label8.Text = "$";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 19);
            this.label11.TabIndex = 48;
            this.label11.Text = "Cantidad Restante:  $";
            // 
            // TxtEfectivo
            // 
            this.TxtEfectivo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEfectivo.Location = new System.Drawing.Point(106, 71);
            this.TxtEfectivo.Name = "TxtEfectivo";
            this.TxtEfectivo.Size = new System.Drawing.Size(97, 29);
            this.TxtEfectivo.TabIndex = 49;
            this.TxtEfectivo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtEfectivo_KeyUp);
            // 
            // LblCantidadRestante
            // 
            this.LblCantidadRestante.AutoSize = true;
            this.LblCantidadRestante.Location = new System.Drawing.Point(185, 34);
            this.LblCantidadRestante.Name = "LblCantidadRestante";
            this.LblCantidadRestante.Size = new System.Drawing.Size(44, 27);
            this.LblCantidadRestante.TabIndex = 50;
            this.LblCantidadRestante.Text = "0.0";
            // 
            // LblCambio
            // 
            this.LblCambio.AutoSize = true;
            this.LblCambio.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCambio.Location = new System.Drawing.Point(370, 299);
            this.LblCambio.Name = "LblCambio";
            this.LblCambio.Size = new System.Drawing.Size(55, 33);
            this.LblCambio.TabIndex = 51;
            this.LblCambio.Text = "0.0";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Image = global::SistemaApartados.Properties.Resources.Cancelarapartado;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(22, 295);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(117, 48);
            this.BtnCancelar.TabIndex = 52;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            this.BtnCancelar.MouseEnter += new System.EventHandler(this.BtnCancelar_MouseEnter);
            this.BtnCancelar.MouseLeave += new System.EventHandler(this.BtnCancelar_MouseLeave);
            // 
            // BtnLiquidar
            // 
            this.BtnLiquidar.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnLiquidar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLiquidar.Image = global::SistemaApartados.Properties.Resources.listo;
            this.BtnLiquidar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLiquidar.Location = new System.Drawing.Point(256, 40);
            this.BtnLiquidar.Name = "BtnLiquidar";
            this.BtnLiquidar.Size = new System.Drawing.Size(128, 48);
            this.BtnLiquidar.TabIndex = 53;
            this.BtnLiquidar.Text = "Liquidar Apartado";
            this.BtnLiquidar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLiquidar.UseVisualStyleBackColor = false;
            this.BtnLiquidar.Click += new System.EventHandler(this.BtnLiquidar_Click);
            this.BtnLiquidar.MouseEnter += new System.EventHandler(this.BtnLiquidar_MouseEnter);
            this.BtnLiquidar.MouseLeave += new System.EventHandler(this.BtnLiquidar_MouseLeave);
            // 
            // LblIDCliente
            // 
            this.LblIDCliente.AutoSize = true;
            this.LblIDCliente.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIDCliente.Location = new System.Drawing.Point(191, 22);
            this.LblIDCliente.Name = "LblIDCliente";
            this.LblIDCliente.Size = new System.Drawing.Size(28, 23);
            this.LblIDCliente.TabIndex = 54;
            this.LblIDCliente.Text = "ID";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(191, 56);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(79, 23);
            this.LblNombre.TabIndex = 55;
            this.LblNombre.Text = "Nombre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblCantidadRestante);
            this.groupBox1.Controls.Add(this.TxtEfectivo);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.BtnLiquidar);
            this.groupBox1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 111);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liquidación";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(6, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 19);
            this.label13.TabIndex = 38;
            this.label13.Text = "30% = $";
            // 
            // LblImporte
            // 
            this.LblImporte.AutoSize = true;
            this.LblImporte.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblImporte.ForeColor = System.Drawing.Color.Black;
            this.LblImporte.Location = new System.Drawing.Point(81, 31);
            this.LblImporte.Name = "LblImporte";
            this.LblImporte.Size = new System.Drawing.Size(48, 30);
            this.LblImporte.TabIndex = 40;
            this.LblImporte.Text = "0.0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblImporte);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(444, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 75);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enganche";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.LblTotal);
            this.groupBox3.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(444, 89);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(167, 108);
            this.groupBox3.TabIndex = 58;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Total";
            // 
            // Frm_LiquidarApartado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(623, 526);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.LblCambio);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblIDCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DgvListaApartados);
            this.Controls.Add(this.dtpFechaE);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_LiquidarApartado";
            this.Text = "Liquidar Apartado";
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaApartados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaE;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvListaApartados;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtEfectivo;
        private System.Windows.Forms.Label LblCantidadRestante;
        private System.Windows.Forms.Label LblCambio;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnLiquidar;
        private System.Windows.Forms.Label LblIDCliente;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label LblImporte;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}