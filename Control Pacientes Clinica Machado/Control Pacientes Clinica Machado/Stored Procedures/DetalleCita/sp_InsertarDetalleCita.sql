USE ClinicaMachado;
GO

IF OBJECT_ID('sp_InsertarDetalleCita') IS NOT NULL
BEGIN 
    DROP PROC sp_InsertarDetalleCita 
END 
GO
CREATE PROC sp_InsertarDetalleCita
    @Citas_IdCita int,
    @MaterialesUsados varchar(100),
    @ProcedimientoRealizado varchar(500)
AS 
	SET NOCOUNT ON 
BEGIN
	
	INSERT INTO [dbo].[DetalleCita] ([Citas_IdCita], [MaterialesUsados], [ProcedimientoRealizado])
	SELECT @Citas_IdCita, @MaterialesUsados, @ProcedimientoRealizado
	
END
GO