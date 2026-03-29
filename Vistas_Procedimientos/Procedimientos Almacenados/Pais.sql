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




