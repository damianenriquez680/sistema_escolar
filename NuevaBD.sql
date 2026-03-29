USE [master]
GO

-- Si ya existe la base, se elimina (opcional)
IF DB_ID('DS3_Catalogos') IS NOT NULL
BEGIN
    ALTER DATABASE [DS3_Catalogos] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE [DS3_Catalogos];
END
GO

-- Crear la base
CREATE DATABASE [DS3_Catalogos]
GO

-- Usar la base creada
USE [DS3_Catalogos]
GO

-- Configuración básica
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- 1. Tabla Pais
CREATE TABLE [dbo].[Pais](
	[IDPais] [int] IDENTITY(1,1) NOT NULL,
	[NombrePais] [varchar](50) NULL,
	[SiglaPais] [char](10) NULL,
	[FechaHoraCreacion] [datetime] NULL,
 CONSTRAINT [PK_Pais] PRIMARY KEY CLUSTERED 
(
	[IDPais] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Pais] ADD  CONSTRAINT [DF_Pais_FechaHoraCreacion]  DEFAULT (getdate()) FOR [FechaHoraCreacion]
GO

-- 2. Tabla Estado
CREATE TABLE [dbo].[Estado](
	[IDEstado] [int] IDENTITY(1,1) NOT NULL,
	[NombreEstado] [varchar](50) NULL,
	[SiglaEstado] [varchar](10) NULL,
	[IDPais] [int] NULL,
	[FechaHoraCreacion] [datetime] NULL,
 CONSTRAINT [PK_Estado] PRIMARY KEY CLUSTERED 
(
	[IDEstado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Estado] ADD  CONSTRAINT [DF_Estado_FechaHoraCreacion]  DEFAULT (getdate()) FOR [FechaHoraCreacion]
GO

ALTER TABLE [dbo].[Estado]  WITH CHECK ADD  CONSTRAINT [FK_Estado_Pais] FOREIGN KEY([IDPais])
REFERENCES [dbo].[Pais] ([IDPais])
GO

ALTER TABLE [dbo].[Estado] CHECK CONSTRAINT [FK_Estado_Pais]
GO

-- 3. Tabla Ciudad
CREATE TABLE [dbo].[Ciudad](
	[IDCiudad] [int] IDENTITY(1,1) NOT NULL,
	[NombreCiudad] [varchar](50) NULL,
	[SiglasCiudad] [varchar](10) NULL,
	[IDEstado] [int] NULL,
	[FechaHoraCreacion] [datetime] NULL,
 CONSTRAINT [PK_Ciudad] PRIMARY KEY CLUSTERED 
(
	[IDCiudad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Ciudad] ADD  CONSTRAINT [DF_Ciudad_FechaHoraCreacion]  DEFAULT (getdate()) FOR [FechaHoraCreacion]
GO

ALTER TABLE [dbo].[Ciudad]  WITH CHECK ADD  CONSTRAINT [FK_Ciudad_Estado] FOREIGN KEY([IDEstado])
REFERENCES [dbo].[Estado] ([IDEstado])
GO

ALTER TABLE [dbo].[Ciudad] CHECK CONSTRAINT [FK_Ciudad_Estado]
GO

-- 4. Tabla Carrera
CREATE TABLE [dbo].[Carrera](
	[IDCarrera] [int] IDENTITY(1,1) NOT NULL,
	[NombreCarrera] [varchar](50) NULL,
	[SiglasCarrera] [varchar](10) NULL,
	[FechaHoraCreacion] [datetime] NULL,
 CONSTRAINT [PK_Carrera] PRIMARY KEY CLUSTERED 
(
	[IDCarrera] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Carrera] ADD  CONSTRAINT [DF_Carrera_FechaHoraCreacion]  DEFAULT (getdate()) FOR [FechaHoraCreacion]
GO

-- 5. Tabla Aula
CREATE TABLE [dbo].[Aula](
	[IDAula] [int] IDENTITY(1,1) NOT NULL,
	[Edificio] [varchar](50) NULL,
	[NombreAula] [varchar](50) NULL,
	[Piso] [varchar](10) NULL,
	[CapacidadMaxima] [int] NULL,
	[FechaHoraCreacion] [datetime] NULL,
 CONSTRAINT [PK_Aula] PRIMARY KEY CLUSTERED 
(
	[IDAula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Aula] ADD  CONSTRAINT [DF_Aula_FechaHoraCreacion]  DEFAULT (getdate()) FOR [FechaHoraCreacion]
GO

-- 6. Tabla Estatus
CREATE TABLE [dbo].[Estatus](
	[IDEstatus] [int] IDENTITY(1,1) NOT NULL,
	[ClaveEstatus] [varchar](30) NULL,
	[NombreEstatus] [varchar](50) NULL,
	[FechaHoraCreacion] [datetime] NULL,
	[Usuario] [varchar](30) NULL,
 CONSTRAINT [PK_Estatus] PRIMARY KEY CLUSTERED 
(
	[IDEstatus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Estatus] ADD  CONSTRAINT [DF_Estatus_FechaHoraCreacion]  DEFAULT (getdate()) FOR [FechaHoraCreacion]
GO

-- 7. Tabla Alumno
CREATE TABLE [dbo].[Alumno](
	[IDAlumno] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellidos] [varchar](50) NULL,
	[Estatus] [varchar](30) NULL,
	[FechaHoraCreacion] [datetime] NULL,
 CONSTRAINT [PK_Alumno] PRIMARY KEY CLUSTERED 
(
	[IDAlumno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Alumno] ADD  CONSTRAINT [DF_Alumno_FechaHoraCreacion]  DEFAULT (getdate()) FOR [FechaHoraCreacion]
GO

-- 8. Tabla Academico
CREATE TABLE [dbo].[Academico](
	[IDAcademico] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellidos] [varchar](50) NULL,
	[Grado] [varchar](30) NULL,
	[FechaHoraCreacion] [datetime] NULL,
 CONSTRAINT [PK_Academico] PRIMARY KEY CLUSTERED 
(
	[IDAcademico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Academico] ADD  CONSTRAINT [DF_Academico_FechaHoraCreacion]  DEFAULT (getdate()) FOR [FechaHoraCreacion]
GO

-- 9. Tabla Materia
CREATE TABLE [dbo].[Materia](
    [IDMateria] INT IDENTITY(1,1) NOT NULL,
    [NombreMateria] VARCHAR(50) NULL,
    [Creditos] INT NULL,
    [FechaHoraCreacion] DATETIME NULL,
    CONSTRAINT [PK_Materia] PRIMARY KEY CLUSTERED ([IDMateria] ASC)
) ON [PRIMARY]
GO

-- 10. Tabla Grupo
CREATE TABLE [dbo].[Grupo](
	[IDGrupo] [int] IDENTITY(1,1) NOT NULL,
	[IDMaestro] [int] NULL,
	[IDAula] [int] NULL,
	[Horario] [varchar](30) NULL,
	[IDCarrera] [int] NULL,
 CONSTRAINT [PK_Grupo] PRIMARY KEY CLUSTERED 
(
	[IDGrupo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Grupo]  WITH CHECK ADD  CONSTRAINT [FK_Grupo_Academico] FOREIGN KEY([IDMaestro])
REFERENCES [dbo].[Academico] ([IDAcademico])
GO

ALTER TABLE [dbo].[Grupo] CHECK CONSTRAINT [FK_Grupo_Academico]
GO

ALTER TABLE [dbo].[Grupo]  WITH CHECK ADD  CONSTRAINT [FK_Grupo_Aula] FOREIGN KEY([IDAula])
REFERENCES [dbo].[Aula] ([IDAula])
GO

ALTER TABLE [dbo].[Grupo] CHECK CONSTRAINT [FK_Grupo_Aula]
GO

ALTER TABLE [dbo].[Grupo]  WITH CHECK ADD  CONSTRAINT [FK_Grupo_Carrera] FOREIGN KEY([IDCarrera])
REFERENCES [dbo].[Carrera] ([IDCarrera])
GO

ALTER TABLE [dbo].[Grupo] CHECK CONSTRAINT [FK_Grupo_Carrera]
GO

-- 11. Tabla Reinscripcion
CREATE TABLE [dbo].[Reinscripcion](
	[IDReinscripcion] [int] IDENTITY(1,1) NOT NULL,
	[IDGrupo] [int] NULL,
	[IDAlumno] [int] NULL,
	[Calificacion] [varchar](30) NULL,
	[FechaHoraCreacion] [datetime] NULL,
 CONSTRAINT [PK_Reinscripcion] PRIMARY KEY CLUSTERED 
(
	[IDReinscripcion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Reinscripcion] ADD  CONSTRAINT [DF_Reinscripcion_FechaHoraCreacion]  DEFAULT (getdate()) FOR [FechaHoraCreacion]
GO

ALTER TABLE [dbo].[Reinscripcion]  WITH CHECK ADD  CONSTRAINT [FK_Reinscripcion_Alumno] FOREIGN KEY([IDAlumno])
REFERENCES [dbo].[Alumno] ([IDAlumno])
GO

ALTER TABLE [dbo].[Reinscripcion] CHECK CONSTRAINT [FK_Reinscripcion_Alumno]
GO

ALTER TABLE [dbo].[Reinscripcion]  WITH CHECK ADD  CONSTRAINT [FK_Reinscripcion_Grupo] FOREIGN KEY([IDGrupo])
REFERENCES [dbo].[Grupo] ([IDGrupo])
GO

ALTER TABLE [dbo].[Reinscripcion] CHECK CONSTRAINT [FK_Reinscripcion_Grupo]
GO

-- Configurar la base para lectura/escritura
USE [master]
GO
ALTER DATABASE [DS3_Catalogos] SET READ_WRITE
GO

-- Agregar relación Grupo - Materia
ALTER TABLE [DS3_Catalogos].[dbo].[Grupo] ADD [IDMateria] [int] NULL;
GO

ALTER TABLE [DS3_Catalogos].[dbo].[Grupo] WITH CHECK ADD CONSTRAINT [FK_Grupo_Materia] 
FOREIGN KEY([IDMateria]) REFERENCES [dbo].[Materia] ([IDMateria]);
GO

ALTER TABLE [DS3_Catalogos].[dbo].[Grupo] CHECK CONSTRAINT [FK_Grupo_Materia];
GO
-- Agregar relación Alumno - Carrera
ALTER TABLE [DS3_Catalogos].[dbo].[Alumno] ADD [IDCarrera] [int] NULL;
GO

ALTER TABLE [DS3_Catalogos].[dbo].[Alumno] WITH CHECK ADD CONSTRAINT [FK_Alumno_Carrera] 
FOREIGN KEY([IDCarrera]) REFERENCES [dbo].[Carrera] ([IDCarrera]);
GO

ALTER TABLE [DS3_Catalogos].[dbo].[Alumno] CHECK CONSTRAINT [FK_Alumno_Carrera];
GO

-- Agregar relación Alumno - Ciudad
ALTER TABLE [DS3_Catalogos].[dbo].[Alumno] ADD [IDCiudad] [int] NULL;
GO

ALTER TABLE [DS3_Catalogos].[dbo].[Alumno] WITH CHECK ADD CONSTRAINT [FK_Alumno_Ciudad] 
FOREIGN KEY([IDCiudad]) REFERENCES [dbo].[Ciudad] ([IDCiudad]);
GO

ALTER TABLE [DS3_Catalogos].[dbo].[Alumno] CHECK CONSTRAINT [FK_Alumno_Ciudad];
GO

-- Agregar relación Academico - Ciudad
ALTER TABLE [DS3_Catalogos].[dbo].[Academico] ADD [IDCiudad] [int] NULL;
GO

ALTER TABLE [DS3_Catalogos].[dbo].[Academico] WITH CHECK ADD CONSTRAINT [FK_Academico_Ciudad] 
FOREIGN KEY([IDCiudad]) REFERENCES [dbo].[Ciudad] ([IDCiudad]);
GO

ALTER TABLE [DS3_Catalogos].[dbo].[Academico] CHECK CONSTRAINT [FK_Academico_Ciudad];
GO

-- Agregar columna FechaHoraCreacion a Grupo
ALTER TABLE [DS3_Catalogos].[dbo].[Grupo] ADD [FechaHoraCreacion] [datetime] NULL;
GO

-- Agregar constraint para valor por defecto
ALTER TABLE [DS3_Catalogos].[dbo].[Grupo] ADD CONSTRAINT [DF_Grupo_FechaHoraCreacion]  
DEFAULT (getdate()) FOR [FechaHoraCreacion];
GO