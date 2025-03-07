USE [gestionbrr]
GO
/****** Object:  Table [dbo].[asignarEquipoEmpleados]    Script Date: 14/12/2023 11:21:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[asignarEquipoEmpleados](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ID_del_Equipo] [int] NOT NULL,
	[Asignado] [nvarchar](max) NOT NULL,
	[Estado] [nvarchar](max) NOT NULL,
	[Fecha_de_Asignacion] [datetime2](7) NOT NULL,
	[Ubicación_Actual] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_asignarEquipoEmpleados] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[asignarEquipoEmpleados] ON 

INSERT [dbo].[asignarEquipoEmpleados] ([Id], [ID_del_Equipo], [Asignado], [Estado], [Fecha_de_Asignacion], [Ubicación_Actual]) VALUES (3, 50255, N'Pablo Mercader Alcantara', N'activo', CAST(N'2023-12-11T00:00:00.0000000' AS DateTime2), N'esquina, Av Enrique Jiménez Moya &, Santo Domingo')
INSERT [dbo].[asignarEquipoEmpleados] ([Id], [ID_del_Equipo], [Asignado], [Estado], [Fecha_de_Asignacion], [Ubicación_Actual]) VALUES (6, 502551, N'Nehemias Alexander', N'activo', CAST(N'2023-12-11T00:00:00.0000000' AS DateTime2), N'esquina, Av Enrique Jiménez Moya &, Santo Domingo')
INSERT [dbo].[asignarEquipoEmpleados] ([Id], [ID_del_Equipo], [Asignado], [Estado], [Fecha_de_Asignacion], [Ubicación_Actual]) VALUES (7, 15041, N'Patricio Estrella', N'activo', CAST(N'2023-12-15T00:00:00.0000000' AS DateTime2), N'Calle 8 N*23')
INSERT [dbo].[asignarEquipoEmpleados] ([Id], [ID_del_Equipo], [Asignado], [Estado], [Fecha_de_Asignacion], [Ubicación_Actual]) VALUES (8, 65454, N'juan pablo', N'activo', CAST(N'2023-11-16T00:00:00.0000000' AS DateTime2), N'gddd')
SET IDENTITY_INSERT [dbo].[asignarEquipoEmpleados] OFF
GO
/****** Object:  Index [IX_asignarEquipoEmpleados]    Script Date: 14/12/2023 11:21:47 ******/
ALTER TABLE [dbo].[asignarEquipoEmpleados] ADD  CONSTRAINT [IX_asignarEquipoEmpleados] UNIQUE NONCLUSTERED 
(
	[ID_del_Equipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[asignarEquipoEmpleados] ADD  DEFAULT (N'') FOR [Asignado]
GO
ALTER TABLE [dbo].[asignarEquipoEmpleados] ADD  DEFAULT (N'') FOR [Estado]
GO
ALTER TABLE [dbo].[asignarEquipoEmpleados] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [Fecha_de_Asignacion]
GO
ALTER TABLE [dbo].[asignarEquipoEmpleados] ADD  DEFAULT (N'') FOR [Ubicación_Actual]
GO
