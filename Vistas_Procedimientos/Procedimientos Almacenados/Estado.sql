
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
