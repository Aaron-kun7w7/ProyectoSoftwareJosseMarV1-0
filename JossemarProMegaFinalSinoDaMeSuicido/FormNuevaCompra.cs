using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JossemarProMegaFinalSinoDaMeSuicido
{
    public partial class FormNuevaCompra : Form
    {
        public FormNuevaCompra()
        {
            InitializeComponent();
        }

        //Variables para diseño estetico del texbox
        string cantidad = "", lote = "", NFactura = "", pcompra="", pventas="", interess="", sub="",total="", desc="", subinteres="";

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
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public double interes;
        public double MontoInt;
        public double Subtotal;
        public double TotalConIva;
        public string fecha;
        public int factura;

       















    }
}
