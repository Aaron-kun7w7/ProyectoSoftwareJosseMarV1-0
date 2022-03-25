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

        public string LogicaAddCompra(string NFactura, int IdUsuario, int IdProveedor, string FechaIngreso, double Subtotal, double total, double Descuento, int Sede)
        {
            // string IP = ip.ObtenerIp();

            string result = add.AddCompra(NFactura, IdUsuario, IdProveedor, FechaIngreso, Subtotal, total, Descuento, Sede);


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
        /*METODO PARA LLENAR DETALLE DE COMPRA*/
        public string LogicaAddDetalleCompra(int IdCompra, int IdProducto, double Cantidad, double PrecioCompra, double PrecioVenta)
        {
            // string IP = ip.ObtenerIp();

            string result = add.AddDetalleCompra(IdCompra,IdProducto,Cantidad,PrecioCompra,PrecioVenta);


            if (result.Trim() == Convert.ToString(0))
            {
                MessageBox.Show("DetalleCompra");
                return result;
            }
            else
            {
                if (result.Trim() != Convert.ToString(0))
                {
                    MessageBox.Show(":(");
                }

                return result;

            }
        }

        public string LogicaAddLotes(int IdProducto, string FechaCaducidad, string NumeroLote, string FechaIngreso, double CantidadU, int IdCompra, int IdSede)
        {
            // string IP = ip.ObtenerIp();

            string result = add.AddLotes(IdProducto,FechaCaducidad,NumeroLote,FechaIngreso,CantidadU,IdCompra,IdSede);


            if (result.Trim() == Convert.ToString(0))
            {
                MessageBox.Show("Lotes");
                return result;
            }
            else
            {
                if (result.Trim() != Convert.ToString(0))
                {
                    MessageBox.Show(":(");
                }

                return result;

            }
        }

        public string LogicaAddPrecioActual(double PrecioCompra, double PrecioVenta, int IdProducto, int IdSede)
        {
            string result = add.AddPrecioActual(PrecioCompra, PrecioVenta, IdProducto, IdSede);


            if (result.Trim() == Convert.ToString(0))
            {
                MessageBox.Show("Precio Actual");
                return result;
            }
            else
            {
                if (result.Trim() != Convert.ToString(0))
                {
                    MessageBox.Show(":(");
                }

                return result;

            }
        }
    }
}
