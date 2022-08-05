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
using System.Threading;
using System.Collections;
using SistemaApartados.Control;

namespace SistemaApartados
{
    public partial class Frm_AltaApartados : Form
    {
        private ArrayList ListaProductos;
        private ArrayList Clientes;
        private ArrayList Productos;
        private float total;
        private float enganche;
        private bool Correcto = false;
        private bool Valido = false;
        public Frm_AltaApartados()
        {
            InitializeComponent();
            insertarClientes();
            insertarProductos();
            DtpFecha.Value = DateTime.Now;
            DtpFechaEntrega.Value = DateTime.Now;
            ListaProductos = new ArrayList();
            total = 0;
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

        public void insertarClientes()
        {
            while (Cmb_Cliente.Items.Count > 0)
            {
                Cmb_Cliente.Items.RemoveAt(0);
            }

            
            ControlCliente mControl = new ControlCliente();
            Clientes = new ArrayList();
            Clientes = mControl.cargarCli();
            for (int i = 0; i < Clientes.Count; i++)
            {
                Cliente mCliente = new Cliente();
                mCliente = (Cliente)Clientes[i];
                Cmb_Cliente.Items.Add(mCliente.Nombre_Cliente);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CmbProducto.Text != " " && txtCantidadProducto.Text!="0")
                {
                    bool encontrado = false;
                    ProductoVenta mProducto1 = new ProductoVenta();
                    ControlProducto mControl = new ControlProducto();
                    Producto mProd = new Producto();
                    //int indice = DgLista.SelectedRows[0].Index;
                    int isp = CmbProducto.SelectedIndex;
                    mProd = (Producto)Productos[isp];
                    
                    mProducto1 = mControl.buscarNombre(mProd);
                    Lbl_Precio.Text = mProducto1.Precio.ToString();
                    

                    mProducto1.Cantidad = float.Parse(txtCantidadProducto.Text);
                    mProducto1.Subtotal = mProducto1.Precio * mProducto1.Cantidad;

                    if (ListaProductos.Count == 0)
                    {
                        ListaProductos.Add(mProducto1);
                        total = mProducto1.Subtotal;
                    }
                    else
                    {
                        for (int i = 0; i < ListaProductos.Count; i++)
                        {
                            ProductoVenta mProducto = new ProductoVenta();
                            mProducto = (ProductoVenta)ListaProductos[i];
                            if(mProducto.Clave_Producto == mProducto1.Clave_Producto&&
                                mProducto1.Nombre_Producto == mProducto.Nombre_Producto)
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


                    DtgListaApartados.DataSource = new Object();
                    DtgListaApartados.DataSource = ListaProductos;
                    LblTotal.Text = total.ToString();
                    enganche = (float)(total * 0.30);
                    LblEnganche.Text = enganche.ToString();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        private void BtnQuitarProducto_Click(object sender, EventArgs e)
        {
            if (ListaProductos.Count !=0)
            {
                float menos = (float)DtgListaApartados.SelectedRows[0].Cells[7].Value;
                total -= menos;
                enganche = (float)(total * 0.30);
                LblTotal.Text = total.ToString();
                LblEnganche.Text = enganche.ToString();
                int indice = DtgListaApartados.SelectedRows[0].Index;
                ListaProductos.RemoveAt(indice);
                DtgListaApartados.DataSource = null;
                DtgListaApartados.DataSource = ListaProductos;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                bool Existente = false;
                BDconexion mBD = new BDconexion();
                ControlApartado mControl = new ControlApartado();
                Cliente mCliente = new Cliente();
                Apartado mApartado = new Apartado();
                mApartado.IdCliente = new Cliente();
                mApartado.Fecha_Pedido = DtpFecha.Value.ToString("yyyy/MM/dd");
                mApartado.Fecha_Entrega = DtpFechaEntrega.Value.ToString("yyyy/MM/dd");
                mApartado.Total = total;
                mApartado.Importe_Enganche = enganche;
                mApartado.IdCliente.ID_Cliente = 0;
                mApartado.IdCliente.ID_Cliente = Cmb_Cliente.SelectedIndex+1;
                int fecha = DtpFecha.Value.DayOfYear;
                int fecha1 = DtpFechaEntrega.Value.DayOfYear;
                if (fecha >= DateTime.Now.DayOfYear&& fecha<fecha1)
                {
                    fecha = DtpFechaEntrega.Value.DayOfYear;
                    if (fecha <= DateTime.Now.AddMonths(1).DayOfYear || fecha<DateTime.Now.DayOfYear)
                    {
                        bool guardado = false;
                        string fol = "";
                        fol = DtpFecha.Value.ToString("yy");
                        fol += DtpFecha.Value.ToString("MM");
                        fol += DtpFecha.Value.ToString("dd");
                        try
                        {
                            mApartado.Importe = float.Parse(txtImporteEnganche.Text);
                            Valido = true;
                        }
                        catch (Exception)
                        {
                            Valido = false;
                        }
                    
                        int fol1 = int.Parse(fol);
                        fol1 = fol1 * 10 + 1;
                        mApartado.Folio = fol1.ToString();

                        if (total != 0&& Valido == true && Cmb_Cliente.Text!="")
                        {
                            while (guardado == false)
                            {
                                try
                                {
                                    ArrayList Apartados = new ArrayList();
                                    Apartados = mControl.buscarApartados();
                                    if (Apartados == null)
                                    {
                                        if (mControl.agregarApartado(mApartado))
                                        {
                                            Correcto = true;
                                            MessageBox.Show("Apartado guardado");
                                            guardado = true;

                                            for (int i = 0; i < ListaProductos.Count; i++)
                                            {
                                                ProductoVenta mProducto = new ProductoVenta();
                                                mProducto = (ProductoVenta)ListaProductos[i];
                                                mControl.relacionarProductos(mProducto, mApartado);
                                            }
                                        }
                                        else
                                        {
                                            guardado = false;
                                            fol1 += 1;
                                            mApartado.Folio = fol1.ToString();
                                        }
                                    }
                                    else
                                    {
                                        for (int i = 0; i < Apartados.Count; i++)
                                        {
                                            ApartadosDisponibles mApa = new ApartadosDisponibles();
                                            mApa = (ApartadosDisponibles)Apartados[i];
                                            if (mApa.IdCliente == mApartado.IdCliente.ID_Cliente)
                                            {
                                                Existente = true;
                                            }
                                            if (mApartado.Folio == mApa.Folio)
                                            {
                                                fol1++;
                                                mApartado.Folio = fol1.ToString();
                                            }
                                        }
                                        if (Existente == false)
                                        {
                                            if (mControl.agregarApartado(mApartado))
                                            {
                                                Correcto = true;
                                                MessageBox.Show("Apartado guardado");
                                                guardado = true;

                                                for (int i = 0; i < ListaProductos.Count; i++)
                                                {
                                                    ProductoVenta mProducto = new ProductoVenta();
                                                    mProducto = (ProductoVenta)ListaProductos[i];
                                                    mControl.relacionarProductos(mProducto, mApartado);
                                                }
                                            }
                                            else
                                            {
                                                guardado = false;
                                                fol1 += 1;
                                                mApartado.Folio = fol1.ToString();
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Éste cliente ya tiene un pedido pendiente es mejor hacer una modificación al existente");
                                            guardado = true;
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
                            MessageBox.Show("No se han llenado todos los campos necesarios");
                            Correcto = false;
                        }

                        if (Correcto == true)
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("La fecha limite debe ser un mes o debe ser mayor a la fecha actual");
                    }
                }
                else
                {
                    MessageBox.Show("La fecha debe ser mayor a la fecha actual");
                }
            }
            catch (Exception)
            {
            
            }
        }

        private void Btn_GuardarCliente_Click(object sender, EventArgs e)
        {
            Cliente mCliente= new Cliente();
            BDconexion mBD = new BDconexion();
            Correcto = false;
            // mCliente.ID_Cliente = int.Parse(txtID_cliente.Text);
            mCliente.Nombre_Cliente = txtNombreCliente.Text;
            mCliente.ID_Cliente = 1;

            if (mBD.Conectar())
            {
                if (mCliente.Nombre_Cliente == " " || mCliente.Nombre_Cliente.Replace(" ","") == ""||
                    mCliente.Nombre_Cliente.Length < 4)
                {
                    MessageBox.Show("Faltan datos del Cliente o el nombre no es valido");
                    txtNombreCliente.Text = "";
                }
                else
                {
                    while (Correcto == false)
                    {
                        try
                        {
                            bool existente = false;
                            for (int i = 0; i < Clientes.Count; i++)
                            {
                                Cliente mCli = new Cliente();
                                mCli = (Cliente)Clientes[i];

                                if (mCli.Nombre_Cliente.ToUpper() == txtNombreCliente.Text.ToUpper())
                                {
                                    existente = true;
                                }
                            }
                            if (existente == false)
                            {
                                ControlCliente mControl = new ControlCliente();
                                if (mControl.guardarCliente(mCliente))
                                {
                                    MessageBox.Show("Cliente Guardado");
                                    txtNombreCliente.Text = "";
                                    insertarClientes();
                                    Correcto = true;

                                }
                                else
                                {
                                    Correcto = false;
                                    mCliente.ID_Cliente++;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Cliente ya existente");
                                Correcto = true;
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Cliente no guardado");
                        }
                    }
                }

            }
            mBD.Desconectar();
            Cmb_Cliente.Text = "";
        }

        private void BtnAgregar_MouseEnter(object sender, EventArgs e)
        {
            this.BtnAgregar.BackColor = Color.LightGreen;
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
            this.BtnGuardar.BackColor = Color.DodgerBlue;
        }

        private void BtnGuardar_MouseEnter(object sender, EventArgs e)
        {
            this.BtnGuardar.BackColor = Color.Cyan;
        }


        private void txtImporteEnganche_KeyUp(object sender, KeyEventArgs e)
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

        private void txtCantidadProducto_KeyUp(object sender, KeyEventArgs e)
        {
            ValidarCampoDecimal((TextBox)sender);
        }
     }
}
