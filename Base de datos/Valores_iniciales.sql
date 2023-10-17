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





