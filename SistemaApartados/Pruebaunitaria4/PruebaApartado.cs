using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaApartados.BaseDatos;
using SistemaApartados.Datos;
using SistemaApartados.Control;
namespace Pruebaunitaria4
{
    [TestClass]
    public class PruebaApartado
    {
        [TestMethod]
        public void PruebaApartadotest()
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
            instance.Folio = "abc";
            Assert.AreEqual(instance.Folio, "abc");
        }
        [TestMethod]
        public void setFecha_Pedidotest()
        {
            Apartado instance = new Apartado();
            instance.Fecha_Pedido = "2019/06/21";
            Assert.AreEqual(instance.Fecha_Pedido, "2019/06/21");
        }
        [TestMethod]
        public void setFecha_Entregatest()
        {
            Apartado instance = new Apartado();
            instance.Fecha_Entrega = "2019/06/30";
            Assert.AreEqual(instance.Fecha_Entrega, "2019/06/30");
        }
        [TestMethod]
        public void setTotaltest()
        {
            Apartado instance = new Apartado();
            instance.Total = 25;
            Assert.AreEqual(instance.Total, 25);
        }
        [TestMethod]
        public void setImporte_Enganchetest()
        {
            Apartado instance = new Apartado();
            instance.Importe_Enganche = 50;
            Assert.AreEqual(instance.Importe_Enganche, 50);
        }
        [TestMethod]

        public void setImportetest()
        {
            Apartado instance = new Apartado();
            instance.Importe = 20;
            Assert.AreEqual(instance.Importe, 20);
        }

    }
}

