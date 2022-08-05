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

namespace SistemaApartados.Interfaz
{
    public partial class Frm_ReporteApartados : Form
    {
        public Frm_ReporteApartados()
        {
            InitializeComponent();
        }

        public void SetListaApartados(ArrayList ListaApartados)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", ListaApartados));

            reportViewer1.RefreshReport();
        }

        private void Frm_ReporteApartados_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
