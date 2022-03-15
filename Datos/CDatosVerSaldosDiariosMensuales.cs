﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace Datos
{
    public class CDatosVerSaldosDiariosMensuales
    {
        private CConexion conexion = new CConexion();
        
        public DataTable VerSaldosAnuales()
        {
            DataTable tab = new DataTable();
            SqlCommand sql = new SqlCommand("JSMSaldosAnuales", conexion.AbrirConexion());
            sql.CommandType = CommandType.StoredProcedure;
            sql.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(sql);
            da.Fill(tab);
            return tab;
        }
    }
}
