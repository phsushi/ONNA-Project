
-- Inserções iniciais

use master
drop database ONNA

create database ONNA
go
use ONNA


-- Tabela central

create table tblTipo_Usuario(
email varchar(120) primary key,
senha varbinary(max) not null,	
nome varchar(100) not null,
status_Ban bit,
dataNasc date not null,
avatar varbinary(max),
tipo_Usuario bit not null-- Valor [0] será perfil pessoal; valor [1] será perfil profissional
)


-- Funcionalidade de chat privado

go
create table tblContato(
idContato varchar(120) primary key, -- Assumirá o valor do email do usuário
email varchar(120) foreign key references tblTipo_Usuario(email) not null,
ultima_Mensagem varchar(50)
)

go
create table tblColecao_Contato(
email varchar(120) foreign key references tblTipo_Usuario(email) not null,
idContato varchar(120) foreign key references tblContato(idContato)
)

go
create table tblConversa_Privada(
email varchar(120) foreign key references tblTipo_Usuario(email) not null,
idContato varchar(120) foreign key references tblContato(idContato) not null,
mensagem varbinary not null,
data_Envio date not null,
hora_Envio time not null
)


-- Funcionalidades do mobile "Perfil Pessoal"

go
create table tblPerfil_Pessoal(
idUsuario varchar(120) primary key,
email varchar(120) foreign key references tblTipo_Usuario(email) not null
)

go
create table tblAjuda(
idAjuda int primary key identity,
idUsuario varchar(120) foreign key references tblPerfil_Pessoal(idUsuario) not null,
titulo varchar(50) not null,
conteudo varbinary not null,
data_Hora datetime not null
)

go
create table tblNotificacao(
idNotificacao int primary key identity,
idUsuario varchar(120) foreign key references tblPerfil_Pessoal(idUsuario) not null,
conteudo varbinary
)

go
create table tblCalendario_Personalizado(
idCalendario int primary key identity,
idUsuario varchar(120) foreign key references tblPerfil_Pessoal(idUsuario) not null,
dia_Marcado date not null,
periodo int not null
)

go
create table tblHumor(
idHumor int primary key identity,
humor int not null
)

go
create table tblHumor_Relatorio(
idUsuario varchar(120) foreign key(idUsuario) references tblPerfil_Pessoal(idUsuario) not null,
idHumor int foreign key references tblHumor(idHumor) not null,
relatorio decimal not null
)


-- Funcionalidades do mobile "Perfil Profissional"

go
create table tblPerfil_Profissional(
idProfissional varchar(120) primary key,
email varchar(120) foreign key references tblTipo_Usuario(email) not null,
crm char(8) not null,
crp char(8) not null,
formacao varchar(80) not null,
hora_Inicial time, -- Início do intervalo de disponibilidade para chat
hora_Final time -- Fim do intervalo de disponibilidade para chat
)

go
create table tblGenero(
idGenero int primary key, -- Cada inteiro irá se referir a um dos gêneros já definidos (maternidade, sexual etc.)
genero varchar(40) not null
)

go 
create table tblArtigo(
idArtigo int primary key identity,
idProfissional varchar(120) foreign key references tblPerfil_Profissional(idProfissional) default 'Equipe ONNA' not null,
idGenero int foreign key references tblGenero(idGenero),
titulo varchar(255) not null,
resumo varbinary not null,
link varbinary not null,
imagem varbinary(max),
data_Publicacao date not null
)


-- Funcionalidades do website

go
create table tblForum(
idForum int primary key identity,
nome varchar(80) not null,
descricao varbinary
)

go
create table tblPostagem(
idPostagem int primary key identity,
email varchar(120) foreign key references tblTipo_Usuario(email) not null,
idForum int foreign key references tblForum(idForum) not null,
status_Ban bit,
mensagem varbinary not null,
data_Envio date not null,
hora_Envio time not null,
gostei int,
desgostei int
)

go
create table tblResposta_Postagem(
idResposta_Postagem int primary key identity,
email varchar(120) foreign key references tblTipo_Usuario(email) not null,
idPostagem int foreign key references tblPostagem(idPostagem) not null,
status_Ban bit,
mensagem varbinary not null,
data_Envio date not null,
hora_Envio time not null,
gostei int,
desgostei int
)

go
create table tblDenuncia(
idDenuncia int primary key identity,
email varchar(120) foreign key references tblTipo_Usuario(email) not null,
idPostagem int foreign key references tblPostagem(idPostagem),
idResposta_Postagem int foreign key references tblResposta_Postagem(idResposta_Postagem),
descricao varbinary,
data_Envio date not null,
hora_Envio time not null 
)

go
create table tblTipo_Denuncia(
idTipo_Denuncia int primary key, -- Cada inteiro irá se referir a um dos tipos já definidos (ofensa, discriminação etc.)
tipo varchar(40) not null
)

go
create table tblColecao_Tipo(
idColecao_Tipo int primary key identity,
idDenuncia int foreign key references tblDenuncia(idDenuncia) not null,
idTipo_Denuncia int foreign key references tblTipo_Denuncia(idTipo_Denuncia) not null
)


-- Desktop

go

create table tblAdmin(
idAdmin int primary key identity,
login varbinary(max) not null,
senha varbinary(max) not null
)