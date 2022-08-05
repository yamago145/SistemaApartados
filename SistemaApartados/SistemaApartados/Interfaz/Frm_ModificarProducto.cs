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
using SistemaApartados.Interfaz;
using System.Collections;
using SistemaApartados.Control;

namespace SistemaApartados.Interfaz
{
    public partial class Frm_ModificarProducto : Form
    {
        private Producto mProducto;
        private ArrayList Productos;
        private bool Existente = false;
        private string clave;
        private bool Correcto =false;
        private int Subfijo = 1;
        public Frm_ModificarProducto()
        {
            InitializeComponent();
            clave = " ";
            extraerProductos();
        }

        public void extraerProductos()
        {
            ControlProducto mConexion = new ControlProducto();
            Productos = mConexion.cargarPro();
        }
        public void SetProducto(Producto mProducto)
        {
            this.mProducto = mProducto;
            TxbNombre_Producto.Text = mProducto.Nombre_Producto;
            CbTipoProducto.Text = mProducto.Tipo;
            Cb_Marca.Text = mProducto.Marca;
            CB_Especie.Text = mProducto.Especie;
            TxbPrecioProducto.Text = mProducto.Precio.ToString();
            Lbl_Clave.Text = "CLAVE";
             
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_ConsultaProductos mConsulta = new Frm_ConsultaProductos();
            mConsulta.actualizarProductos();
        }


        private void BtnGenerarClave_Click(object sender, EventArgs e)
        {
            
            Producto mProducto1;
            mProducto1 = new Producto();
            if (mProducto.Clave_Producto == " " || mProducto.Nombre_Producto == " " || mProducto.Nombre_Producto.Length < 3)
            {
                MessageBox.Show("No existe algún dato");
            }
            else
            {
                mProducto1.Nombre_Producto = TxbNombre_Producto.Text;
                mProducto1.Tipo = CbTipoProducto.Text;
                mProducto1.Marca = Cb_Marca.Text;
                mProducto1.Especie = CB_Especie.Text;
                clave = mProducto1.Tipo.Substring(0, 1)
                        + mProducto1.Especie.Substring(0, 1)
                        + mProducto1.Marca.Substring(0, 1)
                        + mProducto1.Nombre_Producto.Substring(0, 3);
                Lbl_Clave.Text = clave.ToUpper();
            }
        }

       private void BtnGuardar_Producto_Click(object sender, EventArgs e)
        {
            try
            {
                Correcto = false;
                Producto mProducto1 = new Producto();
                mProducto1.Clave_Producto = Lbl_Clave.Text; 
                mProducto1.Nombre_Producto = TxbNombre_Producto.Text;
                mProducto1.Tipo = CbTipoProducto.Text;
                mProducto1.Marca = Cb_Marca.Text;
                mProducto1.Especie = CB_Especie.Text;
                try
                {
                    mProducto1.Precio = float.Parse(TxbPrecioProducto.Text);
                }
                catch (Exception)
                {
                    throw;
                }
            
                if (mProducto1.Clave_Producto == "CLAVE" || mProducto1.Nombre_Producto == " " ||
                    mProducto1.Precio == 0 || mProducto1.Nombre_Producto.Length < 3)
                {
                    MessageBox.Show("No existe algún dato");
                }
                else
                {
                    while (Correcto == false)
                    {
                        ControlProducto mControl = new ControlProducto();
                        Productos = new ArrayList();
                        Productos = mControl.cargarPro0();
                        for (int i = 0; i < Productos.Count; i++)
                        {
                            Producto mPro = new Producto();
                            mPro = (Producto)Productos[i];
                            string nom = mPro.Nombre_Producto.ToUpper();
                            string cla = mPro.Clave_Producto.Substring(0, 6).ToUpper();
                            if (mProducto.Clave_Producto.ToUpper() == cla &&
                                mProducto.Nombre_Producto.ToUpper() == nom)
                            {
                                Existente = true;
                                if (mPro.Precio != mProducto1.Precio)
                                {
                                    Existente = false;
                                    mPro.Existente = 0;
                                    if (mControl.modificarPrecio(mProducto1))
                                    {
                                        MessageBox.Show("Producto Modificado");
                                        Correcto = true;
                                        Lbl_Clave.Text = "Clave";
                                        TxbNombre_Producto.Text = "";
                                    }

                                }
                            }
                        } 
                        if (Existente == true)
                        {
                            MessageBox.Show("Producto ya Existente");
                            Correcto = true;
                            Lbl_Clave.Text = "Clave";
                        }
                        else
                        {
                            if(mControl.modificarProducto(mProducto, mProducto1))
                            clave = Lbl_Clave.Text;
                            clave += Subfijo;
                            Subfijo++;
                            mProducto.Clave_Producto = clave;
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Producto no modificado");
            }  
        }

       private void BtnGenerarClave_MouseEnter(object sender, EventArgs e)
       {
           this.BtnGenerarClave.BackColor = Color.Cyan;
       }

       private void BtnGenerarClave_MouseLeave(object sender, EventArgs e)
       {
           this.BtnGenerarClave.BackColor = Color.Turquoise;
       }

       private void BtnGuardar_Producto_MouseEnter(object sender, EventArgs e)
       {
           this.BtnGuardar_Producto.BackColor = Color.Coral;
       }

       private void BtnGuardar_Producto_MouseLeave(object sender, EventArgs e)
       {
           this.BtnGuardar_Producto.BackColor = Color.LightCoral;
       }

       private void BtnCancelar_MouseEnter(object sender, EventArgs e)
       {
           this.BtnCancelar.BackColor = Color.Tomato;
       }

       private void BtnCancelar_MouseLeave(object sender, EventArgs e)
       {
           this.BtnCancelar.BackColor = Color.Red;
       }

       private void TxbPrecioProducto_KeyUp(object sender, KeyEventArgs e)
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
    }
}
