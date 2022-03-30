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
        }
        CLogicaConsultas sql = new CLogicaConsultas();
        CLogicaLlenarCmb Fil = new CLogicaLlenarCmb();
        CLogicaObtenerFecha zzz = new CLogicaObtenerFecha();
         void InventarioUnificado(string a)
         {
            DgvInventario.DataSource = sql.ConsultaTab("SELECT vs_ProductosExistentes.NombreProducto AS Producto, vs_ProductosExistentes.Marca AS Marca, vs_ProductosExistentes.DescripcionC AS Categoria,vs_ProductosExistentes.DescripcionTipoUM as UMedida, vs_ProductosExistentes.Descripcion, vs_ProductosExistentes.FechaCaducidad FROM vs_ProductosExistentes WHERE vs_ProductosExistentes.NombreProducto LIKE '%" + a+"%' OR vs_ProductosExistentes.Marca LIKE '%"+a+ "%' OR vs_ProductosExistentes.DescripcionC LIKE'%"+a+ "%' AND vs_ProductosExistentes.IdEstado =1 GROUP BY vs_ProductosExistentes.NombreProducto,vs_ProductosExistentes.Marca,vs_ProductosExistentes.DescripcionC,vs_ProductosExistentes.DescripcionTipoUM,vs_ProductosExistentes.Descripcion,vs_ProductosExistentes.FechaCaducidad");
            
        }

        void MostrarISF()
        {
            DgvPsf.DataSource = sql.ConsultaTab("SELECT vs_InventarioProductosSF.NombreProducto AS Producto, vs_InventarioProductosSF.DescripcionPSNF as Descripcion, vs_InventarioProductosSF.DescripcionC as Categoria, vs_InventarioProductosSF.DescripcionTipoUM AS UMedida, vs_InventarioProductosSF.DescripcionEstante AS Estante, vs_InventarioProductosSF.FechaCaducidad AS Caducidad, vs_InventarioProductosSF.PrecioVenta as PVenta,vs_InventarioProductosSF.Stock as Existencia FROM vs_InventarioProductosSF");
        }
        //METODO PARA CAPTURAR TODAS LAS FECHAS DE CADUCIDAD
        void FechasCaducidad()
        {
            DgvCaducidad.DataSource = sql.ConsultaTab("SELECT Compra.FechaCaducidad FROM Compra WHERE Compra.Stock <> '.00' AND Compra.FechaCaducidad <> '0000-00-00'");
        }
        void ViewProdAndCantInventario()
        {
            LblTotalProductos.Text = sql.ConsultaSimple("SELECT COUNT(*) FROM Compra WHERE Compra.Stock <> '.00'");
            string precioInv = sql.ConsultaSimple("SELECT SUM(Compra.PrecioVenta) FROM Compra WHERE Compra.Stock <> '.00'");
            double PreInv = Convert.ToDouble(precioInv);
            string format = String.Format("{0:#,##0.00}", PreInv);
            LblTotalInventario.Text = format;
        }

        private void FrmInventario_Load(object sender, EventArgs e)
        {
            DgvInventario.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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
            this.DgvInventario.Columns["FechaCaducidad"].Visible = false;
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            InventarioUnificado(TxtBuscar.Text);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void DgvInventario_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.DgvInventario.Columns[e.ColumnIndex].Name == "Add" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell celAdd = this.DgvInventario.Rows[e.RowIndex].Cells["Add"] as DataGridViewButtonCell;
                Icon iconAdd = new Icon(Environment.CurrentDirectory + @"\\icons8_eye_16.ico");
                
                e.Graphics.DrawIcon(iconAdd, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.DgvInventario.Rows[e.RowIndex].Height = iconAdd.Height + 8;
                this.DgvInventario.Columns[e.ColumnIndex].Width = iconAdd.Width + 8;

                e.Handled = true;
            }
           
        }

        private void DgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.DgvInventario.Columns[e.ColumnIndex].Name =="Add")
            {
                string nomProd = Convert.ToString(DgvInventario.CurrentRow.Cells[1].Value).Trim();
                FrmProductosAlls prod = new FrmProductosAlls(nomProd);
                prod.ShowDialog();
            }
        }

        private void DgvInventario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
        }

        private void IBtnProductosCaducados_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmProductosVencidos vc = new FrmProductosVencidos();
            vc.ShowDialog();
        }
    }
}
