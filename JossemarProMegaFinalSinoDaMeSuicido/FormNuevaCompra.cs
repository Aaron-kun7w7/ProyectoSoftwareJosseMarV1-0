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
            
            cmbProveedores();
            

            DgvCarrito.Columns[0].Width = 90;
            DgvCarrito.Columns[1].Width = 90;
            DgvCarrito.Columns[2].Width = 90;
            DgvCarrito.Columns[3].Width = 90;
            DgvCarrito.Columns[4].Width = 90;
            DgvCarrito.Columns[5].Width = 90;
            DgvCarrito.Columns[6].Width = 90;
            DgvCarrito.Columns[7].Width = 90;
            DgvCarrito.Columns[8].Width = 90;
            DgvCarrito.Columns[9].Width = 90;
            DgvCarrito.Columns[10].Width = 90;

            TxtSubInteres.Visible = false;
            
        }
        string id;
        string idCompra;
        int IdProducto = 0;
        double PrecioC;
        double PrecioV;
        int contador = 0, contador2 = 0, suma=0, descuento=0, totalF=0;

        //Variables para diseño estetico del texbox
        string cantidad = "", lote = "", NFactura = "", pcompra="", pventas="", interess="", sub="",total="", desc="", subinteres="";
        CLogicaCompraFINAL buy = new CLogicaCompraFINAL();
        CLogicaLlenarCmb fill = new CLogicaLlenarCmb();
        CLogicaConsultas sql = new CLogicaConsultas();
        CLogicaObtenerIP ip = new CLogicaObtenerIP();
       

        private void TxtInteres_Enter(object sender, EventArgs e)
        {
            //TxtInteres.Text = "";
            //TxtInteres.ForeColor = Color.Black;

        }

        private void TxtInteres_Leave(object sender, EventArgs e)
        {
        //    interess = TxtPVenta.Text;
        //    if (interess.Equals("Interes (%)"))
        //    {
        //        TxtInteres.Text = "Interes (%)";
        //        TxtInteres.ForeColor = Color.Gray;

        //    }
        //    else
        //    {
        //        if (interess.Equals(""))
        //        {
        //            TxtInteres.Text = "Interes(%)";
        //            TxtInteres.ForeColor = Color.Gray;
        //        }
        //        else
        //        {
        //            TxtInteres.Text = cantidad;
        //            TxtInteres.ForeColor = Color.Black;
        //        }
        //    }
        }

        private void FormNuevaCompra_Load(object sender, EventArgs e)
        {
            TxtCantidad.Text = "Cantidad";
            TxtPCompra.Text = "Precio Compra";
            TxtPVenta.Text = "Precio Venta";
            TxtLote.Text = "Tamaño Lote";
            TxtNumeroFactura.Text = "N° Factura";
            //TxtInteres.Text = "Interes (%)";
            TxtSubtotal.Text = "Subtotal";
            TxtSubInteres.Text = "Monto Interes";
            TxtDescuento.Text = "Descuento";
            TxtTotal.Text = "Total a Pagar";
            TxtDescuento.Text = "Descuento";
            TxtSubtotal.Text = "SubTotal";

            TxtCantidad.ForeColor = Color.Gray;
            TxtPCompra.ForeColor = Color.Gray;
            TxtPVenta.ForeColor = Color.Gray;
            TxtLote.ForeColor = Color.Gray;
            TxtNumeroFactura.ForeColor = Color.Gray;
            //TxtInteres.ForeColor = Color.Gray;
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

       

        public double Subtotal;


        public double TotalConIva;
        public string fecha;
        public int factura;

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
         AgregarDatosRestantes();
            sumaTotal();

        }

        private void DgvProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (true)
            {

            }
            
            
            DgvCarrito.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //DgvCarrito.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            contador = 0 + contador2;
            contador2++;
            DgvCarrito.Rows.Add();

            DgvCarrito.Rows[contador].Cells[1].Value = DgvProductos.Rows[e.RowIndex].Cells[0].Value;
            DgvCarrito.Rows[contador].Cells[2].Value = DgvProductos.Rows[e.RowIndex].Cells[1].Value;
            DgvCarrito.Rows[contador].Cells[3].Value = DgvProductos.Rows[e.RowIndex].Cells[2].Value;
            DgvCarrito.Rows[contador].Cells[4].Value = DgvProductos.Rows[e.RowIndex].Cells[3].Value;

            
        }

        private void TxtNumeroFactura_Enter_1(object sender, EventArgs e)
        {
            if (TxtNumeroFactura.Text == "N° Factura")
            {
                TxtNumeroFactura.Text = "";
                TxtNumeroFactura.ForeColor = Color.Black;
            }
            
        }

       
        private void TxtLote_Enter_1(object sender, EventArgs e)
        {
            if (TxtLote.Text == "Tamaño Lote")
            {
                TxtLote.Text = "";
                TxtLote.ForeColor = Color.Black;
            }

        }

        private void TxtLote_Leave_1(object sender, EventArgs e)
        {

            if (TxtLote.Text == "")
            {
                TxtLote.Text = "Tamaño Lote";
                TxtLote.ForeColor = Color.Gray;
            }

        }

        private void TxtCantidad_Leave_1(object sender, EventArgs e)
        {
            if (TxtCantidad.Text == "")
            {
                TxtCantidad.Text = "Cantidad";
                TxtCantidad.ForeColor = Color.Gray;
            }

        }

        private void TxtCantidad_Enter_1(object sender, EventArgs e)
        {

            if (TxtCantidad.Text == "Cantidad")
            {
                TxtCantidad.Text = "";
                TxtCantidad.ForeColor = Color.Black;
            }

            
        }

       
        private void TxtPCompra_Enter_1(object sender, EventArgs e)
        {

            if (TxtPCompra.Text == "Precio Compra")
            {
                TxtPCompra.Text = "";
                TxtPCompra.ForeColor = Color.Black;
            }
            
        }

        private void TxtPCompra_Leave_1(object sender, EventArgs e)
        {
            if (TxtPCompra.Text == "")
            {
                TxtPCompra.Text = "Precio Compra";
                TxtPCompra.ForeColor = Color.Gray;
            }
        }

        private void TxtPVenta_Enter_1(object sender, EventArgs e)
        {
            if (TxtPVenta.Text == "Precio Venta")
            {
                TxtPVenta.Text = "";
                TxtPVenta.ForeColor = Color.Black;
            }
        }

        private void TxtPVenta_Leave_1(object sender, EventArgs e)
        {
            if (TxtPVenta.Text == "")
            {
                TxtPVenta.Text = "Precio Venta";
                TxtPVenta.ForeColor = Color.Gray;
            }

        }

        private void TxtBuscar_Enter_1(object sender, EventArgs e)
        {
            if (TxtBuscar.Text == "Buscar")
            {
                TxtBuscar.Text = "";
                TxtBuscar.ForeColor = Color.Black;
            }

            
        }

        private void TxtBuscar_Leave_1(object sender, EventArgs e)
        {
            if (TxtBuscar.Text == "")
            {
                TxtBuscar.Text = "Buscar";
                TxtBuscar.ForeColor = Color.Gray;
            }

        }

        private void TxtNumeroFactura_Leave_1(object sender, EventArgs e)
        {
            if (TxtNumeroFactura.Text=="")
            {
                TxtNumeroFactura.Text = "N° Factura";
                TxtNumeroFactura.ForeColor = Color.Gray;
            }



            /*

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
            */
        }

        private void BtnDescuento_Click(object sender, EventArgs e)
        {
            try
            {
                descuento = Convert.ToInt32(TxtDescuento.Text);

                totalF = suma - descuento;

                TxtTotal.Text = Convert.ToString(totalF);
            }
            catch (Exception)
            {

                MessageBox.Show("No se puede aplicar el descuento debido a que no hay productos");
            }
            
            
        }

        private void TxtDescuento_Enter(object sender, EventArgs e)
        {
            if (TxtDescuento.Text == "Descuento")
            {
                TxtDescuento.Text = "";
                TxtDescuento.ForeColor = Color.Black;
            }
        }

        private void TxtDescuento_Leave(object sender, EventArgs e)
        {
            if (TxtPVenta.Text == "")
            {
                TxtPVenta.Text = "Descuento";
                TxtPVenta.ForeColor = Color.Gray;
            }
        }

        private void TxtSubtotal_Leave(object sender, EventArgs e)
        {
            if (TxtSubtotal.Text == "")
            {
                TxtSubtotal.Text = "SubTotal";
                TxtSubtotal.ForeColor = Color.Gray;
            }
        }

        private void TxtNumeroFactura_Enter_2(object sender, EventArgs e)
        {

            if (TxtNumeroFactura.Text == "N° Factura")
            {
                TxtNumeroFactura.Text = "";
                TxtNumeroFactura.ForeColor = Color.Black;
            }
            
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Delete();
        }

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
            int IdProveedor = Convert.ToInt16(cmbProveedor.SelectedValue.ToString());

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

        void cmbProveedores()
        {
            cmbProveedor.DataSource = fill.cmbProveedores();
            cmbProveedor.DisplayMember = "NombreEmpresa";
            cmbProveedor.ValueMember = "IdProveedor";

        }

        void AgregarDatosRestantes()
        {
            int Proveedor = Convert.ToInt32(cmbProveedor.SelectedValue.ToString());
            string prov = sql.ConsultaSimple("SELECT NombreEmpresa FROM Proveedor where IdProveedor  = '" + Proveedor + "'");
            string fecha1 = DtpCaducidad.Value.ToString("yyy/MM/dd");
            string fecha2 = DtpIngreso.Value.ToString("yyy/MM/dd");
            
            if (TxtCantidad.Text == "Cantidad" && TxtLote.Text == "Tamaño Lote" && TxtNumeroFactura.Text == "N° Factura" && TxtPCompra.Text == "Precio Compra" && TxtPVenta.Text == "Precio Venta")
            {

                MessageBox.Show("Lo sentimos, porfavor rellene los campos solicitador");
            }
            else
            {
                //Recorremos el data
                for (int i = 0; i < DgvCarrito.RowCount; i++)
                {
                    //Obtenemos la ultima fila creada
                    int ultimaFila = DgvCarrito.Rows.Count - 1;

                    //nos posicionamos en la ultimafila existente
                    DgvCarrito.CurrentCell = DgvCarrito.Rows[ultimaFila].Cells[0];

                    //si la fila seleccionada es la ultima entonces
                    if (DgvCarrito.Rows[ultimaFila].Selected == true)
                    {
                        //agregamos los datos restantes al ultimo producto agregado
                        DgvCarrito.Rows[ultimaFila].Cells[0].Value = TxtNumeroFactura.Text;
                        DgvCarrito.Rows[ultimaFila].Cells[5].Value = Convert.ToString(TxtLote.Text);
                        DgvCarrito.Rows[ultimaFila].Cells[6].Value = Convert.ToString(TxtPCompra.Text);
                        DgvCarrito.Rows[ultimaFila].Cells[7].Value = Convert.ToString(TxtPVenta.Text);
                        DgvCarrito.Rows[ultimaFila].Cells[8].Value = fecha1;
                        DgvCarrito.Rows[ultimaFila].Cells[9].Value = fecha2;
                        DgvCarrito.Rows[ultimaFila].Cells[10].Value = prov;
                        DgvCarrito.Rows[ultimaFila].Cells[11].Value = Convert.ToString(TxtCantidad.Text);


                    }

                }

               
            }
            
            
            
        }

        void Limpiar2()
        {
            contador2--;
            foreach (DataGridViewRow row in DgvCarrito.SelectedRows)
            {
                DgvCarrito.Rows.RemoveAt(row.Index);
            }
            contador2 = 0;
        }

        void Delete()
        {
            TxtCantidad.Text = "Cantidad";
            TxtPCompra.Text = "Precio Compra";
            TxtPVenta.Text = "Precio Venta";
            TxtLote.Text = "Tamaño Lote";
            TxtNumeroFactura.Text = "N° Factura";
            //TxtInteres.Text = "Interes (%)";
            TxtSubtotal.Text = "Subtotal";
            //TxtSubInteres.Text = "Monto Interes";
            TxtDescuento.Text = "Descuento";
            TxtTotal.Text = "Total a Pagar";
            cmbProveedor.SelectedValue = 1;
           

        }

        int sumaTotal()
        {
            try
            {
                int calculo = 0;

                calculo = (Convert.ToInt32(DgvCarrito.Rows[DgvCarrito.RowCount - 1].Cells[6].Value) * (Convert.ToInt32(DgvCarrito.Rows[DgvCarrito.RowCount - 1].Cells[11].Value)));
                suma = (suma + calculo);


                TxtSubtotal.Text = Convert.ToString(suma);

               
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                MessageBox.Show("campos vacios");
                
            }
            catch (System.FormatException a)
            {
                MessageBox.Show("Algunos campos del producto en el carrito se encuentran vacios.");
            }   
            return suma;
        }

    }
}
