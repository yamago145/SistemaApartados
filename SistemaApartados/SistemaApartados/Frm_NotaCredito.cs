using Microsoft.Reporting.WinForms;
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
    public partial class Frm_NotaCredito : Form
    {
        public Frm_NotaCredito()
        {
            InitializeComponent();
        }

        private void Frm_NotaCredito_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        public void SetDatosLiquidacion(ArrayList ListaProductos)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", ListaProductos));
            reportViewer1.RefreshReport();
        }
    }
}
