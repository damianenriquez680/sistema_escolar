USE DS3_Catalogos
GO

-- =============================================
-- ACADEMICO
-- =============================================

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Marquez Martinez Perla Jazmin>
-- Create date: <25-10-2025>
-- Description:	<STORED PROCEDURES PARA TABLA ACADEMICO>
-- =============================================
CREATE OR ALTER PROCEDURE dbo.stpAcademicoInserta
	-- Add the parameters for the stored procedure here
    @Nombre varchar(50),
    @Apellidos varchar(50),
    @Grado varchar(30),
    @IDCiudad int,
    @Regreso bit OUTPUT,
    @Mensaje varchar(100) OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    
    -- Insert statements for procedure here
    SET @Regreso = 1
    SET @Mensaje = 'Académico insertado correctamente'
    
	INSERT INTO DS3_Catalogos.dbo.Academico (Nombre, Apellidos, Grado, IDCiudad)
    VALUES (@Nombre, @Apellidos, @Grado, @IDCiudad)
END
GO

-- Actualizar Académico
CREATE OR ALTER PROCEDURE dbo.stpAcademicoActualiza
	-- Add the parameters for the stored procedure here
    @IDAcademico int,
    @Nombre varchar(50),
    @Apellidos varchar(50),
    @Grado varchar(30),
    @IDCiudad int,
    @Regreso bit OUTPUT,
    @Mensaje varchar(100) OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
    SET NOCOUNT ON;
    
    -- Insert statements for procedure here
    IF EXISTS(SELECT IDAcademico FROM DS3_Catalogos.dbo.Academico WHERE IDAcademico = @IDAcademico) BEGIN
        UPDATE DS3_Catalogos.dbo.Academico
        SET Nombre = @Nombre,
            Apellidos = @Apellidos,
            Grado = @Grado,
            IDCiudad = @IDCiudad
        WHERE IDAcademico = @IDAcademico
        
        SET @Regreso = 1
        SET @Mensaje = 'Se actualizó el académico con ID ' + CONVERT(varchar(5), @IDAcademico)
    END
    ELSE BEGIN
        SET @Regreso = 0
        SET @Mensaje = 'No existe el IDAcademico'
    END
END
GO

-- Eliminar Académico
CREATE OR ALTER PROCEDURE dbo.stpAcademicoElimina
	-- Add the parameters for the stored procedure here
    @IDAcademico int,
    @Regreso bit OUTPUT,
    @Mensaje varchar(100) OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
    SET NOCOUNT ON;
    
     -- Insert statements for procedure here
    IF EXISTS(SELECT IDAcademico FROM DS3_Catalogos.dbo.Academico WHERE IDAcademico = @IDAcademico) BEGIN
        DELETE FROM DS3_Catalogos.dbo.Academico
        WHERE IDAcademico = @IDAcademico
        
        SET @Regreso = 1
        SET @Mensaje = 'Se eliminó el académico con ID ' + CONVERT(varchar(5), @IDAcademico)
    END
    ELSE BEGIN
        SET @Regreso = 0
        SET @Mensaje = 'No existe el IDAcademico'
    END
END
GO

-- =============================================
-- ALUMNO
-- =============================================

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Marquez Martinez Perla Jazmin>
-- Create date: <25-10-2025>
-- Description:	<STORED PROCEDURES PARA TABLA ALUMNO>
-- =============================================

CREATE OR ALTER PROCEDURE dbo.stpAlumnoInserta
	-- Add the parameters for the stored procedure here
	@Nombre varchar(50),
    @Apellidos varchar(50),
    @Estatus varchar(30),
    @IDCarrera int,
    @IDCiudad int,
    @Regreso bit OUTPUT,
    @Mensaje varchar(100) OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    
    -- Insert statements for procedure here
    SET @Regreso = 1
    SET @Mensaje = 'Alumno insertado correctamente'
    
    INSERT INTO DS3_Catalogos.dbo.Alumno (Nombre, Apellidos, Estatus, IDCarrera, IDCiudad)
    VALUES (@Nombre, @Apellidos, @Estatus, @IDCarrera, @IDCiudad)
END
GO

-- Actualizar Alumno
CREATE OR ALTER PROCEDURE dbo.stpAlumnoActualiza
    -- Add the parameters for the stored procedure here
    @IDAlumno int,
    @Nombre varchar(50),
    @Apellidos varchar(50),
    @Estatus varchar(30),
    @IDCarrera int,
    @IDCiudad int,
    @Regreso bit OUTPUT,
    @Mensaje varchar(100) OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
    SET NOCOUNT ON;
    
    -- Insert statements for procedure here
    IF EXISTS(SELECT IDAlumno FROM DS3_Catalogos.dbo.Alumno WHERE IDAlumno = @IDAlumno) BEGIN
        UPDATE DS3_Catalogos.dbo.Alumno
        SET Nombre = @Nombre,
            Apellidos = @Apellidos,
            Estatus = @Estatus,
            IDCarrera = @IDCarrera,
            IDCiudad = @IDCiudad
        WHERE IDAlumno = @IDAlumno
        
        SET @Regreso = 1
        SET @Mensaje = 'Se actualizó el alumno con ID ' + CONVERT(varchar(5), @IDAlumno)
    END
    ELSE BEGIN
        SET @Regreso = 0
        SET @Mensaje = 'No existe el IDAlumno'
    END
END
GO

-- Eliminar Alumno
CREATE OR ALTER PROCEDURE dbo.stpAlumnoElimina
    -- Add the parameters for the stored procedure here
    @IDAlumno int,
    @Regreso bit OUTPUT,
    @Mensaje varchar(100) OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
    SET NOCOUNT ON;
 
    -- Insert statements for procedure here
    IF EXISTS(SELECT IDAlumno FROM DS3_Catalogos.dbo.Alumno WHERE IDAlumno = @IDAlumno) BEGIN
        DELETE FROM DS3_Catalogos.dbo.Alumno
        WHERE IDAlumno = @IDAlumno
        
        SET @Regreso = 1
        SET @Mensaje = 'Se eliminó el alumno con ID ' + CONVERT(varchar(5), @IDAlumno)
    END
    ELSE BEGIN
        SET @Regreso = 0
        SET @Mensaje = 'No existe el IDAlumno'
    END
END
GO

-- =============================================
-- CARRERA
-- =============================================

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Marquez Martinez Perla Jazmin>
-- Create date: <25-10-2025>
-- Description:	<STORED PROCEDURES PARA TABLA CARRERA>
-- =============================================
CREATE OR ALTER PROCEDURE dbo.stpCarreraInserta
	-- Add the parameters for the stored procedure here
    @NombreCarrera varchar(50),
    @SiglasCarrera varchar(10),
    @Regreso bit OUTPUT,
    @Mensaje varchar(100) OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SET @Regreso = 1
    SET @Mensaje = 'Carrera insertada correctamente'
    
    INSERT INTO DS3_Catalogos.dbo.Carrera (NombreCarrera, SiglasCarrera)
    VALUES (@NombreCarrera, @SiglasCarrera)
END
GO

-- Actualizar Carrera
CREATE OR ALTER PROCEDURE dbo.stpCarreraActualiza
-- Add the parameters for the stored procedure here
    @IDCarrera int,
    @NombreCarrera varchar(50),
    @SiglasCarrera varchar(10),
    @Regreso bit OUTPUT,
    @Mensaje varchar(100) OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
    SET NOCOUNT ON;
    
    -- Insert statements for procedure here
    IF EXISTS(SELECT IDCarrera FROM DS3_Catalogos.dbo.Carrera WHERE IDCarrera = @IDCarrera) BEGIN
        UPDATE DS3_Catalogos.dbo.Carrera
        SET NombreCarrera = @NombreCarrera,
            SiglasCarrera = @SiglasCarrera
        WHERE IDCarrera = @IDCarrera
        
        SET @Regreso = 1
        SET @Mensaje = 'Se actualizó la carrera con ID ' + CONVERT(varchar(5), @IDCarrera)
    END
    ELSE BEGIN
        SET @Regreso = 0
        SET @Mensaje = 'No existe el IDCarrera'
    END
END
GO

-- Eliminar Carrera
CREATE OR ALTER PROCEDURE dbo.stpCarreraElimina
-- Add the parameters for the stored procedure here
    @IDCarrera int,
    @Regreso bit OUTPUT,
    @Mensaje varchar(100) OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
    SET NOCOUNT ON;
    
    -- Insert statements for procedure here
    IF EXISTS(SELECT IDCarrera FROM DS3_Catalogos.dbo.Carrera WHERE IDCarrera = @IDCarrera) BEGIN
        DELETE FROM DS3_Catalogos.dbo.Carrera
        WHERE IDCarrera = @IDCarrera
        
        SET @Regreso = 1
        SET @Mensaje = 'Se eliminó la carrera con ID ' + CONVERT(varchar(5), @IDCarrera)
    END
    ELSE BEGIN
        SET @Regreso = 0
        SET @Mensaje = 'No existe el IDCarrera'
    END
END
GO

-- =============================================
-- CIUDAD
-- =============================================

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Marquez Martinez Perla Jazmin>
-- Create date: <25-10-2025>
-- Description:	<STORED PROCEDURES PARA TABLA CIUDAD>
-- =============================================
CREATE OR ALTER PROCEDURE  dbo.stpCiudadInserta
	-- Add the parameters for the stored procedure here
    @NombreCiudad varchar(50),
    @SiglasCiudad varchar(10),
    @IDEstado int,
    @Regreso bit OUTPUT,
    @Mensaje varchar(100) OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
    SET @Regreso = 1
    SET @Mensaje = 'Ciudad insertada correctamente'
    
    INSERT INTO DS3_Catalogos.dbo.Ciudad (NombreCiudad, SiglasCiudad, IDEstado)
    VALUES (@NombreCiudad, @SiglasCiudad, @IDEstado)
END
GO

-- Actualizar Ciudad
CREATE OR ALTER PROCEDURE dbo.stpCiudadActualiza
-- Add the parameters for the stored procedure here
    @IDCiudad int,
    @NombreCiudad varchar(50),
    @SiglasCiudad varchar(10),
    @IDEstado int,
    @Regreso bit OUTPUT,
    @Mensaje varchar(100) OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
    SET NOCOUNT ON;
    
    -- Insert statements for procedure here
    IF EXISTS(SELECT IDCiudad FROM DS3_Catalogos.dbo.Ciudad WHERE IDCiudad = @IDCiudad) BEGIN
        UPDATE DS3_Catalogos.dbo.Ciudad
        SET NombreCiudad = @NombreCiudad,
            SiglasCiudad = @SiglasCiudad,
            IDEstado = @IDEstado
        WHERE IDCiudad = @IDCiudad
        
        SET @Regreso = 1
        SET @Mensaje = 'Se actualizó la ciudad con ID ' + CONVERT(varchar(5), @IDCiudad)
    END
    ELSE BEGIN
        SET @Regreso = 0
        SET @Mensaje = 'No existe el IDCiudad'
    END
END
GO

-- Eliminar Ciudad
CREATE OR ALTER PROCEDURE dbo.stpCiudadElimina
-- Add the parameters for the stored procedure here
    @IDCiudad int,
    @Regreso bit OUTPUT,
    @Mensaje varchar(100) OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
    SET NOCOUNT ON;
    
    -- Insert statements for procedure here
    IF EXISTS(SELECT IDCiudad FROM DS3_Catalogos.dbo.Ciudad WHERE IDCiudad = @IDCiudad) BEGIN
        DELETE FROM DS3_Catalogos.dbo.Ciudad
        WHERE IDCiudad = @IDCiudad
        
        SET @Regreso = 1
        SET @Mensaje = 'Se eliminó la ciudad con ID ' + CONVERT(varchar(5), @IDCiudad)
    END
    ELSE BEGIN
        SET @Regreso = 0
        SET @Mensaje = 'No existe el IDCiudad'
    END
END
GO

-- =============================================
-- AULA
-- =============================================

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Marquez Martinez Perla Jazmin>
-- Create date: <25-10-2025>
-- Description:	<STORED PROCEDURES PARA TABLA AULA>
-- =============================================
CREATE OR ALTER PROCEDURE dbo.stpAulaInserta
	-- Add the parameters for the stored procedure here
	@Edificio varchar(50),
    @NombreAula varchar(50),
    @Piso varchar(10),
    @CapacidadMaxima int,
    @Regreso bit OUTPUT,
    @Mensaje varchar(100) OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SET @Regreso = 1
    SET @Mensaje = 'Aula insertada correctamente'
    
    INSERT INTO DS3_Catalogos.dbo.Aula (Edificio, NombreAula, Piso, CapacidadMaxima)
    VALUES (@Edificio, @NombreAula, @Piso, @CapacidadMaxima)
END
GO

-- Actualizar Aula
CREATE OR ALTER PROCEDURE dbo.stpAulaActualiza
-- Add the parameters for the stored procedure here
    @IDAula int,
    @Edificio varchar(50),
    @NombreAula varchar(50),
    @Piso varchar(10),
    @CapacidadMaxima int,
    @Regreso bit OUTPUT,
    @Mensaje varchar(100) OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
    SET NOCOUNT ON;
    
    -- Insert statements for procedure here
    IF EXISTS(SELECT IDAula FROM DS3_Catalogos.dbo.Aula WHERE IDAula = @IDAula) BEGIN
        UPDATE DS3_Catalogos.dbo.Aula
        SET Edificio = @Edificio,
            NombreAula = @NombreAula,
            Piso = @Piso,
            CapacidadMaxima = @CapacidadMaxima
        WHERE IDAula = @IDAula
        
        SET @Regreso = 1
        SET @Mensaje = 'Se actualizó el aula con ID ' + CONVERT(varchar(5), @IDAula)
    END
    ELSE BEGIN
        SET @Regreso = 0
        SET @Mensaje = 'No existe el IDAula'
    END
END
GO

-- Eliminar Aula
CREATE OR ALTER PROCEDURE dbo.stpAulaElimina
-- Add the parameters for the stored procedure here
    @IDAula int,
    @Regreso bit OUTPUT,
    @Mensaje varchar(100) OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
    SET NOCOUNT ON;
    
    -- Insert statements for procedure here
    IF EXISTS(SELECT IDAula FROM DS3_Catalogos.dbo.Aula WHERE IDAula = @IDAula) BEGIN
        DELETE FROM DS3_Catalogos.dbo.Aula
        WHERE IDAula = @IDAula
        
        SET @Regreso = 1
        SET @Mensaje = 'Se eliminó el aula con ID ' + CONVERT(varchar(5), @IDAula)
    END
    ELSE BEGIN
        SET @Regreso = 0
        SET @Mensaje = 'No existe el IDAula'
    END
END
GO

-- =============================================
-- ESTADO
-- =============================================

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Marquez Martinez Perla Jazmin>
-- Create date: <25-10-2025>
-- Description:	<STORED PROCEDURES PARA TABLA ESTADO>
-- =============================================
CREATE OR ALTER PROCEDURE dbo.stpEstadoInserta 
	-- Add the parameters for the stored procedure here
	@NombreEstado varchar(50),
    @SiglaEstado varchar(10),
    @IDPais int,
    @Regreso bit OUTPUT,
    @Mensaje varchar(100) OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
    SET @Regreso = 1
    SET @Mensaje = 'Estado insertado correctamente'

    INSERT INTO DS3_Catalogos.dbo.Estado (NombreEstado, SiglaEstado, IDPais)
    VALUES (@NombreEstado, @SiglaEstado, @IDPais)
END
GO

-- Actualizar Estado
CREATE OR ALTER PROCEDURE dbo.stpEstadoActualiza
    -- Add the parameters for the stored procedure here
    @IDEstado int,
    @NombreEstado varchar(50),
    @SiglaEstado varchar(10),
    @IDPais int,
    @Regreso bit OUTPUT,
    @Mensaje varchar(100) OUTPUT
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
    SET NOCOUNT ON;

    -- Insert statements for procedure here
    IF EXISTS(SELECT IDEstado FROM DS3_Catalogos.dbo.Estado WHERE IDEstado = @IDEstado) BEGIN
        UPDATE DS3_Catalogos.dbo.Estado
        SET NombreEstado = @NombreEstado,
            SiglaEstado = @SiglaEstado,
            IDPais = @IDPais
        WHERE IDEstado = @IDEstado
        
        SET @Regreso = 1
        SET @Mensaje = 'Se actualizó el estado con ID ' + CONVERT(varchar(5), @IDEstado)
    END
    ELSE BEGIN
        SET @Regreso = 0
        SET @Mensaje = 'No existe el IDEstado'
    END
END
GO

-- Eliminar Estado
CREATE OR ALTER PROCEDURE dbo.stpEstadoElimina
    -- Add the parameters for the stored procedure here
    @IDEstado int,
    @Regreso bit OUTPUT,
    @Mensaje varchar(100) OUTPUT
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
    SET NOCOUNT ON;
    
     -- Insert statements for procedure here
    IF EXISTS(SELECT IDEstado FROM DS3_Catalogos.dbo.Estado WHERE IDEstado = @IDEstado) BEGIN
        DELETE FROM DS3_Catalogos.dbo.Estado
        WHERE IDEstado = @IDEstado
        
        SET @Regreso = 1
        SET @Mensaje = 'Se eliminó el estado con ID ' + CONVERT(varchar(5), @IDEstado)
    END
    ELSE BEGIN
        SET @Regreso = 0
        SET @Mensaje = 'No existe el IDEstado'
    END
END
GO

-- =============================================
-- ESTATUS
-- =============================================

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Marquez Martinez Perla Jazmin>
-- Create date: <25-10-2025>
-- Description:	<STORED PROCEDURES PARA TABLA ESTATUS>
-- =============================================
CREATE OR ALTER PROCEDURE dbo.stpEstatusInserta
-- Add the parameters for the stored procedure here
    @ClaveEstatus varchar(30),
    @NombreEstatus varchar(50),
    @Usuario varchar(30),
    @Regreso bit OUTPUT,
    @Mensaje varchar(100) OUTPUT
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
    SET NOCOUNT ON;
    
    -- Insert statements for procedure here
    SET @Regreso = 1
    SET @Mensaje = 'Estatus insertado correctamente'
    
    INSERT INTO DS3_Catalogos.dbo.Estatus (ClaveEstatus, NombreEstatus, Usuario)
    VALUES (@ClaveEstatus, @NombreEstatus, @Usuario)
END
GO

-- Actualizar Estatus
CREATE OR ALTER PROCEDURE dbo.stpEstatusActualiza
	-- Add the parameters for the stored procedure here
	@IDEstatus int,
    @ClaveEstatus varchar(30),
    @NombreEstatus varchar(50),
    @Usuario varchar(30),
    @Regreso bit OUTPUT,
    @Mensaje varchar(100) OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF EXISTS(SELECT IDEstatus FROM DS3_Catalogos.dbo.Estatus WHERE IDEstatus = @IDEstatus) BEGIN
        UPDATE DS3_Catalogos.dbo.Estatus
        SET ClaveEstatus = @ClaveEstatus,
            NombreEstatus = @NombreEstatus,
            Usuario = @Usuario
        WHERE IDEstatus = @IDEstatus

        SET @Regreso = 1
        SET @Mensaje = 'Se actualizó el estatus con ID ' + CONVERT(varchar(5), @IDEstatus)
    END
    ELSE BEGIN
        SET @Regreso = 0
        SET @Mensaje = 'No existe el IDEstatus'
    END
END
GO

-- Eliminar Estatus
CREATE OR ALTER PROCEDURE dbo.stpEstatusElimina
	-- Add the parameters for the stored procedure here
    @IDEstatus int,
    @Regreso bit OUTPUT,
    @Mensaje varchar(100) OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
    SET NOCOUNT ON;
    
    -- Insert statements for procedure here
    IF EXISTS(SELECT IDEstatus FROM DS3_Catalogos.dbo.Estatus WHERE IDEstatus = @IDEstatus) BEGIN
        DELETE FROM DS3_Catalogos.dbo.Estatus
        WHERE IDEstatus = @IDEstatus
        
        SET @Regreso = 1
        SET @Mensaje = 'Se eliminó el estatus con ID ' + CONVERT(varchar(5), @IDEstatus)
    END
    ELSE BEGIN
        SET @Regreso = 0
        SET @Mensaje = 'No existe el IDEstatus'
    END
END
GO

-- =============================================
-- GRUPO
-- =============================================

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Marquez Martinez Perla Jazmin>
-- Create date: <25-10-2025>
-- Description:	<STORED PROCEDURES PARA TABLA GRUPO>
-- =============================================
CREATE OR ALTER PROCEDURE dbo.stpGrupoInserta
	-- Add the parameters for the stored procedure here
	@IDMaestro int,
    @IDAula int,
    @Horario varchar(30),
    @IDCarrera int,
    @IDMateria int,
    @Regreso bit OUTPUT,
    @Mensaje varchar(100) OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SET @Regreso = 1
    SET @Mensaje = 'Grupo insertado correctamente'

    INSERT INTO DS3_Catalogos.dbo.Grupo (IDMaestro, IDAula, Horario, IDCarrera, IDMateria)
    VALUES (@IDMaestro, @IDAula, @Horario, @IDCarrera, @IDMateria)
END
GO

-- Actualizar Grupo
CREATE OR ALTER PROCEDURE dbo.stpGrupoActualiza
-- Add the parameters for the stored procedure here
    @IDGrupo int,
    @IDMaestro int,
    @IDAula int,
    @Horario varchar(30),
    @IDCarrera int,
    @IDMateria int,
    @Regreso bit OUTPUT,
    @Mensaje varchar(100) OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
    SET NOCOUNT ON;
    
    IF EXISTS(SELECT IDGrupo FROM dbo.Grupo WHERE IDGrupo = @IDGrupo) BEGIN
        UPDATE DS3_Catalogos.dbo.Grupo
        SET IDMaestro = @IDMaestro,
            IDAula = @IDAula,
            Horario = @Horario,
            IDCarrera = @IDCarrera,
            IDMateria = @IDMateria
        WHERE IDGrupo = @IDGrupo
        
    -- Insert statements for procedure here
        SET @Regreso = 1
        SET @Mensaje = 'Se actualizó el grupo con ID ' + CONVERT(varchar(5), @IDGrupo)
    END
    ELSE BEGIN
        SET @Regreso = 0
        SET @Mensaje = 'No existe el IDGrupo'
    END
END
GO

-- Eliminar Grupo
CREATE OR ALTER PROCEDURE dbo.stpGrupoElimina
-- Add the parameters for the stored procedure here
    @IDGrupo int,
    @Regreso bit OUTPUT,
    @Mensaje varchar(100) OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
    SET NOCOUNT ON;
    
    IF EXISTS(SELECT IDGrupo FROM DS3_Catalogos.dbo.Grupo WHERE IDGrupo = @IDGrupo) BEGIN
        DELETE FROM DS3_Catalogos.dbo.Grupo
        WHERE IDGrupo = @IDGrupo

    -- Insert statements for procedure here
        SET @Regreso = 1
        SET @Mensaje = 'Se eliminó el grupo con ID ' + CONVERT(varchar(5), @IDGrupo)
    END
    ELSE BEGIN
        SET @Regreso = 0
        SET @Mensaje = 'No existe el IDGrupo'
    END
END
GO

-- =============================================
-- MATERIA
-- =============================================

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Marquez Martinez Perla Jazmin>
-- Create date: <25-10-2025>
-- Description:	<STORED PROCEDURES PARA TABLA MATERIA>
-- =============================================
CREATE OR ALTER PROCEDURE dbo.stpMateriaInserta
	-- Add the parameters for the stored procedure here
	@NombreMateria varchar(50),
    @Creditos int,
    @Regreso bit OUTPUT,
    @Mensaje varchar(100) OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SET @Regreso = 1
    SET @Mensaje = 'Materia insertada correctamente'
    
    INSERT INTO DS3_Catalogos.dbo.Materia (NombreMateria, Creditos)
    VALUES (@NombreMateria, @Creditos)
	
END
GO

CREATE OR ALTER PROCEDURE dbo.stpMateriaActualiza
	-- Add the parameters for the stored procedure here
	@IDMateria int,
    @NombreMateria varchar(50),
    @Creditos int,
    @Regreso bit OUTPUT,
    @Mensaje varchar(100) OUTPUT
AS
BEGIN
   
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	 IF EXISTS(SELECT IDMateria FROM DS3_Catalogos.dbo.Materia WHERE IDMateria = @IDMateria) BEGIN
        UPDATE DS3_Catalogos.dbo.Materia
        SET NombreMateria = @NombreMateria,
            Creditos = @Creditos
        WHERE IDMateria = @IDMateria

        SET @Regreso = 1
        SET @Mensaje = 'Se actualizó la materia con ID ' + CONVERT(varchar(5), @IDMateria)
    END
    ELSE BEGIN
        SET @Regreso = 0
        SET @Mensaje = 'No existe el IDMateria'
    END
END
GO

CREATE OR ALTER PROCEDURE dbo.stpMateriaElimina
    -- Add the parameters for the stored procedure here
    @IDMateria int,
    @Regreso bit OUTPUT,
    @Mensaje varchar(100) OUTPUT
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
    SET NOCOUNT ON;
    
       -- Insert statements for procedure here
    IF EXISTS(SELECT IDMateria FROM DS3_Catalogos.dbo.Materia WHERE IDMateria = @IDMateria) BEGIN
        DELETE FROM DS3_Catalogos.dbo.Materia
        WHERE IDMateria = @IDMateria
        
        SET @Regreso = 1
        SET @Mensaje = 'Se eliminó la materia con ID ' + CONVERT(varchar(5), @IDMateria)
    END
    ELSE BEGIN
        SET @Regreso = 0
        SET @Mensaje = 'No existe el IDMateria'
    END
END
GO

-- =============================================
-- PAIS
-- =============================================

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Marquez Martinez Perla Jazmin>
-- Create date: <25-10-2025>
-- Description:	<STORED PROCEDURES PARA TABLA PAIS>
-- =============================================
CREATE OR ALTER PROCEDURE dbo.stpPaisInserta
	@NombrePais VARCHAR(50),
    @SiglaPais CHAR(10),
    @Regreso BIT OUTPUT,
    @Mensaje VARCHAR(100) OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SET @Regreso = 1
    SET @Mensaje = 'País insertado correctamente'

	INSERT INTO dbo.Pais (NombrePais, SiglaPais)
    VALUES (@NombrePais, @SiglaPais)
END
GO

-- Actualizar País
CREATE OR ALTER PROCEDURE dbo.stpPaisActualiza
    @IDPais int,
    @NombrePais varchar(50),
    @SiglaPais char(10),
    @Regreso bit OUTPUT,
    @Mensaje varchar(100) OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
    SET NOCOUNT ON;
    
      -- Insert statements for procedure here
    IF EXISTS(SELECT IDPais FROM dbo.Pais WHERE IDPais = @IDPais) BEGIN
        UPDATE dbo.Pais
        SET NombrePais = @NombrePais,
            SiglaPais = @SiglaPais
        WHERE IDPais = @IDPais
        
        SET @Regreso = 1
        SET @Mensaje = 'Se actualizó el país con ID ' + CONVERT(varchar(5), @IDPais)
    END
    ELSE BEGIN
        SET @Regreso = 0
        SET @Mensaje = 'No existe el IDPais'
    END
END
GO

-- Eliminar País
CREATE OR ALTER PROCEDURE dbo.stpPaisElimina
    @IDPais int,
    @Regreso bit OUTPUT,
    @Mensaje varchar(100) OUTPUT
AS
BEGIN
-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
    SET NOCOUNT ON;
    
       -- Insert statements for procedure here
    IF EXISTS(SELECT IDPais FROM dbo.Pais WHERE IDPais = @IDPais) BEGIN
        DELETE FROM dbo.Pais
        WHERE IDPais = @IDPais
        
        SET @Regreso = 1
        SET @Mensaje = 'Se eliminó el país con ID ' + CONVERT(varchar(5), @IDPais)
    END
    ELSE BEGIN
        SET @Regreso = 0
        SET @Mensaje = 'No existe el IDPais'
    END
END
GO

-- =============================================
-- REINSCRIPCION
-- =============================================

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Marquez Martinez Perla Jazmin>
-- Create date: <25-10-2025>
-- Description:	<STORED PROCEDURES PARA TABLA REINSCRIPCION>
-- =============================================
CREATE OR ALTER PROCEDURE dbo.stpReinscripcionInserta
	-- Add the parameters for the stored procedure here
	@IDGrupo int,
    @IDAlumno int,
    @Calificacion varchar(30),
    @Regreso bit OUTPUT,
    @Mensaje varchar(100) OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
    SET @Regreso = 1
    SET @Mensaje = 'Reinscripción insertada correctamente'
    
    INSERT INTO DS3_Catalogos.dbo.Reinscripcion (IDGrupo, IDAlumno, Calificacion)
    VALUES (@IDGrupo, @IDAlumno, @Calificacion)
END
GO

-- Actualizar Reinscripción
CREATE OR ALTER PROCEDURE dbo.stpReinscripcionActualiza
	-- Add the parameters for the stored procedure here
    @IDReinscripcion int,
    @IDGrupo int,
    @IDAlumno int,
    @Calificacion varchar(30),
    @Regreso bit OUTPUT,
    @Mensaje varchar(100) OUTPUT
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
    SET NOCOUNT ON;
    
    -- Insert statements for procedure here
    IF EXISTS(SELECT IDReinscripcion FROM DS3_Catalogos.dbo.Reinscripcion WHERE IDReinscripcion = @IDReinscripcion) BEGIN
        UPDATE DS3_Catalogos.dbo.Reinscripcion
        SET IDGrupo = @IDGrupo,
            IDAlumno = @IDAlumno,
            Calificacion = @Calificacion
        WHERE IDReinscripcion = @IDReinscripcion
        
        SET @Regreso = 1
        SET @Mensaje = 'Se actualizó la reinscripción con ID ' + CONVERT(varchar(5), @IDReinscripcion)
    END
    ELSE BEGIN
        SET @Regreso = 0
        SET @Mensaje = 'No existe el IDReinscripcion'
    END
END
GO

-- Eliminar Reinscripción
CREATE OR ALTER PROCEDURE dbo.stpReinscripcionElimina
	-- Add the parameters for the stored procedure here
    @IDReinscripcion int,
    @Regreso bit OUTPUT,
    @Mensaje varchar(100) OUTPUT
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
    SET NOCOUNT ON;
    
    -- Insert statements for procedure here
    IF EXISTS(SELECT IDReinscripcion FROM DS3_Catalogos.dbo.Reinscripcion WHERE IDReinscripcion = @IDReinscripcion) BEGIN
        DELETE FROM DS3_Catalogos.dbo.Reinscripcion
        WHERE IDReinscripcion = @IDReinscripcion
        
        SET @Regreso = 1
        SET @Mensaje = 'Se eliminó la reinscripción con ID ' + CONVERT(varchar(5), @IDReinscripcion)
    END
    ELSE BEGIN
        SET @Regreso = 0
        SET @Mensaje = 'No existe el IDReinscripcion'
    END
END
GO

-- ASEGURARSE QUE SE HAYAN CREADO
SELECT ROUTINE_SCHEMA, ROUTINE_NAME, ROUTINE_TYPE, CREATED, LAST_ALTERED
FROM INFORMATION_SCHEMA.ROUTINES
WHERE ROUTINE_SCHEMA = 'dbo' AND ROUTINE_TYPE = 'PROCEDURE'
ORDER BY ROUTINE_NAME
