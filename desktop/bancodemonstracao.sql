create database demonstracao
use demonstracao

create table tblArtigo(
idArtigo int primary key identity,
titulo varchar(200),
resumo varchar(500),
link varchar(120),
genero varchar(100)
)