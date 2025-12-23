-- SECCION DE INSTALACION (Descomentar solo para resetear de fabrica)
-- USE master;
-- DROP DATABASE IF EXISTS OBRA_SOCIAL;
-- CREATE DATABASE OBRA_SOCIAL;
-- GO

USE OBRA_SOCIAL;
-- A partir de aqui crea las tablas...

CREATE TABLE BARRIOS (
Id_Barrio INT NOT NULL IDENTITY (1,1),
Barrio VARCHAR (25),
CONSTRAINT pk_id_ba PRIMARY KEY (Id_Barrio)
)

CREATE TABLE LOCALIDADES (
Id_Localidad INT NOT NULL IDENTITY (1,1),
Localidad VARCHAR (25),
CONSTRAINT pk_id_lo PRIMARY KEY (Id_Localidad)
)

CREATE TABLE CENTROS (
Cod_Centro INT NOT NULL,
--Lo hice un poco extenso porque no se bien a que se refiere la Denominacion
Denominacion VARCHAR (70),
Calle VARCHAR (25),
Numero INT,
Id_Barrio INT,
Id_Localidad INT,
Telefono INT,
--Al Mail lo dejo con mas caracteres, ya que me toco enviar mail a correos muy largos
Mail VARCHAR(45),
--Lo puse asi para que podamos poner SI o NO, la otra opción es ponerlo BOOLEAN
Propio CHAR(2),
CONSTRAINT pk_cod_cent PRIMARY KEY (Cod_Centro),
CONSTRAINT fk_id_bar FOREIGN KEY (Id_Barrio) REFERENCES BARRIOS,
CONSTRAINT fk_id_loc FOREIGN KEY (Id_Localidad) REFERENCES LOCALIDADES
)

CREATE TABLE PROFESIONALES (
Matricula INT NOT NULL,
Apellido VARCHAR (25),
Nombre VARCHAR (25),
Calle VARCHAR (25),
Numero INT,
Id_Barrio INT,
Id_Localidad INT,
Telefono INT,
CONSTRAINT pk_Matri PRIMARY KEY (Matricula),
CONSTRAINT fk_idbar FOREIGN KEY (Id_Barrio) REFERENCES BARRIOS,
CONSTRAINT fk_idloc FOREIGN KEY (Id_Localidad) REFERENCES LOCALIDADES
)

CREATE TABLE ESPECIALIDADES (
	Cod_Especialidad INT NOT NULL,
	Nombre VARCHAR (25),
	CONSTRAINT pk_codesp PRIMARY KEY (Cod_Especialidad)
)

CREATE TABLE TIPOS_AFILIADO (
	Cod_Tipo INT NOT NULL,
	--No se que tanto hace falta describir, por las dudas la deje en 70
	Descripcion VARCHAR (70),
	CONSTRAINT pk_Cod_TipYDescr PRIMARY KEY (Cod_Tipo)
)

CREATE TABLE PRACTICAS (
	Id_Practica INT NOT NULL,
	Descripcion VARCHAR (70),
	Precio NUMERIC (8,2) CHECK(Precio > 0),
	CONSTRAINT pk_IdPract PRIMARY KEY (Id_Practica)
)

CREATE TABLE ESPECIALIDADES_POR_CENTROS (
	Cod_Centro INT NOT NULL,
	Cod_Especialidad INT NOT NULL,
	CONSTRAINT pk_codCenYEsp PRIMARY KEY (Cod_Centro, Cod_Especialidad),
	CONSTRAINT fk_CodCent FOREIGN KEY (Cod_Centro) REFERENCES CENTROS,
	CONSTRAINT fk_CodEspe FOREIGN KEY (Cod_Especialidad) REFERENCES ESPECIALIDADES
)

CREATE TABLE AFILIADOS (
Nro_Afiliado INT NOT NULL,
Apellido VARCHAR (25),
Nombre VARCHAR (25),
Fecha_Nacimiento DATE CHECK (Fecha_Nacimiento < GETDATE()),
Id_Tipo_Afiliado INT,
Fecha_Inscripcion DATE CHECK (Fecha_Inscripcion < GETDATE()),
Monto_Inscripcion NUMERIC (8,2) CHECK (Monto_Inscripcion > 0),
CONSTRAINT pk_Nro_Af PRIMARY KEY (Nro_Afiliado),
CONSTRAINT fk_Id_Tipo_Afili FOREIGN KEY (Id_Tipo_Afiliado) REFERENCES TIPOS_AFILIADO
)

CREATE TABLE COBERTURAS (
	Id_Tipo_Afiliado INT NOT NULL,
	Id_Practica INT NOT NULL, 
	--El Porcentaje lo podría haber hecho VARCHAR para que me tome el simbolo %, pero eso lo decidimos nosotros
	Porcentaje_Cobertura INT NOT NULL,
	CONSTRAINT pk_Ids_TipoAfilYPrac PRIMARY KEY (Id_Tipo_Afiliado, Id_Practica),
	CONSTRAINT fk_TipoAfi FOREIGN KEY (Id_Tipo_Afiliado) REFERENCES TIPOS_AFILIADO,
	CONSTRAINT fk_IdPract FOREIGN KEY (Id_Practica) REFERENCES PRACTICAS
)

CREATE TABLE PROFESIONALES_POR_CENTROS_POR_ESPECIALIDAD (
	Cod_Especialidad INT NOT NULL,
	Cod_Centro INT NOT NULL,
	Matricula INT NOT NULL,
	CONSTRAINT pk_EsYCeYMatr PRIMARY KEY (Cod_Especialidad, Cod_Centro, Matricula),
	CONSTRAINT fk_Cod_EspYCent FOREIGN KEY (Cod_Especialidad, Cod_Centro) REFERENCES ESPECIALIDADES_POR_CENTROS,
	CONSTRAINT fk_Matri FOREIGN KEY (Matricula) REFERENCES PROFESIONALES
)

CREATE TABLE ATENCIONES_POR_AFILIADO (
Nro_Afiliado INT NOT NULL,
--Ver si hace falta validacion de la Fecha_De_Atencion
Fecha_De_Atencion DATE,
Cod_Centro INT,
Cod_Especialidad INT,
Matricula INT,
Importe NUMERIC (8,2) CHECK (Importe > 0),
Id_Practica INT,
CONSTRAINT pk_Nro_AfiYFecAten PRIMARY KEY (Nro_Afiliado, Fecha_De_Atencion),
CONSTRAINT fk_Nro_Afil FOREIGN KEY (Nro_Afiliado) REFERENCES AFILIADOS,
CONSTRAINT fk_Cod_Cent FOREIGN KEY (Cod_Centro) REFERENCES CENTROS,
CONSTRAINT fk_CodEspec FOREIGN KEY (Cod_Especialidad) REFERENCES ESPECIALIDADES,
CONSTRAINT fk_Matricu FOREIGN KEY (Matricula) REFERENCES PROFESIONALES,
CONSTRAINT fk_Practic FOREIGN KEY (Id_Practica) REFERENCES PRACTICAS
)

CREATE TABLE VALOR_CUOTA (
	Id_Tipo_Afiliado INT NOT NULL,
	Edad_Desde DATE NOT NULL,
	Monto NUMERIC (8,2) CHECK (Monto > 0),
	CONSTRAINT pk_TipoAfilYEda PRIMARY KEY (Id_Tipo_Afiliado, Edad_Desde),
	CONSTRAINT fk_TipAfil FOREIGN KEY (Id_Tipo_Afiliado) REFERENCES TIPOS_AFILIADO
)

CREATE TABLE CUOTAS_PAGAS (
	Nro_Afiliado INT NOT NULL,
	Nro_Cuota INT NOT NULL,
	Anio_Cuota INT NOT NULL,
	--Ver si la Fecha_Pago hace falta validacion
	Fecha_Pago DATE,
	Monto_Emergencia NUMERIC (8,2) CHECK (Monto_Emergencia > 0),
	CONSTRAINT pk_NroAfiYCUOtaYAni PRIMARY KEY (Nro_Afiliado, Nro_Cuota, Anio_Cuota),
	CONSTRAINT fk_NroAfil FOREIGN KEY (Nro_Afiliado) REFERENCES AFILIADOS
)

--Preguntar si Id_Tipo_Afiliado hace referencia a Cod_Tipo de la tabla TIPOS_AFILIADO, supongo que SI
--Tomamos que todos los pagos son superiores a cero, es decir no hay bonificacion, aca se cobra todo

