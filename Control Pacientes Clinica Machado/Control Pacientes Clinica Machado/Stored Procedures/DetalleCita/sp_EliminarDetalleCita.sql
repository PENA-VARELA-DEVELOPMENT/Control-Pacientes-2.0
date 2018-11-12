USE ClinicaMachado;
GO

IF OBJECT_ID('sp_EliminarDetalleCita') IS NOT NULL
BEGIN 
    DROP PROC sp_EliminarDetalleCita
END 
GO
CREATE PROC sp_EliminarDetalleCita 
    @IdDetalleCita int
AS 
	SET NOCOUNT ON 
BEGIN

	DELETE
	FROM   [dbo].[DetalleCita]
	WHERE  [IdDetalleCita] = @IdDetalleCita

END
GO