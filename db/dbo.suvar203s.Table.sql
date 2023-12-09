USE [gestionbrr]
GO
/****** Object:  Table [dbo].[suvar203s]    Script Date: 09/12/2023 12:15:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[suvar203s](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UnidadEmisora] [nvarchar](max) NOT NULL,
	[Ubicacion] [nvarchar](max) NOT NULL,
	[Oficina] [nvarchar](max) NOT NULL,
	[Codigo] [int] NOT NULL,
	[Fecha] [datetime2](7) NOT NULL,
	[Telefono] [nvarchar](max) NOT NULL,
	[Numero_de_activo] [int] NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
	[Modelo] [nvarchar](max) NOT NULL,
	[Marca] [nvarchar](max) NOT NULL,
	[Numerodeserie] [nvarchar](max) NOT NULL,
	[Color] [nvarchar](max) NOT NULL,
	[Condicion] [nvarchar](max) NOT NULL,
	[Observaciones] [nvarchar](max) NOT NULL,
	[CodigoReceptor] [int] NOT NULL,
 CONSTRAINT [PK_suvar203s] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[suvar203s] ADD  DEFAULT ((0)) FOR [CodigoReceptor]
GO
