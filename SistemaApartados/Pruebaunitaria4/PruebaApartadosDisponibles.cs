using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaApartados.Datos;
using SistemaApartados.BaseDatos;
using SistemaApartados.Control;
namespace Pruebaunitaria4
{
    [TestClass]
    public class PruebaApartadosDisponibles
    {
        [TestMethod]

        public void PruebaApartadosDisponiblestest()
        {
            BDconexion mBD = new BDconexion();
            ControlApartado mControl = new ControlApartado();
            ControlProducto mProducto = new ControlProducto();
            ControlCliente mCliente = new ControlCliente();
            //Apartado instance = new Apartado();
        }
        [TestMethod]
        public void setFoliotest()
        {
            Apartado instance = new Apartado();
            instance.Folio = "1ad";
            Assert.AreEqual(instance.Folio, "1ad");
        }
        [TestMethod]
        public void setFecha_Pedidotest()
        {
            Apartado instance = new Apartado();
            instance.Fecha_Pedido = "2018/03/16";
            Assert.AreEqual(instance.Fecha_Pedido, "2018/03/16");
        }
        [TestMethod]
        public void setFecha_Entregatest()
        {
            Apartado instance = new Apartado();
            instance.Fecha_Entrega = "2018/06/30";
            Assert.AreEqual(instance.Fecha_Entrega, "2018/06/30");
        }
        [TestMethod]
        public void setTotaltest()
        {
            Apartado instance = new Apartado();
            instance.Total = 50;
            Assert.AreEqual(instance.Total, 50);
        }
        [TestMethod]
        public void setImporte_Enganchetest()
        {
            Apartado instance = new Apartado();
            instance.Importe_Enganche = 20;
            Assert.AreEqual(instance.Importe_Enganche, 20);
        }

        [TestMethod]
        public void setImportetest()
        {
            Apartado instance = new Apartado();
            instance.Importe = 15;
            Assert.AreEqual(instance.Importe, 15);
        }

    }
}

