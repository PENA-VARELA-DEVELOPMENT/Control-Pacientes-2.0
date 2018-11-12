USE ClinicaMachado;
GO

IF OBJECT_ID('sp_ListarPaciente') IS NOT NULL
BEGIN 
    DROP PROC sp_ListarPaciente 
END 
GO
CREATE PROC sp_ListarPaciente
    @Identidad varchar(15)
AS 
	SET NOCOUNT ON 
	BEGIN

	SELECT [Identidad], [Nombre], [FechaCreacion], [Apellido], [Edad], [Direccion], [Telefono], [Ciudad], [FechaNacimineto], [Ocupacion], [Tutor], [Observaciones] , [NombreDelDoctorQueRefiere] 
	FROM   [dbo].[Paciente] 
	WHERE  ([Identidad] = @Identidad OR @Identidad IS NULL) 

	END
GO
