using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JossemarProMegaFinalSinoDaMeSuicido
{
    public partial class FrmDetalleINVENTARIO : Form
    {
        public FrmDetalleINVENTARIO()
        {
            InitializeComponent();
          
        }

        private void PnlBarraSuperior_Paint(object sender, PaintEventArgs e)
        {

        }
       public void moverCategoriaCombo(string valor, string valor2)
        {
            CmbCategoria.Items.Add(valor);
            CmbUM.Items.Add(valor2);

            CmbCategoria.SelectedIndex = 0;
            CmbUM.SelectedIndex = 0;
        }


    }
}
