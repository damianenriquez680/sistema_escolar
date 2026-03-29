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