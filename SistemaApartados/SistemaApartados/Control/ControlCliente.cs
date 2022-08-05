using MySql.Data.MySqlClient;
using SistemaApartados.BaseDatos;
using SistemaApartados.Datos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaApartados.Control
{
    public class ControlCliente
    {
        public bool guardarCliente(Cliente mCliente)
        {

            bool guardado = true;
            string cadSQL = "insert into cliente values (" +
            "\"" + mCliente.ID_Cliente + "\"," +
            "\"" + mCliente.Nombre_Cliente + "\");";

            BDconexion mConexion = new BDconexion();
            mConexion.Conectar();
            if(!mConexion.ejecutarActualizacion(cadSQL)){
                guardado = false;
            }
            mConexion.Desconectar();
            return guardado;
        }

        public string seleccionarCliente(int num)
        {
            string nom;
            String SQL = "select A.Nombre_Cliente from Cliente A "+
                "inner join Apartado B on B.Cliente_ID_Cliente = A.ID_CLiente "+
                "where B.CLiente_ID_Cliente =" +num +" and B.Concluido = 0";

            BDconexion mBD = new BDconexion();
            mBD.Conectar();
            nom = mBD.ConsultarCliente(SQL);
            mBD.Desconectar();
            return nom;
        }

        public ArrayList cargarCli()
        {
            String SQL = "select Nombre_Cliente from Cliente";
            ArrayList Clientes = new ArrayList();
            BDconexion mBD = new BDconexion();
            mBD.Conectar();
            Clientes = mBD.ConsultarCliente1(SQL);
            mBD.Desconectar();
            return Clientes;
        } 
    }
}
