USE ClinicaMachado;
GO

IF OBJECT_ID('sp_ListarCitas') IS NOT NULL
BEGIN 
    DROP PROC sp_ListarCitas 
END 
GO
CREATE PROC sp_ListarCitas
    @IdCita int
AS 
	SET NOCOUNT ON 
BEGIN
	SELECT [IdCita], [Fecha], [Hora], [paciente_Identidad], [Doctores_IdDoctor] 
	FROM   [dbo].[Citas] 
	WHERE  ([IdCita] = @IdCita OR @IdCita IS NULL) 
END
GO