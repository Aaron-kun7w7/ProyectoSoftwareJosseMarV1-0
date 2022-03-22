using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
namespace JossemarProMegaFinalSinoDaMeSuicido
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        string result = "";

        string localIP;
        string idp2;
        string idU;
        int contador = 0;
        FormPrincipal p = new  FormPrincipal();
        CLogicaConsultas sql = new CLogicaConsultas();
        CLogicaObtenerIP ip = new CLogicaObtenerIP();
        /*private void BtnRegistrarse_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Registro r = new Registro();
            r.Show();
            this.Close();
           
        }*/

        private void Inicio_Load(object sender, EventArgs e)
        {
            SesionIniciada();
            idp2 = "";
            
        }

        /*private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }*/

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void ObtenerDatos()
        {

            CLogicaIniciarSesion log = new CLogicaIniciarSesion();
            string nombreU = TxtUsuario2.Text;
            string passU = TxtContraseña2.Text;
            CLogicaObtenerIP ip = new CLogicaObtenerIP();

            string IpM = ip.ObtenerIp();
            result = log.IniciarS(nombreU, passU, IpM);

            if (result.Trim() == Convert.ToString("R"))
            {
                MessageBox.Show("Error, Ya tiene una sesión abierta. :(", "ERROR Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (result.Trim() == Convert.ToString("Q"))
            {
                localIP = ip.ObtenerIp();
                idp2 = sql.ConsultaSimple("SELECT IpMaquina.IdUsuario FROM IpMaquina WHERE IpMaquina ='" + localIP + "'");

                //MessageBox.Show("Bienvenido. :)");
                p.Show();
                this.Close();
            }

            if (result.Trim() == Convert.ToString("S"))
            {
                localIP = ip.ObtenerIp();
                idp2 = sql.ConsultaSimple("SELECT IpMaquina.IdUsuario FROM IpMaquina WHERE IpMaquina ='" + localIP + "'");

                //MessageBox.Show("Bienvenido Sr. :)");
                p.Show();
                this.Close();
            }
            else if (result.Trim() == Convert.ToString("A"))
            {

                localIP = ip.ObtenerIp();
                idp2 = sql.ConsultaSimple("SELECT IpMaquina.IdUsuario FROM IpMaquina WHERE IpMaquina ='" + localIP + "'");

               // MessageBox.Show("Bienvenido. :)");
                p.Show();
                this.Close();
            }
           
                if (result.Trim() == Convert.ToString("O"))
                {
                int contador = 0;
                    localIP = ip.ObtenerIp();
                    idp2 = sql.ConsultaSimple("SELECT IpMaquina.IdUsuario FROM IpMaquina WHERE IpMaquina ='" + localIP + "'");

                    if (Convert.ToInt64(idp2) > 0)
                    {
                    contador++;
                    MessageBox.Show("Error, Ya tiene una sesión abierta. :(", "ERROR Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (contador == 0)
                    {
                    p.Show();
                    this.Close();
                    }
                
            }
        }

        void SesionIniciada()
        {
                int contador = 0;
                localIP = ip.ObtenerIp();
                idp2 = sql.ConsultaSimple("SELECT IpMaquina.IdUsuario FROM IpMaquina WHERE IpMaquina ='" + localIP + "'");
           // MessageBox.Show("SELECT IpMaquina.IdUsuario FROM IpMaquina WHERE IpMaquina ='" + localIP + "'");
                //MessageBox.Show(idp2);
                if (idp2 != "") { 
                if (Convert.ToInt64(idp2) > 0)
                 {
                    /*contador++;
                    MessageBox.Show("Error, Ya tiene una sesión abierta. :(", "ERROR Login", MessageBoxButtons.OK, MessageBoxIcon.Error);*/
                    p.Show();
                    this.Close();
                }

               
                }

        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            CLogicaObtenerFecha of = new CLogicaObtenerFecha();
            CLogicaObtenerIP ip = new CLogicaObtenerIP();
            CLogicaHistorialU hs = new CLogicaHistorialU();

            

            string fecha, IpMaquina;
            int IdUsuario;

            fecha = of.ObtenerFechaSinHora();
            IpMaquina = ip.ObtenerIp();
            //MessageBox.Show(idp2);
            

            if (ChbRecordar.Checked == true)
            {
                ObtenerDatos();
                IdUsuario = Convert.ToInt32(idp2);

                hs.AgregarHistorialU(fecha, IdUsuario,IpMaquina);
                
            }
            else
            {
                ObtenerDatos();
            }
            
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Registro r = new Registro();
            r.Show();
            this.Close();
        }


        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            if (TxtContraseña2.UseSystemPasswordChar == true)
            {
                TxtContraseña2.UseSystemPasswordChar = false;
                guna2CircleButton1.FillColor = System.Drawing.Color.Gray;
            }
            else
            {
                TxtContraseña2.UseSystemPasswordChar = true;
                guna2CircleButton1.FillColor = System.Drawing.Color.White;
            }
        }

        private void TxtContraseña2_Enter(object sender, EventArgs e)
        {
            if (TxtContraseña2.Text == "CONTRASEÑA")
            {
                TxtContraseña2.Text = "";
                TxtContraseña2.UseSystemPasswordChar = true;
            }
        }

        private void TxtContraseña2_Leave(object sender, EventArgs e)
        {
            if (TxtContraseña2.Text == "")
            {
                TxtContraseña2.UseSystemPasswordChar = false;
                TxtContraseña2.Text = "CONTRASEÑA";
            }
        }

        private void TxtUsuario2_Enter(object sender, EventArgs e)
        {
            if (TxtUsuario2.Text == "USUARIO")
            {
                TxtUsuario2.Text = "";
            }
        }

        private void TxtUsuario2_Leave(object sender, EventArgs e)
        {
            if (TxtUsuario2.Text == "")
            {
                TxtUsuario2.Text = "USUARIO";
            }
        }

    }
}
