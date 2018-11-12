USE ClinicaMachado;
GO

IF OBJECT_ID('sp_ListarDetalleCita') IS NOT NULL
BEGIN 
    DROP PROC sp_ListarDetalleCita
END 
GO
CREATE PROC sp_ListarDetalleCita
    @IdDetalleCita int
AS 
	SET NOCOUNT ON 
BEGIN
	SELECT [IdDetalleCita], [Citas_IdCita], [MaterialesUsados], [ProcedimientoRealizado] 
	FROM   [dbo].[DetalleCita] 
	WHERE  ([IdDetalleCita] = @IdDetalleCita OR @IdDetalleCita IS NULL) 
END
GO