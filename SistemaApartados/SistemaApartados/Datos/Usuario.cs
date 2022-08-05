using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaApartados.Datos
{
    public class Usuario
    {
        public int Id_Usuarios { set; get; }
        public string Tipo_Usuario { set; get; }

        public string User { set; get; }

        public string Nombre_Usuario { set; get; }

        public string Contrasenya { set; get; }

        public string VerifiContrasenya { set; get; }
    }
}
