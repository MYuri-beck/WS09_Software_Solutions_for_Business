create database BelleCroissantLyonnais;

create table Customers(
IdCustomer smallint identity primary key,
Name varchar(60) not null,
LoyaltyPoints int default 0
);

create table Products(
IdProducts smallint identity primary key,
ProductName varchar (60) not null,
Price decimal(10,2) not null
);

create table Orders(
IdOrder smallint identity primary key,
OrderDate date not null,

IdCustomer smallint,
constraint fk_id_cliente foreign key (IdCustomer) references Customers (IdCustomer)
);

insert into Customers(Name,LoyaltyPoints) values
	('João Silva', 150),('Maria Souza', 50);

insert into Products(ProductName,Price) values 
	('Croissant Tradicional', 12.50), ('Baguette',8.00);

insert into Orders(IdCustomer,OrderDate) values 
	(1, '2026-08-28');

Update 
	Customers
	set LoyaltyPoints = LoyaltyPoints + 50
	where
		IdCustomer = 1;

		select * from Customers