using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaApartados
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnApartado_Click(object sender, EventArgs e)
        {
            /////////////////EXCEPCION POR SI NO HAY PRODUCTOS HABILITADOS

            Frm_AltaApartados mApartado = new Frm_AltaApartados();
            mApartado.ShowDialog();
        }

        private void Btncons_Apartado_Click(object sender, EventArgs e)
        {
            Frm_ConsultarApartados mApartado = new Frm_ConsultarApartados();
            mApartado.ShowDialog();
        }

        private void BtnProducto_Click(object sender, EventArgs e)
        {
            Frm_AltaProductos mProducto = new Frm_AltaProductos();
            mProducto.ShowDialog();
        }

        private void Btncons_Producto_Click(object sender, EventArgs e)
        {
            Frm_ConsultaProductos mProducto = new Frm_ConsultaProductos();
            mProducto.ShowDialog();
        }




        //estos son codigos de eventos en el cual al pasar el mouse sobre los botones cambian de color
        private void BtnApartado_MouseEnter(object sender, EventArgs e)
        {
            this.BtnApartado.BackColor = Color.SpringGreen;
        }

        private void BtnApartado_MouseLeave(object sender, EventArgs e)
        {
            this.BtnApartado.BackColor = Color.MediumSeaGreen;                ; 
        }

        private void BtnProducto_MouseEnter(object sender, EventArgs e)
        {
            this.BtnProducto.BackColor = Color.Aqua;
        }

        private void BtnProducto_MouseLeave(object sender, EventArgs e)
        {
            this.BtnProducto.BackColor = Color.DarkTurquoise;
        }

        private void Btncons_Apartado_MouseEnter(object sender, EventArgs e)
        {
            this.Btncons_Apartado.BackColor = Color.Gold;
        }

        private void Btncons_Apartado_MouseLeave(object sender, EventArgs e)
        {
            this.Btncons_Apartado.BackColor = Color.Orange;
        }

        private void Btncons_Producto_MouseEnter(object sender, EventArgs e)
        {
            this.Btncons_Producto.BackColor = Color.PeachPuff;
        }

        private void Btncons_Producto_MouseLeave(object sender, EventArgs e)
        {
            this.Btncons_Producto.BackColor = Color.Peru;
        }

        private void BtnSalir_MouseEnter(object sender, EventArgs e)
        {
            this.BtnSalir.BackColor = Color.Red;
        }

        private void BtnSalir_MouseLeave(object sender, EventArgs e)
        {
            this.BtnSalir.BackColor = Color.OrangeRed;
        }

        private void BtnProducto_Click_1(object sender, EventArgs e)
        {

        }
    }
}
