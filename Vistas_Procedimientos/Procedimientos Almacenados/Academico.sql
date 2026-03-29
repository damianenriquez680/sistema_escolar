
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Marquez Martinez Perla Jazmin>
-- Create date: <25-10-2025>
-- Description:	<STORED PROCEDURES PARA TABLA ACADEMICO>
-- =============================================
CREATE OR ALTER PROCEDURE dbo.stpAcademicoInserta
	-- Add the parameters for the stored procedure here
    @Nombre varchar(50),
    @Apellidos varchar(50),
    @Grado varchar(30),
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
    SET @Mensaje = 'Académico insertado correctamente'
    
	INSERT INTO DS3_Catalogos.dbo.Academico (Nombre, Apellidos, Grado, IDCiudad)
    VALUES (@Nombre, @Apellidos, @Grado, @IDCiudad)
END
GO

-- Actualizar Académico
CREATE OR ALTER PROCEDURE dbo.stpAcademicoActualiza
	-- Add the parameters for the stored procedure here
    @IDAcademico int,
    @Nombre varchar(50),
    @Apellidos varchar(50),
    @Grado varchar(30),
    @IDCiudad int,
    @Regreso bit OUTPUT,
    @Mensaje varchar(100) OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
    SET NOCOUNT ON;
    
    -- Insert statements for procedure here
    IF EXISTS(SELECT IDAcademico FROM DS3_Catalogos.dbo.Academico WHERE IDAcademico = @IDAcademico) BEGIN
        UPDATE DS3_Catalogos.dbo.Academico
        SET Nombre = @Nombre,
            Apellidos = @Apellidos,
            Grado = @Grado,
            IDCiudad = @IDCiudad
        WHERE IDAcademico = @IDAcademico
        
        SET @Regreso = 1
        SET @Mensaje = 'Se actualizó el académico con ID ' + CONVERT(varchar(5), @IDAcademico)
    END
    ELSE BEGIN
        SET @Regreso = 0
        SET @Mensaje = 'No existe el IDAcademico'
    END
END
GO

-- Eliminar Académico
CREATE OR ALTER PROCEDURE dbo.stpAcademicoElimina
	-- Add the parameters for the stored procedure here
    @IDAcademico int,
    @Regreso bit OUTPUT,
    @Mensaje varchar(100) OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
    SET NOCOUNT ON;
    
     -- Insert statements for procedure here
    IF EXISTS(SELECT IDAcademico FROM DS3_Catalogos.dbo.Academico WHERE IDAcademico = @IDAcademico) BEGIN
        DELETE FROM DS3_Catalogos.dbo.Academico
        WHERE IDAcademico = @IDAcademico
        
        SET @Regreso = 1
        SET @Mensaje = 'Se eliminó el académico con ID ' + CONVERT(varchar(5), @IDAcademico)
    END
    ELSE BEGIN
        SET @Regreso = 0
        SET @Mensaje = 'No existe el IDAcademico'
    END
END
GO