CREATE DATABASE IF NOT EXISTS sisorgdata;
use sisorgdata;

CREATE TABLE Projeto(
	ID_projeto int primary key auto_increment,
	Data_inicio date,
	Tipo varchar(20),
	Status varchar (50),
	Nome varchar (50),
	Descricao varchar (40),
	Data_termino date,
	Orcamento numeric (10,2)
);

CREATE TABLE Progresso(
	ID_progresso int primary key,
	Financeiro numeric (10,2),
	Porcent_tarefa numeric (10,2),
	Status_Equipe varchar (50),
	ID_projeto int,
	foreign key (ID_projeto) references Projeto (ID_projeto)
);

CREATE TABLE Equipe(
	ID_equipe int primary key,
	Nome varchar (50),
	Qte_Membros int,
	Tempo numeric(10,2),
	Preco_Temp numeric(10,2),
	ID_progresso int,
	ID_projeto int,
	foreign key (ID_progresso) references Progresso(ID_progresso),
	foreign key (ID_projeto) references Projeto (ID_projeto)
);

CREATE TABLE Membro(
	CPF varchar(11) primary key,
	Cargo varchar (25),
	Nome varchar (30), 
	ID_equipe int,
	foreign key (ID_equipe) references Equipe (ID_equipe)
);

CREATE TABLE Tarefas(
	ID_tarefas int primary key,
	Prazo date,
	Titulo varchar (20),
	Status varchar (50),
	CPF varchar (11),
	ID_progresso int,
	ID_projeto int,
	Foreign key (CPF) references Membro (CPF),
	Foreign key (ID_progresso) references Progresso (ID_progresso),
	Foreign key (ID_projeto) references Projeto (ID_projeto)
);

CREATE TABLE Subtarefa (
	ID_subtarefa int primary key,
	Prazo date not null,
	Status varchar (50) not null,
	Titulo varchar (40) not null,
	ID_tarefas int not null, 
	Foreign key (ID_tarefas) references Tarefas(ID_tarefas)
);

CREATE TABLE Custo (
	ID_custo int primary key,
	Valor decimal (10, 2) not null,
	Tipo varchar (50) not null,
	ID_projeto int not null,
	ID_progresso int not null,
	Foreign key (ID_projeto) references Projeto(ID_projeto),
	Foreign key (ID_progresso) references Progresso(ID_progresso)
);

CREATE TABLE Custo_Equipe (
	ID_equipe int not null,
	ID_custo int not null, 
	Primary key (ID_equipe, ID_custo),
	foreign key (ID_equipe) references Equipe(ID_equipe),
	foreign key (ID_custo) references Custo(ID_custo)
);

CREATE TABLE Recurso (
	ID_recurso int not null,
	Qte_util int not null,
	Qte_disp int not null,
	Preco_unit decimal(10, 2) not null,
	Tipo varchar(50) not null,
	ID_custo int not null,
	ID_projeto int not null,
	Primary key (ID_recurso),
	Foreign key(ID_custo) references Custo (ID_custo),
	Foreign key (ID_projeto) references Projeto (ID_projeto)
);

insert into Projeto (data_inicio, tipo, status, nome, descricao, data_termino, orcamento)
values('1981-02-01', 'NANDE', 'incompleto', 'c', 'd', '1991-02-01', 100.00);

insert into progresso(ID_Progresso, financeiro, porcent_tarefa, status_equipe, ID_Projeto)
values (1, 100.00, 0.00, 0.00, 1);

insert into equipe(ID_Equipe, nome, qte_membros, tempo, preco_temp, ID_Progresso, ID_Projeto)
values(1, 'trupe 8 e 7', 3, 15.5, 29.99, 1, 1);

insert into membro(cpf, cargo, nome, id_equipe)
values('12345678900', 'Presidente', 'Jerson', 1);

insert into tarefas (ID_tarefas, Prazo, titulo, status, cpf, ID_Progresso, ID_Projeto)
values(1, '1953-01-01', 'Fabricar x', 'Incompleto', '12345678900', 1, 1);

insert into subtarefa (ID_subtarefa, prazo, status, titulo, ID_tarefas)
values(1, '1954-03-02', 'incompleto', 'fabricar', 1);

select * from membro;
select * from custo