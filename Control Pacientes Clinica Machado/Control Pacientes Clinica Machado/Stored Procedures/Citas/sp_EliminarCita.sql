USE ClinicaMachado;
GO

IF OBJECT_ID('sp_EliminarCita') IS NOT NULL
BEGIN 
    DROP PROC sp_EliminarCita 
END 
GO
CREATE PROC sp_EliminarCita 
    @IdCita int
AS 
	SET NOCOUNT ON 
BEGIN

	DELETE
	FROM   [dbo].[Citas]
	WHERE  [IdCita] = @IdCita
	
END
GO