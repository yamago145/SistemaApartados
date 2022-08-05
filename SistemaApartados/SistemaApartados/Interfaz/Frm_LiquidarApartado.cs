using SistemaApartados.Control;
using SistemaApartados.Datos;
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
    public partial class Frm_LiquidarApartado : Form
    {

        private float total;
        private float importe;
        private float cambio;
        private ApartadosDisponibles mApartado;
        private ArrayList ListaApartados;

        public Frm_LiquidarApartado()
        {
            InitializeComponent();
        }

        public void setApartado(ApartadosDisponibles mapa, string nom)
        {
            mApartado = new ApartadosDisponibles();
            mApartado.Folio = mapa.Folio;
            LblIDCliente.Text = mapa.IdCliente.ToString();
            LblNombre.Text = nom;
            DtpFecha.Value = DateTime.Parse(mapa.Fecha_Pedido);
            dtpFechaE.Value = DateTime.Parse(mapa.Fecha_Entrega);
            LblTotal.Text = mapa.Total.ToString();
            LblImporte.Text = mapa.Importe_Enganche.ToString();
            

            total = float.Parse(LblTotal.Text);
            importe = float.Parse(LblImporte.Text);
            cambio = total - importe;
            LblCantidadRestante.Text = cambio.ToString();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLiquidar_Click(object sender, EventArgs e)
        {
            try
            {
                float i = 0;

                ControlApartado mControl = new ControlApartado();
                if (LblCambio.Text == "Pago Insuficiente" || LblCambio.Text == "0.0")
                {
                    MessageBox.Show ("Cantidad Insuficiente");
                }
                else
                {
                    if (mControl.inhabilitarApartado(mApartado))
                    {
                        MessageBox.Show("Apartado Liquidado con éxito");
                        string nom = LblNombre.Text;
                        mApartado.Fecha_Pedido = DtpFecha.Value.ToString("dd/MM/yyyy");
                        mApartado.Fecha_Entrega = dtpFechaE.Value.ToString("dd/MM/yyyy");
                        mApartado.IdCliente = int.Parse(LblIDCliente.Text);
                        mApartado.Importe = float.Parse(LblImporte.Text);
                        mApartado.Total = float.Parse(LblTotal.Text);
                        mControl.generarLiquidacion(mApartado, nom);

                        ControlApartado mCA = new ControlApartado();
                        ListaApartados = new ArrayList();
                        ListaApartados = mCA.buscarNotaC(mApartado);

                        Frm_NLiquidacion mFrm_NL = new Frm_NLiquidacion();
                        mFrm_NL.SetDatosLiquidacion(ListaApartados);
                        mFrm_NL.Show();

                        this.Close();
                    }
                    else MessageBox.Show("Apartado no Liquidado");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Apartado no Liquidado");
            }
        }

        private void BtnCancelar_MouseEnter(object sender, EventArgs e)
        {
            this.BtnCancelar.BackColor = Color.Gold;
        }

        private void BtnCancelar_MouseLeave(object sender, EventArgs e)
        {
            this.BtnCancelar.BackColor = Color.DarkGoldenrod;
        }

        private void BtnLiquidar_MouseEnter(object sender, EventArgs e)
        {
            this.BtnLiquidar.BackColor = Color.SpringGreen;
        }

        private void BtnLiquidar_MouseLeave(object sender, EventArgs e)
        {
            this.BtnLiquidar.BackColor = Color.LimeGreen;
        }

        private void TxtEfectivo_KeyUp(object sender, KeyEventArgs e)
        {
            ValidarCampoDecimal((TextBox)sender);

            float resto;
            float resto2;
            resto = float.Parse(TxtEfectivo.Text);
            resto2 = resto - cambio;
            if (cambio > resto)
            {
                LblCambio.ForeColor = Color.Red;
                LblCambio.Text = "Pago Insuficiente";
            }
            else
            {
                LblCambio.ForeColor = Color.Black;
                LblCambio.Text = resto2.ToString();
            }
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
