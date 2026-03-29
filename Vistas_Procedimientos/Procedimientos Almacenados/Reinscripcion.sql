
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
