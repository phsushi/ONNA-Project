
-- Inserções iniciais

use master
drop database ONNA

create database ONNA
go
use ONNA


-- Tabela central

create table tblTipo_Usuario(
idTipo_Usuario int primary key identity,
email varchar(120) unique,
senha varbinary(max) not null,	
nome varchar(100) not null,
status_Ban boolean default 0,
dataNasc date not null,
avatar int not null, -- Serão imagens pré-selecionadas por nossa equipe, depositadas na pasta do aplicativo web/mobile
tipo_Usuario boolean not null -- Valor [0] será perfil pessoal; valor [1] será perfil profissional
)


-- Funcionalidade de chat privado

go
create table tblContato(
idContato int primary key identity,
idTipo_Usuario int foreign key references tblTipo_Usuario(idTipo_Usuario) not null,
ultima_Mensagem varchar(50)
)

go
create table tblColecao_Contato(
idTipo_Usuario int foreign key references tblTipo_Usuario(idTipo_Usuario) not null,
idContato int foreign key references tblContato(idContato)
)

go
create table tblConversa_Privada(
idTipo_Usuario int foreign key references tblTipo_Usuario(idTipo_Usuario) not null,
idContato int foreign key references tblContato(idContato) not null,
mensagem varbinary not null,
data_Hora date not null
)


-- Funcionalidades do mobile "Perfil Pessoal"

go
create table tblPerfil_Pessoal(
idUsuario int primary key identity,
idTipo_Usuario int foreign key references tblTipo_Usuario(idTipo_Usuario) not null,
)

go
create table tblAjuda(
idAjuda int primary key identity,
idUsuario int foreign key references tblPerfil_Pessoal(idUsuario) not null,
titulo varchar(50) not null,
mensagem varbinary not null,
data_Hora datetime not null
)

go
create table tblNotificacao(
idNotificacao int primary key identity,
idUsuario int foreign key references tblPerfil_Pessoal(idUsuario) not null,
mensagem varbinary not null
)

go
create table tblCalendario_Personalizado(
idCalendario int primary key identity,
idUsuario int foreign key references tblPerfil_Pessoal(idUsuario) not null,
dia_Marcado date not null,
periodo int not null
)

go
create table tblHumor(
idHumor int primary key identity,
humor int not null
)

go
create table tblRelatorio_Humor(
idUsuario int foreign key references tblPerfil_Pessoal(idUsuario) not null,
idHumor int foreign key references tblHumor(idHumor) not null,
media_Humor decimal not null,
data_Relatorio date not null

)


-- Funcionalidades do mobile "Perfil Profissional"

go
create table tblPerfil_Profissional(
idProfissional int primary key identity,
idTipo_Usuario int foreign key references tblTipo_Usuario(idTipo_Usuario) not null,
crm char(8),
crp char(8),
area_Formacao varchar(80) not null
)

go
create table tblDia_Semana(
idDia_Semana int primary key identity,
dia_Semana date not null -- Dia da semana que se repetirá periodicamente ao longo do calendário
)

go
create table tblDisponibilidade(
idProfissional int foreign key references tblPerfil_Profissional(idProfissional) not null,
idDia_Semana int foreign key references tblDia_Semana(idDia_Semana) not null,
hora_Inicial time not null, -- Início do intervalo de disponibilidade para chat
hora_Final time not null -- Fim do intervalo de disponibilidade para chat
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
idTipo_Usuario int foreign key references tblTipo_Usuario(idTipo_Usuario) not null,
idForum int foreign key references tblForum(idForum) not null,
status_Ban boolean default 0,
mensagem varbinary not null,
imagem varbinary(max),
data_Hora date not null,
gostei int,
desgostei int
)

go
create table tblResposta_Postagem(
idResposta_Postagem int primary key identity,
idTipo_Usuario int foreign key references tblTipo_Usuario(idTipo_Usuario) not null,
idPostagem int foreign key references tblPostagem(idPostagem) not null,
status_Ban boolean default 0,
mensagem varbinary not null,
data_Hora date not null,
gostei int,
desgostei int
)

go
create table tblDenuncia(
idDenuncia int primary key identity,
idTipo_Usuario int foreign key references tblTipo_Usuario(idTipo_Usuario) not null,
idPostagem int foreign key references tblPostagem(idPostagem),
idResposta_Postagem int foreign key references tblResposta_Postagem(idResposta_Postagem),
descricao varbinary,
data_Hora date not null
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


-- Funcionalidade Desktop

go
create table tblAdmin(
idAdmin int primary key identity,
login varbinary(max) not null,
senha varbinary(max) not null
)

go
create table tblGenero(
idGenero int primary key, -- Cada inteiro irá se referir a um dos gêneros já definidos (maternidade, sexual etc.)
genero varchar(40) not null
)

go 
create table tblArtigo(
idArtigo int primary key identity,
idAdmin int foreign key references tblAdmin(idAdmin) not null,
idGenero int foreign key references tblGenero(idGenero),
titulo varchar(255) not null,
resumo varbinary not null,
link varbinary not null,
imagem varbinary(max),
data_Publicacao date not null
)
