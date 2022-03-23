using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Datos;
using System.Windows.Forms;

namespace Logica
{
    public class CLogicaCompraFINAL
    {
        CDatosCompraFINAL add = new CDatosCompraFINAL();

        public string LogicaAddSinFactura(string NFactura, int IdUsuario, int IdProveedor, string FechaIngreso, double Subtotal, double total, double Descuento, int Sede)
        {
            // string IP = ip.ObtenerIp();

            string result = add.AddSinFactura(NFactura, IdUsuario, IdProveedor, FechaIngreso, Subtotal, total, Descuento, Sede);


            if (result.Trim() == Convert.ToString(0))
            {
                MessageBox.Show("Lo sentimos. La compra no se puedo agregar. :(");
                return result;
            }
            else
            {
                if (result.Trim() != Convert.ToString(0))
                {
                    MessageBox.Show("La compra se agregó correctamente. :)");
                }

                return result;

            }
        }






    }
}
