USE [gestionbrr]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 29/11/2023 17:23:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[asignarAreaEquipos]    Script Date: 29/11/2023 17:23:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[asignarAreaEquipos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Id_Equipo] [int] NOT NULL,
	[Numero_serial] [nvarchar](max) NOT NULL,
	[Numero_activo_del_banco] [int] NOT NULL,
	[Area_Asignada] [nvarchar](max) NOT NULL,
	[Marca] [nvarchar](max) NOT NULL,
	[Tipo] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_asignarAreaEquipos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[equiposAsignados]    Script Date: 29/11/2023 17:23:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[equiposAsignados](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ID_del_Equipo] [int] NOT NULL,
	[Tipo] [nvarchar](max) NOT NULL,
	[Marca] [nvarchar](max) NOT NULL,
	[Condicion] [nvarchar](max) NOT NULL,
	[Modelo] [nvarchar](max) NOT NULL,
	[Numero_de_serie] [nvarchar](max) NOT NULL,
	[Color] [nvarchar](max) NOT NULL,
	[Fecha_de_fabricacion] [datetime2](7) NOT NULL,
	[Fecha_de_adquisicion] [datetime2](7) NOT NULL,
	[Estado] [nvarchar](max) NOT NULL,
	[Ubicación_Actual] [nvarchar](max) NOT NULL,
	[Asignado] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_equiposAsignados] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[historialEventos]    Script Date: 29/11/2023 17:23:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[historialEventos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Numero_serial] [int] NOT NULL,
	[Fecha] [datetime2](7) NOT NULL,
	[TipoEvento] [nvarchar](max) NOT NULL,
	[Detalles] [nvarchar](max) NOT NULL,
	[EmpleadoAsignado] [nvarchar](max) NOT NULL,
	[AreaOrigen] [nvarchar](max) NOT NULL,
	[AreaDestino] [nvarchar](max) NOT NULL,
	[SoftwareInstalado] [nvarchar](max) NOT NULL,
	[DetallesMantenimiento] [nvarchar](max) NOT NULL,
	[DetallesReparacion] [nvarchar](max) NOT NULL,
	[DetallesModificacion] [nvarchar](max) NOT NULL,
	[CausaDaño] [nvarchar](max) NOT NULL,
	[numero_de_activo] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_historialEventos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[mequipos]    Script Date: 29/11/2023 17:23:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mequipos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [varchar](50) NOT NULL,
	[Marca] [nvarchar](max) NOT NULL,
	[Modelo] [varchar](50) NOT NULL,
	[Color] [varchar](50) NOT NULL,
	[Condicion] [varchar](50) NOT NULL,
	[Numero_de_activo] [int] NOT NULL,
	[Numero_serial] [nvarchar](max) NOT NULL,
	[Fecha_fabricacion] [datetime2](7) NOT NULL,
	[fecha_adquisicion] [datetime2](7) NOT NULL,
	[Fecha_expiracion_garantia_1] [datetime2](7) NOT NULL,
	[Fecha_expiracion_garantia_2] [datetime2](7) NOT NULL,
	[Fecha_final_vida_util] [datetime2](7) NOT NULL,
	[Fecha_descarte] [datetime2](7) NOT NULL,
	[Precio] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
 CONSTRAINT [PK_mequipos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[registrarMarcas]    Script Date: 29/11/2023 17:23:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[registrarMarcas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Marca] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_registrarMarcas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[registroindividuals]    Script Date: 29/11/2023 17:23:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[registroindividuals](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [varchar](50) NOT NULL,
	[Marca] [varchar](50) NOT NULL,
	[Modelo] [varchar](50) NOT NULL,
	[Número_de_activo_del_banco] [int] NOT NULL,
	[Número_serial_de_fábrica] [nvarchar](max) NOT NULL,
	[Estado] [nvarchar](max) NOT NULL,
	[Color] [varchar](50) NOT NULL,
 CONSTRAINT [PK_registroindividuals] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[solicitudEquipos]    Script Date: 29/11/2023 17:23:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[solicitudEquipos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TipoEquipo] [nvarchar](max) NOT NULL,
	[Procesador] [nvarchar](max) NOT NULL,
	[MemoriaRam] [nvarchar](max) NOT NULL,
	[DiscoDuro] [nvarchar](max) NOT NULL,
	[TarjetaGrafica] [nvarchar](max) NOT NULL,
	[Marca] [nvarchar](max) NOT NULL,
	[Areasolicitada] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_solicitudEquipos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[suvar203s]    Script Date: 29/11/2023 17:23:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[suvar203s](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UnidadEmisora] [nvarchar](max) NOT NULL,
	[Ubicacion] [nvarchar](max) NOT NULL,
	[Oficina] [nvarchar](max) NOT NULL,
	[Codigo] [nvarchar](max) NOT NULL,
	[Fecha] [datetime2](7) NOT NULL,
	[Telefono] [nvarchar](max) NOT NULL,
	[Numero_de_activo] [int] NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
	[Modelo] [nvarchar](max) NOT NULL,
	[Marca] [nvarchar](max) NOT NULL,
	[Numerodeserie] [nvarchar](max) NOT NULL,
	[color] [nvarchar](max) NOT NULL,
	[Condicion] [nvarchar](max) NOT NULL,
	[Observaciones] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_suvar203s] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231113130142_Inicial', N'7.0.13')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231113160729_nuevoo', N'7.0.13')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231114123454_nuevooooo', N'7.0.13')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231114132416_AsignarE', N'7.0.13')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231114145610_Nuebo', N'7.0.13')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231114145855_Nue', N'7.0.13')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231114162959_mm', N'7.0.13')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231115151942_Prueba', N'7.0.13')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231116131733_nnnnnn', N'7.0.13')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231116131809_NombreDeLaMigracion', N'7.0.13')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231116150401_Nuuuu', N'7.0.13')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231116152144_INININI', N'7.0.13')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231116185201_KK', N'7.0.13')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231117132828_MIJIJ', N'7.0.13')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231117141513_migraicon', N'7.0.13')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231117142353_fg', N'7.0.13')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231117154907_kjk', N'7.0.13')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231117155857_JJ', N'7.0.13')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231117183927_pp', N'7.0.13')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231117192953_JJffd', N'7.0.13')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231122163550_JD', N'7.0.13')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231124130353_JUE', N'7.0.13')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231124192500_JF', N'7.0.13')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231127180651_KI', N'7.0.13')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231127183632_JM', N'7.0.13')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231127184015_HY', N'7.0.13')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231127185127_MI', N'7.0.13')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231127190158_KO', N'7.0.13')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231128132623_JJJ', N'7.0.13')
GO
SET IDENTITY_INSERT [dbo].[asignarAreaEquipos] ON 
GO
INSERT [dbo].[asignarAreaEquipos] ([Id], [Id_Equipo], [Numero_serial], [Numero_activo_del_banco], [Area_Asignada], [Marca], [Tipo]) VALUES (1, 45534, N'43543', 43534, N'FGDG', N'FDGDFG', N'DFGDFG')
GO
INSERT [dbo].[asignarAreaEquipos] ([Id], [Id_Equipo], [Numero_serial], [Numero_activo_del_banco], [Area_Asignada], [Marca], [Tipo]) VALUES (2, 4343, N'4354343', 5435, N'ccc', N'hp', N'monitor')
GO
INSERT [dbo].[asignarAreaEquipos] ([Id], [Id_Equipo], [Numero_serial], [Numero_activo_del_banco], [Area_Asignada], [Marca], [Tipo]) VALUES (3, 344, N'324324', 324234, N'trret', N'mouse', N'retrt')
GO
INSERT [dbo].[asignarAreaEquipos] ([Id], [Id_Equipo], [Numero_serial], [Numero_activo_del_banco], [Area_Asignada], [Marca], [Tipo]) VALUES (4, 55545454, N'342323', 23232, N'retret', N'toyota', N'monitor')
GO
INSERT [dbo].[asignarAreaEquipos] ([Id], [Id_Equipo], [Numero_serial], [Numero_activo_del_banco], [Area_Asignada], [Marca], [Tipo]) VALUES (5, 3443, N'3234342', 32432, N'3424', N'sdfsdf', N'fdsfdsf')
GO
INSERT [dbo].[asignarAreaEquipos] ([Id], [Id_Equipo], [Numero_serial], [Numero_activo_del_banco], [Area_Asignada], [Marca], [Tipo]) VALUES (6, 56454, N'fgfg-5565', 1121, N'CTB', N'dell', N'monitor')
GO
SET IDENTITY_INSERT [dbo].[asignarAreaEquipos] OFF
GO
SET IDENTITY_INSERT [dbo].[equiposAsignados] ON 
GO
INSERT [dbo].[equiposAsignados] ([Id], [ID_del_Equipo], [Tipo], [Marca], [Condicion], [Modelo], [Numero_de_serie], [Color], [Fecha_de_fabricacion], [Fecha_de_adquisicion], [Estado], [Ubicación_Actual], [Asignado]) VALUES (1, 323, N'fsdf', N'dsdsf', N'sfd', N'dsfds', N'23232', N'dssdfsd', CAST(N'2022-12-12T00:00:00.0000000' AS DateTime2), CAST(N'1414-12-12T00:00:00.0000000' AS DateTime2), N'sdsd', N'dedff', N'sadsdfds')
GO
SET IDENTITY_INSERT [dbo].[equiposAsignados] OFF
GO
SET IDENTITY_INSERT [dbo].[historialEventos] ON 
GO
INSERT [dbo].[historialEventos] ([Id], [Numero_serial], [Fecha], [TipoEvento], [Detalles], [EmpleadoAsignado], [AreaOrigen], [AreaDestino], [SoftwareInstalado], [DetallesMantenimiento], [DetallesReparacion], [DetallesModificacion], [CausaDaño], [numero_de_activo]) VALUES (1, 343244, CAST(N'2023-11-21T12:46:00.0000000' AS DateTime2), N'fsgdf', N'ffdgfd', N'gdfgdf', N'gdfgdf', N'gdfg', N'fdgfdg', N'dfgdfgdf', N'gdfgfdg', N'fdgfdg', N'fdg', N'0')
GO
INSERT [dbo].[historialEventos] ([Id], [Numero_serial], [Fecha], [TipoEvento], [Detalles], [EmpleadoAsignado], [AreaOrigen], [AreaDestino], [SoftwareInstalado], [DetallesMantenimiento], [DetallesReparacion], [DetallesModificacion], [CausaDaño], [numero_de_activo]) VALUES (2, 32432, CAST(N'2023-11-22T12:47:00.0000000' AS DateTime2), N'dfgfdgfd', N'gdfgdf', N'gdfgdf', N'gdfgdf', N'g', N'gggg', N'ggfdf', N'fdghdf', N'dfggfhggf', N'sddgfgfd', N'0')
GO
INSERT [dbo].[historialEventos] ([Id], [Numero_serial], [Fecha], [TipoEvento], [Detalles], [EmpleadoAsignado], [AreaOrigen], [AreaDestino], [SoftwareInstalado], [DetallesMantenimiento], [DetallesReparacion], [DetallesModificacion], [CausaDaño], [numero_de_activo]) VALUES (3, 34543, CAST(N'2023-11-22T12:50:00.0000000' AS DateTime2), N'gfdgfdgdf', N'gdfg', N'dfgdf', N'gdfgdf', N'dfgdf', N'gdfgdf', N'gdfgdf', N'gdfgdfg', N'gdf', N'dfgdfg', N'0')
GO
SET IDENTITY_INSERT [dbo].[historialEventos] OFF
GO
SET IDENTITY_INSERT [dbo].[mequipos] ON 
GO
INSERT [dbo].[mequipos] ([Id], [Tipo], [Marca], [Modelo], [Color], [Condicion], [Numero_de_activo], [Numero_serial], [Fecha_fabricacion], [fecha_adquisicion], [Fecha_expiracion_garantia_1], [Fecha_expiracion_garantia_2], [Fecha_final_vida_util], [Fecha_descarte], [Precio], [Cantidad]) VALUES (1, N'monitor', N'hp', N'hp-45658', N'azul', N'Usada', 15, N'4545456', CAST(N'2023-11-09T10:40:00.0000000' AS DateTime2), CAST(N'2023-11-16T10:40:00.0000000' AS DateTime2), CAST(N'2023-11-09T10:40:00.0000000' AS DateTime2), CAST(N'2023-11-13T10:40:00.0000000' AS DateTime2), CAST(N'2023-11-22T10:40:00.0000000' AS DateTime2), CAST(N'2023-11-17T10:40:00.0000000' AS DateTime2), 5800, 0)
GO
INSERT [dbo].[mequipos] ([Id], [Tipo], [Marca], [Modelo], [Color], [Condicion], [Numero_de_activo], [Numero_serial], [Fecha_fabricacion], [fecha_adquisicion], [Fecha_expiracion_garantia_1], [Fecha_expiracion_garantia_2], [Fecha_final_vida_util], [Fecha_descarte], [Precio], [Cantidad]) VALUES (2, N'monitor', N'hp', N'crv', N'azul', N'Dañada', 3434, N'34343', CAST(N'2023-11-16T11:12:00.0000000' AS DateTime2), CAST(N'2023-11-09T11:12:00.0000000' AS DateTime2), CAST(N'2023-11-10T11:12:00.0000000' AS DateTime2), CAST(N'2023-11-24T11:12:00.0000000' AS DateTime2), CAST(N'2023-11-07T11:12:00.0000000' AS DateTime2), CAST(N'2023-11-03T11:12:00.0000000' AS DateTime2), 58004, 0)
GO
INSERT [dbo].[mequipos] ([Id], [Tipo], [Marca], [Modelo], [Color], [Condicion], [Numero_de_activo], [Numero_serial], [Fecha_fabricacion], [fecha_adquisicion], [Fecha_expiracion_garantia_1], [Fecha_expiracion_garantia_2], [Fecha_final_vida_util], [Fecha_descarte], [Precio], [Cantidad]) VALUES (3, N'gfhgf', N'hgfhfghfg', N'hfghfghfg', N'hfghfgh', N'Usada', 545654, N'5465', CAST(N'2023-11-21T11:21:00.0000000' AS DateTime2), CAST(N'2023-11-19T11:21:00.0000000' AS DateTime2), CAST(N'2023-11-18T11:21:00.0000000' AS DateTime2), CAST(N'2023-11-17T11:21:00.0000000' AS DateTime2), CAST(N'2023-11-08T11:21:00.0000000' AS DateTime2), CAST(N'2023-11-03T00:21:00.0000000' AS DateTime2), 5600, 0)
GO
INSERT [dbo].[mequipos] ([Id], [Tipo], [Marca], [Modelo], [Color], [Condicion], [Numero_de_activo], [Numero_serial], [Fecha_fabricacion], [fecha_adquisicion], [Fecha_expiracion_garantia_1], [Fecha_expiracion_garantia_2], [Fecha_final_vida_util], [Fecha_descarte], [Precio], [Cantidad]) VALUES (4, N'gfhgfh', N'gfhhgf', N'gfhhgf', N'gfhfg', N'Nueva', 6657765, N'7657687', CAST(N'2023-11-15T16:53:00.0000000' AS DateTime2), CAST(N'2023-11-15T16:53:00.0000000' AS DateTime2), CAST(N'2023-11-15T16:53:00.0000000' AS DateTime2), CAST(N'2023-11-15T16:53:00.0000000' AS DateTime2), CAST(N'2023-11-15T16:53:00.0000000' AS DateTime2), CAST(N'2023-11-15T16:53:00.0000000' AS DateTime2), 6757657, 0)
GO
INSERT [dbo].[mequipos] ([Id], [Tipo], [Marca], [Modelo], [Color], [Condicion], [Numero_de_activo], [Numero_serial], [Fecha_fabricacion], [fecha_adquisicion], [Fecha_expiracion_garantia_1], [Fecha_expiracion_garantia_2], [Fecha_final_vida_util], [Fecha_descarte], [Precio], [Cantidad]) VALUES (5, N'gfdfdggdfdg', N'gfdgdf', N'dfgdfg', N'fdg', N'Nueva', 54654, N'5656', CAST(N'2023-11-23T17:28:00.0000000' AS DateTime2), CAST(N'2023-11-07T17:28:00.0000000' AS DateTime2), CAST(N'2023-11-11T17:28:00.0000000' AS DateTime2), CAST(N'2023-11-08T17:28:00.0000000' AS DateTime2), CAST(N'2023-11-11T17:28:00.0000000' AS DateTime2), CAST(N'2023-11-03T17:28:00.0000000' AS DateTime2), 5454, 0)
GO
INSERT [dbo].[mequipos] ([Id], [Tipo], [Marca], [Modelo], [Color], [Condicion], [Numero_de_activo], [Numero_serial], [Fecha_fabricacion], [fecha_adquisicion], [Fecha_expiracion_garantia_1], [Fecha_expiracion_garantia_2], [Fecha_final_vida_util], [Fecha_descarte], [Precio], [Cantidad]) VALUES (6, N'dfgdfg', N'dfgdfg', N'fdgdfg', N'dfgdfg', N'Nueva', 546, N'546645', CAST(N'2023-11-02T10:07:00.0000000' AS DateTime2), CAST(N'2023-11-18T10:07:00.0000000' AS DateTime2), CAST(N'2023-11-10T10:07:00.0000000' AS DateTime2), CAST(N'2023-11-14T10:07:00.0000000' AS DateTime2), CAST(N'2023-11-27T10:07:00.0000000' AS DateTime2), CAST(N'2023-11-21T10:07:00.0000000' AS DateTime2), 7777, 0)
GO
INSERT [dbo].[mequipos] ([Id], [Tipo], [Marca], [Modelo], [Color], [Condicion], [Numero_de_activo], [Numero_serial], [Fecha_fabricacion], [fecha_adquisicion], [Fecha_expiracion_garantia_1], [Fecha_expiracion_garantia_2], [Fecha_final_vida_util], [Fecha_descarte], [Precio], [Cantidad]) VALUES (7, N'gfdfg', N'fdgfdg', N'fdgfdg', N'dfg', N'Nueva', 5646546, N'546', CAST(N'2023-11-16T15:01:00.0000000' AS DateTime2), CAST(N'2023-11-16T15:01:00.0000000' AS DateTime2), CAST(N'2023-11-16T15:01:00.0000000' AS DateTime2), CAST(N'2023-11-16T15:01:00.0000000' AS DateTime2), CAST(N'2023-11-16T15:01:00.0000000' AS DateTime2), CAST(N'2023-11-16T15:01:00.0000000' AS DateTime2), 54654, 6)
GO
INSERT [dbo].[mequipos] ([Id], [Tipo], [Marca], [Modelo], [Color], [Condicion], [Numero_de_activo], [Numero_serial], [Fecha_fabricacion], [fecha_adquisicion], [Fecha_expiracion_garantia_1], [Fecha_expiracion_garantia_2], [Fecha_final_vida_util], [Fecha_descarte], [Precio], [Cantidad]) VALUES (1007, N'memoria ram', N'toshiba', N'ddr3', N'verde', N'Nueva', 23223, N'ram-309', CAST(N'2023-11-24T20:48:00.0000000' AS DateTime2), CAST(N'2023-11-24T20:48:00.0000000' AS DateTime2), CAST(N'2023-11-24T20:48:00.0000000' AS DateTime2), CAST(N'2023-11-24T20:48:00.0000000' AS DateTime2), CAST(N'2023-11-24T20:48:00.0000000' AS DateTime2), CAST(N'2023-11-24T20:49:00.0000000' AS DateTime2), 500, 7)
GO
INSERT [dbo].[mequipos] ([Id], [Tipo], [Marca], [Modelo], [Color], [Condicion], [Numero_de_activo], [Numero_serial], [Fecha_fabricacion], [fecha_adquisicion], [Fecha_expiracion_garantia_1], [Fecha_expiracion_garantia_2], [Fecha_final_vida_util], [Fecha_descarte], [Precio], [Cantidad]) VALUES (1008, N'Teclado', N'Hp', N'optic-g40', N'Blanco', N'Usada', 6565, N'fgfg-5565', CAST(N'2023-11-29T14:38:00.0000000' AS DateTime2), CAST(N'2023-11-29T14:38:00.0000000' AS DateTime2), CAST(N'2023-11-29T14:38:00.0000000' AS DateTime2), CAST(N'2023-11-29T14:38:00.0000000' AS DateTime2), CAST(N'2023-11-29T14:38:00.0000000' AS DateTime2), CAST(N'2023-11-29T14:38:00.0000000' AS DateTime2), 5800, 45)
GO
SET IDENTITY_INSERT [dbo].[mequipos] OFF
GO
SET IDENTITY_INSERT [dbo].[registrarMarcas] ON 
GO
INSERT [dbo].[registrarMarcas] ([Id], [Marca]) VALUES (1, N'hp')
GO
INSERT [dbo].[registrarMarcas] ([Id], [Marca]) VALUES (2, N'hp')
GO
INSERT [dbo].[registrarMarcas] ([Id], [Marca]) VALUES (3, N'Huawei')
GO
INSERT [dbo].[registrarMarcas] ([Id], [Marca]) VALUES (4, N'ggg')
GO
SET IDENTITY_INSERT [dbo].[registrarMarcas] OFF
GO
SET IDENTITY_INSERT [dbo].[registroindividuals] ON 
GO
INSERT [dbo].[registroindividuals] ([Id], [Tipo], [Marca], [Modelo], [Número_de_activo_del_banco], [Número_serial_de_fábrica], [Estado], [Color]) VALUES (1025, N'MOUSE', N'Dell', N'Hp', 3432, N'fdgfdg', N'Activo', N'Plata')
GO
INSERT [dbo].[registroindividuals] ([Id], [Tipo], [Marca], [Modelo], [Número_de_activo_del_banco], [Número_serial_de_fábrica], [Estado], [Color]) VALUES (1026, N'Monitor', N'Dell', N'Dell', 2323, N'ewrewr', N'Activo', N'Esmeralda')
GO
INSERT [dbo].[registroindividuals] ([Id], [Tipo], [Marca], [Modelo], [Número_de_activo_del_banco], [Número_serial_de_fábrica], [Estado], [Color]) VALUES (1027, N'TECLADO', N'Dell', N'Hp', 1500, N'gh-gfhg-*ghfghg+@@@@@@@@%$@#', N'Activo', N'Violeta')
GO
INSERT [dbo].[registroindividuals] ([Id], [Tipo], [Marca], [Modelo], [Número_de_activo_del_banco], [Número_serial_de_fábrica], [Estado], [Color]) VALUES (1028, N'MOUSE', N'Lenovo', N'Lenovo', 455454, N'g5-jut-2', N'Activo', N'Amarillo')
GO
INSERT [dbo].[registroindividuals] ([Id], [Tipo], [Marca], [Modelo], [Número_de_activo_del_banco], [Número_serial_de_fábrica], [Estado], [Color]) VALUES (1029, N'MOUSE', N'Dell', N'Lenovo', 3432, N'fdgfdg', N'Activo', N'Esmeralda')
GO
INSERT [dbo].[registroindividuals] ([Id], [Tipo], [Marca], [Modelo], [Número_de_activo_del_banco], [Número_serial_de_fábrica], [Estado], [Color]) VALUES (1030, N'Impresora', N'Dell', N'Dell', 2323, N'fdgfdg', N'Activo', N'Oro')
GO
SET IDENTITY_INSERT [dbo].[registroindividuals] OFF
GO
SET IDENTITY_INSERT [dbo].[solicitudEquipos] ON 
GO
INSERT [dbo].[solicitudEquipos] ([Id], [TipoEquipo], [Procesador], [MemoriaRam], [DiscoDuro], [TarjetaGrafica], [Marca], [Areasolicitada]) VALUES (1, N'laptop', N'intel7', N'32', N'512ssd', N'nvdia-geforce2070tx', N'hp', N'autobanco')
GO
INSERT [dbo].[solicitudEquipos] ([Id], [TipoEquipo], [Procesador], [MemoriaRam], [DiscoDuro], [TarjetaGrafica], [Marca], [Areasolicitada]) VALUES (2, N'laptop', N'fdsfdsf', N'sdf', N'dsf', N'fdsf', N'sdfsd', N'seguro')
GO
INSERT [dbo].[solicitudEquipos] ([Id], [TipoEquipo], [Procesador], [MemoriaRam], [DiscoDuro], [TarjetaGrafica], [Marca], [Areasolicitada]) VALUES (3, N'laptop', N'intel7', N'sdf', N'512ssd', N'fdsf', N'hp', N'ctb')
GO
INSERT [dbo].[solicitudEquipos] ([Id], [TipoEquipo], [Procesador], [MemoriaRam], [DiscoDuro], [TarjetaGrafica], [Marca], [Areasolicitada]) VALUES (4, N'laptop', N'intel7', N'sdf', N'512ssd', N'fdsf', N'hp', N'gomez')
GO
INSERT [dbo].[solicitudEquipos] ([Id], [TipoEquipo], [Procesador], [MemoriaRam], [DiscoDuro], [TarjetaGrafica], [Marca], [Areasolicitada]) VALUES (5, N'laptop', N'fdsfdsf', N'sdf', N'512ssd', N'nvdia-geforce2070tx', N'fghfghgfh', N'ctb')
GO
INSERT [dbo].[solicitudEquipos] ([Id], [TipoEquipo], [Procesador], [MemoriaRam], [DiscoDuro], [TarjetaGrafica], [Marca], [Areasolicitada]) VALUES (6, N'pc', N'amd', N'16', N'1028ssd', N'amd', N'mouse', N'ctb')
GO
INSERT [dbo].[solicitudEquipos] ([Id], [TipoEquipo], [Procesador], [MemoriaRam], [DiscoDuro], [TarjetaGrafica], [Marca], [Areasolicitada]) VALUES (7, N'fdgfdg', N'fdgdfg', N'dfgdfg', N'dfg', N'dfgdf', N'gdfg', N'autobanco')
GO
INSERT [dbo].[solicitudEquipos] ([Id], [TipoEquipo], [Procesador], [MemoriaRam], [DiscoDuro], [TarjetaGrafica], [Marca], [Areasolicitada]) VALUES (8, N'laptop', N'fdgdfg', N'164', N'dsf', N'fdsf', N'dell', N'tarjeta')
GO
INSERT [dbo].[solicitudEquipos] ([Id], [TipoEquipo], [Procesador], [MemoriaRam], [DiscoDuro], [TarjetaGrafica], [Marca], [Areasolicitada]) VALUES (9, N'vbc', N'vccbvc', N'bvcb', N'vcbvc', N'cvcvcv', N'vc', N'seguro')
GO
INSERT [dbo].[solicitudEquipos] ([Id], [TipoEquipo], [Procesador], [MemoriaRam], [DiscoDuro], [TarjetaGrafica], [Marca], [Areasolicitada]) VALUES (10, N'vcbvcb', N'cvb', N'bvcbcv', N'bvcb', N'cvbvc', N'bcvbcv', N'vcbcvbcv')
GO
INSERT [dbo].[solicitudEquipos] ([Id], [TipoEquipo], [Procesador], [MemoriaRam], [DiscoDuro], [TarjetaGrafica], [Marca], [Areasolicitada]) VALUES (11, N'bcvbcv', N'bcvb', N'vcbvc', N'bvcb', N'vcbvc', N'cccccccbcv', N'vcbcv')
GO
INSERT [dbo].[solicitudEquipos] ([Id], [TipoEquipo], [Procesador], [MemoriaRam], [DiscoDuro], [TarjetaGrafica], [Marca], [Areasolicitada]) VALUES (12, N'PC', N'Intel 5', N'16', N'256HDD', N'Amd Vega graphics', N'Toshiba', N'Recurso Humano')
GO
INSERT [dbo].[solicitudEquipos] ([Id], [TipoEquipo], [Procesador], [MemoriaRam], [DiscoDuro], [TarjetaGrafica], [Marca], [Areasolicitada]) VALUES (13, N'laptop', N'intel7', N'32', N'1TB SSD', N'amd-geforce2070tx', N'LG', N'ctb')
GO
SET IDENTITY_INSERT [dbo].[solicitudEquipos] OFF
GO
SET IDENTITY_INSERT [dbo].[suvar203s] ON 
GO
INSERT [dbo].[suvar203s] ([Id], [UnidadEmisora], [Ubicacion], [Oficina], [Codigo], [Fecha], [Telefono], [Numero_de_activo], [Descripcion], [Modelo], [Marca], [Numerodeserie], [color], [Condicion], [Observaciones]) VALUES (1, N'Dirección de Desarrollo de Sistemas Distribuidos', N'CTB', N'CTB', N'CTB', CAST(N'2023-11-24T15:26:00.0000000' AS DateTime2), N'84789789', 176780, N'MONITOR', N'E170Sc', N'DELL', N'CN-0U072N-64180-14T-55SL', N'Negro', N'Usado', N' no hay')
GO
INSERT [dbo].[suvar203s] ([Id], [UnidadEmisora], [Ubicacion], [Oficina], [Codigo], [Fecha], [Telefono], [Numero_de_activo], [Descripcion], [Modelo], [Marca], [Numerodeserie], [color], [Condicion], [Observaciones]) VALUES (2, N'Dirección de Desarrollo de Sistemas Distribuidos', N'ertre', N'dfgdrfg', N'fdgdfg', CAST(N'2023-11-24T20:54:00.0000000' AS DateTime2), N'54656765756', 5656765, N'ta danada', N'lapotp', N'hp', N'CN-0U072N-fg-14T-55SL', N'Negro', N'Usado', N' no hay')
GO
INSERT [dbo].[suvar203s] ([Id], [UnidadEmisora], [Ubicacion], [Oficina], [Codigo], [Fecha], [Telefono], [Numero_de_activo], [Descripcion], [Modelo], [Marca], [Numerodeserie], [color], [Condicion], [Observaciones]) VALUES (3, N'Dirección de Desarrollo de Sistemas Distribuidos', N'CTB', N'CTB', N'1234', CAST(N'2023-11-29T12:07:00.0000000' AS DateTime2), N'84789789', 48454654, N'buenos dias', N'hp-45658', N'toyota', N'CN-0U072N-64180-14T-55SL', N'Negro', N'Usado', N' no hay')
GO
INSERT [dbo].[suvar203s] ([Id], [UnidadEmisora], [Ubicacion], [Oficina], [Codigo], [Fecha], [Telefono], [Numero_de_activo], [Descripcion], [Modelo], [Marca], [Numerodeserie], [color], [Condicion], [Observaciones]) VALUES (4, N'Dirección de Desarrollo de Sistemas Distribuidos', N'CTB', N'CTB', N'1234', CAST(N'2023-11-29T12:11:00.0000000' AS DateTime2), N'84789789', 478789, N'ta danada', N'optic-g40', N'yutyu', N'CN-0U072N-64180-14T-55SL', N'Negro', N'Usado', N' no hay')
GO
INSERT [dbo].[suvar203s] ([Id], [UnidadEmisora], [Ubicacion], [Oficina], [Codigo], [Fecha], [Telefono], [Numero_de_activo], [Descripcion], [Modelo], [Marca], [Numerodeserie], [color], [Condicion], [Observaciones]) VALUES (5, N'Dirección de Desarrollo de Sistemas Distribuidos', N'CTB', N'CTB', N'1234', CAST(N'2023-11-29T12:13:00.0000000' AS DateTime2), N'84789789', 454556, N'buenos dias', N'hp-45658', N'mouse', N'CN-0U072N-64180-14T-55SL', N'Negro', N'Usado', N' no hay')
GO
INSERT [dbo].[suvar203s] ([Id], [UnidadEmisora], [Ubicacion], [Oficina], [Codigo], [Fecha], [Telefono], [Numero_de_activo], [Descripcion], [Modelo], [Marca], [Numerodeserie], [color], [Condicion], [Observaciones]) VALUES (6, N'ctb', N'CTB', N'CTB', N'1234', CAST(N'2023-11-29T12:17:00.0000000' AS DateTime2), N'54656765756', 756877, N'ta danada', N'hp-45658', N'honda', N'CN-0U072N-64180-14T-55SL', N'Negro', N'Usado', N'ytrtry')
GO
INSERT [dbo].[suvar203s] ([Id], [UnidadEmisora], [Ubicacion], [Oficina], [Codigo], [Fecha], [Telefono], [Numero_de_activo], [Descripcion], [Modelo], [Marca], [Numerodeserie], [color], [Condicion], [Observaciones]) VALUES (7, N'SS', N'CTB', N'CTB', N'1111', CAST(N'2023-11-29T12:24:00.0000000' AS DateTime2), N'84789789', 44544564, N'buenos dias', N'hp-45658', N'honda', N'CN-0U072N-fg-14T-55SL', N'Negro', N'Usado', N' no hay')
GO
SET IDENTITY_INSERT [dbo].[suvar203s] OFF
GO
ALTER TABLE [dbo].[asignarAreaEquipos] ADD  DEFAULT (N'') FOR [Marca]
GO
ALTER TABLE [dbo].[asignarAreaEquipos] ADD  DEFAULT (N'') FOR [Tipo]
GO
ALTER TABLE [dbo].[mequipos] ADD  DEFAULT ((0)) FOR [Cantidad]
GO
ALTER TABLE [dbo].[solicitudEquipos] ADD  DEFAULT (N'') FOR [Areasolicitada]
GO
