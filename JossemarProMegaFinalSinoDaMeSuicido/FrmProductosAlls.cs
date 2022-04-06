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
    public partial class FrmProductosAlls : Form
    {
        public FrmProductosAlls(string nom)
        {
            InitializeComponent();
            IdProd = nom;
        }
        string IdProd;
        CLogicaConsultas sql = new CLogicaConsultas();
        CLogicaObtenerIP idsede = new CLogicaObtenerIP();
        CLogicaVentas vtc = new CLogicaVentas();

        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHanler;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }

        }

        protected void Actualizar()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHanler.Invoke(this, args);
        }

        void ProductosAlls()
        {
            string sede = idsede.ObtenerSede();
            DgvProductos.DataSource = sql.ConsultaTab("SELECT vs_BtnViewInventario.IdCaducidad AS IdLote,vs_BtnViewInventario.IdProducto, vs_BtnViewInventario.NumeroLote as NroLote, vs_BtnViewInventario.FechaIngreso as Ingreso, vs_BtnViewInventario.FechaCaducidad AS Caducidad, vs_BtnViewInventario.CantidadU AS Cantidad FROM vs_BtnViewInventario WHERE vs_BtnViewInventario.IdProducto= '" + IdProd+"' AND vs_BtnViewInventario.IdSede ='"+sede+"'");
        }

        void FechasCaducidad()
        {
            DgvCaducidad.DataSource = sql.ConsultaTab("SELECT Compra.FechaCaducidad FROM Compra WHERE Compra.Stock <> '.00' AND Compra.FechaCaducidad <> '0000-00-00'");
        }
        private void FrmProductosAlls_Load(object sender, EventArgs e)
        {
            DgvProductos.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductosAlls();
        }

        private void TxtNombreFull_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumerosPuntosyComas(e);
        }

        private void DgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GbxNum.Visible = true;
        }

        private void DgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GbxNum.Visible = false;
        }

        private void BtnListo_Click(object sender, EventArgs e)
        {
            if(TxtCantidad.Text != "")
            {
                int IdLote = Convert.ToInt32(DgvProductos.CurrentRow.Cells[0].Value.ToString());
                int IdProd = Convert.ToInt32(DgvProductos.CurrentRow.Cells[1].Value.ToString());
                double Cantidad = Convert.ToDouble(DgvProductos.CurrentRow.Cells[5].Value.ToString());
                double cant = Convert.ToDouble(TxtCantidad.Text);
                if (Cantidad < cant)
                {
                    MessageBox.Show("La cantidad supera a la que hay en inventario.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtCantidad.Text = "";
                }
                else if (Cantidad >= cant)
                {
                    string result = vtc.Temporal(IdLote, IdProd, Cantidad);
                    MessageBox.Show("Producto agregado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Rellene el campo de cantidadad.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            //Actualizar();
            this.Close();
        }
    }
}
