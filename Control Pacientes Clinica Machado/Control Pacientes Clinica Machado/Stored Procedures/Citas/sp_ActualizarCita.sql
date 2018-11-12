USE ClinicaMachado;
GO

IF OBJECT_ID('sp_ActualizarCita') IS NOT NULL
BEGIN 
    DROP PROC sp_ActualizarCita
END 
GO
CREATE PROC sp_ActualizarCita
    @IdCita int,
    @Fecha date,
    @Hora datetime,
    @paciente_Identidad varchar(15),
    @Doctores_IdDoctor int
AS 
	SET NOCOUNT ON 
BEGIN

	UPDATE [dbo].[Citas]
	SET    [Fecha] = @Fecha, [Hora] = @Hora, [paciente_Identidad] = @paciente_Identidad, [Doctores_IdDoctor] = @Doctores_IdDoctor
	WHERE  [IdCita] = @IdCita
	
END
GO