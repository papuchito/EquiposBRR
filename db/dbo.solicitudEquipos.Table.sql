USE [gestionbrr]
GO
/****** Object:  Table [dbo].[solicitudEquipos]    Script Date: 14/12/2023 11:21:47 ******/
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
ALTER TABLE [dbo].[solicitudEquipos] ADD  DEFAULT (N'') FOR [Areasolicitada]
GO
