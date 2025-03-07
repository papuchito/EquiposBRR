USE [gestionbrr]
GO
/****** Object:  Table [dbo].[mequipos]    Script Date: 14/12/2023 11:21:47 ******/
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
SET IDENTITY_INSERT [dbo].[mequipos] ON 

INSERT [dbo].[mequipos] ([Id], [Tipo], [Marca], [Modelo], [Color], [Condicion], [Numero_de_activo], [Numero_serial], [Fecha_fabricacion], [fecha_adquisicion], [Fecha_expiracion_garantia_1], [Fecha_expiracion_garantia_2], [Fecha_final_vida_util], [Fecha_descarte], [Precio], [Cantidad]) VALUES (1014, N'Altavoz', N'Dell', N'optic-g40', N'Naranja', N'Nueva', 2022, N'fgfg-5565', CAST(N'2023-12-13T00:00:00.0000000' AS DateTime2), CAST(N'2023-12-13T00:00:00.0000000' AS DateTime2), CAST(N'2023-12-13T00:00:00.0000000' AS DateTime2), CAST(N'2023-12-13T00:00:00.0000000' AS DateTime2), CAST(N'2023-12-13T00:00:00.0000000' AS DateTime2), CAST(N'2023-12-13T00:00:00.0000000' AS DateTime2), 5800, 25)
INSERT [dbo].[mequipos] ([Id], [Tipo], [Marca], [Modelo], [Color], [Condicion], [Numero_de_activo], [Numero_serial], [Fecha_fabricacion], [fecha_adquisicion], [Fecha_expiracion_garantia_1], [Fecha_expiracion_garantia_2], [Fecha_final_vida_util], [Fecha_descarte], [Precio], [Cantidad]) VALUES (1015, N'Monitor', N'Dell', N'hp-45658', N'Verde', N'Nueva', 25485, N'ram-2004', CAST(N'2023-10-11T00:00:00.0000000' AS DateTime2), CAST(N'2023-08-30T00:00:00.0000000' AS DateTime2), CAST(N'2023-09-01T00:00:00.0000000' AS DateTime2), CAST(N'2023-12-08T00:00:00.0000000' AS DateTime2), CAST(N'2023-12-15T00:00:00.0000000' AS DateTime2), CAST(N'2023-12-01T00:00:00.0000000' AS DateTime2), 58004, 5)
SET IDENTITY_INSERT [dbo].[mequipos] OFF
GO
ALTER TABLE [dbo].[mequipos] ADD  DEFAULT ((0)) FOR [Cantidad]
GO
