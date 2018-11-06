USE ClinicaMachado;
GO

IF OBJECT_ID('sp_InsertarPaciente') IS NOT NULL
BEGIN 
    DROP PROC sp_InsertarPaciente 
END 
GO
CREATE PROC sp_InsertarPaciente 
    @Identidad varchar(15),
    @Nombre varchar(50),
    @FechaCreacion datetime,
    @Apellido varchar(50),
    @Edad int,
    @Direccion varchar(1000),
    @Telefono tinyint,
    @Ciudad varchar(100),
    @FechaNacimineto date,
    @Ocupacion varchar(100),
    @Tutor varchar(200),
	@Observaciones varchar(2000),
    @NombreDelDoctorQueRefiere varchar(200) = NULL
AS 
	SET NOCOUNT ON 
	BEGIN
	
	INSERT INTO [dbo].[Paciente] ([Identidad], [Nombre], [FechaCreacion], [Apellido], [Edad], [Direccion], [Telefono], [Ciudad], [FechaNacimineto], [Ocupacion], [Tutor], [Observaciones], [NombreDelDoctorQueRefiere])
	SELECT @Identidad, @Nombre, @FechaCreacion, @Apellido, @Edad, @Direccion, @Telefono, @Ciudad, @FechaNacimineto, @Ocupacion, @Tutor, @Observaciones, @NombreDelDoctorQueRefiere
	
	END
GO