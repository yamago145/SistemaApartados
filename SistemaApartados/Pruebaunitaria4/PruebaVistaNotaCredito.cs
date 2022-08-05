using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaApartados.Datos;
using SistemaApartados.BaseDatos;
using SistemaApartados.Control;

namespace Pruebaunitaria4
{
    [TestClass]
    public class PruebaVistaNotaCredito
    {
        [TestMethod]
        public void PruebavistaNotaCreditotest()
        {
            BDconexion mBD = new BDconexion();
            ControlApartado mControl = new ControlApartado();
            ControlProducto mProducto = new ControlProducto();
            ControlCliente mCliente = new ControlCliente();
            //Apartado instance = new Apartado();
        }
        [TestMethod]
        public void setImportetest()
        {
            VistaNotaCredito instance = new VistaNotaCredito();
            instance.Importe = 23;
            Assert.AreEqual(instance.Importe, 23);
        }
        [TestMethod]
        public void setFoliotest()
        {
            VistaNotaCredito instance = new VistaNotaCredito();
            instance.Folio = "wed4";
            Assert.AreEqual(instance.Folio, "wed4");
        }
    }
}

