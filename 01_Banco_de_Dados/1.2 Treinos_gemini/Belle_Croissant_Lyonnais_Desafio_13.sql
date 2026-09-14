create database BelleCroissantLyonnaisBI;

Create table Customers (
IdCustomer smallint identity primary key,
Name varchar(60) not null
);

Create table CustomerFeedback(
IdFeedback smallint identity primary key,
Rating int not null, 

IdCustomer smallint,
constraint fk_id_cliente foreign key (IdCustomer) references Customers(IdCustomer)
);

Create table WebsiteAnalytics(
IdAnalytics smallint identity primary key,
PageViews int not null,
VisitDate date not null
);

insert into Customers(Name) values ('Pierre Martin');
insert into CustomerFeedback(IdCustomer, Rating) values (1,5);
insert into WebsiteAnalytics(PageViews,VisitDate) values (1500, '2026-08-28');

Select
 AVG(Rating) Ratings from CustomerFeedback