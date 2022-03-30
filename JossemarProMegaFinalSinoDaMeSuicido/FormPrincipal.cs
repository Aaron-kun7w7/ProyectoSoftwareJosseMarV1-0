using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Logica;
using Datos;
namespace JossemarProMegaFinalSinoDaMeSuicido
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            Diseño();
            DiseñoBoton();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //metodos para mostar los sub menus
        private void Diseño()
        {
            PnlSubCompra.Visible = false;
            PnlSubInventario.Visible = false;
            PnlSubVentas. Visible = false;
            PnlSubCaja.Visible = false;
            PnlSubCredito.Visible = false;
            PnlSubPersona.Visible = false;
        }
        private void OcultarSubMenu()
        {
            if (PnlSubCompra.Visible == true)
                PnlSubCompra.Visible = false;
            if (PnlSubInventario.Visible == true)
                PnlSubInventario.Visible = false;
            if (PnlSubVentas.Visible == true)
                PnlSubVentas.Visible = false;
            if (PnlSubCaja.Visible == true)
                PnlSubCaja.Visible = false;
            if (PnlSubCredito.Visible == true)
                PnlSubCredito.Visible = false;
            if (PnlSubPersona.Visible == true)
                PnlSubPersona.Visible = false;
        }
        private void MostrarMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                OcultarSubMenu();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;
        }

        //metodos para mostrar el panel de color bajo el boton
        private void DiseñoBoton()
        {
            PnlPressCompra.Visible = false;
            PnlPressInventario.Visible = false;
            PnlPressVentas.Visible = false;
            PnlPressCaja.Visible = false;
            PnlPressCredito.Visible = false;
            PnlPressPersona.Visible = false;
        }
        private void OcultarPanel()
        {
            if (PnlPressCompra.Visible == true)
                PnlPressCompra.Visible = false;
            if (PnlPressInventario.Visible == true)
                PnlPressInventario.Visible = false;
            if (PnlPressVentas.Visible == true)
                PnlPressVentas.Visible = false;
            if (PnlPressCaja.Visible == true)
                PnlPressCaja.Visible = false;
            if (PnlPressCredito.Visible == true)
                PnlPressCredito.Visible = false;
            if (PnlPressPersona.Visible == true)
                PnlPressPersona.Visible = false;
        }
        private void MostrarPanel(Panel PanelBtn)
        {
            if (PanelBtn.Visible == false)
            {
                OcultarPanel();
                PanelBtn.Visible = true;
            }
            else
                PanelBtn.Visible = false;
        }

        private void BtnCompra_Click(object sender, EventArgs e)
        {

            MostrarPanel(PnlPressCompra);
            if (PnlPressCompra.Visible == false)
            {
                LblCompra.Location = new System.Drawing.Point(10, 61);
            }
            else
                LblCompra.Location = new System.Drawing.Point(10, 57);
            if (PnlPressCompra.Visible == false)
            {
                BtnCompra.Location = new System.Drawing.Point(10, 6);
            }
            else
                BtnCompra.Location = new System.Drawing.Point(10, 2);
            MostrarMenu(PnlSubCompra);
            

        }
        String idp2 = "", a;

        private Form activarfrm = null;
        public void ActivarFrm(Form frmVarios)
        {
            if (activarfrm != null)
                activarfrm.Close();
            activarfrm = frmVarios;
            frmVarios.TopLevel = false;
            frmVarios.FormBorderStyle = FormBorderStyle.None;
            frmVarios.Dock = DockStyle.Fill;
            PnlMostarFrames.Controls.Add(frmVarios);
            PnlMostarFrames.Tag = frmVarios;
            frmVarios.BringToFront();
            frmVarios.Show();
        }

        private void BtnCompra_MouseEnter(object sender, EventArgs e)
        {
            PnlCompra.FillColor = System.Drawing.Color.Gray;
            BtnCompra.BackColor = System.Drawing.Color.Gray;
        }

        private void BtnCompra_MouseLeave(object sender, EventArgs e)
        {
            PnlCompra.FillColor = System.Drawing.Color.Transparent;
            BtnCompra.BackColor = System.Drawing.Color.Transparent;
        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            MostrarPanel(PnlPressInventario);
            if (PnlPressInventario.Visible == false)
            {
                LblInventario.Location = new System.Drawing.Point(4, 61);
            }
            else
                LblInventario.Location = new System.Drawing.Point(4, 57);
            if (PnlPressInventario.Visible == false)
            {
                BtnInventario.Location = new System.Drawing.Point(10, 6);
            }
            else
                 BtnInventario.Location = new System.Drawing.Point(10, 2);
            MostrarMenu(PnlSubInventario);
        }

        private void BtnInventario_MouseEnter(object sender, EventArgs e)
        {
            PnlInventario.FillColor = System.Drawing.Color.Gray;
            BtnInventario.BackColor = System.Drawing.Color.Gray;
        }

        private void BtnInventario_MouseLeave(object sender, EventArgs e)
        {
            PnlInventario.FillColor = System.Drawing.Color.Transparent;
            BtnInventario.BackColor = System.Drawing.Color.Transparent;
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            MostrarPanel(PnlPressVentas);
            if (PnlPressVentas.Visible == false)
            {
                LblVentas.Location = new System.Drawing.Point(14, 61);
            }
            else
                LblVentas.Location = new System.Drawing.Point(14, 57);
            if (PnlPressVentas.Visible == false)
            {
                BtnVentas.Location = new System.Drawing.Point(10, 6);
            }
            else
                BtnVentas.Location = new System.Drawing.Point(10, 2);
            MostrarMenu(PnlSubVentas);
        }

        private void BtnVentas_MouseEnter(object sender, EventArgs e)
        {
            PnlVentas.FillColor = System.Drawing.Color.Gray;
            BtnVentas.BackColor = System.Drawing.Color.Gray;
        }

        private void BtnVentas_MouseLeave(object sender, EventArgs e)
        {
            PnlVentas.FillColor = System.Drawing.Color.Transparent;
            BtnVentas.BackColor = System.Drawing.Color.Transparent;
        }

        private void BtnCaja_Click(object sender, EventArgs e)
        {
            MostrarPanel(PnlPressCaja);
            if (PnlPressCaja.Visible == false)
            {
                LblCaja.Location = new System.Drawing.Point(20, 61);
            }
            else
                LblCaja.Location = new System.Drawing.Point(20, 57);
            if (PnlPressCaja.Visible == false)
            {
                BtnCaja.Location = new System.Drawing.Point(10, 6);
            }
            else
                BtnCaja.Location = new System.Drawing.Point(10, 2);
            MostrarMenu(PnlSubCaja);
        }

        private void BtnCaja_MouseEnter(object sender, EventArgs e)
        {
            PnlCaja.FillColor = System.Drawing.Color.Gray;
            BtnCaja.BackColor = System.Drawing.Color.Gray;
        }

        private void BtnCaja_MouseLeave(object sender, EventArgs e)
        {
            PnlCaja.FillColor = System.Drawing.Color.Transparent;
            BtnCaja.BackColor = System.Drawing.Color.Transparent;
        }

        private void PnlBarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnCredito_Click(object sender, EventArgs e)
        {
            MostrarPanel(PnlPressCredito);
            if (PnlPressCredito.Visible == false)
            {
                LblCredito.Location = new System.Drawing.Point(13, 61);
            }
            else
                LblCredito.Location = new System.Drawing.Point(13, 57);
            if (PnlPressCredito.Visible == false)
            {
                BtnCredito.Location = new System.Drawing.Point(10, 6);
            }
            else
                BtnCredito.Location = new System.Drawing.Point(10, 2);
            MostrarMenu(PnlSubCredito);
        }

        private void BtnCredito_MouseEnter(object sender, EventArgs e)
        {
            PnlCredito.FillColor = System.Drawing.Color.Gray;
            BtnCredito.BackColor = System.Drawing.Color.Gray;
        }

        private void BtnCredito_MouseLeave(object sender, EventArgs e)
        {
            PnlCredito.FillColor = System.Drawing.Color.Transparent;
            BtnCredito.BackColor = System.Drawing.Color.Transparent;
        }

        private void BtnPersona_Click(object sender, EventArgs e)
        {
            MostrarPanel(PnlPressPersona);
            if (PnlPressPersona.Visible == false)
            {
                LblPersona.Location = new System.Drawing.Point(12, 61);
            }
            else
                LblPersona.Location = new System.Drawing.Point(12, 57);
            if (PnlPressPersona.Visible == false)
            {
                BtnPersona.Location = new System.Drawing.Point(10, 6);
            }
            else
                BtnPersona.Location = new System.Drawing.Point(10, 2);
            MostrarMenu(PnlSubPersona);
        }

        private void BtnPersona_MouseEnter(object sender, EventArgs e)
        {
            PnlPersona.FillColor = System.Drawing.Color.Gray;
            BtnPersona.BackColor = System.Drawing.Color.Gray;
        }

        private void BtnPersona_MouseLeave(object sender, EventArgs e)
        {
            PnlPersona.FillColor = System.Drawing.Color.Transparent;
            BtnPersona.BackColor = System.Drawing.Color.Transparent;
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            CLogicaConsultas sql = new CLogicaConsultas();
            //sql.ConsultaSimple("UPDATE dbo.Usuario set Usuario.IdEstadoUsser = 2 WHERE Usuario.IdUsser ="+idp2+"");
            sql.ConsultaSimple("Delete from IpMaquina where IpMaquina.IdUsuario ='" + idp2 + "'");
            sql.ConsultaSimple("UPDATE dbo.Usuarios SET Usuarios.IdEstadoUsuario = 1 WHERE Usuarios.IdUsuario ='" + idp2 + "'");
            Inicio a = new Inicio();
            a.Show();
            this.Close();
        }
        void LimitarAdmins()
        {
            BtnPanelAdmin.Enabled = false;
            BtnPanelAdmin.Visible = false;
            guna2HtmlLabel2.Visible = false;
        }

        void LimitarAsistente()
        {
            BtnAgregarProducto.Enabled = false;
            BtnAgregarInventario.Enabled = false;
            BtnDevolucionCompra.Enabled = false;
            BtnAgregarInventario.Enabled = false;
            BtnNuevaVenta.Enabled = false;
            BtnDevoluciones.Enabled = false;
            BtnNuevoCredito.Enabled = false;
            BtnMovimientos.Enabled = false;
            BtnSaldo.Enabled = false;
            BtnNuevoCredito.Enabled = false;
            btnCreditoPendiente.Enabled = false;
            BtnCliente.Enabled = false;
            BtnProveedor.Enabled = false;
            BtnPersonal.Enabled = false;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            LbliUser.Text = "";
            CLogicaConsultas c = new CLogicaConsultas();
            CLogicaObtenerIP ip = new CLogicaObtenerIP();
            CLogicarecibirId recibirId = new CLogicarecibirId();
            string localIP = ip.ObtenerIp();
           // MessageBox.Show("Ip = "+localIP);
            idp2 = c.ConsultaSimple("SELECT IpMaquina.IdUsuario FROM IpMaquina WHERE IpMaquina ='" + localIP + "'");
            string idU = c.ConsultaSimple("SELECT IpMaquina.IdUsuario FROM IpMaquina WHERE IpMaquina.IpMaquina = '"+localIP + "'");
            string NomU = c.ConsultaSimple("SELECT Usuarios.NombreUsuario FROM Usuarios WHERE Usuarios.IdUsuario ='" + idU + "'");
            string TipoU = c.ConsultaSimple("SELECT Usuarios.IdTipoUsuario FROM Usuarios WHERE Usuarios.IdUsuario ='" + idU + "'");

            if (TipoU == "3")
            {
               //BtnCompra.Enabled = false;
                //BtnAgregarInventario.Enabled = false;
                LimitarAdmins();
            }
            else if (TipoU == "4")
            {
                LimitarAdmins();
                LimitarAsistente();
            }

            LblUsuario.Text = NomU;
            a = LbliUser.Text = idp2;

            recibirId.recibirId((idp2));
        }

        private void BtnProveedor_Click(object sender, EventArgs e)
        {
            ActivarFrm(new FormProveedor());
        }

        private void BtnPersonal_Click(object sender, EventArgs e)
        {
            ActivarFrm(new FormEmpleado());
        }

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            FormNuevaCompra b = new FormNuevaCompra(a);
            b.ShowDialog();
        }

        private void BtnDevolucionCompra_Click(object sender, EventArgs e)
        {
            //ActivarFrm(new AñadirEstante());
            //AñadirEstante a = new AñadirEstante();
            //a.ShowDialog();
        }

        private void BtnMostarInventario_Click(object sender, EventArgs e)
        {
            ActivarFrm(new FrmInventario());
        }

        private void BtnNuevaVenta_Click(object sender, EventArgs e)
        {
            ActivarFrm(new FormVentas(a));
        }

        private void BtnMovimientos_Click(object sender, EventArgs e)
        {
            ActivarFrm(new FrmActividades());
        }

        private void BtnSaldo_Click(object sender, EventArgs e)
        {
            FrmSaldos s = new FrmSaldos();
            s.ShowDialog();
        }

        private void BtnAgregarInventario_Click(object sender, EventArgs e)
        {
            //ActivarFrm(new AñadirSinFactura());
            AñadirSinFactura sf = new AñadirSinFactura();
            sf.ShowDialog();
        }

        private void BtnHistorialCompra_Click(object sender, EventArgs e)
        {
            //FrmAgregarProductoNuevo f = new FrmAgregarProductoNuevo(a);
            FrmAgregarProductoNuevo f = new FrmAgregarProductoNuevo(a);
            f.ShowDialog();

            


        }

        private void BtnDevoluciones_Click(object sender, EventArgs e)
        {
            ActivarFrm(new FrmDevolverVenta());
        }

        private void BtnHistorialVentas_Click(object sender, EventArgs e)
        {
            ActivarFrm(new FrmHistorialVentas(a));
        }

        private void BtnProductosSinfactura_Click(object sender, EventArgs e)
        {
            ActivarFrm(new FrmInventarioSinFactura());
        }

        private void PnlMostarFrames_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            // ActivarFrm(new FormAdmin());
            FormAdmin sa = new FormAdmin();
            sa.ShowDialog();
        }

        private void BtnNuevoCredito_Click(object sender, EventArgs e)
        {
            ActivarFrm(new FrmAgregarCV(a));
        }

        private void BtnHistorialCredito_Click(object sender, EventArgs e)
        {
            ActivarFrm(new FrmHistorialVentasCreditos());
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            ActivarFrm(new FormCliente());
        }
    }
}
