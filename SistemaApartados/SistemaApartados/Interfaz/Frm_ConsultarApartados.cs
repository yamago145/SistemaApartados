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

namespace SistemaApartados
{
    public partial class Frm_ConsultarApartados : Form
    {
        private ArrayList Lista;
        private string nNombre;
        private string nFolio;

        private ArrayList ListaApartados;
        private Apartado mApartado;
        public Frm_ConsultarApartados()
        {
            InitializeComponent();

        }

        public void actualizarTabla(ArrayList lista1)
        {
            Lista = lista1;
            DgvApartados.DataSource = null;
            DgvApartados.DataSource = Lista;
        }
        private void BtnReporte_Click(object sender, EventArgs e)
        {
            ControlApartado mCA = new ControlApartado();
            ListaApartados = new ArrayList();
            ListaApartados = mCA.consultarTodosApartados();

            Frm_ReporteApartados mFrm_RA = new Frm_ReporteApartados();
            mFrm_RA.SetListaApartados(ListaApartados);
            mFrm_RA.Show();
        }

        private void BtnModificarApartado_Click(object sender, EventArgs e)
        {
            Frm_ModificarApartado mModificar = new Frm_ModificarApartado();

            try
            {
                Apartado mApartado = new Apartado();
                int indice = DgvApartados.SelectedRows[0].Index;
                mApartado = (Apartado)Lista[indice];

                ControlProducto mControl = new ControlProducto();
                ControlCliente mControlC = new ControlCliente();
                string NombreCliente="";
                NombreCliente = mControlC.seleccionarCliente(mApartado.IdCliente.ID_Cliente);
                Lista = mControl.verProductos(mApartado.Folio);

                mModificar.SetApartado(mApartado,NombreCliente,Lista);
                mModificar.agregarValores(nFolio,nNombre);
                mModificar.ShowDialog();
                this.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("No se ha seleccionado ningun apartado");
            }
        }

        private void BtnBajaApartado_Click(object sender, EventArgs e)
        {
            try
            {
                ApartadosDisponibles mApartado = new ApartadosDisponibles();
                int indice = DgvApartados.SelectedRows[0].Index;
                mApartado = (ApartadosDisponibles)Lista[indice];

                ControlApartado mControl = new ControlApartado();
                mControl.inhabilitarApartado(mApartado);

                mControl.generarCredito(mApartado);

                ControlApartado mCA = new ControlApartado();
                ListaApartados = new ArrayList();
                ListaApartados = mCA.buscarNota(mApartado);

                Frm_NotaCredito mFrm_NC = new Frm_NotaCredito();
                mFrm_NC.SetDatosLiquidacion(ListaApartados);
                mFrm_NC.Show();


                DgvApartados.DataSource = null;
                Lista = mControl.buscarApartadoFolio(TxtFolio.Text);
                DgvApartados.DataSource = Lista;
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha seleccionado ningun apartado");
            }
            
        }

        private void BtnLiquidar_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_LiquidarApartado mLiquidar = new Frm_LiquidarApartado();
                

                int i = DgvApartados.SelectedRows[0].Index;
                ApartadosDisponibles mApartado = new ApartadosDisponibles();
                mApartado = (ApartadosDisponibles)Lista[i];

                ControlCliente mControlC = new ControlCliente();
                string NombreCliente = "";
                NombreCliente = mControlC.seleccionarCliente(mApartado.IdCliente);
                mLiquidar.setApartado(mApartado,NombreCliente);

                mLiquidar.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha seleccionado ningún apartado");
            }
        }

        private void BtnReporte_MouseEnter(object sender, EventArgs e)
        {
            this.BtnReporte.BackColor = Color.Aquamarine;
        }

        private void BtnReporte_MouseLeave(object sender, EventArgs e)
        {
            this.BtnReporte.BackColor = Color.MediumSpringGreen;
        }

        private void BtnModificarApartado_MouseEnter(object sender, EventArgs e)
        {
            this.BtnModificarApartado.BackColor = Color.OldLace;
        }

        private void BtnModificarApartado_MouseLeave(object sender, EventArgs e)
        {
            this.BtnModificarApartado.BackColor = Color.Moccasin;
        }

        private void BtnBajaApartado_MouseEnter(object sender, EventArgs e)
        {
            this.BtnBajaApartado.BackColor = Color.Gold;
        }

        private void BtnBajaApartado_MouseLeave(object sender, EventArgs e)
        {
            this.BtnBajaApartado.BackColor = Color.Goldenrod;
        }

        private void BtnLiquidar_MouseLeave(object sender, EventArgs e)
        {
            this.BtnLiquidar.BackColor = Color.MediumPurple;
        }

        private void BtnLiquidar_MouseEnter(object sender, EventArgs e)
        {
            this.BtnLiquidar.BackColor = Color.MediumOrchid;
        }

        private void TxtNombreCliente_KeyUp(object sender, KeyEventArgs e)
        {
            ControlApartado mControl = new ControlApartado();
            Lista = mControl.buscarApartadoClientes(TxtNombreCliente.Text);
            DgvApartados.DataSource = Lista;
            nNombre = TxtNombreCliente.Text;
        }

        private void TxtFolio_KeyUp(object sender, KeyEventArgs e)
        {
            ControlApartado mControl = new ControlApartado();
            Lista = mControl.buscarApartadoFolio(TxtFolio.Text);
            DgvApartados.DataSource = Lista;
            nFolio = TxtFolio.Text;
        }

        
    }
}
