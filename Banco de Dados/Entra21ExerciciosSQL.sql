CREATE TABLE pessoas(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(100),
	cpf VARCHAR(14),
	rg VARCHAR(12),
	data_de_nascimento DATETIME2,
	idade INTEGER
);

INSERT INTO pessoas
	(nome, cpf, rg, data_de_nascimento, idade)
	VALUES ('Erick Bryan Enrico Vieira',
	'699.734.958-70',
	'90.745.276-0',
	'1989-05-28',
	'29');

INSERT INTO pessoas
	(nome, cpf, rg, data_de_nascimento, idade)
	VALUES ('Samuel Ruan Dias',
	'802.790.194-40',
	'55.318.691-7',
	'1988-02-08',
	'30');

	INSERT INTO pessoas
	(nome, cpf, rg, data_de_nascimento, idade)
	VALUES ('Fábio Benjamin Souza',
	'522.445.349-60',
	'54.715.232-2',
	'1970-03-22',
	'48');