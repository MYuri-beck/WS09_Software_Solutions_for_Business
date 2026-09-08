insert into stores (Endereco,CodigoPostal, Telefone) values ( 'Rua um macaco na esquina 12', '123456', '51997002702'), ('Rua guapore 15', '223456', '53981371247');
insert into Products( Categoria, Preco, Custo, IndicadorSazonal, StatusAtivo ) values 
( 'Batatao', 15.50, 7.00, 'Alto', 1), 
('Dogao', 9.00, 5.00, 'Baixo', 1),
('Pastel de quiejo', 6.00, 2.00, 'Médio', 1),
('monster', 14.00, 6.00, 'Alto', 1),
('pizza', 35.00, 12.00, 'Alto', 1);

insert into Customers (Nome, Sobrenome, Email, Telefone, StatusFidelidade, DataCadastro) VALUES 
('Andrei', 'Krug', 'aiquedelicia@gmail.com', '460112233', 'Gold', '2025-01-15'),
('Alexandre', 'De Paula', 'de.paulinha@gmail.com', '460445566', 'Silver', '2025-03-10'),
('Yuri', 'Mendes', 'myuribeck@gmail.com', '460778899', 'Basic', '2026-02-01');

insert into Promotions (Codigo, PercentualDesconto, DataInicio, DataFim) VALUES 
('WELCOME10', 10, '2026-01-01', '2026-12-31'),
('SUMMER20', 20, '2026-06-01', '2026-08-31');

insert into Orders (IDLoja, IDCliente, IDPromocao, DataHora, MetodoPagamento, Canal, ValorDesconto) VALUES 
(1, 1, 1, '2026-09-08 08:30:00', 'Cartão', 'In-store', 1),
(1, 2, NULL, '2026-09-08 09:15:00', 'Dinheiro', 'In-store', 0),
(2, 3, 2, '2026-09-08 12:00:00', 'Pix', 'Online', 2),
(2, 1, NULL, '2026-09-08 14:45:00', 'Cartão', 'Online', 0);

INSERT INTO Orders (IDLoja, IDCliente, IDPromocao, DataHora, MetodoPagamento, Canal, ValorDesconto) 
VALUES (2, 1, NULL, '2026-09-08 14:45:00', 'Cartão', 'Online', 0);

INSERT INTO order_items (IDPedido, IDProduto, Quantidade, PrecoUnitario)
SELECT 4, ID, 2, Preco FROM Products WHERE ID = 2; -- 2x dogao

INSERT INTO order_items (IDPedido, IDProduto, Quantidade, PrecoUnitario)
SELECT 4, ID, 2, Preco FROM Products WHERE ID = 3; -- 2x monster