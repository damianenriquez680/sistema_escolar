
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