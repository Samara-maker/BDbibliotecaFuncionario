create database bdBiblioteca;
use bdBiblioteca; 

CREATE TABLE CURSO (
    id_curso INT AUTO_INCREMENT PRIMARY KEY,
    nome_curso VARCHAR(100) NOT NULL,
    duracaoMeses_curso INT,
    modalidade_curso VARCHAR(50) NOT NULL
);

CREATE TABLE ALUNO (
    id_aluno INT AUTO_INCREMENT PRIMARY KEY,
    nome_alu VARCHAR(100) NOT NULL,
    matricula_alu VARCHAR(20) NOT NULL,
    email_alu VARCHAR(100) NOT NULL,
    dataNasc_alu DATE,
    cpf_alu VARCHAR(14) NOT NULL UNIQUE,
    telefone_alu VARCHAR(20),
    id_curso_fk INT NOT NULL,
    FOREIGN KEY (id_curso_fk) REFERENCES CURSO(id_curso)
);

CREATE TABLE FUNCIONARIO (
    id_func INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    sexo varchar(10),
    cpf VARCHAR(14) NOT NULL UNIQUE,
    cargo VARCHAR(50) NOT NULL,
    email VARCHAR(100) NOT NULL,
    telefone VARCHAR(20),
    dataNasc datetime,
    dataAdmissao datetime,
    dataDemissao datetime
);

alter table funcionario change dataDemissao dataDemissao varchar(30);
       
CREATE TABLE LIVRO (
    id_livro INT AUTO_INCREMENT PRIMARY KEY,
    titulo_li VARCHAR(150) NOT NULL,
    editora_li VARCHAR(100) NOT NULL,
    edicao_li VARCHAR(20)
);

CREATE TABLE AUTOR (
    id_autor INT AUTO_INCREMENT PRIMARY KEY,
    nome_autor VARCHAR(100) NOT NULL,
    dataNasc_autor DATE
);

CREATE TABLE LIVRO_AUTOR (
	id_livro_autor INT AUTO_INCREMENT PRIMARY KEY,
	ordemAutoria INT,
    id_livro_fk INT NOT NULL,
    id_autor_fk INT NOT NULL,
    FOREIGN KEY (id_livro_fk) REFERENCES LIVRO(id_livro),
    FOREIGN KEY (id_autor_fk) REFERENCES AUTOR(id_autor)
);

CREATE TABLE CATEGORIAS (
    id_categorias INT AUTO_INCREMENT PRIMARY KEY,
    descricao VARCHAR(100) NOT NULL
);

CREATE TABLE LIVRO_CATEGORIA (
	id_livro_categoria INT AUTO_INCREMENT PRIMARY KEY,
    id_livro_fk INT NOT NULL,
    id_categoria_fk INT NOT NULL,
    FOREIGN KEY (id_livro_fk) REFERENCES LIVRO(id_livro),
    FOREIGN KEY (id_categoria_fk) REFERENCES CATEGORIAS(id_categorias)
);

CREATE TABLE EXEMPLAR (
    id_exemplar INT AUTO_INCREMENT PRIMARY KEY,
    localizacao VARCHAR(50) NOT NULL,
    codigoBarras VARCHAR(50) NOT NULL,
	id_livro_fk INT NOT NULL,
    FOREIGN KEY (id_livro_fk) REFERENCES LIVRO(id_livro)
);


CREATE TABLE RESERVA (
    id_reserva INT AUTO_INCREMENT PRIMARY KEY,
    data_reserva DATE NOT NULL,
    data_limite DATE NOT NULL,
    status_reserva VARCHAR(20),
	id_aluno_fk INT NOT NULL,
    id_exemplar_fk INT NOT NULL,
    FOREIGN KEY (id_aluno_fk) REFERENCES ALUNO(id_aluno),
    FOREIGN KEY (id_exemplar_fk) REFERENCES EXEMPLAR(id_exemplar)
);
CREATE TABLE EMPRESTIMO (
    id_emprestimo INT AUTO_INCREMENT PRIMARY KEY,
    dataEmprestimo DATE NOT NULL,
    dataDevolucao DATE,
    situacao VARCHAR(20) NOT NULL,
	id_aluno_fk INT NOT NULL,
    id_exemplar_fk INT NOT NULL,
    id_func_fk INT NOT NULL,
    FOREIGN KEY (id_aluno_fk) REFERENCES ALUNO(id_aluno),
    FOREIGN KEY (id_exemplar_fk) REFERENCES EXEMPLAR(id_exemplar),
    FOREIGN KEY (id_func_fk) REFERENCES FUNCIONARIO(id_func)
);
CREATE TABLE RENOVACAO (
    id_renovacao INT AUTO_INCREMENT PRIMARY KEY,
    data_renovacao DATE NOT NULL,
    novo_prazo DATE NOT NULL,
	id_emprestimo_fk INT NOT NULL,
    FOREIGN KEY (id_emprestimo_fk) REFERENCES EMPRESTIMO(id_emprestimo)
);

#INSERTS
INSERT INTO CURSO (nome_curso, duracaoMeses_curso, modalidade_curso) VALUES
('Tecnico Informática', 36, 'Presencial'),
('Tecnico Química', 36, 'Presencial'),
('Tecnico Floresta', 36, 'Presencial'),
('Licenciatura quimica', 48, 'Presencial'),
('Engenharia Florestal', 72, 'Presencial'),
('Analise e Desenvollvimento de Sistemas', 36, 'Presencial'),
('Gestão Publica', 24, 'EAD'),
('Gestão comercial', 24, 'EAD'),
('Curso tecnico em administração', 24, 'EAD'),
('Pós Graduação Lato Sensu em Informática na Educação', 6, 'EAD');
select * from curso;

INSERT INTO ALUNO (nome_alu, matricula_alu, email_alu, dataNasc_alu, cpf_alu, telefone_alu, id_curso_fk) VALUES
('Darth Vader', '20210001', 'darth@ifro.edu.br', '2003-05-10', '111.111.111-11', '69999990001', 1),
('Luke Skywalker', '20210002', 'luke@ifro.edu.br', '2002-08-15', '222.222.222-22', '69999990002', 2),
('Ahsoka Tano', '20210003', 'ahsoka@ifro.edu.br', '2001-01-20', '333.333.333-33', '69999990003', 3),
('R2-D2', '20210004', 'r2@ifro.edu.br', '2000-04-30', '444.444.444-44', '69999990004', 4),
('Leia', '20210005', 'leia@ifro.edu.br', '2002-09-10', '555.555.555-55', '69999990005', 5),
('Yoda', '20210006', 'yoda@ifro.edu.br', '2001-02-17', '666.666.666-66', '69999990006', 6),
('Mace Windu', '20210007', 'mace@ifro.edu.br', '2003-03-05', '777.777.777-77', '69999990007', 7),
('Qui Gon Jinn', '20210008', 'quigon@ifro.edu.br', '2004-06-22', '888.888.888-88', '69999990008', 8),
('Samara Hespanhol', '20210009', 'samarahe@ifro.edu.br', '2000-11-13', '999.999.999-99', '69999990009', 9),
('Samara Fraga', '20210010', 'samarafr@ifro.edu.br', '2003-07-19', '000.000.000-00', '69999990010', 10);
select * from aluno;

INSERT INTO FUNCIONARIO (nome, sexo, cpf, cargo, email, telefone, dataNasc, dataAdmissao, dataDemissao) VALUES
('Marcos Pereira', 'Masculino', '101.101.101-01', 'Bibliotecário', 'marcos@ifro.edu.br', '69999991001', '1980-05-15', '2010-03-01', NULL),
('Renata Dias', 'Feminino', '202.202.202-02', 'Auxiliar', 'renata@ifro.edu.br', '69999991002', '1985-07-20', '2012-06-15', NULL),
('José Lima', 'Masculino', '303.303.303-03', 'Técnico', 'jose@ifro.edu.br', '69999991003', '1990-03-10', '2015-01-10', NULL),
('Ana Lúcia', 'Feminino', '404.404.404-04', 'Bibliotecário', 'ana@ifro.edu.br', '69999991004', '1978-11-25', '2008-09-22', NULL),
('Carlos Mendes', 'Masculino', '505.505.505-05', 'Auxiliar', 'carlos@ifro.edu.br', '69999991005', '1983-01-05', '2011-04-12', NULL),
('Juliana Rocha', 'Feminino', '606.606.606-06', 'Técnico', 'juliana@ifro.edu.br', '69999991006', '1992-08-30', '2016-10-08', NULL),
('Tiago Alves', 'Masculino', '707.707.707-07', 'Bibliotecário', 'tiago@ifro.edu.br', '69999991007', '1981-02-18', '2009-12-03', NULL),
('Patrícia Silva', 'Feminino', '808.808.808-08', 'Técnico', 'patricia@ifro.edu.br', '69999991008', '1987-04-12', '2013-07-19', NULL),
('Fernanda Dias', 'Feminino', '909.909.909-09', 'Auxiliar', 'fernanda@ifro.edu.br', '69999991009', '1991-09-17', '2017-02-25', NULL),
('Lucas Moreira', 'Masculino', '010.010.010-10', 'Bibliotecário', 'lucas@ifro.edu.br', '69999991010', '1984-06-28', '2010-11-11', NULL);

select * from funcionario;

INSERT INTO LIVRO (titulo_li, editora_li, edicao_li) VALUES
('Introdução à Programação', 'Editora A', '1ª'),
('Química Básica', 'Editora B', '2ª'),
('Florestas do Brasil', 'Editora C', '3ª'),
('Matemática Aplicada', 'Editora D', '1ª'),
('Física Moderna', 'Editora E', '4ª'),
('Biologia Celular', 'Editora F', '2ª'),
('Geografia do Brasil', 'Editora G', '3ª'),
('História Mundial', 'Editora H', '5ª'),
('Gramática Avançada', 'Editora I', '2ª'),
('Arte Contemporânea', 'Editora J', '1ª');


 select * from livro;
 
INSERT INTO AUTOR (nome_autor, dataNasc_autor) VALUES
('Machado de Assis', '1839-06-21'),
('Clarice Lispector', '1920-12-10'),
('Carlos Drummond de Andrade', '1902-10-31'),
('Cecília Meireles', '1901-11-07'),
('Jorge Amado', '1912-08-10'),
('Monteiro Lobato', '1882-04-18'),
('Lima Barreto', '1881-05-13'),
('Graciliano Ramos', '1892-10-27'),
('Manuel Bandeira', '1886-04-19'),
('Rachel de Queiroz', '1910-11-17');
select * from autor;

INSERT INTO LIVRO_AUTOR (id_livro_fk, id_autor_fk, ordemAutoria) VALUES
(1, 1, 1),
(2, 2, 1),
(3, 3, 1),
(4, 4, 1),
(5, 5, 1),
(6, 6, 1),
(7, 7, 1),
(8, 8, 1),
(9, 9, 1),
(10, 10, 1);
select * from livro_autor;

INSERT INTO CATEGORIAS (descricao) VALUES
('Tecnologia'),
('Química'),
('Meio Ambiente'),
('Matemática'),
('Física'),
('Biologia'),
('Geografia'),
('História'),
('Língua Portuguesa'),
('Artes');
select * from categorias;

INSERT INTO LIVRO_CATEGORIA (id_livro_fk, id_categoria_fk) VALUES
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5),
(6, 6),
(7, 7),
(8, 8),
(9, 9),
(10, 10);
select * from livro_categoria;

INSERT INTO EXEMPLAR (localizacao, codigoBarras, id_livro_fk) VALUES
('Estante A1', '1000001', 1),
('Estante B1', '1000002', 2),
('Estante C1', '1000003', 3),
('Estante D1', '1000004', 4),
('Estante E1', '1000005', 5),
('Estante F1', '1000006', 6),
('Estante G1', '1000007', 7),
('Estante H1', '1000008', 8),
('Estante I1', '1000009', 9),
('Estante J1', '1000010', 10);
select *from exemplar;

INSERT INTO RESERVA (data_reserva, data_limite, status_reserva, id_aluno_fk, id_exemplar_fk) VALUES
('2025-05-25', '2025-05-30', 'Ativa', 1, 2),
('2025-05-26', '2025-05-31', 'Expirada', 2, 3),
('2025-05-27', '2025-06-01', 'Cancelada', 3, 4),
('2025-05-28', '2025-06-02', 'Ativa', 4, 5),
('2025-05-29', '2025-06-03', 'Expirada', 5, 6),
('2025-05-30', '2025-06-04', 'Cancelada', 6, 7),
('2025-05-31', '2025-06-05', 'Ativa', 7, 8),
('2025-06-01', '2025-06-06', 'Ativa', 8, 9),
('2025-06-02', '2025-06-07', 'Expirada', 9, 10),
('2025-06-03', '2025-06-08', 'Ativa', 10, 1);
select * from reserva;

INSERT INTO EMPRESTIMO (dataEmprestimo, dataDevolucao, situacao, id_aluno_fk, id_exemplar_fk, id_func_fk) VALUES
('2025-06-01', '2025-06-10', 'Devolvido', 1, 1, 1),
('2025-06-02', '2025-06-11', 'Em andamento', 2, 2, 2),
('2025-06-03', '2025-06-11', 'Em andamento', 3, 3, 3),
('2025-06-04', '2025-06-13', 'Devolvido', 4, 4, 4),
('2025-06-05', '2025-06-11', 'Em andamento', 5, 5, 5),
('2025-06-06', '2025-06-11', 'Em andamento', 6, 6, 6),
('2025-06-07', '2025-06-16', 'Devolvido', 7, 7, 7),
('2025-06-08', '2025-06-11', 'Em andamento', 8, 8, 8),
('2025-06-09', '2025-06-11', 'Em andamento', 9, 9, 9),
('2025-06-10', '2025-06-19', 'Devolvido', 10, 10, 10);
select * from emprestimo;

INSERT INTO RENOVACAO (data_renovacao, novo_prazo, id_emprestimo_fk) VALUES
('2025-06-05', '2025-06-15', 2),
('2025-06-06', '2025-06-16', 3),
('2025-06-07', '2025-06-17', 5),
('2025-06-08', '2025-06-18', 6),
('2025-06-09', '2025-06-19', 8),
('2025-06-10', '2025-06-20', 9),
('2025-06-11', '2025-06-21', 2),
('2025-06-12', '2025-06-22', 3),
('2025-06-13', '2025-06-23', 5),
('2025-06-14', '2025-06-24', 6);
select * from renovacao;


#nessa primeira consulta irei usar o inner join
#vou listar o nome dos alunos, o titulo dos livros que estão sendo emprestados e data do emprestimo
select a.nome_alu as aluno, l.titulo_li as Livro, e.dataEmprestimo as data_emprestimo
	from emprestimo e inner join aluno a on e.id_aluno_fk = a.id_aluno
	inner join exemplar ex on e.id_exemplar_fk = ex.id_exemplar
	inner join livro l on ex.id_livro_fk = l.id_livro;

#usando left join
#vou listar todos os livros com autores
select l.titulo_li as livro, a.nome_autor as autor
	from livro l left join livro_autor la on l.id_livro = la.id_livro_fk
	left join autor a on la.id_autor_fk = a.id_autor;
    
#usando o right join
#nesse script vou apresentar todos os livros que estão associados com os autores
select a.nome_autor as autor, l.titulo_li as livro
	from autor a right join livro_autor la on a.id_autor = la.id_autor_fk
	right join livro l on la.id_livro_fk = l.id_livro;

#2 consultas que utilizam subconsultas (consultas aninhadas);
#nessa primeira consulta, está selecionando os alunos que realizaram a renovação mais de uma vez
select nome_alu from aluno where id_aluno in (
    select e.id_aluno_fk from emprestimo e
    inner join renovacao r on e.id_emprestimo = r.id_emprestimo_fk
    group by e.id_emprestimo having COUNT(r.id_renovacao) > 1
);

#nessa segunda consulta, está mostrando os livros que estão emprestados
select titulo_li from livro where id_livro in (
    select ex.id_livro_fk from exemplar ex
    inner join emprestimo em on ex.id_exemplar = em.id_exemplar_fk
    where em.situacao = 'Em andamento'
);

#2 consultas que utilizam GROUP BY, sendo uma obrigatoriamente usando a cláusula HAVING
#nessa primeira consulta, estou consultando os livros por categoria
select c.descricao, COUNT(lc.id_livro_fk) as total_livros
	from categorias c inner join  livro_categoria lc on c.id_categorias = lc.id_categoria_fk
	group by c.descricao;

#Empréstimos com mais de uma renovação
select id_emprestimo_fk, COUNT(*) as total_renovacoes
	from renovacao group by id_emprestimo_fk having COUNT(*) > 1;

