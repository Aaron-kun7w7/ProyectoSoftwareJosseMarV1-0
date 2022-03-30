using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Windows.Forms;
namespace Logica
{
   public class CLogicaAddEstanteyCategoria
    {
        CDatosAddEstanteyCategoria add = new CDatosAddEstanteyCategoria();
        
        public string AddCategoria(string DescripcionC)
        {
            // string IP = ip.ObtenerIp();

            string result = add.AgregarCategoria(DescripcionC);


            if (result.Trim() == "E")
            {
                MessageBox.Show("Lo sentimos. La categoría que desea agregar ya existe. :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return result;
            }

            if (result.Trim() == "G")
            {
                MessageBox.Show("Categoría agregada correctamente. :)", "Info Sr", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return result;
            }

            return result;

        }

        public string EliminarCategoria(int idc)
        {
            // string IP = ip.ObtenerIp();

            string result = add.EliminarCategoria(idc);

            if (result.Trim() == "G")
            {
                MessageBox.Show("La Categoria se eliminó correctamente. :)", "Avíso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return result;
            }
            else
            {
                MessageBox.Show("La Categoria no se puedo eliminar. x.x", "Avíso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return result;
            }

            return result;

        }
    }
}
