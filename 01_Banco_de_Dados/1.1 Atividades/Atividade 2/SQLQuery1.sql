create database hoteis_db;

use hoteis_db;

create table TipoAcomodacao(
Id smallint identity primary key,
Nomenclatura varchar(60) not null,
Diaria decimal(10,2) not null,
Capacidade smallint not null
);

Create table Quarto(
Id smallint identity primary key,
Numero smallint not null,
TipoAcomodacao_Id smallint not null,
constraint fk_id_TipoAcomodacao foreign key (TipoAcomodacao_Id) references TipoAcomodacao(Id)
);

create table Reserva(
Id smallint identity primary key,
Checkin datetime not null,
Checkout datetime,

Quarto_Id smallint not null,
constraint fk_id_quarto foreign key (Quarto_Id) references Quarto(Id),

Total decimal (10,2) not null default 0,

constraint valida_data_reserva CHECK (Checkout > Checkin)
);

Create table Modificador(
Id smallint identity primary key,
Percentual decimal (4,3) not null,
Titulo varchar (60) not null,
DataInicio date not null, 
DataFim date not null
);
go
CREATE TRIGGER tg_calcula_total_reserva 
ON Reserva
AFTER INSERT, UPDATE
AS
BEGIN
    -- Evita execuções desnecessárias se nenhuma linha foi afetada
    IF @@ROWCOUNT = 0 RETURN;

    UPDATE r
    SET Total = 
        -- 1. PARTE DOS DIAS NORMAIS: (Total de dias - Dias no modificador) * Valor da Diária
        ((DATEDIFF(day, i.Checkin, i.Checkout) - ISNULL(mod_calc.DiasModificador, 0)) * ta.Diaria) 
        + 
        -- 2. PARTE DOS DIAS MODIFICADOS: (Dias no modificador * Valor da Diária * Percentual/Fator)
        (ISNULL(mod_calc.DiasModificador, 0) * ta.Diaria * ISNULL(mod_calc.Percentual, 1))

    FROM Reserva r
    INNER JOIN inserted i ON r.Id = i.Id
    INNER JOIN Quarto q ON i.Quarto_Id = q.Id
    INNER JOIN TipoAcomodacao ta ON q.TipoAcomodacao_Id = ta.Id
    
    -- O OUTER APPLY busca e calcula os dias que caem dentro do período de modificador/feriado
    OUTER APPLY (
        SELECT TOP 1 
            m.Percentual,
            DATEDIFF(day, 
                -- Limite inicial da sobreposição
                CASE WHEN i.Checkin > m.DataInicio THEN i.Checkin ELSE m.DataInicio END,
                -- Limite final da sobreposição
                CASE WHEN i.Checkout < m.DataFim THEN i.Checkout ELSE m.DataFim END
            ) AS DiasModificador
        FROM Modificador m
        -- Garante que o período da reserva realmente cruza com o período do modificador
        WHERE i.Checkin < m.DataFim AND i.Checkout > m.DataInicio
    ) mod_calc;
END;
GO

