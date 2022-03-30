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
    public partial class FrmAgregarCV : Form
    {
        public FrmAgregarCV(string a)
        {
            InitializeComponent();
            user = a;
        }

        //VARIABLES DECLARADAS DE FORMA GLOBAL
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

        CLogicaConsultas sql = new CLogicaConsultas();
        CLogicaVentasCredito vc = new CLogicaVentasCredito();
        CLogicaVentas vtc = new CLogicaVentas();
        CLogicaObtenerFecha zzz = new CLogicaObtenerFecha();

        string user = "";
        string IdCliente = "", res = "";
        void MostrarClientes(string a)
        {
            DgvClientesC.DataSource = sql.ConsultaTab("SELECT vs_ClientesCredito.IdClientesCredito as Cliente, vs_ClientesCredito.NombreCli as Nombre, vs_ClientesCredito.ApellidoCli as Apellido, vs_ClientesCredito.Cedula as Cedula, vs_ClientesCredito.DescripcionTel as Telefono, vs_ClientesCredito.DescripcionDir as Dirección FROM vs_ClientesCredito WHERE vs_ClientesCredito.IdEstadoCliente = '1' AND vs_ClientesCredito.IdEstadoCredito = '2' AND vs_ClientesCredito.NombreCli LIKE'%" + a + "%'");
        }
        //METODOS PARA LLENAR DATAGRID Y FILTRAR LAS BUSQUEDAS
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

        //METODO PARA DARLE FORMATO A LA FECHA
        void ActivarFormarDate()
        {

            DtpFechaCancelar.MaxDate = DateTime.Today.AddDays(15);
            DtpFechaCancelar.MinDate = DateTime.Now.AddDays(0);

           
        }

        //METODO PARA INICIAR LOAD
        void IniciarLoad()
        {
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

            TxtAbono.Text = "0";
            TxtInteresPorcentual.Text = "0";

            MostrarClientes("");
            LblUsuario.Text = user;
            string Nf = sql.ConsultaSimple("SELECT MAX(dbo.Ventass.NF) FROM Ventass");
            int Nf2 = Convert.ToInt32(Nf);
            Nf2 = Nf2 + 1;
            TxtNumFactura.Text = Convert.ToString(Nf2);

            ActivarFormarDate();
        }

        private void FrmAgregarCV_Load(object sender, EventArgs e)
        {
            DgvClientesC.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvClientesC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            DgvProductos.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            IniciarLoad();
           
        }

        void Delete()
        {
            TxtNombreCliente.Text = "";
            TxtApellidoCliente.Text = "";
            TxtCedulaCliente.Text = "";
            TxtTelefonoCliente.Text = "";
            txtDireccionCliente.Text = "";
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void DgvClientesC_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IdCliente = Convert.ToString(DgvClientesC.CurrentRow.Cells[0].Value).Trim();
            TxtNombreCliente.Text = Convert.ToString(DgvClientesC.CurrentRow.Cells[1].Value).Trim();
            TxtApellidoCliente.Text = Convert.ToString(DgvClientesC.CurrentRow.Cells[2].Value).Trim();
            TxtCedulaCliente.Text = Convert.ToString(DgvClientesC.CurrentRow.Cells[3].Value).Trim();
            TxtTelefonoCliente.Text = Convert.ToString(DgvClientesC.CurrentRow.Cells[4].Value).Trim();
            txtDireccionCliente.Text = Convert.ToString(DgvClientesC.CurrentRow.Cells[5].Value).Trim();

            //MessageBox.Show("IdCliente = " + IdCliente);
        }

        //METODO QUE NO SÉ SI SIRVA
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


        //METODO PARA CAPTURAR DATOS DEL DATAGRIDVIEW
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

                }

            }
        }

        //EVENTOS PARA FILTRAR LOS PRODUCTOS

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
            if (a > 0)
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

        //METODO PARA BUSCAR LOS PRODUCTOS SEGUN EL FILTRO SELECCIONADO
        private void TxtBuscarProd_TextChanged(object sender, EventArgs e)
        {
            if (RbtnMarca.Checked == true)
            {
                ProductosMarca(TxtBuscarProd.Text);
            }
            else if (RbtnPrecio.Checked == true)
            {
                ProductosPrecioASC(TxtBuscarProd.Text);
                ProductosPrecioDesc(TxtBuscarProd.Text);
            }
            else if (RbtnFecha.Checked == true)
            {
                ProductosFechaASC(TxtBuscarProd.Text);
                ProductosFechaDesc(TxtBuscarProd.Text);
            }
            else if (RbtnCategoria.Checked == true)
            {
                ProductosCategoria(TxtBuscarProd.Text);
            }
            else
            {
                ProductosG(TxtBuscarProd.Text);
            }
        }

        //METODO PARA RETIRAR PRODUCTOS
        private void BtnRetirarDV_Click(object sender, EventArgs e)
        {
            int a = DgvCarrito.RowCount;


            if (DgvCarrito.Rows.Count == 0)
            {
                TxtSubTotal.Text = Convert.ToString(0);
                TxtAbono.Text = Convert.ToString(0);
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
                            string desc = TxtAbono.Text;
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
                        else if (m == 0)
                        {
                            string cantidad = Convert.ToString(DgvCarrito.CurrentRow.Cells[5].Value).Trim();
                            string precio = DgvCarrito.Rows[DgvCarrito.CurrentRow.Index].Cells[4].Value.ToString();
                            // MessageBox.Show(cantidad);

                            double cant = Convert.ToDouble(cantidad);
                            double pre = Convert.ToDouble(precio);

                            double resta = (pre * cant);

                            string sub = TxtSubTotal.Text;
                            string desc = TxtAbono.Text;
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


        //EVENTO PARA MANDAR DATOS DEL DATA PRODUCTOS AL CARRITO
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
                        string desc = TxtAbono.Text;

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
                        string desc = TxtAbono.Text;
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

        //METODO PARA VALIDAR QUE LOS TEXBOX NO ESTEN VACÍOS
        int Validartxt()
        {
            int conteo = 0;
            if (TxtNombreCliente.Text != "" && TxtApellidoCliente.Text !="" && TxtCedulaCliente.Text !=""
                && TxtTelefonoCliente.Text != "" && txtDireccionCliente.Text != "" && TxtSubTotal.Text != "" && 
                TxtTotal.Text !="")
                conteo++;
            else
                conteo--;

            return conteo;
        }


        //METODO PARA CAPTURAR DATOS PARA LA VENTA GENERAL
        void ventascontado()
        {
            //string nom = Convert.ToString(TxtNombreFull.Text.Trim());
            //string ape = Convert.ToString(TxtApellido.Text.Trim());
            double descu = 0;
            string aux = TxtAbono.Text.Trim();
            if (aux == "")
            {
                descu = 0;
            }
            else
            {
                descu = Convert.ToDouble(TxtAbono.Text.Trim());
            }



            double subto = Convert.ToDouble(TxtSubTotal.Text);

            double total = Convert.ToDouble(TxtTotal.Text.Trim());
            int idusuario = Convert.ToInt32(user);

            res = vc.AddVenta(idusuario, descu, subto, total, idusuario);
            //MessageBox.Show(" " + res);

        }

        
        //METODO PARA CAPTURAR LOS DATOS DE VENTAS CREDITO
        void CapturarVentasCredito()
        {
            double interesPor = 0;
            double DeudaTotal = 0;
            string idfacturaV = sql.ConsultaSimple("SELECT MAX(dbo.Ventass.IdFacturaVenta) FROM Ventass");
            int IdFacturasV = Convert.ToInt32(idfacturaV);
            string fecha = DtpFechaCancelar.Value.ToString("yyy/MM/dd");
            double abono = 0;

            if (TxtAbono.Text != "")
            {
                abono = Convert.ToDouble(TxtAbono.Text.Trim());
            }
            else
            {
                abono = 0;
            }
            
            DeudaTotal = Convert.ToDouble(TxtTotal.Text);


            if (TxtInteresPorcentual.Text == "")
                interesPor = 0;
            else
                interesPor = Convert.ToDouble(TxtInteresPorcentual.Text.Trim());

            //DeudaTotal = (DeudaTotal - 

          string res2 =  vc.AgregarVentasCredito(IdFacturasV,interesPor, DeudaTotal,fecha,abono);
            //MessageBox.Show("Venta credito = "+res2);
        }

        //METODO PARA CAPTURAR LOS PRODUCTOS QUE FUERON SELECCIONADOS
        void AgregarVentaProducto()
        {
            idVenta = Convert.ToInt32(sql.ConsultaSimple("SELECT MAX(dbo.VentasCredito.IdVentasCredito) FROM VentasCredito"));
             //MessageBox.Show(Convert.ToString(idVenta));

            int idprodmax = DgvCarrito.Rows.Count;
            int can = DgvCarrito.Rows.Count;
            //MessageBox.Show(" " + Nomp);

            idnombresProd = new int[idprodmax];
            cantidad = new double[idprodmax];
            cantidadInv = new double[idprodmax];
            for (int i = 0; i < idprodmax; i++)
            {
                idnombresProd[i] = Convert.ToInt32(DgvCarrito.Rows[i].Cells[0].Value);
                cantidad[i] = Convert.ToDouble(DgvCarrito.Rows[i].Cells[5].Value);
                cantidadInv[i] = Convert.ToDouble(DgvCarrito.Rows[i].Cells[6].Value);
                int id = 0;
                string res = vc.AgregarVentasCreditoProd(Convert.ToInt32(idVenta), idnombresProd[i], cantidad[Convert.ToInt32(i)]);
                string res2 = vtc.RestInventario(id,idnombresProd[i], cantidadInv[Convert.ToInt32(i)], cantidad[Convert.ToInt32(i)]);


               // MessageBox.Show("resProd -"+res);
                //MessageBox.Show("resProd2 -"+res2);
            }

            int z = DgvCarrito.RowCount;


            if (z > 0)
            {
                MessageBox.Show("La venta se realizó con éxito. :)","Avíso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

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
                    string desc = TxtAbono.Text;
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
                            double des = Convert.ToDouble(TxtAbono.Text.Trim());

                            double val1 = cant2 * pre;
                            val2 = val1 + val2;

                            if (TxtAbono.Text == "")
                                des = 0;

                            val3 = ((cant2 * pre) - des);

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
                            TxtAbono.Text = "0";
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
            if (fechav != "0000-00-00")
            {
                if (DgvCarrito.CurrentRow.Cells[5].Value.ToString() == "0")
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
                else if (dias < 30 && dias >= 0)
                {
                    MessageBox.Show("El lote de este producto caduca en <" + dias + "> días.", "Avíso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ValidarCantStock();
                }
                else if (dias >= 30)
                {
                    ValidarCantStock();
                }
                // MessageBox.Show("fecha"+fechav);

            }
            else if (fechav == "0000-00-00")
            {
                ValidarCantStock();
            }
        }

        //METODO PARA RESTAR EL ABONO DE LA DEUDA TOTAL
        private void TxtAbono_TextChanged(object sender, EventArgs e)
        {
            int a = DgvCarrito.RowCount;
            if (a > 0)
            {
                try
                {
                    string sub = TxtSubTotal.Text.Trim();
                    string desc = TxtAbono.Text.Trim();
                    double descuento = Convert.ToDouble(desc);
                    if (descuento > Convert.ToDouble(sub))
                    {
                        MessageBox.Show("El Abono supera los limites", "Avíso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtAbono.Text = "0";
                    }
                    else
                    {
                        if(TxtInteresPorcentual.Text.Trim() == "")
                        {
                            descuento = (Convert.ToDouble(sub) - descuento);
                            double tv = descuento;
                            TxtTotal.Text = Convert.ToString(tv);
                        }
                        else if (TxtInteresPorcentual.Text.Trim() != "")
                        {
                            double interes = Convert.ToDouble(TxtInteresPorcentual.Text.Trim());
                            interes = (interes / 100);
                            double aux3 = (Convert.ToDouble(sub) * interes);

                            descuento = ((Convert.ToDouble(sub) - descuento)+aux3);
                            double tv = descuento;
                            TxtTotal.Text = Convert.ToString(tv);
                        }
                        
                    }

                }
                catch (Exception)
                {


                }

            }
        }

        private void TxtInteresPorcentual_TextChanged(object sender, EventArgs e)
        {
            int a = DgvCarrito.RowCount;
            if (a > 0)
            {
                try
                {
                    string sub = TxtSubTotal.Text.Trim();
                    string desc = TxtInteresPorcentual.Text.Trim();
                    double descuento = Convert.ToDouble(desc);
                    if (descuento > 100)
                    {
                        MessageBox.Show("El Ínteres supera los limites", "Avíso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtInteresPorcentual.Text = "0";
                    }
                    else
                    {
                        if(TxtAbono.Text == "")
                        {
                            descuento = (descuento / 100);
                            double aux = (Convert.ToDouble(sub) * descuento);
                            descuento = (Convert.ToDouble(sub) + Convert.ToDouble(aux));
                            double tv = descuento;
                            TxtTotal.Text = Convert.ToString(tv);
                        }
                        else if(TxtAbono.Text != "")
                        {
                            double abono = Convert.ToDouble(TxtAbono.Text.Trim());

                            descuento = (descuento / 100);
                            double aux = (Convert.ToDouble(sub) * descuento);
                            descuento = (((Convert.ToDouble(sub) + Convert.ToDouble(aux)))-abono);
                            double tv = descuento;
                            TxtTotal.Text = Convert.ToString(tv);
                        }
                        
                    }

                }
                catch (Exception)
                {


                }

            }
        }

        private void TxtAbono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumerosPuntosyComas(e);
        }

        private void TxtInteresPorcentual_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumerosPuntosyComas(e);
        }

        private void TxtBuscarClientes_TextChanged(object sender, EventArgs e)
        {
            MostrarClientes(TxtBuscarClientes.Text.Trim());
        }

        private void DgvCarrito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (UnidadMedida.Trim() == "Unidad" || UnidadMedida.Trim() == "Galon" || UnidadMedida.Trim() == "Quintales" || UnidadMedida.Trim() == "Sobres")
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

        //METODO PARA VALIDAR LA CASILLA DEL DATAGRID Y QUE SOLO DEJE AGREGAR NUMEROS Y DECIMALES
        private void DgvCarrito_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (DgvCarrito.CurrentCell.ColumnIndex == 5)
            {

                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(DgvCarrito_KeyPress);

                }
            }

        }

        //METODO PARA VALIDAR QUE NO SE VAYA VACIO EL DATAGRIDVIEW
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

        //EVENTO PARA GUARDAR
        private void BtnAgregarDV_Click(object sender, EventArgs e)
        {
            if (Validartxt() > 0)
            {
                if (ValidarVacio() == false)
                {
                    ventascontado();
                    CapturarVentasCredito();
                    AgregarVentaProducto();
                    Delete();
                    DgvCarrito.Rows.Clear();
                    TxtSubTotal.Text = "0";
                    TxtAbono.Text = "0";
                    TxtInteresPorcentual.Text = "0";
                    TxtTotal.Text = "0";

                }
                else
                {
                    MessageBox.Show("Uno o más campos están vacíos. x.x", "Avíso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Uno o más campos están vacíos. x.x", "Avíso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
