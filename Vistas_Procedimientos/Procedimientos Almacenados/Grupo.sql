
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

