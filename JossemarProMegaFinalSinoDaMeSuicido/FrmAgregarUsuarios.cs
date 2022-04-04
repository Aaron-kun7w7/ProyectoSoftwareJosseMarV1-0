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
    public partial class FrmAgregarUsuarios : Form
    {
        public FrmAgregarUsuarios(FormAdmin d)
        {
            InitializeComponent();
            cmbSEDE();
        }

        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHanler;
        CLogicaConsultas consultas = new CLogicaConsultas();
        CLogicaLlenarCmb fill = new CLogicaLlenarCmb();

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }

        }

        protected void Actualizar()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHanler.Invoke(this, args);
        }


        string result = "";
        void capturarDatos()
        {
            string nombre = TxtNombre.Text;
            string apellido = TxtApellido.Text;
            string nombreUsuario = TxtNameUsuario.Text;
            string pass = TxtContraseña.Text;
            string confirmarPass = TxtConfirmarContraseña.Text;

            if (pass.Trim() != confirmarPass.Trim())
            {
                result = "Las contraseñas ingresadas, no coinciden. :(";
                MessageBox.Show(result, "Error 404 :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CLogicaRegistrar a = new CLogicaRegistrar();
                Inicio i = new Inicio();
                Registro r = new Registro();
                CLogicaObtenerIP ip = new CLogicaObtenerIP();

                string localIP = ip.ObtenerIp();


                string idp2 = consultas.ConsultaSimple("SELECT IpMaquina.IdUsuario FROM IpMaquina WHERE IpMaquina ='" + localIP + "'");
                string idU = consultas.ConsultaSimple("SELECT IpMaquina.IdUsuario FROM IpMaquina WHERE IpMaquina.IpMaquina = '" + localIP + "'");
                int IdSede = Convert.ToInt32(cmbSede.SelectedValue);

                string msg = a.register(nombre, apellido, nombreUsuario, pass, Convert.ToInt32(IdSede));

                result = "Ta bien";

                MessageBox.Show(msg);
                r.Close();
                i.Show();
            }


        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            capturarDatos();
            Actualizar();
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void cmbSEDE()
        {
            cmbSede.DataSource = fill.cmbSede();
            cmbSede.DisplayMember = "NombreEmpresa";
            cmbSede.ValueMember = "IdSede";

        }


    }
}
