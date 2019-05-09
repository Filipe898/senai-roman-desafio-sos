create database TRABALHO_ROMAN

use TRABALHO_ROMAN

 CREATE TABLE TIPO_USUARIOS (
	id_tipo_usuario int identity primary key
	,nm_tipo_usuario varchar(255) not null
 );

  CREATE TABLE EQUIPE (
	id_equipe int identity primary key
	,ds_equipe varchar(255) not null
 );

   CREATE TABLE TEMA (
	id_tema int identity primary key
	,ds_tema varchar(255) not null
 );

  CREATE TABLE PROJETO (
	id_projeto int identity primary key
	,nm_projeto varchar(255) not null
	,id_tema int foreign key references tema (id_tema)
);

CREATE TABLE USUARIOS (
	id_usuarios int identity primary key
	,nm_usuarios varchar(255) not null
	,ds_senha varchar(255) 
	,num_telefone varchar (30) not null
	,ds_e_mail varchar(255) not null
	,id_tipo_usuarios int foreign key references tipo_usuarios (id_tipo_usuario)
	,id_equipe int foreign key references equipe (id_equipe)
	,id_projeto int foreign key references projeto (id_projeto)
);

INSERT INTO TIPO_USUARIOS (nm_tipo_usuario)
VALUES ('PROFESSOR'),('ADMNISTRAD0R');

INSERT INTO EQUIPE (ds_equipe)
VALUES ('DESENVOLVIMENTO'),('REDES'),('MULTIMIDIA');

INSERT INTO TEMA (ds_tema)
VALUES ('REUTILIZAÇÃO'),('INOVAÇÃO'),('SUGESTÃO');

INSERT INTO PROJETO (nm_projeto, id_tema)
VALUES ('ALPHA',1),
		('BETA',2),
		('OMEGA',3),
		('DELTA',3);

INSERT INTO USUARIOS(nm_usuarios, ds_senha, num_telefone, ds_e_mail, id_tipo_usuarios, id_equipe, id_projeto)
VALUES ('HELENA',123,11928387322,'HELENA@HELENA',2,1,1),
		('FERNANDO',456,11983325712,'FERNANDO@FERNANDO',2,2,2),
		('FILIPE',789,11984330932,'FILIPE@FILIPE',1,3,3),
		('DENAO',234,1196231836,'DENAO@DENAO',1,1,4),
		('LUCIANO',432,11938235278,'LUCIANO@LUCIANO',1,2,1);


SELECT * FROM TIPO_USUARIOS;
SELECT * FROM EQUIPE;
SELECT * FROM TEMA;
SELECT * FROM PROJETO;
SELECT * FROM USUARIOS;

