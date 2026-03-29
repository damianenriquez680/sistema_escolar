
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