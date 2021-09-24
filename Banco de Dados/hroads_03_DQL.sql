USE SENAI_HROADS_MANHA
GO

SELECT * FROM HABILIDADE
GO

SELECT * FROM CLASSEHABILIDADE
GO

--Selecionar todos os personagens;
SELECT * FROM PERSONAGEM
GO

--Selecionar todos as classes
SELECT * FROM CLASSE
ORDER BY idClasse
GO

--Selecionar somente o nome das classes
SELECT nomeC Classe FROM CLASSE
GO

--Selecionar todas as habilidades
SELECT * FROM HABILIDADE
GO

--Realizar a contagem de quantas habilidades estão cadastradas
SELECT COUNT (*) AS [Total de Habilidades] FROM HABILIDADE 
GO

--Selecionar somente os id’s das habilidades classificando-os por ordem crescente
SELECT idHabilidade FROM HABILIDADE
ORDER BY idHabilidade
GO

--Selecionar todos os tipos de habilidades
SELECT * FROM TIPOHABILIDADE
GO

--Selecionar todas as habilidades e a quais tipos de habilidades elas fazem parte
SELECT nomeH Habilidade, nomeTH Tipo FROM HABILIDADE
LEFT JOIN TIPOHABILIDADE
ON TIPOHABILIDADE.idTipoHabilidade = HABILIDADE.idTipoHabilidade

--Selecionar todos os personagens e suas respectivas classes
SELECT nomeP Nome, vidaMaxima 'Vida Máxima', manaMaxima 'Mana Máxima', nomeC Classe, dataCriacao 'Data Criação', dataAtuailizacao 'Data Atualização' FROM PERSONAGEM
LEFT JOIN CLASSE
ON PERSONAGEM.idClasse = CLASSE.idClasse
GO

--Selecionar todos os personagens e as classes (mesmo que elas não tenham correspondência em personagens)
SELECT nomeP Nome, vidaMaxima 'Vida Máxima', manaMaxima 'Mana Máxima', nomeC Classe, dataCriacao 'Data Criação', dataAtuailizacao 'Data Atualização' FROM CLASSE
FULL OUTER JOIN PERSONAGEM
ON CLASSE.idClasse = PERSONAGEM.idClasse
GO

--Selecionar todas as classes e suas respectivas habilidades
SELECT nomeC Classes, nomeH Habilidades FROM CLASSE
LEFT JOIN CLASSEHABILIDADE
ON CLASSE.idClasse = CLASSEHABILIDADE.idClasse
LEFT JOIN HABILIDADE
ON CLASSEHABILIDADE.idHabilidade = HABILIDADE.idHabilidade

--Selecionar todas as habilidades e suas classes (somente as que possuem correspondência)
SELECT nomeC Classes, nomeH Habilidades FROM HABILIDADE
LEFT JOIN CLASSEHABILIDADE
ON CLASSEHABILIDADE.idHabilidade = HABILIDADE.idHabilidade
INNER JOIN CLASSE
ON CLASSE.idClasse = CLASSEHABILIDADE.idClasse

--Selecionar todas as habilidades e suas classes (mesmo que elas não tenham correspondência).
SELECT nomeC Classes, nomeH Habilidades FROM HABILIDADE
LEFT JOIN CLASSEHABILIDADE
ON CLASSEHABILIDADE.idHabilidade = HABILIDADE.idHabilidade
LEFT JOIN CLASSE
ON CLASSE.idClasse = CLASSEHABILIDADE.idClasse