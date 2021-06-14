 DECLARE @Fecha DateTime

SET @Fecha = CAST('1978/21/12' AS DateTime)
SELECT  MONTH(@Fecha)