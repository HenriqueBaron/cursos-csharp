CREATE TABLE twc_cursos
(
	twc_id INT IDENTITY(1,1) PRIMARY KEY,
	twc_nome VARCHAR(40) NOT NULL,
	twc_descricao TEXT
);

INSERT INTO twc_cursos (twc_nome, twc_descricao) VALUES
('C#', 'Aprenda a programar em C#'),
('ADO.NET', 'Acessando bancos de dados utilizando o ADO.NET'),
('Windows Phone 8.1', 'Crie aplicativos para o Windows Phone 8.1');

SELECT * FROM twc_cursos;