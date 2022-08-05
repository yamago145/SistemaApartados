using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaApartados.Datos;
using SistemaApartados.BaseDatos;
using SistemaApartados.Control;


namespace Pruebaunitaria4
{
    [TestClass]
    public class PruebaCliente
    {
        [TestMethod]
        public void PruebaClientetest()
        {
            BDconexion mBD = new BDconexion();
            ControlApartado mControl = new ControlApartado();
            ControlProducto mProducto = new ControlProducto();
            ControlCliente mCliente = new ControlCliente();
            //Apartado instance = new Apartado();
        }
        [TestMethod]
        public void setID_clientestest()
        {
            Cliente instance = new Cliente();
            instance.ID_Cliente = 1;
            Assert.AreEqual(instance.ID_Cliente, 1);
        }
        [TestMethod]
        public void setNombre_clientetest()
        {
            Cliente instance = new Cliente();
            instance.Nombre_Cliente = "fulano";
            Assert.AreEqual(instance.Nombre_Cliente, "fulano");
        }
    }
}
