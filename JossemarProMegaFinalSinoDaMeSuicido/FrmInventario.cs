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
    public partial class FrmInventario : Form
    {
        public FrmInventario()
        {
            InitializeComponent();
<<<<<<< HEAD
            LblLeyenda.BackColor = Color.SkyBlue;
            LblLeyenda.ForeColor = Color.SkyBlue;
            LblSinStock.BackColor = Color.DarkSalmon;
            LblSinStock.ForeColor = Color.DarkSalmon;
=======
            Colorear();
>>>>>>> e1888bfb7b92922b345264f6b469638968ed1985
        }
        CLogicaConsultas sql = new CLogicaConsultas();
        CLogicaLlenarCmb Fil = new CLogicaLlenarCmb();
        CLogicaObtenerFecha zzz = new CLogicaObtenerFecha();
<<<<<<< HEAD



        DateTime FechaCaducidad;
        

        void PersonalizarDGV()
        {
            DgvInventario.DataSource = sql.ConsultaTab("SELECT * FROM vs_InventarioCOMPRA");
            this.DgvInventario.Columns["IdProducto"].Visible = false;
            this.DgvInventario.Columns["Descripcion"].Visible = false;
            this.DgvInventario.Columns["IdCaducidad"].Visible = false;
            this.DgvInventario.Columns["IdCompra"].Visible = false;
            this.DgvInventario.Columns["IdSede"].Visible = false;
            this.DgvInventario.Columns["CATEGORIA"].Visible = false;
            this.DgvInventario.Columns["UM"].Visible = false;
            this.DgvInventario.Columns["CANTIDAD"].Visible = false;
            this.DgvInventario.Columns["UrlImagen"].Visible = false;
       
=======



        DateTime FechaCaducidad;
        

        void PersonalizarDGV()
        {
            this.DgvInventario.Columns["IdProducto"].Visible = false;
            this.DgvInventario.Columns["Descripcion"].Visible = false;
            this.DgvInventario.Columns["IdCaducidad"].Visible = false;
            this.DgvInventario.Columns["IdCompra"].Visible = false;
            this.DgvInventario.Columns["IdSede"].Visible = false;
            this.DgvInventario.Columns["CATEGORIA"].Visible = false;
            this.DgvInventario.Columns["UM"].Visible = false;
            this.DgvInventario.Columns["CANTIDAD"].Visible = false;
            this.DgvInventario.Columns["UrlImagen"].Visible = false;

        }
         void InventarioUnificado(string a)
         {
            DgvInventario.DataSource = sql.ConsultaTab("SELECT * FROM vs_InventarioCOMPRA ");
            
         }

        void MostrarISF()
        {
           //DgvPsf.DataSource = sql.ConsultaTab("SELECT vs_InventarioProductosSF.NombreProducto AS Producto, vs_InventarioProductosSF.DescripcionPSNF as Descripcion, vs_InventarioProductosSF.DescripcionC as Categoria, vs_InventarioProductosSF.DescripcionTipoUM AS UMedida, vs_InventarioProductosSF.DescripcionEstante AS Estante, vs_InventarioProductosSF.FechaCaducidad AS Caducidad, vs_InventarioProductosSF.PrecioVenta as PVenta,vs_InventarioProductosSF.Stock as Existencia FROM vs_InventarioProductosSF");
           DgvPsf.DataSource = sql.ConsultaTab("SELECT * FROM vs_InventarioCOMPRA");
        }
        //METODO PARA CAPTURAR TODAS LAS FECHAS DE CADUCIDAD
        void FechasCaducidad()
        {
            //DgvCaducidad.DataSource = sql.ConsultaTab("SELECT Lotes.FechaCaducidad FROM Compra,Lotes,Producto WHERE Producto.Stock <> '.00' AND Lotes.FechaCaducidad <> '0000-00-00'");
            DgvCaducidad.DataSource = sql.ConsultaTab("SELECT * FROM vs_InventarioCOMPRA");
        }
        void ViewProdAndCantInventario()
        {
            //LblTotalProductos.Text = sql.ConsultaSimple("SELECT COUNT(*) FROM Producto WHERE Producto.Stock <> '.00'");
            //string precioInv = sql.ConsultaSimple("SELECT SUM(DetalleCompra.PrecioVenta) FROM DetalleCompra,Producto WHERE Producto.Stock <> '.00'");
            //double PreInv = Convert.ToDouble(precioInv);
            //string format = String.Format("{0:#,##0.00}", PreInv);
            //LblTotalInventario.Text = format;
        }
>>>>>>> e1888bfb7b92922b345264f6b469638968ed1985

        }
      
        private void FrmInventario_Load(object sender, EventArgs e)
        {

            DgvInventario.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
<<<<<<< HEAD
            PersonalizarDGV();
=======

            DgvPsf.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvPsf.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //DgvInventario.DataSource = sql.ConsultaTab("SELECT vs_ProductosExistentes.NombreProducto AS Producto, vs_ProductosExistentes.Marca AS Marca, vs_ProductosExistentes.DescripcionC AS Categoria,vs_ProductosExistentes.DescripcionTipoUM, vs_ProductosExistentes.Descripcion FROM vs_ProductosExistentes WHERE vs_ProductosExistentes.NombreProducto LIKE '%%' AND vs_ProductosExistentes.Marca LIKE '%%' GROUP BY vs_ProductosExistentes.NombreProducto,vs_ProductosExistentes.Marca,vs_ProductosExistentes.DescripcionC,vs_ProductosExistentes.DescripcionTipoUM,vs_ProductosExistentes.Descripcion");
            InventarioUnificado("");
            MostrarISF();
            
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "Add";
            DgvInventario.Columns.Add(btn);

            int conteo = DgvInventario.Rows.Count;
            //MessageBox.Show("Cantidad de Productos = "+conteo);
            ViewProdAndCantInventario();
            FechasCaducidad();
            PersonalizarDGV();


>>>>>>> e1888bfb7b92922b345264f6b469638968ed1985
        }

        

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            DgvInventario.DataSource = sql.ConsultaTab("SELECT * FROM vs_InventarioCOMPRA where vs_InventarioCOMPRA.PRODUCTO LIKE'%" + TxtBuscar.Text + "%' OR vs_InventarioCOMPRA.CATEGORIA LIKE'%" + TxtBuscar.Text + "%' OR vs_InventarioCOMPRA.LOTE LIKE'%" + TxtBuscar.Text + "%'");
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void DgvInventario_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
  
           Colorear();
           
        }

        private void DgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvInventario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            
 
        }

        private void IBtnProductosCaducados_Click(object sender, EventArgs e)
        {
          
        }
       

        private void DgvInventario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmDetalleINVENTARIO vista = new FrmDetalleINVENTARIO();

            //int IdProducto = Convert.ToInt32(DgvInventario.Rows[e.RowIndex].Cells[1].Value);
            vista.TxtNombre.Text= Convert.ToString(DgvInventario.Rows[e.RowIndex].Cells[2].Value);
            vista.TxtMarca.Text = Convert.ToString(DgvInventario.Rows[e.RowIndex].Cells[3].Value);
            vista.TxtCantidad.Text = Convert.ToString(DgvInventario.Rows[e.RowIndex].Cells[11].Value);
            vista.TxtLote.Text = Convert.ToString(DgvInventario.Rows[e.RowIndex].Cells[5].Value);
            
            vista.TxtDescripcion.Text = Convert.ToString(DgvInventario.Rows[e.RowIndex].Cells["Descripcion"].Value);
            string valorComboCategoria = DgvInventario.CurrentRow.Cells["CATEGORIA"].Value.ToString();
            string valorComboUM = DgvInventario.CurrentRow.Cells["UM"].Value.ToString();
            vista.moverCategoriaCombo(valorComboCategoria, valorComboUM);
            vista.PtbImagen.ImageLocation = Convert.ToString(DgvInventario.Rows[e.RowIndex].Cells["UrlImagen"].Value);
            
            //Con esto calculamos los dias restantes o excedentes de vencimiento del producto
            FechaCaducidad = DateTime.Parse(Convert.ToString(DgvInventario.CurrentRow.Cells[9].Value));
            var dias = (FechaCaducidad - DateTime.Now).Days;

            if (FechaCaducidad < DateTime.Now)
            {
                int r = Convert.ToInt32(dias) * (-1);
                vista.LblAdvertencia.Visible = true;
                vista.LblFechaVencido.Visible = true;
                vista.LblFechaVencido.Text = Convert.ToString(r + " DIAS");

            }
            if (FechaCaducidad > DateTime.Now)
            {

                vista.LblNota.Visible = true;
                vista.LblDiasCantidad.Visible = true;
                vista.LblDiasCantidad.Text = Convert.ToString(dias + " DIAS");
            }
            vista.Show();


        }

        void Colorear()
        {
            int suma = 0, suma2=0,suma3=0;
            for (int i = 0; i < DgvInventario.RowCount; i++)
            {
                FechaCaducidad = DateTime.Parse(Convert.ToString(DgvInventario.Rows[i].Cells["VENCIMIENTO"].Value));
                var dias = (FechaCaducidad - DateTime.Now).Days;
                //MessageBox.Show("Probando"+dias);
                if (Convert.ToInt32(dias)<0)
                {
                   // MessageBox.Show("Probando");
                    DgvInventario.Rows[i].DefaultCellStyle.BackColor = Color.SkyBlue;
                    DgvInventario.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    suma2 = suma2 + 1;
                }
                if (Convert.ToInt32(DgvInventario.Rows[i].Cells["CANTIDAD"].Value)==0)
                {
                    DgvInventario.Rows[i].DefaultCellStyle.BackColor = Color.DarkSalmon;
                    DgvInventario.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    suma3 = suma3 + 1;
                }
                              
                suma = suma + Convert.ToInt32(DgvInventario.Rows[i].Cells[11].Value);
                
            }
            LblTotalProductos.Text = Convert.ToString(suma);
            LblCantidadCaducado.Text = Convert.ToString(suma2);
            LblTotalSinstock.Text = Convert.ToString(suma3);
        }
<<<<<<< HEAD
=======
       

        private void DgvInventario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmDetalleINVENTARIO vista = new FrmDetalleINVENTARIO();

            int IdProducto = Convert.ToInt32(DgvInventario.Rows[e.RowIndex].Cells[1].Value);
            vista.TxtNombre.Text= Convert.ToString(DgvInventario.Rows[e.RowIndex].Cells[2].Value);
            vista.TxtMarca.Text = Convert.ToString(DgvInventario.Rows[e.RowIndex].Cells[3].Value);
            vista.TxtCantidad.Text = Convert.ToString(DgvInventario.Rows[e.RowIndex].Cells[11].Value);
            vista.TxtLote.Text = Convert.ToString(DgvInventario.Rows[e.RowIndex].Cells[5].Value);
            
            vista.TxtDescripcion.Text = Convert.ToString(DgvInventario.Rows[e.RowIndex].Cells[6].Value);
            string valorComboCategoria = DgvInventario.CurrentRow.Cells["CATEGORIA"].Value.ToString();
            string valorComboUM = DgvInventario.CurrentRow.Cells["UM"].Value.ToString();
            vista.moverCategoriaCombo(valorComboCategoria, valorComboUM);
            vista.PtbImagen.ImageLocation = Convert.ToString(DgvInventario.Rows[e.RowIndex].Cells[14].Value);

            FechaCaducidad = DateTime.Parse(Convert.ToString(DgvInventario.CurrentRow.Cells[9].Value));
            var dias = (FechaCaducidad - DateTime.Now).Days;

            if (FechaCaducidad < DateTime.Now)
            {
                int r = Convert.ToInt32(dias) * (-1);
                vista.LblAdvertencia.Visible = true;
                vista.LblFechaVencido.Visible = true;
                vista.LblFechaVencido.Text = Convert.ToString(r + " DIAS");

            }
            if (FechaCaducidad > DateTime.Now)
            {

                vista.LblNota.Visible = true;
                vista.LblDiasCantidad.Visible = true;
                vista.LblDiasCantidad.Text = Convert.ToString(dias + " DIAS");
            }
            vista.Show();


        }

        void Colorear()
        {
            //for (int i = 0; i < DgvInventario.RowCount; i++)
            //{
            //    if (Convert.ToDateTime(DgvInventario.Rows[i].Cells[9].Value)<DateTime.Now)
            //    {
            //        DgvInventario.Rows[i].DefaultCellStyle.BackColor = Color.Red;
            //    }
            //}

        }
>>>>>>> e1888bfb7b92922b345264f6b469638968ed1985
      
    }
}
