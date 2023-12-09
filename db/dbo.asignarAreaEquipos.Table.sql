USE [gestionbrr]
GO
/****** Object:  Table [dbo].[asignarAreaEquipos]    Script Date: 09/12/2023 12:15:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[asignarAreaEquipos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Id_Equipo] [int] NOT NULL,
	[Area_Asignada] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_asignarAreaEquipos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[asignarAreaEquipos] ON 

INSERT [dbo].[asignarAreaEquipos] ([Id], [Id_Equipo], [Area_Asignada]) VALUES (27, 50255, N'CTB')
INSERT [dbo].[asignarAreaEquipos] ([Id], [Id_Equipo], [Area_Asignada]) VALUES (28, 502551, N'CTB')
SET IDENTITY_INSERT [dbo].[asignarAreaEquipos] OFF
GO
