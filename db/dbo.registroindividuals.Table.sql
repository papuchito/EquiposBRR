USE [gestionbrr]
GO
/****** Object:  Table [dbo].[registroindividuals]    Script Date: 09/12/2023 12:15:49 ******/
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
SET IDENTITY_INSERT [dbo].[registroindividuals] OFF
GO
ALTER TABLE [dbo].[registroindividuals] ADD  DEFAULT ((0)) FOR [Id_Equipo]
GO
