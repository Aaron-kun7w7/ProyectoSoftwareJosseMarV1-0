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
    public partial class AñadirEstante : Form
    {
        public AñadirEstante()
        {
            InitializeComponent();
        }
        CLogicaLlenarCmb fill = new CLogicaLlenarCmb();
        CLogicaAddEstanteyCategoria add = new CLogicaAddEstanteyCategoria();
        CLogicaConsultas sql = new CLogicaConsultas();
        //METODO PARA LLENAR COMBOBOX DE CATEGORIA
        //void cmbCategorias()
        //{
        //    CbxCategoria.DataSource = fill.cmbCategoria();
        //    CbxCategoria.DisplayMember = "DescripcionC";
        //    CbxCategoria.ValueMember = "IdCategoria";

        //}

        //METODO PARA CAPTURAR DATOS
        //void CapturarDatosE()
        //{
        //    int IdCategoria = Convert.ToInt32(CbxCategoria.SelectedValue.ToString());
        //    string descripcionE = TxtDescripcionE.Text;
        //    add.AddEstante(IdCategoria, descripcionE);

        //}
        void CapturarDatosC()
        {
            string descripcionC = TxtCategoria.Text;
            add.AddCategoria(descripcionC);

        }

       

        void LlenarGridCategoria()
        {
            DgvCategoria.DataSource = sql.ConsultaTab("SELECT Categoria.IdCategoria as ID, Categoria.DescripcionC as Categoria FROM Categoria");
        }

        //-----------------------------------------------------------------------------------------------

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //CapturarDatosE();
            LlenarGridCategoria();
            CapturarDatosC();
        }

        private void AñadirEstante_Load(object sender, EventArgs e)
        {
            DgvCategoria.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LlenarGridCategoria();
        }

        private void BtnGuardarC_Click(object sender, EventArgs e)
        {
            CapturarDatosC();
            // CapturarDatosC();
            LlenarGridCategoria();
            //cmbCategorias();
        }

        private void BtnDeleteC_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que quieres eliminar esta categoria?", "Avíso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                foreach (DataGridViewRow row in DgvCategoria.SelectedRows)
                {
                    add.EliminarCategoria(Convert.ToInt32(DgvCategoria.CurrentRow.Cells[0].Value));
                    LlenarGridCategoria();

                }
            }
            else if (result == DialogResult.Cancel)
            {

            }
        }

        private void TxtCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetrasONumeros(e);
        }
    }
   
}

