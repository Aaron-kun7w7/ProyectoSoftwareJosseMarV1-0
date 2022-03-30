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
using System.Threading;


namespace JossemarProMegaFinalSinoDaMeSuicido
{
    public partial class FormNuevaCompra : Form
    {
        public FormNuevaCompra(string a)
        {
            InitializeComponent();
            id = a;
            
            cmbProveedores();
            
            // tamaño de las columas personalizado
            DgvCarrito.Columns[0].Width = 70;
            DgvCarrito.Columns[1].Width = 70;
            DgvCarrito.Columns[2].Width = 70;
            DgvCarrito.Columns[3].Width = 70;
            DgvCarrito.Columns[4].Width = 70;
            DgvCarrito.Columns[5].Width = 70;
            DgvCarrito.Columns[6].Width = 70;
            DgvCarrito.Columns[7].Width = 70;
            DgvCarrito.Columns[8].Width = 70;
            DgvCarrito.Columns[9].Width = 70;
            DgvCarrito.Columns[10].Width = 70;

            //Botones y txt que deben iniciar por defecto asi
            TxtSubInteres.Visible = false;
            BtnDescuento.Enabled = false;
            
        }
        string id;
        string idCompra;
        int IdProducto = 0;
        double PrecioC, suma = 0, descuento = 0, totalF = 0;
        double PrecioV;
        int contador = 0, contador2 = 0;

        public double interes;
        public double MontoInt;
        public double Subtotal;
        public double TotalConIva;
        public string fecha;
        public int factura;

        //Variables para diseño estetico del texbox
        //string cantidad = "", lote = "", NFactura = "", pcompra="", pventas="", interess="", sub="",total="", desc="", subinteres="";
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

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            AgregarDatosRestantes();
            

        }

        private void DgvProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int primeraValidacion = DgvCarrito.RowCount;
            
            if (primeraValidacion==0)
            {
                //MessageBox.Show("Primera Validacion");

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

                string Categoria = Convert.ToString(DgvProductos.Rows[e.RowIndex].Cells[2].Value);
                string categoriaa = sql.ConsultaSimple("SELECT IdCategoria as ID  FROM Categoria where DescripcionC  = '" + Categoria + "'");
                DgvCarrito.Rows[contador].Cells[13].Value = Convert.ToInt32(categoriaa);

                string UM = Convert.ToString(DgvProductos.Rows[e.RowIndex].Cells[3].Value);
                string UMM = sql.ConsultaSimple("SELECT IdUnidadM as ID  FROM UnidadMedidas where DescripcionTipoUM  = '" + UM + "'");
                DgvCarrito.Rows[contador].Cells[14].Value = Convert.ToInt32(UMM);

                string ProductoID = Convert.ToString(DgvProductos.Rows[e.RowIndex].Cells[0].Value);
                string ProductoID2 = Convert.ToString(DgvProductos.Rows[e.RowIndex].Cells[1].Value);
                string ProductooID = sql.ConsultaSimple("SELECT Producto.IdProducto  FROM Producto where Producto.Nombre  = '" + ProductoID + "'" + " and Producto.Marca = '" + ProductoID2 +"'");
                DgvCarrito.Rows[contador].Cells[15].Value = Convert.ToInt32(ProductooID);




            }
            else if (primeraValidacion>=1)
            {
                //MessageBox.Show("Segunda Validacion");

                if ((Convert.ToString(DgvCarrito.Rows[contador].Cells[0].Value))=="" && (Convert.ToString(DgvCarrito.Rows[contador].Cells[5].Value)) == "" 
                    && (Convert.ToString(DgvCarrito.Rows[contador].Cells[6].Value)) == "" && (Convert.ToString(DgvCarrito.Rows[contador].Cells[7].Value)) == ""
                    && (Convert.ToString(DgvCarrito.Rows[contador].Cells[8].Value)) == "" && (Convert.ToString(DgvCarrito.Rows[contador].Cells[9].Value)) == "" 
                    && (Convert.ToString(DgvCarrito.Rows[contador].Cells[10].Value)) == "" && (Convert.ToString(DgvCarrito.Rows[contador].Cells[11].Value)) == "" 
                    && (Convert.ToString(DgvCarrito.Rows[contador].Cells[12].Value)) == "")
                {
                    MessageBox.Show("No se puede Agregar otro producto sin completar el anterior");
                }
                else
                {
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

                    string Categoria = Convert.ToString(DgvProductos.Rows[e.RowIndex].Cells[2].Value);
                    string categoriaa = sql.ConsultaSimple("SELECT IdCategoria as ID  FROM Categoria where DescripcionC  = '" + Categoria + "'");
                    DgvCarrito.Rows[contador].Cells[13].Value = Convert.ToInt32(categoriaa);

                    string UM = Convert.ToString(DgvProductos.Rows[e.RowIndex].Cells[3].Value);
                    string UMM = sql.ConsultaSimple("SELECT IdUnidadM as ID  FROM UnidadMedidas where DescripcionTipoUM  = '" + UM + "'");
                    DgvCarrito.Rows[contador].Cells[14].Value = Convert.ToInt32(UMM);

                    string ProductoID = Convert.ToString(DgvProductos.Rows[e.RowIndex].Cells[0].Value);
                    string ProductoID2 = Convert.ToString(DgvProductos.Rows[e.RowIndex].Cells[1].Value);
                    string ProductooID = sql.ConsultaSimple("SELECT Producto.IdProducto  FROM Producto where Producto.Nombre  = '" + ProductoID + "'" + " and Producto.Marca = '" + ProductoID2 + "'");
                    DgvCarrito.Rows[contador].Cells[15].Value = Convert.ToInt32(ProductooID);

                }

            }

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
                descuento = Convert.ToDouble(TxtDescuento.Text);

                if (descuento>=suma)
                {
                    MessageBox.Show("El descuento asignado es mayor al producto comprado");
                    TxtDescuento.Text = "Descuento";
                }
                else
                {
                    totalF = suma - descuento;
                    TxtTotal.Text = Convert.ToString(totalF);
                }
               
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
                BtnDescuento.Enabled = true;
            } 
        }

        private void TxtDescuento_Leave(object sender, EventArgs e)
        {
            if (TxtDescuento.Text == "")
            {
                TxtDescuento.Text = "Descuento";
                TxtDescuento.ForeColor = Color.Gray;
                descuento = 0;
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

        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void TxtPCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumerosPuntosyComas(e);
        }

        private void TxtPVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumerosPuntosyComas(e);
        }

        private void TxtLote_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetrasONumeros(e);
        }

        private void TxtNumeroFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetrasONumeros(e);
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
            
          
            for (int i = 0; i < DgvCarrito.RowCount; i++)
            {
                string Nfactura = Convert.ToString(DgvCarrito.Rows[i].Cells[0].Value).Trim();
                int IdUsuario = Convert.ToInt32(id);
                int IdProveedor = Convert.ToInt32(DgvCarrito.Rows[i].Cells[12].Value);
                string FechaIngreso =Convert.ToString(DgvCarrito.Rows[i].Cells[8].Value);
                double SubT = Convert.ToDouble(suma);
                double Total = Convert.ToDouble(totalF);
                double Descuento = Convert.ToDouble(descuento);


                string IdSede = Convert.ToString(ip.ObtenerSede());
                

                buy.LogicaAddCompra(Nfactura, IdUsuario, IdProveedor, FechaIngreso, SubT, Total, Descuento,Convert.ToInt32(IdSede));
               
            }
            idCompra = sql.ConsultaSimple("SELECT MAX(dbo.Compra.IdCompra)From Compra");
        }

        void CapturarDatosDetalleCompra()
        {
           
            for (int i = 0; i < DgvCarrito.RowCount; i++)
            {
                int IdCompra = Convert.ToInt32(idCompra);
                int idProducto = Convert.ToInt32(DgvCarrito.Rows[i].Cells[15].Value);
                double cantidad = Convert.ToDouble(DgvCarrito.Rows[i].Cells[11].Value);
                PrecioC = Convert.ToDouble(DgvCarrito.Rows[i].Cells[6].Value);
                PrecioV = Convert.ToDouble(DgvCarrito.Rows[i].Cells[7].Value);
                buy.LogicaAddDetalleCompra(IdCompra, idProducto, cantidad, PrecioC, PrecioV);
            }
        }


        void CapturarDatosLotes()
        {
            

            for (int i = 0; i < DgvCarrito.RowCount; i++)
            {
  
                int idProducto = Convert.ToInt32(DgvCarrito.Rows[i].Cells[15].Value);
                string FechaCaducidad = Convert.ToString(DgvCarrito.Rows[i].Cells[9].Value).Trim();
                string numeroLote = Convert.ToString(DgvCarrito.Rows[i].Cells[5].Value).Trim();
                string FechaIngreso = Convert.ToString(DgvCarrito.Rows[i].Cells[8].Value).Trim();
                double cantidadU = Convert.ToDouble(DgvCarrito.Rows[i].Cells[11].Value);
                int IdCompra = Convert.ToInt32(idCompra);

                string IdSede = Convert.ToString(ip.ObtenerSede());
                

                buy.LogicaAddLotes(idProducto, FechaCaducidad, numeroLote, FechaIngreso, cantidadU, IdCompra, Convert.ToInt32(IdSede));

            }
        }
        
        void CapturarPrecioActual()
        {
            for (int i = 0; i < DgvCarrito.RowCount; i++)
            {
                PrecioC = Convert.ToDouble(DgvCarrito.Rows[i].Cells[6].Value);
                PrecioV = Convert.ToDouble(DgvCarrito.Rows[i].Cells[7].Value);
                int idProducto = Convert.ToInt32(DgvCarrito.Rows[i].Cells[15].Value);
                string IdSede = Convert.ToString(ip.ObtenerSede());

                buy.LogicaAddPrecioActual(PrecioC, PrecioV, idProducto, Convert.ToInt32(IdSede));
            }

            
        }

        void cmbProveedores()
        {
            cmbProveedor.DataSource = fill.cmbProveedores();
            cmbProveedor.DisplayMember = "NombreEmpresa";
            cmbProveedor.ValueMember = "IdProveedor";

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if ((Convert.ToString(DgvCarrito.Rows[contador].Cells[0].Value)) == "" && (Convert.ToString(DgvCarrito.Rows[contador].Cells[5].Value)) == ""
                    && (Convert.ToString(DgvCarrito.Rows[contador].Cells[6].Value)) == "" && (Convert.ToString(DgvCarrito.Rows[contador].Cells[7].Value)) == ""
                    && (Convert.ToString(DgvCarrito.Rows[contador].Cells[8].Value)) == "" && (Convert.ToString(DgvCarrito.Rows[contador].Cells[9].Value)) == ""
                    && (Convert.ToString(DgvCarrito.Rows[contador].Cells[10].Value)) == "" && (Convert.ToString(DgvCarrito.Rows[contador].Cells[11].Value)) == ""
                    && (Convert.ToString(DgvCarrito.Rows[contador].Cells[12].Value)) == "")
            {
                MessageBox.Show("No se puede Guardar sin completar todos los campos");
            }
            else
            {
                CapturarDatosCompra();

                Thread Hilo1 = new Thread(CapturarDatosDetalleCompra);
                Thread Hilo2 = new Thread(CapturarDatosLotes);
                Thread Hilo3 = new Thread(CapturarPrecioActual);

                Hilo1.Start();
                Hilo2.Start();
                Hilo3.Start();
            }

            

            
            
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Limpiar2();
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

                    if (((Convert.ToString(DgvCarrito.Rows[ultimaFila].Cells[0].Value)) != "" && (Convert.ToString(DgvCarrito.Rows[ultimaFila].Cells[5].Value)) != ""
                        && (Convert.ToString(DgvCarrito.Rows[ultimaFila].Cells[6].Value)) != "" && (Convert.ToString(DgvCarrito.Rows[ultimaFila].Cells[7].Value)) != ""
                        && (Convert.ToString(DgvCarrito.Rows[ultimaFila].Cells[8].Value)) != "" && (Convert.ToString(DgvCarrito.Rows[ultimaFila].Cells[9].Value)) != ""
                        && (Convert.ToString(DgvCarrito.Rows[ultimaFila].Cells[10].Value)) != "" && (Convert.ToString(DgvCarrito.Rows[ultimaFila].Cells[11].Value)) != ""
                        && (Convert.ToString(DgvCarrito.Rows[ultimaFila].Cells[12].Value)) != ""))
                    {
                        MessageBox.Show("No se pueden agregar estos datos porque no ha ingresado otro producto");


                    }
                    else
                    {
                        //si la fila seleccionada es la ultima entonces
                        if (DgvCarrito.Rows[i].Selected == DgvCarrito.Rows[ultimaFila].Selected)
                        {

                            if (TxtCantidad.Text == "Cantidad" && TxtPCompra.Text == "Precio Compra" && TxtPVenta.Text == "Precio Venta" &&
                               TxtLote.Text == "Tamaño Lote" && TxtNumeroFactura.Text == "N° Factura")
                            {
                                MessageBox.Show("Rellene todos los campos restantes");
                            }
                            else
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
                                DgvCarrito.Rows[ultimaFila].Cells[12].Value = Convert.ToInt32(cmbProveedor.SelectedValue);

                                sumaTotal();

                                Delete();
                            }

                        }
                    }

                }

                
                TxtTotal.Text = Convert.ToString(suma);

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
            cmbProveedor.SelectedValue = 1;
           

        }

        Double sumaTotal()
        {
            try
            {
                Double calculo = 0;

               calculo = (Convert.ToDouble(DgvCarrito.Rows[DgvCarrito.RowCount - 1].Cells[6].Value) * (Convert.ToDouble(DgvCarrito.Rows[DgvCarrito.RowCount - 1].Cells[11].Value)));
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
