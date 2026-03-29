
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
