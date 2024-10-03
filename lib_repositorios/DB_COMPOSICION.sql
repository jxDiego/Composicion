DROP DATABASE IF EXISTS [DB_COMPOSICION];
CREATE DATABASE [DB_COMPOSICION];
USE [DB_COMPOSICION];

CREATE TABLE [Clientes] (
    [Id] INT IDENTITY(1,1),
    [Cedula] NVARCHAR(15) NOT NULL,
    [Nombre] NVARCHAR(50) NOT NULL,
    [Contacto] INT NOT NULL,
    [Direccion] VARCHAR(100) NOT NULL,
    CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED ([Id])
);
GO

INSERT INTO [Clientes] ([Cedula], [Nombre], [Contacto], [Direccion])VALUES ('1234567890', 'Juan Pérez', 987654321, 'Calle 1, Ciudad A');
INSERT INTO [Clientes] ([Cedula], [Nombre], [Contacto], [Direccion])VALUES ('0987654321', 'Ana Gómez', 123456789, 'Avenida 3, Ciudad B');


CREATE TABLE [Tipos_productos] (
    [Id] INT IDENTITY(1,1),
    [Cod_tipo] INT NOT NULL,
    [Nom_tipo] NVARCHAR(50) NOT NULL,
    CONSTRAINT [PK_Tipos_productos] PRIMARY KEY CLUSTERED ([Id])
);
GO
INSERT INTO [Tipos_productos] ([Cod_tipo], [Nom_tipo])VALUES (1, 'Vegetal');
INSERT INTO [Tipos_productos] ([Cod_tipo], [Nom_tipo])VALUES (2, 'Carne');

CREATE TABLE [Productos] (
    [Id] INT IDENTITY(1,1),
    [Tipo_producto] INT NOT NULL,
    [Cod_producto] INT NOT NULL,
    [Nombre_producto] NVARCHAR(50) NOT NULL,
    [Estado_producto] NVARCHAR(50) NOT NULL,
    CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED ([Id]),
    CONSTRAINT [FK_Productos_Tipos_productos] FOREIGN KEY ([Tipo_producto]) REFERENCES [Tipos_Productos] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
);
GO
INSERT INTO [Productos] ([Tipo_producto], [Cod_producto], [Nombre_producto], [Estado_producto])VALUES (1, 101, 'Tomate', 'Fresco');
INSERT INTO [Productos] ([Tipo_producto], [Cod_producto], [Nombre_producto], [Estado_producto])VALUES (2, 202, 'Pollo', 'Congelado');


CREATE TABLE [Compuestos] (
    [Id] INT IDENTITY(1,1),
    [Cod_compuesto] INT NOT NULL,
    [Nombre_composicion] NVARCHAR(50) NOT NULL,
    CONSTRAINT [PK_compuestos] PRIMARY KEY CLUSTERED ([Id])
);
GO
INSERT INTO [Compuestos] ([Cod_compuesto], [Nombre_composicion]) VALUES (1, 'Ensalada Mixta');
INSERT INTO [Compuestos] ([Cod_compuesto], [Nombre_composicion]) VALUES (2, 'Pollo Asado');


CREATE TABLE [Compuestos_Productos] (
    [Id] INT IDENTITY(1,1),
    [Compuesto] INT NOT NULL,
    [Producto] INT NOT NULL,
    [Cantidad_producto_necesario] INT NOT NULL,
    CONSTRAINT [PK_Compuestos_Productos] PRIMARY KEY CLUSTERED ([Id]),
    CONSTRAINT [FK_Compuestos_Productos_Compuestos] FOREIGN KEY ([Compuesto]) REFERENCES [Compuestos] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION,
    CONSTRAINT [FK_Compuestos_Productos_Productos] FOREIGN KEY ([Producto]) REFERENCES [Productos] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
);
GO
INSERT INTO [Compuestos_Productos] ([Compuesto], [Producto], [Cantidad_producto_necesario]) VALUES (1, 1, 3);  -- Ensalada Mixta requiere 3 unidades de Tomate
INSERT INTO [Compuestos_Productos] ([Compuesto], [Producto], [Cantidad_producto_necesario]) VALUES(2, 2, 1);  -- Pollo Asado requiere 1 unidad de Pollo

CREATE TABLE [Inventarios] (
    [Id] INT IDENTITY(1,1),
    [Producto] INT NOT NULL,
    [Cantidad_afectar] INT NOT NULL,
    [Accion_estado] NVARCHAR(50) NOT NULL,
    CONSTRAINT [PK_Inventarios] PRIMARY KEY CLUSTERED ([Id]),
    CONSTRAINT [FK_Inventarios_Productos] FOREIGN KEY ([Producto]) REFERENCES [Productos] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
);
GO
INSERT INTO [Inventarios] ([Producto], [Cantidad_afectar], [Accion_estado]) VALUES (1, 10, 'Ingreso');  -- 10 Tomates ingresados
INSERT INTO [Inventarios] ([Producto], [Cantidad_afectar], [Accion_estado]) VALUES (2, 5, 'Ingreso');   -- 5 Pollos ingresados


CREATE TABLE [Proveedores] (
    [Id] INT IDENTITY(1,1),
    [Nombre_Proveedor] NVARCHAR(50) NOT NULL,
    [Contacto] INT NOT NULL,
    CONSTRAINT [PK_Proveedores] PRIMARY KEY CLUSTERED ([Id])
);
GO
INSERT INTO [Proveedores] ([Nombre_Proveedor], [Contacto])VALUES ('Proveedor A', 112233445);
INSERT INTO [Proveedores] ([Nombre_Proveedor], [Contacto])VALUES ('Proveedor B', 556677889);


CREATE TABLE [Proveedores_Productos] (
    [Id] INT IDENTITY(1,1),
    [Producto] INT NOT NULL,
    [Proveedor] INT NOT NULL,
    [Cantidad_producto] INT NOT NULL,
    [Fecha_entrega] SMALLDATETIME NOT NULL,
    CONSTRAINT [PK_Proveedores_Productos] PRIMARY KEY CLUSTERED ([Id]),
    CONSTRAINT [FK_Proveedores_Productos_Productos] FOREIGN KEY ([Producto]) REFERENCES [Productos] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION,
    CONSTRAINT [FK_Proveedores_Productos_Proveedores] FOREIGN KEY ([Proveedor]) REFERENCES [Proveedores] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
);
GO
INSERT INTO [Proveedores_Productos] ([Producto], [Proveedor], [Cantidad_producto], [Fecha_entrega]) VALUES (1, 1, 50, '2024-10-01');  -- Proveedor A entrega 50 unidades de Tomate
INSERT INTO [Proveedores_Productos] ([Producto], [Proveedor], [Cantidad_producto], [Fecha_entrega]) VALUES (2, 2, 30, '2024-10-02');  -- Proveedor B entrega 30 unidades de Pollo

CREATE TABLE [Ordenes] (
    [Id] INT IDENTITY(1,1),
    [Cliente] INT NOT NULL,
    [Compuesto] INT NOT NULL,
    [Fecha_pedido] SMALLDATETIME NOT NULL,
    [Estado_orden] NVARCHAR(50) NOT NULL,
    [Total_pagar] DECIMAL(10, 2) NOT NULL,
    CONSTRAINT [PK_Ordenes] PRIMARY KEY CLUSTERED ([Id]),
    CONSTRAINT [FK_Ordenes_Clientes] FOREIGN KEY ([Cliente]) REFERENCES [Clientes] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION,
    CONSTRAINT [FK_Ordenes_Compuestos] FOREIGN KEY ([Compuesto]) REFERENCES [Compuestos] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
);
GO
INSERT INTO [Ordenes] ([Cliente], [Compuesto], [Fecha_pedido], [Estado_orden], [Total_pagar])VALUES (1, 1, '2024-10-01', 'En espera', 25.00);  -- Juan Pérez ordena Ensalada Mixta
INSERT INTO [Ordenes] ([Cliente], [Compuesto], [Fecha_pedido], [Estado_orden], [Total_pagar])VALUES (2, 2, '2024-10-02', 'Cumplido', 45.50);   -- Ana Gómez ordena Pollo Asado

--Consulta de ordenes con el cliente y el compuesto solicitado
SELECT O.Fecha_pedido, C.Nombre, C2.Nombre_composicion, O.Total_pagar, O.Estado_orden
FROM [Ordenes] O
INNER JOIN [Clientes] C ON O.Cliente = C.Id
INNER JOIN [Compuestos] C2 ON O.Compuesto = C2.Id;

--Consulta de proveedores con sus productos entregados
SELECT PR.Nombre_Proveedor, P.Nombre_producto, PP.Cantidad_producto, PP.Fecha_entrega
FROM [Proveedores_Productos] PP
INNER JOIN [Proveedores] PR ON PP.Proveedor = PR.Id
INNER JOIN [Productos] P ON PP.Producto = P.Id;
