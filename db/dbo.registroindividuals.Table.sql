USE [gestionbrr]
GO
/****** Object:  Table [dbo].[registroindividuals]    Script Date: 14/12/2023 11:21:47 ******/
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
	[Id_Equipo] [int] NOT NULL,
 CONSTRAINT [PK_registroindividuals] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[registroindividuals] ON 

INSERT [dbo].[registroindividuals] ([Id], [Tipo], [Marca], [Modelo], [Número_de_activo_del_banco], [Número_serial_de_fábrica], [Estado], [Color], [Id_Equipo]) VALUES (1035, N'Monitor', N'Acer', N'hp-45658', 153045, N'ram-2004', N'Activo', N'Azul', 50255)
INSERT [dbo].[registroindividuals] ([Id], [Tipo], [Marca], [Modelo], [Número_de_activo_del_banco], [Número_serial_de_fábrica], [Estado], [Color], [Id_Equipo]) VALUES (1036, N'Monitor', N'Acer', N'hp-45658', 343231, N'ram-2004', N'Activo', N'Azul', 502551)
INSERT [dbo].[registroindividuals] ([Id], [Tipo], [Marca], [Modelo], [Número_de_activo_del_banco], [Número_serial_de_fábrica], [Estado], [Color], [Id_Equipo]) VALUES (1037, N'Mouse', N'Asus', N'jk-mm45', 78986532, N'0154-01', N'Activo', N'Morado', 15041)
INSERT [dbo].[registroindividuals] ([Id], [Tipo], [Marca], [Modelo], [Número_de_activo_del_banco], [Número_serial_de_fábrica], [Estado], [Color], [Id_Equipo]) VALUES (1038, N'Monitor', N'Dell', N'hp-45658', 25485, N'ram-2004	', N'Disponible', N'Verde', 65454)
INSERT [dbo].[registroindividuals] ([Id], [Tipo], [Marca], [Modelo], [Número_de_activo_del_banco], [Número_serial_de_fábrica], [Estado], [Color], [Id_Equipo]) VALUES (1039, N'Teclado', N'Acer', N'cc', 44, N'khkg-45', N'Disponible', N'Azul', 4444)
INSERT [dbo].[registroindividuals] ([Id], [Tipo], [Marca], [Modelo], [Número_de_activo_del_banco], [Número_serial_de_fábrica], [Estado], [Color], [Id_Equipo]) VALUES (1041, N'Monitor', N'Asus', N'hp-f', 3432, N'ff', N'Disponible', N'Rojo', 654546)
SET IDENTITY_INSERT [dbo].[registroindividuals] OFF
GO
/****** Object:  Index [IX_registroindividuals id equipo]    Script Date: 14/12/2023 11:21:47 ******/
ALTER TABLE [dbo].[registroindividuals] ADD  CONSTRAINT [IX_registroindividuals id equipo] UNIQUE NONCLUSTERED 
(
	[Id_Equipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[registroindividuals] ADD  DEFAULT ((0)) FOR [Id_Equipo]
GO
ALTER TABLE [dbo].[registroindividuals]  WITH CHECK ADD  CONSTRAINT [FK_registroindividuals_registroindividuals] FOREIGN KEY([Id])
REFERENCES [dbo].[registroindividuals] ([Id])
GO
ALTER TABLE [dbo].[registroindividuals] CHECK CONSTRAINT [FK_registroindividuals_registroindividuals]
GO
ALTER TABLE [dbo].[registroindividuals]  WITH CHECK ADD  CONSTRAINT [FK_registroindividuals_registroindividuals1] FOREIGN KEY([Id])
REFERENCES [dbo].[registroindividuals] ([Id])
GO
ALTER TABLE [dbo].[registroindividuals] CHECK CONSTRAINT [FK_registroindividuals_registroindividuals1]
GO
