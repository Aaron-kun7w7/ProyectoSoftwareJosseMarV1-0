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
            LblLeyenda.BackColor = Color.SkyBlue;
            LblLeyenda.ForeColor = Color.SkyBlue;
            LblSinStock.BackColor = Color.DarkSalmon;
            LblSinStock.ForeColor = Color.DarkSalmon;
        }
        CLogicaConsultas sql = new CLogicaConsultas();
        CLogicaLlenarCmb Fil = new CLogicaLlenarCmb();
        CLogicaObtenerFecha zzz = new CLogicaObtenerFecha();



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
       

        }
      
        private void FrmInventario_Load(object sender, EventArgs e)
        {

            DgvInventario.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PersonalizarDGV();
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
      
    }
}
