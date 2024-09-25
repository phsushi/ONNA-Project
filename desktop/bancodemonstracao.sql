create database demonstracao
use demonstracao

create table tblArtigo(
idArtigo int primary key identity,
titulo varchar(200),
resumo varchar(500),
link varchar(120),
genero varchar(100)
)


insert into tblArtigo values ('campotitulo','resumo','4000sa','warchanger')


select * from tblArtigo