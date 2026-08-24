create database KazanNeft_DB;

create table AssetGroups(
 IdGrupo smallint identity primary key,
 NomeGrupo varchar(60) not null
 );

 create table Employees(
 IdFuncionario smallint identity primary key,
 NomeFuncionario varchar(50) not null,
 SobrenomeFuncionario varchar(50) not null
 );

 create table Assets(
 IdAtivo smallint identity primary key,
 NumeroDeSerie varchar(50) not null UNIQUE,
 NomeAtivo varchar(50) not null,
 DataGarantia date not null,

 IdGrupo smallint,
	constraint fk_id_grupo foreign key (IdGrupo) references Assetgroups(IdGrupo),

IdFuncionario smallint,
	constraint fk_id_funcionario foreign key (Idfuncionario) references Employees(IdFuncionario)
	);

	insert into AssetGroups(NomeGrupo) values ('TI');
	insert into AssetGroups(NomeGrupo) values ('Transporte');

	insert into Employees (NomeFuncionario, SobrenomeFuncionario) values ('Carlos', 'Mendes');
	insert into Employees (NomeFuncionario, SobrenomeFuncionario) values ('Ana', 'Souza');

	insert into Assets (NomeAtivo,NumeroDeSerie,IdGrupo,IdFuncionario,DataGarantia) values ( 'Notebook Dell', 'SN1001', 1,1,'2026-12-31');
	insert into Assets (NomeAtivo,NumeroDeSerie,IdGrupo,IdFuncionario,DataGarantia) values ( 'Monitor LG', 'SN1002', 1,1,'2025-06-30');
	insert into Assets (NomeAtivo,NumeroDeSerie,IdGrupo,IdFuncionario,DataGarantia) values ( 'Toyota Hilux', 'SN2001', 2,2,'2030-01-01');

	Select
		Employees.NomeFuncionario as Nome,
		COUNT (Assets.IdAtivo) as TotalAtivos
		From Employees
		join Assets on Employees.IdFuncionario = Assets.IdFuncionario
		group by
		Employees.NomeFuncionario


