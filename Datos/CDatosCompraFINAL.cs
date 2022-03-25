using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class CDatosCompraFINAL
    {
        //Con esto hacemos la conexion a Server en la BDD

        private CConexion conexion = new CConexion();
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        SqlParameter res;

        public string AddCompra(string NFactura, int IdUsuario, int IdProveedor, string FechaIngreso, double Subtotal, double total, double Descuento, int Sede)
        {
            //SqlParameter x;
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "JSMAgregarCompra";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@NFactura", NFactura);
                comando.Parameters.AddWithValue("@IdUsuario", IdUsuario);
                comando.Parameters.AddWithValue("@IdProveedor", IdProveedor);
                comando.Parameters.AddWithValue("@FechaIngreso", FechaIngreso);
                comando.Parameters.AddWithValue("@Subt", Subtotal);
                comando.Parameters.AddWithValue("@Total", total);
                comando.Parameters.AddWithValue("@Descuento", Descuento);
                comando.Parameters.AddWithValue("@IdSede", Sede);
               

                res = comando.Parameters.AddWithValue("@Result", "");
                comando.Parameters["@Result"].Direction = ParameterDirection.Output;



                comando.ExecuteNonQuery();
                comando.Parameters.Clear();

                return res.Value.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex + "Error 404 ");
                return "ERROR3";
            }

            //METODO PARA CONECTARME CON EL PROCESO DE ALMACENADO DE DETALLE DE COMPRA


        }
        //METODO PARA CONECTARME CON EL PROCESO DE ALMACENADO DE DETALLE DE COMPRA
        public string AddDetalleCompra(int IdCompra, int IdProducto, double Cantidad, double PrecioCompra,double PrecioVenta)
        {
            //SqlParameter x;
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "JSMDetalleCompra";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdCompra", IdCompra);
                comando.Parameters.AddWithValue("@IdProducto", IdProducto);
                comando.Parameters.AddWithValue("@Cantidad", Cantidad);
                comando.Parameters.AddWithValue("@PrecioCompra", PrecioCompra);
                comando.Parameters.AddWithValue("@PrecioVenta", PrecioVenta);

                res = comando.Parameters.AddWithValue("@Result", "");
                comando.Parameters["@Result"].Direction = ParameterDirection.Output;



                comando.ExecuteNonQuery();
                comando.Parameters.Clear();

                return res.Value.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex + "Error 404 ");
                return "ERROR3";
            }
        }

        //METODO PARA CONECTARME CON EL METODO DE AGREGAR LOTES
        public string AddLotes(int IdProducto, string FechaCaducidad, string NumeroLote, string FechaIngreso, double CantidadU, int IdCompra, int IdSede)
        {
            //SqlParameter x;
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "JSMAgregarLotes";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdProducto", IdProducto);
                comando.Parameters.AddWithValue("@FechaCaducidad", FechaCaducidad);
                comando.Parameters.AddWithValue("@NumeroLote", NumeroLote);
                comando.Parameters.AddWithValue("@FechaIngreso", FechaIngreso);
                comando.Parameters.AddWithValue("@CantidadU", CantidadU);
                comando.Parameters.AddWithValue("@IdCompra", IdCompra);
                comando.Parameters.AddWithValue("@IdSede", IdSede);

                res = comando.Parameters.AddWithValue("@Result", "");
                comando.Parameters["@Result"].Direction = ParameterDirection.Output;



                comando.ExecuteNonQuery();
                comando.Parameters.Clear();

                return res.Value.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex + "Error 404 ");
                return "ERROR3";
            }
        }
        public string AddPrecioActual(double PrecioCompra, double PrecioVenta, int IdProducto, int IdSede)
        {
            //SqlParameter x;
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "JSMAgregarPrecioActual";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@PrecioCompra", PrecioCompra);
                comando.Parameters.AddWithValue("@PrecioVenta", PrecioVenta);
                comando.Parameters.AddWithValue("@IdProducto", IdProducto);
                comando.Parameters.AddWithValue("@IdSede", IdSede);

                res = comando.Parameters.AddWithValue("@Result", "");
                comando.Parameters["@Result"].Direction = ParameterDirection.Output;



                comando.ExecuteNonQuery();
                comando.Parameters.Clear();

                return res.Value.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex + "Error 404 ");
                return "ERROR3";
            }
        }
    }
}
