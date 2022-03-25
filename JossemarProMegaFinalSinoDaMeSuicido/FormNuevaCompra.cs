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
    public partial class FormNuevaCompra : Form
    {
        public FormNuevaCompra(string a)
        {
            InitializeComponent();
            id = a;
        }
        string id;
        string idCompra;
        int IdProducto = 0;
        double PrecioC;
        double PrecioV;
        //Variables para diseño estetico del texbox
        string cantidad = "", lote = "", NFactura = "", pcompra="", pventas="", interess="", sub="",total="", desc="", subinteres="";
        CLogicaCompraFINAL buy = new CLogicaCompraFINAL();
        CLogicaLlenarCmb fill = new CLogicaLlenarCmb();
        CLogicaConsultas sql = new CLogicaConsultas();
        CLogicaObtenerIP ip = new CLogicaObtenerIP();
        private void TxtCantidad_Leave(object sender, EventArgs e)
        {
            cantidad = TxtCantidad.Text;
            if (cantidad.Equals("Cantidad"))
            {
                TxtCantidad.Text = "Cantidad";
                TxtCantidad.ForeColor = Color.Gray;

            }
            else
            {
                if (cantidad.Equals(""))
                {
                    TxtCantidad.Text = "Cantidad";
                    TxtCantidad.ForeColor = Color.Gray;
                }
                else
                {
                    TxtCantidad.Text = cantidad;
                    TxtCantidad.ForeColor = Color.Black;
                }
            }

        }

        private void TxtPCompra_Enter(object sender, EventArgs e)
        {
            TxtPCompra.Text = "";
            TxtPCompra.ForeColor = Color.Black;
        }

        private void TxtPCompra_Leave(object sender, EventArgs e)
        {

            pcompra = TxtPCompra.Text;
            if (pcompra.Equals("Precio Compra"))
            {
                TxtPCompra.Text = "Precio Compra";
                TxtPCompra.ForeColor = Color.Gray;

            }
            else
            {
                if (pcompra.Equals(""))
                {
                    TxtPCompra.Text = "Precio Compra";
                    TxtPCompra.ForeColor = Color.Gray;
                }
                else
                {
                    TxtPCompra.Text = cantidad;
                    TxtPCompra.ForeColor = Color.Black;
                }
            }

        }

        private void TxtPVenta_Enter(object sender, EventArgs e)
        {
            TxtPVenta.Text = "";
            TxtPVenta.ForeColor = Color.Black;
        }

        private void TxtPVenta_Leave(object sender, EventArgs e)
        {
            pventas = TxtPVenta.Text;
            if (pventas.Equals("Precio Venta"))
            {
                TxtPCompra.Text = "Precio Venta";
                TxtPCompra.ForeColor = Color.Gray;

            }
            else
            {
                if (pventas.Equals(""))
                {
                    TxtPVenta.Text = "Precio Venta";
                    TxtPVenta.ForeColor = Color.Gray;
                }
                else
                {
                    TxtPVenta.Text = cantidad;
                    TxtPVenta.ForeColor = Color.Black;
                }
            }
        }

        private void TxtLote_Enter(object sender, EventArgs e)
        {
            TxtLote.Text = "";
            TxtLote.ForeColor = Color.Black;
        }

        private void TxtLote_Leave(object sender, EventArgs e)
        {
             lote= TxtPVenta.Text;
            if (lote.Equals("Tamaño Lote"))
            {
                TxtLote.Text = "Tamaño Lote";
                TxtLote.ForeColor = Color.Gray;

            }
            else
            {
                if (lote.Equals(""))
                {
                    TxtLote.Text = "Tamaño Lote";
                    TxtLote.ForeColor = Color.Gray;
                }
                else
                {
                    TxtLote.Text = cantidad;
                    TxtLote.ForeColor = Color.Black;
                }
            }
        }

        private void TxtNumeroFactura_Enter(object sender, EventArgs e)
        {
            TxtNumeroFactura.Text = "";
            TxtNumeroFactura.ForeColor = Color.Black;
        }

        private void TxtNumeroFactura_Leave(object sender, EventArgs e)
        {
            NFactura = TxtNumeroFactura.Text;
            if (NFactura.Equals("N° Factura"))
            {
                TxtNumeroFactura.Text = "N° Factura";
                TxtNumeroFactura.ForeColor = Color.Gray;

            }
            else
            {
                if (NFactura.Equals(""))
                {
                    TxtNumeroFactura.Text = "N° Factura";
                    TxtNumeroFactura.ForeColor = Color.Gray;
                }
                else
                {
                    TxtNumeroFactura.Text = cantidad;
                    TxtNumeroFactura.ForeColor = Color.Black;
                }
            }

        }

        private void TxtInteres_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtInteres_Enter(object sender, EventArgs e)
        {
            TxtInteres.Text = "";
            TxtInteres.ForeColor = Color.Black;

        }

        private void TxtInteres_Leave(object sender, EventArgs e)
        {
            interess = TxtPVenta.Text;
            if (interess.Equals("Interes (%)"))
            {
                TxtInteres.Text = "Interes (%)";
                TxtInteres.ForeColor = Color.Gray;

            }
            else
            {
                if (interess.Equals(""))
                {
                    TxtInteres.Text = "Interes(%)";
                    TxtInteres.ForeColor = Color.Gray;
                }
                else
                {
                    TxtInteres.Text = cantidad;
                    TxtInteres.ForeColor = Color.Black;
                }
            }
        }

        private void TxtCantidad_Enter(object sender, EventArgs e)
        {
            TxtCantidad.Text = "";
            TxtCantidad.ForeColor = Color.Black;
        }

        private void TxtBuscar_Enter(object sender, EventArgs e)
        {
            TxtBuscar.Text = "";
            TxtBuscar.ForeColor = Color.Black;
        }

        private void TxtBuscar_Leave(object sender, EventArgs e)
        {
            Buscar = TxtBuscar.Text;
            if (Buscar.Equals("Buscar"))
            {
                TxtBuscar.Text = "Buscar";
                TxtBuscar.ForeColor = Color.Gray;

            }
            else
            {
                if (interess.Equals(""))
                {
                    TxtBuscar.Text = "Buscar";
                    TxtBuscar.ForeColor = Color.Gray;
                }
                else
                {
                    TxtBuscar.Text = cantidad;
                    TxtBuscar.ForeColor = Color.Black;
                }
            }
        }

        private void FormNuevaCompra_Load(object sender, EventArgs e)
        {
            TxtCantidad.Text = "Cantidad";
            TxtPCompra.Text = "Precio Compra";
            TxtPVenta.Text = " Precio Venta";
            TxtLote.Text = "Tamaño Lote";
            TxtNumeroFactura.Text = "N° Factura";
            TxtInteres.Text = "Interes (%)";
            TxtSubtotal.Text = "Subtotal";
            TxtSubInteres.Text = "Monto Interes";
            TxtDescuento.Text = "Descuento";
            TxtTotal.Text = "Total a Pagar";

            TxtCantidad.ForeColor = Color.Gray;
            TxtPCompra.ForeColor = Color.Gray;
            TxtPVenta.ForeColor = Color.Gray;
            TxtLote.ForeColor = Color.Gray;
            TxtNumeroFactura.ForeColor = Color.Gray;
            TxtInteres.ForeColor = Color.Gray;
            TxtSubtotal.ForeColor = Color.Gray;
            TxtSubInteres.ForeColor = Color.Gray;
            TxtDescuento.ForeColor = Color.Gray;
            TxtTotal.ForeColor = Color.Gray;
            MostrarProd("");
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarProd(TxtBuscar.Text);
        }

        public double interes;
        public double MontoInt;

        private void DgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IdProducto = Convert.ToInt32(DgvProductos.CurrentRow.Cells[4].Value);
        }

        public double Subtotal;


        public double TotalConIva;
        public string fecha;
        public int factura;
        string Buscar;

        //METODO PARA MOSTRAR PRODUCTOS
        void MostrarProd(string a)
        {
            DgvProductos.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvProductos.DataSource = fill.MostrarProd(a);

            this.DgvProductos.Columns["IdProducto"].Visible = false;
            this.DgvProductos.Columns["IdEstadoProducto"].Visible = false;
        }

        //METODO PARA CAMPTURAR DATOS Y HACER QUE SE MANDEN A LOS METODOS EN LAS CLASES DE LA CAPA LOGICA
       void CapturarDatosCompra()
        {
            string Nfactura = TxtNumeroFactura.Text;

            int IdUsuario = Convert.ToInt32(id);
            int IdProveedor = Convert.ToInt16(CmbProveedores.SelectedValue.ToString());

            string FechaIngreso = DtpIngreso.Value.ToString("yyy/MM/dd");

            double SubT = Convert.ToDouble(TxtSubtotal.Text);
            double Descuento = Convert.ToDouble(TxtDescuento.Text);
            double Total = Convert.ToDouble(TxtTotal.Text);

            int IdSede = Convert.ToInt32(ip.ObtenerSede());

            buy.LogicaAddCompra(Nfactura,IdUsuario,IdProveedor, FechaIngreso,SubT,Total,Descuento,IdSede);
            
            idCompra = sql.ConsultaSimple("SELECT MAX(dbo.Compra.IdCompra)From Compra");
        }

        void CapturarDatosDetalleCompra()
        {
            int IdCompra = Convert.ToInt32(idCompra);
            int idProducto = IdProducto;
            double cantidad = Convert.ToDouble(TxtCantidad.Text);
             PrecioC = Convert.ToDouble(TxtPCompra.Text);
             PrecioV = Convert.ToDouble(TxtPVenta.Text);

            buy.LogicaAddDetalleCompra(IdCompra, idProducto, cantidad, PrecioC, PrecioV);
        }


        void CapturarDatosLotes()
        {
            int idProducto = IdProducto;
            string FechaCaducidad = DtpCaducidad.Value.ToString("yyy/MM/dd");
            string numeroLote = Convert.ToString(TxtLote.Text).Trim();
            string FechaIngreso = DtpIngreso.Value.ToString("yyy/MM/dd");
            double cantidadU = Convert.ToDouble(TxtCantidad.Text);
            int IdCompra = Convert.ToInt32(idCompra);
            int IdSede = Convert.ToInt32(ip.ObtenerSede());

            buy.LogicaAddLotes(idProducto, FechaCaducidad, numeroLote, FechaIngreso, cantidadU, IdCompra, IdSede);
        }
        
        void CapturarPrecioActual()
        {
            PrecioC = Convert.ToDouble(TxtPCompra.Text);
            PrecioV = Convert.ToDouble(TxtPVenta.Text);
            int idProducto = IdProducto;
            int idSede = Convert.ToInt32(ip.ObtenerSede());

            buy.LogicaAddPrecioActual(PrecioC, PrecioV, idProducto, idSede);
        }
    }
}
