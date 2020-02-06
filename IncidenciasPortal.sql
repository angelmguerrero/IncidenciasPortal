USE [master]
GO
/****** Object:  Database [IncidenciasCoqueta]    Script Date: 06/02/2020 11:46:36 a. m. ******/
CREATE DATABASE [IncidenciasCoqueta]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'IncidenciasCoqueta', FILENAME = N'D:\datos\datos\IncidenciasCoqueta.mdf' , SIZE = 14528KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'IncidenciasCoqueta_log', FILENAME = N'D:\datos\logs\IncidenciasCoqueta_log.ldf' , SIZE = 20416KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [IncidenciasCoqueta] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [IncidenciasCoqueta].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [IncidenciasCoqueta] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [IncidenciasCoqueta] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [IncidenciasCoqueta] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [IncidenciasCoqueta] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [IncidenciasCoqueta] SET ARITHABORT OFF 
GO
ALTER DATABASE [IncidenciasCoqueta] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [IncidenciasCoqueta] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [IncidenciasCoqueta] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [IncidenciasCoqueta] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [IncidenciasCoqueta] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [IncidenciasCoqueta] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [IncidenciasCoqueta] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [IncidenciasCoqueta] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [IncidenciasCoqueta] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [IncidenciasCoqueta] SET  ENABLE_BROKER 
GO
ALTER DATABASE [IncidenciasCoqueta] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [IncidenciasCoqueta] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [IncidenciasCoqueta] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [IncidenciasCoqueta] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [IncidenciasCoqueta] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [IncidenciasCoqueta] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [IncidenciasCoqueta] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [IncidenciasCoqueta] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [IncidenciasCoqueta] SET  MULTI_USER 
GO
ALTER DATABASE [IncidenciasCoqueta] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [IncidenciasCoqueta] SET DB_CHAINING OFF 
GO
ALTER DATABASE [IncidenciasCoqueta] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [IncidenciasCoqueta] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [IncidenciasCoqueta] SET DELAYED_DURABILITY = DISABLED 
GO
USE [IncidenciasCoqueta]
GO
/****** Object:  User [PRUEBA01\desarrollo]    Script Date: 06/02/2020 11:46:37 a. m. ******/
CREATE USER [PRUEBA01\desarrollo] FOR LOGIN [PRUEBA01\desarrollo] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[cLotes]    Script Date: 06/02/2020 11:46:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cLotes](
	[numeroLote] [smallint] NOT NULL,
	[pedido] [int] NOT NULL,
	[fechaAdornoTerminado] [date] NOT NULL,
	[semanaEntrega] [smallint] NULL,
	[caja] [char](20) NULL,
	[fechaCapturaLote] [date] NULL,
	[colorEntreSuela] [char](2) NOT NULL,
	[colorForro] [char](2) NOT NULL,
	[colorPlantilla] [char](2) NULL,
	[colorSuela] [char](2) NOT NULL,
	[color1] [char](2) NOT NULL,
	[color2] [char](2) NOT NULL,
	[color3] [char](2) NOT NULL,
	[color4] [char](2) NOT NULL,
	[color5] [char](2) NOT NULL,
	[color6] [char](2) NOT NULL,
	[paresCorrida1] [smallint] NOT NULL,
	[paresCorrida2] [smallint] NOT NULL,
	[paresCorrida3] [smallint] NOT NULL,
	[paresCorrida4] [smallint] NOT NULL,
	[paresCorrida5] [smallint] NOT NULL,
	[fechaAvanceCorte] [date] NOT NULL,
	[fechaAvanceMontado] [date] NULL,
	[claveLinea] [char](2) NOT NULL,
	[fechaEntregaPlaneacion] [date] NULL,
	[claveEstilo] [int] NOT NULL,
	[fechaEntregaDestinatario] [date] NULL,
	[fechaCancelacionLote] [date] NULL,
	[claveForro] [char](2) NOT NULL,
	[claveHorma] [char](8) NULL,
	[fechaInicioLote] [date] NOT NULL,
	[combinacion] [char](1) NOT NULL,
	[linea] [smallint] NOT NULL,
	[loteMaquila] [smallint] NULL,
	[claveMarca] [char](20) NULL,
	[costoMaterial1] [money] NOT NULL,
	[costoMaterial2] [money] NOT NULL,
	[costoMaterial3] [money] NOT NULL,
	[costoMaterial4] [money] NOT NULL,
	[costoMaterial5] [money] NOT NULL,
	[fechaMontado] [date] NOT NULL,
	[talla110Bebe] [smallint] NOT NULL,
	[talla115Bebe] [smallint] NOT NULL,
	[talla120Bebe] [smallint] NOT NULL,
	[talla100] [smallint] NOT NULL,
	[talla105] [smallint] NOT NULL,
	[talla110] [smallint] NOT NULL,
	[talla115] [smallint] NOT NULL,
	[talla120] [smallint] NOT NULL,
	[talla125] [smallint] NOT NULL,
	[talla130] [smallint] NOT NULL,
	[talla135] [smallint] NOT NULL,
	[talla140] [smallint] NOT NULL,
	[talla145] [smallint] NOT NULL,
	[talla150] [smallint] NOT NULL,
	[talla155] [smallint] NOT NULL,
	[talla160] [smallint] NOT NULL,
	[talla165] [smallint] NOT NULL,
	[talla170] [smallint] NOT NULL,
	[talla175] [smallint] NOT NULL,
	[talla180] [smallint] NOT NULL,
	[talla185] [smallint] NOT NULL,
	[talla190] [smallint] NOT NULL,
	[talla195] [smallint] NOT NULL,
	[talla200] [smallint] NOT NULL,
	[talla205] [smallint] NOT NULL,
	[talla210] [smallint] NOT NULL,
	[talla215] [smallint] NOT NULL,
	[talla220] [smallint] NOT NULL,
	[talla225] [smallint] NOT NULL,
	[talla230] [smallint] NOT NULL,
	[talla235] [smallint] NOT NULL,
	[talla240] [smallint] NOT NULL,
	[talla245] [smallint] NOT NULL,
	[talla250] [smallint] NOT NULL,
	[talla255] [smallint] NOT NULL,
	[talla260] [smallint] NOT NULL,
	[talla265] [smallint] NULL,
	[talla270] [smallint] NULL,
	[talla900] [smallint] NOT NULL,
	[talla905] [smallint] NOT NULL,
	[observaciones] [char](40) NULL,
	[fechaPespunte] [date] NOT NULL,
	[fechaPespunteTerminado] [date] NOT NULL,
	[clavePiel1] [char](2) NOT NULL,
	[clavePiel2] [char](2) NULL,
	[clavePiel3] [char](2) NULL,
	[clavePiel4] [char](2) NULL,
	[clavePiel5] [char](2) NULL,
	[clavePiel6] [char](2) NULL,
	[fechaPreliminar] [date] NOT NULL,
	[proveedorMaquila] [smallint] NULL,
	[referenciaLote] [int] NULL,
	[semanaProgramadaEntregaLote] [int] NULL,
	[semanaEntregaLote] [int] NULL,
	[claveEstatusLote] [smallint] NULL,
	[claveSubLinea] [smallint] NOT NULL,
	[claveSuela] [char](2) NOT NULL,
	[fechaTerminadoFabricacion] [date] NOT NULL,
	[claveTipoNumeracion] [smallint] NULL,
	[claveTipoPlantilla] [char](2) NULL,
	[totalPares] [smallint] NOT NULL,
	[ultimoProceso] [smallint] NULL,
 CONSTRAINT [PK_cLotes_1] PRIMARY KEY CLUSTERED 
(
	[numeroLote] ASC,
	[pedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cTipoIncidencia]    Script Date: 06/02/2020 11:46:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cTipoIncidencia](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Incidencia] [varchar](50) NULL,
	[Activo] [bit] NULL CONSTRAINT [DF_cTipoIncidencia_Activo]  DEFAULT ((1)),
 CONSTRAINT [PK_cTipoIncidencia] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cTipoProducto]    Script Date: 06/02/2020 11:46:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cTipoProducto](
	[Tipo] [smallint] NOT NULL,
	[Clave] [char](2) NOT NULL,
	[Descripcion] [nvarchar](20) NULL,
	[Abreviatura] [char](6) NULL,
	[Status] [char](1) NULL,
	[DescripcionIngles] [nvarchar](20) NULL,
	[AbreviaturaIngles] [char](6) NULL,
 CONSTRAINT [PK_TipoProducto] PRIMARY KEY CLUSTERED 
(
	[Tipo] ASC,
	[Clave] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cUsuarios]    Script Date: 06/02/2020 11:46:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cUsuarios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NombreUsuario] [nvarchar](500) NULL,
	[Nombre] [nvarchar](100) NULL,
	[Password] [nvarchar](50) NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[lIncidencias]    Script Date: 06/02/2020 11:46:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[lIncidencias](
	[Id] [varchar](40) NOT NULL,
	[Lote] [varchar](50) NULL,
	[Riel] [smallint] NULL,
	[Semana] [nchar](2) NULL,
	[FechaRegistroIncidencia] [datetime] NULL,
	[TipoIncidenciaId] [int] NULL,
	[TotalIncidencias] [int] NULL,
	[Descripcion] [nvarchar](1000) NULL,
	[UsuarioId] [int] NULL,
 CONSTRAINT [PK_lIncidencias] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LogETL]    Script Date: 06/02/2020 11:46:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LogETL](
	[moment] [datetime] NULL,
	[pid] [varchar](20) NULL,
	[project] [varchar](50) NULL,
	[job] [varchar](255) NULL,
	[language] [varchar](5) NULL,
	[origin] [varchar](50) NULL,
	[status] [varchar](10) NULL,
	[substatus] [varchar](255) NULL,
	[description] [varchar](255) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[rFotoPorlIncidencias]    Script Date: 06/02/2020 11:46:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[rFotoPorlIncidencias](
	[Id] [varchar](40) NOT NULL,
	[lIncidenciasId] [varchar](40) NULL,
	[ImageUrl] [nvarchar](max) NULL,
	[FotoName] [nvarchar](max) NULL,
 CONSTRAINT [PK_rFotoPorlIncidencias] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[sParametroAplicacion]    Script Date: 06/02/2020 11:46:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sParametroAplicacion](
	[Id] [varchar](40) NOT NULL,
	[Valor] [varchar](200) NOT NULL,
	[Descripcion] [varchar](200) NOT NULL,
 CONSTRAINT [PK_S_ParametrosAplicacion_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[uvwLotesMontado]    Script Date: 06/02/2020 11:46:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




 CREATE VIEW [dbo].[uvwLotesMontado] AS
 /* 
 Autor: Alejandro M. Guerrero
 Fecha de Creación: 15/01/2020
 Descripción: Vista que muestra los lotes que estan en proceso de montado
 */

	SELECT CAST(numeroLote AS varchar) + CAST(pedido AS VARCHAR) Lote, claveEstilo AS Estilo, combinacion AS Combinacion, pro.Descripcion AS Suela,(SELECT DATEPART(ISO_WEEK, CURRENT_TIMESTAMP)) as NumSemana
	FROM clotes lot
	INNER JOIN cTipoProducto pro ON lot.claveSuela = pro.Clave AND tipo=4
	WHERE claveEstatusLote NOT IN (2,3,4,5,6,15,16) AND ultimoProceso =6 AND fechaMontado <>'1900-01-01'  AND fechaAvanceMontado='1900-01-01'
GO

SET IDENTITY_INSERT [dbo].[cUsuarios] ON 
INSERT [dbo].[cUsuarios] ([Id],[NombreUsuario],[Nombre],[Password],[Activo]) VALUES (1,'gmedian', 'German Medina', 'G3rM4n',1)
SET IDENTITY_INSERT [dbo].[cUsuarios] OFF 

SET IDENTITY_INSERT [dbo].[cTipoIncidencia] ON 
INSERT [dbo].[cTipoIncidencia] ([Id], [Incidencia], [Activo]) VALUES (1, N'Calidad de Pespuntes', 1)
INSERT [dbo].[cTipoIncidencia] ([Id], [Incidencia], [Activo]) VALUES (2, N'Calidad de Materiales', 1)
INSERT [dbo].[cTipoIncidencia] ([Id], [Incidencia], [Activo]) VALUES (3, N'Faltante suelas', 1)
INSERT [dbo].[cTipoIncidencia] ([Id], [Incidencia], [Activo]) VALUES (4, N'Mal Loteado Suelas', 1)
INSERT [dbo].[cTipoIncidencia] ([Id], [Incidencia], [Activo]) VALUES (5, N'Complejidad de Manufactura', 1)
INSERT [dbo].[cTipoIncidencia] ([Id], [Incidencia], [Activo]) VALUES (6, N'Cambios por día  por estilo', 1)
INSERT [dbo].[cTipoIncidencia] ([Id], [Incidencia], [Activo]) VALUES (7, N'Proceso Montado', 1)
INSERT [dbo].[cTipoIncidencia] ([Id], [Incidencia], [Activo]) VALUES (8, N'Implementaciones', 1)
INSERT [dbo].[cTipoIncidencia] ([Id], [Incidencia], [Activo]) VALUES (9, N'Fallas de Mantenimiento', 1)
INSERT [dbo].[cTipoIncidencia] ([Id], [Incidencia], [Activo]) VALUES (10, N'Falta de Programación/Programación Constante', 1)
INSERT [dbo].[cTipoIncidencia] ([Id], [Incidencia], [Activo]) VALUES (11, N'Plantilla Personal Completa', 1)
INSERT [dbo].[cTipoIncidencia] ([Id], [Incidencia], [Activo]) VALUES (12, N'Procesos Especiales Nuevos', 1)
INSERT [dbo].[cTipoIncidencia] ([Id], [Incidencia], [Activo]) VALUES (13, N'Cursos Planeados', 1)
SET IDENTITY_INSERT [dbo].[cTipoIncidencia] OFF
INSERT [dbo].[sParametroAplicacion] ([Id], [Valor], [Descripcion]) VALUES (N'RepositorioFotos', N'C:\Uploads', N'Repositorio de fotos de las incidencias')
ALTER TABLE [dbo].[cUsuarios] ADD  CONSTRAINT [DF_cUsuarios_Activo]  DEFAULT ((1)) FOR [Activo]
GO
ALTER TABLE [dbo].[lIncidencias] ADD  CONSTRAINT [DF_lIncidencias_FechaRegistroIncidencia]  DEFAULT (getdate()) FOR [FechaRegistroIncidencia]
GO
ALTER TABLE [dbo].[lIncidencias]  WITH CHECK ADD  CONSTRAINT [FK_lIncidencias_cTipoIncidencia] FOREIGN KEY([TipoIncidenciaId])
REFERENCES [dbo].[cTipoIncidencia] ([Id])
GO
ALTER TABLE [dbo].[lIncidencias] CHECK CONSTRAINT [FK_lIncidencias_cTipoIncidencia]
GO
ALTER TABLE [dbo].[lIncidencias]  WITH CHECK ADD  CONSTRAINT [FK_lIncidencias_cUsuarios] FOREIGN KEY([UsuarioId])
REFERENCES [dbo].[cUsuarios] ([Id])
GO
ALTER TABLE [dbo].[lIncidencias] CHECK CONSTRAINT [FK_lIncidencias_cUsuarios]
GO
ALTER TABLE [dbo].[rFotoPorlIncidencias]  WITH CHECK ADD  CONSTRAINT [FK_rFotoPorlIncidencias_lIncidencias] FOREIGN KEY([lIncidenciasId])
REFERENCES [dbo].[lIncidencias] ([Id])
GO
ALTER TABLE [dbo].[rFotoPorlIncidencias] CHECK CONSTRAINT [FK_rFotoPorlIncidencias_lIncidencias]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Numero de lote (lot)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'numeroLote'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Pedido (ped)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'pedido'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha de avances de adorno (ado)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'fechaAdornoTerminado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Semana de entrega (agrupado)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'semanaEntrega'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Caja (caja)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'caja'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha en que se captura el lote (captura)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'fechaCapturaLote'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Color de entre suela (col_ents)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'colorEntreSuela'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Color de forro (col_for)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'colorForro'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Color de plantilla (col_plan)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'colorPlantilla'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Color principal (col1)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'color1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Color 2 (col2)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'color2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Color 3 (col3)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'color3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'color 4 (col4)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'color4'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Color 5 (col5)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'color5'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Color 6 (col6)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'color6'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Total de pares corrida 1 (cor1)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'paresCorrida1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Total de pares corrida 2 (cor2)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'paresCorrida2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Total de pares corrida 3 (cor3)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'paresCorrida3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Total de pares corrida 4 (cor4)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'paresCorrida4'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Total de pares corrida 5 (cor5)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'paresCorrida5'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha de avance de corte (corte)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'fechaAvanceCorte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha de avance de montado (cupmont)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'fechaAvanceMontado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Clave de linea (cvelin)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'claveLinea'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha de entrega a planeacion (ent_pla)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'fechaEntregaPlaneacion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Clave de estilo (est)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'claveEstilo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha de entrega de lote de la planta a su destinatario (fe_ent)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'fechaEntregaDestinatario'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha de cancelacion de lote (fec_canc)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'fechaCancelacionLote'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Clave de forro (forro)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'claveForro'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Clave de horma (horma)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'claveHorma'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha de inicio lote en producion (inicio)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'fechaInicioLote'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Combinacion (let)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'combinacion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Linea (lin)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'linea'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Indica si el lote es de maquila (0 Coqueta - 1 Maquila) (maq)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'loteMaquila'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Clave de Marca (marca)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'claveMarca'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Costo del material 1 (mat1)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'costoMaterial1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Costo del material 2 (mat2)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'costoMaterial2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Costo del material 3 (mat3)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'costoMaterial3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Costo del material 4 (mat4)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'costoMaterial4'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Costo del material 5 (mat5)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'costoMaterial5'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha que ingresa a montado (mont)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'fechaMontado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Punto 11 Corrida 1 de Bebe (n_110)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'talla110Bebe'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Punto 11.5 Corrida 1 de Bebe (n_115)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'talla115Bebe'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Punto 12 Corrida 1 de Bebe (n_120)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'talla120Bebe'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Punto 10 Corrida 2 (n100)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'talla100'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Punto 10.5 Corrida 2 (n105)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'talla105'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Punto 11 Corrida 2 (n110)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'talla110'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Punto 11.5 Corrida 2 (n115)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'talla115'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Punto 12 Corrida 2 (n120)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'talla120'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Punto 12.5 Corrida 2 (n125)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'talla125'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Punto 13 Corrida 2 (n130)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'talla130'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Punto 13.5 Corrida 2 (n135)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'talla135'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Punto 14 Corrida 2 (n140)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'talla140'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Punto 14.5 Corrida 2 (n145)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'talla145'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Punto 15 Corrida 2 (n150)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'talla150'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Punto 15.5 Corrida 2 (n155)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'talla155'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Punto 16 Corrida 2 (n160)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'talla160'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Punto 16.5 Corrida 2 (n165)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'talla165'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Punto 17 Corrida 2 (n170)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'talla170'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Punto 17.5 Corrida 2 (n175)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'talla175'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Punto 18 Corrida 2 (n180)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'talla180'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Punto 18.5 Corrida 2 (n185)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'talla185'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Punto 19 Corrida 2 (n190)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'talla190'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Punto 19.5 Corrida 2 (n195)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'talla195'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Punto 20 Corrida 2 (n200)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'talla200'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Punto 20.5 Corrida 2 (n205)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'talla205'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Punto 21 Corrida 2 (n210)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'talla210'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Punto 21.5 Corrida 2 (n215)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'talla215'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Talla 20 Corrida 2 (n220)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'talla220'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Punto 22.5 Corrida 2 (n225)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'talla225'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Punto 23 Corrida 2 (n230)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'talla230'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Punto 23.5 Corrida 2 (n235)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'talla235'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Punto 24 Corrida 2 (n240)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'talla240'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Punto 24.5 Corrida 2 (n245)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'talla245'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Punto 25 Corrida 2 (n250)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'talla250'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Punto 25.5 Corrida 2 (n255)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'talla255'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Punto 26 Corrida 2 (n260)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'talla260'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Punto 26.5 Corrida 2 (n265)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'talla265'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Punto 27 Corrida 2 (n270)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'talla270'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Punto 9 Corrida 2 (n900)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'talla900'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Punto 9.5 Corrida 2 (n905)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'talla905'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Observaciones (obs)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'observaciones'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha en que entra a pespunte (pesp)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'fechaPespunte'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha que sale de pespunte (pesp_term)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'fechaPespunteTerminado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Clave de Piel 1 (piel1)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'clavePiel1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Clave de Piel 2 (piel2)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'clavePiel2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Clave de Piel 3 (piel3)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'clavePiel3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Clave de Piel 4 (piel4)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'clavePiel4'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Clave de Piel 5 (piel5)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'clavePiel5'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Clave de Piel 6 (piel6)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'clavePiel6'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha que esta en premilinar (prel)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'fechaPreliminar'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Indica si aparecera el numero de provedor (prov)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'proveedorMaquila'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Clave de referencia del lote (reflot)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'referenciaLote'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Semana original de entrega de lote (rlot)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'semanaProgramadaEntregaLote'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Semana de entrega del lote (rped)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'semanaEntregaLote'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Clave de estatus del lote (status)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'claveEstatusLote'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Clave sub linea (sub)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'claveSubLinea'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Clave de suela (suela)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'claveSuela'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha en que se termina de fabricar (term)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'fechaTerminadoFabricacion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Clave tipo de numeracion (tip_num)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'claveTipoNumeracion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Clave tipo de plantilla (tip_plan)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'claveTipoPlantilla'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Total de pares en el lote (tot)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'totalPares'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Clave del ultimo proceso registrado en el lote (ult_proc)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes', @level2type=N'COLUMN',@level2name=N'ultimoProceso'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Catalogo de Lotes' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cLotes'
GO
USE [master]
GO
ALTER DATABASE [IncidenciasCoqueta] SET  READ_WRITE 
GO
