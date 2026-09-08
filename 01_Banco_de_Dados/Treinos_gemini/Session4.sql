create table Properties(
IdProperty smallint identity primary key,
Title varchar(60) not null UNIQUE,
DailyPrice decimal (10,2) not null
);

create table Reservations(
IdReservation smallint identity primary key,
CheckInDate date not null,
CheckOutDate date not null,

IdProperty smallint,
constraint fk_id_propriedade foreign key (IdProperty) references Properties(IdProperty),

IdUser int not null
);

insert into Properties (Title,DailyPrice) values ('Condomínio de Luxo em Gangnam', 250.00), ('Casa Tradicional Hanok', 150.00);
insert into Reservations(IdUser, IdProperty,CheckInDate,CheckOutDate) values (1,2,'2026-09-10','2026-09-15');

update
	Reservations 
	set CheckInDate = '2026-09-08'
	where Reservations.IdReservation = 1;