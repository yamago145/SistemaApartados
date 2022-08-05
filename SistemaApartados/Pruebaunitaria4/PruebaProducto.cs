using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaApartados.Datos;
using SistemaApartados.BaseDatos;
using SistemaApartados.Control;

namespace Pruebaunitaria4
{
    [TestClass]
    public class PruebaProducto
    {
        [TestMethod]
        public void PruebaProducttest()
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
            Producto instance = new Producto();
            instance.Clave_Producto = "MSD23";
            Assert.AreEqual(instance.Clave_Producto, "MSD23");

        }
        [TestMethod]
        public void Nombre_Productotest()
        {
            Producto instance = new Producto();
            instance.Nombre_Producto = "Maiz";
            Assert.AreEqual(instance.Nombre_Producto, "Maiz");
        }
        [TestMethod]
        public void setTipotest()
        {
            Producto instance = new Producto();
            instance.Tipo = "semilla";
            Assert.AreEqual(instance.Tipo, "semilla");
        }
        [TestMethod]
        public void setEspecietest()
        {
            Producto instance = new Producto();
            instance.Especie = "domestico";
            Assert.AreEqual(instance.Especie, "domestico");
        }
        [TestMethod]
        public void setMarcatest()
        {
            Producto instance = new Producto();
            instance.Marca = "SabAmex";
            Assert.AreEqual(instance.Marca, "SabAmex");
        }
        [TestMethod]
        public void setPrecio()
        {
            Producto instance = new Producto();
            instance.Precio = 100;
            Assert.AreEqual(instance.Precio, 100);
        }
    }
}


