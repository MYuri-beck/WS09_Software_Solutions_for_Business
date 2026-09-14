create database LibrarySystem;

create table Publisher(
IdPublisher smallint identity primary key,
PublisherName varchar(60) not null
);

Create table Book(
IdBook smallint identity primary key,
BookName varchar(60) not null,
Price decimal (10,2)not null,

IdPublisher smallint,
constraint fk_id_editora foreign key (IdPublisher) references Publisher(IdPublisher)
);

insert into Publisher(PublisherName) values ('TechBooks Publishing'), ('Literatura Global');
insert into Book(BookName,Price,IdPublisher) values ( 'Guia Definitivo C#',85.50,1), ('Algoritmos Avançados',120.00,1)

Update 
	Book
set Price = 95.50
where IdBook = 1;

Select

	Book.BookName,
	Book.Price,
	Publisher.IdPublisher
	from
	Book
 join 
 Publisher on Book.IdPublisher = Publisher.IdPublisher;
