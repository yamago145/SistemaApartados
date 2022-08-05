using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaApartados.Datos;
using SistemaApartados.BaseDatos;
using SistemaApartados.Control;

namespace Pruebaunitaria4
{
    [TestClass]
    public class PruebaProductoVenta
    {
        [TestMethod]
        public void PruebaProductVentatest()
        {
            BDconexion mBD = new BDconexion();
            ControlApartado mControl = new ControlApartado();
            ControlProducto mProducto = new ControlProducto();
            ControlCliente mCliente = new ControlCliente();
            //Apartado instance = new Apartado();
        }
        [TestMethod]
        public void setClave_Productotest()
        {
            ProductoVenta instance = new ProductoVenta();
            instance.Clave_Producto = "MSD23";
            Assert.AreEqual(instance.Clave_Producto, "MSD23");

        }
        [TestMethod]
        public void setNombre_Productotest()
        {
            ProductoVenta instance = new ProductoVenta();
            instance.Nombre_Producto = "whiskas";
            Assert.AreEqual(instance.Nombre_Producto, "whiskas");

        }
        [TestMethod]
        public void setTipotest()
        {
            ProductoVenta instance = new ProductoVenta();
            instance.Tipo = "Alimentos";
            Assert.AreEqual(instance.Tipo, "Alimentos");

        }
        [TestMethod]
        public void setEspecietest()
        {
            ProductoVenta instance = new ProductoVenta();
            instance.Especie = "Domestico";
            Assert.AreEqual(instance.Especie, "Domestico");

        }
        [TestMethod]
        public void setMarcatest()
        {
            ProductoVenta instance = new ProductoVenta();
            instance.Marca = "purina";
            Assert.AreEqual(instance.Marca, "purina");

        }
        [TestMethod]
        public void setPreciotest()
        {
            ProductoVenta instance = new ProductoVenta();
            instance.Precio = 120;
            Assert.AreEqual(instance.Precio, 120);

        }
        [TestMethod]
        public void setCantidadtest()
        {
            ProductoVenta instance = new ProductoVenta();
            instance.Cantidad = 3;
            Assert.AreEqual(instance.Cantidad, 3);

        }
        [TestMethod]
        public void setSubtotaltest()
        {
            ProductoVenta instance = new ProductoVenta();
            instance.Subtotal = 20;
            Assert.AreEqual(instance.Subtotal, 20);
        }


    }
}

