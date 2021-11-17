﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Datos
{
   public class CDatosAddEstanteyCategoria
    {
        private CConexion conexion = new CConexion();
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        SqlParameter res;
        public string AgregarEstante(int Idcategoria, string DescripcionE)
        {
            //SqlParameter x;
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "JSMAgregarEstante";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdCategoria", Idcategoria);
                comando.Parameters.AddWithValue("@DescripcionE", DescripcionE);


                res = comando.Parameters.AddWithValue("@Result", "");
                comando.Parameters["@Result"].Direction = ParameterDirection.Output;

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();

                return res.Value.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex + "Eroror");
                return "ERROR3";
            }

        }
        public string AgregarCategoria(string DescripcionC)
        {
            //SqlParameter x;
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "JSMAgregarCategoria";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@DescripcionC", DescripcionC);
           
                res = comando.Parameters.AddWithValue("@Result", "");
                comando.Parameters["@Result"].Direction = ParameterDirection.Output;

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();

                return res.Value.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex + "Eroror");
                return "ERROR3";
            }

        }
    }
}