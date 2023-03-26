

insert into Rol(nombre) values
('Administrador'),
('Empleado'),
('Supervisor')

select * from Rol

insert into Usuario(nombreCompleto,correo,idRol,clave) values
('Lucas Salomon','lucassalomon@gmail.com',1,'admin')

select * from Usuario

INSERT INTO Categoria(nombre,esActivo) values
('Laptops',1),
('Monitores',1),
('Teclados',1),
('Auriculares',1),
('Memorias',1),
('Accesorios',1)

select * from Categoria

insert into Producto(nombre,idCategoria,stock,precio,esActivo) values
('Laptop samsung book pro',1,20,250000,1),
('Laptop lenovo idea pad',1,15,200000,1),
('Laptop asus zenbook duo',1,17,300000,1),
('Monitor teros gaming te-2',2,35,55000,1),
('Monitor samsung curvo',2,25,80000,1),
('Monitor huawei gamer',2,15,65000,1),
('Teclado seisen gamer',3,40,8000,1),
('Teclado antryx gamer',3,37,12000,1),
('Teclado logitech 3001',3,15,12000,1),
('Auricular logitech gamer',4,10,15000,1),
('Auricular hyperx gamer',4,12,20000,1),
('Auricular redragon lumia',4,7,13000,1),
('Memoria kingston rgb 16gb',5,30,15000,1),
('Ventilador cooler master',6,15,10000,1),
('Mini ventilador lenovo',6,12,8000,1)

select * from Producto

insert into Menu(nombre,icono,url) values
('DashBoard','dashboard','/pages/dashboard'),
('Usuarios','group','/pages/usuarios'),
('Productos','collections_bookmark','/pages/productos'),
('Venta','currency_exchange','/pages/venta'),
('Historial Ventas','edit_note','/pages/historial_venta'),
('Reportes','receipt','/pages/reportes')

select * from Menu

insert into MenuRol(idMenu,idRol) values
(1,1),
(2,1),
(3,1),
(4,1),
(5,1),
(6,1)

-- Menu para empleados
insert into MenuRol(idMenu,idRol) values
(4,2),
(5,2)

-- Menu para Supervisores
insert into MenuRol(idMenu,idRol) values
(3,3),
(4,3),
(5,3),
(6,3)

select * from MenuRol

insert into NumeroDocumento(ultimo_Numero,fechaRegistro) values
(0,getdate())

select * from NumeroDocumento
