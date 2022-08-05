using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaApartados.Datos;
using SistemaApartados.BaseDatos;
using SistemaApartados.Control;

namespace Pruebaunitaria4
{
    [TestClass]
    public class PruebaNotaLiquidacion
    {
        [TestMethod]
        public void PruebaNotaLiqui()
        {
            BDconexion mBD = new BDconexion();
            ControlApartado mControl = new ControlApartado();
            ControlProducto mProducto = new ControlProducto();
            ControlCliente mCliente = new ControlCliente();
            //Apartado instance = new Apartado();

        }
        [TestMethod]
        public void setIDNotatest()
        {
            NotaLiquidacion instance = new NotaLiquidacion();
            instance.IDNota = 1;
            Assert.AreEqual(instance.IDNota, 1);
        }
        [TestMethod]
        public void setTotaltest()
        {
            NotaLiquidacion instance = new NotaLiquidacion();
            instance.Total = 23;
            Assert.AreEqual(instance.Total, 23);
        }
        [TestMethod]
        public void setNombreClientetest()
        {
            NotaLiquidacion instance = new NotaLiquidacion();
            instance.NombreCliente = "solovino";
            Assert.AreEqual(instance.NombreCliente, "solovino");
        }
        [TestMethod]
        public void setFoliotest()
        {
            NotaLiquidacion instance = new NotaLiquidacion();
            instance.Folio = "sdda54";
            Assert.AreEqual(instance.Folio, "sdda54");
        }

    }
}

