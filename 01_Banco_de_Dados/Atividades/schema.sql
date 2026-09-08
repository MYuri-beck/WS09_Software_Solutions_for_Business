create database BelleCroissantLyonnais_DB1;

use BelleCroissantLyonnais_DB1;

create table stores(
ID smallint identity primary key,
Endereco varchar (70) not null,
CodigoPostal varchar(11) not null,
Telefone varchar(11) not null
);

create table Products(
ID smallint identity primary key,
Nome varchar(60) not null,
Categoria varchar (60) not null,
Preco decimal (10,2) not null,
Custo decimal (10,2) not null,
IndicadorSazonal varchar(60),
StatusAtivo bit
);

create table Customers( 
ID smallint identity primary key,
Nome varchar(60) not null,
Sobrenome varchar(60) not null,
Email varchar(60) unique not null,
Telefone varchar(11) not null,
StatusFidelidade varchar(60) not null,
DataCadastro date not null
);

create table Promotions(
ID smallint identity primary key,
Codigo varchar (60) not null,
PercentualDesconto smallint not null,
DataInicio date not null,
DataFim date not null
);

Create table Orders(
ID smallint identity primary key,
IDLoja smallint not null,
constraint fk_id_lojas foreign key (IDLoja) references stores(ID),
IDCliente smallint not null,
Constraint fk_id_cliente foreign key (IDCliente) references Customers(ID),
IDPromocao smallint,
constraint fk_id_promocao foreign key (IDPromocao) references Promotions(ID),
DataHora datetime not null, 
MetodoPagamento varchar(60) not null,
Canal varchar(60) not null,
ValorDesconto smallint
);

create table order_items(
IDPedido smallint not null,
IDProduto smallint not null,
Quantidade smallint not null,
PrecoUnitario decimal(10,2),
primary key (IDPedido, IDProduto)
);