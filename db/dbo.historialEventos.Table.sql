USE [gestionbrr]
GO
/****** Object:  Table [dbo].[historialEventos]    Script Date: 14/12/2023 11:21:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[historialEventos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Numero_serial] [nvarchar](max) NOT NULL,
	[numero_de_activo] [int] NOT NULL,
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
	[Id_Equipo] [int] NOT NULL,
 CONSTRAINT [PK_historialEventos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[historialEventos] ON 

INSERT [dbo].[historialEventos] ([Id], [Numero_serial], [numero_de_activo], [Fecha], [TipoEvento], [Detalles], [EmpleadoAsignado], [AreaOrigen], [AreaDestino], [SoftwareInstalado], [DetallesMantenimiento], [DetallesReparacion], [DetallesModificacion], [CausaDaño], [Id_Equipo]) VALUES (3, N'ram-2004', 25485, CAST(N'2023-12-14T00:00:00.0000000' AS DateTime2), N'Asignacion', N'Nueva Compra', N'Juan Pablo', N'CTB', N'Tarjeta', N'Windows', N'Ninguno', N'Ninguno', N'Ninguno', N'Ninguno', 65454)
INSERT [dbo].[historialEventos] ([Id], [Numero_serial], [numero_de_activo], [Fecha], [TipoEvento], [Detalles], [EmpleadoAsignado], [AreaOrigen], [AreaDestino], [SoftwareInstalado], [DetallesMantenimiento], [DetallesReparacion], [DetallesModificacion], [CausaDaño], [Id_Equipo]) VALUES (5, N'ram-2004', 5555, CAST(N'2023-12-14T00:00:00.0000000' AS DateTime2), N'Asignacion', N'Nueva Compra', N'Juan Pablo guuuuu', N'CTB', N'Tarjeta', N'Windows', N'Ninguno', N'Ninguno', N'Ninguno', N'Ninguno', 654546)
SET IDENTITY_INSERT [dbo].[historialEventos] OFF
GO
/****** Object:  Index [IX_historialEventos]    Script Date: 14/12/2023 11:21:47 ******/
ALTER TABLE [dbo].[historialEventos] ADD  CONSTRAINT [IX_historialEventos] UNIQUE NONCLUSTERED 
(
	[Id_Equipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[historialEventos] ADD  DEFAULT ((0)) FOR [Id_Equipo]
GO
