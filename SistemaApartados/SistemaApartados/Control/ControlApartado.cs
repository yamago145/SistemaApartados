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
    public class ControlApartado
    {
        public bool agregarApartado(Apartado mApartado)
        {
            bool guardado = true;
            MySqlCommand mConsulta = new MySqlCommand();
            /*INSERT INTO apartado VALUES ('1234', '1', '2019/05/14', '2019-05-16', '45', '23', '1')
             */
            string cadSQL = "insert into apartado values (" +
            "'" + mApartado.Folio + "'," +
            "'" + 0 + "'," +
              "'" + mApartado.Fecha_Pedido + "'," +
            "'" + mApartado.Fecha_Entrega + "'," +
            "'" + mApartado.Total + "'," +
             "'" + mApartado.Importe_Enganche + "'," +
            "'" + mApartado.IdCliente.ID_Cliente + "'," +
            "'" + mApartado.Importe + "');";

            BDconexion mConexion = new BDconexion();
            mConexion.Conectar();
            if (!mConexion.ejecutarActualizacion(cadSQL))
            {
                guardado = false;
            }
            mConexion.Desconectar();

            return guardado;
        }

        public void eliminarApartado(Apartado mApartado)
        {
            String SQL = "delete from apartado where ID?Cliente = '?1'";
            //SQL = SQL.Replace("?1", mApartado.ID_Cliente.ToString());
            BDconexion mConexion = new BDconexion();
            mConexion.Conectar();
            mConexion.ejecutarActualizacion(SQL);
            mConexion.Desconectar();
        }

        public bool modificarApartado(Apartado mApartado1, Apartado mApartado)
        {
            bool correcto = true;
            String SQL = "update Apartado set "
                        + "ID_Cliente = '?1' ,"
                        + "Nombre_Cliente = '?2',"
                        + "Fecha_Pedido = '?3',"
                        + "Fecha_Entrega = '?4',"
                        + "Total = '?5',"
                        + "Importe_Enganche = '?6' "
                        + "where ID_Cliente = '?7'";

            //SQL = SQL.Replace("?1", mApartado1.ID_Cliente.ToString());
            //SQL = SQL.Replace("?2", mApartado1.Nombre_Cliente);
            SQL = SQL.Replace("?3", mApartado1.Fecha_Pedido);
            SQL = SQL.Replace("?5", mApartado1.Fecha_Entrega);
            SQL = SQL.Replace("?4", mApartado1.Total.ToString());
            SQL = SQL.Replace("?6", mApartado1.Importe_Enganche.ToString());
            //SQL = SQL.Replace("?7", mApartado.ID_Cliente.ToString());

            BDconexion mConexion = new BDconexion();
            mConexion.Conectar();
            try
            {
                mConexion.ejecutarActualizacion(SQL);
            }
            catch (Exception)
            {

                correcto = false;
            }
            mConexion.Desconectar();
            return correcto;
        }


        public ArrayList consultarTodosApartados()
        {
            String SQL = "select * from Apartado";
            ArrayList Lista;
            BDconexion mConexion = new BDconexion();
            mConexion.Conectar();
            Lista = mConexion.ConsultarApartados(SQL);
            mConexion.Desconectar();

            return Lista;
        }


        public bool relacionarProductos(ProductoVenta mProducto, Apartado mApartado)
        {

            bool guardado = true;
            string cadSQL = "insert into venta values (" +
            "\"" + mApartado.Folio + "\"," +
            "\"" + mProducto.Clave_Producto + "\"," +
            "\"" + mProducto.Subtotal + "\"," +
            "'" + mProducto.Cantidad + "');";

            BDconexion mConexion = new BDconexion();
            mConexion.Conectar();
            mConexion.ejecutarActualizacion(cadSQL);
            mConexion.Desconectar();

            return guardado;
        }

        //cast(Subtotal as decimal)= cast(" + mProducto.Subtotal + " as decimal)" +

        public ArrayList buscarApartadoClientes(string Nombre)
        {
            String SQL = "select A.Folio,A.Fecha,A.Fecha_Entrega,A.Total,A.Importe,A.Cliente_ID_Cliente,A.Cantidad_Enganche" +
            " from apartado A" +
            " inner join cliente B on B.ID_Cliente = A.Cliente_ID_Cliente" +
            " where B.Nombre_Cliente ='" + Nombre + "' and Concluido=0";
            ArrayList Lista;
            BDconexion mConexion = new BDconexion();
            mConexion.Conectar();
            Lista = mConexion.ConsultarApartados(SQL);
            mConexion.Desconectar();

            return Lista;
        }

        public ArrayList buscarApartadoFolio(string Folio)
        {
            ArrayList Lista;
            String SQL = "select Folio,Fecha,Fecha_Entrega,Total,Importe,Cliente_ID_Cliente,Cantidad_Enganche" +
                " from Apartado where Folio like '%" + Folio + "%' and Concluido =0";

            BDconexion mConexion = new BDconexion();
            mConexion.Conectar();
            Lista = mConexion.ConsultarApartados(SQL);
            mConexion.Desconectar();
            return Lista;
        }
        
        public bool modificarApartado(Apartado mApartado,string fol)
        {
            bool guardado = true;
            MySqlCommand mConsulta = new MySqlCommand();
            /*UPDATE `sistema_apartado`.`apartado` SET 
             * `Folio` = '1905245', `Fecha` = '2019-05-25', `Fecha_Entrega` = '2019-05-31', `Total` = '45', `Cantidad_Enganche` = '13', `Importe` = '37' 
            WHERE `apartado`.`Folio` = '1905244' AND `apartado`.`Cliente_ID_Cliente` = 2;*/
            string cadSQL = "UPDATE apartado SET Folio = '"+mApartado.Folio+"', "+
                "Fecha = '" + mApartado.Fecha_Pedido+"', " +
                "Fecha_Entrega = '" + mApartado.Fecha_Entrega+"', " +
                "Total = '" + mApartado.Total+"', " +
                "Cantidad_Enganche = '" + mApartado.Importe_Enganche+"', " +
                "Importe = '" + mApartado.Importe+"' WHERE Folio = '"+fol+"'";

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

        public ArrayList buscarApartados()
        {
            ArrayList Lista;
            String SQL = "select * from Apartado  where concluido =0";

            BDconexion mConexion = new BDconexion();
            mConexion.Conectar();
            Lista = mConexion.ConsultarApartados(SQL);
            mConexion.Desconectar();
            return Lista;
        }

        public bool borrarCantidades(string fol)
        {

            bool guardado = true;
            string cadSQL = "DELETE FROM venta WHERE Apartado_Folio = '" + fol + "'";

            BDconexion mConexion = new BDconexion();
            mConexion.Conectar();
            mConexion.ejecutarActualizacion(cadSQL);
            mConexion.Desconectar();

            return guardado;
        }

        public bool inhabilitarApartado(ApartadosDisponibles mApartado)
        {
            bool guardado = true;
            /*UPDATE `sistema_apartado`.`apartado` SET `Concluido` = '1' WHERE `apartado`.`Folio` = '1905261'*/
            MySqlCommand mConsulta = new MySqlCommand();
            string cadSQL = "UPDATE apartado SET Concluido = '" + 1 + "'," +
                "Importe ='"+mApartado.Total+"'"+
               " WHERE Folio = '" + mApartado.Folio + "'";

            BDconexion mConexion = new BDconexion();
            mConexion.Conectar();
            if(mConexion.ejecutarActualizacion(cadSQL))
            guardado = true;
            else
                guardado = false;
            mConexion.Desconectar();
            return guardado;
        }
        
        public bool generarCredito(ApartadosDisponibles mApartado)
        {
            bool guardado = true;
            MySqlCommand mConsulta = new MySqlCommand();
            /*INSERT INTO apartado VALUES ('1234', '1', '2019/05/14', '2019-05-16', '45', '23', '1')
             */
            string cadSQL = "insert into nota_credito values (NULL"
            + "," +
            "'" + mApartado.Importe + "'," +
              "'" + mApartado.Folio + "');"; 

            BDconexion mConexion = new BDconexion();
            mConexion.Conectar();
            if (!mConexion.ejecutarActualizacion(cadSQL))
            {
                guardado = false;
            }
            mConexion.Desconectar();

            return guardado;
        }

        public bool generarLiquidacion(ApartadosDisponibles mApartado, string nom)
        {
            bool guardado = true;
            MySqlCommand mConsulta = new MySqlCommand();
            //INSERT INTO `nota_liquidacion` (`ID_NotaLiquidacion`, `Total`, `Nombre_Cliente`, `Apartado_Folio`) VALUES (NULL, '540', 'Mauricio', '1905262');
            string cadSQL = "insert into nota_liquidacion values (NULL" +
            "," +
            "'" + mApartado.Total + "'," +
            "'" + nom + "'," +
              "'" + mApartado.Folio + "');";

            BDconexion mConexion = new BDconexion();
            mConexion.Conectar();
            if (!mConexion.ejecutarActualizacion(cadSQL))
            {
                guardado = false;
            }
            mConexion.Desconectar();

            return guardado;
        }

        public ArrayList buscarNotaC(ApartadosDisponibles mApartado)
        {
            ArrayList Lista;
            

            BDconexion mConexion = new BDconexion();
            String SQL = "select A.ID_NotaLiquidacion,  C.Nombre_Cliente,A.Total, A.Apartado_Folio " +
                "from Nota_Liquidacion A " +
                "inner  join Apartado B on B.Folio = A.Apartado_Folio " +
            "inner join Cliente C on B.Cliente_ID_Cliente = C.ID_Cliente "
            + "where B.Folio = '" + mApartado.Folio + "'";
            mConexion.Conectar();
            Lista = mConexion.liquidarApartados(SQL);
            mConexion.Desconectar();
            return Lista;
        }

        public ArrayList buscarNota(ApartadosDisponibles mApartado)
        {
            ArrayList Lista;
            String SQL = "select A.ID_NotaCredito, A.Cantidad_Enganche, A.Apartado_Folio "+
                "from nota_credito A "+
                "inner join Apartado B on B.Folio = A.Apartado_Folio "+
                "where B.Folio = '"+mApartado.Folio+"'";

            BDconexion mConexion = new BDconexion();
            mConexion.Conectar();
            Lista = mConexion.ConsultarCredito(SQL);
            mConexion.Desconectar();
            return Lista;
        }
    }
}
