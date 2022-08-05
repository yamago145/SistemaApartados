using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SistemaApartados.BaseDatos;
using SistemaApartados.Interfaz;
using SistemaApartados.Datos;
using System.Collections;
using SistemaApartados.Control;

namespace SistemaApartados
{
    public partial class Frm_ConsultaProductos : Form
    {
        private ArrayList ListaProductos;
        private Producto mProducto;
        public Frm_ConsultaProductos()
        {
            InitializeComponent();
        }
        public void actualizarProductos()
        {
            ControlProducto mControl = new ControlProducto();
            ArrayList ListaPro = new ArrayList();
            ListaPro = mControl.buscarNombre2("");
            DgLista.DataSource = new Object();
            DgLista.DataSource = ListaPro;
        }
        public void setProducto(Producto mProducto)
        {
            this.mProducto = mProducto;
            TxtNombre_Producto.Text = mProducto.Nombre_Producto;
        }

        private void BtnModificar_Producto_Click(object sender, EventArgs e)
        {
            Frm_ModificarProducto mModificar = new Frm_ModificarProducto();
            try
            {
                Producto mProducto = new Producto();
                int indice = DgLista.SelectedRows[0].Index;
                mProducto = (Producto)ListaProductos[indice];
                
                mModificar.SetProducto(mProducto); 
                mModificar.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha seleccionado producto a modificar");
            } 
        }

        private void BtnBaja_Producto_Click(object sender, EventArgs e)
        {
            try
            {
                mProducto = (Producto)ListaProductos[DgLista.CurrentRow.Index];
                MessageBox.Show("Se eliminara el producto: " + mProducto.Nombre_Producto);

                ControlProducto mControl = new ControlProducto();
                mControl.eliminarProducto(mProducto);
                MessageBox.Show("Producto eliminado");

                
                ListaProductos = new ArrayList();
                ListaProductos = mControl.buscarNombre2("");
                DgLista.DataSource = null;
                DgLista.DataSource = ListaProductos;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar el producto");
            }
        }

        private void BtnGenerar_Reporte_Click(object sender, EventArgs e)
        {
            ControlProducto mCP = new ControlProducto();
            ListaProductos = new ArrayList();
            ListaProductos = mCP.consultarTodosProductos();

            Frm_ReporteProducto mFrm_RP = new Frm_ReporteProducto();
            mFrm_RP.SetListaProductos(ListaProductos);
            mFrm_RP.Show();
        }

        private void BtnGenerar_Reporte_MouseLeave(object sender, EventArgs e)
        {
            this.BtnGenerar_Reporte.BackColor = Color.Gold;
        }

        private void BtnGenerar_Reporte_MouseEnter(object sender, EventArgs e)
        {
            this.BtnGenerar_Reporte.BackColor = Color.Yellow;
        
        }

        private void BtnModificar_Producto_MouseEnter(object sender, EventArgs e)
        {
            this.BtnModificar_Producto.BackColor = Color.Orange;
        }

        private void BtnModificar_Producto_MouseLeave(object sender, EventArgs e)
        {
            this.BtnModificar_Producto.BackColor = Color.DarkOrange;
        }

        private void BtnBaja_Producto_MouseEnter(object sender, EventArgs e)
        {
            this.BtnBaja_Producto.BackColor = Color.Tomato;
        }

        private void BtnBaja_Producto_MouseLeave(object sender, EventArgs e)
        {
            this.BtnBaja_Producto.BackColor = Color.OrangeRed;
        }

        private void TxtID_Clave_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                ControlProducto mControl = new ControlProducto();
                ListaProductos = mControl.buscarClave(TxtID_Clave.Text);
                DgLista.DataSource = ListaProductos;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void TxtNombre_Producto_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                ControlProducto mControl = new ControlProducto();
                ListaProductos = new ArrayList();
                ListaProductos = mControl.buscarNombre2(TxtNombre_Producto.Text);
                DgLista.DataSource = ListaProductos;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
    }
}
