Create database Session6;

create table Products(
IdProduct smallint identity primary key,
Name varchar(60) not null,
BasePrice decimal (10,2) not null
);

create table Customizations(
IdCustomization smallint identity primary key,
Description varchar (120) not null,
ExtraCost decimal(10,2) not null,

IdProduct smallint,
constraint fk_id_prdouto foreign key (IdProduct) references Products(IdProduct)
);

insert into Products(Name,BasePrice) values ('Croissant Clássico',10.00);
insert into Customizations(Description, ExtraCost, IdProduct) values ('Recheio Extra de Chocolate',4.50,1), ('Cobertura de Amêndoas',3.00,1);

select
	Products.Name as 'Nome do Produto',
	c.Description as 'Descrição da personalização',
	Products.BasePrice + c.ExtraCost

	from 
		Products

	join
		Customizations c on Products.IdProduct = c.IdProduct;