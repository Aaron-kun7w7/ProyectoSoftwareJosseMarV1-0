/*
 Navicat Premium Data Transfer

 Source Server         : Pruebita
 Source Server Type    : SQL Server
 Source Server Version : 15002000
 Source Host           : sql5107.site4now.net:1433
 Source Catalog        : db_a8475e_bddjossemar123
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 15002000
 File Encoding         : 65001

 Date: 25/03/2022 10:29:20
*/


-- ----------------------------
-- Table structure for Categoria
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Categoria]') AND type IN ('U'))
	DROP TABLE [dbo].[Categoria]
GO

CREATE TABLE [dbo].[Categoria] (
  [IdCategoria] int  IDENTITY(1,1) NOT NULL,
  [DescripcionC] nchar(40) COLLATE Modern_Spanish_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[Categoria] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Categoria
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Categoria] ON
GO

INSERT INTO [dbo].[Categoria] ([IdCategoria], [DescripcionC]) VALUES (N'1', N'Hierbicida                              ')
GO

INSERT INTO [dbo].[Categoria] ([IdCategoria], [DescripcionC]) VALUES (N'2', N'Fungicidas                              ')
GO

INSERT INTO [dbo].[Categoria] ([IdCategoria], [DescripcionC]) VALUES (N'3', N'Foliar                                  ')
GO

INSERT INTO [dbo].[Categoria] ([IdCategoria], [DescripcionC]) VALUES (N'4', N'Pesticidas                              ')
GO

INSERT INTO [dbo].[Categoria] ([IdCategoria], [DescripcionC]) VALUES (N'5', N'Fertilizante                            ')
GO

INSERT INTO [dbo].[Categoria] ([IdCategoria], [DescripcionC]) VALUES (N'6', N'Repuesto                                ')
GO

INSERT INTO [dbo].[Categoria] ([IdCategoria], [DescripcionC]) VALUES (N'7', N'Insecticida                             ')
GO

SET IDENTITY_INSERT [dbo].[Categoria] OFF
GO


-- ----------------------------
-- Table structure for Clientes
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Clientes]') AND type IN ('U'))
	DROP TABLE [dbo].[Clientes]
GO

CREATE TABLE [dbo].[Clientes] (
  [Idclientes] int  IDENTITY(1,1) NOT NULL,
  [NombreCli] nchar(30) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [ApellidoCli] nchar(30) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [TipoCliente] nchar(15) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [IdTelefono] int  NULL,
  [IdDireccion] int  NULL,
  [Cedula] nchar(16) COLLATE Modern_Spanish_CI_AS  NULL,
  [IdEstadoCliente] int  NULL,
  [IdEstadoCredito] int  NULL,
  [IdSede] int  NULL
)
GO

ALTER TABLE [dbo].[Clientes] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Clientes
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Clientes] ON
GO

SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO


-- ----------------------------
-- Table structure for Compra
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Compra]') AND type IN ('U'))
	DROP TABLE [dbo].[Compra]
GO

CREATE TABLE [dbo].[Compra] (
  [IdCompra] int  IDENTITY(1,1) NOT NULL,
  [Nfactura] nchar(30) COLLATE Modern_Spanish_CI_AS  NULL,
  [IdUsuario] int  NOT NULL,
  [IdProveedor] int  NOT NULL,
  [FechaIngreso] date  NOT NULL,
  [Subtotal] decimal(11,2)  NOT NULL,
  [Total] decimal(11,2)  NOT NULL,
  [Descuento] decimal(11,2)  NULL,
  [IdSede] int  NOT NULL
)
GO

ALTER TABLE [dbo].[Compra] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Compra
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Compra] ON
GO

SET IDENTITY_INSERT [dbo].[Compra] OFF
GO


-- ----------------------------
-- Table structure for DetalleCompra
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[DetalleCompra]') AND type IN ('U'))
	DROP TABLE [dbo].[DetalleCompra]
GO

CREATE TABLE [dbo].[DetalleCompra] (
  [IdCompra] int  NOT NULL,
  [IdProducto] int  NOT NULL,
  [Cantidad] decimal(11,2)  NOT NULL,
  [PrecioCompra] decimal(11,2)  NOT NULL,
  [PrecioVenta] decimal(11,2)  NOT NULL
)
GO

ALTER TABLE [dbo].[DetalleCompra] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of DetalleCompra
-- ----------------------------

-- ----------------------------
-- Table structure for Direccion
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Direccion]') AND type IN ('U'))
	DROP TABLE [dbo].[Direccion]
GO

CREATE TABLE [dbo].[Direccion] (
  [IdDireccion] int  IDENTITY(1,1) NOT NULL,
  [DescripcionDir] nchar(60) COLLATE Modern_Spanish_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[Direccion] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Direccion
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Direccion] ON
GO

INSERT INTO [dbo].[Direccion] ([IdDireccion], [DescripcionDir]) VALUES (N'1', N'Sanjuan de rio coco                                         ')
GO

SET IDENTITY_INSERT [dbo].[Direccion] OFF
GO


-- ----------------------------
-- Table structure for Empleados
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Empleados]') AND type IN ('U'))
	DROP TABLE [dbo].[Empleados]
GO

CREATE TABLE [dbo].[Empleados] (
  [IdEmpleado] int  IDENTITY(1,1) NOT NULL,
  [IdTipoEmpleado] int  NOT NULL,
  [CedulaE] nchar(16) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [Nombre] nchar(30) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [Apellido] nchar(30) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [IdTelefono] int  NOT NULL,
  [IdDireccion] int  NOT NULL,
  [IdEstadoEmpleado] int  NOT NULL,
  [IdSede] int  NOT NULL
)
GO

ALTER TABLE [dbo].[Empleados] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Empleados
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Empleados] ON
GO

SET IDENTITY_INSERT [dbo].[Empleados] OFF
GO


-- ----------------------------
-- Table structure for EstadoCliente
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[EstadoCliente]') AND type IN ('U'))
	DROP TABLE [dbo].[EstadoCliente]
GO

CREATE TABLE [dbo].[EstadoCliente] (
  [IdEstadoCliente] int  IDENTITY(1,1) NOT NULL,
  [DescripcionEC] nchar(50) COLLATE Modern_Spanish_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[EstadoCliente] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of EstadoCliente
-- ----------------------------
SET IDENTITY_INSERT [dbo].[EstadoCliente] ON
GO

INSERT INTO [dbo].[EstadoCliente] ([IdEstadoCliente], [DescripcionEC]) VALUES (N'1', N'Activo                                            ')
GO

INSERT INTO [dbo].[EstadoCliente] ([IdEstadoCliente], [DescripcionEC]) VALUES (N'2', N'No activo                                         ')
GO

INSERT INTO [dbo].[EstadoCliente] ([IdEstadoCliente], [DescripcionEC]) VALUES (N'3', N'Moroso                                            ')
GO

SET IDENTITY_INSERT [dbo].[EstadoCliente] OFF
GO


-- ----------------------------
-- Table structure for EstadoCredito
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[EstadoCredito]') AND type IN ('U'))
	DROP TABLE [dbo].[EstadoCredito]
GO

CREATE TABLE [dbo].[EstadoCredito] (
  [IdEstadoCredito] int  IDENTITY(1,1) NOT NULL,
  [DescripcionEC] nchar(50) COLLATE Modern_Spanish_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[EstadoCredito] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of EstadoCredito
-- ----------------------------
SET IDENTITY_INSERT [dbo].[EstadoCredito] ON
GO

INSERT INTO [dbo].[EstadoCredito] ([IdEstadoCredito], [DescripcionEC]) VALUES (N'1', N'Sin crédito                                       ')
GO

INSERT INTO [dbo].[EstadoCredito] ([IdEstadoCredito], [DescripcionEC]) VALUES (N'2', N'Con crédito                                       ')
GO

SET IDENTITY_INSERT [dbo].[EstadoCredito] OFF
GO


-- ----------------------------
-- Table structure for EstadoEmpleado
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[EstadoEmpleado]') AND type IN ('U'))
	DROP TABLE [dbo].[EstadoEmpleado]
GO

CREATE TABLE [dbo].[EstadoEmpleado] (
  [IdEstadoEmpleado] int  IDENTITY(1,1) NOT NULL,
  [DescripcionEstadoE] nchar(10) COLLATE Modern_Spanish_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[EstadoEmpleado] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of EstadoEmpleado
-- ----------------------------
SET IDENTITY_INSERT [dbo].[EstadoEmpleado] ON
GO

SET IDENTITY_INSERT [dbo].[EstadoEmpleado] OFF
GO


-- ----------------------------
-- Table structure for EstadoProducto
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[EstadoProducto]') AND type IN ('U'))
	DROP TABLE [dbo].[EstadoProducto]
GO

CREATE TABLE [dbo].[EstadoProducto] (
  [IdEstadoProducto] int  IDENTITY(1,1) NOT NULL,
  [DescripcionEP] nchar(40) COLLATE Modern_Spanish_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[EstadoProducto] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of EstadoProducto
-- ----------------------------
SET IDENTITY_INSERT [dbo].[EstadoProducto] ON
GO

INSERT INTO [dbo].[EstadoProducto] ([IdEstadoProducto], [DescripcionEP]) VALUES (N'1', N'Activo                                  ')
GO

INSERT INTO [dbo].[EstadoProducto] ([IdEstadoProducto], [DescripcionEP]) VALUES (N'2', N'No Activo                               ')
GO

SET IDENTITY_INSERT [dbo].[EstadoProducto] OFF
GO


-- ----------------------------
-- Table structure for EstadoProveedor
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[EstadoProveedor]') AND type IN ('U'))
	DROP TABLE [dbo].[EstadoProveedor]
GO

CREATE TABLE [dbo].[EstadoProveedor] (
  [IdEstadoProv] int  IDENTITY(1,1) NOT NULL,
  [Descripcion] nchar(30) COLLATE Modern_Spanish_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[EstadoProveedor] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of EstadoProveedor
-- ----------------------------
SET IDENTITY_INSERT [dbo].[EstadoProveedor] ON
GO

INSERT INTO [dbo].[EstadoProveedor] ([IdEstadoProv], [Descripcion]) VALUES (N'1', N'Habilitado                    ')
GO

INSERT INTO [dbo].[EstadoProveedor] ([IdEstadoProv], [Descripcion]) VALUES (N'2', N'Inactivo                      ')
GO

SET IDENTITY_INSERT [dbo].[EstadoProveedor] OFF
GO


-- ----------------------------
-- Table structure for EstadoUsuario
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[EstadoUsuario]') AND type IN ('U'))
	DROP TABLE [dbo].[EstadoUsuario]
GO

CREATE TABLE [dbo].[EstadoUsuario] (
  [IdEstadoUsuario] int  IDENTITY(1,1) NOT NULL,
  [DescripcionEU] nchar(40) COLLATE Modern_Spanish_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[EstadoUsuario] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of EstadoUsuario
-- ----------------------------
SET IDENTITY_INSERT [dbo].[EstadoUsuario] ON
GO

INSERT INTO [dbo].[EstadoUsuario] ([IdEstadoUsuario], [DescripcionEU]) VALUES (N'1', N'Habiilitado                             ')
GO

INSERT INTO [dbo].[EstadoUsuario] ([IdEstadoUsuario], [DescripcionEU]) VALUES (N'2', N'Deshabilitado                           ')
GO

INSERT INTO [dbo].[EstadoUsuario] ([IdEstadoUsuario], [DescripcionEU]) VALUES (N'3', N'Bloqueado                               ')
GO

INSERT INTO [dbo].[EstadoUsuario] ([IdEstadoUsuario], [DescripcionEU]) VALUES (N'4', N'En Espera                               ')
GO

SET IDENTITY_INSERT [dbo].[EstadoUsuario] OFF
GO


-- ----------------------------
-- Table structure for HistorialPrecios
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[HistorialPrecios]') AND type IN ('U'))
	DROP TABLE [dbo].[HistorialPrecios]
GO

CREATE TABLE [dbo].[HistorialPrecios] (
  [IdHistorialPrecios] int  IDENTITY(1,1) NOT NULL,
  [PrecioCompra] decimal(11,2)  NOT NULL,
  [PrecioVenta] decimal(11,2)  NOT NULL,
  [IdProducto] int  NOT NULL,
  [Fecha] date  NOT NULL,
  [IdSede] int  NOT NULL
)
GO

ALTER TABLE [dbo].[HistorialPrecios] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of HistorialPrecios
-- ----------------------------
SET IDENTITY_INSERT [dbo].[HistorialPrecios] ON
GO

SET IDENTITY_INSERT [dbo].[HistorialPrecios] OFF
GO


-- ----------------------------
-- Table structure for IpMaquina
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[IpMaquina]') AND type IN ('U'))
	DROP TABLE [dbo].[IpMaquina]
GO

CREATE TABLE [dbo].[IpMaquina] (
  [IdIpMaquina] int  IDENTITY(1,1) NOT NULL,
  [IdUsuario] int  NOT NULL,
  [IpMaquina] nchar(30) COLLATE Modern_Spanish_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[IpMaquina] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of IpMaquina
-- ----------------------------
SET IDENTITY_INSERT [dbo].[IpMaquina] ON
GO

INSERT INTO [dbo].[IpMaquina] ([IdIpMaquina], [IdUsuario], [IpMaquina]) VALUES (N'1', N'2', N'0A0027000007                  ')
GO

INSERT INTO [dbo].[IpMaquina] ([IdIpMaquina], [IdUsuario], [IpMaquina]) VALUES (N'4', N'2', N'002B674288E7                  ')
GO

INSERT INTO [dbo].[IpMaquina] ([IdIpMaquina], [IdUsuario], [IpMaquina]) VALUES (N'6', N'4', N'3C9509206F3E                  ')
GO

INSERT INTO [dbo].[IpMaquina] ([IdIpMaquina], [IdUsuario], [IpMaquina]) VALUES (N'7', N'3', N'3CA067E46FC7                  ')
GO

SET IDENTITY_INSERT [dbo].[IpMaquina] OFF
GO


-- ----------------------------
-- Table structure for Lotes
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Lotes]') AND type IN ('U'))
	DROP TABLE [dbo].[Lotes]
GO

CREATE TABLE [dbo].[Lotes] (
  [IdCaducidad] int  IDENTITY(1,1) NOT NULL,
  [IdProducto] int  NOT NULL,
  [FechaCaducidad] date  NOT NULL,
  [NumeroLote] nchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [FechaIngreso] date  NOT NULL,
  [CantidadU] decimal(11,2)  NOT NULL,
  [IdCompra] int  NOT NULL,
  [IdSede] int  NOT NULL
)
GO

ALTER TABLE [dbo].[Lotes] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Lotes
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Lotes] ON
GO

SET IDENTITY_INSERT [dbo].[Lotes] OFF
GO


-- ----------------------------
-- Table structure for PrecioActual
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[PrecioActual]') AND type IN ('U'))
	DROP TABLE [dbo].[PrecioActual]
GO

CREATE TABLE [dbo].[PrecioActual] (
  [IdPrecioActual] int  IDENTITY(1,1) NOT NULL,
  [PrecioCompra] decimal(11,2)  NOT NULL,
  [PrecioVenta] decimal(11,2)  NOT NULL,
  [IdProducto] int  NOT NULL,
  [IdSede ] int  NOT NULL,
  [Fecha] date  NOT NULL
)
GO

ALTER TABLE [dbo].[PrecioActual] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of PrecioActual
-- ----------------------------
SET IDENTITY_INSERT [dbo].[PrecioActual] ON
GO

SET IDENTITY_INSERT [dbo].[PrecioActual] OFF
GO


-- ----------------------------
-- Table structure for Producto
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Producto]') AND type IN ('U'))
	DROP TABLE [dbo].[Producto]
GO

CREATE TABLE [dbo].[Producto] (
  [IdProducto] int  IDENTITY(1,1) NOT NULL,
  [Nombre] nchar(30) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [Descripcion] nchar(50) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [Marca] nchar(30) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [Stock] decimal(11,2)  NULL,
  [IdUnidadMedida] int  NOT NULL,
  [IdCategoria] int  NOT NULL,
  [IdEstadoProducto] int  NOT NULL,
  [IdSede] int  NOT NULL,
  [UrlImagen] nchar(100) COLLATE Modern_Spanish_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[Producto] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Producto
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Producto] ON
GO

INSERT INTO [dbo].[Producto] ([IdProducto], [Nombre], [Descripcion], [Marca], [Stock], [IdUnidadMedida], [IdCategoria], [IdEstadoProducto], [IdSede], [UrlImagen]) VALUES (N'3', N'Gramoxon                      ', N'Para quemar sacate                                ', N'Bayer                         ', N'.00', N'2', N'2', N'1', N'1', NULL)
GO

INSERT INTO [dbo].[Producto] ([IdProducto], [Nombre], [Descripcion], [Marca], [Stock], [IdUnidadMedida], [IdCategoria], [IdEstadoProducto], [IdSede], [UrlImagen]) VALUES (N'4', N'Gramoxon                      ', N'Para quemar sacate                                ', N'Sigsa                         ', N'.00', N'2', N'2', N'1', N'1', N'C:\Users\LEGUION 5\Desktop\CLASES LV\PaginaGod\img                                                  ')
GO

INSERT INTO [dbo].[Producto] ([IdProducto], [Nombre], [Descripcion], [Marca], [Stock], [IdUnidadMedida], [IdCategoria], [IdEstadoProducto], [IdSede], [UrlImagen]) VALUES (N'5', N'Fertilizante                  ', N'Probando si guarda                                ', N'De Agua                       ', N'.00', N'7', N'6', N'1', N'1', N'C:/Users/ZELPIC/Downloads/nutriesenciales.jpg                                                       ')
GO

INSERT INTO [dbo].[Producto] ([IdProducto], [Nombre], [Descripcion], [Marca], [Stock], [IdUnidadMedida], [IdCategoria], [IdEstadoProducto], [IdSede], [UrlImagen]) VALUES (N'6', N'dsfsdf                        ', N'sdfsdf                                            ', N'sdfsdf                        ', N'.00', N'1', N'1', N'1', N'1', N'C:/Users/ZELPIC/Desktop/Imagenes/follar.jpg                                                         ')
GO

INSERT INTO [dbo].[Producto] ([IdProducto], [Nombre], [Descripcion], [Marca], [Stock], [IdUnidadMedida], [IdCategoria], [IdEstadoProducto], [IdSede], [UrlImagen]) VALUES (N'7', N'ertret                        ', N'ertert                                            ', N'ertert                        ', N'.00', N'1', N'1', N'1', N'1', N'C:/Users/ZELPIC/Desktop/Imagenes/nutriesenciales.jpg                                                ')
GO

SET IDENTITY_INSERT [dbo].[Producto] OFF
GO


-- ----------------------------
-- Table structure for Proveedor
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Proveedor]') AND type IN ('U'))
	DROP TABLE [dbo].[Proveedor]
GO

CREATE TABLE [dbo].[Proveedor] (
  [IdProveedor] int  IDENTITY(1,1) NOT NULL,
  [NumeroRuc] nchar(30) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [AgenteVentasNom] nchar(30) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [AgenteVentasApe] nchar(30) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [IdTelefonoEmpresa] int  NOT NULL,
  [IdEstado] int  NOT NULL,
  [IdDireccion] int  NOT NULL,
  [IdSede] int  NOT NULL,
  [NombreEmpresa] nchar(30) COLLATE Modern_Spanish_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[Proveedor] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Proveedor
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Proveedor] ON
GO

SET IDENTITY_INSERT [dbo].[Proveedor] OFF
GO


-- ----------------------------
-- Table structure for Sede
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Sede]') AND type IN ('U'))
	DROP TABLE [dbo].[Sede]
GO

CREATE TABLE [dbo].[Sede] (
  [IdSede] int  IDENTITY(1,1) NOT NULL,
  [NombreEmpresa] nchar(30) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [IdDireccion] int  NOT NULL,
  [IdTelefono] int  NOT NULL
)
GO

ALTER TABLE [dbo].[Sede] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Sede
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Sede] ON
GO

INSERT INTO [dbo].[Sede] ([IdSede], [NombreEmpresa], [IdDireccion], [IdTelefono]) VALUES (N'1', N'Jossemar                      ', N'1', N'1')
GO

SET IDENTITY_INSERT [dbo].[Sede] OFF
GO


-- ----------------------------
-- Table structure for Telefono
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Telefono]') AND type IN ('U'))
	DROP TABLE [dbo].[Telefono]
GO

CREATE TABLE [dbo].[Telefono] (
  [IdTelefono] int  IDENTITY(1,1) NOT NULL,
  [IdTipoTel] int  NOT NULL,
  [DescripcionTel] nchar(16) COLLATE Modern_Spanish_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[Telefono] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Telefono
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Telefono] ON
GO

INSERT INTO [dbo].[Telefono] ([IdTelefono], [IdTipoTel], [DescripcionTel]) VALUES (N'1', N'1', N'89482358        ')
GO

SET IDENTITY_INSERT [dbo].[Telefono] OFF
GO


-- ----------------------------
-- Table structure for TipoEmpleado
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[TipoEmpleado]') AND type IN ('U'))
	DROP TABLE [dbo].[TipoEmpleado]
GO

CREATE TABLE [dbo].[TipoEmpleado] (
  [IdTipoEmpleado] int  IDENTITY(1,1) NOT NULL,
  [DescripcionTE] nchar(40) COLLATE Modern_Spanish_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[TipoEmpleado] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of TipoEmpleado
-- ----------------------------
SET IDENTITY_INSERT [dbo].[TipoEmpleado] ON
GO

SET IDENTITY_INSERT [dbo].[TipoEmpleado] OFF
GO


-- ----------------------------
-- Table structure for TipoTel
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[TipoTel]') AND type IN ('U'))
	DROP TABLE [dbo].[TipoTel]
GO

CREATE TABLE [dbo].[TipoTel] (
  [IdTipoTelefono] int  IDENTITY(1,1) NOT NULL,
  [DescripcionTT] nchar(30) COLLATE Modern_Spanish_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[TipoTel] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of TipoTel
-- ----------------------------
SET IDENTITY_INSERT [dbo].[TipoTel] ON
GO

INSERT INTO [dbo].[TipoTel] ([IdTipoTelefono], [DescripcionTT]) VALUES (N'1', N'Movil                         ')
GO

INSERT INTO [dbo].[TipoTel] ([IdTipoTelefono], [DescripcionTT]) VALUES (N'2', N'Fijo                          ')
GO

SET IDENTITY_INSERT [dbo].[TipoTel] OFF
GO


-- ----------------------------
-- Table structure for TipoUsuario
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[TipoUsuario]') AND type IN ('U'))
	DROP TABLE [dbo].[TipoUsuario]
GO

CREATE TABLE [dbo].[TipoUsuario] (
  [IdTipoUsuario] int  IDENTITY(1,1) NOT NULL,
  [DescripcionTU] nchar(30) COLLATE Modern_Spanish_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[TipoUsuario] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of TipoUsuario
-- ----------------------------
SET IDENTITY_INSERT [dbo].[TipoUsuario] ON
GO

INSERT INTO [dbo].[TipoUsuario] ([IdTipoUsuario], [DescripcionTU]) VALUES (N'1', N'Sin Privilegios               ')
GO

INSERT INTO [dbo].[TipoUsuario] ([IdTipoUsuario], [DescripcionTU]) VALUES (N'2', N'MegaAdmin                     ')
GO

INSERT INTO [dbo].[TipoUsuario] ([IdTipoUsuario], [DescripcionTU]) VALUES (N'3', N'Admin                         ')
GO

INSERT INTO [dbo].[TipoUsuario] ([IdTipoUsuario], [DescripcionTU]) VALUES (N'4', N'Asistente                     ')
GO

SET IDENTITY_INSERT [dbo].[TipoUsuario] OFF
GO


-- ----------------------------
-- Table structure for UnidadMedidas
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[UnidadMedidas]') AND type IN ('U'))
	DROP TABLE [dbo].[UnidadMedidas]
GO

CREATE TABLE [dbo].[UnidadMedidas] (
  [IdUnidadM] int  IDENTITY(1,1) NOT NULL,
  [DescripcionTipoUM] nchar(50) COLLATE Modern_Spanish_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[UnidadMedidas] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of UnidadMedidas
-- ----------------------------
SET IDENTITY_INSERT [dbo].[UnidadMedidas] ON
GO

INSERT INTO [dbo].[UnidadMedidas] ([IdUnidadM], [DescripcionTipoUM]) VALUES (N'1', N'Unidad                                            ')
GO

INSERT INTO [dbo].[UnidadMedidas] ([IdUnidadM], [DescripcionTipoUM]) VALUES (N'2', N'Litros                                            ')
GO

INSERT INTO [dbo].[UnidadMedidas] ([IdUnidadM], [DescripcionTipoUM]) VALUES (N'3', N'Cuarto                                            ')
GO

INSERT INTO [dbo].[UnidadMedidas] ([IdUnidadM], [DescripcionTipoUM]) VALUES (N'4', N'Medio                                             ')
GO

INSERT INTO [dbo].[UnidadMedidas] ([IdUnidadM], [DescripcionTipoUM]) VALUES (N'5', N'Galon                                             ')
GO

INSERT INTO [dbo].[UnidadMedidas] ([IdUnidadM], [DescripcionTipoUM]) VALUES (N'6', N'Medio Kilo                                        ')
GO

INSERT INTO [dbo].[UnidadMedidas] ([IdUnidadM], [DescripcionTipoUM]) VALUES (N'7', N'Kilo                                              ')
GO

INSERT INTO [dbo].[UnidadMedidas] ([IdUnidadM], [DescripcionTipoUM]) VALUES (N'8', N'Quintales                                         ')
GO

INSERT INTO [dbo].[UnidadMedidas] ([IdUnidadM], [DescripcionTipoUM]) VALUES (N'9', N'Libras                                            ')
GO

SET IDENTITY_INSERT [dbo].[UnidadMedidas] OFF
GO


-- ----------------------------
-- Table structure for Usuarios
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Usuarios]') AND type IN ('U'))
	DROP TABLE [dbo].[Usuarios]
GO

CREATE TABLE [dbo].[Usuarios] (
  [IdUsuario] int  IDENTITY(1,1) NOT NULL,
  [Nombre] nchar(30) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [Apellido] nchar(30) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [NombreUsuario] nchar(30) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [Pass] nchar(20) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [IdEstadoUsuario] int  NOT NULL,
  [IdTipoUsuario] int  NOT NULL,
  [IdSede] int  NOT NULL
)
GO

ALTER TABLE [dbo].[Usuarios] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Usuarios
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Usuarios] ON
GO

INSERT INTO [dbo].[Usuarios] ([IdUsuario], [Nombre], [Apellido], [NombreUsuario], [Pass], [IdEstadoUsuario], [IdTipoUsuario], [IdSede]) VALUES (N'2', N'Frederick                     ', N'Perez                         ', N'sa                            ', N'123                 ', N'2', N'2', N'1')
GO

INSERT INTO [dbo].[Usuarios] ([IdUsuario], [Nombre], [Apellido], [NombreUsuario], [Pass], [IdEstadoUsuario], [IdTipoUsuario], [IdSede]) VALUES (N'3', N'Dennis                        ', N'Castro                        ', N'CuboSIx                       ', N'123                 ', N'1', N'3', N'1')
GO

INSERT INTO [dbo].[Usuarios] ([IdUsuario], [Nombre], [Apellido], [NombreUsuario], [Pass], [IdEstadoUsuario], [IdTipoUsuario], [IdSede]) VALUES (N'4', N'Glen                          ', N'Johan                         ', N'Patience4K                    ', N'123                 ', N'2', N'3', N'1')
GO

SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO


-- ----------------------------
-- View structure for vs_Productos
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[vs_Productos]') AND type IN ('V'))
	DROP VIEW [dbo].[vs_Productos]
GO

CREATE VIEW [dbo].[vs_Productos] AS SELECT
	Producto.IdProducto, 
	Producto.Nombre, 
	Producto.Descripcion, 
	Producto.Marca, 
	Producto.Stock, 
	Producto.IdUnidadMedida, 
	UnidadMedidas.DescripcionTipoUM, 
	Producto.IdCategoria, 
	Categoria.DescripcionC, 
	Producto.IdEstadoProducto, 
	EstadoProducto.DescripcionEP, 
	Producto.IdSede
FROM
	dbo.Producto
	INNER JOIN
	dbo.UnidadMedidas
	ON 
		Producto.IdUnidadMedida = UnidadMedidas.IdUnidadM
	INNER JOIN
	dbo.Categoria
	ON 
		Producto.IdCategoria = Categoria.IdCategoria
	INNER JOIN
	dbo.EstadoProducto
	ON 
		Producto.IdEstadoProducto = EstadoProducto.IdEstadoProducto
GO


-- ----------------------------
-- View structure for vs_Usuarios
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[vs_Usuarios]') AND type IN ('V'))
	DROP VIEW [dbo].[vs_Usuarios]
GO

CREATE VIEW [dbo].[vs_Usuarios] AS SELECT
	Usuarios.IdUsuario, 
	Usuarios.Nombre, 
	Usuarios.Apellido, 
	Usuarios.NombreUsuario, 
	Usuarios.Pass, 
	Usuarios.IdEstadoUsuario, 
	Usuarios.IdTipoUsuario, 
	TipoUsuario.DescripcionTU, 
	Usuarios.IdSede
FROM
	dbo.Usuarios
	INNER JOIN
	dbo.TipoUsuario
	ON 
		Usuarios.IdTipoUsuario = TipoUsuario.IdTipoUsuario
GO


-- ----------------------------
-- procedure structure for JSMAgregarPrecioActual
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[JSMAgregarPrecioActual]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[JSMAgregarPrecioActual]
GO

CREATE PROCEDURE [dbo].[JSMAgregarPrecioActual]
@PrecioCompra AS decimal(11,2),
@PrecioVenta AS decimal(11,2),
@IdProducto AS int,
@IdSede AS int,
@Result AS nvarchar(10) OUTPUT
AS
BEGIN

INSERT dbo.PrecioActual(PrecioCompra,PrecioVenta,IdProducto,IdSede, Fecha)
VALUES(@PrecioCompra,@PrecioVenta,@IdProducto,@IdSede, GETDATE());

SET @Result = '0';

UPDATE dbo.PrecioActual SET PrecioActual.PrecioCompra = @PrecioCompra, PrecioActual.PrecioVenta = @PrecioVenta WHERE PrecioActual.IdProducto = @IdProducto;
END
GO


-- ----------------------------
-- procedure structure for JSMAgregarProducto
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[JSMAgregarProducto]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[JSMAgregarProducto]
GO

CREATE PROCEDURE [dbo].[JSMAgregarProducto]
@Nombre AS nvarchar(30),
@Descripcion AS nvarchar(50),
@Marca AS nvarchar(30),
@Stock as decimal(11,2),
@IdUnidadM AS int,
@IdCategoria AS int,
@IdSede as int,
@UrlImagen as nvarchar(255),
@Result as int OUTPUT
AS
BEGIN

DECLARE @ExistenciaP AS int;
 
set @ExistenciaP = (SELECT COUNT(*) FROM dbo.Producto WHERE UPPER (Nombre) = UPPER(@Nombre) AND UPPER(Marca) = UPPER(@Marca) AND UPPER(IdSede) = UPPER(@IdSede));

IF @ExistenciaP = 0 BEGIN

INSERT dbo.Producto(Nombre,Descripcion,Marca,Stock,IdUnidadMedida,IdCategoria,IdEstadoProducto,IdSede, UrlImagen)
VALUES(@Nombre,@Descripcion,@Marca,@Stock,@IdUnidadM,@IdCategoria,1,@IdSede,@UrlImagen);

SET @Result = 0; /*Retornamos 0 para saber que se guardó correctamente*/
END

IF @ExistenciaP = 1 BEGIN
SET @Result = 1; /*Retornamos 1 para saber que no se guardó correctamente*/
END
END
GO


-- ----------------------------
-- procedure structure for JSMAgregarCaducidad
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[JSMAgregarCaducidad]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[JSMAgregarCaducidad]
GO

CREATE PROCEDURE [dbo].[JSMAgregarCaducidad]
@IdProducto AS int,
@FCaducidad AS date,
@Result as int OUTPUT
AS
BEGIN
INSERT dbo.Caducidad(IdProducto,FechaCaducidad)
VALUES(@IdProducto,@FCaducidad);

SET @Result  = 1; /*Para saber que se guardo*/
END
GO


-- ----------------------------
-- procedure structure for JSMAgregarHistorialPrecio
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[JSMAgregarHistorialPrecio]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[JSMAgregarHistorialPrecio]
GO

CREATE PROCEDURE [dbo].[JSMAgregarHistorialPrecio]
@PrecioC AS decimal(11,2),
@PrecioV AS decimal(11,2),
@IdProducto AS int,
@FechaR AS date,
@Result as int OUTPUT
AS
BEGIN

INSERT dbo.HistorialPrecios(PrecioCompra,PrecioVenta,IdProducto,Fecha)
VALUES(@PrecioC,@PrecioV,@IdProducto,@FechaR);

SET @Result  = 1; /*Para saber que se guardo*/
END
GO


-- ----------------------------
-- procedure structure for JSMAgregarCompra
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[JSMAgregarCompra]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[JSMAgregarCompra]
GO

CREATE PROCEDURE [dbo].[JSMAgregarCompra]
@NFactura AS nvarchar(30),
@IdUsuario AS int,
@IdProveedor As int,
@FechaIngreso as date,
@Subt AS decimal(11,2),
@Total AS decimal(11,2),
@Descuento AS decimal(11,2),
@IdSede AS int,
@Result as int OUTPUT
AS
BEGIN

INSERT dbo.Compra(NFactura,IdUsuario,IdProveedor,FechaIngreso,Subtotal,Total,Descuento,IdSede)
VALUES(@NFactura,@IdUsuario,@IdProveedor,@FechaIngreso,@Subt,@Total,@Descuento,@IdSede);

SET @Result = 0; 
END
GO


-- ----------------------------
-- procedure structure for JSMAgregarSede
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[JSMAgregarSede]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[JSMAgregarSede]
GO

CREATE PROCEDURE [dbo].[JSMAgregarSede]
@NombreEmpresa as nvarchar(30),
@Direccion as nvarchar(60),
@TelefonoNum as nvarchar(8),
@TipoTel as nvarchar(20),
@Result as nvarchar(15) OUTPUT
AS
BEGIN

DECLARE @IdDireccion as int;
DECLARE @IdTelefono as int;

INSERT Direccion(DescripcionDir)
VALUES(@Direccion);

SET @IdDireccion =  (SELECT MAX(dbo.Direccion.IdDireccion)From Direccion)

INSERT Telefono(DescripcionTel, IdTipoTel)
VALUES (@TelefonoNum, @TipoTel);

SET @IdTelefono = (SELECT MAX(dbo.Telefono.IdTelefono)From Telefono)

INSERT dbo.Sede(NombreEmpresa,IdDireccion, IdTelefono)
VALUES(@NombreEmpresa, @IdDireccion, @IdTelefono);

SET @Result = 'S'
END
GO


-- ----------------------------
-- procedure structure for JSMAgregarProveedores
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[JSMAgregarProveedores]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[JSMAgregarProveedores]
GO

CREATE PROCEDURE [dbo].[JSMAgregarProveedores]
@NumeroRuc as nvarchar(30),
@AgenteVentasNom as nvarchar(30),
@AgenteVentasApe as nvarchar(30),
@NombreEmpresa as nvarchar(30),
@Direccion as nvarchar(60),
@TelefonoEmpresa as nvarchar(8),
@IdTipoTelefonoE as int,
@IdSede as int,
@Result as nvarchar(10)
AS
BEGIN
DECLARE @IdDireccion as int;
DECLARE @IdTelefonoEmpresa as int;
DECLARE @Exist as int;
DECLARE @ExistTel as int;
DECLARE @IdEstado AS int;
SET @IdEstado = 1;

SET @Exist = (SELECT COUNT(*) FROM dbo.Proveedor WHERE UPPER (NombreEmpresa) = UPPER(@NombreEmpresa));

IF @Exist = 0 BEGIN

DECLARE @Ult as int;
DECLARE @Ult2 as int;

INSERT dbo.Direccion(DescripcionDir)
VALUES(@Direccion);

SET @IdDireccion = (SELECT MAX(dbo.Direccion.IdDireccion)From Direccion)

SET @ExistTel = (SELECT COUNT(*) FROM dbo.Telefono.IdTelefono WHERE UPPER (DescripcionTel) = UPPER(@TelefonoEmpresa));

IF @ExistTel = 0 BEGIN
INSERT dbo.Telefono(IdTipoTel,DescripcionTel)
VALUES(@IdTipoTelefonoE,@TelefonoEmpresa);

SET @IdTelefonoEmpresa = (SELECT MAX(dbo.Telefono.IdTelefono)From Telefono)
END


SET @Ult = (SELECT MAX(dbo.Proveedor.IdProveedor) FROM Proveedor);

INSERT dbo.Proveedor(NumeroRuc,AgenteVentasNom,AgenteVentasApe, IdTelefonoEmpresa,IdEstado, IdDireccion, IdSede,NombreEmpresa)
VALUES (@NumeroRuc,@AgenteVentasNom,@AgenteVentasApe,@IdTelefonoEmpresa,1,@IdDireccion,@IdSede,@NombreEmpresa);

SET @Ult2 = (SELECT MAX(dbo.Proveedor.IdProveedor) FROM Proveedor);

IF @Ult < @Ult2 BEGIN
SET @Result = 'G';
END

IF @Ult = @Ult2 BEGIN
SET @Result = 'N';
END

END

IF @Exist > 0 BEGIN
SET @Result = 'E';
END

END
GO


-- ----------------------------
-- procedure structure for JSMAgregarEmpleados
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[JSMAgregarEmpleados]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[JSMAgregarEmpleados]
GO

CREATE PROCEDURE [dbo].[JSMAgregarEmpleados]
@IdTipoEmpleado as int,
@Cedula as nvarchar(16),
@Nombre as nvarchar(30),
@Apellido as nvarchar(30),
@Telefono as nvarchar(8),
@IdTipoTel as int,
@Direccion as nvarchar(60),
@IdSede as int,
@Result as nvarchar(15) OUTPUT
AS
BEGIN
DECLARE @ExistenciaE as int;
DECLARE @IdDireccion AS int;
DECLARE  @IdTelefono AS int;
DECLARE @IdTipoUsuario as int;
DECLARE @ExistenciaTel as int;
DECLARE @ExistenciaDireccion as int;
DECLARE @IdEstadoEmpleado AS int;
SET @IdEstadoEmpleado  = 1;
/*-----------------------------EMPLEADOS----------------------------------------------------*/
set @ExistenciaE= (SELECT COUNT(*) FROM dbo.Empleados WHERE UPPER (CedulaE) = UPPER(@Cedula));

IF @ExistenciaE = 0 BEGIN

SET @ExistenciaTel = (SELECT COUNT(*) FROM dbo.Telefono WHERE UPPER (DescripcionTel) = UPPER(@Telefono));

IF  @ExistenciaTel = 0 BEGIN
INSERT dbo.Telefono(IdTipoTel, DescripcionTel)
VALUES(@IdTipoTel,@Telefono);

SET @IdTelefono =  (SELECT MAX(dbo.Telefono.IdTelefono)From Telefono)

/*SET @ExistenciaDireccion = (SELECT COUNT(*) FROM dbo.Direccion WHERE UPPER (DescripcionDir) = UPPER(@Direccion));

IF @ExistenciaDireccion = 0 BEGIN*/
INSERT dbo.Direccion(DescripcionDir)
VALUES(@Direccion);

SET @IdDireccion =  (SELECT MAX(dbo.Direccion.IdDireccion)From Direccion)

INSERT Empleados(IdTipoEmpleado,CedulaE, Nombre, Apellido, IdTelefono, IdDireccion,IdEstadoEmpleado,IdSede)
VALUES(@IdTipoEmpleado,@Cedula,@Nombre,@Apellido,@IdTelefono,@IdDireccion,@IdEstadoEmpleado,@IdSede);


SET @Result = 'G';
END
END

IF @ExistenciaTel >=1 BEGIN
SET @Result = 'T';
END

IF @ExistenciaE >=1 BEGIN
SET @Result = 'N';
END
END
GO


-- ----------------------------
-- procedure structure for JSMIniciarSesion
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[JSMIniciarSesion]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[JSMIniciarSesion]
GO

CREATE PROCEDURE [dbo].[JSMIniciarSesion]
@UserName as nvarchar(20),
@Password as nvarchar(20),
@ipMaquina as nvarchar(30),
@Result as nvarchar(15) Output
AS
BEGIN
DECLARE @reg AS int;
DECLARE @idUsuario AS int;
DECLARE @Estado as int;
DECLARE @TipoU as int;
DECLARE @ipM as int;
DECLARE @Existencia as int;
DECLARE @Existencia2 as int;
	
	SET @Existencia = (SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario = @UserName AND Usuarios.Pass = @Password);
	SET @ipM =(SELECT COUNT(*) FROM IpMaquina WHERE IpMaquina.IpMaquina = @ipMaquina);
	
	SET @Estado = (SELECT Usuarios.IdEstadoUsuario FROM Usuarios WHERE NombreUsuario = @UserName AND Pass = @Password);
	/**/
  SET @TipoU = (SELECT Usuarios.IdTipoUsuario FROM Usuarios WHERE  NombreUsuario = @UserName AND Pass = @Password);
	
	
	IF @Estado = 1 BEGIN
	
	IF @Existencia = 1 BEGIN
	/*SE PROCEDE A VERIFICAR QUE SUS CREDENCIALES TENGAN LOS PERMISOS NECESARIOS PARA INICIAR SESIÓN*/
	
		IF @Estado = 1 BEGIN
		SET @idUsuario = (SELECT Usuarios.IdUsuario FROM Usuarios WHERE  NombreUsuario = @UserName AND Pass = @Password);
		UPDATE dbo.Usuarios SET Usuarios.IdEstadoUsuario = 2 WHERE idUsuario = @idUsuario;
		END
		IF @TipoU = 1 BEGIN
		SET @Result = 'F';
		END
		IF @TipoU = 2 BEGIN
		SET @Result = 'S';
		
		IF @ipM = 0 BEGIN
		INSERT INTO dbo.IpMaquina(IpMaquina.IdUsuario,IpMaquina.IpMaquina) VALUES(@idUsuario,@ipMaquina)
		END 
		
		END
		IF @TipoU = 3 BEGIN
		SET @Result = 'A';
		
		IF @ipM = 0 BEGIN
		INSERT INTO dbo.IpMaquina(IpMaquina.IdUsuario,IpMaquina.IpMaquina) VALUES(@idUsuario,@ipMaquina)
		END 
		
		END
		IF @TipoU = 4 BEGIN
		SET @Result = 'Q';
		
		IF @ipM = 0 BEGIN
		INSERT INTO dbo.IpMaquina(IpMaquina.IdUsuario,IpMaquina.IpMaquina) VALUES(@idUsuario,@ipMaquina)
		END 
		
		END
			
			END/**/

	END
	IF @Existencia = 0 BEGIN
		SET @Result = 'E';
	END 
		
		IF @ipM = 1 BEGIN
		SET @Result = 'O';
	END 
	
		IF @Estado = 2 BEGIN
		SET @Result = 'R';
		END
	
		
		IF @Estado = 3 BEGIN
		SET @Result = 'T';
		END
	
		IF @Estado = 4 BEGIN
		SET @Result = 'Z';
		END
		
		
		IF @TipoU = 1 BEGIN
		SET @Result = 'U';
		END
		
END
GO


-- ----------------------------
-- procedure structure for JSMAgregarClientes
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[JSMAgregarClientes]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[JSMAgregarClientes]
GO

CREATE PROCEDURE [dbo].[JSMAgregarClientes]
@NombreCli AS nvarchar(60),
@ApellidoCli AS nvarchar(60),
@TipoCliente AS nvarchar(15),
@Telefono AS nvarchar(15),
@IdTipoTel AS int,
@Direccion AS nvarchar(15),
@Cedula AS nvarchar(16),
@IdSede AS int,
@ult AS int OUTPUT
AS
BEGIN

DECLARE @ult1 AS int;
DECLARE @Exist AS int;
DECLARE @IdTelefono AS int;
DECLARE @IdDireccion AS int;

DECLARE @IdEstadoCredito AS int;
DECLARE @IdEstadoCliente AS int;

SET @ult1 = (SELECT MAX(dbo.Clientes.IdClientes)From Clientes)
SET @Exist = (SELECT COUNT(*) FROM dbo.Clientes WHERE UPPER(Cedula) = UPPER(@Cedula));

IF @Exist = 0 BEGIN

SET @IdEstadoCredito = 1;
SET @IdEstadoCliente = 1;

INSERT dbo.Telefono(IdTipoTel,DescripcionTel)
VALUES(@IdTipoTel,@Telefono);

SET @IdTelefono = (SELECT MAX(dbo.Telefono.IdTelefono)FROM Telefono)

INSERT dbo.Direccion(DescripcionDir)
VALUES(@Direccion);

SET @IdDireccion = (SELECT MAX(dbo.Direccion.IdDireccion)FROM Direccion)

INSERT dbo.Clientes(NombreCli, ApellidoCli, TipoCliente, IdTelefono,IdDireccion,Cedula,IdEstadoCliente, IdEstadoCredito, IdSede)
VALUES(@NombreCli,@ApellidoCli,@TipoCliente,@IdTelefono,@IdDireccion,@Cedula,@IdEstadoCliente,@IdEstadoCredito,@IdSede);

SET @ult = 0; /*SE RETORNA <0> PARA SABER QUE SE GUARDO EN LA TABLA*/
END

IF @Exist = 1 BEGIN
SET @ult = 1;/*SE RETORNA <1> PARA SABER QUE NO SE GUARDO EN LA TABLA*/
END

END
GO


-- ----------------------------
-- procedure structure for JSMAgregarUsuarios
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[JSMAgregarUsuarios]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[JSMAgregarUsuarios]
GO

CREATE PROCEDURE [dbo].[JSMAgregarUsuarios]
@Nombre AS nvarchar(30),
@Apellido AS nvarchar(30),
@UserName AS nvarchar(30),
@Password AS nvarchar(30),
@IdSede AS nvarchar(30),
@Result AS nvarchar(60) OUTPUT
AS
BEGIN

DECLARE @Estado as int;
DECLARE @Tipo as int;
DECLARE @Existencia as int;

SET @Estado = 4;
SET @Tipo = 1;

SET @Existencia = (SELECT COUNT(*) from Usuarios where UPPER(NombreUsuario) = UPPER(@UserName));

IF @Existencia = 0 BEGIN

INSERT dbo.Usuarios(Nombre,Apellido,NombreUsuario,Usuarios.Pass,Usuarios.IdEstadoUsuario,Usuarios.IdTipoUsuario,IdSede)
VALUES(@Nombre,@Apellido,@UserName,@Password,@Estado,@Tipo,@IdSede);
SET @Result = 'S'; /*SAVE*/

END

IF @Existencia = 1 BEGIN
SET @Result = 'N';/*NO SAVE*/
END
END
GO


-- ----------------------------
-- procedure structure for JSMAsignarPrivilegios
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[JSMAsignarPrivilegios]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[JSMAsignarPrivilegios]
GO

CREATE PROCEDURE [dbo].[JSMAsignarPrivilegios]
@NombreU as nvarchar(30),
@IdPrivi as int,
@Result as nvarchar(10) OUTPUT
AS
BEGIN

DECLARE @Exis as int;
SET @Exis = (SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario = @NombreU);

	IF @Exis > 0 BEGIN
	
	UPDATE dbo.Usuarios SET Usuarios.IdTipoUsuario = @IdPrivi WHERE Usuarios.NombreUsuario = @NombreU;
	UPDATE dbo.Usuarios SET Usuarios.IdEstadoUsuario = 1 WHERE Usuarios.NombreUsuario = @NombreU;
	
	SET @Result = 'G'; /*SAVE*/
	
	END
	
	IF @Exis = 0 BEGIN
	
	SET @Result = 'N'; /*NO SAVE*/
	
	END
END
GO


-- ----------------------------
-- procedure structure for JSMAgregarLotes
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[JSMAgregarLotes]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[JSMAgregarLotes]
GO

CREATE PROCEDURE [dbo].[JSMAgregarLotes]
@IdProducto AS int,
@FechaCaducidad AS date,
@NumeroLote AS nvarchar(30),
@FechaIngreso AS date,
@CantidadU AS decimal(11,2),
@IdCompra AS int,
@IdSede AS int,
@Result AS nvarchar(10) OUTPUT
AS
BEGIN

INSERT dbO.Lotes(IdProducto,FechaCaducidad,NumeroLote,FechaIngreso,CantidadU,IdCompra,IdSede)
VALUES(@IdProducto,@FechaCaducidad,@NumeroLote,@FechaIngreso,@CantidadU,@IdCompra,@IdSede);

SET @Result = '0';
END
GO


-- ----------------------------
-- procedure structure for JSMDetalleCompra
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[JSMDetalleCompra]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[JSMDetalleCompra]
GO

CREATE PROCEDURE [dbo].[JSMDetalleCompra]
@IdCompra AS int,
@IdProducto AS int,
@Cantidad AS decimal(11,2),
@PrecioCompra AS decimal(11,2),
@PrecioVenta AS decimal(11,2),
@Result AS nvarchar(10) OUTPUT
AS
BEGIN

INSERT dbo.DetalleCompra(IdCompra,IdProducto,Cantidad,PrecioCompra,PrecioVenta)
VALUES(@IdCompra,@IdProducto,@Cantidad,@PrecioCompra,@PrecioVenta);

SET @Result = '0';
END
GO


-- ----------------------------
-- Auto increment value for Categoria
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Categoria]', RESEED, 7)
GO


-- ----------------------------
-- Primary Key structure for table Categoria
-- ----------------------------
ALTER TABLE [dbo].[Categoria] ADD CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED ([IdCategoria])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for Clientes
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Clientes]', RESEED, 1)
GO


-- ----------------------------
-- Primary Key structure for table Clientes
-- ----------------------------
ALTER TABLE [dbo].[Clientes] ADD CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED ([Idclientes])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for Compra
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Compra]', RESEED, 1)
GO


-- ----------------------------
-- Primary Key structure for table Compra
-- ----------------------------
ALTER TABLE [dbo].[Compra] ADD CONSTRAINT [PK_Compra] PRIMARY KEY CLUSTERED ([IdCompra])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table DetalleCompra
-- ----------------------------
ALTER TABLE [dbo].[DetalleCompra] ADD CONSTRAINT [PK__CompraPr__1AC4527D23F6500C] PRIMARY KEY CLUSTERED ([IdCompra], [IdProducto])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for Direccion
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Direccion]', RESEED, 1)
GO


-- ----------------------------
-- Primary Key structure for table Direccion
-- ----------------------------
ALTER TABLE [dbo].[Direccion] ADD CONSTRAINT [PK_Direccion] PRIMARY KEY CLUSTERED ([IdDireccion])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for Empleados
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Empleados]', RESEED, 1)
GO


-- ----------------------------
-- Primary Key structure for table Empleados
-- ----------------------------
ALTER TABLE [dbo].[Empleados] ADD CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED ([IdEmpleado])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for EstadoCliente
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[EstadoCliente]', RESEED, 3)
GO


-- ----------------------------
-- Primary Key structure for table EstadoCliente
-- ----------------------------
ALTER TABLE [dbo].[EstadoCliente] ADD CONSTRAINT [PK_EstadoCliente] PRIMARY KEY CLUSTERED ([IdEstadoCliente])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for EstadoCredito
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[EstadoCredito]', RESEED, 2)
GO


-- ----------------------------
-- Primary Key structure for table EstadoCredito
-- ----------------------------
ALTER TABLE [dbo].[EstadoCredito] ADD CONSTRAINT [PK_EstadoCredito] PRIMARY KEY CLUSTERED ([IdEstadoCredito])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for EstadoEmpleado
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[EstadoEmpleado]', RESEED, 1)
GO


-- ----------------------------
-- Primary Key structure for table EstadoEmpleado
-- ----------------------------
ALTER TABLE [dbo].[EstadoEmpleado] ADD CONSTRAINT [PK_EstadoEmpleado] PRIMARY KEY CLUSTERED ([IdEstadoEmpleado])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for EstadoProducto
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[EstadoProducto]', RESEED, 2)
GO


-- ----------------------------
-- Primary Key structure for table EstadoProducto
-- ----------------------------
ALTER TABLE [dbo].[EstadoProducto] ADD CONSTRAINT [PK_EstadoProducto] PRIMARY KEY CLUSTERED ([IdEstadoProducto])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for EstadoProveedor
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[EstadoProveedor]', RESEED, 2)
GO


-- ----------------------------
-- Primary Key structure for table EstadoProveedor
-- ----------------------------
ALTER TABLE [dbo].[EstadoProveedor] ADD CONSTRAINT [PK_EstadoProveedor] PRIMARY KEY CLUSTERED ([IdEstadoProv])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for EstadoUsuario
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[EstadoUsuario]', RESEED, 4)
GO


-- ----------------------------
-- Primary Key structure for table EstadoUsuario
-- ----------------------------
ALTER TABLE [dbo].[EstadoUsuario] ADD CONSTRAINT [PK_EstadoUsuario] PRIMARY KEY CLUSTERED ([IdEstadoUsuario])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for HistorialPrecios
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[HistorialPrecios]', RESEED, 1)
GO


-- ----------------------------
-- Primary Key structure for table HistorialPrecios
-- ----------------------------
ALTER TABLE [dbo].[HistorialPrecios] ADD CONSTRAINT [PK_HistorialPrecios] PRIMARY KEY CLUSTERED ([IdHistorialPrecios])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for IpMaquina
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[IpMaquina]', RESEED, 7)
GO


-- ----------------------------
-- Primary Key structure for table IpMaquina
-- ----------------------------
ALTER TABLE [dbo].[IpMaquina] ADD CONSTRAINT [PK_IpMaquina] PRIMARY KEY CLUSTERED ([IdIpMaquina])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for Lotes
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Lotes]', RESEED, 1)
GO


-- ----------------------------
-- Primary Key structure for table Lotes
-- ----------------------------
ALTER TABLE [dbo].[Lotes] ADD CONSTRAINT [PK_Caducidad] PRIMARY KEY CLUSTERED ([IdCaducidad])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for PrecioActual
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[PrecioActual]', RESEED, 1)
GO


-- ----------------------------
-- Primary Key structure for table PrecioActual
-- ----------------------------
ALTER TABLE [dbo].[PrecioActual] ADD CONSTRAINT [PK_PrecioActual] PRIMARY KEY CLUSTERED ([IdPrecioActual])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for Producto
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Producto]', RESEED, 7)
GO


-- ----------------------------
-- Primary Key structure for table Producto
-- ----------------------------
ALTER TABLE [dbo].[Producto] ADD CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED ([IdProducto])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for Proveedor
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Proveedor]', RESEED, 1)
GO


-- ----------------------------
-- Primary Key structure for table Proveedor
-- ----------------------------
ALTER TABLE [dbo].[Proveedor] ADD CONSTRAINT [PK_Proveedor] PRIMARY KEY CLUSTERED ([IdProveedor])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for Sede
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Sede]', RESEED, 1)
GO


-- ----------------------------
-- Primary Key structure for table Sede
-- ----------------------------
ALTER TABLE [dbo].[Sede] ADD CONSTRAINT [PK_Sede] PRIMARY KEY CLUSTERED ([IdSede])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for Telefono
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Telefono]', RESEED, 1)
GO


-- ----------------------------
-- Primary Key structure for table Telefono
-- ----------------------------
ALTER TABLE [dbo].[Telefono] ADD CONSTRAINT [PK_Telefono] PRIMARY KEY CLUSTERED ([IdTelefono])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for TipoEmpleado
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[TipoEmpleado]', RESEED, 1)
GO


-- ----------------------------
-- Primary Key structure for table TipoEmpleado
-- ----------------------------
ALTER TABLE [dbo].[TipoEmpleado] ADD CONSTRAINT [PK_TipoEmpleado] PRIMARY KEY CLUSTERED ([IdTipoEmpleado])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for TipoTel
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[TipoTel]', RESEED, 2)
GO


-- ----------------------------
-- Primary Key structure for table TipoTel
-- ----------------------------
ALTER TABLE [dbo].[TipoTel] ADD CONSTRAINT [PK_TipoTel] PRIMARY KEY CLUSTERED ([IdTipoTelefono])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for TipoUsuario
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[TipoUsuario]', RESEED, 4)
GO


-- ----------------------------
-- Primary Key structure for table TipoUsuario
-- ----------------------------
ALTER TABLE [dbo].[TipoUsuario] ADD CONSTRAINT [PK_TipoUsuario] PRIMARY KEY CLUSTERED ([IdTipoUsuario])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for UnidadMedidas
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[UnidadMedidas]', RESEED, 9)
GO


-- ----------------------------
-- Primary Key structure for table UnidadMedidas
-- ----------------------------
ALTER TABLE [dbo].[UnidadMedidas] ADD CONSTRAINT [PK_UnidadMedidas] PRIMARY KEY CLUSTERED ([IdUnidadM])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for Usuarios
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Usuarios]', RESEED, 4)
GO


-- ----------------------------
-- Primary Key structure for table Usuarios
-- ----------------------------
ALTER TABLE [dbo].[Usuarios] ADD CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED ([IdUsuario])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Foreign Keys structure for table Clientes
-- ----------------------------
ALTER TABLE [dbo].[Clientes] ADD CONSTRAINT [FK__Clientes__IdTele__48CFD27E] FOREIGN KEY ([IdTelefono]) REFERENCES [dbo].[Telefono] ([IdTelefono]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[Clientes] ADD CONSTRAINT [FK__Clientes__IdDire__49C3F6B7] FOREIGN KEY ([IdDireccion]) REFERENCES [dbo].[Direccion] ([IdDireccion]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[Clientes] ADD CONSTRAINT [FK__Clientes__IdEsta__4E88ABD4] FOREIGN KEY ([IdEstadoCliente]) REFERENCES [dbo].[EstadoCliente] ([IdEstadoCliente]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[Clientes] ADD CONSTRAINT [FK__Clientes__IdEsta__4F7CD00D] FOREIGN KEY ([IdEstadoCredito]) REFERENCES [dbo].[EstadoCredito] ([IdEstadoCredito]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[Clientes] ADD CONSTRAINT [FK__Clientes__IdSede__5FB337D6] FOREIGN KEY ([IdSede]) REFERENCES [dbo].[Sede] ([IdSede]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table DetalleCompra
-- ----------------------------
ALTER TABLE [dbo].[DetalleCompra] ADD CONSTRAINT [FK__CompraPro__IdCom__0E6E26BF] FOREIGN KEY ([IdCompra]) REFERENCES [dbo].[Compra] ([IdCompra]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[DetalleCompra] ADD CONSTRAINT [FK__CompraPro__IdPro__0F624AF8] FOREIGN KEY ([IdProducto]) REFERENCES [dbo].[Producto] ([IdProducto]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table Empleados
-- ----------------------------
ALTER TABLE [dbo].[Empleados] ADD CONSTRAINT [FK__Empleados__IdTip__3E52440B] FOREIGN KEY ([IdTipoEmpleado]) REFERENCES [dbo].[TipoEmpleado] ([IdTipoEmpleado]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[Empleados] ADD CONSTRAINT [FK__Empleados__IdTel__3F466844] FOREIGN KEY ([IdTelefono]) REFERENCES [dbo].[Telefono] ([IdTelefono]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[Empleados] ADD CONSTRAINT [FK__Empleados__IdDir__403A8C7D] FOREIGN KEY ([IdDireccion]) REFERENCES [dbo].[Direccion] ([IdDireccion]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[Empleados] ADD CONSTRAINT [FK__Empleados__IdEst__412EB0B6] FOREIGN KEY ([IdEstadoEmpleado]) REFERENCES [dbo].[EstadoEmpleado] ([IdEstadoEmpleado]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[Empleados] ADD CONSTRAINT [FK__Empleados__IdSed__4222D4EF] FOREIGN KEY ([IdSede]) REFERENCES [dbo].[Sede] ([IdSede]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table HistorialPrecios
-- ----------------------------
ALTER TABLE [dbo].[HistorialPrecios] ADD CONSTRAINT [FK__Historial__IdSed__01142BA1] FOREIGN KEY ([IdSede]) REFERENCES [dbo].[Sede] ([IdSede]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[HistorialPrecios] ADD CONSTRAINT [FK__Historial__IdPro__05D8E0BE] FOREIGN KEY ([IdProducto]) REFERENCES [dbo].[Producto] ([IdProducto]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table Lotes
-- ----------------------------
ALTER TABLE [dbo].[Lotes] ADD CONSTRAINT [FK__Caducidad__IdPro__03F0984C] FOREIGN KEY ([IdProducto]) REFERENCES [dbo].[Producto] ([IdProducto]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[Lotes] ADD CONSTRAINT [FK__Caducidad__IdCom__7B5B524B] FOREIGN KEY ([IdCompra]) REFERENCES [dbo].[Compra] ([IdCompra]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[Lotes] ADD CONSTRAINT [FK__Lotes__IdSede__7F2BE32F] FOREIGN KEY ([IdSede]) REFERENCES [dbo].[Sede] ([IdSede]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table PrecioActual
-- ----------------------------
ALTER TABLE [dbo].[PrecioActual] ADD CONSTRAINT [FK__PrecioAct__IdPro__04E4BC85] FOREIGN KEY ([IdProducto]) REFERENCES [dbo].[Producto] ([IdProducto]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table Producto
-- ----------------------------
ALTER TABLE [dbo].[Producto] ADD CONSTRAINT [FK__Producto__IdUnid__7A672E12] FOREIGN KEY ([IdUnidadMedida]) REFERENCES [dbo].[UnidadMedidas] ([IdUnidadM]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[Producto] ADD CONSTRAINT [FK__Producto__IdCate__7B5B524B] FOREIGN KEY ([IdCategoria]) REFERENCES [dbo].[Categoria] ([IdCategoria]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[Producto] ADD CONSTRAINT [FK__Producto__IdEsta__7C4F7684] FOREIGN KEY ([IdEstadoProducto]) REFERENCES [dbo].[EstadoProducto] ([IdEstadoProducto]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[Producto] ADD CONSTRAINT [FK__Producto__IdSede__7D439ABD] FOREIGN KEY ([IdSede]) REFERENCES [dbo].[Sede] ([IdSede]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table Proveedor
-- ----------------------------
ALTER TABLE [dbo].[Proveedor] ADD CONSTRAINT [FK__Proveedor__IdTel__4316F928] FOREIGN KEY ([IdTelefonoEmpresa]) REFERENCES [dbo].[Telefono] ([IdTelefono]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[Proveedor] ADD CONSTRAINT [FK__Proveedor__IdEst__440B1D61] FOREIGN KEY ([IdEstado]) REFERENCES [dbo].[EstadoProveedor] ([IdEstadoProv]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[Proveedor] ADD CONSTRAINT [FK__Proveedor__IdDir__44FF419A] FOREIGN KEY ([IdDireccion]) REFERENCES [dbo].[Direccion] ([IdDireccion]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[Proveedor] ADD CONSTRAINT [FK__Proveedor__IdSed__45F365D3] FOREIGN KEY ([IdSede]) REFERENCES [dbo].[Sede] ([IdSede]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table Sede
-- ----------------------------
ALTER TABLE [dbo].[Sede] ADD CONSTRAINT [FK__Sede__IdDireccio__5AEE82B9] FOREIGN KEY ([IdDireccion]) REFERENCES [dbo].[Direccion] ([IdDireccion]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[Sede] ADD CONSTRAINT [FK__Sede__IdTelefono__5BE2A6F2] FOREIGN KEY ([IdTelefono]) REFERENCES [dbo].[Telefono] ([IdTelefono]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table Telefono
-- ----------------------------
ALTER TABLE [dbo].[Telefono] ADD CONSTRAINT [FK__Telefono__IdTipo__3C69FB99] FOREIGN KEY ([IdTipoTel]) REFERENCES [dbo].[TipoTel] ([IdTipoTelefono]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table Usuarios
-- ----------------------------
ALTER TABLE [dbo].[Usuarios] ADD CONSTRAINT [FK__Usuarios__IdEsta__37A5467C] FOREIGN KEY ([IdEstadoUsuario]) REFERENCES [dbo].[EstadoUsuario] ([IdEstadoUsuario]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[Usuarios] ADD CONSTRAINT [FK__Usuarios__IdTipo__38996AB5] FOREIGN KEY ([IdTipoUsuario]) REFERENCES [dbo].[TipoUsuario] ([IdTipoUsuario]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[Usuarios] ADD CONSTRAINT [FK__Usuarios__IdSede__398D8EEE] FOREIGN KEY ([IdSede]) REFERENCES [dbo].[Sede] ([IdSede]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

