using SistemaApartados.BaseDatos;
using SistemaApartados.Control;
using SistemaApartados.Datos;
using SistemaApartados.Interfaz;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaApartados.Interfaz
{
    public partial class Frm_ModificarApartado : Form
    {
        private Apartado mApartado;
        private ArrayList ListaProductos;
        private ArrayList ListaModificar;
        private ArrayList Lista;
        private ArrayList Consulta;
        private ArrayList Productos;
        private float total;
        private float enganche;
        private string folio;
        private string nNombre;
        private string nFolio;
        public Frm_ModificarApartado()
        {
            InitializeComponent();
            insertarProductos();
            txtImporte_Enganche.Text = "0";
        }

        public void agregarValores(string n1, string n2)
        {
            nFolio = n1;
            nNombre = n2;
        }
        public void SetApartado(Apartado mApa, string nom,ArrayList Lista)
        {
            mApartado = mApa;
            folio = mApa.Folio;
            Lbl_IDcliente.Text = mApartado.IdCliente.ID_Cliente.ToString();
            LblNombreCliente.Text = nom;
            DtgListaProductos.DataSource = null;
            ListaProductos = new ArrayList();
            ListaModificar = Lista;
            ListaProductos = Lista;
            DtgListaProductos.DataSource = ListaProductos;
            LblTotal.Text = mApartado.Total.ToString();
            LblEnganche.Text = mApartado.Importe_Enganche.ToString();
            DtpFecha.Text = mApartado.Fecha_Entrega;
            total = mApa.Total;
            enganche = mApa.Importe_Enganche;
        }

        public void insertarProductos()
        {
            ControlProducto mControl = new ControlProducto();
            Productos = mControl.cargarPro0();
            for (int i = 0; i < Productos.Count; i++)
            {
                Producto mProducto = new Producto();
                mProducto = (Producto)Productos[i];
                CmbProducto.Items.Add(mProducto.Nombre_Producto);
            }
        }


        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CmbProducto.Text != "")
                {

                    bool encontrado = false;
                    ControlApartado mControl = new ControlApartado();
                    ControlProducto mControlP = new ControlProducto();
                    ProductoVenta mProducto1 = new ProductoVenta();
                    Producto mProd = new Producto();
                    int isp = CmbProducto.SelectedIndex;
                    mProd = (Producto)Productos[isp];

                    mProducto1 = mControlP.buscarNombre(mProd);
                    Lbl_Precio.Text = mProducto1.Precio.ToString();

                    mProducto1.Cantidad = float.Parse(TxtCantidadProducto.Text);
                    mProducto1.Subtotal = mProducto1.Precio * mProducto1.Cantidad;

                    if (ListaProductos == null)
                    {
                        ListaProductos = new ArrayList();
                        ListaProductos.Add(mProducto1);
                        total = mProducto1.Subtotal;
                    }
                    else
                    {
                        for (int i = 0; i < ListaProductos.Count; i++)
                        {
                            ProductoVenta mProducto = new ProductoVenta();
                            mProducto = (ProductoVenta) ListaProductos[i];
                            string clave = mProducto.Clave_Producto;
                            if (mProducto1.Clave_Producto == clave)
                            {
                                encontrado = true;
                            }
                        }
                        if (encontrado == false)
                        {
                            ListaProductos.Add(mProducto1);
                            total += mProducto1.Subtotal;
                        }
                    }


                    DtgListaProductos.DataSource = new Object();
                    DtgListaProductos.DataSource = ListaProductos;
                    LblTotal.Text = total.ToString();
                    enganche = (float)(total * 0.30);
                    LblEnganche.Text = enganche.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnQuitarProducto_Click(object sender, EventArgs e)
        {
            if (ListaProductos.Count != 0)
            {
                float menos = (float)DtgListaProductos.SelectedRows[0].Cells[7].Value;
                total -= menos;
                enganche = (float)(total * 0.30);
                LblTotal.Text = total.ToString();
                LblEnganche.Text = enganche.ToString();
                int indice = DtgListaProductos.SelectedRows[0].Index;
                ListaProductos.RemoveAt(indice);
                DtgListaProductos.DataSource = null;
                DtgListaProductos.DataSource = ListaProductos;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            bool guardado = false;
            string fol;
            Apartado mApartado = new Apartado();
            BDconexion mBD = new BDconexion();
            ControlApartado mControl = new ControlApartado();
            Cliente mCliente = new Cliente();
            mApartado.IdCliente = new Cliente();

            mApartado.Fecha_Pedido = DateTime.Now.ToString("yyyy/MM/dd");
            mApartado.Fecha_Entrega = DtpFecha.Value.ToString("yyyy/MM/dd");
            mApartado.Total = total;
            mApartado.Importe_Enganche = enganche;
            mApartado.IdCliente.ID_Cliente = 0;
            mApartado.IdCliente.ID_Cliente = int.Parse(Lbl_IDcliente.Text);
            fol = DateTime.Now.ToString("yy");
            fol += DateTime.Now.ToString("MM");
            fol += DateTime.Now.ToString("dd");
            
            mApartado.Importe = float.Parse(txtImporte_Enganche.Text);
            
            int fol1;
            fol1 = int.Parse(fol) * 10 + 1;
            mApartado.Folio = fol1.ToString();

            int fecha = 0;
            fecha = DtpFecha.Value.CompareTo(DateTime.Now);

            if (fecha > 0)
            {
                if (total != 0 && txtImporte_Enganche.Text.Replace(" ","") != "")
                {
                    while (guardado == false)
                    {
                        try
                        {
                            if (mControl.borrarCantidades(folio))
                            {
                                if (txtImporte_Enganche.Text == "0")
                                {
                                    MessageBox.Show("Es necesario agregar el enganche");
                                    guardado = true;
                                }
                                else
                                {
                                    if (mControl.modificarApartado(mApartado, folio))
                                    {
                                        MessageBox.Show("Apartado guardado");
                                        guardado = true;

                                        for (int i = 0; i < ListaProductos.Count; i++)
                                        {
                                            ProductoVenta mProducto = new ProductoVenta();
                                            mProducto = (ProductoVenta)ListaProductos[i];
                                            mControl.relacionarProductos(mProducto, mApartado);
                                        }

                                        Frm_ConsultarApartados mConsulta = new Frm_ConsultarApartados();
                                        if (nFolio!= "")
                                        {
                                            Lista = mControl.buscarApartadoFolio(nFolio);
                                        }
                                        else
                                        {
                                            Lista = mControl.buscarApartadoClientes(nNombre);
                                        }
                                        mConsulta.actualizarTabla(Lista);
                                    }
                                    else
                                    {
                                        guardado = false;
                                        fol1 += 1;
                                        mApartado.Folio = fol1.ToString();
                                    }
                                }
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Apartado no guardado");

                        }
                    }

                }
                else
                {
                    MessageBox.Show("No hay productos agregados");
                }
            }
            else
            {
                MessageBox.Show("La fecha de entrega debe ser mayor a la actual");
            }
        }

        private void BtnAgregar_MouseLeave(object sender, EventArgs e)
        {
            this.BtnAgregar.BackColor = Color.LimeGreen;
        }

        private void BtnAgregar_MouseEnter(object sender, EventArgs e)
        {
            this.BtnAgregar.BackColor = Color.SpringGreen;
        }

        private void BtnQuitarProducto_MouseLeave(object sender, EventArgs e)
        {
            this.BtnQuitarProducto.BackColor = Color.Red;
        }

        private void BtnQuitarProducto_MouseEnter(object sender, EventArgs e)
        {
            this.BtnQuitarProducto.BackColor = Color.Tomato;
        }

        private void BtnGuardar_MouseLeave(object sender, EventArgs e)
        {
            this.BtnGuardar.BackColor = Color.MediumTurquoise;
        }

        private void BtnGuardar_MouseEnter(object sender, EventArgs e)
        {
            this.BtnGuardar.BackColor = Color.Aqua;
        }
    }
}
