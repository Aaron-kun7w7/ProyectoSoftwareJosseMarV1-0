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
    public class CLogicaLlenarCmb
    {
        CLogicaObtenerIP ip = new CLogicaObtenerIP();
        public DataTable cmbCategoria()
        {

            String sql2 = "SELECT IdCategoria, DescripcionC FROM Categoria";
            CLogicaConsultas consult = new CLogicaConsultas();
            return consult.ConsultaTab(sql2);

        }

        public DataTable cmbProveedores()
        {

            String sql2="SELECT IdProveedor, Proveedor.NombreEmpresa FROM Proveedor WHERE Proveedor.IdEstado = '1'";
            CLogicaConsultas consult = new CLogicaConsultas();
            return consult.ConsultaTab(sql2);

        }

        public DataTable cmbUnidadM()
        {

            String sql2 = "SELECT UnidadMedidas.IdUnidadM, UnidadMedidas.DescripcionTipoUM FROM UnidadMedidas";
            CLogicaConsultas consult = new CLogicaConsultas();
            return consult.ConsultaTab(sql2);

        }

        public DataTable cmbCategoria2()
        {

            String sql2 = "SELECT DescripcionC as Categoria, IdCategoria as ID   FROM Categoria ";
            CLogicaConsultas consult = new CLogicaConsultas();
            return consult.ConsultaTab(sql2);

        }

        public DataTable cmbProveedores2()
        {

            String sql2 = "SELECT IdProveedor, Proveedor.NombreEmpresa FROM Proveedor";
            CLogicaConsultas consult = new CLogicaConsultas();
            return consult.ConsultaTab(sql2);

        }

        public DataTable cmbUnidadM2()
        {

            String sql2 = "SELECT UnidadMedida.DescripcionTipoUM as Medida, UnidadMedida.IdUnidadM as ID  FROM UnidadMedida ";

            CLogicaConsultas consult = new CLogicaConsultas();
            return consult.ConsultaTab(sql2);

        }

        public DataTable cmbEstantes2()
        {

            String sql2 = "SELECT  DescripcionEstante as Estante, IdEstante as ID  FROM Estanteria ";
            CLogicaConsultas consult = new CLogicaConsultas();
            return consult.ConsultaTab(sql2);

        }

        public DataTable cmbDescriEstadoDevolucionV()
        {

            String sql2 = " SELECT EstadoDevolucionV.IdEstadoDV, EstadoDevolucionV.DescripcionDv FROM EstadoDevolucionV";
            CLogicaConsultas consult = new CLogicaConsultas();
            return consult.ConsultaTab(sql2);

        }

        public DataTable LlenarDgvHistorialVentas(string a)
        {

            String sql2 = "SELECT vs_VentasUnificadas.NF as NFactura,vs_VentasUnificadas.NombreCli as Nombre_C, vs_VentasUnificadas.ApellidoCli as Apellido_C, vs_VentasUnificadas.PrecioDescuento AS P_Descuento, vs_VentasUnificadas.SubTotal as SubTotal, vs_VentasUnificadas.Total as Total, vs_VentasUnificadas.FechaVenta as F_Venta, vs_VentasUnificadas.IdCliente, vs_VentasUnificadas.IdFacturaVenta, vs_VentasUnificadas.IdEstadoV FROM vs_VentasUnificadas WHERE vs_VentasUnificadas.NF='" + a+"'";
            CLogicaConsultas consult = new CLogicaConsultas();
            return consult.ConsultaTab(sql2);

        }
        public DataTable LlenarDgvHistorialVentasAlls()
        {

            String sql2 = "SELECT vs_VentasUnificadas.NF as NFactura,vs_VentasUnificadas.NombreCli as Nombre_C, vs_VentasUnificadas.ApellidoCli as Apellido_C, vs_VentasUnificadas.PrecioDescuento AS P_Descuento, vs_VentasUnificadas.SubTotal as SubTotal, vs_VentasUnificadas.Total as Total, vs_VentasUnificadas.FechaVenta as F_Venta, vs_VentasUnificadas.IdCliente, vs_VentasUnificadas.IdFacturaVenta, vs_VentasUnificadas.IdEstadoV FROM vs_VentasUnificadas";
            CLogicaConsultas consult = new CLogicaConsultas();
            return consult.ConsultaTab(sql2);

        }

        public DataTable LlenarDgvIdProductoVenta(string a)
        {

            String sql2 = "SELECT VentaProducto.IdProducto FROM VentaProducto WHERE VentaProducto.IdVenta ="+a+"";
            CLogicaConsultas consult = new CLogicaConsultas();
            return consult.ConsultaTab(sql2);

        }

        public DataTable LlenarDgvUsuarios(string a)
        {

            String sql2 = "SELECT vs_Usuarios.IdUsuario as ID, vs_Usuarios.Nombre, vs_Usuarios.Apellido, vs_Usuarios.NombreUsuario as Nombre_Usuario, vs_Usuarios.Pass as Contraseña, vs_Usuarios.IdSede as Sede, vs_Usuarios.IdEstadoUsuario as IDE, vs_Usuarios.IdTipoUsuario as IDTU, vs_Usuarios.DescripcionTU as Privilegio FROM vs_Usuarios WHERE vs_Usuarios.NombreUsuario LIKE'%" + a + "%'";
            CLogicaConsultas consult = new CLogicaConsultas();
            return consult.ConsultaTab(sql2);

        }

        public DataTable cmbPrivilegios()
        {

            String sql2 = "SELECT TipoUsuario.IdTipoUsuario, TipoUsuario.DescripcionTU FROM TipoUsuario WHERE IdTipoUsuario <> 2";
            CLogicaConsultas consult = new CLogicaConsultas();
            return consult.ConsultaTab(sql2);

        }

        public DataTable MostrarTotalCantInventario()
        {

            String sql2 = "SELECT COUNT(*) FROM Compra WHERE Compra.Stock <> '.00'";
            CLogicaConsultas consult = new CLogicaConsultas();
            return consult.ConsultaTab(sql2);

        }

        public string MostrarTotalProdSinFact()
        {
            String sql2 = "SELECT COUNT(*) FROM ProductosSinFactura WHERE ProductosSinFactura.Stock <> '0'";
            CLogicaConsultas consult = new CLogicaConsultas();
            return consult.ConsultaSimple(sql2);
        }

        public string MostrarCantTotalProdSinFact()
        {
            String sql2 = "SELECT SUM(ProductosSinFactura.PrecioVenta) FROM ProductosSinFactura WHERE ProductosSinFactura.Stock <> '0'";
            CLogicaConsultas consult = new CLogicaConsultas();
            return consult.ConsultaSimple(sql2);
        }

        public DataTable MostrarInventarioSinFactura(string a)
        {
            String sql2 = "SELECT vs_InventarioProductosSF.NombreProducto AS Producto,vs_InventarioProductosSF.Marca AS Marca, vs_InventarioProductosSF.DescripcionPSNF as Descripcion, vs_InventarioProductosSF.DescripcionC as Categoria, vs_InventarioProductosSF.DescripcionTipoUM AS UMedida, vs_InventarioProductosSF.DescripcionEstante AS Estante, vs_InventarioProductosSF.FechaCaducidad AS Caducidad, vs_InventarioProductosSF.PrecioVenta as PVenta,vs_InventarioProductosSF.Stock as Existencia FROM vs_InventarioProductosSF WHERE vs_InventarioProductosSF.NombreProducto LIKE'%"+a+"%' OR vs_InventarioProductosSF.Marca LIKE'%"+a+"%' OR vs_InventarioProductosSF.DescripcionC LIKE'%"+a+"%'";
            CLogicaConsultas consult = new CLogicaConsultas();
            return consult.ConsultaTab(sql2);
        }

        //METODO PARA MOSTRAR LAS VENTAS POR PRODUCTO EN ESPECIFICO
        public DataTable MostrarVentasE(string a)
        {
            String sql2 = "SELECT vs_VentasEspecificas.NombreProducto as Producto, vs_VentasEspecificas.Marca, vs_VentasEspecificas.Descripcion as Descripcion, vs_VentasEspecificas.DescripcionTipoUM as Uds_Medida, vs_VentasEspecificas.DescripcionC as Categoria, vs_VentasEspecificas.PrecioVenta as P_Venta, vs_VentasEspecificas.Cantidad, vs_VentasEspecificas.FechaVenta as F_Vennta, vs_VentasEspecificas.IdVenta, vs_VentasEspecificas.IdFacturaVenta,vs_VentasEspecificas.IdProducto, vs_VentasEspecificas.IdVentaProd, vs_VentasEspecificas.IdEstadoProducto FROM vs_VentasEspecificas WHERE vs_VentasEspecificas.IdVenta ='"+a+"' AND vs_VentasEspecificas.IdEstadoProducto <>'2'";
            CLogicaConsultas consult = new CLogicaConsultas();
            return consult.ConsultaTab(sql2);
        }

        //METODO PARA MOSTRAR LOS PRODUCTOS DEVUELTOS EN ESPECIFICO
        public DataTable MostrarDevolucionesE(string a)
        {
            String sql2 = "SELECT vs_VentasEspecificas.NombreProducto as Producto, vs_VentasEspecificas.Marca, vs_VentasEspecificas.Descripcion as Descripcion, vs_VentasEspecificas.DescripcionTipoUM as Uds_Medida, vs_VentasEspecificas.DescripcionC as Categoria, vs_VentasEspecificas.PrecioVenta as P_Venta, vs_VentasEspecificas.Cantidad, vs_VentasEspecificas.FechaVenta as F_Vennta, vs_VentasEspecificas.IdVenta, vs_VentasEspecificas.IdFacturaVenta,vs_VentasEspecificas.IdProducto, vs_VentasEspecificas.IdVentaProd, vs_VentasEspecificas.IdEstadoProducto FROM vs_VentasEspecificas WHERE vs_VentasEspecificas.IdVenta ='" + a + "' AND vs_VentasEspecificas.IdEstadoProducto = '2'";
            CLogicaConsultas consult = new CLogicaConsultas();
            return consult.ConsultaTab(sql2);
        }

        //METODO PARA MOSTRAR EN COMBOBOX LOS ESTADOS DE UNA CANCELACIOON DE FACTURA
        public DataTable cmbEstadosCF()
        {

            String sql2 = "	SELECT EstadoDevolucionV.IdEstadoDV, EstadoDevolucionV.DescripcionDv FROM EstadoDevolucionV";
            CLogicaConsultas consult = new CLogicaConsultas();
            return consult.ConsultaTab(sql2);

        }

        //METODO PARA LLENAR DATAGRIDVIEW DE UNIDADES DE MEDIDA
        public DataTable MostrarUnidadMDgv()
        {

            String sql2 = "SELECT UnidadMedida.DescripcionTipoUM FROM UnidadMedida";
            CLogicaConsultas consult = new CLogicaConsultas();
            return consult.ConsultaTab(sql2);

        }

        //NUEVOS METODOSSSSSSSSSSS

        //METODO PARA LLENAR EL DATAGRIDCONPRODUCTOS
        public DataTable MostrarProd(string a)
        {
            String sql2 = "SELECT vs_Productos.Nombre AS Producto, vs_Productos.Marca,vs_Productos.DescripcionC AS Categoría, vs_Productos.DescripcionTipoUM AS UndMedida, vs_Productos.IdProducto, vs_Productos.IdEstadoProducto FROM vs_Productos WHERE vs_Productos.Nombre LIKE'%"+a+"%' AND vs_Productos.IdEstadoProducto = 1";
            CLogicaConsultas consult = new CLogicaConsultas();
            return consult.ConsultaTab(sql2);
        }

        public DataTable MostrarUndMedida()
        {
            String sql2 = "SELECT UnidadMedidas.IdUnidadM, UnidadMedidas.DescripcionTipoUM FROM UnidadMedidas";
            CLogicaConsultas consult = new CLogicaConsultas();
            return consult.ConsultaTab(sql2);
        }

        public DataTable MostrarProveedores()
        {
            string a = ip.ObtenerSede();
            String sql2 = "SELECT Proveedor.IdProveedor, Proveedor.NombreEmpresa FROM Proveedor";
            CLogicaConsultas consult = new CLogicaConsultas();
            return consult.ConsultaTab(sql2);
        }

        public DataTable MostrarCategorias()
        {
            String sql2 = "SELECT Categoria.IdCategoria, Categoria.DescripcionC FROM Categoria";
            CLogicaConsultas consult = new CLogicaConsultas();
            return consult.ConsultaTab(sql2);
        }

        //METODO PARA LA CONSULTA QUE TRAE LOS PRODUCTOS
        public DataTable MostrarProductos(string a)
        {
            string sede = ip.ObtenerSede();
            String sql2 = "SELECT vs_Productos.IdProducto as ID, vs_Productos.Nombre AS Producto, vs_Productos.Marca,vs_Productos.DescripcionC AS Categoría, vs_Productos.DescripcionTipoUM AS UndMedida, vs_Productos.IdEstadoProducto FROM vs_Productos WHERE vs_Productos.Nombre LIKE'%%' AND vs_Productos.IdEstadoProducto = 1 AND vs_Productos.IdSede ='"+sede+"'";
            CLogicaConsultas consult = new CLogicaConsultas();
            return consult.ConsultaTab(sql2);
        }

        //METODO PARA MOSTRAR DATOS DE LA TABLA TEMPORAL
        public DataTable Temporal()
        {
            String sql2 = "SELECT Temporal.IdTemp, Temporal.IdLote, Temporal.IdProducto, Temporal.Cantidad FROM Temporal";
            CLogicaConsultas consult = new CLogicaConsultas();
            return consult.ConsultaTab(sql2);
        }

    }
}
