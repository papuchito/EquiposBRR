USE [gestionbrr]
GO
/****** Object:  Table [dbo].[historialEventos]    Script Date: 11/12/2023 15:30:49 ******/
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
ALTER TABLE [dbo].[historialEventos] ADD  DEFAULT ((0)) FOR [Id_Equipo]
GO

