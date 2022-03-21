using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Windows.Forms;
using System.Data;
namespace Logica
{
    public class CLogicaRegistrarProducto
    {
        CDatosRegistrarProducto add = new CDatosRegistrarProducto();
        public string AgregarProductos(string Nombre, string Descripcion, string Marca, int Stock, int IdUnidadM, int IdCategoria, int IdSede)
        {
            string result = add.AgregarProductto(Nombre,Descripcion,Marca,Stock,IdUnidadM,IdCategoria,IdSede);


            if (result.Trim() == "0")
            {
                MessageBox.Show("El Producto se agregó correctamente. :)", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return result;
            }
            else if(result.Trim() == "1")
            {
                MessageBox.Show("El Producto no se agregó correctamente. :)", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return result;
            }
            return result;
        }
    }
}
