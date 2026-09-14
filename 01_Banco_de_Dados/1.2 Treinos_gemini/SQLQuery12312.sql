create database SeoulStayDB1;

use SeoulStayDB1;

create table items(
ID smallint identity primary key,
GUID uniqueidentifier,
Title varchar(60)
);

create table Amenities(
ID smallint identity primary key,
GUID uniqueidentifier,
Name varchar(60),
IconName varchar(60)
);

Create table ItemAmenities(
ID smallint identity primary key,
GUID uniqueidentifier,
ItemID smallint,
constraint fk_id_item foreign key (ItemId) references Items (ID),
AmenityID smallint,
constraint fk_id_amenity foreign key (AmenityId) references Amenities(ID)
);

Insert into Amenities(Name, GUID) values ('Ar condicionado', NEWID());
insert into items(Title, GUID) values ('Cobertura em Seul', NEWID());
insert into ItemAmenities(ItemID,AmenityID,GUID) values (1,1,NEWID());

select
	a.Name as Comodidade,
	i.Title as 'Titulo do imovel'

from
	ItemAmenities ia
inner join
	Amenities a on ia.AmenityID = a.ID

inner join 
	items i on ia.ItemID  = i.ID;
