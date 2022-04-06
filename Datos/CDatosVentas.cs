using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Datos
{
    public class CDatosVentas
    {
        private CConexion conexion = new CConexion();
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        SqlParameter res;

        public string AgregarVenta(string NomCli, string ApeCli, double descuento, double SubT,
             double Total, int IdUsuario)
        {
            //SqlParameter x;
            conexion.CerrarConexion();
            try
            {


                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "JSMAgregarVentasContado";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@NombreCli", NomCli);
                comando.Parameters.AddWithValue("@ApellidoCli", ApeCli);
                comando.Parameters.AddWithValue("@Descuento", descuento);


                comando.Parameters.AddWithValue("@SubTotal", SubT);

                comando.Parameters.AddWithValue("@Total", Total);
                comando.Parameters.AddWithValue("@IdUsuario", IdUsuario);

                res = comando.Parameters.AddWithValue("@Result", "");
                comando.Parameters["@Result"].Direction = ParameterDirection.Output;

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();

                return res.Value.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex + "Eroror");
                return Convert.ToString(ex);
            }

        }

        public string AgregarVentaProducto(int idV, int idProd, double cantidad, int IdLote)
        {
            //SqlParameter x;
            conexion.CerrarConexion();
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "JSMAgregarVentaProducto";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@idv", idV);
                comando.Parameters.AddWithValue("@idProducto", idProd);
                comando.Parameters.AddWithValue("@Cantidad", cantidad);
                comando.Parameters.AddWithValue("@IdLote", IdLote);

                res = comando.Parameters.AddWithValue("@Result", "");
                comando.Parameters["@Result"].Direction = ParameterDirection.Output;

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();

                return res.Value.ToString();
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex + "Eroror");
                return Convert.ToString(ex);


            }

        }
        public string RestarInventario(int idLote, int idProd, double stock, double cantidad)
        {
            //SqlParameter x;
            conexion.CerrarConexion();
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "JSMRestarInventario";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@IdLote", idLote);
                comando.Parameters.AddWithValue("@IdProducto", idProd);
                comando.Parameters.AddWithValue("@Stock", stock);
                comando.Parameters.AddWithValue("@Cantidad", cantidad);

                res = comando.Parameters.AddWithValue("@Result", "");
                comando.Parameters["@Result"].Direction = ParameterDirection.Output;

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();

                return res.Value.ToString();
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex + "Eroror");
                return Convert.ToString(ex);


            }

        }

        //METODO PARA COMUNICARME CON EL PROCESO DE ALMACENADO TEMPORAL
        public string Temporal(int idLote, int idProd, double cantidad)
        {
            //SqlParameter x;
            conexion.CerrarConexion();
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "JSMAgregarTemporal";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@IdLote", idLote);
                comando.Parameters.AddWithValue("@IdProducto", idProd);
                comando.Parameters.AddWithValue("@Cantidad", cantidad);

                res = comando.Parameters.AddWithValue("@Result", "");
                comando.Parameters["@Result"].Direction = ParameterDirection.Output;

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();

                return res.Value.ToString();
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex + "Eroror");
                return Convert.ToString(ex);


            }

        }

        public string DevolucionProdV(int nf, int idp, string estado,int idU,int idvp)
        {
            //SqlParameter x;
            conexion.CerrarConexion();
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "JSMAgregarDevolucionVP";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@NF", nf);
                comando.Parameters.AddWithValue("@IdP", idp);
                comando.Parameters.AddWithValue("@ParaIDEstado", estado);
                comando.Parameters.AddWithValue("@IdUsuario", idU);
                comando.Parameters.AddWithValue("@idvp", idvp);

                res = comando.Parameters.AddWithValue("@Result", "");
                comando.Parameters["@Result"].Direction = ParameterDirection.Output;

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();

                return res.Value.ToString();
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex + "Eroror");
                return Convert.ToString(ex);


            }

        }

        public string RetirarDevolucion(int idp)
        {
            //SqlParameter x;
            conexion.CerrarConexion();
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "JSMRetirarDevolucion";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@idvp", idp);

                res = comando.Parameters.AddWithValue("@Result", "");
                comando.Parameters["@Result"].Direction = ParameterDirection.Output;

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();

                return res.Value.ToString();
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex + "Eroror");
                return Convert.ToString(ex);
            }

        }

        public string CancelarAllFactura(int idV, int idvp,int idU, int Tipo)
        {
            //SqlParameter x;
            conexion.CerrarConexion();
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "JSMCancelarFactura";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@idVenta", idV);
                comando.Parameters.AddWithValue("@idVP", idvp);
                comando.Parameters.AddWithValue("@idUser", idU);
                comando.Parameters.AddWithValue("@tipoDev", Tipo);

                res = comando.Parameters.AddWithValue("@Result", "");
                comando.Parameters["@Result"].Direction = ParameterDirection.Output;

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();

                return res.Value.ToString();
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex + "Eroror");
                return Convert.ToString(ex);
            }

        }
    }
}
