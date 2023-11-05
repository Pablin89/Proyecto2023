--Valores iniciales (Estados - Sexos - Perfiles)

Insert into Estados_clientes(id_estado_cliente, descripcion) Values (0, 'Inactivo')
Insert into Estados_clientes(id_estado_cliente, descripcion) Values (1, 'Activo')


Insert into Estados_empleados(id_estado_empleado, descripcion) Values (0, 'Inactivo')
Insert into Estados_empleados(id_estado_empleado, descripcion) Values (1, 'Activo')


Insert into Estados_productos(id_estado_producto, descripcion) Values (0, 'Inactivo')
Insert into Estados_productos(id_estado_producto, descripcion) Values (1, 'Activo')

Insert into Estados_ventas(id_estado_venta, descripcion) Values (0, 'Inactivo')
Insert into Estados_ventas(id_estado_venta, descripcion) Values (1, 'Activo')


Insert into Perfiles Values(1, 'Gerente General')
Insert into Perfiles Values(2, 'Gerente')
Insert into Perfiles Values(3, 'Encargado')
Insert into Perfiles Values(1, 'Cajero')


Insert into Sexos Values(1, 'Masculino')
Insert into Sexos Values(2, 'Femenino')
Insert into Sexos Values(3, 'Otro')


--Empleados principales para el uso inicial del sistema
Select * from empleados
Insert into empleados values (1,00,'Ecargado', 'Inicial',' ', 00,'usuario1@gmail.com', '2020-01-01', 3, 1)
Insert into empleados values (2,01,'Gerente General', 'Inicial',' ', 01,'usuario2@gmail.com', '2020-01-01', 3, 1)
Insert into empleados values (3,02,'Gerente', 'Inicial',' ', 02,'usuario3@gmail.com', '2020-01-01', 3, 1)
Insert into empleados values (4,03,'Cajero', 'Inicial',' ', 03,'usuario4@gmail.com', '2020-01-01', 3, 1)
insert into Empleados values(5,4,'Cajero','inicial','',4,'usuario5@gmail.com','2020-01-01',3,1)


--insertar registros en tipo de pago
insert into tipos_pagos values(1,'Efectivo')
insert into tipos_pagos values(2,'Débito')
insert into tipos_pagos values(3,'Crédito')
insert into tipos_pagos values(4,'Mercado Pago')


-- Se modificó los valores para la contraseña por varchar(50)
--Creación de un cajero Usuario: Cajero contraseña: cajero
insert into Usuarios Values('Cajero','YwBhAGoAZQByAG8A',4,4)
--Creación de un cajero Usuario: Cajero2 contraseña: cajero
insert into Usuarios Values('Cajero2','YwBhAGoAZQByAG8A',5,4)
--Creación de un Encargado Usuario: Encargado contraseña: encargado 
insert into Usuarios Values('Encargado','ZQBuAGMAYQByAGcAYQBkAG8A',1,3)
--Creación de un Encargado Usuario: Encargado2 contraseña: encargado 
insert into Usuarios Values('Encargado2','ZQBuAGMAYQByAGcAYQBkAG8A',1,3)
--Creación de un Gerente Usuario: Gerente contraseña: gerente 
insert into Usuarios Values('Gerente','ZwBlAHIAZQBuAHQAZQA=',3,2)
--Creación de un Gerente Gral Usuario: GerenteGral contraseña: gerentegral 
insert into Usuarios Values('GerenteGral','ZwBlAHIAZQBuAHQAZQBnAHIAYQBsAA==',2,1)





