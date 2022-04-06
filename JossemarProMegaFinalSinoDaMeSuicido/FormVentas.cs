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
using Datos;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
namespace JossemarProMegaFinalSinoDaMeSuicido
{
    public partial class FormVentas : Form
    {
        public FormVentas(string ids)
        {
            InitializeComponent();
            id = ids;
        }
        string id, IdCliente, Descripcion, PrecioVenta, IdVenta, res;
        int contador = 0;
        CLogicaConsultas sql = new CLogicaConsultas();
        CLogicaAgregarClientes addC = new CLogicaAgregarClientes();
        CLogicaAgregarClientesCredito addcc = new CLogicaAgregarClientesCredito();
        CLogicaContadorCedula contCedula = new CLogicaContadorCedula();
        CDatosValidarCedula validation = new CDatosValidarCedula();
        CLogicaVentas vtc = new CLogicaVentas();
        Validaciones validar = new Validaciones();
        CLogicaObtenerFecha zzz = new CLogicaObtenerFecha();
        CLogicaLlenarCmb cmb99 = new CLogicaLlenarCmb();

        int[] idnombresProd;
        int idVenta;
        double[] cantidad;
        double[] cantidadInv;
        //-------------------
        string[] nombreprod;
        double[] cantidadprod;
        double[] precioprod;
        //------------------
        int stock2;
        int canti2, contaTactico;
        string fechav = "";
        string UnidadMedida = "";
        //METODOS PARA TRAER Y FILTRAR LOS PRODUCTOS
        void ProductosG(string a)
        {
            DgvProductos.DataSource = sql.ConsultaTab("SELECT vs_BtnViewInventario.IdCompra AS ID, vs_BtnViewInventario.NumeroFactura AS NFactura, vs_BtnViewInventario.NombreProducto AS Producto, vs_BtnViewInventario.Marca AS Marca,vs_BtnViewInventario.DescripcionC AS Categoría, vs_BtnViewInventario.Descripcion, vs_BtnViewInventario.DescripcionTipoUM AS UMedida, vs_BtnViewInventario.FechaIngreso AS FechaIngreso,vs_BtnViewInventario.FechaCaducidad AS FechaCaducidad, vs_BtnViewInventario.NombreEmpresa AS Proveedor, vs_BtnViewInventario.PrecioVenta AS PVenta,vs_BtnViewInventario.Stock FROM vs_BtnViewInventario WHERE vs_BtnViewInventario.NombreProducto LIKE'%" + a + "%' AND vs_BtnViewInventario.IdEstado =1");

        }

        void ProductosMarca(string a)
        {
            DgvProductos.DataSource = sql.ConsultaTab("SELECT vs_BtnViewInventario.IdCompra AS ID, vs_BtnViewInventario.NumeroFactura AS NFactura, vs_BtnViewInventario.NombreProducto AS Producto, vs_BtnViewInventario.Marca AS Marca,vs_BtnViewInventario.DescripcionC AS Categoría, vs_BtnViewInventario.Descripcion, vs_BtnViewInventario.DescripcionTipoUM AS UMedida, vs_BtnViewInventario.FechaIngreso AS FechaIngreso,vs_BtnViewInventario.FechaCaducidad AS FechaCaducidad, vs_BtnViewInventario.NombreEmpresa AS Proveedor, vs_BtnViewInventario.PrecioVenta AS PVenta,vs_BtnViewInventario.Stock FROM vs_BtnViewInventario WHERE vs_BtnViewInventario.NombreProducto LIKE'%" + a + "%' AND vs_BtnViewInventario.IdEstado =1 ORDER BY vs_BtnViewInventario.Marca");

        }

        void ProductosPrecioASC(string a)
        {
            DgvProductos.DataSource = sql.ConsultaTab("SELECT vs_BtnViewInventario.IdCompra AS ID, vs_BtnViewInventario.NumeroFactura AS NFactura, vs_BtnViewInventario.NombreProducto AS Producto, vs_BtnViewInventario.Marca AS Marca,vs_BtnViewInventario.DescripcionC AS Categoría, vs_BtnViewInventario.Descripcion, vs_BtnViewInventario.DescripcionTipoUM AS UMedida, vs_BtnViewInventario.FechaIngreso AS FechaIngreso,vs_BtnViewInventario.FechaCaducidad AS FechaCaducidad, vs_BtnViewInventario.NombreEmpresa AS Proveedor, vs_BtnViewInventario.PrecioVenta AS PVenta,vs_BtnViewInventario.Stock FROM vs_BtnViewInventario WHERE vs_BtnViewInventario.NombreProducto LIKE'%" + a + "%' AND vs_BtnViewInventario.IdEstado =1 ORDER BY vs_BtnViewInventario.PrecioVenta ASC");

        }

        void ProductosPrecioDesc(string a)
        {
            DgvProductos.DataSource = sql.ConsultaTab("SELECT vs_BtnViewInventario.IdCompra AS ID, vs_BtnViewInventario.NumeroFactura AS NFactura, vs_BtnViewInventario.NombreProducto AS Producto, vs_BtnViewInventario.Marca AS Marca,vs_BtnViewInventario.DescripcionC AS Categoría, vs_BtnViewInventario.Descripcion, vs_BtnViewInventario.DescripcionTipoUM AS UMedida, vs_BtnViewInventario.FechaIngreso AS FechaIngreso,vs_BtnViewInventario.FechaCaducidad AS FechaCaducidad, vs_BtnViewInventario.NombreEmpresa AS Proveedor, vs_BtnViewInventario.PrecioVenta AS PVenta,vs_BtnViewInventario.Stock FROM vs_BtnViewInventario WHERE vs_BtnViewInventario.NombreProducto LIKE'%" + a + "%' AND vs_BtnViewInventario.IdEstado =1 ORDER BY vs_BtnViewInventario.PrecioVenta DESC");

        }


        void ProductosFechaDesc(string a)
        {
            DgvProductos.DataSource = sql.ConsultaTab("SELECT vs_BtnViewInventario.IdCompra AS ID, vs_BtnViewInventario.NumeroFactura AS NFactura, vs_BtnViewInventario.NombreProducto AS Producto, vs_BtnViewInventario.Marca AS Marca,vs_BtnViewInventario.DescripcionC AS Categoría, vs_BtnViewInventario.Descripcion, vs_BtnViewInventario.DescripcionTipoUM AS UMedida, vs_BtnViewInventario.FechaIngreso AS FechaIngreso,vs_BtnViewInventario.FechaCaducidad AS FechaCaducidad, vs_BtnViewInventario.NombreEmpresa AS Proveedor, vs_BtnViewInventario.PrecioVenta AS PVenta,vs_BtnViewInventario.Stock FROM vs_BtnViewInventario WHERE vs_BtnViewInventario.NombreProducto LIKE'%" + a + "%' AND vs_BtnViewInventario.IdEstado =1 ORDER BY vs_BtnViewInventario.FechaCaducidad DESC");

        }


        void ProductosFechaASC(string a)
        {
            DgvProductos.DataSource = sql.ConsultaTab("SELECT vs_BtnViewInventario.IdCompra AS ID, vs_BtnViewInventario.NumeroFactura AS NFactura, vs_BtnViewInventario.NombreProducto AS Producto, vs_BtnViewInventario.Marca AS Marca,vs_BtnViewInventario.DescripcionC AS Categoría, vs_BtnViewInventario.Descripcion, vs_BtnViewInventario.DescripcionTipoUM AS UMedida, vs_BtnViewInventario.FechaIngreso AS FechaIngreso,vs_BtnViewInventario.FechaCaducidad AS FechaCaducidad, vs_BtnViewInventario.NombreEmpresa AS Proveedor, vs_BtnViewInventario.PrecioVenta AS PVenta,vs_BtnViewInventario.Stock FROM vs_BtnViewInventario WHERE vs_BtnViewInventario.NombreProducto LIKE'%" + a + "%' AND vs_BtnViewInventario.IdEstado =1 ORDER BY vs_BtnViewInventario.FechaCaducidad ASC");

        }

        void ProductosCategoria(string a)
        {
            DgvProductos.DataSource = sql.ConsultaTab("SELECT vs_BtnViewInventario.IdCompra AS ID, vs_BtnViewInventario.NumeroFactura AS NFactura, vs_BtnViewInventario.NombreProducto AS Producto, vs_BtnViewInventario.Marca AS Marca,vs_BtnViewInventario.DescripcionC AS Categoría, vs_BtnViewInventario.Descripcion, vs_BtnViewInventario.DescripcionTipoUM AS UMedida, vs_BtnViewInventario.FechaIngreso AS FechaIngreso,vs_BtnViewInventario.FechaCaducidad AS FechaCaducidad, vs_BtnViewInventario.NombreEmpresa AS Proveedor, vs_BtnViewInventario.PrecioVenta AS PVenta,vs_BtnViewInventario.Stock FROM vs_BtnViewInventario WHERE vs_BtnViewInventario.NombreProducto LIKE'%" + a + "%' AND vs_BtnViewInventario.IdEstado =1 ORDER BY vs_BtnViewInventario.DescripcionC");

        }

        //METODO PARA FILTRAR LOS PRODUCTOS
        private void RbtnMarca_CheckedChanged(object sender, EventArgs e)
        {
            ProductosMarca("");
        }


        private void RbtnPrecio_CheckedChanged(object sender, EventArgs e)
        {
            if (RbtnPrecio.Checked == true)
            {
                DialogResult result = MessageBox.Show("Ordenar Precio Ascendente <Si>\nOrdenar Precio Descendete <No>", "Avíso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    ProductosPrecioASC("");
                }
                else if (result == DialogResult.No)
                {
                    ProductosPrecioDesc("");
                }
            }
        }


        private void RbtnFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (RbtnFecha.Checked == true)
            {
                DialogResult result = MessageBox.Show("Ordenar Fecha Ascendente <Si>\nOrdenar Fecha Descendete <No>", "Avíso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    ProductosFechaASC("");
                }
                else if (result == DialogResult.No)
                {
                    ProductosFechaDesc("");
                }
            }
        }

        private void RbtnCategoria_CheckedChanged(object sender, EventArgs e)
        {
            ProductosCategoria("");
        }

        private void DgvCarrito_SelectionChanged(object sender, EventArgs e)
        {
            int a = DgvCarrito.RowCount;
            if(a > 0)
            {
                try
                {
                    DgvCarrito.CurrentCell = DgvCarrito.CurrentRow.Cells["Stock1"];
                    DgvCarrito.BeginEdit(true);

                }
                catch (Exception)
                {
                    DgvCarrito.CurrentCell = DgvCarrito.CurrentRow.Cells["Stock1"];
                    DgvCarrito.BeginEdit(true);

                }
            }
            
            
        }

        void validadStock() //Valida que la cantidad no supere al stock en inventario
        {
            int stock = stock2;
            int canti = canti2;
            if (stock >= canti)
             {

           }
             else
           {
                        MessageBox.Show("La cantidad del producto Introducido anteriormente supera la cantidad en existencia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
               
        }

        //METODO PARA BUSCAR LOS PRODUCTOS
        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (RbtnMarca.Checked == true)
            {
                ProductosMarca(TxtBuscar.Text);
            }
            else if (RbtnPrecio.Checked == true)
            {
                ProductosPrecioASC(TxtBuscar.Text);
                ProductosPrecioDesc(TxtBuscar.Text);
            }
            else if (RbtnFecha.Checked == true)
            {
                ProductosFechaASC(TxtBuscar.Text);
                ProductosFechaDesc(TxtBuscar.Text);
            }
            else if (RbtnCategoria.Checked == true)
            {
                ProductosCategoria(TxtBuscar.Text);
            }
            else
            {
                ProductosG(TxtBuscar.Text);
            }
        }


        //METODO PARA INICIAR FUNCIONES BASICAS TRAS EJECUTAR EL FORMULARIO DE VENTAS
        void IniciarLoad()
        {
            LblUsuario.Text = id;
            DgvProductos.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DgvCarrito.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductosG("");

            DgvProductos.Columns["ID"].Visible = false;
            DgvProductos.Columns["NFactura"].Visible = false;
            DgvProductos.Columns["FechaIngreso"].Visible = false;
            DgvProductos.Columns["Proveedor"].Visible = false;
            DgvCarrito.Columns["SI"].Visible = false;

            foreach (DataGridViewColumn c in DgvCarrito.Columns)
                if (c.Name != "Stock1") c.ReadOnly = true;

            TxtDescuento.Text = "0";
           int a = Convert.ToInt32(sql.ConsultaSimple("SELECT MAX(Ventass.NF) FROM Ventass"));
            a = a + 1;
            TxtNumFactura.Text = Convert.ToString(a);
        }

        private void BtnRetirarDV_Click(object sender, EventArgs e)
        {
            int a = DgvCarrito.RowCount;

            
                if (DgvCarrito.Rows.Count == 0)
                {
                    TxtSubTotal.Text = Convert.ToString(0);
                    TxtDescuento.Text = Convert.ToString(0);
                    TxtTotal.Text = Convert.ToString(0);
                }
                else
                    
            {
                foreach (DataGridViewRow row in DgvCarrito.SelectedRows)
                {
                    if (DgvCarrito.CurrentRow.Cells["Stock1"].Value == null || String.IsNullOrEmpty(DgvCarrito.CurrentRow.Cells["Stock1"].Value.ToString()))
                    {
                        

                    }
                    else
                    {
                        int m = DgvCarrito.RowCount;
                        if (m > 0)
                        {
                            string cantidad = Convert.ToString(DgvCarrito.CurrentRow.Cells[5].Value).Trim();
                            string precio = DgvCarrito.Rows[DgvCarrito.CurrentRow.Index].Cells[4].Value.ToString();
                            // MessageBox.Show(cantidad);

                            double cant = Convert.ToDouble(cantidad);
                            double pre = Convert.ToDouble(precio);

                            double resta = (pre * cant);

                            string sub = TxtSubTotal.Text;
                            string desc = TxtDescuento.Text;
                            try
                            {
                                double descuento = Convert.ToDouble(desc);
                                descuento = (Convert.ToDouble(sub) - descuento) - resta;
                                double tv = descuento;
                                TxtSubTotal.Text = Convert.ToString(tv);
                                TxtTotal.Text = Convert.ToString(tv);

                                DgvCarrito.Rows.RemoveAt(DgvCarrito.CurrentRow.Index);
                            }
                            catch (Exception)
                            {

                                //
                            }
                            
                        }
                        else if(m==0)
                        {
                            string cantidad = Convert.ToString(DgvCarrito.CurrentRow.Cells[5].Value).Trim();
                            string precio = DgvCarrito.Rows[DgvCarrito.CurrentRow.Index].Cells[4].Value.ToString();
                            // MessageBox.Show(cantidad);

                            double cant = Convert.ToDouble(cantidad);
                            double pre = Convert.ToDouble(precio);

                            double resta = (pre * cant);

                            string sub = TxtSubTotal.Text;
                            string desc = TxtDescuento.Text;
                            double descuento = Convert.ToDouble(desc);
                            descuento = (Convert.ToDouble(sub) - descuento) - resta;
                            double tv = descuento;
                            TxtSubTotal.Text = Convert.ToString(0);
                            TxtTotal.Text = Convert.ToString(0);

                            DgvCarrito.Rows.RemoveAt(DgvCarrito.CurrentRow.Index);
                        }
                       
                    }

                }
            
        }

        }
        void ventascontado()
        {
            string nom = Convert.ToString(TxtNombreFull.Text.Trim());
            string ape = Convert.ToString(TxtApellido.Text.Trim());
            double descu = 0;
            string aux = TxtDescuento.Text.Trim();
            if (aux == "")
            {
                descu = 0;
            }
            else
            {
                descu = Convert.ToDouble(TxtDescuento.Text.Trim());
            }
            
            

            double subto = Convert.ToDouble(TxtSubTotal.Text);

            double total = Convert.ToDouble(TxtTotal.Text.Trim());
            int idusuario = Convert.ToInt32(id);

            res = vtc.AddVenta(nom, ape, descu, subto, total, idusuario);
           // MessageBox.Show(" " + res);
            
        }
        void AgregarVentaProducto()
        {
           idVenta = Convert.ToInt32(sql.ConsultaSimple("SELECT MAX(Ventas.IdFacturaVenta) FROM Ventas"));
           // MessageBox.Show(Convert.ToString(idVenta));
            
            int idprodmax = DgvCarrito.Rows.Count;
            int can = DgvCarrito.Rows.Count;
            //MessageBox.Show(" " + Nomp);
            
            idnombresProd = new int[idprodmax];
            cantidad = new double [idprodmax];
            cantidadInv = new double[idprodmax];
            for (int i = 0; i < idprodmax; i++)
            {
                idnombresProd[i] = Convert.ToInt32(DgvCarrito.Rows[i].Cells[0].Value);
                cantidad[i] = Convert.ToDouble(DgvCarrito.Rows[i].Cells[5].Value);
                cantidadInv[i] = Convert.ToDouble(DgvCarrito.Rows[i].Cells[6].Value);
              
                //string res =  vtc.AddVentasProd(Convert.ToInt32(idVenta), idnombresProd[i], cantidad[Convert.ToInt32(i)]);
                //string res2 = vtc.RestInventario(idnombresProd[i], cantidadInv[Convert.ToInt32(i)], cantidad[Convert.ToInt32(i)]);
 
                //MessageBox.Show("res -"+res);
                //MessageBox.Show("res2 -"+res2);
            }

            int z = DgvCarrito.RowCount;


            if (z > 0)
            {
                MessageBox.Show("La venta se realizó con éxito. :)");
            }
                

            
        }

        private bool ValidarVacio()//METODO PARA VALIDAR CAMPOS VACIOS EN EL DATAGRID
        {
            bool bCampoVacio = false;
            if (DgvCarrito.RowCount > 0)
            {

                foreach (DataGridViewRow dr in DgvCarrito.Rows)
                {
                    foreach (DataGridViewCell dc in dr.Cells)
                    {
                        if (dc.Value == null || string.IsNullOrEmpty(dc.Value.ToString()))
                        {
                            bCampoVacio = true;
                        }
                    }
                }
                return bCampoVacio;
            }

            return bCampoVacio;
        }

        //private bool ValidarCifrasMayores()
        //{
        //    bool bCampoVacio = false;
        //    if (DgvCarrito.RowCount > 0)
        //    {

        //        foreach (DataGridViewRow dr in DgvCarrito.Rows)
        //        {
        //            foreach (DataGridViewCell dc in dr.Cells)
        //            {
        //                if (dc.Value == null || string.IsNullOrEmpty(dc.Value.ToString()))
        //                {
        //                    bCampoVacio = true;
        //                }
        //            }
        //        }
        //        return bCampoVacio;
        //    }

        //    return bCampoVacio;
        //}
        void CrearFacturaPdf()
        {
            Document doc = new Document();
            var fecha = DateTime.Now.ToString("dd-MM-yyyy");
            var hora = DateTime.Now.ToString("HH:mm:ss");
            PdfWriter.GetInstance(doc, new FileStream(@"C:\Reportes\" + TxtNombreFull.Text + " " + TxtApellido.Text + " " + TxtNumFactura.Text + ".pdf", FileMode.Create));
            doc.Open();

            Paragraph title1 = new Paragraph();
            Paragraph title = new Paragraph();
            title1.Font = FontFactory.GetFont(FontFactory.TIMES, 20f, BaseColor.BLACK);
            title1.Add("                            Agroservicio Jossemar");
            doc.Add(title1);
            doc.Add(new Paragraph("          De la Farmacia del Dr. Erik Velásquez, San Juan de Rio Coco, Madrizz"));
            doc.Add(new Paragraph("                                                  32325106200000A"));
            doc.Add(new Paragraph("                                               8255-0276 * 7631-0502"));
            doc.Add(new Paragraph(" "));
            title.Font = FontFactory.GetFont(FontFactory.TIMES, 16f, BaseColor.BLACK);
            title.Add("----------------------------DETALLE FACTURA---------------------------");
            doc.Add(title);
            doc.Add(new Paragraph("Cliente: " + TxtNombreFull.Text + " " + TxtApellido.Text));
            doc.Add(new Paragraph("Fecha: " + fecha));
            doc.Add(new Paragraph("Hora: " + hora));
            doc.Add(new Paragraph("N° Factura: " + TxtNumFactura.Text));
            doc.Add(new Paragraph("---------------------------------------------------------------------------------------------------------------"));
            doc.Add(new Paragraph("|   PRODUCTO   |                                           |   CANT   |   PRECIO   |   IMPORTE   |"));
            doc.Add(new Paragraph("---------------------------------------------------------------------------------------------------------------"));

            int nombre = DgvCarrito.Rows.Count;

            nombreprod = new string[nombre];
            cantidadprod = new double[nombre];
            precioprod = new double[nombre];
            double importe;

            for (int i = 0; i < nombre; i++)
            {

                nombreprod[i] = Convert.ToString(DgvCarrito.Rows[i].Cells[1].Value);
                cantidadprod[i] = Convert.ToDouble(DgvCarrito.Rows[i].Cells[5].Value);

                precioprod[i] = Convert.ToDouble(DgvCarrito.Rows[i].Cells[4].Value);

                importe = (Convert.ToDouble(cantidadprod[i] * precioprod[i]));

                if (nombreprod[i].Length < 30)
                {
                    for (int a = 0; a < 30; i++)
                    {
                        nombreprod[i] = nombreprod[i] + " ";
                    }
                }
                doc.Add(new Paragraph(nombreprod[i] + "                              " + cantidadprod[i] + "          " + precioprod[i] + "              " + importe));

            }
            doc.Add(new Paragraph("---------------------------------------------------------------------------------------------------------------"));
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph("Subtotal..........C$" + TxtSubTotal.Text));
            doc.Add(new Paragraph("Descuento......C$" + TxtDescuento.Text));
            doc.Add(new Paragraph("Total...............C$" + TxtTotal.Text));
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph("---------------------------------------------------------------------------------------------------------------"));
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph("                                     GRACIAS POR FREPERIRNOS"));
            doc.Close();
        }
        //METODO DELETE
        void Delete()
        {
            TxtNombreFull.Text = "";
            TxtApellido.Text = "";
            TxtDescuento.Text = "0";
            TxtSubTotal.Text = "0";
            TxtTotal.Text = "0";
            DgvCarrito.Rows.Clear();
        }
        //METODO DE CAJA PARA VENTAS
        private void Movimiento()
        {
            CLogicaMovimientos lg = new CLogicaMovimientos();
            string note = sql.ConsultaSimple("SELECT MAX(Ventass.IdFacturaVenta)FROM Ventass");
            lg.MovimientoVenta(note, TxtTotal.Text.Trim());
            lg.SaldoD(TxtTotal.Text.Trim(), 2);
        }
        private void BtnAgregarDV_Click(object sender, EventArgs e)
        {

            if (TxtNombreFull.Text.Trim() == "" || TxtApellido.Text.Trim() == "")
            {
                MessageBox.Show("Error, uno de los datos del cliente está vacío", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (ValidarVacio() == false)
                {
                    Movimiento();
                    ventascontado();
                    AgregarVentaProducto();
                    CrearFacturaPdf();
                    Delete();
                    TxtSubTotal.Text = "0";
                    TxtDescuento.Text = "0";
                    TxtTotal.Text = "0";
                    ProductosG("");
                }

            }
        }

        private void DgvCarrito_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
           

        }

        private void BtnLimpiarDV_Click(object sender, EventArgs e)
        {
            TxtNombreFull.Text = "";
            TxtApellido.Text = "";
            TxtSubTotal.Text = "0";
            TxtTotal.Text = "0";
            
            DgvCarrito.Rows.Clear();
        }

        private void TxtDescuento_TextChanged(object sender, EventArgs e)
        {
            int a = DgvCarrito.RowCount;
            if (a > 0)
            {
                try
                {
                    string sub = TxtSubTotal.Text;
                    string desc = TxtDescuento.Text;
                    double descuento = Convert.ToDouble(desc);
                    if (descuento > Convert.ToDouble(sub))
                    {
                        MessageBox.Show("El descuento supera los limites", "Avíso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtDescuento.Text = "0";
                    }
                    else
                    {
                        descuento = (Convert.ToDouble(sub) - descuento);
                        double tv = descuento;
                        TxtTotal.Text = Convert.ToString(tv);
                    }
                    
                }
                catch (Exception)
                {

                    
                }
                
            }
            
        }

        private void TxtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumerosPuntosyComas(e);
        }

        private void TxtNombreFull_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private void DgvCarrito_Validating(object sender, CancelEventArgs e)
        {
            if(ValidarVacio() == true)
            {
                //MessageBox.Show("a");


            }
        }

        private void DgvCarrito_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if(UnidadMedida.Trim() == "Unidad" || UnidadMedida.Trim() == "Galon" || UnidadMedida.Trim() == "Quintales" || UnidadMedida.Trim() == "Sobres")
            {
                if (Char.IsNumber(e.KeyChar) || e.KeyChar == (Char)Keys.Back)
                    e.Handled = false;
                else
                    e.Handled = true;
            }
            else if (UnidadMedida.Trim() == "Litros" || UnidadMedida.Trim() == "Cuarto" || UnidadMedida.Trim() == "Medio" || UnidadMedida.Trim() == "Libras" || UnidadMedida.Trim() == "Kilo" || UnidadMedida.Trim() == "Medio Kilo")
            {
                Validaciones.SoloNumerosPuntosyComas(e);
            }
            

        }

        private void DgvCarrito_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //TENGO QUE BORRAR ESTO

        }
        //METODO PARA VALIDAR SI LA CANTIDAD ES MAYOR A STOCK
        void ValidarCantStock()
        {
            if (ValidarVacio() == false)
            {
                int a = DgvCarrito.RowCount;
                for (int i = 0; i < a; i++)
                {
                    string cantidad = Convert.ToString(DgvCarrito.CurrentRow.Cells[5].Value).Trim();
                    string stock = DgvCarrito.Rows[DgvCarrito.CurrentRow.Index].Cells[6].Value.ToString();
                    // MessageBox.Show(cantidad);

                    double cant = Convert.ToDouble(cantidad);
                    double preS = Convert.ToDouble(stock);

                    if (cant > preS)
                    {
                        DgvCarrito.Rows.RemoveAt(DgvCarrito.CurrentRow.Index);
                        double val2 = 0;
                        double val3 = 0;
                        try
                        {
                            string cantidad2 = DgvCarrito.Rows[i].Cells[5].Value.ToString();
                            string precio = DgvCarrito.Rows[i].Cells[4].Value.ToString();
                            int cant2 = Convert.ToInt32(cantidad2);
                            double pre = Convert.ToDouble(precio);
                            double des = Convert.ToDouble(TxtDescuento.Text.Trim());

                            double val1 = cant2 * pre;
                            val2 = val1 + val2;

                            if (TxtDescuento.Text == "")
                                des = 0;

                            val3 = ((cant2 * pre)-des);

                            TxtSubTotal.Text = Convert.ToString(val2);
                            TxtTotal.Text = Convert.ToString(val3);
                        }
                        catch (Exception)
                        {


                        }

                        int c = DgvCarrito.RowCount;
                        if (c == 0)
                        {
                            TxtSubTotal.Text = "";
                            TxtTotal.Text = "";
                            TxtDescuento.Text = "0";
                        }
                    }
                    else
                    {
                            if (ValidarVacio() == false)
                            {
                                CalcSubtotal();
                                BtnRetirarDV.Enabled = true;
                                BtnAgregarDV.Enabled = true;
                            } 
                    }


                }
            }
        }
        private void DgvCarrito_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(fechav != "0000-00-00")
            {

                if(DgvCarrito.CurrentRow.Cells[5].Value.ToString() == "0")
                {
                    MessageBox.Show("No se debe de agregar cantidades 0");
                    DgvCarrito.CurrentRow.Cells[5].Value = "";
                }
                var fechaAct = zzz.ObtenerFechaSinHora();
                TimeSpan fc = Convert.ToDateTime(fechav) - Convert.ToDateTime(fechaAct);

                int dias = fc.Days;
               
                if (dias < 0)
                {
                    DialogResult result = MessageBox.Show("El producto que está agregando se encuentra en estado <<Caducado>> ¿Está seguro de añadirlo al carrito?", "Avíso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (result == DialogResult.OK)
                    {

                        ValidarCantStock();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        try
                        {
                            DgvCarrito.Rows.RemoveAt(DgvCarrito.CurrentRow.Index);
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Ha ocurrido un error, pero sus cambios se efectuaron correctamente. x.x", "Avíso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                       
                    }
                }
                else if (dias == 30)
                {
                    MessageBox.Show("El lote de este producto caduca en un mes.", "Avíso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ValidarCantStock();
                }
                else if (dias<30 && dias >=0)
                {
                    MessageBox.Show("El lote de este producto caduca en <"+dias+"> días.", "Avíso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ValidarCantStock();
                }
                else if (dias >= 30)
                {
                    ValidarCantStock();
                }
                // MessageBox.Show("fecha"+fechav);

            }
            else if(fechav == "0000-00-00")
            {
                ValidarCantStock();
            }

        }

        private void LblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void LblNombreFull_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TxtNombreFull_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void DtpFechaFact_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtNumFactura_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblNumFactura_Click(object sender, EventArgs e)
        {

        }

        private void DgvUnidadM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2GroupBox4_Click(object sender, EventArgs e)
        {

        }

        private void DgvCarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LblTotal_Click(object sender, EventArgs e)
        {

        }

        private void TxtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtSubTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

        private void DgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void PnlBarraSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void DgvCarrito_EditingControlShowing_1(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (DgvCarrito.CurrentCell.ColumnIndex == 5)
            {

                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(DgvCarrito_KeyPress_1);
                    
                }
            }
              
        }




        private void FormVentas_Load(object sender, EventArgs e)
        {
            IniciarLoad();
            DgvUnidadM.DataSource = cmb99.MostrarUnidadMDgv();
        }

       // MÉTODO PARA QUE SUME SUBTOTAL
        void CalcSubtotal()
        {
            int DgvConteo = DgvCarrito.RowCount;
            if (DgvConteo > 0)
            {
                if (DgvCarrito.CurrentRow.Cells["Stock1"].Value == null || String.IsNullOrEmpty(DgvCarrito.CurrentRow.Cells["Stock1"].Value.ToString()))
                {
                    MessageBox.Show("Ingrese la cantidad de productos", "Error,Cantidad vacia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    double val2 = 0;
                    for (int i = 0; i < DgvCarrito.RowCount; i++)
                    {
                        try
                        {
                            string cantidad = DgvCarrito.Rows[i].Cells[5].Value.ToString();
                            string precio = DgvCarrito.Rows[i].Cells[4].Value.ToString();
                            double cant = Convert.ToDouble(cantidad);
                            double pre = Convert.ToDouble(precio);

                            double val1 = cant * pre;
                            val2 = val1 + val2;

                            TxtSubTotal.Text = Convert.ToString(val2);
                        }
                        catch (Exception)
                        {


                        }

                    }
                    string sub = TxtSubTotal.Text;
                    string desc = TxtDescuento.Text;
                    if (desc == "")
                        desc = "0";
                    double descuento = Convert.ToDouble(desc);
                    try
                    {
                        descuento = (Convert.ToDouble(sub) - descuento);
                    }
                    catch (Exception)
                    {
                     //Tratar de poner algo así
                                                            
                    }
                    
                    double tv = descuento;
                    TxtTotal.Text = Convert.ToString(tv);
                }
            }
        }



        //METODO PARA CAPTURAR LOS DATOS DEL CARRITO
        void CapturarDtCarrito()
        {
            
            int filas = DgvCarrito.Rows.Count;


            // Verificar si ya esta agegado
            Boolean esta = false;
            if (filas != 0)
            {
                for (int i = 0; i < filas; i++)
                {
                    if (Convert.ToInt32(DgvProductos.CurrentRow.Cells[0].Value) == Convert.ToInt32(DgvCarrito.Rows[i].Cells[0].Value))
                    {
                        esta = true;

                        break;

                    }
                }

            }

            if (esta)
            {
                MessageBox.Show("El Paquete ya está en la orden");
            }
            else
            {
                //int filas = 0 + contador;
                //contador++;

                int a = DgvCarrito.RowCount;

                if (a > 0)
                {
                    validadStock();
                }

                try
                {
                    DgvCarrito.Rows.Add();
                    DgvCarrito.Rows[filas].Cells[0].Value = DgvProductos.CurrentRow.Cells[0].Value;
                    DgvCarrito.Rows[filas].Cells[1].Value = DgvProductos.CurrentRow.Cells[2].Value;
                    DgvCarrito.Rows[filas].Cells[2].Value = DgvProductos.CurrentRow.Cells[5].Value;
                    DgvCarrito.Rows[filas].Cells[3].Value = DgvProductos.CurrentRow.Cells[3].Value;
                    DgvCarrito.Rows[filas].Cells[4].Value = DgvProductos.CurrentRow.Cells[10].Value;
                    DgvCarrito.Rows[filas].Cells[6].Value = DgvProductos.CurrentRow.Cells[11].Value;
                    DgvCarrito.Rows[filas].Cells[7].Value = DgvProductos.CurrentRow.Cells[6].Value;
                }
                catch (Exception)
                {
                    //DgvCarrito.Rows.Add();
                    //DgvCarrito.Rows[filas].Cells[0].Value = DgvProductos.CurrentRow.Cells[0].Value;
                    //DgvCarrito.Rows[filas].Cells[1].Value = DgvProductos.CurrentRow.Cells[2].Value;
                    //DgvCarrito.Rows[filas].Cells[2].Value = DgvProductos.CurrentRow.Cells[5].Value;
                    //DgvCarrito.Rows[filas].Cells[3].Value = DgvProductos.CurrentRow.Cells[3].Value;
                    //DgvCarrito.Rows[filas].Cells[4].Value = DgvProductos.CurrentRow.Cells[10].Value;
                    //DgvCarrito.Rows[filas].Cells[6].Value = DgvProductos.CurrentRow.Cells[11].Value;

                }
                


            }
        }
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtNombreFull.Text.Trim() == "" || TxtApellido.Text.Trim() == "")
            {
                MessageBox.Show("Error, uno de los datos del cliente está vacío", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (ValidarVacio() == false)
                {
                    CalcSubtotal();
                    BtnRetirarDV.Enabled = true;
                    BtnAgregarDV.Enabled = true;
                }

            }
           
        }

        //METODO PARA PASAR LOS PRODUCTOS AL CARRITO
        private void DgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = 0;
            //Validaciones.SoloNumeros(DgvCarrito.Rows[e.RowIndex].Cells[10].Value);
            int a = DgvCarrito.RowCount;
            if (a > 0)
            {
                    stock2 = Convert.ToInt32(DgvCarrito.CurrentRow.Cells[6].Value);
                    //MessageBox.Show("stock = " + stock2);
                    canti2 = Convert.ToInt32(DgvCarrito.CurrentRow.Cells[5].Value);
                    if (canti2 > stock2)
                    {
                        MessageBox.Show("Lo sentimos la cantidad estableciida del producto supera la que hay en existencia.", "Avíso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    int m = DgvCarrito.RowCount;
                       if (m > 0)
                        {
                        string cantidad = Convert.ToString(DgvCarrito.CurrentRow.Cells[5].Value).Trim();
                        string precio = DgvCarrito.Rows[DgvCarrito.CurrentRow.Index].Cells[4].Value.ToString();
                        // MessageBox.Show(cantidad);

                        double cant = Convert.ToDouble(cantidad);
                        double pre = Convert.ToDouble(precio);

                        double resta = (pre * cant);

                        string sub = TxtSubTotal.Text;
                        string desc = TxtDescuento.Text;

                        if (sub == "")
                            sub = "0";
                       
                        double descuento = Convert.ToDouble(desc);
                        descuento = (Convert.ToDouble(sub) - descuento) - resta;
                        double tv = descuento;
                        TxtSubTotal.Text = Convert.ToString(tv);
                        TxtTotal.Text = Convert.ToString(tv);

                        DgvCarrito.Rows.RemoveAt(DgvCarrito.CurrentRow.Index);
                        }
                    else if (m == 0)
                    {
                        string cantidad = Convert.ToString(DgvCarrito.CurrentRow.Cells[5].Value).Trim();
                        string precio = DgvCarrito.Rows[DgvCarrito.CurrentRow.Index].Cells[4].Value.ToString();
                        // MessageBox.Show(cantidad);

                        double cant = Convert.ToDouble(cantidad);
                        double pre = Convert.ToDouble(precio);

                        double resta = (pre * cant);

                        string sub = TxtSubTotal.Text;
                        if (sub == "")
                            sub = "0";
                        string desc = TxtDescuento.Text;
                        double descuento = Convert.ToDouble(desc);
                        descuento = (Convert.ToDouble(sub) - descuento) - resta;
                        double tv = descuento;
                        TxtSubTotal.Text = Convert.ToString(0);
                        TxtTotal.Text = Convert.ToString(0);

                        DgvCarrito.Rows.RemoveAt(DgvCarrito.CurrentRow.Index);
                    }
                  //  DgvCarrito.Rows.RemoveAt(DgvCarrito.CurrentRow.Index);

                    }
                else
                {
                    CapturarDtCarrito();
                    fechav = Convert.ToString(DgvProductos.CurrentRow.Cells[8].Value).Trim();
                    UnidadMedida = Convert.ToString(DgvProductos.CurrentRow.Cells[6].Value).Trim();
                    // MessageBox.Show(fechav);
                }
                

            }
            else if (a == 0)
            {
                CapturarDtCarrito();
                fechav = Convert.ToString(DgvProductos.CurrentRow.Cells[8].Value).Trim();
                UnidadMedida = Convert.ToString(DgvProductos.CurrentRow.Cells[6].Value).Trim();
                //MessageBox.Show(fechav);
            }
            

            contaTactico++;
            
        }

        
    }
}
