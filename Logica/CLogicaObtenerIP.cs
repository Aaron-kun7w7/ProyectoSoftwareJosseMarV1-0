using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
namespace Logica
{
   public class CLogicaObtenerIP
    {
        public string ObtenerIp()
        {
            string Mac = "";
            foreach (NetworkInterface NIC in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (NIC.OperationalStatus == OperationalStatus.Up)
                {
                    Mac += NIC.GetPhysicalAddress().ToString();
                    break;
                }
            }
            return Mac;
        }

        public string ObtenerSede()
        {
            CLogicaConsultas c = new CLogicaConsultas();

            string localIP = ObtenerIp();
           string idp2 = c.ConsultaSimple("SELECT IpMaquina.IdUsuario FROM IpMaquina WHERE IpMaquina ='" + localIP + "'");
            string idU = c.ConsultaSimple("SELECT IpMaquina.IdUsuario FROM IpMaquina WHERE IpMaquina.IpMaquina = '" + localIP + "'");
            string IdSede = c.ConsultaSimple("SELECT Usuarios.IdSede FROM Usuarios WHERE Usuarios.IdUsuario = '" + idU + "'");

            return IdSede;
        }
    }
}
