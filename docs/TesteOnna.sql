
CREATE DATABASE Pogge
Use Pogge



-- Mobile 1

CREATE TABLE tblUser(
idUser int identity primary key,
emailUser varchar(120),
senhaUser varbinary(100),
nomeUser varchar(100),
dataNasc date 
)
CREATE TABLE tblCalendario(
idCalendario int identity primary key,
idUser int foreign key references tblUser(idUser),
diaMarcado int,
periodo int default 3
)
CREATE TABLE tblHumor(
idHumor int identity primary key,
idUser int foreign key references tblUser(idUser),
humor int
)
CREATE TABLE tblHumor_Relatorio(
idUser int foreign key references tblUser(idUser),
idHumor int foreign key references tblHumor(idHumor),
relatorio decimal
)
CREATE TABLE tblNotificação(
idNotificacao int identity primary key,
idUser int foreign key references tblUser(idUser),
conteudoNot varchar(200)
)
CREATE TABLE tblAjuda(
idAjuda int identity primary key,
idUser int foreign key references tblUser(idUser),
tituloAjuda varchar(50),
conteudoAjuda varchar(200),
dataHora date
)
CREATE TABLE tblNoticias(
idNoticias int identity primary key,
generoNoticia varchar(50),
conteudoNoticia varchar(500)
)

-- MOBILE 2

CREATE TABLE tblVoluntario(
codVerificador varchar(8) primary key,
formacaoVol varchar(80),
emailVol varchar(120),
nomeVol varchar(100),
senhaVol varchar(20),
diasDispo varchar(31)
)

CREATE TABLE tblForum(
idForum int identity primary key,
nomeForum varchar(80)
)
CREATE TABLE tblMensagem_Forum(
idMensagem int identity primary key,
idForum int foreign key references tblForum(idForum),
mensagemForum varchar(200)
)
/* tentativa do chat hiper*/

CREATE TABLE tblReceptor(
idReceptor int identity primary key,
idUser int foreign key references tblUser(idUser)
)
CREATE TABLE tblMensagem_Chat (
idUser int foreign key references tblUser(idUser),
idReceptor int foreign key references tblReceptor(idReceptor),
mensagem varchar(250),
enviadoStatus varchar(10) default 'não enviado'
)


/*LOGIN*/
INSERT INTO tblUser values
('phsushi@hotmail.com','09090','Paulo','12-12-1960'),
('bombomRicardo@gmail.com','76611','Bombs','12-09-1897')


INSERT INTO tblReceptor (idUser) values
(3),
(4)
/*MANDA MENSAGEM*/
INSERT INTO tblMensagem_Chat values
(3,4,'shimishimiEY, beleza?')


 /*CRIPTOGRAFIA*/
 /*
 select PWDENCRYPT('.')
declare @pwd1 varbinary(100)

set @pwd1 = PWDENCRYPT(@pwd1)

insert into tblUser(senhaUser)values(@pwd1)


select * from tblUser
 */

