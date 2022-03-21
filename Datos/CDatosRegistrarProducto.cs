using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Datos
{
    public class CDatosRegistrarProducto
    {

        private CConexion conexion = new CConexion();
       //CLASE PARA COMUNICARNOS CON EL PROCESO DE ALMACENADO DE LA BDD
        SqlCommand comando = new SqlCommand();
        SqlParameter res;
        public string AgregarProductto(string Nombre, string Descripcion, string Marca,int Stock, int IdUnidadM, int IdCategoria, int IdSede)
        {
            //SqlParameter x;
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "JSMAgregarProducto";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Nombre", Nombre);
                comando.Parameters.AddWithValue("@Descripcion", Descripcion);
                comando.Parameters.AddWithValue("@Marca", Marca);
                comando.Parameters.AddWithValue("@Stock", Stock);
                comando.Parameters.AddWithValue("@IdUnidadM", IdUnidadM);
                comando.Parameters.AddWithValue("@IdCategoria", IdCategoria);
                comando.Parameters.AddWithValue("@IdSede", IdSede);

                res = comando.Parameters.AddWithValue("@Result", "");
                comando.Parameters["@Result"].Direction = ParameterDirection.Output;

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();

                return res.Value.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex + "Eroror productos");
                return "ERROR3" + ex;
            }

        }

    }
}
