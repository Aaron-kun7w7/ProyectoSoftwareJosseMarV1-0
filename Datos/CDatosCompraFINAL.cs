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

        public string AddSinFactura(string NFactura, int IdUsuario, int IdProveedor, string FechaIngreso, double Subtotal, double total, double Descuento, int Sede)
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

        }



















    }
}
