USE ClinicaMachado;
GO

IF OBJECT_ID('sp_EliminarPaciente') IS NOT NULL
BEGIN 
    DROP PROC sp_EliminarPaciente 
END 
GO


CREATE PROC sp_EliminarPaciente
    @Identidad varchar(15)
AS 
	SET NOCOUNT ON 
BEGIN

	DELETE
	FROM   [dbo].[Paciente]
	WHERE  [Identidad] = @Identidad
END
GO