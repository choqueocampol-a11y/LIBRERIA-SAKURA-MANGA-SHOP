-- Corrección de los procedimientos sp_ListarComprasDelDia y sp_ObtenerTotalCompradoDelDia
-- Ejecutar contra la base Libreria ya existente.

USE Libreria;
GO

ALTER PROCEDURE sp_ListarComprasDelDia
AS
BEGIN
    SELECT 
        C.ID_Compra,
        P.Nombre_Empresa AS Nombre_Proveedor,
        U.Nombre AS Nombre_Usuario,
        C.Fecha,
        C.Total_Pagado
    FROM Compras C
    INNER JOIN Proveedores P ON C.ID_Proveedor = P.ID_Proveedor
    INNER JOIN Usuarios U ON C.ID_Usuario = U.ID_Usuario
    WHERE CAST(C.Fecha AS DATE) = CAST(GETDATE() AS DATE);
END;
GO

ALTER PROCEDURE sp_ObtenerTotalCompradoDelDia
AS
BEGIN
    SELECT ISNULL(SUM(Total_Pagado), 0) AS Total_Comprado_Hoy
    FROM Compras
    WHERE CAST(Fecha AS DATE) = CAST(GETDATE() AS DATE);
END;
GO
