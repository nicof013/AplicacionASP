CREATE DATABASE ProyectoMuestraASP1;

CREATE TABLE usuarios (
usu_id int IDENTITY(1,1) NOT NULL,
usu_nombre varchar(50) NOT NULL,
usu_apellido varchar(50) NOT NULL,
usu_mail varchar(100) NOT NULL UNIQUE,
usu_pass varbinary(max) NOT NULL,
CONSTRAINT PK_Usuarios PRIMARY KEY (usu_id) );

------------------------------------------------

CREATE TABLE contacto_mensajes(
cmje_id int IDENTITY(1,1) NOT NULL,
cmje_nombre varchar(50) NOT NULL,
cmje_mail varchar(50) NOT NULL,
cmje_mensaje varchar(150) NOT NULL,
cmje_fecha datetime NOT NULL );

------------------------------------------------

CREATE TABLE log_usuarios(
log_id int IDENTITY(1,1) NOT NULL,
usu_id int  NOT NULL,
log_fecha datetime  NOT NULL,
CONSTRAINT FK_UsuariosLog FOREIGN KEY (usu_id) REFERENCES usuarios(usu_id) );



--------------------------- STORED PROCEDURES ---------------------------

CREATE PROCEDURE [dbo].[sp_contacto_mensajes_insertar]
	@nombre varchar(50),
	@mail varchar(50),
	@mensaje varchar(150)
AS
BEGIN
	INSERT INTO contacto_mensajes(cmje_nombre,cmje_mail,cmje_mensaje,cmje_fecha)
	VALUES (@nombre,@mail,@mensaje,GETDATE())
END

------------------------------------------------

CREATE PROCEDURE [dbo].[sp_contacto_mensajes_listar] 
@mail varchar(50)
AS
BEGIN
	IF @mail = '' OR @mail is null
		BEGIN
			SELECT cmje_nombre as Nombre, cmje_mail as Mail, cmje_mensaje as Mensaje, cmje_fecha as Fecha
			FROM contacto_mensajes
		END
	ELSE
		BEGIN
			SELECT cmje_nombre as Nombre, cmje_mail as Mail, cmje_mensaje as Mensaje, cmje_fecha as Fecha
			FROM contacto_mensajes
			WHERE cmje_mail = @mail
		END
END

------------------------------------------------

CREATE PROCEDURE [dbo].[sp_log_usuarios_registro] 
	@mail varchar(50)
AS
BEGIN
	INSERT INTO log_usuarios(usu_id,log_fecha)
	SELECT usu_id, GETDATE() FROM usuarios WHERE usu_mail = @mail
END

------------------------------------------------

CREATE PROCEDURE [dbo].[sp_usuario_existe_mail]
	@mail varchar(50)	
AS
BEGIN
	SELECT * FROM usuarios WHERE usu_mail = @mail
END

------------------------------------------------

CREATE PROCEDURE [dbo].[sp_usuario_listar]	
AS
BEGIN
	SELECT usu_nombre as Nombre, usu_apellido as Apellido, usu_mail as Mail
	FROM usuarios
END

------------------------------------------------

CREATE PROCEDURE [dbo].[sp_usuario_login] 	
	@mail varchar(50),
	@clave varchar(50)	
AS
BEGIN
	SELECT * 
	FROM usuarios 
	WHERE usu_mail = @mail 
	AND usu_pass = HASHBYTES('SHA2_256',@clave)
END

------------------------------------------------

CREATE PROCEDURE [dbo].[sp_usuario_logueado] 
	@mail varchar(50)
AS
BEGIN
	SELECT usu_nombre as Nombre, usu_apellido as Apellido, usu_mail as Mail, ISNULL(MAX(lg.log_fecha),GETDATE()) as "Ultima Conexion"
	FROM usuarios u left join log_usuarios lg
	ON u.usu_id = lg.usu_id
	WHERE u.usu_mail = @mail
	GROUP BY usu_nombre, usu_apellido,usu_mail
END

------------------------------------------------

CREATE PROCEDURE [dbo].[sp_usuario_registro]
	@nombre varchar(50),
	@apellido varchar(50),
	@mail varchar(100),
	@clave varchar(50)
AS
BEGIN
	
	INSERT INTO usuarios (usu_nombre, usu_apellido, usu_mail, usu_pass)
	VALUES(@nombre,@apellido,@mail,HASHBYTES('SHA2_256',@clave))

END
