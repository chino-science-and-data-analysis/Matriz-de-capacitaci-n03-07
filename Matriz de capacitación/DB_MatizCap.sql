--------------------------------------------MASTER-----------------------------------------------------------------------------
--USE master
GO
--------------------------------------------SE BORRA LA BASE EXISTENTE---------------------------------------------------------
--DROP DATABASE MatrizCapFgi
GO
--------------------------------------------SE CREA BASE DE DATOS MDC----------------------------------------------------------
--CREATE DATABASE MatrizCapFgi
GO
--------------------------------------------MatrizCapFgi-----------------------------------------------------------------------
--USE MatrizCapFgi
GO
-------------------------------------------/*[CATALOGOS]*\---------------------------------------------------------------------
-------------------------------------------/*[CATALOGOS]*\---------------------------------------------------------------------
-------------------------------------------/*[CATALOGOS]*\---------------------------------------------------------------------
GO
--------------------------------------------Catalogo Movimientos---------------------------------------------------------------
--SELECT * FROM cat_movimientos
--DROP TABLE cat_movimientos
CREATE TABLE cat_movimientos
(
Id_Movimiento int identity (1,1) primary key,
Nombre varchar (70),
Comentarios nvarchar (300),
Observaciones nvarchar (300)
)
INSERT INTO cat_movimientos (Nombre)
Values
('Creado'),
('Editado'),
('Eliminado'),
('Status Sucursal'),
('Status Colaborador'),
('Ingreso a GI'),
('Ingreso a Plubek'),
('Baja de GI'),
('Baja Plubek'),
('Cambio de puesto'),
('Otro');
SELECT * FROM cat_movimientos
GO
--------------------------------------------Catalogo Status Delete-------------------------------------------------------------
--SELECT * FROM cat_statusdelete
--DROP TABLE cat_statusdelete
CREATE TABLE cat_statusdelete
(
Id_Delete bit primary key,
Detalle nvarchar (50),
Comentarios nvarchar (300),
Observaciones nvarchar (300),
Id_Movimiento int default '3'
CONSTRAINT FK_Id_Movimiento_delete FOREIGN KEY (Id_Movimiento)
REFERENCES cat_movimientos (Id_Movimiento)
);
INSERT INTO cat_statusdelete (Id_Delete,Detalle)
Values
(0,'Activo'),
(1,'Eliminado')
SELECT * FROM cat_statusdelete
GO
--------------------------------------------Catalogo de genero-----------------------------------------------------------------
--SELECT * FROM cat_generos
--DROP TABLE cat_generos
CREATE TABLE cat_generos
(
Id_Genero int identity (1,1) primary key,
Nombre varchar (50),
Comentarios varchar (300),
Observaciones varchar (300),
)
INSERT INTO cat_generos (Nombre)
VALUES
(''),
('MASCULINO'),
('FEMENINO');
SELECT * FROM cat_generos
GO
--------------------------------------------Catalogo de status-----------------------------------------------------------------
--SELECT * FROM cat_statuscolaborador
--DROP TABLE cat_statuscolaborador
CREATE TABLE cat_statuscolaborador
(
Id_Statuscolaborador int identity (1,1) primary key not null,
Nombre varchar (50),
Comentarios varchar (300),
Observaciones varchar (300),
Eliminado int,
Id_Movimiento int default '5',
CONSTRAINT FK_Id_Movimiento_Statuscolaborador FOREIGN KEY (Id_Movimiento)
REFERENCES cat_movimientos (Id_Movimiento)
);
INSERT INTO cat_statuscolaborador (Nombre)
VALUES
(''),
('ALTA'),
('BAJA'),
('REINGRESO');
SELECT * FROM cat_statuscolaborador
GO
--------------------------------------------Catalogo Causa Baja----------------------------------------------------------------
--SELECT * FROM cat_causabaja
--DROP TABLE cat_causabaja
CREATE TABLE cat_causabaja
(
Id_Causabaja int identity (1,1) primary key,
Nombre Varchar (50),
Comentarios varchar (300),
Observaciones varchar (300),
Eliminado int
)
INSERT INTO cat_causabaja (Nombre)
VALUES
(''),
('ABADONO DE TRABAJO'),
('BAJO DESEMPEÑO LABORAL'),
('PROBLEMAS CON LOS COMPAÑEROS'),
('RENUNCIA VOLUNTARIA'),
('DEFUNCIÓN'),
('OTRO');
SELECT * FROM cat_causabaja
GO
--------------------------------------------Catalogo Causa Baja Plubek---------------------------------------------------------
--SELECT * FROM cat_causabajaplubek
--DROP TABLE cat_causabajaplubek
CREATE TABLE cat_causabajaplubek
(
Id_Causabajaplubek int identity (1,1) primary key,
Nombre Varchar (50),
Comentarios varchar (300),
Observaciones varchar (300),
Eliminado int
)
INSERT INTO cat_causabajaplubek (Nombre)
VALUES
(''),
('ABADONO DE TRABAJO'),
('BAJO DESEMPEÑO LABORAL'),
('PROBLEMAS CON LOS COMPAÑEROS'),
('RENUNCIA VOLUNTARIA'),
('DEFUNCIÓN'),
('PROMOCIÓN'),
('OTRO');
SELECT * FROM cat_causabajaplubek
GO
--------------------------------------------Catalogo tipo de colaborador-------------------------------------------------------
--SELECT * FROM cat_tipocolaborador
--DROP TABLE cat_tipocolaborador
CREATE TABLE cat_tipocolaborador
(
Id_Tipocolaborador int identity (1,1) primary key,
Nombre Varchar (20),
Comentarios varchar (300),
Observaciones varchar (300),
Eliminado int
)
INSERT INTO cat_tipocolaborador(Nombre)
VALUES
(''),
('CORPORATIVO'),
('PLUBEK'),
('DISPENSADOR'),
('DISPENSADOR PLUBEK');
SELECT * FROM cat_tipocolaborador
GO
--------------------------------------------Catalogo tipo de usuarios----------------------------------------------------------
--SELECT * FROM cat_tipousuario
--DROP TABLE cat_tipousuario
CREATE TABLE cat_perfilusuario
(
Id_TipoUsuario int identity (1,1) primary key,
Nombre Varchar (20),
Comentarios varchar (300),
Observaciones varchar (300),
Eliminado int
)
INSERT INTO cat_perfilusuario (Nombre)
VALUES
(''),
('Administrador'),
('Jefe de área'),
('Colaborador'),
('Master');
SELECT * FROM cat_perfilusuario
GO
--------------------------------------------Catalogo de horarios---------------------------------------------------------------
--SELECT * FROM cat_horarios
--DROP TABLE cat_horarios
CREATE TABLE cat_horarios
(
Id_Horario int identity (1,1) primary key not null,
Nombre varchar (50),
Comentarios varchar (300),
Observaciones varchar (300),
Eliminado int
)
INSERT INTO cat_horarios (Nombre)
VALUES
(''),
('MATUTINO'),
('VESPERTINO'),
('MIXTO');
SELECT * FROM cat_horarios
GO
--------------------------------------------Catalogo de bancos-----------------------------------------------------------------
--SELECT * FROM cat_bancos
--DROP TABLE cat_bancos
CREATE TABLE cat_bancos
(
Id_Banco int identity (1,1) primary key,
Nombre varchar (50),
Comentarios varchar (300),
Observaciones varchar (300),
Eliminado int
)
INSERT INTO cat_bancos (Nombre)
VALUES
(''),
('AFIRME'),
('BANCO NACIONAL DE MEXICO'),
('BANORTE'),
('BBVA BANCOMER'),
('COMPARTAMOS'),
('HSBC MEXICO'),
('INBURSA'),
('MIFEL'),
('MULTIVA'),
('SANTANDER'),
('SCOTIABANK INVERLAT');
SELECT * FROM cat_bancos
GO
--------------------------------------------Catalogo de tipo de eventos--------------------------------------------------------
--SELECT * FROM cat_tipoevento
--DROP TABLE cat_tipoevento
CREATE TABLE cat_tipoevento
(
Id_Tipoevento int identity (1,1) primary key,
Nombre varchar (50),
Fecha_Registro datetime,
Id_Delete bit default '0',
Fecha_Eliminado datetime,
Id_Movimiento int,
Fecha_Movimiento datetime,
Movimiento_User varchar,
Comentarios varchar (300),
Observaciones varchar (300)
CONSTRAINT FK_Id_Deletetipoevento FOREIGN KEY (Id_Delete)
REFERENCES cat_statusdelete (Id_Delete),
CONSTRAINT FK_Id_Movimientotipoevento FOREIGN KEY (Id_Movimiento)
REFERENCES cat_movimientos (Id_Movimiento)
)
INSERT INTO cat_tipoevento (Nombre)
Values
(''),
('CONGRESO'),
('CURSO'),
('FORO'),
('PLÁTICA'),
('SIMPOSIO'),
('TALLER'),
('SEMINARIO'),
('DIPLOMADO');
SELECT * FROM cat_tipoevento
GO
--------------------------------------------Catalogo de nivel educativo--------------------------------------------------------
--SELECT * FROM cat_niveleducativo
--DROP TABLE cat_nivelecucativo
CREATE TABLE cat_niveleducativo
(
Id_Niveleducativo int identity (1,1) primary Key,
Nombre varchar (50),
Comentarios varchar (300),
Observaciones varchar (300),
Eliminado int
)
INSERT INTO cat_niveleducativo (Nombre)
VALUES
(''),
('TÉCNICO SUPERIOR UNIVERSITARIO'),
('LICENCIATURA'),
('DIPLOMADO'),
('ESPECIALIDAD'),
('MAESTRÍA');
SELECT * FROM cat_niveleducativo
GO
--------------------------------------------Catalogo Alcaldìas-----------------------------------------------------------------
--SELECT * FROM cat_alcaldias
--DROP TABLE cat_alcaldias
CREATE TABLE cat_alcaldias
(
Id_Alcaldia int identity (1,1) primary key,
Nombre varchar (50),
Fecha_Registro datetime,
Id_Delete bit default '0',
Fecha_Eliminado datetime,
Id_Movimiento int,
Fecha_Movimiento datetime,
Movimiento_User varchar,
Comentarios varchar (300),
Observaciones varchar (300)
CONSTRAINT FK_Id_Deletealcaldias FOREIGN KEY (Id_Delete)
REFERENCES cat_statusdelete (Id_Delete),
CONSTRAINT FK_Id_Movimientoalcaldias FOREIGN KEY (Id_Movimiento)
REFERENCES cat_movimientos (Id_Movimiento)
)
INSERT INTO cat_alcaldias (Nombre)
VALUES
(''),
('ATIZAPÁN'),
('CIUDAD NEZAHUALCÓYOTL'),
('COACALCO'),
('CUAUHTÉMOC'),
('ECATEPEC'),
('GUSTAVO A. MADERO'),
('MIGUEL HIDALGO'),
('NAUCALPAN'),
('TLALNEPANTLA'),
('TOLUCA'),
('TULTITLÁN'),
('VENUSTIANO CARRANZA')
SELECT * FROM cat_alcaldias
GO
--------------------------------------------Creación Catalogo de Zonas---------------------------------------------------------
--SELECT * FROM cat_zonas
--DROP TABLE cat_zonas
CREATE TABLE cat_zonas
(
Id_Zona int identity (1,1) primary key,
Nombre varchar (50),
Supervisor varchar (180),
Fecha_Registro datetime,
Id_Delete bit default '0',
Fecha_Eliminado datetime,
Id_Movimiento int,
Fecha_Movimiento datetime,
Movimiento_User varchar,
Comentarios varchar (300),
Observaciones varchar (300),
CONSTRAINT FK_Id_Deletezonas FOREIGN KEY (Id_Delete)
REFERENCES cat_statusdelete (Id_Delete),
CONSTRAINT FK_Id_Movimientzonas FOREIGN KEY (Id_Movimiento)
REFERENCES cat_movimientos (Id_Movimiento)
)
INSERT INTO cat_zonas (Nombre)
VALUES
(''),
('ZONA 1'),
('ZONA 2'),
('ZONA 3'),
('ZONA 4'),
('ZONA 5'),
('ZONA 6'),
('ZONA 7'),
('ZONA 8');
SELECT * FROM cat_zonas
GO
--------------------------------------------Creación Catalogo de Status de Sucursal--------------------------------------------
--SELECT * FROM cat_statussucursal
--DROP TABLE cat_statussucursal
CREATE TABLE cat_statussucursal
(
Id_Statussuc int identity (1,1) primary key,
Nombre varchar (50),
Id_Movimiento int default '4',
Comentarios varchar (300),
Observaciones varchar (300),
Eliminado int
)
INSERT INTO cat_statussucursal (Nombre)
VALUES
(''),
('ACTIVA'),
('CERRADA');
SELECT * FROM cat_statussucursal
GO
--------------------------------------------Creación Catalogo de Estado de Sucursal--------------------------------------------
--SELECT * FROM cat_regionsucursal
--DROP TABLE cat_regionsucursal
CREATE TABLE cat_regionsucursal
(
Id_Region int identity (1,1) primary key,
Nombre varchar (50),
Fecha_Registro datetime,
Id_Delete bit default '0',
Fecha_Eliminado datetime,
Id_Movimiento int,
Fecha_Movimiento datetime,
Movimiento_User varchar,
Comentarios varchar (300),
Observaciones varchar (300)
CONSTRAINT FK_Id_Deleteregionsucursal FOREIGN KEY (Id_Delete)
REFERENCES cat_statusdelete (Id_Delete),
CONSTRAINT FK_Id_Movimientregionsucursal FOREIGN KEY (Id_Movimiento)
REFERENCES cat_movimientos (Id_Movimiento)
)
INSERT INTO cat_regionsucursal (Nombre)
VALUES
(''),
('CDMX'),
('MÉXICO'),
('CHIAPAS');
SELECT * FROM cat_regionsucursal
GO
--------------------------------------------TABLAS-----------------------------------------------------------------------------
--------------------------------------------TABLAS-----------------------------------------------------------------------------
--------------------------------------------TABLAS-----------------------------------------------------------------------------
GO
--------------------------------------------Creación de tabla de departamentos-------------------------------------------------
--SELECT * FROM tbl_departamentos
--DROP TABLE tbl_departamentos
CREATE TABLE tbl_departamentos
(
Id_Departamento bigint primary key,
Nombre varchar (70),
Id_Delete bit default'0',
Fecha_Creacion datetime,
Fecha_Eliminado datetime,
Id_Movimiento int,
Fecha_Movimiento datetime,
Id_Usermove int,
Comentarios varchar (300),
Observaciones varchar(300),
Columna1 varchar (300),
CONSTRAINT FK_Id_Deletedepartamento FOREIGN KEY (Id_Delete)
REFERENCES cat_statusdelete (Id_Delete),
CONSTRAINT FK_Id_Movimientodepartamentos FOREIGN KEY (Id_Movimiento)
REFERENCES cat_movimientos (Id_Movimiento)
)
INSERT INTO tbl_departamentos (Id_Departamento,Nombre)
VALUES
(1,null),
(4070,'ALMACÉN'),
(5010,'DIVISIÓN FARMACIAS'),
(4030,'ASUNTOS REGULATORIOS'),
(2010,'CALIDAD'),
(4060,'CONTABILIDAD'),
(4050,'CRÉDITO Y COBRANZA'),
(4120,'COMEDOR'),
(4010,'COMPRAS'),
(1010,'DIRECCIÓN GENERAL'),
(4080,'FRANQUICIAS'),
(3010,'GERENCIA COMERCIAL'),
(4130,'GESTORÍA'),
(4110,'MANTENIMIENTO'),
(4090,'MERCADOTECNIA'),
(4040,'RECURSOS HUMANOS '),
(4100,'T. I.'),
(4020,'VENTAS'),
(3020,'GERENCIA ADMINISTRATIVA');
SELECT *FROM tbl_departamentos
GO
--------------------------------------------Creación de tabla áreas------------------------------------------------------------
--SELECT * FROM tbl_areas
--DROP TABLE tbl_areas
CREATE TABLE tbl_areas
(
Id_Area bigint primary key,
Id_Departamento bigint,
Nombre varchar (50),
Id_Delete bit default'0',
Fecha_Creacion datetime,
Fecha_Eliminado datetime,
Id_Movimiento int,
Fecha_Movimiento datetime,
Id_Usermove int,
Comentarios varchar (300),
Observaciones varchar(300),
Columna1 varchar (300),
CONSTRAINT FK_ID_Departamentoareas FOREIGN KEY (Id_Departamento)
REFERENCES tbl_departamentos (Id_Departamento),
CONSTRAINT FK_Id_Deleteareas FOREIGN KEY (Id_Delete)
REFERENCES cat_statusdelete (Id_Delete),
CONSTRAINT FK_Id_Movimientoareas FOREIGN KEY (Id_Movimiento)
REFERENCES cat_movimientos (Id_Movimiento)
)
--------------------------------------------Insertar Áreas--------------------------------------------
INSERT INTO tbl_areas(Id_Area,Id_Departamento,Nombre)
VALUES
(1,1,null),
(6010,4040,'LIMPIEZA'),
(6020,4070,'RECIBO'),
(6030,4070,'COLOCACIÓN DE PRECIO'),
(6040,4070,'SURTIDO'),
(6050,4070,'EMPAQUE'),
(6060,4070,'EMBARQUE'),
(6070,4070,'SUB ALMACÉN'),
(6080,4090,'PROMOCIÓN Y PUBLICIDAD');
GO
--------------------------------------------Creación de tabla de puestos-------------------------------------------------------
--SELECT * FROM tbl_puestos
--DROP TABLE tbl_puestos
CREATE TABLE tbl_puestos
(
Id_Puesto bigint primary key,
Id_Departamento bigint not null,
Id_Area bigint null,
Nombre varchar (100),
Id_Delete bit default'0',
Fecha_Creacion datetime,
Fecha_Eliminado datetime,
Id_Movimiento int,
Fecha_Movimiento datetime,
Id_Usermove int,
Comentarios varchar (300),
Observaciones varchar(300),
Columna1 varchar (300),
CONSTRAINT FK_Id_Departamentopuestos FOREIGN KEY (Id_Departamento)
REFERENCES tbl_departamentos (Id_Departamento),
CONSTRAINT FK_Id_Areapuestos FOREIGN KEY (Id_Area)
REFERENCES tbl_areas (Id_Area),
CONSTRAINT FK_Id_Deletepuestos FOREIGN KEY (Id_Delete)
REFERENCES cat_statusdelete (Id_Delete),
CONSTRAINT FK_Id_Movimientopuestos FOREIGN KEY (Id_Movimiento)
REFERENCES cat_movimientos (Id_Movimiento)
)
--------------------------------------------Insertar Puestos--------------------------------------------
INSERT INTO tbl_puestos (Id_Departamento,Id_Area,Id_Puesto,Nombre)
VALUES
(1,1,1,NULL),
(1010,NULL,1001,'DIRECTOR GENERAL'),
(1010,NULL,1002,'ASISTENTE DE DIRECCION'),
(1010,NULL,1003,'RECEPCIONISTA'),
(1010,NULL,1004,'MENSAJERO'),
(2010,NULL,2011,'RESPONSABLE SANITARIO'),
(2010,NULL,2012,'ASESOR SANITARIO'),
(2010,NULL,2013,'ANALISTA DE CALIDAD'),
(2010,NULL,2014,'QUIMICO DE CALIDAD'),
(2010,NULL,2015,'QUIMICO DE DOCUMENTACION'),
(3010,NULL,3011,'GERENTE COMERCIAL'),
(3010,NULL,3012,'COORDINADOR COMERCIAL'),
(3010,NULL,3013,'ANALISTA DE PRECIOS'),
(3010,NULL,3014,'EJECUTIVO COMERCIAL JR'),
(3020,NULL,3021,'GERENTE ADMINISTRATIVA'),
(3020,NULL,3022,'ARCHIVISTA'),
(4010,NULL,4011,'JEFE DE COMPRAS'),
(4010,NULL,4012,'COMPRADOR JUNIOR'),
(4010,NULL,4013,'COMPRADOR SENIOR'),
(4010,NULL,4014,'EJECUTIVO DE COMPRAS'),
(4020,NULL,4021,'JEFE DE VENTAS'),
(4020,NULL,4022,'AUXILIAR ADMINISTRATIVO'),
(4020,NULL,4023,'EJECUTIVO DE VENTAS'),
(4020,NULL,4024,'EJECUTIVO DE CALL CENTER'),
(4020,NULL,4025,'AUXILIAR DE FACTURACION'),
(4030,NULL,4031,'JEFE DE ASUNTOS REGULATORIOS'),
(4030,NULL,4032,'ASISTENTE DE ASUNTOS REGULATORIOS'),
(4030,NULL,4033,'CAPACITADOR'),
(4040,NULL,4041,'JEFE DE RECURSOS HUMANOS'),
(4040,NULL,4042,'ANALISTA DE PROCESOS'),
(4040,NULL,4043,'ASISTENTE DE RECURSOS HUMANOS'),
(4040,NULL,4044,'RESPONSABLE DE NOMINA E IMSS'),
(4040,NULL,4045,'RESPONSABLE DE  CAPACITACION Y ADIESTRAMIENTO'),
(4040,NULL,4046,'RESPONSABLE DE RECLUTAMIENTO, SELECCIÓN Y CONTRATACION'),
(4040,NULL,4047,'RESPONSABLE DE SEGURIDAD E HIGIENE'),
(4040,NULL,4048,'CAPACITADOR'),
(4050,NULL,4051,'JEFE DE CREDITO Y COBRANZA'),
(4050,NULL,4052,'ASISTENTE DE CREDITO Y COBRANZA'),
(4050,NULL,4053,'AUXILIAR DE CREDITO Y COBRANZA'),
(4060,NULL,4061,'JEFE DE CONTABILIDAD'),
(4060,NULL,4062,'CONTADOR'),
(4060,NULL,4063,'AUXILIAR ADMINISTRATIVO'),
(4060,NULL,4064,'ANALISTA DE INVENTARIOS'),
(4060,NULL,4065,'AUXILIAR CONTABLE A'),
(4060,NULL,4066,'AUXILIAR CONTABLE B'),
(4070,NULL,4071,'JEFE DE ALMACEN'),
(4070,NULL,4072,'COORDINADOR DE OPERACIÓN SAP'),
(4070,NULL,4073,'ANALISTA DE INVENTARIOS'),
(4070,NULL,4074,'ASISTENTE ADMINISTRATIVA'),
(4080,NULL,4081,'JEFE DE FRANQUICIAS'),
(4080,NULL,4082,'ASISTENTE DE FRANQUICIAS'),
(4080,NULL,4083,'ASESOR TECNICO'),
(4080,NULL,4084,'SUPERVISOR DE FRANQUICIAS'),
(4090,NULL,4091,'JEFE DE MERCADOTECNIA'),
(4090,NULL,4092,'RESPONSABLE DE PUBLICIDAD'),
(4090,NULL,4093,'COORDINADOR DE EVENTOS'),
(4090,NULL,4094,'COMMUNITY MANAGER'),
(4090,NULL,4095,'DISEÑADOR GRAFICO'),
(4090,NULL,4096,'AUDITOR DE MARCA'),
(4100,NULL,4101,'JEFE DE TI'),
(4100,NULL,4102,'COORDINADOR DE TI'),
(4100,NULL,4103,'DESARROLLADOR DE SISTEMAS'),
(4100,NULL,4104,'ENCARGADO DE SOPORTE TÉCNICO'),
(4110,NULL,4111,'JEFE DE MANTENIMIENTO'),
(4110,NULL,4112,'AUXILIAR DE MANTENIMIENTO A'),
(4120,NULL,4121,'ADMINISTRADOR DE COMEDOR EXTERNO'),
(4120,NULL,4122,'ENCARGADA DE COCINA'),
(4120,NULL,4123,'AUXILIAR DE COCINA'),
(4120,NULL,4124,'AYUDANTE GENERAL DE COCINA'),
(4130,NULL,4131,'GESTOR  CORPORATIVO'),
(4130,NULL,4132,'ASISTENTE DE GESTORIA'),
(4130,NULL,4133,'TECNICO DE MANTENIMIENTO EN FARMACIAS'),
(4130,NULL,4134,'AUXILIAR DE MANTENIMIENTO FARMACIAS'),
(5010,NULL,5011,'JEFE DIVISION FARMACIAS'),
(5010,NULL,5012,'PLANEADOR DE DEMANDA'),
(5010,NULL,5013,'ANALISTA DE FARMACIA'),
(5010,NULL,5014,'SUPERVISOR DE FARMACIA'),
(5010,NULL,5015,'ENCARGADO REGIONAL'),
(5010,NULL,5016,'DISPENSADOR DE FARMACIA'),
(4040,6010,6011,'COORDINADOR DE LIMPIEZA'),
(4040,6010,6012,'AUXILIAR DE LIMPIEZA'),
(4040,6010,6013,'INTENDENCIA'),
(4070,6020,6021,'SUPERVISOR DE RECIBO'),
(4070,6020,6022,'AUXILIAR DE OPERACIÓN'),
(4070,6030,6031,'SUPERVISOR DE COLOCACION DE PRECIO'),
(4070,6030,6032,'AUXILIAR DE ALMACEN'),
(4070,6030,6033,'AYUDANTE GENERAL A'),
(4070,6040,6041,'SUPERVISOR DE SURTIDO'),
(4070,6040,6042,'AUXILIAR DE OPERACIÓN'),
(4070,6040,6043,'MONTACARGUISTA'),
(4070,6040,6044,'AUXILIAR DE ALMACEN'),
(4070,6040,6045,'AYUDANTE GENERAL B'),
(4070,6050,6051,'SUPERVISOR DE EMPAQUE'),
(4070,6050,6052,'AUXILIAR DE OPERACIÓN'),
(4070,6050,6053,'ALMACENISTA'),
(4070,6060,6061,'SUPERVISOR DE EMBARQUE'),
(4070,6060,6062,'CHOFER DE REPARTO'),
(4070,6060,6063,'AUXILIAR DE REPARTO'),
(4070,6070,6070,'SUB ALMACEN'),
(4070,6070,6071,'SUPERVISOR SUB ALMACEN'),
(4070,6070,6072,'AUXILIAR DE ALMACEN'),
(4090,6080,6081,'SUPERVISOR DE CAMPO'),
(4090,6080,6082,'CHOFER PROMOTOR'),
(4090,6080,6083,'PROMOTOR');
GO

--------------------------------------------Creación de tabla de Sucursales--------------------------------------------
--SELECT * FROM tbl_sucursales
--DROP TABLE tbl_sucursales
--RFC	SUCURSAL	STATUS	ESTADO	CALLE Y NÚMERO	COLONIA	DELEGACIÓN O MUNICIPIO	C.P.	ZONA	SUPERVISOR DE ZONA	TELÉFONO

SELECT * FROM cat_statussucursal
CREATE TABLE tbl_sucursales
(
Id_Sucursal int identity (10000,10) primary key,
Nombre varchar (80),
Id_Statussuc int,
Id_Zona int,
Id_Estado int,
Calle_Numero varchar (140),
Id_Alcaldia int,
Telefono varchar (14),
Colonia varchar (120),
Codigo_Postal int,
Id_Eliminado bit default'0',
CONSTRAINT FK_Id_Eliminado_SUC FOREIGN KEY (Id_Eliminado)
References cat_eliminados (Id_Eliminado),
CONSTRAINT FK_Id_Statussucursal FOREIGN KEY (Id_Statussuc)
REFERENCES cat_statussucursal (Id_Statussuc),
CONSTRAINT FK_Id_EstadoSuc FOREIGN KEY (Id_Estado)
REFERENCES cat_estadosucursal (Id_Estado),
CONSTRAINT FK_Id_AlcaldiaSuc FOREIGN KEY (Id_Alcaldia)
REFERENCES cat_alcaldias (Id_Alcaldia),
CONSTRAINT FK_Id_Zonasuc FOREIGN KEY (Id_Zona)
REFERENCES cat_zonas (Id_zona)
)
INSERT INTO tbl_sucursales (Id_Zona,Nombre,Id_Alcaldia)
VALUES
 (3,'JACARANDAS 2',2),
 (4,'MEXICO 86',2),
 (4,'PALOMAS A',2),
 (4,'SAN JOSE DEL JARAL',2),
 (3,'SAN MARTIN DF',2),
 (8,'BOSQUES DE ARAGON 1',3),
 (8,'BOSQUES DE ARAGON 2',3),
 (8,'CAMPESTRE 1',3),
 (8,'CAMPESTRE 2',3),
 (8,'IMPULSORA',3),
 (8,'JARDINES DE GUADALUPE',3),
 (8,'VALLE DE ARAGON NEZA',3),
 (4,'PARQUE RESIDENCIAL COACALCO',4),
 (5,'MARTIRES DE RIO BLANCO',5),
 (5,'SANTA MARIA',5),
 (5,'SANTA MARIA 2',5),
 (7,'AV MEXICO',6),
 (6,'BOSQUES DE ANTEQUERA',6),
 (7,'CERRO GORDO',6),
 (6,'IZCALLI JARDINES',6),
 (6,'JARDINES DE MORELOS 2',6),
 (7,'LAURELES',6),
 (8,'NUEVA ARAGON',6),
 (7,'OLIMPICA',6),
 (8,'RENACIMIENTO',6),
 (7,'RUSTICA XALOSTOC',6),
 (6,'SAN ANDRES',6),
 (6,'SAN PEDRO 1',6),
 (6,'SAN PEDRO 2',6),
 (6,'SAN PEDRO 3',6),
 (7,'SANTA CLARA',6),
 (7,'TEOCALLIS',6),
 (6,'URBANA BUENAVISTA',6),
 (8,'VALLE DE GUADIANA',6),
 (6,'VILLAS DE ECATEPEC',6),
 (7,'VIVEROS',6),
 (7,'CHIQUIHUITE',7),
 (5,'MALINCHE',7),
 (8,'SAN FELIPE',7),
 (5,'ESCANDON',8),
 (2,'CHAMAPA',9),
 (3,'COLINAS DE SAN MATEO',9),
 (2,'LA MANCHA',9),
 (3,'MEXICO 68',9),
 (2,'MINAS PALACIO',9),
 (2,'MINAS PALACIOS 2',9),
 (3,'NOPALA',9),
 (3,'PRADERAS DE SAN MATEO',9),
 (2,'SAN AGUSTIN DF',9),
 (2,'SAN LORENZO',9),
 (4,'BARRIENTOS',10),
 (3,'JACARANDAS 1',10),
 (3,'MUNDO E',10),
 (5,'PIRAMIDE TENAYUCA',10),
 (5,'SAN LUCAS PATONI',10),
 (5,'SANTA CECILIA DF',10),
 (5,'TABLA HONDA',10),
 (5,'TENAYO',10),
 (3,'TLALNEMEX 2',10),
 (9,'LIBERTAD',11),
 (9,'SANTA CRUZ',11),
 (9,'TILAPA',11),
 (4,'ALBORADA',12),
 (4,'BUENAVISTA 2',12),
 (4,'PRADOS 1',12),
 (4,'SAN PABLO DE LAS SALINAS',12),
 (4,'SOLIDARIDAD',12),
 (5,'JAMAICA',13);

--------------------------------------------Creación de tabla de colaboradores--------------------------------------------
--SELECT * FROM tbl_colaboradoresgi
--DROP TABLE tbl_colaboradoresgi
CREATE TABLE tbl_colaboradoresgi
(
Id_Colaborador int not null primary key,
Numero_Emp int,
Nombre varchar (130) not null,
Apellido_Paterno varchar (50),
Apellido_Materno varchar (50),
Curp varchar (25),
RFC varchar (15),
Num_SS varchar (15),
Fecha_Nacimiento date,
Fecha_Registro date,
Comentarios varchar (200),
Id_Genero int,
Id_Eliminado bit default'0',
Fecha_Eliminado date,
Nombre_Usuario varchar (100),
Comentarios_2 varchar (200),
Observaciones varchar (200),
Columna1 varchar (200),
Columna2 varchar (200),
Columna3 varchar (200),
Columna4 varchar (200),
Columna5 varchar (200),
CONSTRAINT FK_Id_GeneroGI FOREIGN KEY (Id_Genero)
REFERENCES cat_generos (Id_Genero),
CONSTRAINT FK_Id_Eliminado FOREIGN KEY (Id_Eliminado)
REFERENCES cat_eliminados (Id_Eliminado)
);

--------------------------------------------JOIN PARA VISUAL--------------------------------------------
/*
SELECT Id_Colaborador AS Número_de_empleado,Nombre,Apellido_Paterno,Apellido_Materno FROM tbl_colaboradoresgi WHERE Id_Colaborador!=1
*/

--------------------------------------------Creación de tabla de dispensadores GI--------------------------------------------
CREATE TABLE tbl_dispensadoresgi
(
Id_Dispensador int not null primary key,
Numero_Emp int,
Nombre varchar (130) not null,
Apellido_Paterno varchar (50),
Apellido_Materno varchar (50),
Curp varchar (25),
RFC varchar (15),
Num_SS varchar (15),
Fecha_Nacimiento date,
Fecha_Registro date,
Comentarios varchar (200),
Id_Genero int,
Id_Eliminado bit default'0',
Fecha_Eliminado date,
Nombre_Usuario varchar (100),
Comentarios_2 varchar (200),
Observaciones varchar (200),
Columna1 varchar (200),
Columna2 varchar (200),
Columna3 varchar (200),
Columna4 varchar (200),
Columna5 varchar (200),
CONSTRAINT FK_Id_GeneroDIS FOREIGN KEY (Id_Genero)
REFERENCES cat_generos (Id_Genero),
CONSTRAINT FK_Id_EliminadoDIS FOREIGN KEY (Id_Eliminado)
REFERENCES cat_eliminados (Id_Eliminado)
);

--------------------------------------------Creación de tabla de colaboradores Plubek--------------------------------------------
--SELECT * FROM tbl_colaboradoresplubek
--DROP TABLE tbl_colaboradoresplubek
CREATE TABLE tbl_colaboradoresplubek
(
Id_Colaboradorplubek int identity (1,1) not null primary key,
Nombre varchar (130) not null,
Apellido_Paterno varchar (50),
Apellido_Materno varchar (50),
Curp varchar (25),
RFC varchar (15),
Num_SS varchar (15),
Fecha_Nacimiento date,
Fecha_Registro date,
Comentarios varchar (200),
Id_Genero int,
Id_Eliminado bit default'0',
Fecha_Eliminado date,
Nombre_Usuario varchar (100),
Comentarios_2 varchar (200),
Observaciones varchar (200),
Columna1 varchar (200),
Columna2 varchar (200),
Columna3 varchar (200),
Columna4 varchar (200),
Columna5 varchar (200),
CONSTRAINT FK_Id_GeneroP FOREIGN KEY (Id_Genero)
REFERENCES cat_generos (Id_Genero),
CONSTRAINT FK_Id_EliminadoP FOREIGN KEY (Id_Eliminado)
REFERENCES cat_eliminados (Id_Eliminado)
);

--------------------------------------------Creación de tabla de dispensadores plubek--------------------------------------------
--SELECT * FROM tbl_colaboradoresplubek
--DROP TABLE tbl_colaboradoresplubek
CREATE TABLE tbl_dispensadoresplubek
(
Id_Dispensadorplubek int identity (1,1) not null primary key,
Nombre varchar (130) not null,
Apellido_Paterno varchar (50),
Apellido_Materno varchar (50),
Curp varchar (25),
RFC varchar (15),
Num_SS varchar (15),
Fecha_Nacimiento date,
Fecha_Registro date,
Comentarios varchar (200),
Id_Genero int,
Id_Eliminado bit default'0',
Fecha_Eliminado date,
Nombre_Usuario varchar (100),
Comentarios_2 varchar (200),
Observaciones varchar (200),
Columna1 varchar (200),
Columna2 varchar (200),
Columna3 varchar (200),
Columna4 varchar (200),
Columna5 varchar (200),
CONSTRAINT FK_Id_Genero FOREIGN KEY (Id_Genero)
REFERENCES cat_generos (Id_Genero),
CONSTRAINT FK_Id_EliminadoDISPP FOREIGN KEY (Id_Eliminado)
REFERENCES cat_eliminados (Id_Eliminado)
);

--------------------------------------------Creación de tabla Colaboradores Detalle--------------------------------------------
--SELECT * FROM tbl_colaboradorgidetalle
--DROP TABLE tbl_colaboradorgidetalle
CREATE TABLE tbl_colaboradorgidetalle
(
Id_Colaborador int,
Id_Departamento int,
Id_Area int,
Id_Puesto int,
Ingreso_Plubek date,
Ingreso_Gi date,
Id_Status int,
Fecha_Baja date,
Id_Causa_Baja int,
Comentarios varchar (300),
Id_Eliminado bit default'0',
Id_Tipocolaborador int,
Fecha_Eliminado date,
Observaciones varchar (300),
Columna1 varchar (300)
CONSTRAINT FK_Id_Tipocolab FOREIGN KEY (Id_Tipocolaborador)
REFERENCES cat_tipocolaborador (Id_Tipocolaborador),
CONSTRAINT FK_Id_ColaboradorDetalle FOREIGN KEY (Id_Colaborador)
REFERENCES tbl_colaboradoresgi (Id_Colaborador),
CONSTRAINT FK_Id_DeártamentoDatalle FOREIGN KEY (Id_Departamento)
REFERENCES tbl_departamentos (Id_Departamento),
CONSTRAINT FK_Id_AreaDeatalle FOREIGN KEY (Id_Area)
REFERENCES tbl_areas (Id_Area),
CONSTRAINT FK_Id_PuestoDetalle FOREIGN KEY (Id_Puesto)
REFERENCES tbl_puestos (Id_puesto),
CONSTRAINT FK_Id_StatusDetalle FOREIGN KEY (Id_Status)
REFERENCES cat_status (Id_Status),
CONSTRAINT FK_Id_Causa_BajaDetalle FOREIGN KEY (Id_Causa_Baja)
REFERENCES cat_causabaja (Id_Causa_Baja),
CONSTRAINT FK_Id_EliminadoDetalle FOREIGN KEY (Id_Eliminado)
REFERENCES cat_eliminados (Id_Eliminado)
)

--------------------------------------------Creación de tabla Dispensador GI Detalle--------------------------------------------
--SELECT * FROM tbl_dispensadorgidetalle
--DROP TABLE tbl_dispensadorgidetalle
CREATE TABLE tbl_dispensadorgidetalle
(
Id_Dispensador int,
Id_Departamento int,
Id_Area int,
Id_Puesto int,
Id_Alcaldia int,
Id_Sucursal int,
Id_Horario int,
Ingreso_Plubek date,
Ingreso_Gi date,
Id_Status int,
Fecha_Baja date,
Id_Causa_Baja int,
Comentarios varchar (300),
Id_Eliminado bit default'0',
Id_Tipocolaborador int,
Fecha_Eliminado date,
Observaciones varchar (300),
Columna1 varchar (300),
CONSTRAINT FK_Id_TipocolabDISP FOREIGN KEY (Id_Tipocolaborador)
REFERENCES cat_tipocolaborador (Id_Tipocolaborador),
CONSTRAINT FK_Id_HorarioDisp FOREIGN KEY (Id_Horario)
REFERENCES cat_horarios (Id_Horario),
CONSTRAINT FK_Id_SucursalDISP FOREIGN KEY (Id_Sucursal)
REFERENCES tbl_sucursales (Id_Sucursal),
CONSTRAINT FK_Id_AlcaldiaDisp2 FOREIGN KEY (Id_Alcaldia)
REFERENCES cat_alcaldias (Id_Alcaldia),
CONSTRAINT FK_Id_DispensadorGI FOREIGN KEY (Id_Dispensador)
REFERENCES tbl_dispensadoresgi (Id_Dispensador),
CONSTRAINT FK_Id_DepartamentoDISP FOREIGN KEY (Id_Departamento)
REFERENCES tbl_departamentos (Id_Departamento),
CONSTRAINT FK_Id_AreaDeatalleDISP FOREIGN KEY (Id_Area)
REFERENCES tbl_areas (Id_Area),
CONSTRAINT FK_Id_PuestoDetalleDISP FOREIGN KEY (Id_Puesto)
REFERENCES tbl_puestos (Id_puesto),
CONSTRAINT FK_Id_StatusDetalleDISP FOREIGN KEY (Id_Status)
REFERENCES cat_status (Id_Status),
CONSTRAINT FK_Id_Causa_BajaDetalleDISP FOREIGN KEY (Id_Causa_Baja)
REFERENCES cat_causabaja (Id_Causa_Baja),
CONSTRAINT FK_Id_EliminadoDetalleDISP FOREIGN KEY (Id_Eliminado)
REFERENCES cat_eliminados (Id_Eliminado)
)

--------------------------------------------Creación de tabla Colaborador Plubek Detalle--------------------------------------------
--SELECT * FROM tbl_colaboradorPlubekdetalle
--DROP TABLE tbl_colaboradorPlubekdetalle
CREATE TABLE tbl_colaboradorPlubekdetalle
(
Id_Colaboradorplubek int,
Id_Departamento int,
Id_Area int,
Id_Puesto int,
Ingreso_Plubek date,
Id_Status int,
Fecha_Baja date,
Id_Causa_Baja int,
Comentarios varchar (300),
Id_Eliminado bit default'0',
Id_Tipocolaborador int,
Fecha_Eliminado date,
Observaciones varchar (300),
Columna1 varchar (300),
CONSTRAINT FK_Id_Tipocolabora FOREIGN KEY (Id_Tipocolaborador)
REFERENCES cat_tipocolaborador (Id_Tipocolaborador),
CONSTRAINT FK_Id_ColaboradorPlubek FOREIGN KEY (Id_Colaboradorplubek)
REFERENCES tbl_colaboradoresplubek (Id_Colaboradorplubek),
CONSTRAINT FK_Id_DepartamentoPL FOREIGN KEY (Id_Departamento)
REFERENCES tbl_departamentos (Id_Departamento),
CONSTRAINT FK_Id_AreaDeatallePL FOREIGN KEY (Id_Area)
REFERENCES tbl_areas (Id_Area),
CONSTRAINT FK_Id_PuestoDetallePL FOREIGN KEY (Id_Puesto)
REFERENCES tbl_puestos (Id_puesto),
CONSTRAINT FK_Id_StatusDetallePL FOREIGN KEY (Id_Status)
REFERENCES cat_status (Id_Status),
CONSTRAINT FK_Id_Causa_BajaDetallePL FOREIGN KEY (Id_Causa_Baja)
REFERENCES cat_causabaja (Id_Causa_Baja),
CONSTRAINT FK_Id_EliminadoDetallePL FOREIGN KEY (Id_Eliminado)
REFERENCES cat_eliminados (Id_Eliminado)
)

--------------------------------------------Creación de tabla Dispensador Plubek Detalle--------------------------------------------
--SELECT * FROM tbl_dispensadorpldetalle
--DROP TABLE tbl_dispensadorpldetalle
CREATE TABLE tbl_dispensadorpldetalle
(
Id_Dispensadorplubek int,
Id_Departamento int,
Id_Area int,
Id_Puesto int,
Id_Alcaldia int,
Id_Sucursal int,
Id_Horario int,
Ingreso_Plubek date,
Ingreso_Gi date,
Id_Status int,
Fecha_Baja date,
Id_Causa_Baja int,
Id_Eliminado bit default'0',
Id_Tipocolaborador int,
Fecha_Eliminado date,
Observaciones varchar (300),
Columna1 varchar (300),
CONSTRAINT FK_Id_TipocolabDISPPL FOREIGN KEY (Id_Tipocolaborador)
REFERENCES cat_tipocolaborador (Id_Tipocolaborador),
CONSTRAINT FK_Id_HorarioDispPL FOREIGN KEY (Id_Horario)
REFERENCES cat_horarios (Id_Horario),
CONSTRAINT FK_Id_SucursalDISPPL FOREIGN KEY (Id_Sucursal)
REFERENCES tbl_sucursales (Id_Sucursal),
CONSTRAINT FK_Id_AlcaldiaDisp2PL FOREIGN KEY (Id_Alcaldia)
REFERENCES cat_alcaldias (Id_Alcaldia),
CONSTRAINT FK_Id_DispensadorPL FOREIGN KEY (Id_Dispensadorplubek)
REFERENCES tbl_dispensadoresplubek (Id_Dispensadorplubek),
CONSTRAINT FK_Id_DepartamentoDISPPL FOREIGN KEY (Id_Departamento)
REFERENCES tbl_departamentos (Id_Departamento),
CONSTRAINT FK_Id_AreaDeatalleDISPPL FOREIGN KEY (Id_Area)
REFERENCES tbl_areas (Id_Area),
CONSTRAINT FK_Id_PuestoDetalleDISPPL FOREIGN KEY (Id_Puesto)
REFERENCES tbl_puestos (Id_puesto),
CONSTRAINT FK_Id_StatusDetalleDISPPL FOREIGN KEY (Id_Status)
REFERENCES cat_status (Id_Status),
CONSTRAINT FK_Id_Causa_BajaDetalleDISPPL FOREIGN KEY (Id_Causa_Baja)
REFERENCES cat_causabaja (Id_Causa_Baja),
CONSTRAINT FK_Id_EliminadoDetalleDISPPL FOREIGN KEY (Id_Eliminado)
REFERENCES cat_eliminados (Id_Eliminado)
)

--------------------------------------------creación de tabla usuarios--------------------------------------------
--SELECT * FROM tbl_usuarios
--DROP TABLE tbl_usuarios
CREATE TABLE tbl_usuarios
(
Id_Usuario int primary key,
Id_Colaborador int,
Usuario varchar (15),
Contraseña varchar (100),
Id_TipoUsuario int,
Id_Eliminado bit default'0',
CONSTRAINT FK_Id_Eliminadouser FOREIGN KEY (Id_Eliminado)
REFERENCES cat_eliminados (Id_Eliminado),
CONSTRAINT FK_Id_ColaboradorUS FOREIGN KEY (Id_Colaborador)
REFERENCES tbl_colaboradoresgi (Id_Colaborador),
CONSTRAINT FK_Id_TipousuarioUS FOREIGN KEY (Id_Tipousuario)
REFERENCES cat_tipousuario (Id_tipousuario)
)
INSERT INTO tbl_usuarios (Id_Usuario,Usuario,Contraseña,Id_TipoUsuario)
VALUES
('2210','2210','2210','5')

