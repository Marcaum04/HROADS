USE SENAI_HROADS_MANHA;
GO

INSERT INTO CLASSE (nomeC)
VALUES  ('Bárbaro'), ('Cruzado'), 
		('Caçadora de Demônios'), ('Monge'), 
		('Necromante'), ('Feiticeiro'), 
		('Arcanista')
GO


INSERT INTO TIPOHABILIDADE (nomeTH)
VALUES  ('Ataque'), ('Defesa'), 
		('Cura'), ('Magia')
GO



INSERT INTO HABILIDADE (nomeH, idTipoHabilidade)
VALUES  ('Lança mortal',1), ('Escudo Suprema',2),
		('Recuperar Vida',3)
GO



INSERT INTO CLASSEHABILIDADE(idHabilidade, idClasse)
VALUES  (1,1),(2,1),
		(2,2),(1,3),
		(2,4),(3,4),
		(3,6)
GO

INSERT INTO TIPOUSUARIO (tituloUsuario)
VALUES ('Administrador'), ('Jogador')

INSERT INTO USUARIO (idTipoUsuario, nomeUsuario, email, senha)
VALUES (1, 'ROGER ADM', 'ROGERINHOADM@ADM.COM', 'ADM123'),
		(2, 'WILLIAMONGE', 'WILLIAMPOGGERS@JOGADOR.COM', 'WWWWW')

INSERT INTO PERSONAGEM (idClasse, nomeP,idUsuario, vidaMaxima, manaMaxima, dataAtuailizacao, dataCriacao)
VALUES  (1,'DeuBug',NULL,100,80,'2019-01-18','2019-01-18'),
		(4,'BitBug',2,70,100,'2016-03-17','2016-03-17'),
		(7,'Fer8',NULL,75,60,'2018-03-18','2018-03-18')
GO


UPDATE PERSONAGEM
SET nomeP = 'Fer7'
WHERE IdPersonagem = 3;
GO

UPDATE CLASSE
SET nomeC = 'Necromancer'
WHERE idClasse = 5;
GO


