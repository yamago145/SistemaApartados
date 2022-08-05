using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using SistemaApartados.Datos;
using System.Collections;

namespace SistemaApartados.BaseDatos
{
    public class BDconexion
    {
        private MySqlConnection Conexion;

        public bool Conectar()
        {
            
            bool conectado = true;
            Conexion = new MySqlConnection(
            "Server=localhost;" +
            "Database=sistema_apartado;" +
            "Uid=root;" +
            "Pwd=1234;");
            try
            {
                Conexion.Open();
            }
            catch
            {
                conectado = false;
            }
            return conectado;
        }

        public void Desconectar()
        {
            if (Conexion.State == System.Data.ConnectionState.Open)
            {
                Conexion.Close();
            }
        }

        public ArrayList ConsultarProductos(String SQL)
        {
            ArrayList Lista = null;
            Producto mProducto;
            try
            {
                MySqlCommand comando = Conexion.CreateCommand();
                comando.CommandText = SQL;
                MySqlDataReader lector = comando.ExecuteReader();

                if (lector.HasRows)
                {
                    Lista = new ArrayList();
                    while (lector.Read())
                    {
                        mProducto = new Producto();
                        mProducto.Clave_Producto = lector["Clave_Producto"].ToString();
                        mProducto.Nombre_Producto = lector["Nombre_Producto"].ToString();
                        mProducto.Tipo = lector["Tipo"].ToString();
                        mProducto.Especie = lector["Especie"].ToString();
                        mProducto.Marca = lector["Marca"].ToString();
                        mProducto.Precio = float.Parse(lector["Precio"].ToString());
                        Lista.Add(mProducto);
                    }
                }
                return Lista;
            }
            catch (Exception)
            {

                return null;
            }
        }

        

        public ProductoVenta ConsultarProducto(String SQL)
        {
            ProductoVenta mProducto = new ProductoVenta();
            try
            {
                MySqlCommand comando = Conexion.CreateCommand();
                comando.CommandText = SQL;
                MySqlDataReader lector = comando.ExecuteReader();

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        mProducto = new ProductoVenta();
                        mProducto.Clave_Producto = lector["Clave_Producto"].ToString();
                        mProducto.Nombre_Producto = lector["Nombre_Producto"].ToString();
                        mProducto.Tipo = lector["Tipo"].ToString();
                        mProducto.Especie = lector["Especie"].ToString();
                        mProducto.Marca = lector["Marca"].ToString();
                        mProducto.Precio = float.Parse(lector["Precio"].ToString());
                    }
                }
                return mProducto;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public bool ejecutarActualizacion(String SQL)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand(SQL, Conexion);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public ArrayList ConsultarApartados(String SQL)
        {
            ArrayList Lista = null;
            ApartadosDisponibles mApartado;
            try
            {
                MySqlCommand comando = Conexion.CreateCommand();
                comando.CommandText = SQL;
                MySqlDataReader lector = comando.ExecuteReader();

                if (lector.HasRows)
                {
                    Lista = new ArrayList();
                    while (lector.Read())
                    {
                        mApartado = new ApartadosDisponibles();
                        mApartado.Folio = lector["Folio"].ToString();
                        mApartado.Fecha_Pedido = lector["Fecha"].ToString();
                        mApartado.Fecha_Entrega = lector["Fecha_Entrega"].ToString();
                        mApartado.Total = float.Parse(lector["Total"].ToString());
                        mApartado.Importe = float.Parse(lector["Importe"].ToString());
                        mApartado.IdCliente = int.Parse(lector["Cliente_ID_Cliente"].ToString());
                        mApartado.Importe_Enganche = float.Parse(lector["Cantidad_Enganche"].ToString());
                        Lista.Add(mApartado);
                    }
                }
                return Lista;
            }
            catch (Exception)
            {

                return null;
            }
        }


        public ArrayList liquidarApartados(String SQL)
        {
            ArrayList Lista = null;
            NotaLiquidacion mNotaL = new NotaLiquidacion();
            try
            {
                MySqlCommand comando = Conexion.CreateCommand();
                comando.CommandText = SQL;
                MySqlDataReader lector = comando.ExecuteReader();

                if (lector.HasRows)
                {
                    Lista = new ArrayList();
                    while (lector.Read())
                    {
                        mNotaL = new NotaLiquidacion();
                        mNotaL.IDNota = int.Parse(lector["ID_NotaLiquidacion"].ToString());
                        mNotaL.Total = float.Parse(lector["Total"].ToString());
                        mNotaL.Folio = lector["Apartado_Folio"].ToString();
                        mNotaL.NombreCliente = lector["Nombre_Cliente"].ToString();
                        Lista.Add(mNotaL);
                    }
                }
                return Lista;
            }
            catch (Exception)
            {

                return null;
            }
        }



        public ArrayList ConsultarCredito(String SQL)
        {
            ArrayList Lista = null;
            Apartado mApartado;
            VistaNotaCredito mNotaC;
            try
            {
                MySqlCommand comando = Conexion.CreateCommand();
                comando.CommandText = SQL;
                MySqlDataReader lector = comando.ExecuteReader();

                if (lector.HasRows)
                {
                    Lista = new ArrayList();
                    while (lector.Read())
                    {
                        mApartado = new Apartado();
                        mNotaC = new VistaNotaCredito();

                        mApartado.IdCliente = new Cliente();
                        mNotaC.IDNota =int.Parse(lector["ID_NotaCredito"].ToString());
                        mNotaC.Importe = float.Parse(lector["Cantidad_Enganche"].ToString());
                        mNotaC.Folio = lector["Apartado_Folio"].ToString();

                        Lista.Add(mNotaC);
                    }
                }
                return Lista;
            }
            catch (Exception)
            {

                return null;
            }
        }


        public ArrayList ConsultarPro(String SQL)
        {
            try
            {
                ArrayList Productos = new ArrayList();
                Producto mProducto;
                MySqlCommand comando = Conexion.CreateCommand();
                comando.CommandText = SQL;
                MySqlDataReader lector = comando.ExecuteReader();
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        mProducto = new Producto();
                        mProducto.Clave_Producto = lector["Clave_Producto"].ToString();
                        mProducto.Nombre_Producto = lector["Nombre_Producto"].ToString();
                        mProducto.Existente = int.Parse(lector["Habilitado"].ToString());
                        Productos.Add(mProducto);
                    }
                }
                return Productos;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public ArrayList ConsultarPro0(String SQL)
        {
            try
            {
                ArrayList Productos = new ArrayList();
                Producto mProducto;
                MySqlCommand comando = Conexion.CreateCommand();
                comando.CommandText = SQL;
                MySqlDataReader lector = comando.ExecuteReader();
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        mProducto = new Producto();
                        mProducto.Clave_Producto = lector["Clave_Producto"].ToString();
                        mProducto.Nombre_Producto = lector["Nombre_Producto"].ToString();
                        mProducto.Precio = float.Parse(lector["Precio"].ToString());
                        mProducto.Existente = int.Parse(lector["Habilitado"].ToString());
                        Productos.Add(mProducto);
                    }
                }
                return Productos;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public string ConsultarCliente(String SQL)
        {
            try
            {
                string nombre="";
                MySqlCommand comando = Conexion.CreateCommand();
                comando.CommandText = SQL;
                MySqlDataReader lector = comando.ExecuteReader();
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        nombre = lector["Nombre_Cliente"].ToString();
                    }
                }
                return nombre;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public ArrayList ConsultarCliente1(String SQL)
        {
            try
            {
                ArrayList Clientes = new ArrayList();
                MySqlCommand comando = Conexion.CreateCommand();
                comando.CommandText = SQL;
                MySqlDataReader lector = comando.ExecuteReader();
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        Cliente mCliente = new Cliente();
                        mCliente.Nombre_Cliente= lector["Nombre_Cliente"].ToString();
                        Clientes.Add(mCliente);
                    }
                }
                return Clientes;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public ArrayList ConsultarProductosVenta(String SQL)
        {
            ArrayList Lista = null;
            ProductoVenta mProducto;
            try
            {
                MySqlCommand comando = Conexion.CreateCommand();
                comando.CommandText = SQL;
                MySqlDataReader lector = comando.ExecuteReader();

                if (lector.HasRows)
                {
                    Lista = new ArrayList();
                    while (lector.Read())
                    {
                        mProducto = new ProductoVenta();
                        mProducto.Clave_Producto = lector["Clave_Producto"].ToString();
                        mProducto.Nombre_Producto = lector["Nombre_Producto"].ToString();
                        mProducto.Tipo = lector["Tipo"].ToString();
                        mProducto.Especie = lector["Especie"].ToString();
                        mProducto.Marca = lector["Marca"].ToString();
                        mProducto.Precio = float.Parse(lector["Precio"].ToString());
                        mProducto.Cantidad = float.Parse(lector["Cantidad"].ToString());
                        mProducto.Subtotal = float.Parse(lector["Subtotal"].ToString());
                        Lista.Add(mProducto);
                    }
                }
                return Lista;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public bool agregarUsuario(Usuario mUsuario)
        {

            bool guardado = true;
            MySqlCommand mConsulta;
            string cadSQL = "insert into usuario values (" +
            "\"" + mUsuario.Id_Usuarios + "\"," +
            "\"" + mUsuario.Nombre_Usuario + "\"," +
           // "\"" + mUsuario.User + "\"," +
            "\"" + mUsuario.Contrasenya+ "\"," +
            "\"" + mUsuario.Tipo_Usuario + "\");";

            mConsulta = Conexion.CreateCommand();
            mConsulta.CommandText = cadSQL;

            try
            {
                mConsulta.ExecuteNonQuery();
            }
            catch
            {
                guardado = false;
            }

            return guardado;
        }

        public bool buscarUsuario(string Nombre, string contrase)
        {
            bool encontrado = true;


            String SQL = "select * from Usuarios where User = '" + Nombre + "' and Contrasenya ='" + contrase + "'";
            //SQL = SQL.Replace("?2", Nombre_Producto);

            BDconexion mConexion = new BDconexion();
            mConexion.Conectar();

            mConexion.Desconectar();
            return encontrado;
        }

        public ArrayList consultarProductosExistentes()
        {
            String SQL = "select * from Producto";
            ArrayList Lista;
            BDconexion mConexion = new BDconexion();
            mConexion.Conectar();
            Lista = mConexion.ConsultarProductos(SQL);
            mConexion.Desconectar();

            return Lista;
        }
    }
} 
