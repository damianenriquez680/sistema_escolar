USE [DS3_Catalogos]
GO

-- Vista de dbo.Academico
CREATE OR ALTER VIEW [dbo].[vwAcademicoInformacion]
AS
SELECT 
 	a.IDAcademico, 
 	a.Nombre, 
 	a.Apellidos, 
 	a.Grado, 
 	c.NombreCiudad AS Ciudad,
 	a.FechaHoraCreacion AS 'Fecha/Hora Creación'
FROM dbo.Academico a
LEFT JOIN dbo.Ciudad c ON a.IDCiudad = c.IDCiudad
GO

-- Vista de dbo.Alumno
CREATE OR ALTER VIEW [dbo].[vwAlumnoInformacion]
AS
SELECT 
 	a.IDAlumno, 
 	a.Nombre, 
 	a.Apellidos, 
 	a.Estatus, 
 	d.NombreCarrera AS Carrera,
 	c.NombreCiudad AS Ciudad,
 	a.FechaHoraCreacion AS 'Fecha/Hora Creación'
FROM dbo.Alumno a
LEFT JOIN dbo.Carrera d ON a.IDCarrera = d.IDCarrera
LEFT JOIN dbo.Ciudad c ON a.IDCiudad = c.IDCiudad
GO

-- Vista de dbo.Aula
CREATE OR ALTER VIEW [dbo].[vwAulaInformacion]
AS
SELECT 
 	a.IDAula, 
 	a.Edificio, 
 	a.NombreAula AS Nombre,
 	a.Piso, 
 	a.CapacidadMaxima AS 'Capacidad máxima',
 	a.FechaHoraCreacion AS 'Fecha/Hora Creación'
FROM dbo.Aula a
GO

-- Vista de dbo.Carrera
CREATE OR ALTER VIEW [dbo].[vwCarreraInformacion]
AS
SELECT 
 	c.IDCarrera, 
 	c.NombreCarrera AS Nombre, 
 	c.SiglasCarrera AS Siglas, 
 	c.FechaHoraCreacion AS 'Fecha/Hora Creación'
FROM dbo.Carrera c
GO

-- Vista de dbo.Ciudad
CREATE OR ALTER VIEW [dbo].[vwCiudadInformacion]
AS
SELECT 
 	c.IDCiudad, 
 	c.NombreCiudad AS Nombre, 
 	c.SiglasCiudad AS Siglas, 
 	e.NombreEstado AS Estado, 
 	c.FechaHoraCreacion AS 'Fecha/Hora Creación'
FROM dbo.Ciudad c
LEFT JOIN dbo.Estado e ON c.IDEstado = e.IDEstado
GO

-- Vista de dbo.Estado
CREATE OR ALTER VIEW [dbo].[vwEstadoInformacion]
AS
SELECT 
 	e.IDEstado, 
 	e.NombreEstado AS Nombre, 
 	e.SiglaEstado AS Siglas, 
 	p.NombrePais AS Pais, 
 	e.FechaHoraCreacion AS 'Fecha/Hora Creación'
FROM dbo.Estado e
LEFT JOIN dbo.Pais p ON e.IDPais = p.IDPais
GO

-- Vista de dbo.Estatus
CREATE OR ALTER VIEW [dbo].[vwEstatusInformacion]
AS
SELECT 
 	e.IDEstatus, 
 	e.ClaveEstatus AS Clave, 
 	e.NombreEstatus AS Estatus, 
 	e.Usuario, 
 	e.FechaHoraCreacion AS 'Fecha/Hora Creación'
FROM dbo.Estatus e
GO

-- Vista de dbo.Grupo
CREATE OR ALTER VIEW [dbo].[vwGrupoInformacion]
AS
SELECT 
 	g.IDGrupo, 
 	a.Nombre AS Maestro, 
 	b.NombreAula AS Aula, 
 	g.Horario, 
 	c.NombreCarrera AS Carrera, 
 	m.NombreMateria AS Materia, 
 	g.FechaHoraCreacion AS 'Fecha/Hora Creación'
FROM dbo.Grupo g
LEFT JOIN dbo.Academico a ON g.IDMaestro = a.IDAcademico
LEFT JOIN dbo.Aula b ON g.IDAula = b.IDAula
LEFT JOIN dbo.Carrera c ON g.IDCarrera = c.IDCarrera
LEFT JOIN dbo.Materia m ON g.IDMateria = m.IDMateria 
GO

-- Vista de dbo.Materia
CREATE OR ALTER VIEW [dbo].[vwMateriaInformacion]
AS
SELECT
 	m.IDMateria,
 	m.NombreMateria AS Nombre,
 	m.Creditos,
 	m.FechaHoraCreacion AS 'Fecha/Hora Creación'
 	From dbo.Materia m
 	GO
	
-- Vista de dbo.Pais
CREATE OR ALTER VIEW [dbo].[vwPaisInformacion]
AS
SELECT 
p.IDPais,
p.NombrePais AS Nombre,
p.SiglaPais AS Siglas,
p.FechaHoraCreacion AS 'Fecha/Hora Creación'
From dbo.Pais p
Go

-- Vista de dbo.Reinscripcion
CREATE OR ALTER VIEW [dbo].[vwReinscripcionInformacion]
AS
SELECT 
 	r.IDReinscripcion, 
 	a.Nombre + ' ' + a.Apellidos AS Alumno,
 	g.IDGrupo, 
 	g.Horario AS GrupoHorario,
 	r.Calificacion, 
 	r.FechaHoraCreacion AS 'Fecha/Hora Creación'
FROM dbo.Reinscripcion r
LEFT JOIN dbo.Alumno a ON r.IDAlumno = a.IDAlumno
LEFT JOIN dbo.Grupo g ON r.IDGrupo = g.IDGrupo
GO

---- Pruebas de selección de vistas
--SELECT * FROM vwAcademicoInformacion
--SELECT * FROM vwAlumnoInformacion
--SELECT * FROM vwAulaInformacion
--SELECT * FROM vwCarreraInformacion
--SELECT * FROM vwCiudadInformacion
--SELECT * FROM vwEstadoInformacion
--SELECT * FROM vwGrupoInformacion

-- Para ver que sí se están creando las vistas
SELECT TABLE_SCHEMA, TABLE_NAME 
FROM INFORMATION_SCHEMA.VIEWS
WHERE TABLE_SCHEMA = 'dbo'
ORDER BY TABLE_NAME