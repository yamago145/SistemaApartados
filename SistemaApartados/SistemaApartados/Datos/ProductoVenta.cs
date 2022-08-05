using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaApartados.Datos
{
    public class ProductoVenta
    {
        public string Clave_Producto { set; get; }
        public string Nombre_Producto { set; get; }
        public string Tipo { set; get; }
        public string Especie { set; get; }
        public string Marca { set; get; }
        public float Precio { set; get; }
        public float Cantidad { get; set; }
        public float Subtotal { get; set; }
    }
}
