-- drop database Dveiculobd;

create database Dveiculobd;

use Dveiculobd;

CREATE TABLE movimentacoes (     
	id INT AUTO_INCREMENT PRIMARY KEY,     
	placa VARCHAR(10),     
	modelo VARCHAR(50),     
	hora_entrada DATETIME,     
	hora_saida DATETIME,     
	valor_pago DECIMAL(10,2) 
);

-- insert into movimentacoes (placa, modelo, hora_entrada, hora_saida, valor_pago) values
-- ('ABC-1234', 'Sedan', '2025-04-30 08:15:00', '2025-04-30 10:30:00', 10.00),
-- ('XYZ-5678', 'SUV', '2025-04-30 09:00:00', '2025-04-30 12:45:00', 20.00),
-- ('JKL-9101', 'Hatch', '2025-05-01 07:30:00', null, null), -- Ainda estacionado
-- ('MNO-1122', 'Caminhonete', '2025-05-01 10:00:00', null, null), -- Ainda estacionado
-- ('PQR-3344', 'Esportivo', '2025-04-29 15:50:00', '2025-04-29 18:00:00', 10.00);

insert into movimentacoes (placa, modelo, hora_entrada, hora_saida, valor_pago) values
('ACC-1334', 'Sedan', '2025-05-05 19:30:00', null, null);
SELECT * FROM movimentacoes;

RDL-4421', 'Honda HR-v