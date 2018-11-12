USE ClinicaMachado;
GO

IF OBJECT_ID('sp_ActualizarPaciente') IS NOT NULL
BEGIN 
    DROP PROC sp_ActualizarPaciente 
END 
GO
CREATE PROC sp_ActualizarPaciente
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
	UPDATE [dbo].[Paciente]
	SET    [Nombre] = @Nombre, [FechaCreacion] = @FechaCreacion, [Apellido] = @Apellido, [Edad] = @Edad, [Direccion] = @Direccion, [Telefono] = @Telefono, [Ciudad] = @Ciudad, [FechaNacimineto] = @FechaNacimineto, [Ocupacion] = @Ocupacion, [Tutor] = @Tutor, [Observaciones] = @Observaciones, [NombreDelDoctorQueRefiere] = @NombreDelDoctorQueRefiere
	WHERE  [Identidad] = @Identidad
END
GO