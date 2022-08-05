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
    public class ControlProducto
    {
        public bool agregarProducto(Producto mProducto)
        {

            bool guardado = true;
            string cadSQL = "insert into Producto values (" +
            "'" + mProducto.Clave_Producto + "'," +
            "'" + mProducto.Nombre_Producto + "'," +
            "'" + mProducto.Tipo + "'," +
            "'" + mProducto.Especie + "'," +
            "'" + mProducto.Marca + "'," +
            "'" + mProducto.Precio.ToString() + "'," +
            "'" + mProducto.Existente.ToString() + "');";

            BDconexion mConexion = new BDconexion();
            mConexion.Conectar();
            if (mConexion.ejecutarActualizacion(cadSQL))
            {
                guardado = true;
            }
            else
            {
                guardado = false;
            }
            
            mConexion.Desconectar();

            return guardado;
        }

        public ArrayList buscarNombre2(string Nombre_Producto)
        {
            ArrayList Lista;
            //like '%" + Nombre_Producto + "%'"
            String SQL = "select * from Producto where Nombre_Producto like '%" + Nombre_Producto + "%' "+
                "and Habilitado = 0";
            //SQL = SQL.Replace("?2", Nombre_Producto);

            BDconexion mConexion = new BDconexion();
            mConexion.Conectar();
            Lista = mConexion.ConsultarProductos(SQL);
            mConexion.Desconectar();
            return Lista;
        }

        public ProductoVenta buscarNombre(Producto mProducto)
        {
            ProductoVenta Lista;
            String SQL = "select Clave_Producto, Nombre_Producto,Tipo, Especie,Marca,Precio from Producto where Nombre_Producto = '" + mProducto.Nombre_Producto + "'" +
                "and Clave_Producto ='" + mProducto.Clave_Producto + "'";

            BDconexion mConexion = new BDconexion();
            mConexion.Conectar();
            Lista = mConexion.ConsultarProducto(SQL);
            mConexion.Desconectar();
            return Lista;
        }

        public ArrayList buscarClave(string clave)
        {
            //like '%" + Nombre_Producto + "%'"
            ArrayList Lista;
            String SQL = "select * from Producto where Clave_Producto = '" + clave + "' and Habilitado =0";


            //SQL = SQL.Replace("?2", Nombre_Producto);
            BDconexion mConexion = new BDconexion();
            mConexion.Conectar();
            Lista = mConexion.ConsultarProductos(SQL);
            mConexion.Desconectar();
            return Lista;
        }

        public void eliminarProducto(Producto mProducto)
        {
            /*UPDATE `sistema_apartado`.`producto` SET `Habilitado` = '1' WHERE `producto`.`Clave_Producto` = 'ADOALP';*/
            String SQL = "UPDATE producto set habilitado = '1' where Clave_Producto = '?1'";
            SQL = SQL.Replace("?1", mProducto.Clave_Producto.ToString());
            BDconexion mConexion = new BDconexion();
            mConexion.Conectar();
            mConexion.ejecutarActualizacion(SQL);
            mConexion.Desconectar();
        }

        public bool modificarProducto(Producto mProducto, Producto mProducto1)
        {
            bool correcto = true;
            /*UPDATE producto SET Clave_Producto = 'ADOALI', Nombre_Producto = 'alimento', 
             * Tipo = 'ded', Especie = 'por', Marca = 'O', Precio = '8' WHERE Clave_Producto = 'ADOMAI';*/
            String SQL = "update producto set " +
                        "Clave_Producto = '" + mProducto1.Clave_Producto + "', " +
                        "Nombre_Producto = '" + mProducto1.Nombre_Producto + "', " +
                         "Tipo = '" + mProducto1.Tipo + "', " +
                        "Especie = '" + mProducto1.Especie + "', " +
                        "Marca = '" + mProducto1.Marca + "', " +
                        "Precio = '" + mProducto1.Precio + "' " +
                        "WHERE Clave_Producto = '" + mProducto.Clave_Producto + "'";

            BDconexion mConexion = new BDconexion();
            mConexion.Conectar();
            if (mConexion.ejecutarActualizacion(SQL))
            {
                correcto = true;
            }
            else
            {
                correcto = false;
            }
            mConexion.Desconectar();
            return correcto;
        }
        public bool reactivarProducto(Producto mProducto1)
        {
            bool correcto = true;
            /*UPDATE `sistema_apartado`.`producto` SET `Habilitado` = '1' WHERE `producto`.`Clave_Producto` = 'ADOALP';*/
            String SQL = "update producto set " +
                        "Habilitado = '" + mProducto1.Existente + "', " +
                        "Precio = '" + mProducto1.Precio + "' " +
                        "WHERE Clave_Producto = '" + mProducto1.Clave_Producto + "'";

            BDconexion mConexion = new BDconexion();
            mConexion.Conectar();
            if (mConexion.ejecutarActualizacion(SQL))
            {
                correcto = true;
            }
            else
            {
                correcto = false;
            }
            mConexion.Desconectar();
            return correcto;
        }
        public bool modificarPrecio(Producto mProducto1)
        {
            bool correcto = true;
            /*UPDATE `sistema_apartado`.`producto` SET `Habilitado` = '1' WHERE `producto`.`Clave_Producto` = 'ADOALP';*/
            String SQL = "update producto set " +
                        "Precio = '" + mProducto1.Precio + "' " +
                        "WHERE Clave_Producto = '" + mProducto1.Clave_Producto + "'";

            BDconexion mConexion = new BDconexion();
            mConexion.Conectar();
            if (mConexion.ejecutarActualizacion(SQL))
            {
                correcto = true;
            }
            else
            {
                correcto = false;
            }
            mConexion.Desconectar();
            return correcto;
        }
        public ArrayList consultarTodosProductos()
        {
            String SQL = "select Clave_Producto ,Nombre_Producto ,Tipo ,Especie, Marca, Precio from Producto"+
                " where Habilitado = 0";
            ArrayList Lista;
            BDconexion mConexion = new BDconexion();
            mConexion.Conectar();
            Lista = mConexion.ConsultarProductos(SQL);
            mConexion.Desconectar();

            return Lista;
        }

        public ArrayList cargarPro()
        {
            ArrayList Productos = new ArrayList();
            String SQL = "select Clave_Producto, Nombre_Producto, Habilitado from Producto";

            BDconexion mConexion = new BDconexion();
            mConexion.Conectar();
            Productos = mConexion.ConsultarPro(SQL);
            mConexion.Desconectar();
            return Productos;
        }
        public ArrayList cargarPro0()
        {
            ArrayList Productos = new ArrayList();
            String SQL = "select Clave_Producto, Nombre_Producto, Precio, Habilitado from Producto where Habilitado =0";

            BDconexion mConexion = new BDconexion();
            mConexion.Conectar();
            Productos = mConexion.ConsultarPro0(SQL);
            mConexion.Desconectar();
            return Productos;
        }

        public ArrayList verProductos(string Fol)
        {
            ArrayList Lista = null;
            /*select A.Clave_Producto, A.Nombre_Producto, A.Tipo, A.Especie, A.Marca, A.Precio 
             * from producto A inner join relacion B on B.Producto_Clave_Producto = A.Clave_Producto inner join Apartado C on C.Folio = B.Apartado_Folio
             * where Folio = '1905161'*/
            String SQL = "select A.Clave_Producto, A.Nombre_Producto, A.Tipo, A.Especie, A.Marca, A.Precio, B.Cantidad, B.subtotal " + 
                         "from producto A inner join venta B on B.Producto_Clave_Producto = A.Clave_Producto "+
                         "inner join apartado C on C.Folio = B.Apartado_Folio where folio = '" + Fol + "'";

            BDconexion mConexion = new BDconexion();
            mConexion.Conectar();
            Lista = mConexion.ConsultarProductosVenta(SQL);
            mConexion.Desconectar();
            return Lista;
        }
    }
}
