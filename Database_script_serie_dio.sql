-- comandos DDL
Drop database if exists dbseriesdio;
create database dbSeriesDIO;
use  dbSeriesDIO;

CREATE TABLE Serie (
  idSerie INT NOT NULL auto_increment,
  Nome VARCHAR(80) NOT NULL,
  Descricao varchar(500) not null,
  AnoSerie int, 
  PRIMARY KEY (idSerie)
);

CREATE TABLE Genero (
  idGenero INT NOT NULL AUTO_INCREMENT,
  Nome VARCHAR(70) NOT NULL,
  PRIMARY KEY (idGenero)
);

CREATE TABLE GeneroSerie (
  idGenero INT NOT NULL,
  idSerie INT NOT NULL,
  PRIMARY KEY (idGenero, idSerie),
  CONSTRAINT fkGenero1 FOREIGN KEY (idGenero) REFERENCES Genero (idGenero)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT fkSerie1 FOREIGN KEY (idSerie) REFERENCES Serie (idSerie)
    ON DELETE CASCADE
    ON UPDATE CASCADE
);

INSERT INTO Genero ( Nome) VALUES
( 'Comédia'),
( 'Drama'),
( 'Adulto'),
( 'Família'),
( 'Romance'),
( 'Programa de entrevistas'),
( 'Animação'),
( 'Música'),
('Aventura'),
( 'Fantasia'),
( 'Açao'),
( 'Ficção científica'),
( 'Notícia'),
( 'Crime'),
( 'Game-Show'),
( 'Mistério'),
( 'Musical'),
( 'Terror'),
( 'Suspense'),
( 'Reality-TV'),
( 'Documentário'),
( 'Esporte'),
( 'História'),
( 'Ocidental'),
( 'Biografia'),
( 'Guerra');

INSERT INTO Serie ( Nome, Descricao, AnoSerie) VALUES
('Dark','Viagem no tempo e muita treta de família',2019),
('Black Mirror','Cada EP uma história muito louca',2016),
('The Mandalorian','Baby yoda é muito fofo', 2020),
('The Witcher','Bruxeiro tando espada em geral', 2019);

insert into GeneroSerie values 
(22,5 ),(29,5), (39,5);

create procedure sp_ExibeSerieGenero()
select s.nome SERIE, g.nome GENERO from GeneroSerie gs
inner join serie s on s.idSerie = gs.idSerie
inner join genero g on g.idGenero = gs.idGenero
;

call  sp_ExibeSerieGenero();
select s.nome SERIE, s.descricao, g.nome GENERO from Serie s
inner join GeneroSerie gs on s.idSerie = gs.idSerie
inner join genero g on g.idGenero = gs.idGenero
;

select s.descricao, g.genero