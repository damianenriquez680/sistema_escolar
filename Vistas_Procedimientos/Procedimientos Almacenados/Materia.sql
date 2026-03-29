
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
