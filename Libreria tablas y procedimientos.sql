Create DataBase Libreria;
Go
Create table Clientes( 
ID_Cliente int identity (1,1) Primary Key,
Nombre Varchar(100)not null,
Celular Varchar(12), 
Gmail Varchar(50)
);

Create table Roles(
ID_Rol int Primary Key,
Nombre_Rol Varchar (50)
);

Create table Usuarios(
ID_Usuario int identity (1,1) Primary Key,
ID_Rol int not null,
Nombre Varchar (50) not null,
Username Varchar (50) not null,
Password varchar (255) not null,
);

Create table Ventas(
ID_Venta int identity (1,1) Primary Key,
ID_Cliente int not null,
ID_Usuario int not null,
Fecha Date,
Monto_Total Decimal (10,2)
);

Create table Detalle_Ventas(
ID_Detalle_Venta int identity (1,1) Primary Key,
ID_Venta int not null,
ID_Producto int not null,
Cantidad int,
Precio_U_Historico Decimal (10,2),
Subtotal Decimal (10,2)
);

Create table Productos(
ID_Producto int identity (1,1) Primary key,
Nombre_Producto Varchar (50) not null,
Autor Varchar (50),
Tomo Varchar (20),
Precio_V_Actual Decimal (10,2) not null,
Stock int, 
Ubicacion varchar (50)
);

Create table Compras(
ID_Compra int identity (1,1) Primary Key,
ID_Proveedor int not null,
ID_Usuario int not null,
Fecha Date,
Total_Pagado Decimal (10,2)
);

Create table Detalle_Compras(
ID_Detalle_Compra int identity (1,1) Primary Key,
ID_Compra int not null,
ID_Producto int not null,
Cantidad_Recibida int not null,
Costo_Unitario Decimal (10,2) not null
);

Create table Proveedores(
ID_Proveedor int identity (1,1) Primary Key,
Nombre_Empresa Varchar (50),
Telefono Varchar (12)
);

-----------Modificacion de tablas------------

-- Modificamos la tabla Ventas
ALTER TABLE Ventas 
ADD Estado VARCHAR(20) NOT NULL DEFAULT 'Activa';

-- Modificamos la tabla Compra
ALTER TABLE Compras 
ADD Estado VARCHAR(20) NOT NULL DEFAULT 'Activa';
GO

---------------RELACIONES DE LAS TABLAS--------------------------------
ALTER TABLE Usuarios ADD CONSTRAINT FK_Usuarios_Roles 
FOREIGN KEY (ID_Rol) REFERENCES Roles(ID_Rol);

ALTER TABLE Ventas ADD CONSTRAINT FK_Ventas_Clientes 
FOREIGN KEY (ID_Cliente) REFERENCES Clientes(ID_Cliente);

ALTER TABLE Ventas ADD CONSTRAINT FK_Ventas_Usuarios 
FOREIGN KEY (ID_Usuario) REFERENCES Usuarios(ID_Usuario);

ALTER TABLE Compras ADD CONSTRAINT FK_Compra_Proveedores 
FOREIGN KEY (ID_Proveedor) REFERENCES Proveedores(ID_Proveedor);

ALTER TABLE Compras ADD CONSTRAINT FK_Compra_Usuarios 
FOREIGN KEY (ID_Usuario) REFERENCES Usuarios(ID_Usuario);

ALTER TABLE Detalle_Ventas ADD CONSTRAINT FK_DetalleVentas_Ventas 
FOREIGN KEY (ID_Venta) REFERENCES Ventas(ID_Venta);

ALTER TABLE Detalle_Ventas ADD CONSTRAINT FK_DetalleVentas_Productos 
FOREIGN KEY (ID_Producto) REFERENCES Productos(ID_Producto);

ALTER TABLE Detalle_Compras ADD CONSTRAINT FK_DetalleCompras_Compras 
FOREIGN KEY (ID_Compra) REFERENCES Compras(ID_Compra);

ALTER TABLE Detalle_Compras ADD CONSTRAINT FK_DetalleCompras_Productos 
FOREIGN KEY (ID_Producto) REFERENCES Productos(ID_Producto);
GO


------------------PROCEDIMIENTOS ALMACENADOS----------------------------------
--  Lista Roles
CREATE PROCEDURE sp_ListarRoles
AS
BEGIN
    SELECT ID_Rol, Nombre_Rol FROM Roles;
END;
GO

-- Validar login
CREATE PROCEDURE sp_ValidarUsuario
    @Username VARCHAR(50),
    @Password VARCHAR(255)
AS
BEGIN
    SELECT U.ID_Usuario, U.Nombre, U.Username, R.Nombre_Rol
    FROM Usuarios U
    INNER JOIN Roles R ON U.ID_Rol = R.ID_Rol
    WHERE U.Username = @Username AND U.Password = @Password;
END;
GO

--Registrar Usuario
CREATE PROCEDURE sp_RegistrarUsuario
    @ID_Rol INT,
    @Nombre VARCHAR(50),
    @Username VARCHAR(50),
    @Password VARCHAR(255)
AS
BEGIN
    INSERT INTO Usuarios (ID_Rol, Nombre, Username, Password)
    VALUES (@ID_Rol, @Nombre, @Username, @Password);
END;
GO

-- Modificar Usuario
CREATE PROCEDURE sp_ModificarUsuario
    @ID_Usuario INT,
    @ID_Rol INT,
    @Nombre VARCHAR(50),
    @Username VARCHAR(50),
    @Password VARCHAR(255)
AS
BEGIN
    UPDATE Usuarios 
    SET ID_Rol = @ID_Rol, Nombre = @Nombre, Username = @Username, Password = @Password
    WHERE ID_Usuario = @ID_Usuario;
END;
GO

--Eliminar Usuario
CREATE PROCEDURE sp_EliminarUsuario
    @ID_Usuario INT
AS
BEGIN
    DELETE FROM Usuarios WHERE ID_Usuario = @ID_Usuario;
END;
GO

--Listar Usuarios
CREATE PROCEDURE sp_ListarUsuarios
AS
BEGIN
    SELECT U.ID_Usuario, U.Nombre, U.Username, R.Nombre_Rol 
    FROM Usuarios U
    INNER JOIN Roles R ON U.ID_Rol = R.ID_Rol;
END;
GO

-- Registrar Cliente
CREATE PROCEDURE sp_RegistrarCliente
    @Nombre VARCHAR(100),
    @Celular VARCHAR(12),
    @Gmail VARCHAR(50)
AS
BEGIN
    INSERT INTO Clientes (Nombre, Celular, Gmail)
    VALUES (@Nombre, @Celular, @Gmail);
END;
GO

-- Modificar Cliente
CREATE PROCEDURE sp_ModificarCliente
    @ID_Cliente INT,
    @Nombre VARCHAR(100),
    @Celular VARCHAR(12),
    @Gmail VARCHAR(50)
AS
BEGIN
    UPDATE Clientes 
    SET Nombre = @Nombre, Celular = @Celular, Gmail = @Gmail
    WHERE ID_Cliente = @ID_Cliente;
END;
GO

-- Eliminar Cliente
CREATE PROCEDURE sp_EliminarCliente
    @ID_Cliente INT
AS
BEGIN
    DELETE FROM Clientes WHERE ID_Cliente = @ID_Cliente;
END;
GO

--  Listar Clientes
CREATE PROCEDURE sp_ListarClientes
AS
BEGIN
    SELECT ID_Cliente, Nombre, Celular, Gmail FROM Clientes;
END;
GO

--  Registrar Producto
CREATE PROCEDURE sp_RegistrarProducto
    @Nombre_Producto VARCHAR(50),
    @Autor VARCHAR(50),
    @Tomo VARCHAR(20),
    @Precio_V_Actual DECIMAL(10,2),
    @Stock INT,
    @Ubicacion VARCHAR(50)
AS
BEGIN
    INSERT INTO Productos (Nombre_Producto, Autor, Tomo, Precio_V_Actual, Stock, Ubicacion)
    VALUES (@Nombre_Producto, @Autor, @Tomo, @Precio_V_Actual, @Stock, @Ubicacion);
END;
GO

-- Modificar Producto
CREATE PROCEDURE sp_ModificarProducto
    @ID_Producto INT,
    @Nombre_Producto VARCHAR(50),
    @Autor VARCHAR(50),
    @Tomo VARCHAR(20),
    @Precio_V_Actual DECIMAL(10,2),
    @Stock INT,
    @Ubicacion VARCHAR(50)
AS
BEGIN
    UPDATE Productos 
    SET Nombre_Producto = @Nombre_Producto, Autor = @Autor, Tomo = @Tomo, 
        Precio_V_Actual = @Precio_V_Actual, Stock = @Stock, Ubicacion = @Ubicacion
    WHERE ID_Producto = @ID_Producto;
END;
GO

-- Eliminar Producto
CREATE PROCEDURE sp_EliminarProducto
    @ID_Producto INT
AS
BEGIN
    DELETE FROM Productos WHERE ID_Producto = @ID_Producto;
END;
GO

-- Listar Productos
CREATE PROCEDURE sp_ListarProductos
AS
BEGIN
    SELECT ID_Producto, Nombre_Producto, Autor, Tomo, Precio_V_Actual, Stock, Ubicacion 
    FROM Productos;
END;
GO
---------------Stock minimo--------------------
CREATE PROCEDURE sp_AlertaStockMinimo
AS
BEGIN
    SELECT 
        ID_Producto,
        Nombre_Producto, 
        Tomo,            
        Stock,          
        Precio_V_Actual  
    FROM Productos
    WHERE Stock <= 3
    ORDER BY Stock ASC;
END;
GO
--  Registrar Proveedor
CREATE PROCEDURE sp_RegistrarProveedor
    @Nombre_Empresa VARCHAR(50),
    @Telefono VARCHAR(12)
AS
BEGIN
    INSERT INTO Proveedores (Nombre_Empresa, Telefono)
    VALUES (@Nombre_Empresa, @Telefono);
END;
GO

--  Modificar Proveedor
CREATE PROCEDURE sp_ModificarProveedor
    @ID_Proveedor INT,
    @Nombre_Empresa VARCHAR(50),
    @Telefono VARCHAR(12)
AS
BEGIN
    UPDATE Proveedores 
    SET Nombre_Empresa = @Nombre_Empresa, Telefono = @Telefono
    WHERE ID_Proveedor = @ID_Proveedor;
END;
GO

-- Eliminar Proveedor
CREATE PROCEDURE sp_EliminarProveedor
    @ID_Proveedor INT
AS
BEGIN
    DELETE FROM Proveedores WHERE ID_Proveedor = @ID_Proveedor;
END;
GO

--  Listar Proveedores
CREATE PROCEDURE sp_ListarProveedores
AS
BEGIN
    SELECT ID_Proveedor, Nombre_Empresa, Telefono FROM Proveedores;
END;
GO

--  Insertar Cabecera de Venta
CREATE PROCEDURE sp_RegistrarVenta
    @ID_Cliente INT,
    @ID_Usuario INT,
    @Monto_Total DECIMAL(10,2),
    @ID_Venta_Generado INT OUTPUT 
AS
BEGIN
    INSERT INTO Ventas (ID_Cliente, ID_Usuario, Fecha, Monto_Total)
    VALUES (@ID_Cliente, @ID_Usuario, GETDATE(), @Monto_Total);
    SET @ID_Venta_Generado = SCOPE_IDENTITY();
END;
GO

CREATE PROCEDURE sp_ListarVentasDelDia
AS
BEGIN
    SELECT 
        V.ID_Venta,
        C.Nombre AS Nombre_Cliente,
        U.Nombre AS Nombre_Usuario,
        V.Fecha,
        V.Monto_Total
    FROM Ventas V
    INNER JOIN Clientes C ON V.ID_Cliente = C.ID_Cliente
    INNER JOIN Usuarios U ON V.ID_Usuario = U.ID_Usuario
    WHERE CAST(V.Fecha AS DATE) = CAST(GETDATE() AS DATE);
END;
GO

CREATE PROCEDURE sp_ObtenerTotalVendidoDelDia
AS
BEGIN
    -- Suma todo el dinero que entró hoy a la caja
    SELECT ISNULL(SUM(Monto_Total), 0) AS Total_Vendido_Hoy
    FROM Ventas
    WHERE CAST(Fecha AS DATE) = CAST(GETDATE() AS DATE);
END;
GO

ALTER PROCEDURE sp_ObtenerTotalVendidoDelDia
AS
BEGIN
    SELECT ISNULL(SUM(Monto_Total), 0) AS Total_Vendido_Hoy
    FROM Ventas
    WHERE CAST(Fecha AS DATE) = CAST(GETDATE() AS DATE)
      AND Estado = 'Activa'; 
END;
GO

--  Insertar Detalle de Venta y ACTUALIZAR STOCK, Resta del inventario
CREATE PROCEDURE sp_RegistrarDetalleVenta
    @ID_Venta INT,
    @ID_Producto INT,
    @Cantidad INT,
    @Precio_U_Historico DECIMAL(10,2),
    @Subtotal DECIMAL(10,2)
AS
BEGIN
    BEGIN TRANSACTION;
    BEGIN TRY
    
        INSERT INTO Detalle_Ventas (ID_Venta, ID_Producto, Cantidad, Precio_U_Historico, Subtotal)
        VALUES (@ID_Venta, @ID_Producto, @Cantidad, @Precio_U_Historico, @Subtotal);
        
        UPDATE Productos 
        SET Stock = Stock - @Cantidad
        WHERE ID_Producto = @ID_Producto;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH;
END;
GO

CREATE PROCEDURE sp_AnularVenta
    @ID_Venta INT
AS
BEGIN
    BEGIN TRANSACTION;
    BEGIN TRY
        --  Cambiamos el estado de la venta a 'Anulada'
        UPDATE Ventas 
        SET Estado = 'Anulada' 
        WHERE ID_Venta = @ID_Venta;

        --  Devolvemos los productos al stock 
        DECLARE @ID_Producto INT, @Cantidad INT;

        DECLARE cursor_productos CURSOR FOR 
        SELECT ID_Producto, Cantidad FROM Detalle_Ventas WHERE ID_Venta = @ID_Venta;

        OPEN cursor_productos;
        FETCH NEXT FROM cursor_productos INTO @ID_Producto, @Cantidad;

        WHILE @@FETCH_STATUS = 0
        BEGIN
            UPDATE Productos 
            SET Stock = Stock + @Cantidad
            WHERE ID_Producto = @ID_Producto;

            FETCH NEXT FROM cursor_productos INTO @ID_Producto, @Cantidad;
        END;

        CLOSE cursor_productos;
        DEALLOCATE cursor_productos;
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

--  Insertar Cabecera de Compra
CREATE PROCEDURE sp_RegistrarCompra
    @ID_Proveedor INT,
    @ID_Usuario INT,
    @Total_Pagado DECIMAL(10,2),
    @ID_Compra_Generado INT OUTPUT
AS
BEGIN
    INSERT INTO Compras (ID_Proveedor, ID_Usuario, Fecha, Total_Pagado)
    VALUES (@ID_Proveedor, @ID_Usuario, GETDATE(), @Total_Pagado);
    
    SET @ID_Compra_Generado = SCOPE_IDENTITY();
END;
GO

--Insertar Detalle de Compra y ACTUALIZAR STOCK, Suma al inventario
CREATE PROCEDURE sp_RegistrarDetalleCompra
    @ID_Compra INT,
    @ID_Producto INT,
    @Cantidad_Recibida INT,
    @Costo_Unitario DECIMAL(10,2)
AS
BEGIN
    BEGIN TRANSACTION;
    BEGIN TRY
        --Insertamos el renglón del detalle de la compra
        INSERT INTO Detalle_Compras (ID_Compra, ID_Producto, Cantidad_Recibida, Costo_Unitario)
        VALUES (@ID_Compra, @ID_Producto, @Cantidad_Recibida, @Costo_Unitario);
        
        -- Sumamos el stock que acaba de llegar a la tabla Productos
        UPDATE Productos 
        SET Stock = Stock + @Cantidad_Recibida
        WHERE ID_Producto = @ID_Producto;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH;
END;
GO

CREATE PROCEDURE sp_ListarComprasDelDia
AS
BEGIN
    SELECT 
        C.ID_Compra,
        P.Nombre_Empresa AS Nombre_Proveedor,
        U.Nombre AS Nombre_Usuario,
        C.Fecha,
        C.Total_Pagado
    FROM Compra C
    INNER JOIN Proveedores P ON C.ID_Proveedor = P.ID_Proveedor
    INNER JOIN Usuarios U ON C.ID_Usuario = U.ID_Usuario
    -- Filtramos para que solo muestre lo comprado hoy
    WHERE CAST(C.Fecha AS DATE) = CAST(GETDATE() AS DATE);
END;
GO


CREATE PROCEDURE sp_ObtenerTotalCompradoDelDia
AS
BEGIN
    -- Suma todo el dinero que salió hoy para pagar a proveedores
    SELECT ISNULL(SUM(Total_Pagado), 0) AS Total_Comprado_Hoy
    FROM Compra
    WHERE CAST(Fecha AS DATE) = CAST(GETDATE() AS DATE);
END;
GO
