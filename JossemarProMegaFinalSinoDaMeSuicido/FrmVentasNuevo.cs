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
namespace JossemarProMegaFinalSinoDaMeSuicido
{
    public partial class FrmVentasNuevo : Form
    {
        public FrmVentasNuevo(string a)
        {
            InitializeComponent();
            id = a;
        }
        string id,IdCliente, Descripcion, PrecioVenta, IdVenta, res;
        CLogicaLlenarCmb fill = new CLogicaLlenarCmb();
        CLogicaConsultas sql = new CLogicaConsultas();
        CLogicaAgregarClientes addC = new CLogicaAgregarClientes();
        CLogicaAgregarClientesCredito addcc = new CLogicaAgregarClientesCredito();
        CLogicaContadorCedula contCedula = new CLogicaContadorCedula();
        CDatosValidarCedula validation = new CDatosValidarCedula();
        CLogicaVentas vtc = new CLogicaVentas();
        Validaciones validar = new Validaciones();
        CLogicaObtenerFecha zzz = new CLogicaObtenerFecha();

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

        private void FrmVentasNuevo_Load(object sender, EventArgs e)
        {
            IniciarLoad();
            carrito();
        }

        //METODO PARA LLENAR EL DATAGRID DE LOS PRODUCTOS
        void MostrarProductos(string a)
        {
            DgvProductos.DataSource = fill.MostrarProductos(a);
        }

        //METODO PARA INICIAR TODO CON EL FORMULARIO
        void IniciarLoad()
        {
            LblUsuario.Text = id;

            DgvProductos.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DgvCarrito.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MostrarProductos("");

            DgvProductos.Columns["ID"].Visible = false;
            DgvProductos.Columns["IdEstadoProducto"].Visible = false;

            //foreach (DataGridViewColumn c in DgvCarrito.Columns)
            //    if (c.Name != "Stock1") c.ReadOnly = true;

            TxtDescuento.Text = "0";
            int a = Convert.ToInt32(sql.ConsultaSimple("SELECT MAX(Ventas.NF) FROM Ventas"));
            a = a + 1;
            TxtNumFactura.Text = Convert.ToString(a);


            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "Add";
            DgvProductos.Columns.Add(btn);

            MetodoTemp();
        }


        private void DgvProductos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.DgvProductos.Columns[e.ColumnIndex].Name == "Add" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell celAdd = this.DgvProductos.Rows[e.RowIndex].Cells["Add"] as DataGridViewButtonCell;
                Icon iconAdd = new Icon(Environment.CurrentDirectory + @"\\icons8_eye_16.ico");

                e.Graphics.DrawIcon(iconAdd, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.DgvProductos.Rows[e.RowIndex].Height = iconAdd.Height + 8;
                this.DgvProductos.Columns[e.ColumnIndex].Width = iconAdd.Width + 8;

                e.Handled = true;
            }
        }

        private void DgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.DgvProductos.Columns[e.ColumnIndex].Name == "Add")
            {
                string nomProd = Convert.ToString(DgvProductos.CurrentRow.Cells[1].Value).Trim();
                FrmProductosAlls prod = new FrmProductosAlls(nomProd);
                prod.ShowDialog();
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            carrito();
            carritoGod();
            //contaTactico++;
        }

        //METODOS PARA CAPTURAR DATOS DE LOS TXT Y AYUDARNOS A COMUNICARNOS CON LA CAPA LOGICA
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
            cantidad = new double[idprodmax];
            cantidadInv = new double[idprodmax];
            for (int i = 0; i < idprodmax; i++)
            {
                idnombresProd[i] = Convert.ToInt32(DgvCarrito.Rows[i].Cells[0].Value);
                cantidad[i] = Convert.ToDouble(DgvCarrito.Rows[i].Cells[5].Value);
                cantidadInv[i] = Convert.ToDouble(DgvCarrito.Rows[i].Cells[6].Value);
                //vtc.AddVentasProd(Convert.ToInt32(idVenta), Convert.ToInt32(DgvCarrito.Rows[i].Cells[0].Value), Convert.ToDouble(DgvCarrito.Rows[i].Cells[5].Value));
                //MessageBox.Show(Convert.ToString(i));

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


        //METODO PARA VALIDAR UNA CELDA VACIA DEL DATAGRID
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

        //METODO PARA TRAER DATOS DE LA TABLA TEMPORAL
        void MetodoTemp()
        {
            DgvTemporal.DataSource = fill.Temporal(); 
        }

        //METODO PARA LLENAR EL DATAGRID DEL CARRITO
        string nom = "";
        string descrip = "";
        string marca = "";
        string pventa = "";
        string cantidadlotes = "";
        int idProd2 = 0;
        void carrito()
        {
            int cont = DgvTemporal.Rows.Count;

            int[] idTemp = new int[cont];
            int[] idLote = new int[cont];
            int[] idProducto = new int[cont];
            double[] cantidad = new double[cont];

            
            for (int i = 0; i < cont; i++)
            {
                idTemp[i] = Convert.ToInt32(DgvTemporal.Rows[i].Cells[0].Value.ToString());
                idLote[i] = Convert.ToInt32(DgvTemporal.Rows[i].Cells[1].Value.ToString());
                idProducto[i] = Convert.ToInt32(DgvTemporal.Rows[i].Cells[2].Value.ToString());
                cantidad[i] = Convert.ToDouble(DgvTemporal.Rows[i].Cells[3].Value.ToString());

                nom = sql.ConsultaSimple("SELECT Producto.Nombre FROM Producto WHERE Producto.IdProducto = '"+idProducto[i]+ "'");
                descrip = sql.ConsultaSimple("SELECT Producto.Descripcion FROM Producto WHERE Producto.IdProducto = '" + idProducto[i] + "'");
                marca = sql.ConsultaSimple("SELECT Producto.Marca FROM Producto WHERE Producto.IdProducto = '" + idProducto[i] + "'");
                pventa = sql.ConsultaSimple("SELECT MAX(DetalleCompra.PrecioVenta) FROM DetalleCompra WHERE DetalleCompra.IdProducto ='"+idProducto[i]+"'");
                cantidadlotes = sql.ConsultaSimple("SELECT Temporal.Cantidad FROM Temporal WHERE Temporal.IdTemp ='"+idTemp[i]+"'");

                idProd2 = idProducto[i];
               
            }
        }
        //METODO PARA LLENAR EL DATAGRID DEL CARRITO x2
        void carritoGod()
        {
            int cont = DgvTemporal.Rows.Count;

            for (int i = 0; i < cont; i++)
            {
                DgvCarrito.Rows.Add();
                DgvCarrito.Rows[i].Cells[0].Value = idProd2;
                DgvCarrito.Rows[i].Cells[1].Value = nom;
                DgvCarrito.Rows[i].Cells[2].Value = descrip;
                DgvCarrito.Rows[i].Cells[3].Value = marca;
                DgvCarrito.Rows[i].Cells[4].Value = pventa;
                DgvCarrito.Rows[i].Cells[6].Value = cantidadlotes;
            }  
        }
    }
}
