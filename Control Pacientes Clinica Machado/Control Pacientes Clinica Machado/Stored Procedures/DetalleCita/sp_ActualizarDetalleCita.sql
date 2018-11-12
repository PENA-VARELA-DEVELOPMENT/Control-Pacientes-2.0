USE ClinicaMachado;
GO

IF OBJECT_ID('sp_ActualizarDetalleCita') IS NOT NULL
BEGIN 
    DROP PROC sp_ActualizarDetalleCita
END 
GO
CREATE PROC sp_ActualizarDetalleCita
    @IdDetalleCita int,
    @Citas_IdCita int,
    @MaterialesUsados varchar(100),
    @ProcedimientoRealizado varchar(500)
AS 
	SET NOCOUNT ON 
BEGIN

	UPDATE [dbo].[DetalleCita]
	SET    [Citas_IdCita] = @Citas_IdCita, [MaterialesUsados] = @MaterialesUsados, [ProcedimientoRealizado] = @ProcedimientoRealizado
	WHERE  [IdDetalleCita] = @IdDetalleCita
	
END
GO