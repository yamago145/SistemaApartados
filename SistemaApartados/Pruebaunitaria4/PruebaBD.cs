using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaApartados.BaseDatos;
using SistemaApartados.Control;
using SistemaApartados.Datos;
using System.Collections;

namespace Pruebaunitaria4
{
    [TestClass]
    public class PruebaBD
    {
        [TestMethod]
        public void PruebaBDtest()
        {
            BDconexion instance = new BDconexion();
            bool Conectado;
            Conectado = instance.Conectar();
            bool Esperado = true;
            Assert.AreEqual(Conectado, Esperado);

        }
        [TestMethod]
        public void ConsultarProductostest()
        {
            BDconexion instance = new BDconexion();
            ArrayList Consulta;
            Consulta = instance.ConsultarProductos("select Clave_Producto ,Nombre_Producto ,Tipo ,Especie, Marca, Precio from Producto" +
                " where Habilitado = 0");

            Assert.IsNotNull(Consulta);
        }
        public void ConsultarApartados()
        {
            BDconexion instance = new BDconexion();
            ArrayList ConsultaApartado;
            ConsultaApartado = instance.ConsultarApartados("select * from Apartado");
            Assert.IsNotNull(ConsultaApartado);
        }
        public void AgregarApartado()
        {
            ControlApartado instance = new ControlApartado();
            bool Agregar;
            Apartado mApartado = new Apartado();
            mApartado.Folio = "1aaas";
            mApartado.Fecha_Entrega = "2019/04/3";
            mApartado.Fecha_Pedido = "2019/03/2";
            mApartado.Importe = 100;
            mApartado.Importe_Enganche = 50;
            mApartado.Total = 120;
            Agregar = instance.agregarApartado(mApartado);
        }
        public void EliminarApartado()
        {
            ControlApartado instance = new ControlApartado();
            
        }

    }
}

