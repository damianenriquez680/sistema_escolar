
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



