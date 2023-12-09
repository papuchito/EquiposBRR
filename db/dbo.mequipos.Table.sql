USE [gestionbrr]
GO
/****** Object:  Table [dbo].[mequipos]    Script Date: 09/12/2023 12:15:49 ******/
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
ALTER TABLE [dbo].[mequipos] ADD  DEFAULT ((0)) FOR [Cantidad]
GO
ALTER TABLE [dbo].[mequipos]  WITH CHECK ADD  CONSTRAINT [FK_mequipos_asignarAreaEquipos] FOREIGN KEY([Id])
REFERENCES [dbo].[asignarAreaEquipos] ([Id])
GO
ALTER TABLE [dbo].[mequipos] CHECK CONSTRAINT [FK_mequipos_asignarAreaEquipos]
GO
ALTER TABLE [dbo].[mequipos]  WITH CHECK ADD  CONSTRAINT [FK_mequipos_asignarEquipoEmpleados] FOREIGN KEY([Id])
REFERENCES [dbo].[asignarEquipoEmpleados] ([Id])
GO
ALTER TABLE [dbo].[mequipos] CHECK CONSTRAINT [FK_mequipos_asignarEquipoEmpleados]
GO
ALTER TABLE [dbo].[mequipos]  WITH CHECK ADD  CONSTRAINT [FK_mequipos_registroindividuals] FOREIGN KEY([Id])
REFERENCES [dbo].[registroindividuals] ([Id])
GO
ALTER TABLE [dbo].[mequipos] CHECK CONSTRAINT [FK_mequipos_registroindividuals]
GO
