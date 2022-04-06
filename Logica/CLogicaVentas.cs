using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Logica
{
    public class CLogicaVentas
    {

        CDatosVentas add = new CDatosVentas();
        // CLogicaObtenerIP ip = new CLogicaObtenerIP();
        public string AddVenta(string NomCli, string ApeCli, double descuento, double SubT,
         double Total, int IdUsuario)
        {
            // string IP = ip.ObtenerIp();

            string result = add.AgregarVenta(NomCli, ApeCli, descuento, SubT,
         Total, IdUsuario);



            return result;


        }

        public string AddVentasProd(int idV, int idProd, double cantidad, int IdLote)
        {
            string result = add.AgregarVentaProducto(idV, idProd, cantidad, IdLote);
            return result;
        }
        public string RestInventario(int idLote,int idProd, double stock, double cantidad)
        {
            string result = add.RestarInventario(idLote,idProd, stock, cantidad);
            return result;
        }

        public string DevolucionProdV(int nf, int idp, string estado, int idU,int idvp)
        {
            string result = add.DevolucionProdV( nf,  idp, estado,idU, idvp);
            return result;
        }

        public string RetirarDev(int idvp)
        {
            string result = add.RetirarDevolucion(idvp);
            return result;
        }

        public string CancelarAllNFact(int idV, int idvp, int idU, int Tipo)
        {
            string result = add.CancelarAllFactura(idV,idvp,idU,Tipo);
            return result;
        }

        public string Temporal(int IdLote, int IdProducto, double Cantidad)
        {
            string result = add.Temporal(IdLote, IdProducto, Cantidad);
            return result;
        }
    }
}
