using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaApartados.Datos;
using SistemaApartados.BaseDatos;
using SistemaApartados.Control;

namespace Pruebaunitaria4
{
    [TestClass]
    public class PruebaUsuario
    {
        [TestMethod]
        public void PruebaUsutest()
        {
            BDconexion mBD = new BDconexion();
            ControlApartado mControl = new ControlApartado();
            ControlProducto mProducto = new ControlProducto();
            ControlCliente mCliente = new ControlCliente();
            //Apartado instance = new Apartado();
        }
        [TestMethod]
        public void setID_Usuariostest()
        {
            Usuario instance = new Usuario();
            instance.Id_Usuarios = 1;
            Assert.AreEqual(instance.Id_Usuarios, 1);

        }
        [TestMethod]
        public void setTipo_Usuariotest()
        {
            Usuario instance = new Usuario();
            instance.Tipo_Usuario = "admin";
            Assert.AreEqual(instance.Tipo_Usuario, "admin");
        }
        [TestMethod]
        public void setUsertest()
        {
            Usuario instance = new Usuario();
            instance.User = "ymg";
            Assert.AreEqual(instance.User, "ymg");
        }
        [TestMethod]
        public void setNombre_Usuariotest()
        {
            Usuario instance = new Usuario();
            instance.Nombre_Usuario = "perla";
            Assert.AreEqual(instance.Nombre_Usuario, "perla");
        }
        [TestMethod]
        public void setcontrasenyatest()
        {
            Usuario instance = new Usuario();
            instance.Contrasenya = "123";
            Assert.AreEqual(instance.Contrasenya, "123");
        }
        [TestMethod]
        public void setVerifiContrasenyatest()
        {
            Usuario instance = new Usuario();
            instance.VerifiContrasenya = "123";
            Assert.AreEqual(instance.VerifiContrasenya, "123");
        }

    }
}