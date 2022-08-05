using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SistemaApartados.Datos;
using SistemaApartados.BaseDatos;
using MySql.Data.MySqlClient;
using System.Collections;
using SistemaApartados.Control;

namespace SistemaApartados
{
    public partial class Frm_AltaProductos : Form
    {
        private bool Correcto = false;
        private ArrayList Productos = new ArrayList();
        private bool Existente = false;
        private int Subfijo =1;
        private string clave;
        
        public Frm_AltaProductos()
        {
            InitializeComponent();
            setProducto1();
        }

        public void setProducto1()
        {
            TxtPrecio.Text = "0";
            CbTipo_Producto.Text = "Alimentos";
            CbMarca.Text = "Otra";
            CbEspecie.Text = "Domesticos";
        }
        private void BtnGuardarproducto_Click(object sender, EventArgs e)
        {
            Producto mProducto = new Producto();
            BDconexion mConexion = new BDconexion();
            Existente = false;
            mProducto.Clave_Producto = lblClave.Text;
            clave = lblClave.Text;
            mProducto.Nombre_Producto = TxtNombre_Producto.Text;
            mProducto.Tipo = CbTipo_Producto.Text;
            mProducto.Marca = CbMarca.Text;
            mProducto.Especie = CbEspecie.Text;
            mProducto.Existente = 0;
            try
            {
                Correcto = false;
                mProducto.Precio = float.Parse(TxtPrecio.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Valores inválidos y/o Faltan Datos");
                mProducto.Precio = 0;
            }


            if (mConexion.Conectar())
            {
                if (mProducto.Clave_Producto == "Clave" || mProducto.Nombre_Producto == " " ||
                    mProducto.Precio == 0 || mProducto.Nombre_Producto.Length < 3)
                {
                    MessageBox.Show("No existe algún dato");
                    lblClave.Text = "Clave";
                }
                else
                {
                    while (Correcto == false)
                    {
                        ControlProducto mControl = new ControlProducto();
                        Productos = new ArrayList();
                        Productos = mControl.cargarPro();
                        for (int i = 0; i < Productos.Count; i++)
                        {
                            Producto mPro = new Producto();
                            mPro = (Producto) Productos[i];
                            string nom = mPro.Nombre_Producto.ToUpper();
                            string cla = mPro.Clave_Producto.Substring(0,6).ToUpper();
                            if (mProducto.Clave_Producto.ToUpper() == cla &&
                                mProducto.Nombre_Producto.ToUpper() == nom)
                            {
                                Existente = true;
                                if (mPro.Existente== 1)
                                {
                                    Existente = false;
                                    mPro.Existente = 0;
                                    mPro.Precio = int.Parse(TxtPrecio.Text);
                                    if (mControl.reactivarProducto(mPro))
                                    {
                                        MessageBox.Show("Producto Agregado");
                                        Correcto = true;
                                        lblClave.Text = "Clave";
                                        TxtNombre_Producto.Text = "";
                                        Correcto = true;
                                    }
                                    
                                }
                            }
                        }
                        if (Existente == true)
                        {
                            MessageBox.Show("Producto ya Existente");
                            Correcto = true;
                            lblClave.Text = "Clave";
                        }
                        else
                        {
                            if (mControl.agregarProducto(mProducto))
                            {
                                MessageBox.Show("Producto Agregado");
                                Correcto = true;
                                lblClave.Text = "Clave";
                            }
                            clave = lblClave.Text;
                            clave += Subfijo;
                            Subfijo++;
                            mProducto.Clave_Producto = clave;
                        }
                    }  
                       
                }
            }
            mConexion.Desconectar();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        { 
            this.Close();
        }

        private void BtnGenerar_Clave_Click(object sender, EventArgs e)
        {
            Producto mProducto;
            mProducto = new Producto();
            mProducto.Nombre_Producto = TxtNombre_Producto.Text;
            mProducto.Tipo = CbTipo_Producto.Text;
            mProducto.Marca = CbMarca.Text;
            mProducto.Especie = CbEspecie.Text;

            Frm_AltaProductos mAlta = new Frm_AltaProductos();
            if (mProducto.Clave_Producto == " " || mProducto.Nombre_Producto == " " || mProducto.Nombre_Producto.Length < 3)
            {
                MessageBox.Show("No existe algun dato");
            }
            else
            {
                clave = mProducto.Tipo.Substring(0, 1)
                    + mProducto.Especie.Substring(0, 1)
                    + mProducto.Marca.Substring(0, 1)
                    + mProducto.Nombre_Producto.Substring(0, 3);
                lblClave.Text = clave.ToUpper();
            } 
        }

        private void TxtPrecio_KeyUp(object sender, KeyEventArgs e)
        {
            ValidarCampoDecimal((TextBox)sender);
        }
        public static bool ValidarCampoDecimal(TextBox CajaDeTexto)
        {
            try
            {
                decimal d = Convert.ToDecimal(CajaDeTexto.Text);
                return true;
            }
            catch (Exception)
            {
                CajaDeTexto.Text = "0";
                CajaDeTexto.Select(0, CajaDeTexto.Text.Length);
                return false;
            }
        }

        private void BtnGenerar_Clave_MouseEnter(object sender, EventArgs e)
        {
            this.BtnGenerar_Clave.BackColor = Color.LightSalmon;
        }

        private void BtnGenerar_Clave_MouseLeave(object sender, EventArgs e)
        {
            this.BtnGenerar_Clave.BackColor = Color.Salmon;
        }

        private void BtnGuardarProducto_MouseEnter(object sender, EventArgs e)
        {
            this.BtnGuardarProducto.BackColor = Color.LightBlue;
        }

        private void BtnGuardarProducto_MouseLeave(object sender, EventArgs e)
        {
            this.BtnGuardarProducto.BackColor = Color.SteelBlue;
        }

        private void BtnCancelar_MouseEnter(object sender, EventArgs e)
        {
            this.BtnCancelar.BackColor = Color.Gold;
        }

        private void BtnCancelar_MouseLeave(object sender, EventArgs e)
        {
            this.BtnCancelar.BackColor = Color.Goldenrod;
        }

        private void TxtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
