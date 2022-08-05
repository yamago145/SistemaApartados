namespace SistemaApartados
{
    partial class Frm_AltaApartados
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
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnQuitarProducto = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.LblEnganche = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.DtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.txtImporteEnganche = new System.Windows.Forms.TextBox();
            this.DtgListaApartados = new System.Windows.Forms.DataGridView();
            this.CmbProducto = new System.Windows.Forms.ComboBox();
            this.txtCantidadProducto = new System.Windows.Forms.TextBox();
            this.Btn_GuardarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Cmb_Cliente = new System.Windows.Forms.ComboBox();
            this.Lbl_Precio = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtgListaApartados)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Cross;
            this.BtnAgregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Image = global::SistemaApartados.Properties.Resources.nuevo;
            this.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregar.Location = new System.Drawing.Point(238, 64);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(113, 48);
            this.BtnAgregar.TabIndex = 6;
            this.BtnAgregar.Text = "Añadir a la Lista";
            this.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            this.BtnAgregar.MouseEnter += new System.EventHandler(this.BtnAgregar_MouseEnter);
            // 
            // BtnQuitarProducto
            // 
            this.BtnQuitarProducto.BackColor = System.Drawing.Color.Red;
            this.BtnQuitarProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuitarProducto.Image = global::SistemaApartados.Properties.Resources.eliminar;
            this.BtnQuitarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnQuitarProducto.Location = new System.Drawing.Point(359, 64);
            this.BtnQuitarProducto.Name = "BtnQuitarProducto";
            this.BtnQuitarProducto.Size = new System.Drawing.Size(105, 48);
            this.BtnQuitarProducto.TabIndex = 7;
            this.BtnQuitarProducto.Text = "Quitar de la Lista";
            this.BtnQuitarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnQuitarProducto.UseVisualStyleBackColor = false;
            this.BtnQuitarProducto.Click += new System.EventHandler(this.BtnQuitarProducto_Click);
            this.BtnQuitarProducto.MouseEnter += new System.EventHandler(this.BtnQuitarProducto_MouseEnter);
            this.BtnQuitarProducto.MouseLeave += new System.EventHandler(this.BtnQuitarProducto_MouseLeave);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnGuardar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Image = global::SistemaApartados.Properties.Resources.guardar;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(529, 470);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(195, 48);
            this.BtnGuardar.TabIndex = 9;
            this.BtnGuardar.Text = "Guardar Apartado";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            this.BtnGuardar.MouseEnter += new System.EventHandler(this.BtnGuardar_MouseEnter);
            this.BtnGuardar.MouseLeave += new System.EventHandler(this.BtnGuardar_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre del Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(370, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha de Pedido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(365, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha de Entrega:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(235, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Precio $";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Cantidad: (Unidades/Kg)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 27);
            this.label9.TabIndex = 11;
            this.label9.Text = "Total:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 41);
            this.label10.TabIndex = 12;
            this.label10.Text = "$";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(38, 35);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(73, 45);
            this.LblTotal.TabIndex = 13;
            this.LblTotal.Text = "0.0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 27);
            this.label13.TabIndex = 15;
            this.label13.Text = "30% =";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(87, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 27);
            this.label14.TabIndex = 16;
            this.label14.Text = "$";
            // 
            // LblEnganche
            // 
            this.LblEnganche.AutoSize = true;
            this.LblEnganche.BackColor = System.Drawing.Color.SeaShell;
            this.LblEnganche.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEnganche.Location = new System.Drawing.Point(118, 60);
            this.LblEnganche.Name = "LblEnganche";
            this.LblEnganche.Size = new System.Drawing.Size(44, 27);
            this.LblEnganche.TabIndex = 17;
            this.LblEnganche.Text = "0.0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(45, 121);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 27);
            this.label16.TabIndex = 18;
            this.label16.Text = "Importe:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(19, 151);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 27);
            this.label17.TabIndex = 19;
            this.label17.Text = "$";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(11, 61);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(208, 29);
            this.txtNombreCliente.TabIndex = 10;
            // 
            // DtpFecha
            // 
            this.DtpFecha.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFecha.Location = new System.Drawing.Point(524, 9);
            this.DtpFecha.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.DtpFecha.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(200, 22);
            this.DtpFecha.TabIndex = 2;
            this.DtpFecha.Value = new System.DateTime(2019, 5, 25, 1, 3, 0, 0);
            // 
            // DtpFechaEntrega
            // 
            this.DtpFechaEntrega.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaEntrega.Location = new System.Drawing.Point(524, 41);
            this.DtpFechaEntrega.Name = "DtpFechaEntrega";
            this.DtpFechaEntrega.Size = new System.Drawing.Size(200, 22);
            this.DtpFechaEntrega.TabIndex = 3;
            this.DtpFechaEntrega.Value = new System.DateTime(2019, 5, 25, 1, 3, 0, 0);
            // 
            // txtImporteEnganche
            // 
            this.txtImporteEnganche.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporteEnganche.Location = new System.Drawing.Point(50, 158);
            this.txtImporteEnganche.Name = "txtImporteEnganche";
            this.txtImporteEnganche.Size = new System.Drawing.Size(100, 32);
            this.txtImporteEnganche.TabIndex = 8;
            this.txtImporteEnganche.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtImporteEnganche_KeyUp);
            // 
            // DtgListaApartados
            // 
            this.DtgListaApartados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgListaApartados.Location = new System.Drawing.Point(12, 298);
            this.DtgListaApartados.Name = "DtgListaApartados";
            this.DtgListaApartados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgListaApartados.Size = new System.Drawing.Size(712, 166);
            this.DtgListaApartados.TabIndex = 26;
            // 
            // CmbProducto
            // 
            this.CmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbProducto.FormattingEnabled = true;
            this.CmbProducto.Location = new System.Drawing.Point(6, 29);
            this.CmbProducto.Name = "CmbProducto";
            this.CmbProducto.Size = new System.Drawing.Size(220, 30);
            this.CmbProducto.TabIndex = 4;
            // 
            // txtCantidadProducto
            // 
            this.txtCantidadProducto.Location = new System.Drawing.Point(170, 75);
            this.txtCantidadProducto.Name = "txtCantidadProducto";
            this.txtCantidadProducto.Size = new System.Drawing.Size(56, 29);
            this.txtCantidadProducto.TabIndex = 5;
            this.txtCantidadProducto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCantidadProducto_KeyUp);
            // 
            // Btn_GuardarCliente
            // 
            this.Btn_GuardarCliente.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GuardarCliente.Location = new System.Drawing.Point(225, 60);
            this.Btn_GuardarCliente.Name = "Btn_GuardarCliente";
            this.Btn_GuardarCliente.Size = new System.Drawing.Size(115, 29);
            this.Btn_GuardarCliente.TabIndex = 11;
            this.Btn_GuardarCliente.Text = "Guardar Cliente";
            this.Btn_GuardarCliente.UseVisualStyleBackColor = true;
            this.Btn_GuardarCliente.Click += new System.EventHandler(this.Btn_GuardarCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Seleccionar un Cliente:";
            // 
            // Cmb_Cliente
            // 
            this.Cmb_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Cliente.FormattingEnabled = true;
            this.Cmb_Cliente.ItemHeight = 22;
            this.Cmb_Cliente.Location = new System.Drawing.Point(158, 106);
            this.Cmb_Cliente.Name = "Cmb_Cliente";
            this.Cmb_Cliente.Size = new System.Drawing.Size(182, 30);
            this.Cmb_Cliente.TabIndex = 1;
            // 
            // Lbl_Precio
            // 
            this.Lbl_Precio.AutoSize = true;
            this.Lbl_Precio.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Precio.Location = new System.Drawing.Point(305, 36);
            this.Lbl_Precio.Name = "Lbl_Precio";
            this.Lbl_Precio.Size = new System.Drawing.Size(35, 22);
            this.Lbl_Precio.TabIndex = 33;
            this.Lbl_Precio.Text = "0.0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OldLace;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.LblTotal);
            this.panel2.Location = new System.Drawing.Point(374, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 88);
            this.panel2.TabIndex = 35;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.OldLace;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtImporteEnganche);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.LblEnganche);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Location = new System.Drawing.Point(510, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(214, 220);
            this.panel3.TabIndex = 36;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CmbProducto);
            this.groupBox1.Controls.Add(this.BtnAgregar);
            this.groupBox1.Controls.Add(this.BtnQuitarProducto);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Lbl_Precio);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCantidadProducto);
            this.groupBox1.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 126);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar Productos:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_GuardarCliente);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtNombreCliente);
            this.groupBox2.Controls.Add(this.Cmb_Cliente);
            this.groupBox2.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 150);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "Enganche Obligatorio:";
            // 
            // Frm_AltaApartados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(743, 524);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.DtpFechaEntrega);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DtgListaApartados);
            this.Controls.Add(this.BtnGuardar);
            this.Name = "Frm_AltaApartados";
            this.Text = "Alta Apartado";
            ((System.ComponentModel.ISupportInitialize)(this.DtgListaApartados)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnQuitarProducto;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label LblEnganche;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.DateTimePicker DtpFechaEntrega;
        private System.Windows.Forms.TextBox txtImporteEnganche;
        private System.Windows.Forms.DataGridView DtgListaApartados;
        private System.Windows.Forms.ComboBox CmbProducto;
        private System.Windows.Forms.TextBox txtCantidadProducto;
        private System.Windows.Forms.Button Btn_GuardarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cmb_Cliente;
        private System.Windows.Forms.Label Lbl_Precio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        protected internal System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
    }
}