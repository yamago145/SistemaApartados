using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SistemaApartados.Datos;

namespace SistemaApartados.Datos
{
    public class Apartado
    {
        public string Folio { set; get; }
        public string Fecha_Pedido { set; get; }
        public string Fecha_Entrega { set; get; }
        public float Total { set; get; }
        public float Importe_Enganche { set; get; }

        public float Importe { get; set; }

        public Cliente IdCliente { get; set; }
    }
}
