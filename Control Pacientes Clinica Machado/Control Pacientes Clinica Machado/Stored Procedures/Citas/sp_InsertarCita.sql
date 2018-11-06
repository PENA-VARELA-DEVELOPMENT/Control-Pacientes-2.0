USE ClinicaMachado;
GO

IF OBJECT_ID('sp_InsertarCita') IS NOT NULL
BEGIN 
    DROP PROC sp_InsertarCita 
END 
GO
CREATE PROC sp_InsertarCita
    @Fecha date,
    @Hora datetime,
    @paciente_Identidad varchar(15),
    @Doctores_IdDoctor int
AS 
	SET NOCOUNT ON 
BEGIN
	
	INSERT INTO [dbo].[Citas] ([Fecha], [Hora], [paciente_Identidad], [Doctores_IdDoctor])
	SELECT @Fecha, @Hora, @paciente_Identidad, @Doctores_IdDoctor

END
GO