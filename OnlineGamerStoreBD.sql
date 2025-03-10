USE [OnlineGamerStore]
GO
/****** Object:  Schema [OGS]    Script Date: 11/02/2025 10:54:06 p. m. ******/
CREATE SCHEMA [OGS]
GO
/****** Object:  Schema [Param]    Script Date: 11/02/2025 10:54:06 p. m. ******/
CREATE SCHEMA [Param]
GO
/****** Object:  Schema [Users]    Script Date: 11/02/2025 10:54:06 p. m. ******/
CREATE SCHEMA [Users]
GO
/****** Object:  Table [OGS].[tbCarrito]    Script Date: 11/02/2025 10:54:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [OGS].[tbCarrito](
	[IDCarrito] [int] IDENTITY(1,1) NOT NULL,
	[IDUsuario] [int] NULL,
	[IDProducto] [int] NULL,
	[Cantidad] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDCarrito] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [OGS].[tbCategorias]    Script Date: 11/02/2025 10:54:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [OGS].[tbCategorias](
	[IDCategoria] [int] IDENTITY(1,1) NOT NULL,
	[DescripcionCategoria] [varchar](200) NULL,
	[Estado] [bit] NULL,
	[FechaRegistro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [OGS].[tbClientes]    Script Date: 11/02/2025 10:54:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [OGS].[tbClientes](
	[IDCliente] [int] IDENTITY(1,1) NOT NULL,
	[IDPersona] [int] NULL,
	[IDUsuario] [int] NULL,
	[IDTipoDocumento] [int] NULL,
	[NumeroDocumento] [int] NULL,
	[NombreCompleto] [varchar](200) NULL,
	[FechaRegistro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [OGS].[tbComentarios]    Script Date: 11/02/2025 10:54:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [OGS].[tbComentarios](
	[IDComentario] [int] IDENTITY(1,1) NOT NULL,
	[IDusuario] [int] NULL,
	[Estado] [bit] NULL,
	[FechaRegistro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDComentario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [OGS].[tbDetalleVenta]    Script Date: 11/02/2025 10:54:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [OGS].[tbDetalleVenta](
	[IDDetalleVenta] [int] IDENTITY(1,1) NOT NULL,
	[IDVenta] [int] NULL,
	[IDProducto] [int] NULL,
	[Cantidad] [int] NULL,
	[FechaRegistro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDDetalleVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [OGS].[tbEstadoPedido]    Script Date: 11/02/2025 10:54:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [OGS].[tbEstadoPedido](
	[IDestadoPedido] [int] IDENTITY(1,1) NOT NULL,
	[DescripcionEstadoPedido] [varchar](200) NULL,
	[Estado] [bit] NULL,
	[FechaRegistro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDestadoPedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [OGS].[tbFacturas]    Script Date: 11/02/2025 10:54:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [OGS].[tbFacturas](
	[IDFactura] [int] IDENTITY(1,1) NOT NULL,
	[Total] [decimal](10, 2) NULL,
	[SubTotal] [decimal](10, 2) NULL,
	[IDMedioDePago] [int] NULL,
	[ValorTotalPago] [decimal](10, 2) NULL,
	[ValorTotalSinIva] [decimal](10, 2) NULL,
	[ValorIva] [decimal](10, 2) NULL,
	[NombreCliente] [varchar](200) NULL,
	[IDTipoDocumento] [int] NULL,
	[ClienteNoDocumento] [int] NULL,
	[IDTipoDocumentoFacturador] [int] NULL,
	[FacturadorNoDocumento] [int] NULL,
	[IDPago] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [OGS].[tbGarantias]    Script Date: 11/02/2025 10:54:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [OGS].[tbGarantias](
	[IDGarantia] [int] IDENTITY(1,1) NOT NULL,
	[IDFactura] [int] NULL,
	[IDProducto] [int] NULL,
	[IDCliente] [int] NULL,
	[FechaInicialGarantia] [datetime] NOT NULL,
	[FechaFinalGarantia] [datetime] NOT NULL,
	[DiasRestantesDeGarantia] [int] NULL,
	[IDVenta] [int] NULL,
	[NombreCliente] [varchar](200) NULL,
	[IDTipoDocumento] [int] NULL,
	[TotalPagado] [decimal](10, 2) NULL,
	[FechaRegistro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDGarantia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [OGS].[tbMarcas]    Script Date: 11/02/2025 10:54:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [OGS].[tbMarcas](
	[IDMarca] [int] IDENTITY(1,1) NOT NULL,
	[DescripcionMarca] [varchar](200) NULL,
	[Estado] [bit] NULL,
	[FechaRegistro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDMarca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [OGS].[tbPagos]    Script Date: 11/02/2025 10:54:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [OGS].[tbPagos](
	[IDPago] [int] IDENTITY(1,1) NOT NULL,
	[IDCliente] [int] NULL,
	[IDTransaccion] [varchar](200) NULL,
	[ValorPago] [decimal](10, 2) NULL,
	[IDEstadoPago] [int] NULL,
	[FechaRegistro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [OGS].[tbPedidos]    Script Date: 11/02/2025 10:54:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [OGS].[tbPedidos](
	[IDPedido] [int] IDENTITY(1,1) NOT NULL,
	[IDVenta] [int] NULL,
	[IDCliente] [int] NULL,
	[IDProductpo] [int] NULL,
	[IDFactura] [int] NULL,
	[Direccion] [varchar](200) NULL,
	[Contacto] [varchar](20) NULL,
	[IDEstadoPedido] [int] NULL,
	[FechaRegistro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDPedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [OGS].[tbPersonas]    Script Date: 11/02/2025 10:54:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [OGS].[tbPersonas](
	[IDPersona] [int] IDENTITY(1,1) NOT NULL,
	[IDTipoPersona] [int] NULL,
	[IDUsuario] [int] NULL,
	[IDTipoDocumento] [int] NULL,
	[NumeroDocumento] [int] NULL,
	[FechaNacimiento] [date] NULL,
	[Nombre1] [varchar](200) NULL,
	[Nombre2] [varchar](200) NULL,
	[Apellido1] [varchar](200) NULL,
	[Apellido2] [varchar](200) NULL,
	[NombreCompleto] [varchar](200) NULL,
	[CorreoElectronico] [varchar](200) NULL,
	[IDsexo] [int] NULL,
	[Telefono] [int] NULL,
	[Edad] [int] NULL,
	[Direccion1] [varchar](200) NULL,
	[Direccion2] [varchar](200) NULL,
	[Direccion3] [varchar](200) NULL,
	[Complemento] [varchar](200) NULL,
	[FechaRegistro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDPersona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [OGS].[tbProductos]    Script Date: 11/02/2025 10:54:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [OGS].[tbProductos](
	[IDProducto] [int] IDENTITY(1,1) NOT NULL,
	[NombreProducto] [varchar](200) NULL,
	[DescripcionProducto] [varchar](200) NULL,
	[Precio] [decimal](10, 2) NULL,
	[IVAPorcentaje] [decimal](5, 2) NULL,
	[IVAValor] [decimal](10, 2) NULL,
	[IDMarca] [int] NULL,
	[IDCategoria] [int] NULL,
	[Stock] [int] NULL,
	[RutaImagen] [varchar](200) NULL,
	[NombreImagen] [varchar](200) NULL,
	[Estado] [bit] NULL,
	[FechaRegistro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [OGS].[tbVentas]    Script Date: 11/02/2025 10:54:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [OGS].[tbVentas](
	[IdVenta] [int] IDENTITY(1,1) NOT NULL,
	[IDCliente] [int] NULL,
	[IDProducto] [int] NULL,
	[IDFactura] [int] NULL,
	[Idusuario] [int] NULL,
	[IDMedioDePago] [int] NULL,
	[IDPago] [int] NULL,
	[ValorTotalPago] [decimal](10, 2) NULL,
	[ValorTotalSinIva] [decimal](10, 2) NULL,
	[ValorIva] [decimal](10, 2) NULL,
	[FechaRegistro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Param].[tbCiudades]    Script Date: 11/02/2025 10:54:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Param].[tbCiudades](
	[IDCiudad] [int] IDENTITY(1,1) NOT NULL,
	[CodigoCiudad] [varchar](200) NOT NULL,
	[DescripcionCiudad] [varchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDCiudad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Param].[tbDepartamentos]    Script Date: 11/02/2025 10:54:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Param].[tbDepartamentos](
	[IDDepartamento] [int] IDENTITY(1,1) NOT NULL,
	[CodigoDepartamento] [varchar](200) NOT NULL,
	[DescripcionDepartanento] [varchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDDepartamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Param].[tbEstadosDePago]    Script Date: 11/02/2025 10:54:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Param].[tbEstadosDePago](
	[IDEstadoPago] [int] IDENTITY(1,1) NOT NULL,
	[DescripcionEstadoPago] [varchar](200) NULL,
	[Estado] [bit] NULL,
	[FechaRegistro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDEstadoPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Param].[tbMedioDePago]    Script Date: 11/02/2025 10:54:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Param].[tbMedioDePago](
	[IDMedioDePago] [int] IDENTITY(1,1) NOT NULL,
	[DescripcionMedioDePago] [varchar](200) NULL,
	[Estado] [bit] NULL,
	[FechaRegistro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDMedioDePago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Param].[tbSexo]    Script Date: 11/02/2025 10:54:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Param].[tbSexo](
	[IDSexo] [int] IDENTITY(1,1) NOT NULL,
	[Abreviatura] [varchar](200) NULL,
	[DescripcionSexo] [varchar](200) NULL,
	[FechaRegistro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDSexo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Param].[tbTipoDocumento]    Script Date: 11/02/2025 10:54:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Param].[tbTipoDocumento](
	[IDTipoDocumento] [int] IDENTITY(1,1) NOT NULL,
	[DescripcionTipoDocumento] [varchar](200) NULL,
	[Abreviatura] [varchar](5) NULL,
	[FechaRegistro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDTipoDocumento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Param].[tbTipoPersona]    Script Date: 11/02/2025 10:54:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Param].[tbTipoPersona](
	[IDTipoPersona] [int] IDENTITY(1,1) NOT NULL,
	[DescripcionTipoPersona] [varchar](200) NULL,
	[FechaRegistro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDTipoPersona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Users].[tbRoles]    Script Date: 11/02/2025 10:54:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Users].[tbRoles](
	[IDRol] [int] IDENTITY(1,1) NOT NULL,
	[DescripcionRol] [varchar](50) NULL,
	[FechaRegistro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Users].[tbUserRoles]    Script Date: 11/02/2025 10:54:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Users].[tbUserRoles](
	[IDUsuarioRol] [int] IDENTITY(1,1) NOT NULL,
	[IDUsuario] [int] NULL,
	[IDRol] [int] NULL,
	[Estado] [bit] NULL,
	[FechaRegistro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDUsuarioRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Users].[tbUsers]    Script Date: 11/02/2025 10:54:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Users].[tbUsers](
	[IDUsuario] [int] IDENTITY(1,1) NOT NULL,
	[IDTipoDocumento] [int] NULL,
	[Nombre1] [varchar](200) NULL,
	[Nombre2] [varchar](200) NULL,
	[Apellido1] [varchar](200) NULL,
	[Apellido2] [varchar](200) NULL,
	[NombreCompleto] [varchar](200) NULL,
	[CorreoElectronico] [varchar](200) NULL,
	[Contraseña] [varchar](200) NULL,
	[FechaNacimiento] [date] NULL,
	[IDsexo] [int] NULL,
	[Telefono] [int] NULL,
	[Estado] [bit] NULL,
	[FechaRegistro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [OGS].[tbCategorias] ADD  DEFAULT ((1)) FOR [Estado]
GO
ALTER TABLE [OGS].[tbCategorias] ADD  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [OGS].[tbClientes] ADD  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [OGS].[tbComentarios] ADD  DEFAULT ((1)) FOR [Estado]
GO
ALTER TABLE [OGS].[tbComentarios] ADD  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [OGS].[tbDetalleVenta] ADD  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [OGS].[tbEstadoPedido] ADD  DEFAULT ((1)) FOR [Estado]
GO
ALTER TABLE [OGS].[tbEstadoPedido] ADD  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [OGS].[tbFacturas] ADD  DEFAULT ((2)) FOR [IDTipoDocumentoFacturador]
GO
ALTER TABLE [OGS].[tbFacturas] ADD  DEFAULT ((123456789)) FOR [FacturadorNoDocumento]
GO
ALTER TABLE [OGS].[tbGarantias] ADD  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [OGS].[tbMarcas] ADD  DEFAULT ((1)) FOR [Estado]
GO
ALTER TABLE [OGS].[tbMarcas] ADD  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [OGS].[tbPagos] ADD  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [OGS].[tbPedidos] ADD  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [OGS].[tbPersonas] ADD  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [OGS].[tbProductos] ADD  DEFAULT ((1)) FOR [Estado]
GO
ALTER TABLE [OGS].[tbProductos] ADD  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [OGS].[tbVentas] ADD  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [Param].[tbEstadosDePago] ADD  DEFAULT ((1)) FOR [Estado]
GO
ALTER TABLE [Param].[tbEstadosDePago] ADD  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [Param].[tbMedioDePago] ADD  DEFAULT ((1)) FOR [Estado]
GO
ALTER TABLE [Param].[tbMedioDePago] ADD  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [Param].[tbSexo] ADD  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [Param].[tbTipoDocumento] ADD  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [Param].[tbTipoPersona] ADD  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [Users].[tbRoles] ADD  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [Users].[tbUserRoles] ADD  DEFAULT ((1)) FOR [Estado]
GO
ALTER TABLE [Users].[tbUserRoles] ADD  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [Users].[tbUsers] ADD  DEFAULT ((1)) FOR [Estado]
GO
ALTER TABLE [Users].[tbUsers] ADD  DEFAULT (getdate()) FOR [FechaRegistro]
GO
/****** Object:  StoredProcedure [Users].[spListadoDeClientes]    Script Date: 11/02/2025 10:54:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Users].[spListadoDeClientes] (
@TRAZA AS BIT = 1

)
AS
BEGIN 

SELECT A.IDCliente,
		--A.IDTipoDocumento,
		B.Abreviatura,
		A.NumeroDocumento,
		A.NombreCompleto,
		C.FechaNacimiento,
		C.CorreoElectronico
FROM OnlineGamerStore.OGS.tbClientes A
INNER JOIN OnlineGamerStore.Param.tbTipoDocumento B
ON A.IDTipoDocumento = B.IDTipoDocumento
INNER JOIN OnlineGamerStore.OGS.tbPersonas C
ON A.IDPersona = C.IDPersona

END

GO
